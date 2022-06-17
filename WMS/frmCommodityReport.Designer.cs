namespace WMS
{
    partial class frmCommodityReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCommodities = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.ribbonClientPanel1 = new DevComponents.DotNetBar.Ribbon.RibbonClientPanel();
            this.btnCommodityCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnPrintCommodities = new DevComponents.DotNetBar.ButtonX();
            this.dsWMS = new WMS.dsWMS();
            this.kalaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kalaTableAdapter = new WMS.dsWMSTableAdapters.kalaTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anbarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarikhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommodities)).BeginInit();
            this.ribbonClientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsWMS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kalaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCommodities
            // 
            this.dgvCommodities.AllowUserToAddRows = false;
            this.dgvCommodities.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvCommodities.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCommodities.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCommodities.AutoGenerateColumns = false;
            this.dgvCommodities.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCommodities.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCommodities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCommodities.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.desDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn,
            this.anbarDataGridViewTextBoxColumn,
            this.cterDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn,
            this.unitpriceDataGridViewTextBoxColumn,
            this.totalpriceDataGridViewTextBoxColumn,
            this.tarikhDataGridViewTextBoxColumn});
            this.dgvCommodities.DataSource = this.kalaBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCommodities.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCommodities.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvCommodities.Location = new System.Drawing.Point(0, 0);
            this.dgvCommodities.MultiSelect = false;
            this.dgvCommodities.Name = "dgvCommodities";
            this.dgvCommodities.ReadOnly = true;
            this.dgvCommodities.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvCommodities.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCommodities.Size = new System.Drawing.Size(883, 376);
            this.dgvCommodities.TabIndex = 0;
            // 
            // ribbonClientPanel1
            // 
            this.ribbonClientPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ribbonClientPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.ribbonClientPanel1.Controls.Add(this.btnCommodityCancel);
            this.ribbonClientPanel1.Controls.Add(this.btnPrintCommodities);
            this.ribbonClientPanel1.Location = new System.Drawing.Point(0, 376);
            this.ribbonClientPanel1.Name = "ribbonClientPanel1";
            this.ribbonClientPanel1.Size = new System.Drawing.Size(883, 33);
            // 
            // 
            // 
            this.ribbonClientPanel1.Style.Class = "RibbonClientPanel";
            this.ribbonClientPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonClientPanel1.StyleMouseDown.Class = "";
            this.ribbonClientPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonClientPanel1.StyleMouseOver.Class = "";
            this.ribbonClientPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonClientPanel1.TabIndex = 1;
            // 
            // btnCommodityCancel
            // 
            this.btnCommodityCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCommodityCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCommodityCancel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCommodityCancel.Location = new System.Drawing.Point(422, 3);
            this.btnCommodityCancel.Name = "btnCommodityCancel";
            this.btnCommodityCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCommodityCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCommodityCancel.TabIndex = 2;
            this.btnCommodityCancel.Text = "انصراف";
            this.btnCommodityCancel.Click += new System.EventHandler(this.btnCommodityCancel_Click);
            // 
            // btnPrintCommodities
            // 
            this.btnPrintCommodities.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPrintCommodities.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPrintCommodities.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintCommodities.Location = new System.Drawing.Point(341, 3);
            this.btnPrintCommodities.Name = "btnPrintCommodities";
            this.btnPrintCommodities.Size = new System.Drawing.Size(75, 23);
            this.btnPrintCommodities.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPrintCommodities.TabIndex = 0;
            this.btnPrintCommodities.Text = "چاپ";
            this.btnPrintCommodities.Click += new System.EventHandler(this.btnPrintCommodities_Click);
            // 
            // dsWMS
            // 
            this.dsWMS.DataSetName = "dsWMS";
            this.dsWMS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kalaBindingSource
            // 
            this.kalaBindingSource.DataMember = "kala";
            this.kalaBindingSource.DataSource = this.dsWMS;
            // 
            // kalaTableAdapter
            // 
            this.kalaTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "کد";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "نام کالا";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // desDataGridViewTextBoxColumn
            // 
            this.desDataGridViewTextBoxColumn.DataPropertyName = "des";
            this.desDataGridViewTextBoxColumn.HeaderText = "توضیحات";
            this.desDataGridViewTextBoxColumn.Name = "desDataGridViewTextBoxColumn";
            this.desDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "کشور سازنده";
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            this.countryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // anbarDataGridViewTextBoxColumn
            // 
            this.anbarDataGridViewTextBoxColumn.DataPropertyName = "anbar";
            this.anbarDataGridViewTextBoxColumn.HeaderText = "نام انبار";
            this.anbarDataGridViewTextBoxColumn.Name = "anbarDataGridViewTextBoxColumn";
            this.anbarDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cterDataGridViewTextBoxColumn
            // 
            this.cterDataGridViewTextBoxColumn.DataPropertyName = "cter";
            this.cterDataGridViewTextBoxColumn.HeaderText = "تعداد";
            this.cterDataGridViewTextBoxColumn.Name = "cterDataGridViewTextBoxColumn";
            this.cterDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unitDataGridViewTextBoxColumn
            // 
            this.unitDataGridViewTextBoxColumn.DataPropertyName = "unit";
            this.unitDataGridViewTextBoxColumn.HeaderText = "واحد";
            this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            this.unitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unitpriceDataGridViewTextBoxColumn
            // 
            this.unitpriceDataGridViewTextBoxColumn.DataPropertyName = "unitprice";
            this.unitpriceDataGridViewTextBoxColumn.HeaderText = "قیمت واحد";
            this.unitpriceDataGridViewTextBoxColumn.Name = "unitpriceDataGridViewTextBoxColumn";
            this.unitpriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalpriceDataGridViewTextBoxColumn
            // 
            this.totalpriceDataGridViewTextBoxColumn.DataPropertyName = "totalprice";
            this.totalpriceDataGridViewTextBoxColumn.HeaderText = "قیمت کل";
            this.totalpriceDataGridViewTextBoxColumn.Name = "totalpriceDataGridViewTextBoxColumn";
            this.totalpriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tarikhDataGridViewTextBoxColumn
            // 
            this.tarikhDataGridViewTextBoxColumn.DataPropertyName = "tarikh";
            this.tarikhDataGridViewTextBoxColumn.HeaderText = "تاریخ ثبت";
            this.tarikhDataGridViewTextBoxColumn.Name = "tarikhDataGridViewTextBoxColumn";
            this.tarikhDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmCommodityReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 408);
            this.Controls.Add(this.ribbonClientPanel1);
            this.Controls.Add(this.dgvCommodities);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1280, 446);
            this.Name = "Form_report_kala";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "گزارش کالاهای انبار";
            this.Load += new System.EventHandler(this.frmCommodity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommodities)).EndInit();
            this.ribbonClientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsWMS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kalaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgvCommodities;
        private DevComponents.DotNetBar.Ribbon.RibbonClientPanel ribbonClientPanel1;
        private DevComponents.DotNetBar.ButtonX btnCommodityCancel;
        private DevComponents.DotNetBar.ButtonX btnPrintCommodities;
        private dsWMS dsWMS;
        private System.Windows.Forms.BindingSource kalaBindingSource;
        private dsWMSTableAdapters.kalaTableAdapter kalaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn desDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anbarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarikhDataGridViewTextBoxColumn;
    }
}