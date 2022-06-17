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
    public partial class frmCountry : Form
    {
        private string selectedCountryName;
        public frmCountry()
        {
            InitializeComponent();
        }

        private void btnAddCountry_Click(object sender, EventArgs e)
        {
            if (txtCountryName.Text == "")
            {
                MessageBox.Show("لطفا همه فیلد ها رو تکمیل کنید");
            }
            else
            {
                int c = (int)this.countryTableAdapter.CheckDuplicateRecord(txtCountryName.Text);
                if (c > 0)
                {
                    DialogResult d = MessageBox.Show("این رکورد قبلا ثبت شده است ", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    

                }
                else
                {
                    this.countryTableAdapter.AddNewCountry(txtCountryName.Text);
                    MessageBox.Show("اضافه شد");
                }
                frmCountry_Load(sender, e);
            }
        }

        private void frmCountry_Load(object sender, EventArgs e)
        {
            this.countryTableAdapter.Fill(this.dsWMS.country);
            txtCountryName.Clear();
        }

        private void btnUpdateCountry_Click(object sender, EventArgs e)
        {
            this.countryTableAdapter.UpdateCountry(txtCountryName.Text, selectedCountryName);
            frmCountry_Load(sender, e);
            MessageBox.Show("ویرایش شد"); 
        }

        private void dgvCountry_MouseUp(object sender, MouseEventArgs e)
        {
            txtCountryName.Text = dgvCountry[0, dgvCountry.CurrentRow.Index].Value.ToString();
            selectedCountryName = txtCountryName.Text;
        }

        private void btnDeleteCountry_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا مایل به حذف هستید؟", "پیام", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.countryTableAdapter.DeleteCountry(txtCountryName.Text);
                frmCountry_Load(sender, e);
                MessageBox.Show("حذف شد");
            }
        }

        private void btnSearchCountry_Click(object sender, EventArgs e)
        {
            this.countryTableAdapter.FillByConditionalSearch(dsWMS.country, txtCountryName.Text);
        }

        private void btnPrintCountries_Click(object sender, EventArgs e)
        {
            PrintDGV.printDataGridView(dgvCountry);
        }
        }
    }
