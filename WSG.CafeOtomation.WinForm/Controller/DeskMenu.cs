using MySqlX.XDevAPI.Relational;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Documents;
using System.Windows.Forms;
using WizardSoftwareGroupsFramework.Core.Entities.Concrete;
using WSG.CafeOtomation.Business.Abstract;
using WSG.CafeOtomation.Business.Concrete;
using WSG.CafeOtomation.DataAccess.Concrete.EntityFramework;
using WSG.CafeOtomation.Entities.Concrete;
using WSG.CafeOtomation.WinForm.Controller.Business;

namespace WSG.CafeOtomation.WinForm.Controller
{
    public partial class DeskMenu : Form
    {
        private Desk _desk;
        private User _user;
        private IProductCategoryService _productCategoryService;
        private IProductService _productService;
        private IOrderService _orderService;
        private IOrderDetailService _orderDetailService;
        private IOperationClaimService _operationClaimService;
        private TreeNode _newNode;
        public DeskMenu(Desk desk, User user)
        {
            InitializeComponent();
            _desk = desk;
            _user = user;
            _productCategoryService = new ProductCategoryManager(new EfProductCategoryDal());
            _productService = new ProductManager(new EfProductDal());
            _orderService = new OrderManager(new EfOrderDal());
            _orderDetailService = new OrderDetailManager(new EfOrderDetailDal());
            _operationClaimService = new OperationClaimManager(new EfOperationClaimDal());
            AccessControl();
            tVList();

            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.AutoSize = true;
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
            if (_orderService.GetByDesk(_desk.ID).Data.Where(c => !c.IsClose).Count() > 0)
            {
                var data = _orderService.GetByDesk(_desk.ID).Data.Where(c => !c.IsClose).SingleOrDefault();
                dGWOrders.DataSource = _orderDetailService.GetAll(x => x.OrderID == data.ID).Data;
                dGWOrders.Columns["ID"].Visible = false;
                dGWOrders.Columns["IsComplete"].Visible = false;
                lblTotalPay.Text = data.TotalPrice.ToString();
                pnlPay.Enabled = true;
            }
            try
            {
                PayChange();
            }
            catch
            {
            }
        }
        /// <summary>
        /// Odeme yapildiginda degisiklikler icin
        /// </summary>
        private void PayChange()
        {
            var data = _orderService.GetByDesk(_desk.ID).Data.Where(c => !c.IsClose).SingleOrDefault();
            dGWOrders.DataSource = _orderDetailService.GetAll(x => x.OrderID == data.ID).Data;
            if ((nUDPay.Value - data.TotalPrice) < 0)
            {
                lblChangeTitle.Text = "Ödenecek:";
            }
            else
            {
                lblChangeTitle.Text = "Para Üstü:";
            }
            lblChange.Text = (nUDPay.Value - data.TotalPrice).ToString();
        }
        private void AccessControl()
        {
            var access = _operationClaimService.GetByID(_user.ID);
            if (access.Data.Name == "Waiter")
            {
                pnlPay.Visible = false;
                pnlPay.Enabled = false;
                btnDelete.Visible = false;
                btnDelete.Enabled = false;
                nUDAmount.Visible = false;
                nUDAmount.Enabled = false;
                lblAmount.Visible = false;
                lblAmount.Enabled = false;
            }
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
            loadData();
        }
        /// <summary>
        /// Agac listesindeki urunlere cift tiklanildiginda siparislere eklenmesi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tVProducts_DoubleClick(object sender, EventArgs e)
        {
            var data = _orderService.GetByDesk(_desk.ID).Data.Where(c => !c.IsClose).SingleOrDefault();
            var product = _productService.GetByName(tVProducts.SelectedNode.Text).Data;
            if (product == null)
            {
                return;
            }
            DeskMenuHelper deskMenuHelper = new DeskMenuHelper(tVProducts.SelectedNode.Text);
            deskMenuHelper.ShowDialog();
            if (PropertyTraffics.ProductCount == null)
            {

            }
            else
            {
                if (data == null)
                {
                    data = new Order
                    {
                        CreateUserID = _user.ID,
                        DeskID = _desk.ID,
                        IsClose = false,
                        TotalPrice = product.UnitPrice
                    };
                    MessageBox.Show(_orderService.Add(data).Message);
                }
                var dataChilds = _orderDetailService.GetBy(x => x.Product.Name == tVProducts.SelectedNode.Text && x.OrderID == data.ID).Data;
                if (dataChilds != null)
                {
                    dataChilds.Amount += 1;
                    dataChilds.TotalPrice += product.UnitPrice;
                    data.TotalPrice += product.UnitPrice;
                    _orderDetailService.Update(dataChilds);
                    _orderService.Update(data);
                }
                else
                {
                    int count = (int)PropertyTraffics.ProductCount;
                    dataChilds = new OrderDetail
                    {
                        OrderID = data.ID,
                        ProductID = product.ID,
                        Amount = count,
                        TotalPrice = product.UnitPrice * count
                    };
                    data.TotalPrice += dataChilds.TotalPrice;
                    _orderDetailService.Add(dataChilds);
                    _orderService.Update(data);
                }
                loadData();
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
            var data = _orderService.GetByDesk(_desk.ID).Data.Where(c => !c.IsClose).SingleOrDefault();
            var product = _productService.GetByName(dGWOrders.CurrentRow.Cells["Product"].Value.ToString()).Data;
            var dataChild = _orderDetailService.GetBy(x => x.Product.Name == product.Name && x.OrderID == data.ID).Data;
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
            dGWOrders.CurrentCell = dGWOrders.Rows[i].Cells[1];
        }
        /// <summary>
        /// DataGridView da hucrete tiklandiginda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dGWOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pnlControl.Enabled = true;
            nUDAmount.Value = decimal.Parse(dGWOrders.CurrentRow.Cells["Amount"].Value.ToString());
            lblProductTitle.Text = dGWOrders.CurrentRow.Cells["Product"].Value.ToString();
            lblUnitPrice.Text = Convert.ToDecimal(dGWOrders.CurrentRow.Cells["TotalPrice"].Value).ToString("#.00 ₺");
            if (Convert.ToBoolean(dGWOrders.CurrentRow.Cells["IsComplete"].Value))
            {
                btnSuccessOrder.BackColor = Color.OrangeRed;
                btnSuccessOrder.Text = "İstenen Sipariş Verilmedi";
            }
            else
            {
                btnSuccessOrder.BackColor = Color.MediumSeaGreen;
                btnSuccessOrder.Text = "İstenen Siparis Verildi";
            }
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
                if (Convert.ToBoolean(row.Cells[4].Value))
                {
                    row.DefaultCellStyle.BackColor = Color.MediumSeaGreen;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }

            }
        }

        #region Buttons

        private void btnSuccessOrder_Click(object sender, EventArgs e)
        {
            var data = _orderDetailService.GetBy(x => x.ID == Convert.ToInt32(dGWOrders.CurrentRow.Cells["ID"].Value)).Data;
            data.IsComplete = true;
            _orderDetailService.Update(data);
            loadData();
        }

        private void btnPaySuccess_Click(object sender, EventArgs e)
        {
            var dataSource = _orderService.GetByDesk(_desk.ID).Data.Where(c => !c.IsClose).SingleOrDefault();
            if (decimal.Parse(lblChange.Text) >= 0)
            {
                var data = new Order
                {
                    ID = dataSource.ID,
                    UpdateUserID = _user.ID,
                    Change = decimal.Parse(lblChange.Text),
                    CreateUserID = dataSource.CreateUserID,
                    DeskID = dataSource.DeskID,
                    IsClose = true,
                    Paid = nUDPay.Value,
                    TotalPrice = dataSource.TotalPrice
                };
                _orderService.Update(data);
                this.Close();
            }
            else
            {
                MessageBox.Show(lblChange.Text + " Daha ödenmesi gerekiyor!");
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
            var order = _orderService.GetByDesk(_desk.ID).Data.Where(c => !c.IsClose).SingleOrDefault();
            var dataChilds = _orderDetailService.GetByOrderNo(order.ID).Data;
            if (dataChilds.Count <= 0)
            {
                _orderService.Delete(order);
            }
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Dispose();
            this.Close();
        }
        #endregion

        #endregion
    }
}
