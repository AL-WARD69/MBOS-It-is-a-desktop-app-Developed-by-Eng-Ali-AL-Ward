namespace MBOS_Full_System
{
    partial class Roles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Roles));
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.UserGridControl = new DevExpress.XtraGrid.GridControl();
            this.UserGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.Edit_PassWord_Btn = new DevExpress.XtraEditors.SimpleButton();
            this.Edit_User_Btn = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.Add_User_Btn = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.RoleGridControl = new DevExpress.XtraGrid.GridControl();
            this.RoleGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.Edit_Role_Btn = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.Add_Role = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.usersToRolesTableAdapter = new MBOS_Full_System.ControlSecurityDataSetTableAdapters.UsersToRolesTableAdapter();
            this.tabNavigationPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoleGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoleGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.tabNavigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.Caption = "المستخدمين";
            this.tabNavigationPage2.Controls.Add(this.UserGridControl);
            this.tabNavigationPage2.Controls.Add(this.panelControl2);
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.Size = new System.Drawing.Size(812, 522);
            // 
            // UserGridControl
            // 
            this.UserGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserGridControl.Location = new System.Drawing.Point(3, 62);
            this.UserGridControl.MainView = this.UserGridView;
            this.UserGridControl.Name = "UserGridControl";
            this.UserGridControl.Size = new System.Drawing.Size(806, 428);
            this.UserGridControl.TabIndex = 14;
            this.UserGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.UserGridView});
            // 
            // UserGridView
            // 
            this.UserGridView.GridControl = this.UserGridControl;
            this.UserGridView.Name = "UserGridView";
            this.UserGridView.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.UserGridView_RowClick);
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(98)))), ((int)(((byte)(112)))));
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.Edit_PassWord_Btn);
            this.panelControl2.Controls.Add(this.Edit_User_Btn);
            this.panelControl2.Controls.Add(this.labelControl3);
            this.panelControl2.Controls.Add(this.Add_User_Btn);
            this.panelControl2.Controls.Add(this.labelControl4);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.panelControl2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(812, 64);
            this.panelControl2.TabIndex = 11;
            // 
            // Edit_PassWord_Btn
            // 
            this.Edit_PassWord_Btn.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.False;
            this.Edit_PassWord_Btn.Appearance.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Edit_PassWord_Btn.Appearance.BackColor2 = System.Drawing.Color.MediumSeaGreen;
            this.Edit_PassWord_Btn.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Edit_PassWord_Btn.Appearance.ForeColor = System.Drawing.Color.White;
            this.Edit_PassWord_Btn.Appearance.Options.UseBackColor = true;
            this.Edit_PassWord_Btn.Appearance.Options.UseFont = true;
            this.Edit_PassWord_Btn.Appearance.Options.UseForeColor = true;
            this.Edit_PassWord_Btn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.Edit_PassWord_Btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Edit_PassWord_Btn.ImageOptions.Image")));
            this.Edit_PassWord_Btn.Location = new System.Drawing.Point(181, 18);
            this.Edit_PassWord_Btn.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Edit_PassWord_Btn.Name = "Edit_PassWord_Btn";
            this.Edit_PassWord_Btn.Size = new System.Drawing.Size(126, 25);
            this.Edit_PassWord_Btn.TabIndex = 3;
            this.Edit_PassWord_Btn.Text = "تغيير كلمة المرور";
            this.Edit_PassWord_Btn.Click += new System.EventHandler(this.Edit_PassWord_Btn_Click);
            // 
            // Edit_User_Btn
            // 
            this.Edit_User_Btn.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.False;
            this.Edit_User_Btn.Appearance.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Edit_User_Btn.Appearance.BackColor2 = System.Drawing.Color.MediumSeaGreen;
            this.Edit_User_Btn.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Edit_User_Btn.Appearance.ForeColor = System.Drawing.Color.White;
            this.Edit_User_Btn.Appearance.Options.UseBackColor = true;
            this.Edit_User_Btn.Appearance.Options.UseFont = true;
            this.Edit_User_Btn.Appearance.Options.UseForeColor = true;
            this.Edit_User_Btn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.Edit_User_Btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Edit_User_Btn.ImageOptions.Image")));
            this.Edit_User_Btn.Location = new System.Drawing.Point(101, 18);
            this.Edit_User_Btn.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Edit_User_Btn.Name = "Edit_User_Btn";
            this.Edit_User_Btn.Size = new System.Drawing.Size(74, 25);
            this.Edit_User_Btn.TabIndex = 3;
            this.Edit_User_Btn.Text = "تعديل";
            this.Edit_User_Btn.Click += new System.EventHandler(this.Edit_User_Btn_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.ForeColor = System.Drawing.SystemColors.Info;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl3.Location = new System.Drawing.Point(579, 42);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(221, 14);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "ادارة المستخدمين وتعديل صلاحياتهم";
            // 
            // Add_User_Btn
            // 
            this.Add_User_Btn.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.False;
            this.Add_User_Btn.Appearance.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Add_User_Btn.Appearance.BackColor2 = System.Drawing.Color.MediumSeaGreen;
            this.Add_User_Btn.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Add_User_Btn.Appearance.ForeColor = System.Drawing.Color.White;
            this.Add_User_Btn.Appearance.Options.UseBackColor = true;
            this.Add_User_Btn.Appearance.Options.UseFont = true;
            this.Add_User_Btn.Appearance.Options.UseForeColor = true;
            this.Add_User_Btn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.Add_User_Btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Add_User_Btn.ImageOptions.Image")));
            this.Add_User_Btn.Location = new System.Drawing.Point(22, 18);
            this.Add_User_Btn.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Add_User_Btn.Name = "Add_User_Btn";
            this.Add_User_Btn.Size = new System.Drawing.Size(73, 25);
            this.Add_User_Btn.TabIndex = 2;
            this.Add_User_Btn.Text = "أضافة";
            this.Add_User_Btn.Click += new System.EventHandler(this.Add_User_Btn_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 17F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.ForeColor = System.Drawing.SystemColors.Info;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl4.Location = new System.Drawing.Point(544, 9);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(256, 28);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "ادارة المستخدمين";
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.RoleGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // RoleGridControl
            // 
            this.RoleGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RoleGridControl.Location = new System.Drawing.Point(3, 62);
            this.RoleGridControl.MainView = this.RoleGridView;
            this.RoleGridControl.Name = "RoleGridControl";
            this.RoleGridControl.Size = new System.Drawing.Size(806, 457);
            this.RoleGridControl.TabIndex = 13;
            this.RoleGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.RoleGridView,
            this.gridView2,
            this.gridView1});
            // 
            // RoleGridView
            // 
            this.RoleGridView.GridControl = this.RoleGridControl;
            this.RoleGridView.Name = "RoleGridView";
            this.RoleGridView.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.RoleGridView_RowClick);
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.RoleGridControl;
            this.gridView2.Name = "gridView2";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "الادوار الوظيفية";
            this.tabNavigationPage1.Controls.Add(this.RoleGridControl);
            this.tabNavigationPage1.Controls.Add(this.panelControl1);
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(812, 522);
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(98)))), ((int)(((byte)(112)))));
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.Edit_Role_Btn);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.Add_Role);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.panelControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(812, 69);
            this.panelControl1.TabIndex = 10;
            // 
            // Edit_Role_Btn
            // 
            this.Edit_Role_Btn.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.False;
            this.Edit_Role_Btn.Appearance.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Edit_Role_Btn.Appearance.BackColor2 = System.Drawing.Color.MediumSeaGreen;
            this.Edit_Role_Btn.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Edit_Role_Btn.Appearance.ForeColor = System.Drawing.Color.White;
            this.Edit_Role_Btn.Appearance.Options.UseBackColor = true;
            this.Edit_Role_Btn.Appearance.Options.UseFont = true;
            this.Edit_Role_Btn.Appearance.Options.UseForeColor = true;
            this.Edit_Role_Btn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.Edit_Role_Btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Edit_Role_Btn.ImageOptions.Image")));
            this.Edit_Role_Btn.Location = new System.Drawing.Point(102, 22);
            this.Edit_Role_Btn.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Edit_Role_Btn.Name = "Edit_Role_Btn";
            this.Edit_Role_Btn.Size = new System.Drawing.Size(74, 25);
            this.Edit_Role_Btn.TabIndex = 3;
            this.Edit_Role_Btn.Text = "تعديل";
            this.Edit_Role_Btn.Click += new System.EventHandler(this.Edit_Role_Btn_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.ForeColor = System.Drawing.SystemColors.Info;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl2.Location = new System.Drawing.Point(267, 42);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(527, 14);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "تستطيع من هذه الشاشة اضافة وتعديل الادوار الوظيفية";
            // 
            // Add_Role
            // 
            this.Add_Role.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.False;
            this.Add_Role.Appearance.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Add_Role.Appearance.BackColor2 = System.Drawing.Color.MediumSeaGreen;
            this.Add_Role.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Add_Role.Appearance.ForeColor = System.Drawing.Color.White;
            this.Add_Role.Appearance.Options.UseBackColor = true;
            this.Add_Role.Appearance.Options.UseFont = true;
            this.Add_Role.Appearance.Options.UseForeColor = true;
            this.Add_Role.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.Add_Role.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Add_Role.ImageOptions.Image")));
            this.Add_Role.Location = new System.Drawing.Point(23, 22);
            this.Add_Role.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Add_Role.Name = "Add_Role";
            this.Add_Role.Size = new System.Drawing.Size(73, 25);
            this.Add_Role.TabIndex = 2;
            this.Add_Role.Text = "أضافة";
            this.Add_Role.Click += new System.EventHandler(this.Add_Role_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 17F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.Info;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl1.Location = new System.Drawing.Point(538, 8);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(256, 28);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "الادوار الوظيفية";
            // 
            // tabPane1
            // 
            this.tabPane1.AllowCollapse = DevExpress.Utils.DefaultBoolean.Default;
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Controls.Add(this.tabNavigationPage2);
            this.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPane1.Location = new System.Drawing.Point(0, 0);
            this.tabPane1.LookAndFeel.SkinName = "Office 2016 Colorful";
            this.tabPane1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1,
            this.tabNavigationPage2});
            this.tabPane1.RegularSize = new System.Drawing.Size(812, 549);
            this.tabPane1.SelectedPage = this.tabNavigationPage1;
            this.tabPane1.Size = new System.Drawing.Size(812, 549);
            this.tabPane1.TabIndex = 0;
            this.tabPane1.Text = "tabPane1";
            this.tabPane1.Click += new System.EventHandler(this.tabPane1_Click);
            // 
            // gridView3
            // 
            this.gridView3.Name = "gridView3";
            // 
            // usersToRolesTableAdapter
            // 
            this.usersToRolesTableAdapter.ClearBeforeFill = true;
            // 
            // Roles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 549);
            this.ControlBox = false;
            this.Controls.Add(this.tabPane1);
            this.Name = "Roles";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "الادوار الوظيفية والاسناد";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormRole_Load);
            this.tabNavigationPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UserGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoleGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoleGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.tabNavigationPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        private DevExpress.XtraGrid.GridControl UserGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView UserGridView;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton Edit_PassWord_Btn;
        private DevExpress.XtraEditors.SimpleButton Edit_User_Btn;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton Add_User_Btn;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl RoleGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Views.Grid.GridView RoleGridView;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton Edit_Role_Btn;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton Add_Role;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private ControlSecurityDataSetTableAdapters.UsersToRolesTableAdapter usersToRolesTableAdapter;

    }
}