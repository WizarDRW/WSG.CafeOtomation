using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Media;
using System.Windows.Forms;
using WizardSoftwareGroupsFramework.Core.Entities.Concrete;
using WSG.CafeOtomation.Business.Abstract;
using WSG.CafeOtomation.Business.Concrete;
using WSG.CafeOtomation.DataAccess.Concrete.EntityFramework;
using WSG.CafeOtomation.Entities.Concrete;
using WSG.CafeOtomation.WinForm.Controller.Business;

namespace WSG.CafeOtomation.WinForm.Controller
{
    public partial class Menu : Form
    {
        private DateTime _nowTime;
        private User _user;
        private DeskMenu _desk;
        private IProductCategoryService _productCategoryService;
        private IProductService _productService;
        private IProductImageService _productImageService;
        private IDeskService _deskService;
        private IOrderService _orderService;
        private IOrderDetailService _orderDetailService;
        private IOrderDetailTypeService _orderDetailTypeService;
        private IUserTitleService _userTitleService;
        private IOrderDetailTimeLogService _orderDetailTimeLogService;
        private int _sessionMinutesOption;
        private int _count;
        public Menu(User user)
        {
            InitializeComponent();
            _user = user;
            _productCategoryService = new ProductCategoryManager(new EfProductCategoryDal());
            _productService = new ProductManager(new EfProductDal());
            _productImageService = new ProductImageManager(new EfProductImageDal());
            _deskService = new DeskManager(new EfDeskDal());
            _orderService = new OrderManager(new EfOrderDal());
            _orderDetailService = new OrderDetailManager(new EfOrderDetailDal());
            _userTitleService = new UserTitleManager(new EfUserTitleDal());
            _orderDetailTimeLogService = new OrderDetailTimeLogManager(new EfOrderDetailTimeLogDal());
            _orderDetailTypeService = new OrderDetailTypeManager(new EfOrderDetailTypeDal());
            _sessionMinutesOption = 2;

            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
        }
        public void Desk(string find = "")
        {
            tPDesk.Controls.Clear();
            int left = 25;
            int top = 25;
            int i = 1;
            foreach (var d in _deskService.GetAll(x => x.DeskNo.Contains(find)).Data)
            {
                Button button = new Button();
                if ((left + 200) > tPDesk.Width)
                {
                    left = 25;
                    top += 230;
                }
                button.Enabled = true;
                ButtonColor(button, d.ID);
                button.Font = new Font("Trebuchet MS", 25f, FontStyle.Regular);
                button.Text = d.DeskNo;
                button.Location = new Point(left, top);
                button.Size = new Size(200, 200);
                button.FlatStyle = FlatStyle.Popup;
                i += 1;
                left += 230;
                button.Click += Button_Click;
                tPDesk.Controls.Add(button);
            }
        }
        private void Button_Click(object sender, EventArgs e)
        {
            Button button;
            button = sender as Button;
            var data = _deskService.GetByNo(button.Text).Data;
            _desk = new DeskMenu(data, _user, _userTitleService, _orderDetailTimeLogService);
            _desk.ShowDialog();
            int id = _deskService.GetByNo(button.Text).Data.ID;
            ButtonColor(button, id);
        }
        private void ButtonColor(Button button, int id)
        {
            var data = _orderService.GetByDesk(id).Data.Where(c => c.OrderPayStatus == OrderPayStatus.Open);
            if (data.Count() > 0)
            {
                button.BackColor = Color.LawnGreen;
                button.ForeColor = Color.White;
            }
            else
            {
                button.BackColor = Color.Gray;
                button.ForeColor = Color.White;
            }
        }
        public void OrderList()
        {
            dGVOrderDetails.DataSource = _orderDetailService.GetOrderDetailAll(x => x.EOrderStatus != OrderStatus.Complete).Data;
            dGVOrderDetails.Columns["ID"].Visible = false;
        }
        public void AccessControl()
        {
            var access = _userTitleService.GetByUserID(_user.ID);
            _sessionMinutesOption = access.Data.SessionMinute * 60;
            PropertyTraffics.SessionSecond = _sessionMinutesOption;
            if (access.Data.AccessAuth == (AccessAuth)5)
            {
                tSOrder.Enabled = false;
                grBxAboutOrderDetailProcess.Enabled = false;
            }
            timerNow.Enabled = true;
        }
        public int Alert(int count, string msg, Form_Alert.enmType enmType)
        {
            Form_Alert frm = new Form_Alert(10000);
            frm.ShowAlert(msg, enmType);
            SystemSounds.Beep.Play();
            return count;
        }
        public void OrderType()
        {
            int id = int.Parse(dGVOrderDetails.CurrentRow.Cells["ID"].Value.ToString());
            dGVOrderTypes.DataSource = _orderDetailTypeService.GetAll(x => x.OrderDetailID == id).Data.GroupBy(x => x.ProductType).Select(x => new { Adet = x.Count(), Tip = x.Key }).ToList();
            //dGVOrderTypes.Columns["ID"].Visible = false;
        }

        #region Events
        private void Menu_Load(object sender, EventArgs e)
        {
            lblUser.Text = _user.FirstName + ' ' + _user.LastName;
            AccessControl();
            try
            {
                OrderList();
                dGVOrderDetails.CurrentCell = dGVOrderDetails[0, 1];
                timerLoadOrderDetails.Enabled = true;
            }
            catch
            {
            }
            foreach (var pC in _productCategoryService.GetAll().Data)
            {
                lBxPCategory.Items.Add(pC.Name);
            }

            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.AutoSize = true;
        }
        private void lBxPCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = _productCategoryService.GetByName(lBxPCategory.SelectedItem.ToString()).Data.ID;
            dGwProductList.DataSource = _productService.GetByCategory(id).Data;
            lblCount.Text = dGwProductList.Rows.Count.ToString();
            gBxProductDetail.Visible = false;
        }
        private void dGwProductList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = int.Parse(dGwProductList.CurrentRow.Cells["ID"].Value.ToString());
            var productImage = _productImageService.GetByProduct(id).Data;
            var product = _productService.GetByID(id).Data;


            gBxProductDetail.Visible = true;
            gBxProductDetail.Text = "Ürün Detay Bilgisi / " + DateTime.Now.ToString("dd MMMM yyyy dddd");
            pBxImage.Load(productImage.FirstOrDefault(x => x.IsCover).Path.ToString());
            lblProductName.Text = product.Name;
            lblStockAmount.Text = product.StockAmount.ToString();
        }
        private void dGVOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dGVOrderDetails.Rows.Count == 0)
            {
                return;
            }
            int id = int.Parse(dGVOrderDetails.CurrentRow.Cells["ID"].Value.ToString());
            lblOrderNo.Text = dGVOrderDetails.CurrentRow.Cells["ID"].Value.ToString();
            lblProductInfoName.Text = dGVOrderDetails.CurrentRow.Cells["Product"].Value.ToString();
            lblDeskInfo.Text = dGVOrderDetails.CurrentRow.Cells["DeskNo"].Value.ToString();
            lblAmountInfo.Text = dGVOrderDetails.CurrentRow.Cells["Amount"].Value.ToString();
            lblTimeInfo.Text = dGVOrderDetails.CurrentRow.Cells["CreateTime"].Value.ToString();
            if ((OrderStatus)dGVOrderDetails.CurrentRow.Cells["EOrderStatus"].Value == OrderStatus.Waiting)
            {
                cmBxOrderStatus.Items.Remove(OrderStatus.AtWaiters);
                if (!cmBxOrderStatus.Items.Contains(OrderStatus.Waiting))
                {
                    cmBxOrderStatus.Items.Add(OrderStatus.Waiting);
                }
                if (!cmBxOrderStatus.Items.Contains(OrderStatus.Prepares))
                {
                    cmBxOrderStatus.Items.Add(OrderStatus.Prepares);
                }
            }
            else if ((OrderStatus)dGVOrderDetails.CurrentRow.Cells["EOrderStatus"].Value == OrderStatus.Prepares)
            {
                cmBxOrderStatus.Items.Remove(OrderStatus.Waiting);
                if (!cmBxOrderStatus.Items.Contains(OrderStatus.Prepares))
                {
                    cmBxOrderStatus.Items.Add(OrderStatus.Prepares);
                }
                if (!cmBxOrderStatus.Items.Contains(OrderStatus.AtWaiters))
                {
                    cmBxOrderStatus.Items.Add(OrderStatus.AtWaiters);
                }
            }
            else
            {
                cmBxOrderStatus.Items.Remove(OrderStatus.Prepares);
                if (!cmBxOrderStatus.Items.Contains(OrderStatus.AtWaiters))
                {
                    cmBxOrderStatus.Items.Add(OrderStatus.AtWaiters);
                }
            }
            cmBxOrderStatus.SelectedItem = dGVOrderDetails.CurrentRow.Cells["EOrderStatus"].Value;
            timerLoadOrderDetails.Enabled = true;
            OrderType();
        }
        private void dGVOrderDetails_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dGVOrderDetails.Columns["TotalPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dGVOrderDetails.Columns["TotalPrice"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dGVOrderDetails.Columns["TotalPrice"].HeaderCell.Style.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            dGVOrderDetails.Columns["TotalPrice"].DefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            dGVOrderDetails.Columns["TotalPrice"].DefaultCellStyle.Format = "#.00 ₺";
            foreach (DataGridViewRow row in dGVOrderDetails.Rows)
            {
                if (Convert.ToInt32(row.Cells["EOrderStatus"].Value) == 0)
                {
                    row.DefaultCellStyle.BackColor = Color.LightGoldenrodYellow;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
                else if (Convert.ToInt32(row.Cells["EOrderStatus"].Value) == 1)
                {
                    row.DefaultCellStyle.BackColor = Color.Orange;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
                else if (Convert.ToInt32(row.Cells["EOrderStatus"].Value) == 2)
                {
                    row.DefaultCellStyle.BackColor = Color.Blue;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }
            }
        }
        private void timerLoadOrderDetails_Tick(object sender, EventArgs e)
        {
            _nowTime = DateTime.Now;
            int scroll = dGVOrderDetails.FirstDisplayedScrollingRowIndex;
            if (dGVOrderDetails.Rows.Count == 0)
            {
                return;
            }
            int i = dGVOrderDetails.CurrentCell.RowIndex;
            int r = dGVOrderDetails.CurrentCell.ColumnIndex;
            OrderList();
            try
            {
                TimeSpan span = _nowTime.Subtract(DateTime.ParseExact(dGVOrderDetails.Rows[i].Cells["CreateTime"].Value.ToString(), "HH:mm:ss", null));
                lblTimeMinuteInfo.Text = span.TotalMinutes.ToString("0 dk");
                dGVOrderDetails.CurrentCell = dGVOrderDetails.Rows[i].Cells[r];
                dGVOrderDetails.FirstDisplayedScrollingRowIndex = scroll;
            }
            catch (ArgumentOutOfRangeException) { return; }
            catch (NullReferenceException) { }
            catch
            {
                dGVOrderDetails.CurrentCell = dGVOrderDetails.Rows[i - 1].Cells[r];
                dGVOrderDetails.FirstDisplayedScrollingRowIndex = 0;
            }
            if (_count < dGVOrderDetails.Rows.Count)
            {
                _count = Alert(dGVOrderDetails.Rows.Count, "Sipariş Geldi", Form_Alert.enmType.Info);
            }
        }
        private void timerNow_Tick(object sender, EventArgs e)
        {
            _nowTime = DateTime.Now;
            PropertyTraffics.SessionSecond--;
            Debug.WriteLine(PropertyTraffics.SessionSecond);
            if (PropertyTraffics.SessionSecond < 1)
            {
                _user = null;
                _userTitleService = null;
                _productService = null;
                _productImageService = null;
                _productCategoryService = null;
                _orderService = null;
                _orderDetailTimeLogService = null;
                _orderDetailService = null;
                _deskService = null;
                this.Close();
                this.Dispose();
            }
            lblTimeNow.Text = _nowTime.ToString("dddd dd/MM HH:mm ");
        }
        private void cmBxOrderStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            _nowTime = DateTime.Now;
            TimeSpan begintoSpan = _nowTime.Subtract(DateTime.ParseExact(dGVOrderDetails.CurrentRow.Cells["CreateTime"].Value.ToString(), "HH:mm:ss", null));
            int id = (int)dGVOrderDetails.CurrentRow.Cells["ID"].Value;
            var data = _orderDetailService.GetBy(x => x.ID == id).Data;
            if (data.EOrderStatus != (OrderStatus)cmBxOrderStatus.SelectedItem)
            {
                if ((OrderStatus)cmBxOrderStatus.SelectedItem == OrderStatus.Prepares)
                {
                    var log = new OrderDetailTimeLog
                    {
                        UserID = _user.ID,
                        OrderStatus = OrderStatus.Prepares,
                        OrderDetailID = id,
                        CreateDate = _nowTime,
                        Minute = (decimal)begintoSpan.TotalMinutes,
                        Second = (decimal)begintoSpan.TotalSeconds
                    };
                    _orderDetailTimeLogService.Add(log);
                    cmBxOrderStatus.Items.Remove(OrderStatus.Waiting);
                    cmBxOrderStatus.Items.Add(OrderStatus.AtWaiters);

                }
                else if ((OrderStatus)cmBxOrderStatus.SelectedItem == OrderStatus.AtWaiters)
                {
                    var minute = _orderDetailTimeLogService.GetBy(x => x.OrderDetailID == data.ID && x.OrderStatus == OrderStatus.Prepares).Data.CreateDate.ToString("dd.MM.yyyy HH:mm:ss");
                    begintoSpan = _nowTime.Subtract(DateTime.ParseExact(minute, "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture));
                    var log = new OrderDetailTimeLog
                    {
                        UserID = _user.ID,
                        OrderStatus = OrderStatus.AtWaiters,
                        OrderDetailID = id,
                        CreateDate = _nowTime,
                        Minute = (decimal)begintoSpan.TotalMinutes,
                        Second = (decimal)begintoSpan.TotalSeconds
                    };
                    _orderDetailTimeLogService.Add(log);
                    cmBxOrderStatus.Items.Remove(OrderStatus.Prepares);
                }
                data.EOrderStatus = (OrderStatus)cmBxOrderStatus.SelectedItem;
                _orderDetailService.Update(data);
            }
        }
        private void MouseMoveForSession(object sender, MouseEventArgs e)
        {
            PropertyTraffics.SessionSecond = _sessionMinutesOption;
        }

        #region Buttons

        private void tSDesk_Click(object sender, EventArgs e)
        {
            tCMain.SelectedTab = tPDesk;
            Desk();
        }

        private void tSOrder_Click(object sender, EventArgs e)
        {
            tCMain.SelectedTab = tPOrder;
            OrderList();
        }

        private void tSLogOut_Click(object sender, EventArgs e)
        {
            _user = null;
            this.Close();
        }

        private void tSExit_Click(object sender, EventArgs e)
        {
            DialogResult Exit = MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Çıkış",
             MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (Exit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        #endregion

        #endregion
    }
}
