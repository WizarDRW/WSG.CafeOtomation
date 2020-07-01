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
using WSG.CafeOtomation.Entities.Concrete;

namespace WSG.CafeOtomation.WinForm.Controller
{
    public partial class DeskMenu : Form
    {
        private Desk _desk;
        public DeskMenu(Desk desk)
        {
            InitializeComponent();
            _desk = desk;
        }

        private void DeskMenu_Load(object sender, EventArgs e)
        {
            lblTitle.Text = _desk.DeskNo;
        }
    }
}
