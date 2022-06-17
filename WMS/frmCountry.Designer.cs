namespace WMS
{
    partial class frmCountry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCountry));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnPrintCountries = new DevComponents.DotNetBar.ButtonX();
            this.btnDeleteCountry = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgvCountry = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dsWMS = new WMS.dsWMS();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btnAddCountry = new DevComponents.DotNetBar.ButtonX();
            this.btnSearchCountry = new DevComponents.DotNetBar.ButtonX();
            this.btnUpdateCountry = new DevComponents.DotNetBar.ButtonX();
            this.txtCountryName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.countryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.controlContainerItem1 = new DevComponents.DotNetBar.ControlContainerItem();
            this.ribbonClientPanel1 = new DevComponents.DotNetBar.Ribbon.RibbonClientPanel();
            this.countryTableAdapter = new WMS.dsWMSTableAdapters.countryTableAdapter();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWMS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).BeginInit();
            this.ribbonClientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPrintCountries
            // 
            this.btnPrintCountries.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPrintCountries.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPrintCountries.Location = new System.Drawing.Point(33, 157);
            this.btnPrintCountries.Name = "btnPrintCountries";
            this.btnPrintCountries.Size = new System.Drawing.Size(75, 23);
            this.btnPrintCountries.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPrintCountries.TabIndex = 2;
            this.btnPrintCountries.Text = "چاپ";
            this.btnPrintCountries.Click += new System.EventHandler(this.btnPrintCountries_Click);
            // 
            // btnDeleteCountry
            // 
            this.btnDeleteCountry.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDeleteCountry.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDeleteCountry.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCountry.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteCountry.Image")));
            this.btnDeleteCountry.Location = new System.Drawing.Point(33, 99);
            this.btnDeleteCountry.Name = "btnDeleteCountry";
            this.btnDeleteCountry.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteCountry.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDeleteCountry.TabIndex = 0;
            this.btnDeleteCountry.Text = "حذف";
            this.btnDeleteCountry.Click += new System.EventHandler(this.btnDeleteCountry_Click);
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.groupPanel1.Controls.Add(this.dgvCountry);
            this.groupPanel1.Controls.Add(this.btnPrintCountries);
            this.groupPanel1.Controls.Add(this.btnDeleteCountry);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Controls.Add(this.btnAddCountry);
            this.groupPanel1.Controls.Add(this.btnSearchCountry);
            this.groupPanel1.Controls.Add(this.btnUpdateCountry);
            this.groupPanel1.Controls.Add(this.txtCountryName);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel1.Location = new System.Drawing.Point(11, 11);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(363, 306);
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
            // dgvCountry
            // 
            this.dgvCountry.AllowUserToAddRows = false;
            this.dgvCountry.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvCountry.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCountry.AutoGenerateColumns = false;
            this.dgvCountry.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvCountry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCountry.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn});
            this.dgvCountry.DataSource = this.countryBindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCountry.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCountry.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvCountry.Location = new System.Drawing.Point(126, 41);
            this.dgvCountry.MultiSelect = false;
            this.dgvCountry.Name = "dgvCountry";
            this.dgvCountry.ReadOnly = true;
            this.dgvCountry.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvCountry.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCountry.Size = new System.Drawing.Size(210, 234);
            this.dgvCountry.TabIndex = 11;
            this.dgvCountry.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dgvCountry_MouseUp);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "نام کشور";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countryBindingSource1
            // 
            this.countryBindingSource1.DataMember = "country";
            this.countryBindingSource1.DataSource = this.dsWMS;
            // 
            // dsWMS
            // 
            this.dsWMS.DataSetName = "dsWMS";
            this.dsWMS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.Color.Red;
            this.labelX1.Location = new System.Drawing.Point(9, 10);
            this.labelX1.Name = "labelX1";
            this.labelX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX1.Size = new System.Drawing.Size(13, 23);
            this.labelX1.TabIndex = 11;
            this.labelX1.Text = "*";
            // 
            // btnAddCountry
            // 
            this.btnAddCountry.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddCountry.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddCountry.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCountry.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCountry.Image")));
            this.btnAddCountry.Location = new System.Drawing.Point(33, 41);
            this.btnAddCountry.Name = "btnAddCountry";
            this.btnAddCountry.Size = new System.Drawing.Size(75, 23);
            this.btnAddCountry.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddCountry.TabIndex = 13;
            this.btnAddCountry.Text = "درج";
            this.btnAddCountry.Click += new System.EventHandler(this.btnAddCountry_Click);
            // 
            // btnSearchCountry
            // 
            this.btnSearchCountry.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearchCountry.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSearchCountry.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCountry.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchCountry.Image")));
            this.btnSearchCountry.Location = new System.Drawing.Point(33, 128);
            this.btnSearchCountry.Name = "btnSearchCountry";
            this.btnSearchCountry.Size = new System.Drawing.Size(75, 23);
            this.btnSearchCountry.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSearchCountry.TabIndex = 0;
            this.btnSearchCountry.Text = "جستجو";
            this.btnSearchCountry.Click += new System.EventHandler(this.btnSearchCountry_Click);
            // 
            // btnUpdateCountry
            // 
            this.btnUpdateCountry.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnUpdateCountry.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnUpdateCountry.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCountry.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateCountry.Image")));
            this.btnUpdateCountry.Location = new System.Drawing.Point(33, 70);
            this.btnUpdateCountry.Name = "btnUpdateCountry";
            this.btnUpdateCountry.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateCountry.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnUpdateCountry.TabIndex = 0;
            this.btnUpdateCountry.Text = "ویرایش";
            this.btnUpdateCountry.Click += new System.EventHandler(this.btnUpdateCountry_Click);
            // 
            // txtCountryName
            // 
            // 
            // 
            // 
            this.txtCountryName.Border.Class = "TextBoxBorder";
            this.txtCountryName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCountryName.Location = new System.Drawing.Point(33, 10);
            this.txtCountryName.Name = "txtCountryName";
            this.txtCountryName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCountryName.Size = new System.Drawing.Size(237, 21);
            this.txtCountryName.TabIndex = 6;
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
            this.labelX2.Location = new System.Drawing.Point(287, 12);
            this.labelX2.Name = "labelX2";
            this.labelX2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX2.Size = new System.Drawing.Size(49, 23);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "نام کشور";
            // 
            // countryBindingSource
            // 
            this.countryBindingSource.DataMember = "country";
            this.countryBindingSource.DataSource = this.dsWMS;
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
            this.ribbonClientPanel1.Location = new System.Drawing.Point(1, 1);
            this.ribbonClientPanel1.Name = "ribbonClientPanel1";
            this.ribbonClientPanel1.Size = new System.Drawing.Size(387, 329);
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
            this.ribbonClientPanel1.TabIndex = 14;
            // 
            // countryTableAdapter
            // 
            this.countryTableAdapter.ClearBeforeFill = true;
            // 
            // frmCountry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 329);
            this.Controls.Add(this.ribbonClientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(402, 367);
            this.Name = "frmCountry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "کشورها";
            this.Load += new System.EventHandler(this.frmCountry_Load);
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWMS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).EndInit();
            this.ribbonClientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnPrintCountries;
        private DevComponents.DotNetBar.ButtonX btnDeleteCountry;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btnAddCountry;
        private DevComponents.DotNetBar.ButtonX btnSearchCountry;
        private DevComponents.DotNetBar.ButtonX btnUpdateCountry;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCountryName;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvCountry;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem1;
        private DevComponents.DotNetBar.Ribbon.RibbonClientPanel ribbonClientPanel1;
        private dsWMS dsWMS;
        private System.Windows.Forms.BindingSource countryBindingSource;
        private dsWMSTableAdapters.countryTableAdapter countryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource countryBindingSource1;
    }
}