namespace WMS
{
    partial class frmFactor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFactor));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ribbonClientPanel1 = new DevComponents.DotNetBar.Ribbon.RibbonClientPanel();
            this.btnRefresh = new DevComponents.DotNetBar.ButtonX();
            this.btnSearch = new DevComponents.DotNetBar.ButtonX();
            this.btnDeleteFactor = new DevComponents.DotNetBar.ButtonX();
            this.btnAddEditFactor = new DevComponents.DotNetBar.ButtonX();
            this.dgvFactors = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custumerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numresanbarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tkalaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsWMS = new WMS.dsWMS();
            this.expandablePanel1 = new DevComponents.DotNetBar.ExpandablePanel();
            this.ribbonClientPanel2 = new DevComponents.DotNetBar.Ribbon.RibbonClientPanel();
            this.lblTotalPrice = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.dgvCommodities = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shfactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anbarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarikhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aghlamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelSearchFactor = new DevComponents.DotNetBar.PanelEx();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btnPanelSearchFactor = new DevComponents.DotNetBar.ButtonX();
            this.btnExitSearchFactor = new DevComponents.DotNetBar.ButtonX();
            this.txtPanelFactorRecipient = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtPanelFactorCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.factorTableAdapter = new WMS.dsWMSTableAdapters.factorTableAdapter();
            this.aghlamTableAdapter = new WMS.dsWMSTableAdapters.aghlamTableAdapter();
            this.ribbonClientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWMS)).BeginInit();
            this.expandablePanel1.SuspendLayout();
            this.ribbonClientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommodities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aghlamBindingSource)).BeginInit();
            this.panelSearchFactor.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonClientPanel1
            // 
            this.ribbonClientPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ribbonClientPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.ribbonClientPanel1.Controls.Add(this.btnRefresh);
            this.ribbonClientPanel1.Controls.Add(this.btnSearch);
            this.ribbonClientPanel1.Controls.Add(this.btnDeleteFactor);
            this.ribbonClientPanel1.Controls.Add(this.btnAddEditFactor);
            this.ribbonClientPanel1.Location = new System.Drawing.Point(0, 0);
            this.ribbonClientPanel1.Name = "ribbonClientPanel1";
            this.ribbonClientPanel1.Size = new System.Drawing.Size(651, 38);
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
            // btnRefresh
            // 
            this.btnRefresh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnRefresh.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnRefresh.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(248, 7);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(77, 23);
            this.btnRefresh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "تازه سازی";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSearch.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(331, 7);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(77, 23);
            this.btnSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "جستجو";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDeleteFactor
            // 
            this.btnDeleteFactor.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDeleteFactor.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDeleteFactor.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteFactor.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteFactor.Image")));
            this.btnDeleteFactor.Location = new System.Drawing.Point(415, 7);
            this.btnDeleteFactor.Name = "btnDeleteFactor";
            this.btnDeleteFactor.Size = new System.Drawing.Size(86, 23);
            this.btnDeleteFactor.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDeleteFactor.TabIndex = 0;
            this.btnDeleteFactor.Text = "حذف فاکتور";
            this.btnDeleteFactor.Click += new System.EventHandler(this.btnDeleteFactor_Click);
            // 
            // btnAddEditFactor
            // 
            this.btnAddEditFactor.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddEditFactor.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddEditFactor.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEditFactor.Image = ((System.Drawing.Image)(resources.GetObject("btnAddEditFactor.Image")));
            this.btnAddEditFactor.Location = new System.Drawing.Point(507, 7);
            this.btnAddEditFactor.Name = "btnAddEditFactor";
            this.btnAddEditFactor.Size = new System.Drawing.Size(122, 23);
            this.btnAddEditFactor.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddEditFactor.TabIndex = 3;
            this.btnAddEditFactor.Text = "فاکتور جدید / ویرایش";
            this.btnAddEditFactor.Click += new System.EventHandler(this.btnAddEdit_Click);
            // 
            // dgvFactors
            // 
            this.dgvFactors.AllowUserToAddRows = false;
            this.dgvFactors.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvFactors.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvFactors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFactors.AutoGenerateColumns = false;
            this.dgvFactors.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFactors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvFactors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFactors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.sellerDataGridViewTextBoxColumn,
            this.custumerDataGridViewTextBoxColumn,
            this.dtDataGridViewTextBoxColumn,
            this.numresanbarDataGridViewTextBoxColumn,
            this.tkalaDataGridViewTextBoxColumn});
            this.dgvFactors.DataSource = this.factorBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFactors.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvFactors.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvFactors.Location = new System.Drawing.Point(0, 38);
            this.dgvFactors.MultiSelect = false;
            this.dgvFactors.Name = "dgvFactors";
            this.dgvFactors.ReadOnly = true;
            this.dgvFactors.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvFactors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFactors.Size = new System.Drawing.Size(646, 221);
            this.dgvFactors.TabIndex = 1;
            this.dgvFactors.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dgvFactors_MouseUp);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "کد فاکتور";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sellerDataGridViewTextBoxColumn
            // 
            this.sellerDataGridViewTextBoxColumn.DataPropertyName = "seller";
            this.sellerDataGridViewTextBoxColumn.HeaderText = "فروشنده";
            this.sellerDataGridViewTextBoxColumn.Name = "sellerDataGridViewTextBoxColumn";
            this.sellerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // custumerDataGridViewTextBoxColumn
            // 
            this.custumerDataGridViewTextBoxColumn.DataPropertyName = "custumer";
            this.custumerDataGridViewTextBoxColumn.HeaderText = "خریدار";
            this.custumerDataGridViewTextBoxColumn.Name = "custumerDataGridViewTextBoxColumn";
            this.custumerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dtDataGridViewTextBoxColumn
            // 
            this.dtDataGridViewTextBoxColumn.DataPropertyName = "dt";
            this.dtDataGridViewTextBoxColumn.HeaderText = "تاریخ صدور";
            this.dtDataGridViewTextBoxColumn.Name = "dtDataGridViewTextBoxColumn";
            this.dtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numresanbarDataGridViewTextBoxColumn
            // 
            this.numresanbarDataGridViewTextBoxColumn.DataPropertyName = "num_res_anbar";
            this.numresanbarDataGridViewTextBoxColumn.HeaderText = "شماره رسید";
            this.numresanbarDataGridViewTextBoxColumn.Name = "numresanbarDataGridViewTextBoxColumn";
            this.numresanbarDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tkalaDataGridViewTextBoxColumn
            // 
            this.tkalaDataGridViewTextBoxColumn.DataPropertyName = "t_kala";
            this.tkalaDataGridViewTextBoxColumn.HeaderText = "تعداد اقلام";
            this.tkalaDataGridViewTextBoxColumn.Name = "tkalaDataGridViewTextBoxColumn";
            this.tkalaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // factorBindingSource
            // 
            this.factorBindingSource.DataMember = "factor";
            this.factorBindingSource.DataSource = this.dsWMS;
            // 
            // dsWMS
            // 
            this.dsWMS.DataSetName = "dsWMS";
            this.dsWMS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // expandablePanel1
            // 
            this.expandablePanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.expandablePanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.expandablePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.expandablePanel1.Controls.Add(this.ribbonClientPanel2);
            this.expandablePanel1.Controls.Add(this.dgvCommodities);
            this.expandablePanel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expandablePanel1.Location = new System.Drawing.Point(0, 260);
            this.expandablePanel1.MinimumSize = new System.Drawing.Size(645, 260);
            this.expandablePanel1.Name = "expandablePanel1";
            this.expandablePanel1.Size = new System.Drawing.Size(645, 260);
            this.expandablePanel1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expandablePanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.expandablePanel1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.expandablePanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandablePanel1.Style.GradientAngle = 90;
            this.expandablePanel1.TabIndex = 2;
            this.expandablePanel1.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel1.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel1.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expandablePanel1.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.expandablePanel1.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandablePanel1.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.expandablePanel1.TitleStyle.GradientAngle = 90;
            this.expandablePanel1.TitleText = "(اقلام (برای مشاهده روی ردبف های جدول بالا کلیک کنید";
            // 
            // ribbonClientPanel2
            // 
            this.ribbonClientPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.ribbonClientPanel2.Controls.Add(this.lblTotalPrice);
            this.ribbonClientPanel2.Controls.Add(this.labelX3);
            this.ribbonClientPanel2.Location = new System.Drawing.Point(0, 224);
            this.ribbonClientPanel2.Name = "ribbonClientPanel2";
            this.ribbonClientPanel2.Size = new System.Drawing.Size(645, 36);
            // 
            // 
            // 
            this.ribbonClientPanel2.Style.Class = "RibbonClientPanel";
            this.ribbonClientPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonClientPanel2.StyleMouseDown.Class = "";
            this.ribbonClientPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonClientPanel2.StyleMouseOver.Class = "";
            this.ribbonClientPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonClientPanel2.TabIndex = 4;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblTotalPrice.BackgroundStyle.Class = "";
            this.lblTotalPrice.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblTotalPrice.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.Red;
            this.lblTotalPrice.Location = new System.Drawing.Point(491, 4);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(79, 23);
            this.lblTotalPrice.TabIndex = 3;
            this.lblTotalPrice.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.ForeColor = System.Drawing.Color.Red;
            this.labelX3.Location = new System.Drawing.Point(554, 4);
            this.labelX3.Name = "labelX3";
            this.labelX3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 2;
            this.labelX3.Text = " قیمت کل  : ";
            // 
            // dgvCommodities
            // 
            this.dgvCommodities.AllowUserToAddRows = false;
            this.dgvCommodities.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvCommodities.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvCommodities.AutoGenerateColumns = false;
            this.dgvCommodities.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvCommodities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCommodities.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.shfactDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.desDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn,
            this.anbarDataGridViewTextBoxColumn,
            this.cterDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn,
            this.unitpriceDataGridViewTextBoxColumn,
            this.totalpriceDataGridViewTextBoxColumn,
            this.tarikhDataGridViewTextBoxColumn});
            this.dgvCommodities.DataSource = this.aghlamBindingSource;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCommodities.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvCommodities.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvCommodities.Location = new System.Drawing.Point(0, 26);
            this.dgvCommodities.MultiSelect = false;
            this.dgvCommodities.Name = "dgvCommodities";
            this.dgvCommodities.ReadOnly = true;
            this.dgvCommodities.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvCommodities.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCommodities.Size = new System.Drawing.Size(645, 199);
            this.dgvCommodities.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "کد کالا";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // shfactDataGridViewTextBoxColumn
            // 
            this.shfactDataGridViewTextBoxColumn.DataPropertyName = "shfact";
            this.shfactDataGridViewTextBoxColumn.HeaderText = "کد فاکتور";
            this.shfactDataGridViewTextBoxColumn.Name = "shfactDataGridViewTextBoxColumn";
            this.shfactDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.anbarDataGridViewTextBoxColumn.HeaderText = "انبار";
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
            // aghlamBindingSource
            // 
            this.aghlamBindingSource.DataMember = "aghlam";
            this.aghlamBindingSource.DataSource = this.dsWMS;
            // 
            // panelSearchFactor
            // 
            this.panelSearchFactor.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelSearchFactor.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelSearchFactor.Controls.Add(this.labelX2);
            this.panelSearchFactor.Controls.Add(this.labelX1);
            this.panelSearchFactor.Controls.Add(this.btnPanelSearchFactor);
            this.panelSearchFactor.Controls.Add(this.btnExitSearchFactor);
            this.panelSearchFactor.Controls.Add(this.txtPanelFactorRecipient);
            this.panelSearchFactor.Controls.Add(this.txtPanelFactorCode);
            this.panelSearchFactor.Location = new System.Drawing.Point(272, 39);
            this.panelSearchFactor.Name = "panelSearchFactor";
            this.panelSearchFactor.Size = new System.Drawing.Size(200, 100);
            this.panelSearchFactor.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelSearchFactor.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelSearchFactor.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelSearchFactor.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelSearchFactor.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelSearchFactor.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelSearchFactor.Style.GradientAngle = 90;
            this.panelSearchFactor.TabIndex = 3;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(124, 36);
            this.labelX2.Name = "labelX2";
            this.labelX2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX2.Size = new System.Drawing.Size(60, 23);
            this.labelX2.TabIndex = 4;
            this.labelX2.Text = "تحویل گیرنده";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(133, 13);
            this.labelX1.Name = "labelX1";
            this.labelX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX1.Size = new System.Drawing.Size(50, 23);
            this.labelX1.TabIndex = 3;
            this.labelX1.Text = "کد فاکتور";
            // 
            // btnPanelSearchFactor
            // 
            this.btnPanelSearchFactor.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPanelSearchFactor.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPanelSearchFactor.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPanelSearchFactor.Location = new System.Drawing.Point(104, 65);
            this.btnPanelSearchFactor.Name = "btnPanelSearchFactor";
            this.btnPanelSearchFactor.Size = new System.Drawing.Size(75, 23);
            this.btnPanelSearchFactor.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPanelSearchFactor.TabIndex = 0;
            this.btnPanelSearchFactor.Text = "جستجو";
            this.btnPanelSearchFactor.Click += new System.EventHandler(this.btnPanelSearchFactor_Click);
            // 
            // btnExitSearchFactor
            // 
            this.btnExitSearchFactor.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnExitSearchFactor.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnExitSearchFactor.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitSearchFactor.Location = new System.Drawing.Point(23, 65);
            this.btnExitSearchFactor.Name = "btnExitSearchFactor";
            this.btnExitSearchFactor.Size = new System.Drawing.Size(75, 23);
            this.btnExitSearchFactor.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnExitSearchFactor.TabIndex = 2;
            this.btnExitSearchFactor.Text = "خروج";
            this.btnExitSearchFactor.Click += new System.EventHandler(this.btnExitSearchFactor_Click);
            // 
            // txtPanelFactorRecipient
            // 
            // 
            // 
            // 
            this.txtPanelFactorRecipient.Border.Class = "TextBoxBorder";
            this.txtPanelFactorRecipient.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPanelFactorRecipient.Location = new System.Drawing.Point(23, 39);
            this.txtPanelFactorRecipient.Name = "txtPanelFactorRecipient";
            this.txtPanelFactorRecipient.Size = new System.Drawing.Size(98, 20);
            this.txtPanelFactorRecipient.TabIndex = 1;
            // 
            // txtPanelFactorCode
            // 
            // 
            // 
            // 
            this.txtPanelFactorCode.Border.Class = "TextBoxBorder";
            this.txtPanelFactorCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPanelFactorCode.Location = new System.Drawing.Point(23, 13);
            this.txtPanelFactorCode.Name = "txtPanelFactorCode";
            this.txtPanelFactorCode.Size = new System.Drawing.Size(98, 20);
            this.txtPanelFactorCode.TabIndex = 0;
            this.txtPanelFactorCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPanelFactorCode_KeyPress);
            // 
            // factorTableAdapter
            // 
            this.factorTableAdapter.ClearBeforeFill = true;
            // 
            // aghlamTableAdapter
            // 
            this.aghlamTableAdapter.ClearBeforeFill = true;
            // 
            // frmFactor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 513);
            this.Controls.Add(this.panelSearchFactor);
            this.Controls.Add(this.expandablePanel1);
            this.Controls.Add(this.dgvFactors);
            this.Controls.Add(this.ribbonClientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(651, 551);
            this.Name = "frmFactor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نمایش فاکتور";
            this.Load += new System.EventHandler(this.frmFactor_Load);
            this.ribbonClientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWMS)).EndInit();
            this.expandablePanel1.ResumeLayout(false);
            this.ribbonClientPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommodities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aghlamBindingSource)).EndInit();
            this.panelSearchFactor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Ribbon.RibbonClientPanel ribbonClientPanel1;
        private DevComponents.DotNetBar.ButtonX btnSearch;
        private DevComponents.DotNetBar.ButtonX btnDeleteFactor;
        private DevComponents.DotNetBar.ButtonX btnAddEditFactor;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvFactors;
        private DevComponents.DotNetBar.ExpandablePanel expandablePanel1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvCommodities;
        private DevComponents.DotNetBar.ButtonX btnRefresh;
        private DevComponents.DotNetBar.PanelEx panelSearchFactor;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btnPanelSearchFactor;
        private DevComponents.DotNetBar.ButtonX btnExitSearchFactor;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPanelFactorRecipient;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPanelFactorCode;
        private DevComponents.DotNetBar.LabelX lblTotalPrice;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Ribbon.RibbonClientPanel ribbonClientPanel2;
        private dsWMS dsWMS;
        private System.Windows.Forms.BindingSource factorBindingSource;
        private dsWMSTableAdapters.factorTableAdapter factorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custumerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numresanbarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tkalaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource aghlamBindingSource;
        private dsWMSTableAdapters.aghlamTableAdapter aghlamTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn shfactDataGridViewTextBoxColumn;
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