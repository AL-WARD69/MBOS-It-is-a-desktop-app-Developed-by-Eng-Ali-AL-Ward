namespace MBOS_Full_System
{
    partial class SetUpAdmin
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
            System.Windows.Forms.Label workphoneLabel;
            System.Windows.Forms.Label jobLabel;
            System.Windows.Forms.Label department_idLabel;
            System.Windows.Forms.Label label5;
            this.ConfirmPassWord = new DevExpress.XtraEditors.TextEdit();
            this.PassWord = new DevExpress.XtraEditors.TextEdit();
            this.JopID = new DevExpress.XtraEditors.TextEdit();
            this.UserName = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Phone = new DevExpress.XtraEditors.TextEdit();
            this.JopName = new DevExpress.XtraEditors.TextEdit();
            this.activeCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.Save = new DevExpress.XtraEditors.SimpleButton();
            this.Dept = new System.Windows.Forms.ComboBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            workphoneLabel = new System.Windows.Forms.Label();
            jobLabel = new System.Windows.Forms.Label();
            department_idLabel = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ConfirmPassWord.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassWord.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JopID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Phone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JopName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activeCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConfirmPassWord
            // 
            this.ConfirmPassWord.Location = new System.Drawing.Point(353, 91);
            this.ConfirmPassWord.Name = "ConfirmPassWord";
            this.ConfirmPassWord.Size = new System.Drawing.Size(117, 20);
            this.ConfirmPassWord.TabIndex = 0;
            // 
            // PassWord
            // 
            this.PassWord.Location = new System.Drawing.Point(104, 91);
            this.PassWord.Name = "PassWord";
            this.PassWord.Size = new System.Drawing.Size(130, 20);
            this.PassWord.TabIndex = 0;
            this.PassWord.EditValueChanged += new System.EventHandler(this.PassWord_EditValueChanged);
            // 
            // JopID
            // 
            this.JopID.Location = new System.Drawing.Point(353, 36);
            this.JopID.Name = "JopID";
            this.JopID.Properties.Mask.EditMask = "n0";
            this.JopID.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.JopID.Size = new System.Drawing.Size(117, 20);
            this.JopID.TabIndex = 0;
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(104, 36);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(130, 20);
            this.UserName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "اسم المستخدم";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "الرقم الوظيفي";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "كلمة المرور";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(264, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "تاكيد كلمة المرور";
            // 
            // workphoneLabel
            // 
            workphoneLabel.AutoSize = true;
            workphoneLabel.Location = new System.Drawing.Point(16, 196);
            workphoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            workphoneLabel.Name = "workphoneLabel";
            workphoneLabel.Size = new System.Drawing.Size(59, 13);
            workphoneLabel.TabIndex = 23;
            workphoneLabel.Text = "رقم التلفون";
            // 
            // Phone
            // 
            this.Phone.Location = new System.Drawing.Point(107, 193);
            this.Phone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(127, 20);
            this.Phone.TabIndex = 24;
            // 
            // jobLabel
            // 
            jobLabel.AutoSize = true;
            jobLabel.Location = new System.Drawing.Point(265, 151);
            jobLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            jobLabel.Name = "jobLabel";
            jobLabel.Size = new System.Drawing.Size(41, 13);
            jobLabel.TabIndex = 21;
            jobLabel.Text = "الوظيفه";
            // 
            // JopName
            // 
            this.JopName.Location = new System.Drawing.Point(353, 149);
            this.JopName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.JopName.Name = "JopName";
            this.JopName.Size = new System.Drawing.Size(117, 20);
            this.JopName.TabIndex = 22;
            // 
            // department_idLabel
            // 
            department_idLabel.AutoSize = true;
            department_idLabel.Location = new System.Drawing.Point(16, 146);
            department_idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            department_idLabel.Name = "department_idLabel";
            department_idLabel.Size = new System.Drawing.Size(70, 13);
            department_idLabel.TabIndex = 19;
            department_idLabel.Text = "الادارة/القسم";
            // 
            // activeCheckEdit
            // 
            this.activeCheckEdit.Location = new System.Drawing.Point(267, 193);
            this.activeCheckEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.activeCheckEdit.Name = "activeCheckEdit";
            this.activeCheckEdit.Properties.Caption = "فعال";
            this.activeCheckEdit.Size = new System.Drawing.Size(100, 19);
            this.activeCheckEdit.TabIndex = 18;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(335, 382);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(122, 23);
            this.Save.TabIndex = 25;
            this.Save.Text = "حفظ";
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Dept
            // 
            this.Dept.FormattingEnabled = true;
            this.Dept.Location = new System.Drawing.Point(104, 149);
            this.Dept.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Dept.Name = "Dept";
            this.Dept.Size = new System.Drawing.Size(130, 21);
            this.Dept.TabIndex = 26;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Enabled = false;
            this.checkBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.checkBox3.Location = new System.Drawing.Point(215, 90);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(132, 17);
            this.checkBox3.TabIndex = 29;
            this.checkBox3.Text = "يوجد احرف بحالة صغيرة";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Enabled = false;
            this.checkBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.checkBox2.Location = new System.Drawing.Point(221, 67);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(126, 17);
            this.checkBox2.TabIndex = 30;
            this.checkBox2.Text = "يوجد احرف بحالة كبيرة";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.checkBox1.Location = new System.Drawing.Point(242, 44);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(105, 17);
            this.checkBox1.TabIndex = 31;
            this.checkBox1.Text = "تحتوي على ارقام";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.checkBox2);
            this.panelControl1.Controls.Add(this.checkBox3);
            this.panelControl1.Controls.Add(this.checkBox1);
            this.panelControl1.Controls.Add(label5);
            this.panelControl1.Location = new System.Drawing.Point(104, 233);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(366, 116);
            this.panelControl1.TabIndex = 32;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(170, 16);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(180, 13);
            label5.TabIndex = 23;
            label5.Text = "التحقق من مستوى تعقيد كلمة المرور";
            // 
            // SetUpAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 442);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.Dept);
            this.Controls.Add(this.Save);
            this.Controls.Add(workphoneLabel);
            this.Controls.Add(this.Phone);
            this.Controls.Add(jobLabel);
            this.Controls.Add(this.JopName);
            this.Controls.Add(department_idLabel);
            this.Controls.Add(this.activeCheckEdit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.PassWord);
            this.Controls.Add(this.JopID);
            this.Controls.Add(this.ConfirmPassWord);
            this.LookAndFeel.SkinName = "Office 2016 Colorful";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "SetUpAdmin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "تهيئة حساب الادمن";
            this.Load += new System.EventHandler(this.SetUpAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ConfirmPassWord.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassWord.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JopID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Phone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JopName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activeCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit ConfirmPassWord;
        private DevExpress.XtraEditors.TextEdit PassWord;
        private DevExpress.XtraEditors.TextEdit JopID;
        private DevExpress.XtraEditors.TextEdit UserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit Phone;
        private DevExpress.XtraEditors.TextEdit JopName;
        private DevExpress.XtraEditors.CheckEdit activeCheckEdit;
        private DevExpress.XtraEditors.SimpleButton Save;
        private System.Windows.Forms.ComboBox Dept;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
    }
}