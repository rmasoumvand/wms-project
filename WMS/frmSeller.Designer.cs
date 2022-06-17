namespace WMS
{
    partial class frmSeller
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSeller));
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.dgvSellers = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foroshandehBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsWMS = new WMS.dsWMS();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnRefresh = new DevComponents.DotNetBar.ButtonX();
            this.txtSellerID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.btnPrintSellers = new DevComponents.DotNetBar.ButtonX();
            this.btnDeleteSeller = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btnAddSeller = new DevComponents.DotNetBar.ButtonX();
            this.btnSearchSeller = new DevComponents.DotNetBar.ButtonX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.btnUpdateSeller = new DevComponents.DotNetBar.ButtonX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.txtSellerName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtSellerAddress = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtSellerPhone = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtSellerFamily = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.controlContainerItem1 = new DevComponents.DotNetBar.ControlContainerItem();
            this.foroshandehTableAdapter = new WMS.dsWMSTableAdapters.foroshandehTableAdapter();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSellers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foroshandehBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWMS)).BeginInit();
            this.groupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.dgvSellers);
            this.panelEx1.Controls.Add(this.groupPanel1);
            this.panelEx1.Location = new System.Drawing.Point(1, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(547, 428);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // dgvSellers
            // 
            this.dgvSellers.AllowUserToAddRows = false;
            this.dgvSellers.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvSellers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSellers.AutoGenerateColumns = false;
            this.dgvSellers.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSellers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSellers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSellers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.familyDataGridViewTextBoxColumn,
            this.telDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.dgvSellers.DataSource = this.foroshandehBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSellers.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSellers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvSellers.Location = new System.Drawing.Point(8, 245);
            this.dgvSellers.Name = "dgvSellers";
            this.dgvSellers.ReadOnly = true;
            this.dgvSellers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSellers.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSellers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSellers.Size = new System.Drawing.Size(524, 173);
            this.dgvSellers.TabIndex = 11;
            this.dgvSellers.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dgvSellers_MouseUp);
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
            // familyDataGridViewTextBoxColumn
            // 
            this.familyDataGridViewTextBoxColumn.DataPropertyName = "family";
            this.familyDataGridViewTextBoxColumn.HeaderText = "نام خانوادگی";
            this.familyDataGridViewTextBoxColumn.Name = "familyDataGridViewTextBoxColumn";
            this.familyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telDataGridViewTextBoxColumn
            // 
            this.telDataGridViewTextBoxColumn.DataPropertyName = "tel";
            this.telDataGridViewTextBoxColumn.HeaderText = "تلفن";
            this.telDataGridViewTextBoxColumn.Name = "telDataGridViewTextBoxColumn";
            this.telDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "آدرس";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // foroshandehBindingSource
            // 
            this.foroshandehBindingSource.DataMember = "foroshandeh";
            this.foroshandehBindingSource.DataSource = this.dsWMS;
            // 
            // dsWMS
            // 
            this.dsWMS.DataSetName = "dsWMS";
            this.dsWMS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.groupPanel1.Controls.Add(this.btnRefresh);
            this.groupPanel1.Controls.Add(this.txtSellerID);
            this.groupPanel1.Controls.Add(this.labelX9);
            this.groupPanel1.Controls.Add(this.btnPrintSellers);
            this.groupPanel1.Controls.Add(this.btnDeleteSeller);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Controls.Add(this.btnAddSeller);
            this.groupPanel1.Controls.Add(this.btnSearchSeller);
            this.groupPanel1.Controls.Add(this.labelX6);
            this.groupPanel1.Controls.Add(this.btnUpdateSeller);
            this.groupPanel1.Controls.Add(this.labelX7);
            this.groupPanel1.Controls.Add(this.labelX8);
            this.groupPanel1.Controls.Add(this.txtSellerName);
            this.groupPanel1.Controls.Add(this.txtSellerAddress);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.txtSellerPhone);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.txtSellerFamily);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.labelX5);
            this.groupPanel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel1.Location = new System.Drawing.Point(9, 12);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(524, 227);
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
            // btnRefresh
            // 
            this.btnRefresh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnRefresh.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnRefresh.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(44, 15);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnRefresh.TabIndex = 18;
            this.btnRefresh.Text = "باز نشانی";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtSellerID
            // 
            // 
            // 
            // 
            this.txtSellerID.Border.Class = "TextBoxBorder";
            this.txtSellerID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSellerID.Enabled = false;
            this.txtSellerID.Location = new System.Drawing.Point(184, 18);
            this.txtSellerID.Name = "txtSellerID";
            this.txtSellerID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSellerID.Size = new System.Drawing.Size(206, 21);
            this.txtSellerID.TabIndex = 17;
            // 
            // labelX9
            // 
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.Class = "";
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX9.Location = new System.Drawing.Point(400, 17);
            this.labelX9.Name = "labelX9";
            this.labelX9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX9.Size = new System.Drawing.Size(75, 23);
            this.labelX9.TabIndex = 16;
            this.labelX9.Text = "کد";
            // 
            // btnPrintSellers
            // 
            this.btnPrintSellers.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPrintSellers.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPrintSellers.Location = new System.Drawing.Point(43, 170);
            this.btnPrintSellers.Name = "btnPrintSellers";
            this.btnPrintSellers.Size = new System.Drawing.Size(432, 23);
            this.btnPrintSellers.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPrintSellers.TabIndex = 15;
            this.btnPrintSellers.Text = "چاپ";
            this.btnPrintSellers.Click += new System.EventHandler(this.btnPrintSellers_Click);
            // 
            // btnDeleteSeller
            // 
            this.btnDeleteSeller.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDeleteSeller.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDeleteSeller.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSeller.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteSeller.Image")));
            this.btnDeleteSeller.Location = new System.Drawing.Point(44, 101);
            this.btnDeleteSeller.Name = "btnDeleteSeller";
            this.btnDeleteSeller.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteSeller.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDeleteSeller.TabIndex = 0;
            this.btnDeleteSeller.Text = "حذف";
            this.btnDeleteSeller.Click += new System.EventHandler(this.btnDeleteSeller_Click);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.Color.Red;
            this.labelX1.Location = new System.Drawing.Point(136, 44);
            this.labelX1.Name = "labelX1";
            this.labelX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX1.Size = new System.Drawing.Size(42, 23);
            this.labelX1.TabIndex = 11;
            this.labelX1.Text = "*";
            // 
            // btnAddSeller
            // 
            this.btnAddSeller.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddSeller.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddSeller.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSeller.Image = ((System.Drawing.Image)(resources.GetObject("btnAddSeller.Image")));
            this.btnAddSeller.Location = new System.Drawing.Point(44, 44);
            this.btnAddSeller.Name = "btnAddSeller";
            this.btnAddSeller.Size = new System.Drawing.Size(75, 23);
            this.btnAddSeller.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddSeller.TabIndex = 13;
            this.btnAddSeller.Text = "درج";
            this.btnAddSeller.Click += new System.EventHandler(this.btnAddSeller_Click);
            // 
            // btnSearchSeller
            // 
            this.btnSearchSeller.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearchSeller.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSearchSeller.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchSeller.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchSeller.Image")));
            this.btnSearchSeller.Location = new System.Drawing.Point(44, 130);
            this.btnSearchSeller.Name = "btnSearchSeller";
            this.btnSearchSeller.Size = new System.Drawing.Size(75, 23);
            this.btnSearchSeller.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSearchSeller.TabIndex = 0;
            this.btnSearchSeller.Text = "جستجو";
            this.btnSearchSeller.Click += new System.EventHandler(this.btnSearchSeller_Click);
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.Class = "";
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX6.ForeColor = System.Drawing.Color.Red;
            this.labelX6.Location = new System.Drawing.Point(136, 74);
            this.labelX6.Name = "labelX6";
            this.labelX6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX6.Size = new System.Drawing.Size(42, 23);
            this.labelX6.TabIndex = 12;
            this.labelX6.Text = "*";
            // 
            // btnUpdateSeller
            // 
            this.btnUpdateSeller.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnUpdateSeller.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnUpdateSeller.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateSeller.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateSeller.Image")));
            this.btnUpdateSeller.Location = new System.Drawing.Point(44, 73);
            this.btnUpdateSeller.Name = "btnUpdateSeller";
            this.btnUpdateSeller.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateSeller.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnUpdateSeller.TabIndex = 0;
            this.btnUpdateSeller.Text = "ویرایش";
            this.btnUpdateSeller.Click += new System.EventHandler(this.btnUpdateSeller_Click);
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.Class = "";
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX7.ForeColor = System.Drawing.Color.Red;
            this.labelX7.Location = new System.Drawing.Point(136, 105);
            this.labelX7.Name = "labelX7";
            this.labelX7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX7.Size = new System.Drawing.Size(42, 23);
            this.labelX7.TabIndex = 13;
            this.labelX7.Text = "*";
            // 
            // labelX8
            // 
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.Class = "";
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX8.ForeColor = System.Drawing.Color.Red;
            this.labelX8.Location = new System.Drawing.Point(136, 134);
            this.labelX8.Name = "labelX8";
            this.labelX8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX8.Size = new System.Drawing.Size(42, 23);
            this.labelX8.TabIndex = 14;
            this.labelX8.Text = "*";
            // 
            // txtSellerName
            // 
            // 
            // 
            // 
            this.txtSellerName.Border.Class = "TextBoxBorder";
            this.txtSellerName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSellerName.Location = new System.Drawing.Point(184, 46);
            this.txtSellerName.Name = "txtSellerName";
            this.txtSellerName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSellerName.Size = new System.Drawing.Size(206, 21);
            this.txtSellerName.TabIndex = 6;
            // 
            // txtSellerAddress
            // 
            // 
            // 
            // 
            this.txtSellerAddress.Border.Class = "TextBoxBorder";
            this.txtSellerAddress.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSellerAddress.Location = new System.Drawing.Point(184, 133);
            this.txtSellerAddress.Name = "txtSellerAddress";
            this.txtSellerAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSellerAddress.Size = new System.Drawing.Size(206, 21);
            this.txtSellerAddress.TabIndex = 9;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(400, 46);
            this.labelX2.Name = "labelX2";
            this.labelX2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "نام";
            // 
            // txtSellerPhone
            // 
            // 
            // 
            // 
            this.txtSellerPhone.Border.Class = "TextBoxBorder";
            this.txtSellerPhone.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSellerPhone.Location = new System.Drawing.Point(184, 104);
            this.txtSellerPhone.Name = "txtSellerPhone";
            this.txtSellerPhone.Size = new System.Drawing.Size(206, 21);
            this.txtSellerPhone.TabIndex = 8;
            this.txtSellerPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSellerPhone_KeyPress);
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(400, 75);
            this.labelX3.Name = "labelX3";
            this.labelX3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 2;
            this.labelX3.Text = "نام خانوادگی";
            // 
            // txtSellerFamily
            // 
            // 
            // 
            // 
            this.txtSellerFamily.Border.Class = "TextBoxBorder";
            this.txtSellerFamily.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSellerFamily.Location = new System.Drawing.Point(184, 75);
            this.txtSellerFamily.Name = "txtSellerFamily";
            this.txtSellerFamily.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSellerFamily.Size = new System.Drawing.Size(206, 21);
            this.txtSellerFamily.TabIndex = 7;
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.Location = new System.Drawing.Point(400, 104);
            this.labelX4.Name = "labelX4";
            this.labelX4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX4.Size = new System.Drawing.Size(75, 23);
            this.labelX4.TabIndex = 3;
            this.labelX4.Text = "تلفن";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.Class = "";
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.Location = new System.Drawing.Point(400, 133);
            this.labelX5.Name = "labelX5";
            this.labelX5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX5.Size = new System.Drawing.Size(75, 23);
            this.labelX5.TabIndex = 4;
            this.labelX5.Text = "آدرس";
            // 
            // controlContainerItem1
            // 
            this.controlContainerItem1.AllowItemResize = true;
            this.controlContainerItem1.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem1.Name = "controlContainerItem1";
            // 
            // foroshandehTableAdapter
            // 
            this.foroshandehTableAdapter.ClearBeforeFill = true;
            // 
            // frmSeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 418);
            this.Controls.Add(this.panelEx1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(554, 456);
            this.Name = "frmSeller";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فروشند گان";
            this.Load += new System.EventHandler(this.frmSeller_Load);
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSellers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foroshandehBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWMS)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSellerAddress;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSellerPhone;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSellerFamily;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSellerName;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvSellers;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.ButtonX btnAddSeller;
        private DevComponents.DotNetBar.ButtonX btnSearchSeller;
        private DevComponents.DotNetBar.ButtonX btnUpdateSeller;
        private DevComponents.DotNetBar.ButtonX btnDeleteSeller;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem1;
        private DevComponents.DotNetBar.ButtonX btnPrintSellers;
        private dsWMS dsWMS;
        private System.Windows.Forms.BindingSource foroshandehBindingSource;
        private dsWMSTableAdapters.foroshandehTableAdapter foroshandehTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn familyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DevComponents.DotNetBar.ButtonX btnRefresh;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSellerID;
        private DevComponents.DotNetBar.LabelX labelX9;
    }
}