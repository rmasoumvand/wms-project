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
    public partial class frmWarehouse : Form
    {
        private int selectedWarehouseId;
        public frmWarehouse()
        {
            InitializeComponent();
        }

        private void btnAddWarehouse_Click(object sender, EventArgs e)
        {
            if (txtWarhouseName.Text == "" || txtWarhouseType.Text == "")
            {
                MessageBox.Show("لطفا همه فیلد ها رو تکمیل کنید");
            }
            else
            {
                int c = (int)this.anbarTableAdapter.CheckDuplicateRecord(txtWarhouseName.Text);  
                if (c > 0)
                {
                    DialogResult d = MessageBox.Show("این رکورد قبلا ثبت شده است ", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    this.anbarTableAdapter.AddNewWarehouse(txtWarhouseName.Text, txtWarhouseType.Text, txtWarhouseManager.Text);
                    MessageBox.Show("اضافه شد");
                }
                frmWarehouse_Load(sender, e);
            }
        }

        private void frmWarehouse_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsWMS.anbar' table. You can move, or remove it, as needed.
            this.anbarTableAdapter.Fill(this.dsWMS.anbar);
            txtWarhouseName.Clear();
            txtWarhouseType.Clear();
            txtWarhouseManager.Clear();
        }

        private void btnUpdateWarehouse_Click(object sender, EventArgs e)
        {
            this.anbarTableAdapter.UpdateWarehouse(txtWarhouseName.Text, txtWarhouseType.Text, txtWarhouseManager.Text, selectedWarehouseId);
            frmWarehouse_Load(sender, e);
            MessageBox.Show("ویرایش شد"); 
        }

        private void dgvWarehouse_MouseUp(object sender, MouseEventArgs e)
        {
            selectedWarehouseId = int.Parse(dgvWarhouses[0, dgvWarhouses.CurrentRow.Index].Value.ToString());
            txtWarhouseName.Text = dgvWarhouses[1, dgvWarhouses.CurrentRow.Index].Value.ToString();
            txtWarhouseType.Text = dgvWarhouses[2, dgvWarhouses.CurrentRow.Index].Value.ToString();
            txtWarhouseManager.Text = dgvWarhouses[3, dgvWarhouses.CurrentRow.Index].Value.ToString();
        }

        private void btnDeleteWarehouse_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا مایل به حذف هستید؟", "پیام", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.anbarTableAdapter.DeleteWarehouse(selectedWarehouseId);
                frmWarehouse_Load(sender, e);
                MessageBox.Show("حذف شد");
            }
            else { }
        }

        private void btnSearchWarehouse_Click(object sender, EventArgs e)
        {
            this.anbarTableAdapter.FillByConditionalSearch(dsWMS.anbar, txtWarhouseName.Text, txtWarhouseType.Text, txtWarhouseManager.Text);
        }

        private void btnPrintWarehouses_Click(object sender, EventArgs e)
        {
            PrintDGV.printDataGridView(dgvWarhouses);
        }
    }
}
