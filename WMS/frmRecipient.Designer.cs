namespace WMS
{
    partial class frmRecipient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecipient));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnDeleteRecipient = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.dgvRecipient = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnPrintRecipient = new DevComponents.DotNetBar.ButtonX();
            this.btnAddRecipient = new DevComponents.DotNetBar.ButtonX();
            this.btnSearchRecipient = new DevComponents.DotNetBar.ButtonX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.btnUpdateRecipient = new DevComponents.DotNetBar.ButtonX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.txtRecipientName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtRecipientAddress = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtRecipientPhone = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtRecipientFamily = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.controlContainerItem1 = new DevComponents.DotNetBar.ControlContainerItem();
            this.dsWMS = new WMS.dsWMS();
            this.tahvilgirandehBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tahvilgirandehTableAdapter = new WMS.dsWMSTableAdapters.tahvilgirandehTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipient)).BeginInit();
            this.panelEx1.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsWMS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tahvilgirandehBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteRecipient
            // 
            this.btnDeleteRecipient.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDeleteRecipient.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDeleteRecipient.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRecipient.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteRecipient.Image")));
            this.btnDeleteRecipient.Location = new System.Drawing.Point(44, 67);
            this.btnDeleteRecipient.Name = "btnDeleteRecipient";
            this.btnDeleteRecipient.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteRecipient.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDeleteRecipient.TabIndex = 0;
            this.btnDeleteRecipient.Text = "حذف";
            this.btnDeleteRecipient.Click += new System.EventHandler(this.btnDeleteRecipient_Click);
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
            this.labelX1.Location = new System.Drawing.Point(136, 10);
            this.labelX1.Name = "labelX1";
            this.labelX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX1.Size = new System.Drawing.Size(42, 23);
            this.labelX1.TabIndex = 11;
            this.labelX1.Text = "*";
            // 
            // dgvRecipient
            // 
            this.dgvRecipient.AllowUserToAddRows = false;
            this.dgvRecipient.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvRecipient.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRecipient.AutoGenerateColumns = false;
            this.dgvRecipient.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecipient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRecipient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecipient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.familyDataGridViewTextBoxColumn,
            this.telDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.dgvRecipient.DataSource = this.tahvilgirandehBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRecipient.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRecipient.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvRecipient.Location = new System.Drawing.Point(11, 196);
            this.dgvRecipient.Name = "dgvRecipient";
            this.dgvRecipient.ReadOnly = true;
            this.dgvRecipient.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecipient.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRecipient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecipient.Size = new System.Drawing.Size(524, 227);
            this.dgvRecipient.TabIndex = 11;
            this.dgvRecipient.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dgvRecipient_MouseUp);
            // 
            // panelEx1
            // 
            this.panelEx1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.dgvRecipient);
            this.panelEx1.Controls.Add(this.groupPanel1);
            this.panelEx1.Location = new System.Drawing.Point(-4, -6);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(547, 432);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 1;
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.groupPanel1.Controls.Add(this.btnPrintRecipient);
            this.groupPanel1.Controls.Add(this.btnDeleteRecipient);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Controls.Add(this.btnAddRecipient);
            this.groupPanel1.Controls.Add(this.btnSearchRecipient);
            this.groupPanel1.Controls.Add(this.labelX6);
            this.groupPanel1.Controls.Add(this.btnUpdateRecipient);
            this.groupPanel1.Controls.Add(this.labelX7);
            this.groupPanel1.Controls.Add(this.labelX8);
            this.groupPanel1.Controls.Add(this.txtRecipientName);
            this.groupPanel1.Controls.Add(this.txtRecipientAddress);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.txtRecipientPhone);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.txtRecipientFamily);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.labelX5);
            this.groupPanel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel1.Location = new System.Drawing.Point(11, 12);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(524, 178);
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
            // btnPrintRecipient
            // 
            this.btnPrintRecipient.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPrintRecipient.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPrintRecipient.Location = new System.Drawing.Point(43, 125);
            this.btnPrintRecipient.Name = "btnPrintRecipient";
            this.btnPrintRecipient.Size = new System.Drawing.Size(432, 23);
            this.btnPrintRecipient.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPrintRecipient.TabIndex = 16;
            this.btnPrintRecipient.Text = "چاپ";
            this.btnPrintRecipient.Click += new System.EventHandler(this.buttonX5_Click);
            // 
            // btnAddRecipient
            // 
            this.btnAddRecipient.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddRecipient.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddRecipient.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRecipient.Image = ((System.Drawing.Image)(resources.GetObject("btnAddRecipient.Image")));
            this.btnAddRecipient.Location = new System.Drawing.Point(44, 10);
            this.btnAddRecipient.Name = "btnAddRecipient";
            this.btnAddRecipient.Size = new System.Drawing.Size(75, 23);
            this.btnAddRecipient.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddRecipient.TabIndex = 13;
            this.btnAddRecipient.Text = "درج";
            this.btnAddRecipient.Click += new System.EventHandler(this.btnAddRecipient_Click);
            // 
            // btnSearchRecipient
            // 
            this.btnSearchRecipient.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearchRecipient.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSearchRecipient.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchRecipient.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchRecipient.Image")));
            this.btnSearchRecipient.Location = new System.Drawing.Point(43, 96);
            this.btnSearchRecipient.Name = "btnSearchRecipient";
            this.btnSearchRecipient.Size = new System.Drawing.Size(75, 23);
            this.btnSearchRecipient.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSearchRecipient.TabIndex = 0;
            this.btnSearchRecipient.Text = "جستجو";
            this.btnSearchRecipient.Click += new System.EventHandler(this.btnSearchRecipient_Click);
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
            this.labelX6.Location = new System.Drawing.Point(136, 40);
            this.labelX6.Name = "labelX6";
            this.labelX6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX6.Size = new System.Drawing.Size(42, 23);
            this.labelX6.TabIndex = 12;
            this.labelX6.Text = "*";
            // 
            // btnUpdateRecipient
            // 
            this.btnUpdateRecipient.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnUpdateRecipient.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnUpdateRecipient.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateRecipient.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateRecipient.Image")));
            this.btnUpdateRecipient.Location = new System.Drawing.Point(44, 39);
            this.btnUpdateRecipient.Name = "btnUpdateRecipient";
            this.btnUpdateRecipient.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateRecipient.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnUpdateRecipient.TabIndex = 0;
            this.btnUpdateRecipient.Text = "ویرایش";
            this.btnUpdateRecipient.Click += new System.EventHandler(this.btnUpdateRecipient_Click);
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
            this.labelX7.Location = new System.Drawing.Point(136, 71);
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
            this.labelX8.Location = new System.Drawing.Point(136, 100);
            this.labelX8.Name = "labelX8";
            this.labelX8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX8.Size = new System.Drawing.Size(42, 23);
            this.labelX8.TabIndex = 14;
            this.labelX8.Text = "*";
            // 
            // txtRecipientName
            // 
            // 
            // 
            // 
            this.txtRecipientName.Border.Class = "TextBoxBorder";
            this.txtRecipientName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtRecipientName.Location = new System.Drawing.Point(184, 12);
            this.txtRecipientName.Name = "txtRecipientName";
            this.txtRecipientName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtRecipientName.Size = new System.Drawing.Size(206, 21);
            this.txtRecipientName.TabIndex = 6;
            // 
            // txtRecipientAddress
            // 
            // 
            // 
            // 
            this.txtRecipientAddress.Border.Class = "TextBoxBorder";
            this.txtRecipientAddress.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtRecipientAddress.Location = new System.Drawing.Point(184, 99);
            this.txtRecipientAddress.Name = "txtRecipientAddress";
            this.txtRecipientAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtRecipientAddress.Size = new System.Drawing.Size(206, 21);
            this.txtRecipientAddress.TabIndex = 9;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(400, 12);
            this.labelX2.Name = "labelX2";
            this.labelX2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "نام";
            // 
            // txtRecipientPhone
            // 
            // 
            // 
            // 
            this.txtRecipientPhone.Border.Class = "TextBoxBorder";
            this.txtRecipientPhone.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtRecipientPhone.Location = new System.Drawing.Point(184, 70);
            this.txtRecipientPhone.Name = "txtRecipientPhone";
            this.txtRecipientPhone.Size = new System.Drawing.Size(206, 21);
            this.txtRecipientPhone.TabIndex = 8;
            this.txtRecipientPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRecipientPhone_KeyPress);
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(400, 41);
            this.labelX3.Name = "labelX3";
            this.labelX3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 2;
            this.labelX3.Text = "نام خانوادگی";
            // 
            // txtRecipientFamily
            // 
            // 
            // 
            // 
            this.txtRecipientFamily.Border.Class = "TextBoxBorder";
            this.txtRecipientFamily.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtRecipientFamily.Location = new System.Drawing.Point(184, 41);
            this.txtRecipientFamily.Name = "txtRecipientFamily";
            this.txtRecipientFamily.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtRecipientFamily.Size = new System.Drawing.Size(206, 21);
            this.txtRecipientFamily.TabIndex = 7;
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.Location = new System.Drawing.Point(400, 70);
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
            this.labelX5.Location = new System.Drawing.Point(400, 99);
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
            // dsWMS
            // 
            this.dsWMS.DataSetName = "dsWMS";
            this.dsWMS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tahvilgirandehBindingSource
            // 
            this.tahvilgirandehBindingSource.DataMember = "tahvilgirandeh";
            this.tahvilgirandehBindingSource.DataSource = this.dsWMS;
            // 
            // tahvilgirandehTableAdapter
            // 
            this.tahvilgirandehTableAdapter.ClearBeforeFill = true;
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
            // frmRecipient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 426);
            this.Controls.Add(this.panelEx1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(554, 464);
            this.Name = "frmRecipient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تحویل گیرند گان";
            this.Load += new System.EventHandler(this.frmRecipient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipient)).EndInit();
            this.panelEx1.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsWMS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tahvilgirandehBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnDeleteRecipient;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvRecipient;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.ButtonX btnAddRecipient;
        private DevComponents.DotNetBar.ButtonX btnSearchRecipient;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.ButtonX btnUpdateRecipient;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.Controls.TextBoxX txtRecipientName;
        private DevComponents.DotNetBar.Controls.TextBoxX txtRecipientAddress;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtRecipientPhone;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtRecipientFamily;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem1;
        private DevComponents.DotNetBar.ButtonX btnPrintRecipient;
        private dsWMS dsWMS;
        private System.Windows.Forms.BindingSource tahvilgirandehBindingSource;
        private dsWMSTableAdapters.tahvilgirandehTableAdapter tahvilgirandehTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn familyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
    }
}