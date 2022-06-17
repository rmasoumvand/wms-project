namespace WMS
{
    partial class frmWarehouse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWarehouse));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnDeleteWarhouse = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.dgvWarhouses = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.managerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anbarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsWMS = new WMS.dsWMS();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnPrintWarhouses = new DevComponents.DotNetBar.ButtonX();
            this.btnAddWarhouse = new DevComponents.DotNetBar.ButtonX();
            this.btnSearchWarhouse = new DevComponents.DotNetBar.ButtonX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.btnUpdateWarhouse = new DevComponents.DotNetBar.ButtonX();
            this.txtWarhouseName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtWarhouseManager = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtWarhouseType = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.controlContainerItem1 = new DevComponents.DotNetBar.ControlContainerItem();
            this.anbarTableAdapter = new WMS.dsWMSTableAdapters.anbarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWarhouses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anbarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWMS)).BeginInit();
            this.panelEx1.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDeleteWarhouse
            // 
            this.btnDeleteWarhouse.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDeleteWarhouse.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDeleteWarhouse.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteWarhouse.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteWarhouse.Image")));
            this.btnDeleteWarhouse.Location = new System.Drawing.Point(12, 66);
            this.btnDeleteWarhouse.Name = "btnDeleteWarhouse";
            this.btnDeleteWarhouse.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteWarhouse.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDeleteWarhouse.TabIndex = 0;
            this.btnDeleteWarhouse.Text = "حذف";
            this.btnDeleteWarhouse.Click += new System.EventHandler(this.btnDeleteWarehouse_Click);
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
            this.labelX1.Location = new System.Drawing.Point(119, 10);
            this.labelX1.Name = "labelX1";
            this.labelX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX1.Size = new System.Drawing.Size(13, 23);
            this.labelX1.TabIndex = 11;
            this.labelX1.Text = "*";
            // 
            // dgvWarhouses
            // 
            this.dgvWarhouses.AllowUserToAddRows = false;
            this.dgvWarhouses.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvWarhouses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvWarhouses.AutoGenerateColumns = false;
            this.dgvWarhouses.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWarhouses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvWarhouses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWarhouses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.managerDataGridViewTextBoxColumn});
            this.dgvWarhouses.DataSource = this.anbarBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvWarhouses.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvWarhouses.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvWarhouses.Location = new System.Drawing.Point(9, 190);
            this.dgvWarhouses.MultiSelect = false;
            this.dgvWarhouses.Name = "dgvWarhouses";
            this.dgvWarhouses.ReadOnly = true;
            this.dgvWarhouses.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWarhouses.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvWarhouses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWarhouses.Size = new System.Drawing.Size(465, 200);
            this.dgvWarhouses.TabIndex = 11;
            this.dgvWarhouses.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dgvWarehouse_MouseUp);
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
            this.nameDataGridViewTextBoxColumn.HeaderText = "نام انبار";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "نوع انبار";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // managerDataGridViewTextBoxColumn
            // 
            this.managerDataGridViewTextBoxColumn.DataPropertyName = "manager";
            this.managerDataGridViewTextBoxColumn.HeaderText = "نام انباردار";
            this.managerDataGridViewTextBoxColumn.Name = "managerDataGridViewTextBoxColumn";
            this.managerDataGridViewTextBoxColumn.ReadOnly = true;
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
            // panelEx1
            // 
            this.panelEx1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.dgvWarhouses);
            this.panelEx1.Controls.Add(this.groupPanel1);
            this.panelEx1.Location = new System.Drawing.Point(-2, 1);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(483, 403);
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
            this.groupPanel1.Controls.Add(this.btnPrintWarhouses);
            this.groupPanel1.Controls.Add(this.btnDeleteWarhouse);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Controls.Add(this.btnAddWarhouse);
            this.groupPanel1.Controls.Add(this.btnSearchWarhouse);
            this.groupPanel1.Controls.Add(this.labelX6);
            this.groupPanel1.Controls.Add(this.btnUpdateWarhouse);
            this.groupPanel1.Controls.Add(this.txtWarhouseName);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.txtWarhouseManager);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.txtWarhouseType);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel1.Location = new System.Drawing.Point(9, 10);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(465, 174);
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
            // btnPrintWarhouses
            // 
            this.btnPrintWarhouses.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPrintWarhouses.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPrintWarhouses.Location = new System.Drawing.Point(12, 124);
            this.btnPrintWarhouses.Name = "btnPrintWarhouses";
            this.btnPrintWarhouses.Size = new System.Drawing.Size(434, 23);
            this.btnPrintWarhouses.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPrintWarhouses.TabIndex = 2;
            this.btnPrintWarhouses.Text = "چاپ";
            this.btnPrintWarhouses.Click += new System.EventHandler(this.btnPrintWarehouses_Click);
            // 
            // btnAddWarhouse
            // 
            this.btnAddWarhouse.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddWarhouse.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddWarhouse.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddWarhouse.Image = ((System.Drawing.Image)(resources.GetObject("btnAddWarhouse.Image")));
            this.btnAddWarhouse.Location = new System.Drawing.Point(12, 8);
            this.btnAddWarhouse.Name = "btnAddWarhouse";
            this.btnAddWarhouse.Size = new System.Drawing.Size(75, 23);
            this.btnAddWarhouse.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddWarhouse.TabIndex = 13;
            this.btnAddWarhouse.Text = "درج";
            this.btnAddWarhouse.Click += new System.EventHandler(this.btnAddWarehouse_Click);
            // 
            // btnSearchWarhouse
            // 
            this.btnSearchWarhouse.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearchWarhouse.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSearchWarhouse.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchWarhouse.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchWarhouse.Image")));
            this.btnSearchWarhouse.Location = new System.Drawing.Point(12, 95);
            this.btnSearchWarhouse.Name = "btnSearchWarhouse";
            this.btnSearchWarhouse.Size = new System.Drawing.Size(75, 23);
            this.btnSearchWarhouse.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSearchWarhouse.TabIndex = 0;
            this.btnSearchWarhouse.Text = "جستجو";
            this.btnSearchWarhouse.Click += new System.EventHandler(this.btnSearchWarehouse_Click);
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
            this.labelX6.Location = new System.Drawing.Point(119, 41);
            this.labelX6.Name = "labelX6";
            this.labelX6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX6.Size = new System.Drawing.Size(13, 23);
            this.labelX6.TabIndex = 12;
            this.labelX6.Text = "*";
            // 
            // btnUpdateWarhouse
            // 
            this.btnUpdateWarhouse.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnUpdateWarhouse.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnUpdateWarhouse.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateWarhouse.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateWarhouse.Image")));
            this.btnUpdateWarhouse.Location = new System.Drawing.Point(12, 37);
            this.btnUpdateWarhouse.Name = "btnUpdateWarhouse";
            this.btnUpdateWarhouse.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateWarhouse.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnUpdateWarhouse.TabIndex = 0;
            this.btnUpdateWarhouse.Text = "ویرایش";
            this.btnUpdateWarhouse.Click += new System.EventHandler(this.btnUpdateWarehouse_Click);
            // 
            // txtWarhouseName
            // 
            // 
            // 
            // 
            this.txtWarhouseName.Border.Class = "TextBoxBorder";
            this.txtWarhouseName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtWarhouseName.Location = new System.Drawing.Point(143, 10);
            this.txtWarhouseName.Name = "txtWarhouseName";
            this.txtWarhouseName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtWarhouseName.Size = new System.Drawing.Size(237, 21);
            this.txtWarhouseName.TabIndex = 6;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(397, 12);
            this.labelX2.Name = "labelX2";
            this.labelX2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX2.Size = new System.Drawing.Size(49, 23);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "نام انبار";
            // 
            // txtWarhouseManager
            // 
            // 
            // 
            // 
            this.txtWarhouseManager.Border.Class = "TextBoxBorder";
            this.txtWarhouseManager.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtWarhouseManager.Location = new System.Drawing.Point(143, 70);
            this.txtWarhouseManager.Name = "txtWarhouseManager";
            this.txtWarhouseManager.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtWarhouseManager.Size = new System.Drawing.Size(237, 21);
            this.txtWarhouseManager.TabIndex = 8;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(407, 41);
            this.labelX3.Name = "labelX3";
            this.labelX3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX3.Size = new System.Drawing.Size(39, 23);
            this.labelX3.TabIndex = 2;
            this.labelX3.Text = "نوع انبار";
            // 
            // txtWarhouseType
            // 
            // 
            // 
            // 
            this.txtWarhouseType.Border.Class = "TextBoxBorder";
            this.txtWarhouseType.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtWarhouseType.Location = new System.Drawing.Point(143, 41);
            this.txtWarhouseType.Name = "txtWarhouseType";
            this.txtWarhouseType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtWarhouseType.Size = new System.Drawing.Size(237, 21);
            this.txtWarhouseType.TabIndex = 7;
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.Location = new System.Drawing.Point(407, 70);
            this.labelX4.Name = "labelX4";
            this.labelX4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX4.Size = new System.Drawing.Size(39, 23);
            this.labelX4.TabIndex = 3;
            this.labelX4.Text = "انباردار";
            // 
            // controlContainerItem1
            // 
            this.controlContainerItem1.AllowItemResize = true;
            this.controlContainerItem1.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem1.Name = "controlContainerItem1";
            // 
            // anbarTableAdapter
            // 
            this.anbarTableAdapter.ClearBeforeFill = true;
            // 
            // frmWarehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 403);
            this.Controls.Add(this.panelEx1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(495, 441);
            this.Name = "frmWarehouse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "انبارها";
            this.Load += new System.EventHandler(this.frmWarehouse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWarhouses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anbarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWMS)).EndInit();
            this.panelEx1.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnDeleteWarhouse;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvWarhouses;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.ButtonX btnAddWarhouse;
        private DevComponents.DotNetBar.ButtonX btnSearchWarhouse;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.ButtonX btnUpdateWarhouse;
        private DevComponents.DotNetBar.Controls.TextBoxX txtWarhouseName;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtWarhouseManager;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtWarhouseType;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem1;
        private DevComponents.DotNetBar.ButtonX btnPrintWarhouses;
        private dsWMS dsWMS;
        private System.Windows.Forms.BindingSource anbarBindingSource;
        private dsWMSTableAdapters.anbarTableAdapter anbarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn managerDataGridViewTextBoxColumn;
    }
}