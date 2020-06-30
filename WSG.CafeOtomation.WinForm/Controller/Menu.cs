using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        public Menu(User user)
        {
            InitializeComponent();
            _user = user;
            _productCategoryService = new ProductCategoryManager(new EfProductCategoryDal());
            _productService = new ProductManager(new EfProductDal());
            _productImageService = new ProductImageManager(new EfProductImageDal());
            _deskService = new DeskManager(new EfDeskDal());
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
            foreach (var d in _deskService.GetAll(x=>x.DeskNo.Contains(find)).Data)
            {
                Button button = new Button();
                if (i%5 == 0)
                {
                    left = 200;
                    top += 200;
                }
                button.Enabled = false;
                if (d.IsActive)
                {
                    button.BackColor = Color.LawnGreen;
                    button.ForeColor = Color.White;
                    button.Enabled = true;
                }
                button.Font = new Font("Trebuchet MS", 25f ,FontStyle.Regular);
                button.Text = d.DeskNo;
                button.Location = new Point(left, top);
                button.Size = new Size(190, 190);
                i += 1;
                left += 200;
                tPDesk.Controls.Add(button);
            }
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
            var product = _productImageService.GetByProduct(id).Data;
            gBxProductDetail.Visible = true;
            gBxProductDetail.Text = "Ürün Detay Bilgisi / " + DateTime.Now.ToString("dd MMMM yyyy dddd");
            pBxImage.Load(product.FirstOrDefault(x => x.IsCover).Path.ToString());
            lblProductName.Text = _productService.GetByID(id).Data.Name;
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
        }

        private void tSStock_Click(object sender, EventArgs e)
        {
            tCMain.SelectedTab = tPStock;
        }

        private void tSExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

    }
}
