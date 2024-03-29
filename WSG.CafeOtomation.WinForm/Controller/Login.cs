﻿using System;
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
        private IUserEntryService _userEntryService;
        private bool _exit;
        public Login()
        {
            InitializeComponent();
            _authService = new AuthManager(new UserManager(new EfUserDal()), new UserTitleManager(new EfUserTitleDal()), true);
            _userService = new UserManager(new EfUserDal());
            _userEntryService = new UserEntryManager(new EfUserEntryDal());
            _exit = false;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            string title = "Kullanıcıyı Seçiniz!";
            cmBxUserName.Items.Add(title);
            cmBxUserName.SelectedIndex = cmBxUserName.FindString(title);
            foreach (var item in _userService.GetAllStuff().Data)
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
                    ActiveControl = txtbxPassword;
                }
            }
        }

        private void LoginSuccess(IDataResult<User> result)
        {
            //var check = _userEntryService.GetAllByUserID(x=>x.UserID == result.Data.ID && TimeSpan.FromHours(x.Date.Hour) > TimeSpan.FromHours(x.Date.Hour+20));
            //if (check.Data.Count < 0)
            //{
            //    var entry = new UserEntry
            //    {
            //        UserID = result.Data.ID,
            //        Date = DateTime.Now,
            //        EntryType = EntryType.Giris
            //    };
            //    _userEntryService.Add(entry);
            //}
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
            ActiveControl = txtbxPassword;
            Button btn = (Button)sender;
            txtbxPassword.Text += btn.Text;
        }

        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            ActiveControl = txtbxPassword;
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
