namespace MBOS_Full_System
{
    partial class AddRole
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddRole));
            this.mBOSDataSet = new MBOS_Full_System.MBOSDataSet();
            this.RoleName = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.SaveUserBtn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.mBOSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoleName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mBOSDataSet
            // 
            this.mBOSDataSet.DataSetName = "MBOSDataSet";
            this.mBOSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RoleName
            // 
            this.RoleName.Location = new System.Drawing.Point(148, 40);
            this.RoleName.Name = "RoleName";
            this.RoleName.Properties.Appearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.RoleName.Properties.Appearance.Options.UseBorderColor = true;
            this.RoleName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.RoleName.Size = new System.Drawing.Size(156, 20);
            this.RoleName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(98)))), ((int)(((byte)(112)))));
            this.label1.Location = new System.Drawing.Point(18, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "اسم الدور الوظيفي";
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
            this.simpleButton2.Location = new System.Drawing.Point(229, 95);
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
            this.SaveUserBtn.Location = new System.Drawing.Point(148, 95);
            this.SaveUserBtn.LookAndFeel.SkinName = "Office 2013";
            this.SaveUserBtn.LookAndFeel.UseDefaultLookAndFeel = false;
            this.SaveUserBtn.Name = "SaveUserBtn";
            this.SaveUserBtn.Size = new System.Drawing.Size(75, 25);
            this.SaveUserBtn.TabIndex = 50;
            this.SaveUserBtn.Text = "حفظ";
            this.SaveUserBtn.Click += new System.EventHandler(this.SaveUserBtn_Click);
            // 
            // AddRole
            // 
            this.Appearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.Appearance.Options.UseBorderColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 157);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.SaveUserBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RoleName);
            this.Font = new System.Drawing.Font("Traditional Arabic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LookAndFeel.SkinName = "Office 2013";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddRole";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "اضافة دور وظيفي";
            ((System.ComponentModel.ISupportInitialize)(this.mBOSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoleName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlSecurityDataSet controlSecurityDataSet;
        private ControlSecurityDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private ControlSecurityDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private MBOSDataSet mBOSDataSet;
        private DevExpress.XtraEditors.TextEdit RoleName;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton SaveUserBtn;
    }
}