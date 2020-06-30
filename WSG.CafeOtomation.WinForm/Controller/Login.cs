using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WSG.CafeOtomation.Business.Abstract;
using WSG.CafeOtomation.Business.Concrete;
using WSG.CafeOtomation.DataAccess.Concrete.EntityFramework;
using WSG.CafeOtomation.Entities.Dtos;

namespace WSG.CafeOtomation.WinForm.Controller
{
    public partial class Login : Form
    {
        private IAuthService _authService;
        private bool _exit;
        public Login()
        {
            InitializeComponent();
            _authService = new AuthManager(new UserManager(new EfUserDal()));
            _exit = false;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var data = new UserForLoginDto
            {
                UserName = txtbxUserName.Text,
                Password = txtbxPassword.Text
            };
            var result = _authService.Login(data);

            if (result.Success)
            {
                var mainMenu = new Menu(result.Data);
                mainMenu.Show();
                _exit = false;
                this.Hide();
            }
            else
            {
                MessageBox.Show(result.Message);
            }
            
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_exit)
            {
                Application.Exit();
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_exit)
            {
                Application.Exit();
            }
        }
    }
}
