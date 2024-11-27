namespace MBOS_Full_System.PL
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.grp_login = new DevExpress.XtraEditors.GroupControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_err = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.txt_pass = new DevExpress.XtraEditors.TextEdit();
            this.Jop_ID = new DevExpress.XtraEditors.TextEdit();
            this.rolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grp_login)).BeginInit();
            this.grp_login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_pass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Jop_ID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_login
            // 
            this.grp_login.Appearance.BackColor = System.Drawing.Color.White;
            this.grp_login.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_login.Appearance.Options.UseBackColor = true;
            this.grp_login.Appearance.Options.UseFont = true;
            this.grp_login.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_login.AppearanceCaption.Options.UseFont = true;
            this.grp_login.AppearanceCaption.Options.UseTextOptions = true;
            this.grp_login.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grp_login.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.grp_login.Controls.Add(this.labelControl3);
            this.grp_login.Controls.Add(this.labelControl2);
            this.grp_login.Controls.Add(this.panel1);
            this.grp_login.Controls.Add(this.lbl_err);
            this.grp_login.Controls.Add(this.simpleButton1);
            this.grp_login.Controls.Add(this.txt_pass);
            this.grp_login.Controls.Add(this.Jop_ID);
            this.grp_login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grp_login.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.grp_login.Location = new System.Drawing.Point(0, 0);
            this.grp_login.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.grp_login.LookAndFeel.UseDefaultLookAndFeel = false;
            this.grp_login.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.grp_login.Name = "grp_login";
            this.grp_login.Size = new System.Drawing.Size(335, 443);
            this.grp_login.TabIndex = 0;
            this.grp_login.Text = "تسجيل الدخول الى النظام";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(98)))), ((int)(((byte)(112)))));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(258, 331);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 19);
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "كلمة المرور";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(98)))), ((int)(((byte)(112)))));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(251, 287);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(66, 19);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "الرقم الوظيفي";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.BackgroundImage = global::MBOS_Full_System.Properties.Resources.index;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(21, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 219);
            this.panel1.TabIndex = 7;
            // 
            // lbl_err
            // 
            this.lbl_err.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_err.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_err.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_err.Appearance.Options.UseFont = true;
            this.lbl_err.Appearance.Options.UseForeColor = true;
            this.lbl_err.Location = new System.Drawing.Point(38, 367);
            this.lbl_err.Name = "lbl_err";
            this.lbl_err.Size = new System.Drawing.Size(0, 16);
            this.lbl_err.TabIndex = 6;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.simpleButton1.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton1.Location = new System.Drawing.Point(12, 389);
            this.simpleButton1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.simpleButton1.Size = new System.Drawing.Size(297, 40);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "تسجيل الدخول";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // txt_pass
            // 
            this.txt_pass.EditValue = "";
            this.txt_pass.Location = new System.Drawing.Point(21, 323);
            this.txt_pass.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.Properties.Appearance.Options.UseFont = true;
            this.txt_pass.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txt_pass.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.txt_pass.Properties.AutoHeight = false;
            this.txt_pass.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txt_pass.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("txt_pass.Properties.ContextImageOptions.Image")));
            this.txt_pass.Properties.NullValuePrompt = "ادخل كلمة المرور";
            this.txt_pass.Properties.NullValuePromptShowForEmptyValue = true;
            this.txt_pass.Properties.ShowNullValuePromptWhenFocused = true;
            this.txt_pass.Properties.UseSystemPasswordChar = true;
            this.txt_pass.Size = new System.Drawing.Size(217, 36);
            this.txt_pass.TabIndex = 2;
            this.txt_pass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_pass_KeyDown);
            // 
            // Jop_ID
            // 
            this.Jop_ID.EditValue = "";
            this.Jop_ID.Location = new System.Drawing.Point(21, 279);
            this.Jop_ID.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Jop_ID.Name = "Jop_ID";
            this.Jop_ID.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.Jop_ID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Jop_ID.Properties.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("Jop_ID.Properties.Appearance.Image")));
            this.Jop_ID.Properties.Appearance.Options.UseFont = true;
            this.Jop_ID.Properties.Appearance.Options.UseImage = true;
            this.Jop_ID.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Jop_ID.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.Jop_ID.Properties.AutoHeight = false;
            this.Jop_ID.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.Jop_ID.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Jop_ID.Properties.ContextImageOptions.Image")));
            this.Jop_ID.Properties.Mask.BeepOnError = true;
            this.Jop_ID.Properties.Mask.EditMask = "n0";
            this.Jop_ID.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.Jop_ID.Properties.NullValuePrompt = "ادخل رقمك الوظيفي";
            this.Jop_ID.Properties.NullValuePromptShowForEmptyValue = true;
            this.Jop_ID.Properties.ShowNullValuePromptWhenFocused = true;
            this.Jop_ID.Size = new System.Drawing.Size(217, 36);
            this.Jop_ID.TabIndex = 1;
            this.Jop_ID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Jop_ID_KeyDown);
            // 
            // rolesBindingSource
            // 
            this.rolesBindingSource.DataMember = "Roles";
            // 
            // login
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 443);
            this.Controls.Add(this.grp_login);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LookAndFeel.SkinName = "Office 2013";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "login";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تسجيل الدخول";
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grp_login)).EndInit();
            this.grp_login.ResumeLayout(false);
            this.grp_login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_pass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Jop_ID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grp_login;
        private DevExpress.XtraEditors.TextEdit Jop_ID;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl lbl_err;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private ControlSecurityDataSet controlSecurityDataSet;
        private System.Windows.Forms.BindingSource rolesBindingSource;
        private ControlSecurityDataSetTableAdapters.RolesTableAdapter rolesTableAdapter;
        public DevExpress.XtraEditors.TextEdit txt_pass;
    }
}