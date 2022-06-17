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
    public partial class frmInventoryReport : Form
    {
        public frmInventoryReport()
        {
            InitializeComponent();
        }

        private void frmInventoryReport_Load(object sender, EventArgs e)
        {
            this.anbarTableAdapter.Fill(this.dsWMS.anbar);
            this.kalaTableAdapter.FillByAnbarName(this.dsWMS.kala, cmbWarehouse.Text);
            txtInventory.Text = this.kalaTableAdapter.SumTotalInventories(cmbWarehouse.Text).ToString();
        }

        private void btnPrintInventories_Click(object sender, EventArgs e)
        {
            PrintDGV.printDataGridView(dataGridViewX1);
        }

        private void comboBoxEx1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.kalaTableAdapter.FillByAnbarName(this.dsWMS.kala, cmbWarehouse.Text);
            txtInventory.Text = this.kalaTableAdapter.SumTotalInventories(cmbWarehouse.Text).ToString();
        }
    }
}
