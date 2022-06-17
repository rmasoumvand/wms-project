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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFactor));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ribbonClientPanel1 = new DevComponents.DotNetBar.Ribbon.RibbonClientPanel();
            this.btn_refresh = new DevComponents.DotNetBar.ButtonX();
            this.btnSearch = new DevComponents.DotNetBar.ButtonX();
            this.btn_del_factor = new DevComponents.DotNetBar.ButtonX();
            this.btn_factor = new DevComponents.DotNetBar.ButtonX();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.expandablePanel1 = new DevComponents.DotNetBar.ExpandablePanel();
            this.ribbonClientPanel2 = new DevComponents.DotNetBar.Ribbon.RibbonClientPanel();
            this.lab_ghimat_kol = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.dataGridViewX2 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btn_search = new DevComponents.DotNetBar.ButtonX();
            this.btn_exit = new DevComponents.DotNetBar.ButtonX();
            this.txt_tahvilgirandeh = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_code_factor = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.ribbonClientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            this.expandablePanel1.SuspendLayout();
            this.ribbonClientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX2)).BeginInit();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonClientPanel1
            // 
            this.ribbonClientPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ribbonClientPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.ribbonClientPanel1.Controls.Add(this.btn_refresh);
            this.ribbonClientPanel1.Controls.Add(this.btnSearch);
            this.ribbonClientPanel1.Controls.Add(this.btn_del_factor);
            this.ribbonClientPanel1.Controls.Add(this.btn_factor);
            this.ribbonClientPanel1.Location = new System.Drawing.Point(0, 0);
            this.ribbonClientPanel1.Name = "ribbonClientPanel1";
            this.ribbonClientPanel1.Size = new System.Drawing.Size(645, 38);
            // 
            // 
            // 
            this.ribbonClientPanel1.Style.Class = "RibbonClientPanel";
            this.ribbonClientPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonClientPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonClientPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonClientPanel1.TabIndex = 0;
            // 
            // btn_refresh
            // 
            this.btn_refresh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_refresh.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_refresh.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.Image = ((System.Drawing.Image)(resources.GetObject("btn_refresh.Image")));
            this.btn_refresh.Location = new System.Drawing.Point(248, 7);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(77, 23);
            this.btn_refresh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_refresh.TabIndex = 4;
            this.btn_refresh.Text = "تازه سازی";
            this.btn_refresh.Click += new System.EventHandler(this.buttonX2_Click);
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
            this.btnSearch.Click += new System.EventHandler(this.buttonX4_Click);
            // 
            // btn_del_factor
            // 
            this.btn_del_factor.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_del_factor.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_del_factor.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_del_factor.Image = ((System.Drawing.Image)(resources.GetObject("btn_del_factor.Image")));
            this.btn_del_factor.Location = new System.Drawing.Point(415, 7);
            this.btn_del_factor.Name = "btn_del_factor";
            this.btn_del_factor.Size = new System.Drawing.Size(86, 23);
            this.btn_del_factor.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_del_factor.TabIndex = 0;
            this.btn_del_factor.Text = "حذف فاکتور";
            this.btn_del_factor.Click += new System.EventHandler(this.buttonX3_Click);
            // 
            // btn_factor
            // 
            this.btn_factor.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_factor.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_factor.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_factor.Image = ((System.Drawing.Image)(resources.GetObject("btn_factor.Image")));
            this.btn_factor.Location = new System.Drawing.Point(507, 7);
            this.btn_factor.Name = "btn_factor";
            this.btn_factor.Size = new System.Drawing.Size(122, 23);
            this.btn_factor.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_factor.TabIndex = 3;
            this.btn_factor.Text = "فاکتور جدید / ویرایش";
            this.btn_factor.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.AllowUserToAddRows = false;
            this.dataGridViewX1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewX1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewX1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewX1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewX1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(0, 38);
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.ReadOnly = true;
            this.dataGridViewX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridViewX1.Size = new System.Drawing.Size(640, 221);
            this.dataGridViewX1.TabIndex = 1;
            this.dataGridViewX1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dataGridViewX1_MouseUp);
            // 
            // expandablePanel1
            // 
            this.expandablePanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.expandablePanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.expandablePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.expandablePanel1.Controls.Add(this.ribbonClientPanel2);
            this.expandablePanel1.Controls.Add(this.dataGridViewX2);
           // this.expandablePanel1.DisabledBackColor = System.Drawing.Color.Empty;
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
            this.ribbonClientPanel2.Controls.Add(this.lab_ghimat_kol);
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
            this.ribbonClientPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonClientPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonClientPanel2.TabIndex = 4;
            // 
            // lab_ghimat_kol
            // 
            this.lab_ghimat_kol.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lab_ghimat_kol.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lab_ghimat_kol.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_ghimat_kol.ForeColor = System.Drawing.Color.Red;
            this.lab_ghimat_kol.Location = new System.Drawing.Point(491, 4);
            this.lab_ghimat_kol.Name = "lab_ghimat_kol";
            this.lab_ghimat_kol.Size = new System.Drawing.Size(79, 23);
            this.lab_ghimat_kol.TabIndex = 3;
            this.lab_ghimat_kol.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.ForeColor = System.Drawing.Color.Red;
            this.labelX3.Location = new System.Drawing.Point(554, 4);
            this.labelX3.Name = "labelX3";
            this.labelX3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 2;
            this.labelX3.Text = " قیمت کل  : ";
            // 
            // dataGridViewX2
            // 
            this.dataGridViewX2.AllowUserToAddRows = false;
            this.dataGridViewX2.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewX2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewX2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewX2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX2.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewX2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX2.Location = new System.Drawing.Point(0, 26);
            this.dataGridViewX2.Name = "dataGridViewX2";
            this.dataGridViewX2.ReadOnly = true;
            this.dataGridViewX2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridViewX2.Size = new System.Drawing.Size(645, 199);
            this.dataGridViewX2.TabIndex = 1;
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.labelX2);
            this.panelEx1.Controls.Add(this.labelX1);
            this.panelEx1.Controls.Add(this.btn_search);
            this.panelEx1.Controls.Add(this.btn_exit);
            this.panelEx1.Controls.Add(this.txt_tahvilgirandeh);
            this.panelEx1.Controls.Add(this.txt_code_factor);
           // this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Location = new System.Drawing.Point(272, 39);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(200, 100);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 3;
            // 
            // labelX2
            // 
            // 
            // 
            // 
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
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(133, 13);
            this.labelX1.Name = "labelX1";
            this.labelX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX1.Size = new System.Drawing.Size(50, 23);
            this.labelX1.TabIndex = 3;
            this.labelX1.Text = "کد فاکتور";
            // 
            // btn_search
            // 
            this.btn_search.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_search.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_search.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(104, 65);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_search.TabIndex = 0;
            this.btn_search.Text = "جستجو";
            this.btn_search.Click += new System.EventHandler(this.buttonX6_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_exit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_exit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(23, 65);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_exit.TabIndex = 2;
            this.btn_exit.Text = "خروج";
            this.btn_exit.Click += new System.EventHandler(this.buttonX5_Click);
            // 
            // txt_tahvilgirandeh
            // 
            // 
            // 
            // 
            this.txt_tahvilgirandeh.Border.Class = "TextBoxBorder";
            this.txt_tahvilgirandeh.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_tahvilgirandeh.Location = new System.Drawing.Point(23, 39);
            this.txt_tahvilgirandeh.Name = "txt_tahvilgirandeh";
            this.txt_tahvilgirandeh.Size = new System.Drawing.Size(98, 20);
            this.txt_tahvilgirandeh.TabIndex = 1;
            // 
            // txt_code_factor
            // 
            // 
            // 
            // 
            this.txt_code_factor.Border.Class = "TextBoxBorder";
            this.txt_code_factor.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_code_factor.Location = new System.Drawing.Point(23, 13);
            this.txt_code_factor.Name = "txt_code_factor";
            this.txt_code_factor.Size = new System.Drawing.Size(98, 20);
            this.txt_code_factor.TabIndex = 0;
            this.txt_code_factor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxX1_KeyPress);
            // 
            // Form_factor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 513);
            this.Controls.Add(this.panelEx1);
            this.Controls.Add(this.expandablePanel1);
            this.Controls.Add(this.dataGridViewX1);
            this.Controls.Add(this.ribbonClientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(651, 551);
            this.Name = "Form_factor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نمایش فاکتور";
            this.Load += new System.EventHandler(this.frmFactor_Load);
            this.ribbonClientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            this.expandablePanel1.ResumeLayout(false);
            this.ribbonClientPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX2)).EndInit();
            this.panelEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Ribbon.RibbonClientPanel ribbonClientPanel1;
        private DevComponents.DotNetBar.ButtonX btnSearch;
        private DevComponents.DotNetBar.ButtonX btn_del_factor;
        private DevComponents.DotNetBar.ButtonX btn_factor;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private DevComponents.DotNetBar.ExpandablePanel expandablePanel1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX2;
        private DevComponents.DotNetBar.ButtonX btn_refresh;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btn_search;
        private DevComponents.DotNetBar.ButtonX btn_exit;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_tahvilgirandeh;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_code_factor;
        private DevComponents.DotNetBar.LabelX lab_ghimat_kol;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Ribbon.RibbonClientPanel ribbonClientPanel2;

    }
}