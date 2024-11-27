namespace MBOS_Full_System
{
    partial class EditUsers
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
            System.Windows.Forms.Label department_idLabel;
            System.Windows.Forms.Label jobLabel;
            System.Windows.Forms.Label workphoneLabel;
            System.Windows.Forms.Label label6;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditUsers));
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mBOSDataSet = new MBOS_Full_System.MBOSDataSet();
            this.departmentsTableAdapter = new MBOS_Full_System.MBOSDataSetTableAdapters.departmentsTableAdapter();
            this.UserName = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.activeCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.JopName = new DevExpress.XtraEditors.TextEdit();
            this.Phone = new DevExpress.XtraEditors.TextEdit();
            this.Dept = new System.Windows.Forms.ComboBox();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.SaveUserBtn = new DevExpress.XtraEditors.SimpleButton();
            this.RolesJops = new DevExpress.XtraEditors.CheckedListBoxControl();
            department_idLabel = new System.Windows.Forms.Label();
            jobLabel = new System.Windows.Forms.Label();
            workphoneLabel = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mBOSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activeCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JopName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Phone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RolesJops)).BeginInit();
            this.SuspendLayout();
            // 
            // department_idLabel
            // 
            department_idLabel.AutoSize = true;
            department_idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            department_idLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(98)))), ((int)(((byte)(112)))));
            department_idLabel.Location = new System.Drawing.Point(281, 37);
            department_idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            department_idLabel.Name = "department_idLabel";
            department_idLabel.Size = new System.Drawing.Size(77, 13);
            department_idLabel.TabIndex = 42;
            department_idLabel.Text = "الادارة/القسم";
            // 
            // jobLabel
            // 
            jobLabel.AutoSize = true;
            jobLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            jobLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(98)))), ((int)(((byte)(112)))));
            jobLabel.Location = new System.Drawing.Point(281, 100);
            jobLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            jobLabel.Name = "jobLabel";
            jobLabel.Size = new System.Drawing.Size(47, 13);
            jobLabel.TabIndex = 43;
            jobLabel.Text = "الوظيفه";
            // 
            // workphoneLabel
            // 
            workphoneLabel.AutoSize = true;
            workphoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            workphoneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(98)))), ((int)(((byte)(112)))));
            workphoneLabel.Location = new System.Drawing.Point(26, 98);
            workphoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            workphoneLabel.Name = "workphoneLabel";
            workphoneLabel.Size = new System.Drawing.Size(68, 13);
            workphoneLabel.TabIndex = 45;
            workphoneLabel.Text = "رقم التلفون";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(98)))), ((int)(((byte)(112)))));
            label6.Location = new System.Drawing.Point(15, 151);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(90, 13);
            label6.TabIndex = 42;
            label6.Text = "الادوار الوظيفية";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            // 
            // departmentsBindingSource
            // 
            this.departmentsBindingSource.DataMember = "departments";
            this.departmentsBindingSource.DataSource = this.mBOSDataSet;
            // 
            // mBOSDataSet
            // 
            this.mBOSDataSet.DataSetName = "MBOSDataSet";
            this.mBOSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departmentsTableAdapter
            // 
            this.departmentsTableAdapter.ClearBeforeFill = true;
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(112, 36);
            this.UserName.Name = "UserName";
            this.UserName.Properties.Appearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.UserName.Properties.Appearance.Options.UseBorderColor = true;
            this.UserName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.UserName.Size = new System.Drawing.Size(145, 20);
            this.UserName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(98)))), ((int)(((byte)(112)))));
            this.label1.Location = new System.Drawing.Point(14, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "اسم المستخدم";
            // 
            // activeCheckEdit
            // 
            this.activeCheckEdit.Location = new System.Drawing.Point(368, 148);
            this.activeCheckEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.activeCheckEdit.Name = "activeCheckEdit";
            this.activeCheckEdit.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeCheckEdit.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(98)))), ((int)(((byte)(112)))));
            this.activeCheckEdit.Properties.Appearance.Options.UseFont = true;
            this.activeCheckEdit.Properties.Appearance.Options.UseForeColor = true;
            this.activeCheckEdit.Properties.Caption = "فعال";
            this.activeCheckEdit.Size = new System.Drawing.Size(100, 19);
            this.activeCheckEdit.TabIndex = 9;
            // 
            // JopName
            // 
            this.JopName.Location = new System.Drawing.Point(368, 97);
            this.JopName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.JopName.Name = "JopName";
            this.JopName.Properties.Appearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.JopName.Properties.Appearance.Options.UseBorderColor = true;
            this.JopName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.JopName.Size = new System.Drawing.Size(156, 20);
            this.JopName.TabIndex = 6;
            // 
            // Phone
            // 
            this.Phone.Location = new System.Drawing.Point(112, 97);
            this.Phone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Phone.Name = "Phone";
            this.Phone.Properties.Appearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.Phone.Properties.Appearance.Options.UseBorderColor = true;
            this.Phone.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.Phone.Properties.Mask.EditMask = "n0";
            this.Phone.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.Phone.Size = new System.Drawing.Size(145, 20);
            this.Phone.TabIndex = 7;
            // 
            // Dept
            // 
            this.Dept.FormattingEnabled = true;
            this.Dept.ItemHeight = 20;
            this.Dept.Location = new System.Drawing.Point(368, 34);
            this.Dept.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Dept.Name = "Dept";
            this.Dept.Size = new System.Drawing.Size(156, 28);
            this.Dept.TabIndex = 5;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.BackColor = System.Drawing.Color.White;
            this.simpleButton2.Appearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.simpleButton2.Appearance.ForeColor = System.Drawing.Color.DarkOrange;
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Appearance.Options.UseBorderColor = true;
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Appearance.Options.UseForeColor = true;
            this.simpleButton2.AppearanceHovered.BackColor = System.Drawing.Color.DarkOrange;
            this.simpleButton2.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 9F);
            this.simpleButton2.AppearanceHovered.ForeColor = System.Drawing.Color.White;
            this.simpleButton2.AppearanceHovered.Options.UseBackColor = true;
            this.simpleButton2.AppearanceHovered.Options.UseFont = true;
            this.simpleButton2.AppearanceHovered.Options.UseForeColor = true;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(424, 266);
            this.simpleButton2.LookAndFeel.SkinName = "Office 2013";
            this.simpleButton2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 25);
            this.simpleButton2.TabIndex = 51;
            this.simpleButton2.Text = "ألغاء";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // SaveUserBtn
            // 
            this.SaveUserBtn.Appearance.BackColor = System.Drawing.Color.White;
            this.SaveUserBtn.Appearance.BorderColor = System.Drawing.Color.BlueViolet;
            this.SaveUserBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.SaveUserBtn.Appearance.ForeColor = System.Drawing.Color.BlueViolet;
            this.SaveUserBtn.Appearance.Options.UseBackColor = true;
            this.SaveUserBtn.Appearance.Options.UseBorderColor = true;
            this.SaveUserBtn.Appearance.Options.UseFont = true;
            this.SaveUserBtn.Appearance.Options.UseForeColor = true;
            this.SaveUserBtn.AppearanceHovered.BackColor = System.Drawing.Color.BlueViolet;
            this.SaveUserBtn.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 9F);
            this.SaveUserBtn.AppearanceHovered.ForeColor = System.Drawing.Color.White;
            this.SaveUserBtn.AppearanceHovered.Options.UseBackColor = true;
            this.SaveUserBtn.AppearanceHovered.Options.UseFont = true;
            this.SaveUserBtn.AppearanceHovered.Options.UseForeColor = true;
            this.SaveUserBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SaveUserBtn.ImageOptions.Image")));
            this.SaveUserBtn.Location = new System.Drawing.Point(343, 266);
            this.SaveUserBtn.LookAndFeel.SkinName = "Office 2013";
            this.SaveUserBtn.LookAndFeel.UseDefaultLookAndFeel = false;
            this.SaveUserBtn.Name = "SaveUserBtn";
            this.SaveUserBtn.Size = new System.Drawing.Size(75, 25);
            this.SaveUserBtn.TabIndex = 50;
            this.SaveUserBtn.Text = "حفظ";
            this.SaveUserBtn.Click += new System.EventHandler(this.SaveUserBtn_Click);
            // 
            // RolesJops
            // 
            this.RolesJops.Appearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.RolesJops.Appearance.Options.UseBorderColor = true;
            this.RolesJops.Location = new System.Drawing.Point(112, 148);
            this.RolesJops.Name = "RolesJops";
            this.RolesJops.Size = new System.Drawing.Size(211, 95);
            this.RolesJops.TabIndex = 52;
            // 
            // EditUsers
            // 
            this.Appearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.Appearance.Options.UseBorderColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 309);
            this.Controls.Add(this.RolesJops);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.SaveUserBtn);
            this.Controls.Add(this.Dept);
            this.Controls.Add(workphoneLabel);
            this.Controls.Add(this.Phone);
            this.Controls.Add(jobLabel);
            this.Controls.Add(label6);
            this.Controls.Add(this.JopName);
            this.Controls.Add(department_idLabel);
            this.Controls.Add(this.activeCheckEdit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserName);
            this.Font = new System.Drawing.Font("Traditional Arabic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LookAndFeel.SkinName = "Office 2013";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EditUsers";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "تعديل بيانات المستخدم";
            this.Load += new System.EventHandler(this.FormRoles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mBOSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activeCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JopName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Phone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RolesJops)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlSecurityDataSet controlSecurityDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private ControlSecurityDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private ControlSecurityDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private MBOSDataSet mBOSDataSet;
        private System.Windows.Forms.BindingSource departmentsBindingSource;
        private MBOSDataSetTableAdapters.departmentsTableAdapter departmentsTableAdapter;
        private DevExpress.XtraEditors.TextEdit UserName;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.CheckEdit activeCheckEdit;
        private DevExpress.XtraEditors.TextEdit JopName;
        private DevExpress.XtraEditors.TextEdit Phone;
        private System.Windows.Forms.ComboBox Dept;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton SaveUserBtn;
        private DevExpress.XtraEditors.CheckedListBoxControl RolesJops;
    }
}