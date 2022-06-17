using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WMS
{
    public partial class frmUserSettings : Form
    {
        private int selectedUserID;
        public frmUserSettings()
        {
            InitializeComponent();
        }
       
        private void btnPrintUsers_Click(object sender, EventArgs e)
        {
            PrintDGV.printDataGridView(dgvUsers);
        }

        private void dgvUsers_MouseUp(object sender, MouseEventArgs e)
        {
            selectedUserID = int.Parse(dgvUsers[0, dgvUsers.CurrentRow.Index].Value.ToString());
            txtUserName.Text = dgvUsers[1, dgvUsers.CurrentRow.Index].Value.ToString();
            txtPassword.Text = dgvUsers[2, dgvUsers.CurrentRow.Index].Value.ToString();
            cmbUserType.SelectedIndex = bool.Parse(dgvUsers[3, dgvUsers.CurrentRow.Index].Value.ToString()) ? 0 : 1;
        }

        private void frmUserSettings_Load(object sender, EventArgs e)
        {
            this.uSER_TBLTableAdapter.Fill(this.dsWMS.USER_TBL);
            txtUserName.Clear();
            txtPassword.Clear();
            cmbUserType.SelectedIndex = 1;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            int c = (int)this.uSER_TBLTableAdapter.CheckDuplicateRecord(txtUserName.Text);

            if (c > 0)
            {
                MessageBox.Show("این رکورد قبلا ثبت شده است ", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.uSER_TBLTableAdapter.AddNewUser(txtUserName.Text, txtPassword.Text, (cmbUserType.SelectedIndex > 0) ? false : true);
                MessageBox.Show("اضافه شد");
            }
            frmUserSettings_Load(null, e);
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا مایل به حذف هستید؟", "پیام", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.uSER_TBLTableAdapter.DeleteUser(selectedUserID);
                frmUserSettings_Load(null, e);
                MessageBox.Show("حذف شد");
            }
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            this.uSER_TBLTableAdapter.UpdateUser(txtUserName.Text, txtPassword.Text, (cmbUserType.SelectedIndex > 0) ? false : true, selectedUserID);
            frmUserSettings_Load(sender, e);
            MessageBox.Show("ویرایش شد"); 
        }

        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            this.uSER_TBLTableAdapter.FillBySearchCondition(dsWMS.USER_TBL, txtUserName.Text);
        }
    }
}
