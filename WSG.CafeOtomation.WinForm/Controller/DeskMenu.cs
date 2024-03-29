﻿using Microsoft.PointOfService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WizardSoftwareGroupsFramework.Core.Entities.Concrete;
using WSG.CafeOtomation.Business.Abstract;
using WSG.CafeOtomation.Business.Concrete;
using WSG.CafeOtomation.DataAccess.Concrete.EntityFramework;
using WSG.CafeOtomation.Entities.Concrete;
using WSG.CafeOtomation.WinForm.Controller.Business;

namespace WSG.CafeOtomation.WinForm.Controller
{
    public partial class DeskMenu : Form, ISynchronizeInvoke
    {
        private DateTime _nowTime;
        private Desk _desk;
        private User _user;
        private IProductCategoryService _productCategoryService;
        private IProductService _productService;
        private IOrderService _orderService;
        private IOrderDetailService _orderDetailService;
        private IUserTitleService _userTitleService;
        private IOrderDetailTimeLogService _orderDetailTimeLogService;
        private IPayTypeService _payTypeService;
        private IOrderPaymentService _orderPaymentService;
        private TreeNode _newNode;
        private PosPrinter posPrinter;
        public DeskMenu(Desk desk, User user, IUserTitleService userTitleService, IOrderDetailTimeLogService orderDetailTimeLogService)
        {
            InitializeComponent();
            _desk = desk;
            _user = user;
            _productCategoryService = new ProductCategoryManager(new EfProductCategoryDal());
            _productService = new ProductManager(new EfProductDal());
            _orderService = new OrderManager(new EfOrderDal());
            _orderDetailService = new OrderDetailManager(new EfOrderDetailDal());
            _payTypeService = new PayTypeManager(new EfPayTypeDal());
            _orderPaymentService = new OrderPaymentManager(new EfOrderPaymentDal());
            _userTitleService = userTitleService;
            _orderDetailTimeLogService = orderDetailTimeLogService;
            AccessControl();
            tVList();

            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.AutoSize = true;
        }
        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert(5000);
            frm.ShowAlert(msg, type);
        }
        /// <summary>
        /// Urunlerin listesinin kategorisi ile birlikte gelen datalar
        /// </summary>
        private void tVList()
        {
            if (_productCategoryService.GetAll().Data.Count > 0)
            {
                int i = 0;
                foreach (var row in _productCategoryService.GetAll().Data)
                {
                    _newNode = new TreeNode(row.Name.ToString());
                    tVProducts.Font = new Font("Trebuchet MS", 20);
                    tVProducts.Nodes.Add(_newNode);
                    foreach (var child in _productService.GetByCategory(row.ID).Data)
                    {
                        _newNode = new TreeNode(child.Name.ToString());
                        tVProducts.Nodes[i].Nodes.Add(_newNode);
                    }
                    i++;
                }
            }
        }
        /// <summary>
        /// Masa icindeki siparislerin datalari
        /// </summary>
        private void loadData()
        {
            if (_orderService.GetByDesk(_desk.ID).Data.Where(c => c.OrderPayStatus == OrderPayStatus.Open).Count() > 0)
            {
                var dataDetails = _orderService.GetByOrderNo((int)cmBxOrders.SelectedItem).Data;
                dGWOrders.DataSource = _orderDetailService.GetAll(x => x.OrderID == dataDetails.ID).Data;
                dGWOrders.Columns["OrderID"].Visible = false;
                dGWOrders.Columns["ProductID"].Visible = false;
                dGWOrders.Columns["CreateTime"].Visible = false;
                decimal total = dataDetails.TotalPrice - _orderPaymentService.GetSafeAll(x => x.OrderID == dataDetails.ID).Data.Sum(x => x.Value);
                lblTotalPay.Text = total.ToString("#.00 TL");
                pnlPay.Enabled = true;
            }
        }
        /// <summary>
        /// Odeme yapildiginda degisiklikler icin
        /// </summary>
        private void PayChange()
        {
            var data = _orderService.GetByOrderNo((int)cmBxOrders.SelectedItem).Data;
            dGWOrders.DataSource = _orderDetailService.GetAll(x => x.OrderID == data.ID).Data;
            if (((data.TotalPrice - _orderPaymentService.GetSafeAll(x => x.OrderID == data.ID).Data.Sum(x => x.Value)) - nUDPay.Value) > data.TotalPrice)
            {
                lblChangeTitle.Text = "Ödenecek:";
            }
            else if (((data.TotalPrice - _orderPaymentService.GetSafeAll(x => x.OrderID == data.ID).Data.Sum(x => x.Value)) - nUDPay.Value) == data.TotalPrice)
            {
                lblChangeTitle.Text = "";
            }
            else
            {
                lblChangeTitle.Text = "Para Üstü:";
            }
            lblChange.Text = ((data.TotalPrice - _orderPaymentService.GetSafeAll(x => x.OrderID == data.ID).Data.Sum(x => x.Value)) - nUDPay.Value).ToString();
        }
        /// <summary>
        /// Kullanici yetki kontrolleri
        /// </summary>
        private void AccessControl()
        {
            var access = _userTitleService.GetByUserID(_user.ID);
            if (access.Data.AccessAuth == (AccessAuth)5)
            {
                btnDelete.Visible = false;
                btnDelete.Enabled = false;
                nUDAmount.Visible = false;
                nUDAmount.Enabled = false;
                lblAmount.Visible = false;
                lblAmount.Enabled = false;
            }
        }
        /// <summary>
        /// Garsonun gormesi gereken sol buton kontrolu
        /// </summary>
        private void LeftProcessButton()
        {
            btnSuccessOrder.Enabled = false;
            pnlControl.Enabled = true;
            pnlControl.Visible = true;
            btnSuccessOrder.Visible = true;
            if (Convert.ToInt16(dGWOrders.CurrentRow.Cells["EOrderStatus"].Value) == 3)
            {
                pnlControl.Visible = false;
            }
            else if (Convert.ToInt16(dGWOrders.CurrentRow.Cells["EOrderStatus"].Value) == 2)
            {
                btnSuccessOrder.Enabled = true;
                btnSuccessOrder.Text = "Siparişi Teslim Ettim";
                btnSuccessOrder.BackColor = Color.MediumSeaGreen;
            }
            else if (Convert.ToInt16(dGWOrders.CurrentRow.Cells["EOrderStatus"].Value) == 1)
            {
                btnSuccessOrder.Enabled = false;
                btnSuccessOrder.BackColor = Color.Orange;
                btnSuccessOrder.Text = "Sipariş Hazırlanıyor";
            }
            else
            {
                btnSuccessOrder.Enabled = false;
                btnSuccessOrder.BackColor = Color.LightGray;
                btnSuccessOrder.ForeColor = Color.White;
                btnSuccessOrder.Text = "İstenen Siparis Bekliyor";
            }
        }

        private async Task PosWriteAsync()
        {
            var order = _orderService.GetByOrderNo((int)cmBxOrders.SelectedItem).Data;
            var explorer = new PosExplorer(this);
            var deviceInfo = explorer.GetDevice(DeviceType.PosPower);
            if (deviceInfo == null)
            {
                Alert("Yazıcı bulunamadı!", Form_Alert.enmType.Error);
                return;
            }

            posPrinter = (PosPrinter)explorer.CreateInstance(deviceInfo);
            posPrinter.Open();
            posPrinter.Claim(500);
            posPrinter.DeviceEnabled = true;

            posPrinter.ErrorEvent += (s, evt) => {
                if (evt.ErrorCode == ErrorCode.NoService)
                {
                    MessageBox.Show("Yazıcı bağlantısı yok!");
                    return;
                }
                if (evt.ErrorCode == ErrorCode.Closed)
                {
                    MessageBox.Show("Yazıcı kapalı!");
                }
            };

            posPrinter.StatusUpdateEvent += (s, evt) =>
            {
                if (evt.Status == PosPrinter.StatusCoverOpen)
                {
                    MessageBox.Show("Yazıcının kağıt kapağı açıldı");
                }
                if (evt.Status == PosPrinter.StatusCoverOK)
                {
                    MessageBox.Show("Yazıcının kağıt kapağı kapandı");
                }
                if (evt.Status == PosPrinter.StatusJournalCartridgeEmpty)
                {
                    MessageBox.Show("Yazıcının kartuşu bitmek üzere");
                }
            };

            posPrinter.PrintNormal(PrinterStation.Slip, "Smoke-in" + Environment.NewLine);
            posPrinter.PrintNormal(PrinterStation.Slip, "********************************************************************" + Environment.NewLine);
            posPrinter.PrintNormal(PrinterStation.Slip, "HESAP KODU: " + order.ID + Environment.NewLine); 
            //posPrinter.PrintBarCode(PrinterStation.Slip, order.ID.ToString(), BarCodeSymbology.Ean128, 40, 200, 1, BarCodeTextPosition.Above);
            posPrinter.PrintNormal(PrinterStation.Slip, "********************************************************************" + Environment.NewLine);
            foreach (var item in _orderDetailService.GetAll(x => x.OrderID == order.ID).Data)
            {
                posPrinter.PrintNormal(PrinterStation.Slip, item.Product + "\t\t\t" + item.Amount + "\t\t" + item.TotalPrice + "₺" + Environment.NewLine);
            }
            posPrinter.PrintNormal(PrinterStation.Slip, "********************************************************************" + Environment.NewLine);
            posPrinter.PrintNormal(PrinterStation.Slip, "Toplam:\t\t\t\t" + order.TotalPrice + "₺" + Environment.NewLine);

            posPrinter.CutPaper(100); //kağıdı tam kes, 100 yerine 50 yazarsan yarısına kadar keser
        }

        #region Events
        /// <summary>
        /// Masa yuklendigindeki olay dizesi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeskMenu_Load(object sender, EventArgs e)
        {
            lblTitle.Text = _desk.DeskNo;
            try
            {
                foreach (var item in _payTypeService.GetAll().Data)
                {
                    cmBxPayType.Items.Add(item.Name);
                }
                cmBxPayType.SelectedIndex = 0;
                ComboBoxOrders();
                loadData();
                dGWOrders.CurrentCell = dGWOrders[1, 0];
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Debug.WriteLine(ex);
            }
            catch { }
        }

        private void ComboBoxOrders(int index = 0)
        {
            cmBxOrders.Items.Clear();
            var data = _orderService.GetByClose(OrderPayStatus.Open).Data.Where(x => x.DeskID == _desk.ID);
            foreach (var item in data)
            {
                cmBxOrders.Items.Add(item.ID);
            }
            cmBxOrders.SelectedIndex = index;
        }

        /// <summary>
        /// Agac listesindeki urunlere cift tiklanildiginda siparislere eklenmesi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tVProducts_DoubleClick(object sender, EventArgs e)
        {
            Order data = null;
            OrderDetail dataChilds = null;
            if (cmBxOrders.SelectedItem != null)
            {
                data = _orderService.GetByOrderNo((int)cmBxOrders.SelectedItem).Data;
            }
            var product = _productService.GetByName(tVProducts.SelectedNode.Text).Data;
            if (product == null)
            {
                return;
            }
            DeskMenuHelper deskMenuHelper = new DeskMenuHelper(tVProducts.SelectedNode.Text);
            deskMenuHelper.ShowDialog();
            if (PropertyTraffics.ProductCount == null)
            {
                return;
            }
            else
            {
                if (data == null)
                {
                    data = new Order
                    {
                        CreateUserID = _user.ID,
                        DeskID = _desk.ID,
                        OrderPayStatus = OrderPayStatus.Open,
                        TotalPrice = product.UnitPrice,
                        CreateDate = DateTime.Now
                    };
                    _orderService.Add(data);
                    ComboBoxOrders();
                    timerOrderList.Enabled = true;
                    int count = (int)PropertyTraffics.ProductCount;
                    dataChilds = new OrderDetail
                    {
                        OrderID = data.ID,
                        ProductID = product.ID,
                        Amount = count,
                        TotalPrice = product.UnitPrice * count,
                        CreateUserID = _user.ID,
                        CreateDate = DateTime.Now
                    };
                }
                else
                {
                    int count = (int)PropertyTraffics.ProductCount;
                    dataChilds = new OrderDetail
                    {
                        OrderID = data.ID,
                        ProductID = product.ID,
                        Amount = count,
                        TotalPrice = product.UnitPrice * count,
                        CreateUserID = _user.ID,
                        CreateDate = DateTime.Now
                    };
                    data.TotalPrice += dataChilds.TotalPrice;
                }
                var result = _orderDetailService.Add(dataChilds);
                _orderService.Update(data);
                loadData();
                if (result.Success == true)
                    Alert(result.Message, Form_Alert.enmType.Success);
                else
                    Alert(result.Message, Form_Alert.enmType.Error);
            }
        }
        /// <summary>
        /// Agac listesinde fiyatlari getirmek icin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tVProducts_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var data = _productService.GetByName(tVProducts.SelectedNode.Text);
            if (data.Data != null)
            {
                lblProductTitle.Text = data.Data.Name;
                lblUnitPrice.Text = data.Data.UnitPrice.ToString("#.00 ₺");
            }
        }
        /// <summary>
        /// Urun bulmak icin bir textbox changed olayi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBxFind_TextChanged(object sender, EventArgs e)
        {
            foreach (TreeNode node in tVProducts.Nodes[1].Nodes)
            {

                if (tVProducts.Nodes.Find(txtBxFind.Text, true) != null)
                {

                    tVProducts.SelectedNode = node;

                    break;

                }
            }
        }
        /// <summary>
        /// Odenecek numeric text box changed olayi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nUDPay_ValueChanged(object sender, EventArgs e)
        {
            PayChange();
        }
        /// <summary>
        /// Urun adetini degistirmek icin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nUDAmount_ValueChanged(object sender, EventArgs e)
        {
            var data = _orderService.GetByOrderNo((int)cmBxOrders.SelectedItem).Data;
            var product = _productService.GetByID(Convert.ToInt32(dGWOrders.CurrentRow.Cells["ProductID"].Value)).Data;
            var dataChild = _orderDetailService.GetBy(x => x.ProductID == product.ID && x.OrderID == data.ID && x.ID == Convert.ToInt32(dGWOrders.CurrentRow.Cells["ID"].Value)).Data;
            if (dataChild != null)
            {
                dataChild.Amount = (int)nUDAmount.Value;
                dataChild.TotalPrice = dataChild.Amount * product.UnitPrice;
                _orderDetailService.Update(dataChild);
                data.TotalPrice = _orderDetailService.GetAll(x => x.OrderID == data.ID).Data.Sum(x => x.TotalPrice);
                _orderService.Update(data);
            }
            var i = dGWOrders.CurrentCell.RowIndex;
            loadData();
            dGWOrders.CurrentCell = dGWOrders.Rows[i].Cells[0];
        }
        /// <summary>
        /// DataGridView da hucrete tiklandiginda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dGWOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var order = _orderService.GetByOrderNo((int)cmBxOrders.SelectedItem).Data;
            string totalAmount = Convert.ToDecimal(_orderDetailService.GetAll(x => x.OrderID == order.ID && x.ProductID == (int)dGWOrders.CurrentRow.Cells["ProductID"].Value).Data.Sum(x => x.Amount)).ToString("# Adet");
            if (dGWOrders.SelectedRows.Count == dGWOrders.Rows.Count)
                btnDeskSelectedMove.Enabled = false;
            else
                btnDeskSelectedMove.Enabled = true;
            if (dGWOrders.SelectedRows.Count > 1)
            {
                btnDeskSelectedMove.Text = "Siparişleri Taşı";
                lblUnitPrice.Text = Convert.ToDecimal(dGWOrders.SelectedRows.Cast<DataGridViewRow>().Sum(x => (decimal)x.Cells["TotalPrice"].Value)).ToString();
                timerOrderList.Enabled = false;
            }
            else
            {
                btnDeskSelectedMove.Text = "Siparişi Taşı";
                timerOrderList.Enabled = true;
                nUDAmount.Value = decimal.Parse(dGWOrders.CurrentRow.Cells["Amount"].Value.ToString());
                lblProductTitle.Text = totalAmount + ' ' + dGWOrders.CurrentRow.Cells["Product"].Value.ToString();
                lblUnitPrice.Text = Convert.ToDecimal(_orderDetailService.GetAll(x => x.OrderID == order.ID && x.ProductID == (int)dGWOrders.CurrentRow.Cells["ProductID"].Value).Data.Sum(x => x.TotalPrice)).ToString("#.00 ₺");
            }
            LeftProcessButton();
        }
        /// <summary>
        /// DataGridView Formatlari icin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dGWOrders_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dGWOrders.Columns["TotalPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dGWOrders.Columns["TotalPrice"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dGWOrders.Columns["TotalPrice"].HeaderCell.Style.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            dGWOrders.Columns["TotalPrice"].DefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            dGWOrders.Columns["TotalPrice"].DefaultCellStyle.Format = "#.00 ₺";
            foreach (DataGridViewRow row in dGWOrders.Rows)
            {
                if (Convert.ToInt32(row.Cells[4].Value) == 3)
                {
                    row.DefaultCellStyle.BackColor = Color.MediumSeaGreen;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }
                else if (Convert.ToInt32(row.Cells[4].Value) == 1)
                {
                    row.DefaultCellStyle.BackColor = Color.Orange;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }
                else if (Convert.ToInt32(row.Cells[4].Value) == 2)
                {
                    row.DefaultCellStyle.BackColor = Color.MediumSlateBlue;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }
                else
                {
                }
            }
        }
        /// <summary>
        /// Timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerOrderList_Tick(object sender, EventArgs e)
        {
            if (dGWOrders.Rows.Count <= 0)
            {
                return;
            }
            try
            {
                int i = dGWOrders.CurrentCell.RowIndex;
                int c = dGWOrders.CurrentCell.ColumnIndex;
                loadData();
                dGWOrders.CurrentCell = dGWOrders.Rows[i].Cells[c];
                LeftProcessButton();
            }
            catch (NullReferenceException ex)
            {
                Debug.WriteLine(ex);
                timerOrderList.Enabled = false;
            }
            catch { }
        }

        private void cmBxPayType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmBxPayType.SelectedIndex == 0)
            {
                btnPaySuccess.Enabled = false;
            }
            else
            {
                btnPaySuccess.Enabled = true;
            }
        }
        #region Buttons

        private void btnSuccessOrder_Click(object sender, EventArgs e)
        {
            _nowTime = DateTime.Now;
            TimeSpan begintoSpan = _nowTime.Subtract(DateTime.ParseExact(dGWOrders.CurrentRow.Cells["CreateTime"].Value.ToString(), "HH:mm:ss", null));
            var data = _orderDetailService.GetBy(x => x.ID == Convert.ToInt32(dGWOrders.CurrentRow.Cells["ID"].Value)).Data;
            data.EOrderStatus = (OrderStatus)3;
            data.UpdateDate = DateTime.Now;
            data.UpdateUserID = _user.ID;
            _orderDetailService.Update(data);
            var i = dGWOrders.CurrentCell.RowIndex;
            loadData();
            dGWOrders.CurrentCell = dGWOrders.Rows[i].Cells[1];
            btnSuccessOrder.Visible = false;

            var minute = _orderDetailTimeLogService.GetBy(x => x.OrderDetailID == data.ID && x.OrderStatus == OrderStatus.AtWaiters).Data.CreateDate.ToString("dd.MM.yyyy HH:mm:ss");
            begintoSpan = _nowTime.Subtract(DateTime.ParseExact(minute, "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture));
            var log = new OrderDetailTimeLog
            {
                UserID = _user.ID,
                OrderStatus = OrderStatus.Complete,
                OrderDetailID = data.ID,
                CreateDate = _nowTime,
                Minute = (decimal)begintoSpan.TotalMinutes,
                Second = (decimal)begintoSpan.TotalSeconds
            };
            _orderDetailTimeLogService.Add(log);
        }

        private async void btnPaySuccess_Click(object sender, EventArgs e)
        {
            PayChange();
            var dataSource = _orderService.GetByOrderNo((int)cmBxOrders.SelectedItem).Data;
            var orderPayType = _payTypeService.GetBy(x => x.Name == (string)cmBxPayType.SelectedItem).Data;
            var orderPayment = new OrderPayment
            {
                OrderID = dataSource.ID,
                PayTypeID = orderPayType.ID,
                Value = nUDPay.Value,
                Balance = decimal.Parse(lblChange.Text)
            };
            _orderPaymentService.Add(orderPayment);
            if (_orderPaymentService.GetSafeAll(x => x.OrderID == dataSource.ID).Data.Sum(x => x.Value) >= dataSource.TotalPrice)
            {
                dataSource.UpdateUserID = _user.ID;
                dataSource.UpdateDate = DateTime.Now;
                dataSource.OrderPayStatus = OrderPayStatus.Paid;
                _orderService.Update(dataSource);
                //await PosWriteAsync();
                if (_orderService.GetByDesk(_desk.ID).Data.Where(x => x.OrderPayStatus == OrderPayStatus.Open).Count() > 0)
                    ComboBoxOrders();
                else
                    this.Close();
            }
        }

        private void btnPayCustomer_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var data = new OrderDetail
            {
                ID = (int)dGWOrders.Rows[dGWOrders.CurrentCell.RowIndex].Cells[0].Value
            };
            _orderDetailService.Delete(data);
            var order = _orderService.GetByDesk(_desk.ID).Data.Where(c => c.OrderPayStatus == OrderPayStatus.Open).SingleOrDefault();
            var dataChilds = _orderDetailService.GetByOrderNo(order.ID).Data;
            if (dataChilds.Count <= 0)
            {
                _orderService.Delete(order);
                this.Dispose();
                this.Close();
            }
            loadData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Dispose();
            this.Close();
        }

        private async void btnPrint_Click(object sender, EventArgs e)
        {
            await PosWriteAsync();
        }

        private async void btnPrintSelect_Click(object sender, EventArgs e)
        {
            await PosWriteAsync();
        }

        private void btnDeskMove_Click(object sender, EventArgs e)
        {
            var data = _orderService.GetByOrderNo((int)cmBxOrders.SelectedItem).Data;
            DeskMenuMoveHelper deskMenuMoveHelper = new DeskMenuMoveHelper(_user, data, _orderService, _orderDetailService);
            bool IsMove = false;
            deskMenuMoveHelper.FormClosing += (o, ev) =>
            {
                IsMove = deskMenuMoveHelper.IsMove;
            };
            deskMenuMoveHelper.ShowDialog();
            if (IsMove)
                this.Close();
        }

        private void btnDeskSelectedMove_Click(object sender, EventArgs e)
        {
            List<int> ID = new List<int>();
            foreach (DataGridViewRow item in dGWOrders.SelectedRows)
            {
                ID.Add((int)item.Cells["ID"].Value);
            }
            var data = _orderService.GetByOrderNo((int)cmBxOrders.SelectedItem).Data;
            DeskMenuMoveHelper deskMenuMoveHelper = new DeskMenuMoveHelper(_user, ID, _orderService, _orderDetailService);
            deskMenuMoveHelper.ShowDialog();
            loadData();
        }

        private void btnHalf_Click(object sender, EventArgs e)
        {
            int index = cmBxOrders.SelectedIndex;
            HalfManage halfManage = new HalfManage(_orderService, _orderDetailService, _productService, _user, (int)cmBxOrders.SelectedItem, _desk.ID);
            halfManage.ShowDialog();
            ComboBoxOrders(index);
            loadData();
        }
        #endregion

        #endregion
    }
}
