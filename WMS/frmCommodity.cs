using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WMS
{
    public partial class frmCommodity : Form
    {
        private int selectedCommodityId;
        public frmCommodity()
        {
            InitializeComponent();
        }
        
        private void frmCommodity_Load(object sender, EventArgs e)
        {
            this.anbarTableAdapter.Fill(this.dsWMS.anbar);
            this.countryTableAdapter.Fill(this.dsWMS.country);
            this.unitTableAdapter.Fill(this.dsWMS.unit);
            this.kalaTableAdapter.Fill(this.dsWMS.kala);
        }

        private void btnAddCommodity_Click(object sender, EventArgs e)
        {
            if (txtCommodityName.Text == "" || txtCommodityAmount.Text == "" || txtCommodityUnitPrice.Text == "")
            {
                MessageBox.Show("لطفا همه فیلد ها رو تکمیل کنید");
            }
            else
            {
                int sum = int.Parse(txtCommodityAmount.Text) * int.Parse(txtCommodityUnitPrice.Text);

                this.kalaTableAdapter.AddNewCommodity(txtCommodityName.Text, txtCommodityDesc.Text, cmbCommodityCountry.SelectedText, cmbCommodityWarehouse.SelectedText, txtCommodityAmount.Text, cmbCommodityUnit.SelectedText, txtCommodityUnitPrice.Text, sum.ToString(), txtCommodityDate.Text);
                frmCommodity_Load(sender, e);
                MessageBox.Show("اضافه شد");
            }
        }

        private void btnUpdateCommodity_Click(object sender, EventArgs e)
        {
            int sum = int.Parse(txtCommodityAmount.Text) * int.Parse(txtCommodityUnitPrice.Text);
            this.kalaTableAdapter.UpdateCommodity(txtCommodityName.Text, txtCommodityDesc.Text, cmbCommodityCountry.Text, cmbCommodityWarehouse.Text, txtCommodityAmount.Text, cmbCommodityUnit.Text, txtCommodityUnitPrice.Text, sum.ToString(), txtCommodityDate.Text, selectedCommodityId);
            frmCommodity_Load(sender, e);
            MessageBox.Show("ویرایش شد"); 
        }

        private void dgvCommodity_MouseUp(object sender, MouseEventArgs e)
        {
            selectedCommodityId = int.Parse(dgvCommodity[0, dgvCommodity.CurrentRow.Index].Value.ToString());
            txtCommodityName.Text = dgvCommodity[1, dgvCommodity.CurrentRow.Index].Value.ToString();
            txtCommodityDesc.Text = dgvCommodity[2, dgvCommodity.CurrentRow.Index].Value.ToString();
            cmbCommodityCountry.Text = dgvCommodity[3, dgvCommodity.CurrentRow.Index].Value.ToString();
            txtCommodityAmount.Text = dgvCommodity[5, dgvCommodity.CurrentRow.Index].Value.ToString();
            cmbCommodityUnit.Text = dgvCommodity[6, dgvCommodity.CurrentRow.Index].Value.ToString();
            cmbCommodityWarehouse.Text=dgvCommodity[4,dgvCommodity.CurrentRow.Index].Value.ToString();
            txtCommodityUnitPrice.Text = dgvCommodity[7, dgvCommodity.CurrentRow.Index].Value.ToString();
            txtCommodityDate.Text = dgvCommodity[9, dgvCommodity.CurrentRow.Index].Value.ToString();
        }

        private void btnDeleteCommodity_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا از حذف کالا مطمئن هستید؟", "پیام", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.kalaTableAdapter.DeleteCommodity(selectedCommodityId);
                frmCommodity_Load(sender, e);
                MessageBox.Show("حذف شد");
            }
            else { }
        }

        private void btnSearchCommodity_Click(object sender, EventArgs e)
        {
            this.kalaTableAdapter.FillBySearchCondition(dsWMS.kala, txtCommodityName.Text, txtCommodityDesc.Text, txtCommodityAmount.Text, txtCommodityUnitPrice.Text);
        }

        private void btnPrintCommodities_Click(object sender, EventArgs e)
        {
            PrintDGV.printDataGridView(dgvCommodity);
        }

        private void txtCommodityAmount_KeyPress(object sender, KeyPressEventArgs e)
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
