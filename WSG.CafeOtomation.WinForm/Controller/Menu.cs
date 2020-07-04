using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WizardSoftwareGroupsFramework.Core.Entities.Concrete;
using WSG.CafeOtomation.Business.Abstract;
using WSG.CafeOtomation.Business.Concrete;
using WSG.CafeOtomation.DataAccess.Concrete.EntityFramework;

namespace WSG.CafeOtomation.WinForm.Controller
{
    public partial class Menu : Form
    {
        private User _user;
        private IProductCategoryService _productCategoryService;
        private IProductService _productService;
        private IProductImageService _productImageService;
        private IDeskService _deskService;
        private IOrderService _orderService;
        private IOrderDetailService _orderDetailService;
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
        }
        private void Menu_Load(object sender, EventArgs e)
        {
            foreach (var pC in _productCategoryService.GetAll().Data)
            {
                lBxPCategory.Items.Add(pC.Name);
            }
        }
        public void Desk(string find = "")
        {
            int left = 200;
            int top = 100;
            int i = 1;
            foreach (var d in _deskService.GetAll(x => x.DeskNo.Contains(find)).Data)
            {
                Button button = new Button();
                if (i % 5 == 0)
                {
                    left = 200;
                    top += 200;
                }
                button.Enabled = true;
                if (d.IsActive)
                {
                    button.BackColor = Color.LawnGreen;
                    button.ForeColor = Color.White;
                }
                else
                {
                    button.BackColor = Color.Gray;
                    button.ForeColor = Color.Black;
                }
                button.Font = new Font("Trebuchet MS", 25f, FontStyle.Regular);
                button.Text = d.DeskNo;
                button.Location = new Point(left, top);
                button.Size = new Size(190, 190);
                i += 1;
                left += 200;
                button.Click += Button_Click;
                tPDesk.Controls.Add(button);
            }
        }
        private void Button_Click(object sender, EventArgs e)
        {
            Button button;
            button = sender as Button;
            var data = _deskService.GetByNo(button.Text).Data;
            DeskMenu desk = new DeskMenu(data);
            desk.ShowDialog();

        }
        public void OrderList()
        {
            dGVOrder.DataSource = _orderService.GetAll(x => !x.IsClose).Data;
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
            int id = int.Parse(dGVOrder.CurrentRow.Cells["ID"].Value.ToString());
            dGVOrderDetails.DataSource = _orderDetailService.GetAll(x => x.OrderID == id).Data;
            btnDoSale.Enabled = true;
            btnDetailSale.Enabled = true;
        }

        #region Buttons

        private void tSSale_Click(object sender, EventArgs e)
        {
            tCMain.SelectedTab = tPSale;
        }

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

        private void tSStock_Click(object sender, EventArgs e)
        {
            tCMain.SelectedTab = tPStock;
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
    }
}
