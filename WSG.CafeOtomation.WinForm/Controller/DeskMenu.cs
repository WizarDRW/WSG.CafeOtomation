using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WizardSoftwareGroupsFramework.Core.Entities.Concrete;
using WSG.CafeOtomation.Business.Abstract;
using WSG.CafeOtomation.Business.Concrete;
using WSG.CafeOtomation.DataAccess.Concrete.EntityFramework;
using WSG.CafeOtomation.Entities.Concrete;

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

            tVList();
        }

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

        private void loadData()
        {
            if (_orderService.GetByDesk(_desk.ID).Data.Where(c => !c.IsClose).Count() > 0)
            {
                var data = _orderService.GetByDesk(_desk.ID).Data.Where(c => !c.IsClose).SingleOrDefault();
                dGWOrders.DataSource = _orderDetailService.GetAll(x => x.OrderID == data.ID).Data;
                dGWOrders.Columns["ID"].Visible = false;
                lblTotalPay.Text = data.TotalPrice.ToString();
                pnlPay.Enabled = true;
            }
        }

        #region Events

        private void DeskMenu_Load(object sender, EventArgs e)
        {
            lblTitle.Text = _desk.DeskNo;
            loadData();
            try
            {
                PayChange();
            }
            catch
            {
            }
        }

        private void tVProducts_DoubleClick(object sender, EventArgs e)
        {

            var data = _orderService.GetByDesk(_desk.ID).Data.Where(c => !c.IsClose).SingleOrDefault();
            var product = _productService.GetByName(tVProducts.SelectedNode.Text).Data;
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
                if (product != null)
                {
                    dataChilds = new OrderDetail
                    {
                        OrderID = data.ID,
                        ProductID = product.ID,
                        Amount = 1,
                        TotalPrice = product.UnitPrice
                    };
                    _orderDetailService.Add(dataChilds);
                }
                else
                {
                    MessageBox.Show("Lütfen başlığa tıklamayınız. Yanlış bir seçenek.");
                }
            }

            loadData();

        }

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

        private void nUDPay_ValueChanged(object sender, EventArgs e)
        {
            PayChange();
        }

        private void PayChange()
        {
            var data = _orderService.GetByDesk(_desk.ID).Data.Where(c => !c.IsClose).SingleOrDefault();
            dGWOrders.DataSource = _orderDetailService.GetAll(x => x.OrderID == data.ID).Data;
            if ((nUDPay.Value - data.TotalPrice) < 0)
            {
                lblChangeTitle.Text = "Ödenecek: ";
            }
            else
            {
                lblChangeTitle.Text = "Para Üstü: ";
            }
            lblChange.Text = (nUDPay.Value - data.TotalPrice).ToString();
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

        private void dGWOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pnlControl.Enabled = true;
            nUDAmount.Value = decimal.Parse(dGWOrders.CurrentRow.Cells["Amount"].Value.ToString());
            lblProductTitle.Text = dGWOrders.CurrentRow.Cells["Product"].Value.ToString();
        }

        #region Buttons

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
            loadData();
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
