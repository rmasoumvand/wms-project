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
    public partial class frmRecipient : Form
    {
        private int selectedRecipientId;
        public frmRecipient()
        {
            InitializeComponent();
        }


        private void frmRecipient_Load(object sender, EventArgs e)
        {
            this.tahvilgirandehTableAdapter.Fill(this.dsWMS.tahvilgirandeh);
            txtRecipientName.Clear();
            txtRecipientFamily.Clear();
            txtRecipientPhone.Clear();
            txtRecipientAddress.Clear();
        }

        private void btnAddRecipient_Click(object sender, EventArgs e)
        {
            if (txtRecipientName.Text == "" || txtRecipientFamily.Text == "" || txtRecipientPhone.Text == "" || txtRecipientAddress.Text == "")
            {
                MessageBox.Show("لطفا همه فیلد ها رو تکمیل کنید");
            }
            else
            {
                int c = (int)this.tahvilgirandehTableAdapter.CheckForDuplicateRecord(txtRecipientName.Text, txtRecipientFamily.Text);

                if (c > 0)
                {
                    MessageBox.Show("این رکورد قبلا ثبت شده است ", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    this.tahvilgirandehTableAdapter.AddNewRecipient(txtRecipientName.Text, txtRecipientFamily.Text, txtRecipientPhone.Text, txtRecipientAddress.Text);
                    MessageBox.Show("اضافه شد");
                }
            }
            frmRecipient_Load(null, e);
          }

        private void btnUpdateRecipient_Click(object sender, EventArgs e)
        {
            this.tahvilgirandehTableAdapter.UpdateRecipient(txtRecipientName.Text, txtRecipientFamily.Text, txtRecipientPhone.Text, txtRecipientAddress.Text, selectedRecipientId);
            frmRecipient_Load(sender, e);
            MessageBox.Show("ویرایش شد"); 
        }

        private void btnDeleteRecipient_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا مایل به حذف هستید؟", "پیام", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.tahvilgirandehTableAdapter.DeleteRecipient(selectedRecipientId);
                frmRecipient_Load(sender, e);
                MessageBox.Show("حذف شد");
            }
            else { }
        }

        private void btnSearchRecipient_Click(object sender, EventArgs e)
        {
            this.tahvilgirandehTableAdapter.FillBySearchCondition(dsWMS.tahvilgirandeh, txtRecipientName.Text, txtRecipientFamily.Text, txtRecipientPhone.Text, txtRecipientAddress.Text);
        }

        private void dgvRecipient_MouseUp(object sender, MouseEventArgs e)
        {
            selectedRecipientId = int.Parse( dgvRecipient[0, dgvRecipient.CurrentRow.Index].Value.ToString());
            txtRecipientName.Text = dgvRecipient[1, dgvRecipient.CurrentRow.Index].Value.ToString();
            txtRecipientFamily.Text = dgvRecipient[2, dgvRecipient.CurrentRow.Index].Value.ToString();
            txtRecipientPhone.Text = dgvRecipient[3, dgvRecipient.CurrentRow.Index].Value.ToString();
            txtRecipientAddress.Text = dgvRecipient[4, dgvRecipient.CurrentRow.Index].Value.ToString();
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            PrintDGV.printDataGridView(dgvRecipient);
        }

        private void txtRecipientPhone_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
