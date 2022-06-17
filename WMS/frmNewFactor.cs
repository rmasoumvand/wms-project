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
        string shfact;
        string a;
        int index;
        public frmNewFactor()
        {
            InitializeComponent();
        }
        private void frmNewFactor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsWMS1.aghlam' table. You can move, or remove it, as needed.

            this.anbarTableAdapter.Fill(this.dsWMS.anbar);
            this.foroshandehTableAdapter.FillBySellersNameFamily(dsWMS.foroshandeh);
            this.tahvilgirandehTableAdapter.FillByRecipientsNameFamily(dsWMS.tahvilgirandeh);
            txtFactorDate.Text = utils.Instance.getPersianDate();
        }

        void show()
        {
            DataTable dt = new DataTable();
            DataBase db = new DataBase();
            dt = db.MySelect("select *from aghlam  where shfact='" + txtFactorNumber.Text + "'");
            dgvNewFactorCommodities.DataSource = dt;
            dgvNewFactorCommodities.Columns[0].HeaderText = "کد";
            dgvNewFactorCommodities.Columns[1].HeaderText = "کد فاکتور";
            dgvNewFactorCommodities.Columns[2].HeaderText = "نام ";
            dgvNewFactorCommodities.Columns[3].HeaderText = "توضیحات";
            dgvNewFactorCommodities.Columns[4].HeaderText = "کشور سازنده";
            dgvNewFactorCommodities.Columns[5].HeaderText = " نام انبار";
            dgvNewFactorCommodities.Columns[6].HeaderText = "تعداد";
            dgvNewFactorCommodities.Columns[7].HeaderText = "واحد";
            dgvNewFactorCommodities.Columns[8].HeaderText = "قیمت واحد";
            dgvNewFactorCommodities.Columns[9].HeaderText = "قیمت کل";
            dgvNewFactorCommodities.Columns[10].HeaderText = " تاریخ ثیت";

            dt = db.MySelect("select cter from kala where name='" + cmbNewFactorCommodityName.Text + "'");
            //    dataGridViewX2.Visible = false;
            dataGridViewX2.DataSource = dt;
            txtNewFactorInventory.Text = dataGridViewX2[0, 0].Value.ToString();
        }
        private void comboBoxEx4_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataBase db = new DataBase();

                DataTable dt4 = new DataTable();
                dt4 = db.MySelect("select des from kala where name='" + cmbNewFactorCommodityName.Text + "'");
                cmbNewFactorCommodityDesc.DataSource = dt4;
                cmbNewFactorCommodityDesc.DisplayMember = "des";

                DataTable dt5 = new DataTable();
                dt5 = db.MySelect("select cter from kala where name='" + cmbNewFactorCommodityName.Text + "' and des='" + cmbNewFactorCommodityDesc.Text + "'");
                dataGridViewX2.DataSource = dt5;
                txtNewFactorInventory.Text = dataGridViewX2[0, 0].Value.ToString();

                DataTable dt6 = new DataTable();
                dt6 = db.MySelect("select unitprice from kala where name='" + cmbNewFactorCommodityName.Text + "' and des='" + cmbNewFactorCommodityDesc.Text + "'");
                cmbNewFactorCommodityUnitPrice.DataSource = dt6;
                cmbNewFactorCommodityUnitPrice.DisplayMember = "unitprice";


                DataTable dt7 = new DataTable();
                dt7 = db.MySelect("select id from kala where name='" + cmbNewFactorCommodityName.Text + "' and des='" + cmbNewFactorCommodityDesc.Text + "'");
                dataGridViewX3.DataSource = dt7;
                txtNewFactorCommodityCode.Text = dataGridViewX3[0, 0].Value.ToString();
            }
            catch { }

        }

        private void comboBoxEx3_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt4 = new DataTable();
            DataBase db = new DataBase();
            dt4 = db.MySelect("SELECT DISTINCT name FROM kala WHERE anbar='" + cmbWarehouses.Text + "'");
            cmbNewFactorCommodityName.DataSource = dt4;
            cmbNewFactorCommodityName.DisplayMember = "name";
        }

        private void cmb_des_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataBase db = new DataBase();

                DataTable dt5 = new DataTable();
                dt5 = db.MySelect("select cter from kala where name='" + cmbNewFactorCommodityName.Text + "' and des='" + cmbNewFactorCommodityDesc.Text + "'");
                dataGridViewX2.DataSource = dt5;
                txtNewFactorInventory.Text = dataGridViewX2[0, 0].Value.ToString();

                DataTable dt6 = new DataTable();
                dt6 = db.MySelect("select unitprice from kala where name='" + cmbNewFactorCommodityName.Text + "' and des='" + cmbNewFactorCommodityDesc.Text + "'");
                cmbNewFactorCommodityUnitPrice.DataSource = dt6;
                cmbNewFactorCommodityUnitPrice.DisplayMember = "unitprice";


                DataTable dt7 = new DataTable();
                dt7 = db.MySelect("select id from kala where name='" + cmbNewFactorCommodityName.Text + "' and des='" + cmbNewFactorCommodityDesc.Text + "'");
                dataGridViewX3.DataSource = dt7;
                txtNewFactorCommodityCode.Text = dataGridViewX3[0, 0].Value.ToString();
            }
            catch { }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                DataBase db = new DataBase();
                dt = db.MySelect("select shfact from aghlam where shfact='" + txtFactorNumber.Text + "' and name='" + cmbNewFactorCommodityName.Text + "' and des='" + cmbNewFactorCommodityDesc.Text + "' ");
                if (dt.Rows.Count > 0)
                    MessageBox.Show("این کالا قبلا وارد شده است");
                else
                {
                    dt = db.MySelect("select id from kala where name='" + cmbNewFactorCommodityName.Text + "' and des='" + cmbNewFactorCommodityDesc.Text + "' ");
                    dataGridViewX3.DataSource = dt;
                    txtNewFactorCommodityCode.Text = dataGridViewX3[0, 0].Value.ToString();
                    int t = 0;
                    t = int.Parse(cmbNewFactorCommodityUnitPrice.Text) * int.Parse(txtNewFactorCommodityAmount.Text);
                    db.DoCommand("insert into aghlam(name,des,country,anbar,unit,unitprice,tarikh,cter,totalprice,shfact,id) select name,des,country,anbar,unit,unitprice,tarikh, '" + txtNewFactorCommodityAmount.Text + "' as cter,  '" + t.ToString() + "' as totalprice,  '" + txtFactorNumber.Text + "' as shfact,  '" + txtNewFactorCommodityCode.Text + "' as id from kala where name='" + cmbNewFactorCommodityName.Text + "' and des='" + cmbNewFactorCommodityDesc.Text + "'");
                    DataTable dt5 = new DataTable();
                    DataBase db2 = new DataBase();
                    dt5 = db2.MySelect("select * from aghlam  where shfact='" + txtFactorNumber.Text + "'");
                    dgvNewFactorCommodities.DataSource = dt5;
                    dgvNewFactorCommodities.Columns[0].HeaderText = "کد";
                    dgvNewFactorCommodities.Columns[1].HeaderText = "کد فاکتور";
                    dgvNewFactorCommodities.Columns[2].HeaderText = "نام ";
                    dgvNewFactorCommodities.Columns[3].HeaderText = "توضیحات";
                    dgvNewFactorCommodities.Columns[4].HeaderText = "کشور سازنده";
                    dgvNewFactorCommodities.Columns[5].HeaderText = " نام انبار";
                    dgvNewFactorCommodities.Columns[6].HeaderText = "تعداد";
                    dgvNewFactorCommodities.Columns[7].HeaderText = "واحد";
                    dgvNewFactorCommodities.Columns[8].HeaderText = "قیمت واحد";
                    dgvNewFactorCommodities.Columns[9].HeaderText = "قیمت کل";
                    dgvNewFactorCommodities.Columns[10].HeaderText = " تاریخ ثیت";
                    show();
                }
            }
            catch { }
        }

        private void dataGridViewX1_MouseUp(object sender, MouseEventArgs e)
        {
            txtNewFactorCommodityAmount.Text = dgvNewFactorCommodities[6, dgvNewFactorCommodities.CurrentRow.Index].Value.ToString();
            cmbWarehouses.Text = dgvNewFactorCommodities[5, dgvNewFactorCommodities.CurrentRow.Index].Value.ToString();
            shfact = dgvNewFactorCommodities[1, dgvNewFactorCommodities.CurrentRow.Index].Value.ToString();
            cmbNewFactorCommodityName.Text = dgvNewFactorCommodities[2, dgvNewFactorCommodities.CurrentRow.Index].Value.ToString();
            index = dgvNewFactorCommodities.CurrentRow.Index;
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا مایل به حذف هستید؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataBase db = new DataBase();
                a = dgvNewFactorCommodities[2, index].Value.ToString();
                int b = 0;
                b = int.Parse(dgvNewFactorCommodities[6, index].Value.ToString());
                string fi;
                fi = dgvNewFactorCommodities[8, index].Value.ToString();
                db.DoCommand("delete from aghlam where name='" + a + "'and shfact='" + txtFactorNumber.Text + "'");
                show();
                string t;
                t = (dgvNewFactorCommodities.RowCount - 1).ToString();
                db.DoCommand("update factor set t_kala='" + t + "' where id='" + txtFactorNumber.Text + "'");
                DataTable dt = new DataTable();
                dt = db.MySelect("select id from factor where id='" + txtFactorNumber.Text + "'");
                if (dt.Rows.Count <= 0) { }
                else
                {
                    int totall = 0;
                    dt = db.MySelect("select cter from kala where name='" + a + "'");
                    comboBox1.DataSource = dt;
                    comboBox1.DisplayMember = "cter";
                    int count;
                    int c;
                    c = int.Parse(comboBox1.Text);
                    count = c + b;//cter final
                    totall = count * int.Parse(fi);//totall price
                    db.DoCommand("update kala set cter='" + count.ToString() + "',totalprice='" + totall.ToString() + "' where name='" + a + "'");
                    show();
                }
            }
            else { }
        }

        private void btnSaveNewFactor_Click(object sender, EventArgs e)
        {
            if (txtFactorNumber.Text == "" || txtFactorDate.Text == "" || txtNewFactorCommodityAmount.Text == "")
            {
                MessageBox.Show("پرشون کن");
            }
            else
            {
                btnAddFactorItem.Enabled = false;
                DataBase db = new DataBase();
                DataTable dt = new DataTable();
                dt = db.MySelect("select *from factor where id='" + txtFactorNumber.Text + "'");
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("این فاکتور قبلا ثبت شده است");
                }
                else
                {
                    string t;
                    t = (dgvNewFactorCommodities.RowCount).ToString();
                    db.DoCommand("insert into factor(id,seller,custumer,dt,num_res_anbar,t_kala) values('" + txtFactorNumber.Text + "','" + cmbFactorSellers.Text + "','" + cmbRecipients.Text + "','" + txtFactorDate.Text + "','" + txtNewFactorRecientNumber.Text + "','" + t + "')");
                    MessageBox.Show("ثبت شد", "پیام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    for (int i = 0; i < dgvNewFactorCommodities.RowCount - 1; i++)
                    {
                        a = dgvNewFactorCommodities[2, i].Value.ToString();
                        int b = 0;
                        b = int.Parse(dgvNewFactorCommodities[6, i].Value.ToString());
                        int totall = 0;
                        dt = db.MySelect("select cter from kala where name='" + a + "'");
                        comboBox1.DataSource = dt;
                        comboBox1.DisplayMember = "cter";
                        int count;
                        int c;
                        c = int.Parse(comboBox1.Text);
                        count = c - b;//cter final
                        totall = count * int.Parse(dgvNewFactorCommodities[8, i].Value.ToString());//totall price
                        db.DoCommand("update kala set cter='" + count.ToString() + "',totalprice='" + totall.ToString() + "' where name='" + a + "'");

                    }
                }
            }
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

        private void textBoxX1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBoxX6_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBoxX4_KeyPress(object sender, KeyPressEventArgs e)
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
