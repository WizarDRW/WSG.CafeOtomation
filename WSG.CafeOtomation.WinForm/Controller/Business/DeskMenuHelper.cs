using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSG.CafeOtomation.WinForm.Controller.Business
{
    public partial class DeskMenuHelper : Form
    {
        public DeskMenuHelper(string name)
        {
            InitializeComponent();
            lblTitle.Text = name;
        }
        public DeskMenuHelper()
        {
            InitializeComponent();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(lblCount.Text);
            a++;
            lblCount.Text = a.ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(lblCount.Text);
            a--;
            lblCount.Text = a.ToString();
        }

        private void DeskMenuHelper_Load(object sender, EventArgs e)
        {
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            PropertyTraffics.ProductCount = null;
            this.Close();
            this.Dispose();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            PropertyTraffics.ProductCount = Convert.ToInt32(lblCount.Text);
            this.Close();
            this.Dispose();
        }
    }
}
