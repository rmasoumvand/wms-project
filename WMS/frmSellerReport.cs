﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WMS
{
    public partial class frmSellerReport : Form
    {
        public frmSellerReport()
        {
            InitializeComponent();
        }

        private void frmSellerReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsWMS.foroshandeh' table. You can move, or remove it, as needed.
            this.foroshandehTableAdapter.Fill(this.dsWMS.foroshandeh);
        }

        private void btnSellersCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrintSellers_Click(object sender, EventArgs e)
        {
            PrintDGV.printDataGridView(dataGridViewX1);
        }
    }
}
