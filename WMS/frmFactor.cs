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
    public partial class frmFactor : Form
    {
        public frmFactor()
        {
            InitializeComponent();
        }
        string sh;
        private void buttonX1_Click(object sender, EventArgs e)
        {
            new frmNewFactor().ShowDialog();
        }

        private void frmFactor_Load(object sender, EventArgs e)
        {
            panelEx1.Visible = false;
            DataTable dt = new DataTable();
            DataBase db = new DataBase();
            dt = db.MySelect("select * from factor");
            dataGridViewX1.DataSource = dt;
            dataGridViewX1.Columns[0].HeaderText = " کد فاکتور";
            dataGridViewX1.Columns[1].HeaderText = "فروشنده ";
            dataGridViewX1.Columns[2].HeaderText = "خریدار";
            dataGridViewX1.Columns[3].HeaderText = "تاریخ صدور";
            dataGridViewX1.Columns[4].HeaderText = "شماره رسید";
            dataGridViewX1.Columns[5].HeaderText = "تعداد اقلام";
            if(dataGridViewX1.RowCount>1)
            sh=dataGridViewX1[0,0].Value.ToString();
            dt = db.MySelect("select * from aghlam where shfact='"+sh+"'");
            dataGridViewX2.DataSource = dt;
            dataGridViewX2.Columns[0].HeaderText = "کدکالا";
            dataGridViewX2.Columns[1].HeaderText = "کد فاکتور";
            dataGridViewX2.Columns[2].HeaderText = "نام کالا ";
            dataGridViewX2.Columns[3].HeaderText = "توضیحات";
            dataGridViewX2.Columns[4].HeaderText = "کشور سازنده";
            dataGridViewX2.Columns[5].HeaderText = " نام انبار";
            dataGridViewX2.Columns[6].HeaderText = "تعداد";
            dataGridViewX2.Columns[7].HeaderText = "واحد";
            dataGridViewX2.Columns[8].HeaderText = "قیمت واحد";
            dataGridViewX2.Columns[9].HeaderText = "قیمت کل";
            dataGridViewX2.Columns[10].HeaderText = " تاریخ ثیت";
            
        }

        private void dataGridViewX1_MouseUp(object sender, MouseEventArgs e)
        {
            DataTable dt = new DataTable();
            DataBase db = new DataBase();
            sh = dataGridViewX1[0,dataGridViewX1.CurrentRow.Index].Value.ToString();
            dt = db.MySelect("select *from aghlam where shfact='" + sh + "'");
            dataGridViewX2.DataSource = dt;
            dataGridViewX2.Columns[0].HeaderText = "کدکالا";
            dataGridViewX2.Columns[1].HeaderText = "کد فاکتور";
            dataGridViewX2.Columns[2].HeaderText = "نام کالا ";
            dataGridViewX2.Columns[3].HeaderText = "توضیحات";
            dataGridViewX2.Columns[4].HeaderText = "کشور سازنده";
            dataGridViewX2.Columns[5].HeaderText = " نام انبار";
            dataGridViewX2.Columns[6].HeaderText = "تعداد";
            dataGridViewX2.Columns[7].HeaderText = "واحد";
            dataGridViewX2.Columns[8].HeaderText = "قیمت واحد";
            dataGridViewX2.Columns[9].HeaderText = "قیمت کل";
            dataGridViewX2.Columns[10].HeaderText = " تاریخ ثیت";

            int sum = 0;
            for (int i = 0; i < dataGridViewX1.RowCount-1; i++)
            {
                string price;
                if (dataGridViewX2.RowCount > 1)
                    price = dataGridViewX2[9, i].Value.ToString();
                else if (dataGridViewX2.RowCount == 1)
                {
                    price = dataGridViewX2[9, 0].Value.ToString();
                    sum += int.Parse(price);
                    break;
                }
                else {
                    sum = 0;
                    break;
                }
                sum += int.Parse(price);
            }
            lab_ghimat_kol.Text = sum.ToString();
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            db.DoCommand("delete from factor where id='"+sh+"'");
            db.DoCommand("delete from aghlam where shfact='" + sh + "'");
            frmFactor_Load(sender, e);
            MessageBox.Show("حذف شد","پیام",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            frmFactor_Load(sender,e);
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            panelEx1.Visible = true;
        }

        private void buttonX6_Click(object sender, EventArgs e)
        {
            string str = "select * from factor where ";
            if (txt_tahvilgirandeh.Text != "") str += "custumer like '%" + txt_tahvilgirandeh.Text + "' and ";

            if (txt_code_factor.Text != "") str += "id='" + txt_code_factor.Text + "' and ";
            if (str == "select * from factor where ")
                str = "select * from factor";
            else
                str = str.Remove(str.Length - 4, 4);
            DataTable dt = new DataTable();
            DataBase db = new DataBase();
            dt = db.MySelect(str);
            MessageBox.Show(dt.Rows.Count.ToString() + "مورد یافت شد");
            dataGridViewX1.DataSource = dt;
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            panelEx1.Visible = false;
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
    }
}
