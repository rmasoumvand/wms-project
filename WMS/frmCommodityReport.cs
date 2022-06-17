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
    public partial class frmCommodityReport : Form
    {
        public frmCommodityReport()
        {
            InitializeComponent();
        }

        private void frmCommodity_Load(object sender, EventArgs e)
        {
            this.kalaTableAdapter.Fill(this.dsWMS.kala);
        }

        private void btnCommodityCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrintCommodities_Click(object sender, EventArgs e)
        {
            PrintDGV.printDataGridView(dgvCommodities);
        }
    }
}
