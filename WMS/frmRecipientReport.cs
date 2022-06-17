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
    public partial class frmRecipientReport : Form
    {
        public frmRecipientReport()
        {
            InitializeComponent();
        }

        private void frmRecipientReport_Load(object sender, EventArgs e)
        {
            this.tahvilgirandehTableAdapter.Fill(this.dsWMS.tahvilgirandeh);
        }

        private void btnRecipientCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPrintRecipients_Click(object sender, EventArgs e)
        {
            PrintDGV.printDataGridView(dgvRecipient);
        }
    }
}