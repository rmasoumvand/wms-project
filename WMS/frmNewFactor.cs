using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WMS
{
    public partial class frmNewFactor : Form
    {
        private string selectedFactorNumber;
        public frmNewFactor(string selectedFactorId)
        {
            InitializeComponent();

            if (selectedFactorId != null)
                txtFactorNumber.Text = selectedFactorId;
        }
        private void frmNewFactor_Load(object sender, EventArgs e)
        {
            this.kalaTableAdapter.Fill(this.dsWMS.kala);

            this.anbarTableAdapter.Fill(this.dsWMS.anbar);
            this.foroshandehTableAdapter.FillBySellersNameFamily(dsWMS.foroshandeh);
            this.tahvilgirandehTableAdapter.FillByRecipientsNameFamily(dsWMS.tahvilgirandeh);
            txtFactorDate.Text = utils.Instance.getPersianDate();
        }
       
        private void cmbWarehouses_SelectedIndexChanged(object sender, EventArgs e)
        {
            kalaTableAdapter.FillByAnbarName(dsWMS.kala, cmbWarehouses.Text);
        }

        
        private void btnAddNewFactorItem_Click(object sender, EventArgs e)
        {
            int totalPrice = int.Parse(cmbNewFactorCommodityUnitPrice.Text) * int.Parse(txtNewFactorCommodityAmount.Text);
            this.aghlamTableAdapter.AddNewAghlam(int.Parse(txtNewFactorCommodityCode.Text), int.Parse(txtNewFactorCommodityAmount.Text),  int.Parse(txtFactorNumber.Text), int.Parse(txtNewFactorCommodityCode.Text), -2);
            this.aghlamTableAdapter.Fill(this.dsWMS1.aghlam);
        }

        private void dgvNewFactorCommodities_MouseUp(object sender, MouseEventArgs e)
        {
            txtNewFactorCommodityAmount.Text = dgvNewFactorCommodities[6, dgvNewFactorCommodities.CurrentRow.Index].Value.ToString();
            cmbWarehouses.Text = dgvNewFactorCommodities[5, dgvNewFactorCommodities.CurrentRow.Index].Value.ToString();
            selectedFactorNumber = dgvNewFactorCommodities[1, dgvNewFactorCommodities.CurrentRow.Index].Value.ToString();
            cmbNewFactorCommodityName.Text = dgvNewFactorCommodities[2, dgvNewFactorCommodities.CurrentRow.Index].Value.ToString();
        }

        private void btnDeleteFactorItem_Click(object sender, EventArgs e)
        {
            this.aghlamTableAdapter.DeleteAghlam(txtFactorNumber.Text);
        }

        private void btnSaveNewFactor_Click(object sender, EventArgs e)
        {
            //
        }

        private void txtFactorNumber_TextChanged(object sender, EventArgs e)
        {
            int c = (int)this.factorTableAdapter.QueryFactorById(txtFactorNumber.Text);
            if (c > 0)
            {
                btnSaveNewFactor.Enabled = false;
                btnAddFactorItem.Enabled = false;
                txtNewFactorRecientNumber.Text = this.factorTableAdapter.QueryWarehouseReciptById(txtFactorNumber.Text);
            }
            else
            {
                txtNewFactorRecientNumber.Clear();
                btnAddFactorItem.Enabled = true;
                btnSaveNewFactor.Enabled = true;
            }
            this.aghlamTableAdapter.FillByAghlamFactorNumber(this.dsWMS1.aghlam, txtFactorNumber.Text);
        }

        private void btnCancelNewFactor_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUpdateNewFactor_Click(object sender, EventArgs e)
        {
            if (txtFactorNumber.Text == "" || txtNewFactorRecientNumber.Text == "")
            {
                MessageBox.Show("لطفا همه فیلد ها رو تکمیل کنید");
            }
            else
            {
                this.factorTableAdapter.UpdateFactor(cmbFactorSellers.Text, cmbRecipients.Text,txtNewFactorRecientNumber.Text, txtFactorNumber.Text);
                MessageBox.Show("ویرایش شد");
            }
            frmNewFactor_Load(null, e);
        }

        private void checkInputNumber_Event(object sender, KeyPressEventArgs e)
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
