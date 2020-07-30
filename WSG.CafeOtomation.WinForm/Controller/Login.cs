using System;
using System.Linq;
using System.Windows.Forms;
using WizardSoftwareGroupsFramework.Core.Entities.Concrete;
using WizardSoftwareGroupsFramework.Core.Utilities.Result.Abstract;
using WSG.CafeOtomation.Business.Abstract;
using WSG.CafeOtomation.Business.Concrete;
using WSG.CafeOtomation.DataAccess.Concrete.EntityFramework;
using WSG.CafeOtomation.Entities.Concrete;
using WSG.CafeOtomation.Entities.Dtos;

namespace WSG.CafeOtomation.WinForm.Controller
{
    public partial class Login : Form
    {
        private IAuthService _authService;
        private IUserService _userService;
        private bool _exit;
        public Login()
        {
            InitializeComponent();
            _authService = new AuthManager(new UserManager(new EfUserDal()), new UserTitleManager(new EfUserTitleDal()));
            _userService = new UserManager(new EfUserDal());
            _exit = false;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            string title = "Kullanıcıyı Seçiniz!";
            cmBxUserName.Items.Add(title);
            cmBxUserName.SelectedIndex = cmBxUserName.FindString(title);
            foreach (var item in _userService.GetAllStuff(x => x.AccessAuth == AccessAuth.Waiter || x.AccessAuth == AccessAuth.Staff || x.AccessAuth == AccessAuth.Chef).Data)
            {
                cmBxUserName.Items.Add(item.UserName);
            }
            ActiveControl = txtbxPassword;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            txtbxPassword.Text = txtbxPassword.Text.Replace("\r", "");
            var cartRes = _authService.CardLogin(new UserTitle { CartPass = txtbxPassword.Text });
            if (cartRes.Success)
            {
                LoginSuccess(cartRes);
            }
            else
            {
                var data = new UserForLoginDto
                {
                    UserName = cmBxUserName.Text,
                    Password = txtbxPassword.Text
                };
                var result = _authService.Login(data);
                if (result.Success)
                {
                    LoginSuccess(result);
                }
                else
                {
                    MessageBox.Show(result.Message);
                }
            }
        }

        private void LoginSuccess(IDataResult<User> result)
        {
            var mainMenu = new Menu(result.Data);
            mainMenu.Show();
            mainMenu.FormClosing += MainMenu_FormClosing;
            _exit = false;
            this.Hide();
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Show();
            txtbxPassword.Text = string.Empty;
        }

        private void btnNumbers(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtbxPassword.Text += btn.Text;
        }

        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtbxPassword.Text))
            {
                string str = txtbxPassword.Text;
                str = str.Substring(0, str.Length - 1);
                txtbxPassword.Text = str;
            }
        }

        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtbxPassword.Text += e.KeyChar.ToString();
            if (txtbxPassword.Text.Contains("\r"))
            {
                btnLogin_Click(sender, e);
            }
        }
    }
}
