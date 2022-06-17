namespace WMS
{
    partial class frmUnits
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUnits));
            this.controlContainerItem1 = new DevComponents.DotNetBar.ControlContainerItem();
            this.dgvUnit = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.btnPrintUnits = new DevComponents.DotNetBar.ButtonX();
            this.btnDeleteUnit = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btnAddUnit = new DevComponents.DotNetBar.ButtonX();
            this.btnSearchUnit = new DevComponents.DotNetBar.ButtonX();
            this.btnUpdateUnit = new DevComponents.DotNetBar.ButtonX();
            this.txtUnitName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.ribbonClientPanel1 = new DevComponents.DotNetBar.Ribbon.RibbonClientPanel();
            this.dsWMS = new WMS.dsWMS();
            this.unitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unitTableAdapter = new WMS.dsWMSTableAdapters.unitTableAdapter();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnit)).BeginInit();
            this.groupPanel1.SuspendLayout();
            this.ribbonClientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsWMS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // controlContainerItem1
            // 
            this.controlContainerItem1.AllowItemResize = true;
            this.controlContainerItem1.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem1.Name = "controlContainerItem1";
            // 
            // dgvUnit
            // 
            this.dgvUnit.AllowUserToAddRows = false;
            this.dgvUnit.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvUnit.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUnit.AutoGenerateColumns = false;
            this.dgvUnit.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvUnit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn});
            this.dgvUnit.DataSource = this.unitBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUnit.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUnit.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvUnit.Location = new System.Drawing.Point(126, 41);
            this.dgvUnit.MultiSelect = false;
            this.dgvUnit.Name = "dgvUnit";
            this.dgvUnit.ReadOnly = true;
            this.dgvUnit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvUnit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUnit.Size = new System.Drawing.Size(210, 234);
            this.dgvUnit.TabIndex = 11;
            this.dgvUnit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dgvUnits_MouseUp);
            // 
            // btnPrintUnits
            // 
            this.btnPrintUnits.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPrintUnits.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPrintUnits.Location = new System.Drawing.Point(33, 157);
            this.btnPrintUnits.Name = "btnPrintUnits";
            this.btnPrintUnits.Size = new System.Drawing.Size(75, 23);
            this.btnPrintUnits.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPrintUnits.TabIndex = 2;
            this.btnPrintUnits.Text = "چاپ";
            this.btnPrintUnits.Click += new System.EventHandler(this.btnPrintUnits_Click);
            // 
            // btnDeleteUnit
            // 
            this.btnDeleteUnit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDeleteUnit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDeleteUnit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUnit.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteUnit.Image")));
            this.btnDeleteUnit.Location = new System.Drawing.Point(33, 99);
            this.btnDeleteUnit.Name = "btnDeleteUnit";
            this.btnDeleteUnit.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteUnit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDeleteUnit.TabIndex = 0;
            this.btnDeleteUnit.Text = "حذف";
            this.btnDeleteUnit.Click += new System.EventHandler(this.btnDeleteUnit_Click);
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.groupPanel1.Controls.Add(this.dgvUnit);
            this.groupPanel1.Controls.Add(this.btnPrintUnits);
            this.groupPanel1.Controls.Add(this.btnDeleteUnit);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Controls.Add(this.btnAddUnit);
            this.groupPanel1.Controls.Add(this.btnSearchUnit);
            this.groupPanel1.Controls.Add(this.btnUpdateUnit);
            this.groupPanel1.Controls.Add(this.txtUnitName);
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
            // btnAddUnit
            // 
            this.btnAddUnit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddUnit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddUnit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUnit.Image = ((System.Drawing.Image)(resources.GetObject("btnAddUnit.Image")));
            this.btnAddUnit.Location = new System.Drawing.Point(33, 41);
            this.btnAddUnit.Name = "btnAddUnit";
            this.btnAddUnit.Size = new System.Drawing.Size(75, 23);
            this.btnAddUnit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddUnit.TabIndex = 13;
            this.btnAddUnit.Text = "درج";
            this.btnAddUnit.Click += new System.EventHandler(this.btnAddUnit_Click);
            // 
            // btnSearchUnit
            // 
            this.btnSearchUnit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearchUnit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSearchUnit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchUnit.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchUnit.Image")));
            this.btnSearchUnit.Location = new System.Drawing.Point(33, 128);
            this.btnSearchUnit.Name = "btnSearchUnit";
            this.btnSearchUnit.Size = new System.Drawing.Size(75, 23);
            this.btnSearchUnit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSearchUnit.TabIndex = 0;
            this.btnSearchUnit.Text = "جستجو";
            this.btnSearchUnit.Click += new System.EventHandler(this.btnSearchUnit_Click);
            // 
            // btnUpdateUnit
            // 
            this.btnUpdateUnit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnUpdateUnit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnUpdateUnit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateUnit.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateUnit.Image")));
            this.btnUpdateUnit.Location = new System.Drawing.Point(33, 70);
            this.btnUpdateUnit.Name = "btnUpdateUnit";
            this.btnUpdateUnit.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateUnit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnUpdateUnit.TabIndex = 0;
            this.btnUpdateUnit.Text = "ویرایش";
            this.btnUpdateUnit.Click += new System.EventHandler(this.btnUpdateUnit_Click);
            // 
            // txtUnitName
            // 
            // 
            // 
            // 
            this.txtUnitName.Border.Class = "TextBoxBorder";
            this.txtUnitName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtUnitName.Location = new System.Drawing.Point(33, 10);
            this.txtUnitName.Name = "txtUnitName";
            this.txtUnitName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtUnitName.Size = new System.Drawing.Size(237, 21);
            this.txtUnitName.TabIndex = 6;
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
            this.labelX2.Location = new System.Drawing.Point(276, 12);
            this.labelX2.Name = "labelX2";
            this.labelX2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX2.Size = new System.Drawing.Size(60, 23);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "عنوان واحد";
            // 
            // ribbonClientPanel1
            // 
            this.ribbonClientPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.ribbonClientPanel1.Controls.Add(this.groupPanel1);
            this.ribbonClientPanel1.Location = new System.Drawing.Point(0, 0);
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
            this.ribbonClientPanel1.TabIndex = 15;
            // 
            // dsWMS
            // 
            this.dsWMS.DataSetName = "dsWMS";
            this.dsWMS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // unitBindingSource
            // 
            this.unitBindingSource.DataMember = "unit";
            this.unitBindingSource.DataSource = this.dsWMS;
            // 
            // unitTableAdapter
            // 
            this.unitTableAdapter.ClearBeforeFill = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "واحد";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmUnits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 328);
            this.Controls.Add(this.ribbonClientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(402, 366);
            this.Name = "frmUnits";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "واحدها";
            this.Load += new System.EventHandler(this.frmUnits_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnit)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            this.ribbonClientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsWMS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvUnit;
        private DevComponents.DotNetBar.ButtonX btnPrintUnits;
        private DevComponents.DotNetBar.ButtonX btnDeleteUnit;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btnAddUnit;
        private DevComponents.DotNetBar.ButtonX btnSearchUnit;
        private DevComponents.DotNetBar.ButtonX btnUpdateUnit;
        private DevComponents.DotNetBar.Controls.TextBoxX txtUnitName;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Ribbon.RibbonClientPanel ribbonClientPanel1;
        private dsWMS dsWMS;
        private System.Windows.Forms.BindingSource unitBindingSource;
        private dsWMSTableAdapters.unitTableAdapter unitTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}