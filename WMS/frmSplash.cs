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
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            progressBar.PerformStep();

            if (progressBar.Value == progressBar.Maximum)
            {
                timer.Enabled = false;
                this.Hide();
                new frmLogin().ShowDialog();
            }
            
        }
    }
}
