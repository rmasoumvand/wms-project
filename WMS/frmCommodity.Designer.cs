namespace WMS
{
    partial class frmCommodity
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCommodity));
            this.ribbonClientPanel1 = new DevComponents.DotNetBar.Ribbon.RibbonClientPanel();
            this.dgvCommodity = new DevComponents.DotNetBar.Controls.DataGridViewX();
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
            this.dsWMS = new WMS.dsWMS();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.cmbCommodityWarehouse = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.anbarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.cmbCommodityUnit = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.unitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnPrintCommodities = new DevComponents.DotNetBar.ButtonX();
            this.btnDeleteCommodity = new DevComponents.DotNetBar.ButtonX();
            this.btnAddCommodity = new DevComponents.DotNetBar.ButtonX();
            this.btnSearchCommodity = new DevComponents.DotNetBar.ButtonX();
            this.btnEditCommodity = new DevComponents.DotNetBar.ButtonX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.txtCommodityUnitPrice = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtCommodityAmount = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtCommodityDate = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.cmbCommodityCountry = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.countryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtCommodityName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtCommodityDesc = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.kalaTableAdapter = new WMS.dsWMSTableAdapters.kalaTableAdapter();
            this.anbarTableAdapter = new WMS.dsWMSTableAdapters.anbarTableAdapter();
            this.unitTableAdapter = new WMS.dsWMSTableAdapters.unitTableAdapter();
            this.countryTableAdapter = new WMS.dsWMSTableAdapters.countryTableAdapter();
            this.anbarBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.countryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.unitBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ribbonClientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommodity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kalaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWMS)).BeginInit();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anbarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anbarBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonClientPanel1
            // 
            this.ribbonClientPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ribbonClientPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.ribbonClientPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonClientPanel1.Controls.Add(this.dgvCommodity);
            this.ribbonClientPanel1.Controls.Add(this.groupPanel1);
            this.ribbonClientPanel1.Location = new System.Drawing.Point(0, 0);
            this.ribbonClientPanel1.Name = "ribbonClientPanel1";
            this.ribbonClientPanel1.Size = new System.Drawing.Size(670, 436);
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
            this.ribbonClientPanel1.TabIndex = 0;
            // 
            // dgvCommodity
            // 
            this.dgvCommodity.AllowUserToAddRows = false;
            this.dgvCommodity.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvCommodity.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCommodity.AutoGenerateColumns = false;
            this.dgvCommodity.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCommodity.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCommodity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCommodity.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgvCommodity.DataSource = this.kalaBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCommodity.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCommodity.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvCommodity.Location = new System.Drawing.Point(12, 203);
            this.dgvCommodity.MultiSelect = false;
            this.dgvCommodity.Name = "dgvCommodity";
            this.dgvCommodity.ReadOnly = true;
            this.dgvCommodity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvCommodity.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCommodity.Size = new System.Drawing.Size(644, 222);
            this.dgvCommodity.TabIndex = 1;
            this.dgvCommodity.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dgvCommodity_MouseUp);
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
            this.countryDataGridViewTextBoxColumn.HeaderText = "کشور";
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
            // dsWMS
            // 
            this.dsWMS.DataSetName = "dsWMS";
            this.dsWMS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.cmbCommodityWarehouse);
            this.groupPanel1.Controls.Add(this.labelX8);
            this.groupPanel1.Controls.Add(this.cmbCommodityUnit);
            this.groupPanel1.Controls.Add(this.btnPrintCommodities);
            this.groupPanel1.Controls.Add(this.btnDeleteCommodity);
            this.groupPanel1.Controls.Add(this.btnAddCommodity);
            this.groupPanel1.Controls.Add(this.btnSearchCommodity);
            this.groupPanel1.Controls.Add(this.btnEditCommodity);
            this.groupPanel1.Controls.Add(this.labelX7);
            this.groupPanel1.Controls.Add(this.txtCommodityUnitPrice);
            this.groupPanel1.Controls.Add(this.txtCommodityAmount);
            this.groupPanel1.Controls.Add(this.txtCommodityDate);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.labelX5);
            this.groupPanel1.Controls.Add(this.labelX6);
            this.groupPanel1.Controls.Add(this.cmbCommodityCountry);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Controls.Add(this.txtCommodityName);
            this.groupPanel1.Controls.Add(this.txtCommodityDesc);
            this.groupPanel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel1.Location = new System.Drawing.Point(12, 12);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(644, 185);
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
            this.groupPanel1.TabIndex = 1;
            this.groupPanel1.Text = "مشخصات کالا";
            // 
            // cmbCommodityWarehouse
            // 
            this.cmbCommodityWarehouse.DataSource = this.anbarBindingSource1;
            this.cmbCommodityWarehouse.DisplayMember = "name";
            this.cmbCommodityWarehouse.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCommodityWarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCommodityWarehouse.FormattingEnabled = true;
            this.cmbCommodityWarehouse.ItemHeight = 15;
            this.cmbCommodityWarehouse.Location = new System.Drawing.Point(409, 102);
            this.cmbCommodityWarehouse.Name = "cmbCommodityWarehouse";
            this.cmbCommodityWarehouse.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbCommodityWarehouse.Size = new System.Drawing.Size(131, 21);
            this.cmbCommodityWarehouse.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbCommodityWarehouse.TabIndex = 22;
            // 
            // labelX8
            // 
            this.labelX8.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.Class = "";
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Location = new System.Drawing.Point(553, 103);
            this.labelX8.Name = "labelX8";
            this.labelX8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX8.Size = new System.Drawing.Size(62, 23);
            this.labelX8.TabIndex = 21;
            this.labelX8.Text = "انبار";
            // 
            // cmbCommodityUnit
            // 
            this.cmbCommodityUnit.DataSource = this.unitBindingSource1;
            this.cmbCommodityUnit.DisplayMember = "name";
            this.cmbCommodityUnit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCommodityUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCommodityUnit.FormattingEnabled = true;
            this.cmbCommodityUnit.ItemHeight = 15;
            this.cmbCommodityUnit.Location = new System.Drawing.Point(132, 14);
            this.cmbCommodityUnit.Name = "cmbCommodityUnit";
            this.cmbCommodityUnit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbCommodityUnit.Size = new System.Drawing.Size(131, 21);
            this.cmbCommodityUnit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbCommodityUnit.TabIndex = 0;
            // 
            // btnPrintCommodities
            // 
            this.btnPrintCommodities.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPrintCommodities.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPrintCommodities.Location = new System.Drawing.Point(22, 133);
            this.btnPrintCommodities.Name = "btnPrintCommodities";
            this.btnPrintCommodities.Size = new System.Drawing.Size(601, 23);
            this.btnPrintCommodities.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPrintCommodities.TabIndex = 20;
            this.btnPrintCommodities.Text = "چاپ";
            this.btnPrintCommodities.Click += new System.EventHandler(this.btnPrintCommodities_Click);
            // 
            // btnDeleteCommodity
            // 
            this.btnDeleteCommodity.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDeleteCommodity.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDeleteCommodity.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCommodity.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteCommodity.Image")));
            this.btnDeleteCommodity.Location = new System.Drawing.Point(22, 74);
            this.btnDeleteCommodity.Name = "btnDeleteCommodity";
            this.btnDeleteCommodity.Size = new System.Drawing.Size(78, 23);
            this.btnDeleteCommodity.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDeleteCommodity.TabIndex = 17;
            this.btnDeleteCommodity.Text = "حذف";
            this.btnDeleteCommodity.Click += new System.EventHandler(this.btnDeleteCommodity_Click);
            // 
            // btnAddCommodity
            // 
            this.btnAddCommodity.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddCommodity.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddCommodity.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCommodity.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCommodity.Image")));
            this.btnAddCommodity.Location = new System.Drawing.Point(22, 14);
            this.btnAddCommodity.Name = "btnAddCommodity";
            this.btnAddCommodity.Size = new System.Drawing.Size(78, 23);
            this.btnAddCommodity.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddCommodity.TabIndex = 19;
            this.btnAddCommodity.Text = "درج";
            this.btnAddCommodity.Click += new System.EventHandler(this.btnAddCommodity_Click);
            // 
            // btnSearchCommodity
            // 
            this.btnSearchCommodity.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearchCommodity.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSearchCommodity.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCommodity.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchCommodity.Image")));
            this.btnSearchCommodity.Location = new System.Drawing.Point(22, 103);
            this.btnSearchCommodity.Name = "btnSearchCommodity";
            this.btnSearchCommodity.Size = new System.Drawing.Size(78, 23);
            this.btnSearchCommodity.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSearchCommodity.TabIndex = 16;
            this.btnSearchCommodity.Text = "جستجو";
            this.btnSearchCommodity.Click += new System.EventHandler(this.btnSearchCommodity_Click);
            // 
            // btnEditCommodity
            // 
            this.btnEditCommodity.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEditCommodity.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnEditCommodity.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCommodity.Image = ((System.Drawing.Image)(resources.GetObject("btnEditCommodity.Image")));
            this.btnEditCommodity.Location = new System.Drawing.Point(22, 45);
            this.btnEditCommodity.Name = "btnEditCommodity";
            this.btnEditCommodity.Size = new System.Drawing.Size(78, 23);
            this.btnEditCommodity.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnEditCommodity.TabIndex = 18;
            this.btnEditCommodity.Text = "ویرایش";
            this.btnEditCommodity.Click += new System.EventHandler(this.btnUpdateCommodity_Click);
            // 
            // labelX7
            // 
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.Class = "";
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(269, 99);
            this.labelX7.Name = "labelX7";
            this.labelX7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX7.Size = new System.Drawing.Size(75, 20);
            this.labelX7.TabIndex = 12;
            this.labelX7.Text = "تاریخ ثبت";
            // 
            // txtCommodityUnitPrice
            // 
            // 
            // 
            // 
            this.txtCommodityUnitPrice.Border.Class = "TextBoxBorder";
            this.txtCommodityUnitPrice.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCommodityUnitPrice.Location = new System.Drawing.Point(132, 44);
            this.txtCommodityUnitPrice.Name = "txtCommodityUnitPrice";
            this.txtCommodityUnitPrice.Size = new System.Drawing.Size(131, 21);
            this.txtCommodityUnitPrice.TabIndex = 11;
            this.txtCommodityUnitPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCommodityAmount_KeyPress);
            // 
            // txtCommodityAmount
            // 
            // 
            // 
            // 
            this.txtCommodityAmount.Border.Class = "TextBoxBorder";
            this.txtCommodityAmount.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCommodityAmount.Location = new System.Drawing.Point(132, 71);
            this.txtCommodityAmount.Name = "txtCommodityAmount";
            this.txtCommodityAmount.Size = new System.Drawing.Size(131, 21);
            this.txtCommodityAmount.TabIndex = 9;
            this.txtCommodityAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCommodityAmount_KeyPress);
            // 
            // txtCommodityDate
            // 
            // 
            // 
            // 
            this.txtCommodityDate.Border.Class = "TextBoxBorder";
            this.txtCommodityDate.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCommodityDate.Enabled = false;
            this.txtCommodityDate.Location = new System.Drawing.Point(132, 99);
            this.txtCommodityDate.Name = "txtCommodityDate";
            this.txtCommodityDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCommodityDate.Size = new System.Drawing.Size(131, 21);
            this.txtCommodityDate.TabIndex = 8;
            this.txtCommodityDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(269, 69);
            this.labelX4.Name = "labelX4";
            this.labelX4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX4.Size = new System.Drawing.Size(75, 23);
            this.labelX4.TabIndex = 1;
            this.labelX4.Text = "تعداد";
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.Class = "";
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(269, 17);
            this.labelX5.Name = "labelX5";
            this.labelX5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX5.Size = new System.Drawing.Size(75, 23);
            this.labelX5.TabIndex = 2;
            this.labelX5.Text = "واحد";
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.Class = "";
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(269, 45);
            this.labelX6.Name = "labelX6";
            this.labelX6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX6.Size = new System.Drawing.Size(75, 23);
            this.labelX6.TabIndex = 3;
            this.labelX6.Text = "قیمت واحد";
            // 
            // cmbCommodityCountry
            // 
            this.cmbCommodityCountry.DataSource = this.countryBindingSource1;
            this.cmbCommodityCountry.DisplayMember = "name";
            this.cmbCommodityCountry.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCommodityCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCommodityCountry.FormattingEnabled = true;
            this.cmbCommodityCountry.ItemHeight = 15;
            this.cmbCommodityCountry.Location = new System.Drawing.Point(409, 78);
            this.cmbCommodityCountry.Name = "cmbCommodityCountry";
            this.cmbCommodityCountry.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbCommodityCountry.Size = new System.Drawing.Size(131, 21);
            this.cmbCommodityCountry.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbCommodityCountry.TabIndex = 7;
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(553, 79);
            this.labelX3.Name = "labelX3";
            this.labelX3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX3.Size = new System.Drawing.Size(62, 23);
            this.labelX3.TabIndex = 6;
            this.labelX3.Text = "کشور سازنده";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(553, 42);
            this.labelX2.Name = "labelX2";
            this.labelX2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX2.Size = new System.Drawing.Size(62, 23);
            this.labelX2.TabIndex = 5;
            this.labelX2.Text = "توضیحات کالا";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(572, 16);
            this.labelX1.Name = "labelX1";
            this.labelX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX1.Size = new System.Drawing.Size(43, 23);
            this.labelX1.TabIndex = 4;
            this.labelX1.Text = "نام کالا";
            // 
            // txtCommodityName
            // 
            // 
            // 
            // 
            this.txtCommodityName.Border.Class = "TextBoxBorder";
            this.txtCommodityName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCommodityName.Location = new System.Drawing.Point(409, 19);
            this.txtCommodityName.Name = "txtCommodityName";
            this.txtCommodityName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCommodityName.Size = new System.Drawing.Size(131, 21);
            this.txtCommodityName.TabIndex = 2;
            // 
            // txtCommodityDesc
            // 
            // 
            // 
            // 
            this.txtCommodityDesc.Border.Class = "TextBoxBorder";
            this.txtCommodityDesc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCommodityDesc.Location = new System.Drawing.Point(409, 44);
            this.txtCommodityDesc.Multiline = true;
            this.txtCommodityDesc.Name = "txtCommodityDesc";
            this.txtCommodityDesc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCommodityDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCommodityDesc.Size = new System.Drawing.Size(131, 31);
            this.txtCommodityDesc.TabIndex = 3;
            // 
            // kalaTableAdapter
            // 
            this.kalaTableAdapter.ClearBeforeFill = true;
            // 
            // anbarTableAdapter
            // 
            this.anbarTableAdapter.ClearBeforeFill = true;
            // 
            // unitTableAdapter
            // 
            this.unitTableAdapter.ClearBeforeFill = true;
            // 
            // countryTableAdapter
            // 
            this.countryTableAdapter.ClearBeforeFill = true;
            // 
            // anbarBindingSource1
            // 
            this.anbarBindingSource1.DataMember = "anbar";
            this.anbarBindingSource1.DataSource = this.dsWMS;
            // 
            // countryBindingSource1
            // 
            this.countryBindingSource1.DataMember = "country";
            this.countryBindingSource1.DataSource = this.dsWMS;
            // 
            // unitBindingSource1
            // 
            this.unitBindingSource1.DataMember = "unit";
            this.unitBindingSource1.DataSource = this.dsWMS;
            // 
            // frmCommodity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 437);
            this.Controls.Add(this.ribbonClientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(684, 475);
            this.Name = "frmCommodity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ثبت کالا";
            this.Load += new System.EventHandler(this.frmCommodity_Load);
            this.ribbonClientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommodity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kalaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWMS)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.anbarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anbarBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Ribbon.RibbonClientPanel ribbonClientPanel1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCommodityName;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCommodityDesc;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvCommodity;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbCommodityCountry;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCommodityAmount;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCommodityDate;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCommodityUnitPrice;
        private DevComponents.DotNetBar.ButtonX btnPrintCommodities;
        private DevComponents.DotNetBar.ButtonX btnDeleteCommodity;
        private DevComponents.DotNetBar.ButtonX btnAddCommodity;
        private DevComponents.DotNetBar.ButtonX btnSearchCommodity;
        private DevComponents.DotNetBar.ButtonX btnEditCommodity;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbCommodityUnit;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbCommodityWarehouse;
        private DevComponents.DotNetBar.LabelX labelX8;
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
        private System.Windows.Forms.BindingSource unitBindingSource;
        private dsWMSTableAdapters.unitTableAdapter unitTableAdapter;
        private System.Windows.Forms.BindingSource countryBindingSource;
        private dsWMSTableAdapters.countryTableAdapter countryTableAdapter;
        private System.Windows.Forms.BindingSource anbarBindingSource;
        private dsWMSTableAdapters.anbarTableAdapter anbarTableAdapter;
        private System.Windows.Forms.BindingSource anbarBindingSource1;
        private System.Windows.Forms.BindingSource unitBindingSource1;
        private System.Windows.Forms.BindingSource countryBindingSource1;
    }
}