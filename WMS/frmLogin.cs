using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WMS
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            btn_time.Text = DateTime.Now.ToLongTimeString();
        }

        private void login_Load(object sender, EventArgs e)
        {
            this.uSER_TBLTableAdapter.Fill(this.dsWMS.USER_TBL);

            if (cmbUserLogin.Items.Count == 1)
            {
                cmbUserLogin.SelectedIndex = 0;
                cmbUserLogin.Enabled = false;
            }

            btn_date.Text = utils.Instance.getPersianDate();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                bool userType = (bool)this.uSER_TBLTableAdapter.GetUserAuth(cmbUserLogin.Text, txtPassword.Text);
                this.Hide();
                new frmMainPanel(userType).ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("رمز عبور اشتباه می باشد", "اخطار");
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin_Click(sender, e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmbUserLogin_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPassword.Clear();
        }


    }
}
