namespace WMS
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.expandablePanel1 = new DevComponents.DotNetBar.ExpandablePanel();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.cmbUserLogin = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.uSERTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsWMS = new WMS.dsWMS();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnLogin = new DevComponents.DotNetBar.ButtonX();
            this.reflectionImage1 = new DevComponents.DotNetBar.Controls.ReflectionImage();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btn_time = new DevComponents.DotNetBar.ButtonX();
            this.btn_date = new DevComponents.DotNetBar.ButtonX();
            this.loginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.comboItem4 = new DevComponents.Editors.ComboItem();
            this.loginTableAdapter = new WMS.dsWMSTableAdapters.loginTableAdapter();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.uSER_TBLTableAdapter = new WMS.dsWMSTableAdapters.USER_TBLTableAdapter();
            this.expandablePanel1.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uSERTBLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWMS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // expandablePanel1
            // 
            this.expandablePanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.expandablePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.expandablePanel1.Controls.Add(this.groupPanel1);
            this.expandablePanel1.Controls.Add(this.btn_time);
            this.expandablePanel1.Controls.Add(this.btn_date);
            this.expandablePanel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expandablePanel1.Location = new System.Drawing.Point(0, 0);
            this.expandablePanel1.Name = "expandablePanel1";
            this.expandablePanel1.Size = new System.Drawing.Size(385, 238);
            this.expandablePanel1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expandablePanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.expandablePanel1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.expandablePanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.expandablePanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandablePanel1.Style.GradientAngle = 90;
            this.expandablePanel1.TabIndex = 0;
            this.expandablePanel1.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel1.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel1.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expandablePanel1.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.expandablePanel1.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandablePanel1.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.expandablePanel1.TitleStyle.GradientAngle = 90;
            this.expandablePanel1.TitleText = "ورود";
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.cmbUserLogin);
            this.groupPanel1.Controls.Add(this.btnCancel);
            this.groupPanel1.Controls.Add(this.btnLogin);
            this.groupPanel1.Controls.Add(this.reflectionImage1);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Controls.Add(this.txtPassword);
            this.groupPanel1.Location = new System.Drawing.Point(10, 69);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(364, 154);
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
            this.groupPanel1.TabIndex = 2;
            this.groupPanel1.Text = "اطلاعات ورود";
            // 
            // cmbUserLogin
            // 
            this.cmbUserLogin.DataSource = this.uSERTBLBindingSource;
            this.cmbUserLogin.DisplayMember = "USER_NAME";
            this.cmbUserLogin.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbUserLogin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUserLogin.FormattingEnabled = true;
            this.cmbUserLogin.ItemHeight = 15;
            this.cmbUserLogin.Location = new System.Drawing.Point(139, 22);
            this.cmbUserLogin.Name = "cmbUserLogin";
            this.cmbUserLogin.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbUserLogin.Size = new System.Drawing.Size(121, 21);
            this.cmbUserLogin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbUserLogin.TabIndex = 7;
            this.cmbUserLogin.SelectedIndexChanged += new System.EventHandler(this.cmbUserLogin_SelectedIndexChanged);
            // 
            // uSERTBLBindingSource
            // 
            this.uSERTBLBindingSource.DataMember = "USER_TBL";
            this.uSERTBLBindingSource.DataSource = this.dsWMS;
            // 
            // dsWMS
            // 
            this.dsWMS.DataSetName = "dsWMS";
            this.dsWMS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Location = new System.Drawing.Point(203, 99);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(68, 23);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "انصراف";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLogin.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLogin.Location = new System.Drawing.Point(276, 99);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(68, 23);
            this.btnLogin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "ورود";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // reflectionImage1
            // 
            // 
            // 
            // 
            this.reflectionImage1.BackgroundStyle.Class = "";
            this.reflectionImage1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionImage1.Image = global::WMS.Properties.Resources.preferences_desktop_user_password;
            this.reflectionImage1.Location = new System.Drawing.Point(3, -2);
            this.reflectionImage1.Name = "reflectionImage1";
            this.reflectionImage1.Size = new System.Drawing.Size(134, 128);
            this.reflectionImage1.TabIndex = 6;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(266, 50);
            this.labelX2.Name = "labelX2";
            this.labelX2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 4;
            this.labelX2.Text = "کلمه عبور";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(266, 20);
            this.labelX1.Name = "labelX1";
            this.labelX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 3;
            this.labelX1.Text = "نام کاربری";
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.Border.Class = "TextBoxBorder";
            this.txtPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPassword.Location = new System.Drawing.Point(139, 52);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(121, 21);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // btn_time
            // 
            this.btn_time.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_time.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_time.Location = new System.Drawing.Point(193, 36);
            this.btn_time.Name = "btn_time";
            this.btn_time.Size = new System.Drawing.Size(181, 27);
            this.btn_time.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_time.TabIndex = 6;
            this.btn_time.Text = "time";
            // 
            // btn_date
            // 
            this.btn_date.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_date.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_date.Location = new System.Drawing.Point(10, 36);
            this.btn_date.Name = "btn_date";
            this.btn_date.Size = new System.Drawing.Size(177, 27);
            this.btn_date.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_date.TabIndex = 5;
            this.btn_date.Text = "date";
            // 
            // loginBindingSource
            // 
            this.loginBindingSource.DataMember = "login";
            this.loginBindingSource.DataSource = this.dsWMS;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Windows7Blue;
            // 
            // comboItem3
            // 
            this.comboItem3.Text = "مدیر";
            // 
            // comboItem4
            // 
            this.comboItem4.Text = "کاربر";
            // 
            // loginTableAdapter
            // 
            this.loginTableAdapter.ClearBeforeFill = true;
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "کاربر";
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "مدیر";
            // 
            // uSER_TBLTableAdapter
            // 
            this.uSER_TBLTableAdapter.ClearBeforeFill = true;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(386, 238);
            this.Controls.Add(this.expandablePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.TransparencyKey = System.Drawing.SystemColors.ActiveCaption;
            this.Load += new System.EventHandler(this.login_Load);
            this.expandablePanel1.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uSERTBLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWMS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ExpandablePanel expandablePanel1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.ButtonX btn_time;
        private DevComponents.DotNetBar.ButtonX btn_date;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPassword;
        private DevComponents.DotNetBar.Controls.ReflectionImage reflectionImage1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.Timer timer1;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.ButtonX btnLogin;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbUserLogin;
        private DevComponents.Editors.ComboItem comboItem3;
        private DevComponents.Editors.ComboItem comboItem4;
        private dsWMS dsWMS;
        private System.Windows.Forms.BindingSource loginBindingSource;
        private dsWMSTableAdapters.loginTableAdapter loginTableAdapter;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.Editors.ComboItem comboItem1;
        private System.Windows.Forms.BindingSource uSERTBLBindingSource;
        private dsWMSTableAdapters.USER_TBLTableAdapter uSER_TBLTableAdapter;
    }
}