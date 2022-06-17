namespace WMS
{
    partial class frmInventoryReport
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
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtInventory = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cmbWarehouse = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.anbarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsWMS = new WMS.dsWMS();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
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
            this.kalaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_print = new DevComponents.DotNetBar.ButtonX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.controlContainerItem1 = new DevComponents.DotNetBar.ControlContainerItem();
            this.ribbonClientPanel1 = new DevComponents.DotNetBar.Ribbon.RibbonClientPanel();
            this.kalaTableAdapter = new WMS.dsWMSTableAdapters.kalaTableAdapter();
            this.anbarTableAdapter = new WMS.dsWMSTableAdapters.anbarTableAdapter();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anbarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWMS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kalaBindingSource)).BeginInit();
            this.ribbonClientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Controls.Add(this.txtInventory);
            this.groupPanel1.Controls.Add(this.cmbWarehouse);
            this.groupPanel1.Controls.Add(this.dataGridViewX1);
            this.groupPanel1.Controls.Add(this.btn_print);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel1.Location = new System.Drawing.Point(11, 6);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(739, 306);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.Class = "";
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.Class = "";
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.Class = "";
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 10;
            this.groupPanel1.Text = "اطلاعات";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(414, 10);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 14;
            this.labelX1.Text = ":موجودی کل";
            // 
            // txtInventory
            // 
            // 
            // 
            // 
            this.txtInventory.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.txtInventory.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.txtInventory.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.txtInventory.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.txtInventory.Border.Class = "TextBoxBorder";
            this.txtInventory.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtInventory.Enabled = false;
            this.txtInventory.Location = new System.Drawing.Point(281, 12);
            this.txtInventory.Name = "txtInventory";
            this.txtInventory.Size = new System.Drawing.Size(127, 21);
            this.txtInventory.TabIndex = 13;
            // 
            // cmbWarehouse
            // 
            this.cmbWarehouse.DataSource = this.anbarBindingSource;
            this.cmbWarehouse.DisplayMember = "name";
            this.cmbWarehouse.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbWarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWarehouse.FormattingEnabled = true;
            this.cmbWarehouse.ItemHeight = 15;
            this.cmbWarehouse.Location = new System.Drawing.Point(519, 12);
            this.cmbWarehouse.Name = "cmbWarehouse";
            this.cmbWarehouse.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbWarehouse.Size = new System.Drawing.Size(161, 21);
            this.cmbWarehouse.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbWarehouse.TabIndex = 12;
            this.cmbWarehouse.SelectedIndexChanged += new System.EventHandler(this.comboBoxEx1_SelectedIndexChanged);
            // 
            // anbarBindingSource
            // 
            this.anbarBindingSource.DataMember = "anbar";
            this.anbarBindingSource.DataSource = this.dsWMS;
            // 
            // dsWMS
            // 
            this.dsWMS.DataSetName = "dsWMS";
            this.dsWMS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.AllowUserToAddRows = false;
            this.dataGridViewX1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewX1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewX1.AutoGenerateColumns = false;
            this.dataGridViewX1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewX1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridViewX1.DataSource = this.kalaBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(3, 47);
            this.dataGridViewX1.MultiSelect = false;
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.ReadOnly = true;
            this.dataGridViewX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridViewX1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewX1.Size = new System.Drawing.Size(727, 234);
            this.dataGridViewX1.TabIndex = 11;
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
            this.nameDataGridViewTextBoxColumn.HeaderText = "نام";
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
            // kalaBindingSource
            // 
            this.kalaBindingSource.DataMember = "kala";
            this.kalaBindingSource.DataSource = this.dsWMS;
            // 
            // btn_print
            // 
            this.btn_print.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_print.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_print.Location = new System.Drawing.Point(3, 12);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(240, 23);
            this.btn_print.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_print.TabIndex = 2;
            this.btn_print.Text = "چاپ";
            this.btn_print.Click += new System.EventHandler(this.btnPrintInventories_Click);
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(681, 9);
            this.labelX2.Name = "labelX2";
            this.labelX2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX2.Size = new System.Drawing.Size(49, 23);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "نام انبار";
            // 
            // controlContainerItem1
            // 
            this.controlContainerItem1.AllowItemResize = true;
            this.controlContainerItem1.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem1.Name = "controlContainerItem1";
            // 
            // ribbonClientPanel1
            // 
            this.ribbonClientPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.ribbonClientPanel1.Controls.Add(this.groupPanel1);
            this.ribbonClientPanel1.Location = new System.Drawing.Point(0, 0);
            this.ribbonClientPanel1.Name = "ribbonClientPanel1";
            this.ribbonClientPanel1.Size = new System.Drawing.Size(877, 329);
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
            this.ribbonClientPanel1.TabIndex = 15;
            // 
            // kalaTableAdapter
            // 
            this.kalaTableAdapter.ClearBeforeFill = true;
            // 
            // anbarTableAdapter
            // 
            this.anbarTableAdapter.ClearBeforeFill = true;
            // 
            // frmInventoryReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 322);
            this.Controls.Add(this.ribbonClientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmInventoryReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "موجودی انبار";
            this.Load += new System.EventHandler(this.frmInventoryReport_Load);
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.anbarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWMS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kalaBindingSource)).EndInit();
            this.ribbonClientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private DevComponents.DotNetBar.ButtonX btn_print;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem1;
        private DevComponents.DotNetBar.Ribbon.RibbonClientPanel ribbonClientPanel1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbWarehouse;
        private DevComponents.DotNetBar.Controls.TextBoxX txtInventory;
        private DevComponents.DotNetBar.LabelX labelX1;
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
        private System.Windows.Forms.BindingSource anbarBindingSource;
        private dsWMSTableAdapters.anbarTableAdapter anbarTableAdapter;
    }
}