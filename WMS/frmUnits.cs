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
    public partial class frmUnits : Form
    {
        private string selectedUnitName;
        public frmUnits()
        {
            InitializeComponent();
        }

        private void frmUnits_Load(object sender, EventArgs e)
        {
            this.unitTableAdapter.Fill(this.dsWMS.unit);
            txtUnitName.Clear();
        }

        private void btnAddUnit_Click(object sender, EventArgs e)
        {
            if (txtUnitName.Text == "")
            {
                MessageBox.Show("لطفا همه فیلد ها رو تکمیل کنید");
            }
            else
            {
                int c = (int)this.unitTableAdapter.CheckDuplicateRecord(txtUnitName.Text);

                if (c > 0)
                {
                    DialogResult d = MessageBox.Show("این رکورد قبلا ثبت شده است ", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    this.unitTableAdapter.AddNewUnit(txtUnitName.Text);
                    MessageBox.Show("اضافه شد");
                }
                frmUnits_Load(sender, e);
            }
        }

        private void btnDeleteUnit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا مایل به حذف هستید؟", "پیام", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.unitTableAdapter.DeleteUnit(txtUnitName.Text);
                frmUnits_Load(sender, e);
                MessageBox.Show("حذف شد");
            }
        }

        private void btnSearchUnit_Click(object sender, EventArgs e)
        {
            this.unitTableAdapter.FillByConditionalSearch(dsWMS.unit, txtUnitName.Text);
        }

        private void btnUpdateUnit_Click(object sender, EventArgs e)
        {
            this.unitTableAdapter.UpdateUnit(txtUnitName.Text, selectedUnitName);
            frmUnits_Load(sender, e);
            MessageBox.Show("ویرایش شد"); 
        }

        private void dgvUnits_MouseUp(object sender, MouseEventArgs e)
        {
            txtUnitName.Text = dgvUnit[0, dgvUnit.CurrentRow.Index].Value.ToString();
            selectedUnitName = txtUnitName.Text;
        }

        private void btnPrintUnits_Click(object sender, EventArgs e)
        {
            PrintDGV.printDataGridView(dgvUnit);
        }
    }
}
