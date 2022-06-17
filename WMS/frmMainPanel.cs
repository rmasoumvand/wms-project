using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WMS
{
    public partial class frmMainPanel : Form
    {
        private bool isAdmin;
        public frmMainPanel(bool isAdmin)
        {
            this.isAdmin = isAdmin;

            InitializeComponent();
        }     

        private void buttonItem7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMainPanel_Load(object sender, EventArgs e)
        {
            this.foroshandehTableAdapter.FillByTopRecords(this.dsWMS.foroshandeh);
            this.tahvilgirandehTableAdapter.FillByTopRecords(this.dsWMS.tahvilgirandeh);
            this.kalaTableAdapter.FillByTopRecords(this.dsWMS.kala);
            this.anbarTableAdapter.FillByTopRecords(this.dsWMS.anbar);

            if (!isAdmin)
            {
                lblUserType.Text = "کاربر عادی";
                btnManageSellers.Enabled = false;
                mnuItemManageSeller.Enabled = false;
                btnManageRecipients.Enabled = false;
                mnuItemManageRecipient.Enabled = false;
                btnManageWarhouses.Enabled = false;
                mnuItemManageWarhouses.Enabled = false;
                btnInvetoryReport.Enabled = false;
                mnuItemWarhousesReport.Enabled = false;
                btnSellersReport.Enabled = false;
                mnuItemSellersReport.Enabled = false;
                btnRecipientReport.Enabled = false;
                btnManageUsers.Enabled = false;
            }
            else
            {
                lblUserType.Text = "مدیر";
            }

            btnMainDate.Text = utils.Instance.getPersianDate();
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            PrintDGV.printDataGridView(dgvLastSellers);
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            PrintDGV.printDataGridView(dgvLastRecipients);
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            PrintDGV.printDataGridView(dgvLastWarhouses);
        }

        private void buttonX6_Click(object sender, EventArgs e)
        {
            PrintDGV.printDataGridView(dgvLastCommodities);
        }

        private void btnNewFactor_Click(object sender, EventArgs e)
        {
            new frmFactor().ShowDialog();
        }

        private void frmMainPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void buttonItem12_Click(object sender, EventArgs e)
        {
            new frmUserSettings().ShowDialog();
        }

        private void frmMainPanel_Activated(object sender, EventArgs e)
        {
            this.frmMainPanel_Load(null, e);
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            new frmUserSettings().ShowDialog();
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void mnuItemNewFactor_Click(object sender, EventArgs e)
        {
            btnNewFactor_Click(null, e);
        }

        private void btnManageSellers_Click(object sender, EventArgs e)
        {
            new frmSeller().ShowDialog();
        }

        private void btnManageCommodities_Click(object sender, EventArgs e)
        {
            new frmCommodity().ShowDialog();
        }

        private void btnManageWarhouses_Click(object sender, EventArgs e)
        {
            new frmWarehouse().ShowDialog();
        }

        private void btnManageCountries_Click(object sender, EventArgs e)
        {
            new frmCountry().ShowDialog();
        }

        private void btnManageUnits_Click(object sender, EventArgs e)
        {
            new frmUnits().ShowDialog();
        }

        private void btnRecipientReport_Click(object sender, EventArgs e)
        {
            frmRecipientReport x = new frmRecipientReport();
            x.ShowDialog();
        }

        private void btnSellersReport_Click(object sender, EventArgs e)
        {
            frmSellerReport x = new frmSellerReport();
            x.ShowDialog();
        }

        private void btnCommodityReport_Click(object sender, EventArgs e)
        {
            new frmCommodityReport().ShowDialog();
        }

        private void btnInvetoryReport_Click(object sender, EventArgs e)
        {
            new frmInventoryReport().ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا میخواهید خارج شوید؟", "پیام", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void tmrMainPanel_Tick(object sender, EventArgs e)
        {
            btnMainTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void mnuItemWarhousesReport_Click(object sender, EventArgs e)
        {
            btnCommodityReport_Click(null, e);
        }

        private void mnuItemCommoditiesReport_Click(object sender, EventArgs e)
        {
            btnCommodityReport_Click(null, e);
        }

        private void mnuItemSellersReport_Click(object sender, EventArgs e)
        {
            btnSellersReport_Click(null, e);
        }

        private void mnuItemManageSeller_Click(object sender, EventArgs e)
        {
            btnManageSellers_Click(null, e);
        }

        private void mnuItemManageRecipient_Click(object sender, EventArgs e)
        {
            btnManageRecipients_Click(null, e); 
        }

        private void mnuItemManageCommodities_Click(object sender, EventArgs e)
        {
            btnManageCommodities_Click(null, e);
        }

        private void mnuItemManageWarhouses_Click(object sender, EventArgs e)
        {
            btnManageWarhouses_Click(null, e);
        }

        private void mnuItemManageUnits_Click(object sender, EventArgs e)
        {
            btnManageUnits_Click(null, e);
        }

        private void mnuItemManageCountries_Click(object sender, EventArgs e)
        {
            btnManageCountries_Click(null, e);
        }

        private void btnManageRecipients_Click(object sender, EventArgs e)
        {
            new frmRecipient().ShowDialog();
        }

        private void ribbonTabItem2_Click(object sender, EventArgs e)
        {

        }
    }
}