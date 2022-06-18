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
    public partial class frmFactor : Form
    {
        private int calculateTotalSum()
        {
            int sum = 0;
            for (int i = 0; i < dgvFactors.RowCount - 1; i++)
            {
                string price;
                if (dgvCommodities.RowCount > 1)
                    price = dgvCommodities[9, i].Value.ToString();
                else if (dgvCommodities.RowCount == 1)
                {
                    price = dgvCommodities[9, 0].Value.ToString();
                    sum += int.Parse(price);
                    break;
                }
                else
                {
                    sum = 0;
                    break;
                }
                sum += int.Parse(price);
            }
            return sum;
        }
        public frmFactor()
        {
            InitializeComponent();
        }
        private string selectedFactorId;
        private void btnAddEdit_Click(object sender, EventArgs e)
        {
            new frmNewFactor().ShowDialog();
            selectedFactorId = null;
        }

        private void frmFactor_Load(object sender, EventArgs e)
        {
            this.factorTableAdapter.Fill(this.dsWMS.factor);
            panelSearchFactor.Visible = false;
            lblTotalPrice.Text = calculateTotalSum().ToString();
        }

        private void dgvFactors_MouseUp(object sender, MouseEventArgs e)
        {
            selectedFactorId = dgvFactors[0,dgvFactors.CurrentRow.Index].Value.ToString();
            if (selectedFactorId != null)
            {
                this.aghlamTableAdapter.FillByAghlamFactorNumber(this.dsWMS.aghlam, selectedFactorId);
                lblTotalPrice.Text = calculateTotalSum().ToString();
            }
        }

        private void btnDeleteFactor_Click(object sender, EventArgs e)
        {
            if (selectedFactorId != null)
            {
                this.factorTableAdapter.DeleteFactor(selectedFactorId);
                this.aghlamTableAdapter.DeleteAghlam(selectedFactorId);
                MessageBox.Show("حذف شد", "پیام", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            frmFactor_Load(sender, e);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            frmFactor_Load(sender,e);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            panelSearchFactor.Visible = true;
        }

        private void btnPanelSearchFactor_Click(object sender, EventArgs e)
        {
            this.factorTableAdapter.FillByFactorId(this.dsWMS.factor, txtPanelFactorCode.Text, txtPanelFactorRecipient.Text);
            lblTotalPrice.Text = calculateTotalSum().ToString();
            panelSearchFactor.Visible = false;
        }

        private void btnExitSearchFactor_Click(object sender, EventArgs e)
        {
            panelSearchFactor.Visible = false;
        }

        private void txtPanelFactorCode_KeyPress(object sender, KeyPressEventArgs e)
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
