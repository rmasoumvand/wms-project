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
    public partial class frmSeller : Form
    {
        public frmSeller()
        {
            InitializeComponent();
        }

        private void frmSeller_Load(object sender, EventArgs e)
        {
            this.foroshandehTableAdapter.Fill(this.dsWMS.foroshandeh);
            txtSellerName.Clear();
            txtSellerFamily.Clear();
            txtSellerPhone.Clear();
            txtSellerAddress.Clear();
            txtSellerID.Clear();
        }

        private void dgvSellers_MouseUp(object sender, MouseEventArgs e)
        {
            txtSellerID.Text = dgvSellers[0, dgvSellers.CurrentRow.Index].Value.ToString();
            txtSellerName.Text = dgvSellers[1, dgvSellers.CurrentRow.Index].Value.ToString();
            txtSellerFamily.Text = dgvSellers[2, dgvSellers.CurrentRow.Index].Value.ToString();
            txtSellerPhone.Text = dgvSellers[3, dgvSellers.CurrentRow.Index].Value.ToString();
            txtSellerAddress.Text = dgvSellers[4, dgvSellers.CurrentRow.Index].Value.ToString();
        }

        private void txtSellerPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
				{
					return;
				}
				if (!System.Char.IsDigit(e.KeyChar))
				{
					e.Handled = true;
					MessageBox.Show("لطفا عدد وارد کنید", "هشدار", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
				}
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.frmSeller_Load(null, e);
        }

        private void btnAddSeller_Click(object sender, EventArgs e)
        {
            if (txtSellerName.Text == "" || txtSellerFamily.Text == "" || txtSellerPhone.Text == "" || txtSellerAddress.Text == "")
            {
                MessageBox.Show("لطفا همه فیلد ها رو تکمیل کنید");
            }
            else
            {
                int c = (int)this.foroshandehTableAdapter.CheckDuplicateRecord(txtSellerName.Text, txtSellerFamily.Text);

                if (c > 0)
                {
                    MessageBox.Show("این رکورد قبلا ثبت شده است ", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    this.foroshandehTableAdapter.AddNewSeller(txtSellerName.Text, txtSellerFamily.Text, txtSellerPhone.Text, txtSellerAddress.Text);
                    dgvSellers.CurrentCell = dgvSellers.Rows[dgvSellers.RowCount - 1].Cells[0];
                    MessageBox.Show("اضافه شد");
                }
            }
            frmSeller_Load(sender, e);
        }

        private void btnUpdateSeller_Click(object sender, EventArgs e)
        {
            this.foroshandehTableAdapter.UpdateSeller(txtSellerName.Text, txtSellerFamily.Text, txtSellerPhone.Text, txtSellerAddress.Text, Int16.Parse(txtSellerID.Text));
            frmSeller_Load(sender, e);
            MessageBox.Show("ویرایش شد"); 
        }

        private void btnDeleteSeller_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا مایل به حذف هستید؟", "پیام", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.foroshandehTableAdapter.DeleteSeller(Int16.Parse(txtSellerID.Text));
                frmSeller_Load(sender, e);
                MessageBox.Show("حذف شد");
            }
        }

        private void btnSearchSeller_Click(object sender, EventArgs e)
        {
            this.foroshandehTableAdapter.FillBySearchCondition(dsWMS.foroshandeh, txtSellerName.Text, txtSellerFamily.Text, txtSellerPhone.Text, txtSellerAddress.Text);
        }

        private void btnPrintSellers_Click(object sender, EventArgs e)
        {
            PrintDGV.printDataGridView(dgvSellers);
        }
    }
}
