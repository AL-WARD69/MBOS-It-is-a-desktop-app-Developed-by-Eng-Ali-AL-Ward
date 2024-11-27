namespace MBOS_Full_System
{
    partial class EditPassWord
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
            System.Windows.Forms.Label label5;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mBOSDataSet = new MBOS_Full_System.MBOSDataSet();
            this.departmentsTableAdapter = new MBOS_Full_System.MBOSDataSetTableAdapters.departmentsTableAdapter();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.ConfirmPassWord = new DevExpress.XtraEditors.TextEdit();
            this.PassWord = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.SaveUserBtn = new DevExpress.XtraEditors.SimpleButton();
            label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mBOSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConfirmPassWord.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassWord.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(95, 19);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(180, 13);
            label5.TabIndex = 23;
            label5.Text = "التحقق من مستوى تعقيد كلمة المرور";
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
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.checkBox2);
            this.panelControl1.Controls.Add(this.checkBox3);
            this.panelControl1.Controls.Add(this.checkBox1);
            this.panelControl1.Controls.Add(label5);
            this.panelControl1.Location = new System.Drawing.Point(28, 146);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(284, 121);
            this.panelControl1.TabIndex = 49;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Enabled = false;
            this.checkBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.checkBox2.Location = new System.Drawing.Point(146, 70);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(126, 17);
            this.checkBox2.TabIndex = 30;
            this.checkBox2.Text = "يوجد احرف بحالة كبيرة";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Enabled = false;
            this.checkBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.checkBox3.Location = new System.Drawing.Point(140, 93);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(132, 17);
            this.checkBox3.TabIndex = 29;
            this.checkBox3.Text = "يوجد احرف بحالة صغيرة";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.checkBox1.Location = new System.Drawing.Point(167, 47);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(105, 17);
            this.checkBox1.TabIndex = 31;
            this.checkBox1.Text = "تحتوي على ارقام";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // ConfirmPassWord
            // 
            this.ConfirmPassWord.Location = new System.Drawing.Point(141, 95);
            this.ConfirmPassWord.Name = "ConfirmPassWord";
            this.ConfirmPassWord.Properties.Appearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.ConfirmPassWord.Properties.Appearance.Options.UseBorderColor = true;
            this.ConfirmPassWord.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.ConfirmPassWord.Properties.PasswordChar = '*';
            this.ConfirmPassWord.Size = new System.Drawing.Size(156, 20);
            this.ConfirmPassWord.TabIndex = 4;
            // 
            // PassWord
            // 
            this.PassWord.Location = new System.Drawing.Point(141, 35);
            this.PassWord.Name = "PassWord";
            this.PassWord.Properties.Appearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.PassWord.Properties.Appearance.Options.UseBorderColor = true;
            this.PassWord.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.PassWord.Properties.PasswordChar = '*';
            this.PassWord.Size = new System.Drawing.Size(156, 20);
            this.PassWord.TabIndex = 3;
            this.PassWord.EditValueChanged += new System.EventHandler(this.PassWord_EditValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(98)))), ((int)(((byte)(112)))));
            this.label3.Location = new System.Drawing.Point(25, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "كلمة المرور";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(98)))), ((int)(((byte)(112)))));
            this.label4.Location = new System.Drawing.Point(25, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "تاكيد كلمة المرور";
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
            this.simpleButton2.Location = new System.Drawing.Point(237, 286);
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
            this.SaveUserBtn.Location = new System.Drawing.Point(156, 286);
            this.SaveUserBtn.LookAndFeel.SkinName = "Office 2013";
            this.SaveUserBtn.LookAndFeel.UseDefaultLookAndFeel = false;
            this.SaveUserBtn.Name = "SaveUserBtn";
            this.SaveUserBtn.Size = new System.Drawing.Size(75, 25);
            this.SaveUserBtn.TabIndex = 50;
            this.SaveUserBtn.Text = "حفظ";
            this.SaveUserBtn.Click += new System.EventHandler(this.SaveUserBtn_Click);
            // 
            // Users
            // 
            this.Appearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.Appearance.Options.UseBorderColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 329);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.SaveUserBtn);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PassWord);
            this.Controls.Add(this.ConfirmPassWord);
            this.Font = new System.Drawing.Font("Traditional Arabic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LookAndFeel.SkinName = "Office 2013";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Users";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "تعديل كلمة المرور";
            this.Load += new System.EventHandler(this.FormRoles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mBOSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConfirmPassWord.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassWord.Properties)).EndInit();
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
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox1;
        private DevExpress.XtraEditors.TextEdit ConfirmPassWord;
        private DevExpress.XtraEditors.TextEdit PassWord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton SaveUserBtn;
    }
}