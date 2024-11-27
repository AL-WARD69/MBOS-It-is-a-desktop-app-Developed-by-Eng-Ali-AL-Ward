namespace MBOS_Full_System
{
    partial class AddDept
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDept));
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.save_dept_btn = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dept_type_radiogrp = new DevExpress.XtraEditors.RadioGroup();
            this.dept_type_cb = new System.Windows.Forms.ComboBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dept_type_radiogrp.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // separatorControl1
            // 
            this.separatorControl1.LineColor = System.Drawing.Color.DarkRed;
            this.separatorControl1.LineThickness = 1;
            this.separatorControl1.Location = new System.Drawing.Point(27, 46);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(344, 18);
            this.separatorControl1.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.labelControl2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("labelControl2.ImageOptions.Image")));
            this.labelControl2.Location = new System.Drawing.Point(27, 29);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(203, 20);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "اضافة معلومات الادارة/القسم";
            this.labelControl2.Click += new System.EventHandler(this.labelControl2_Click);
            // 
            // save_dept_btn
            // 
            this.save_dept_btn.Appearance.BackColor = System.Drawing.Color.White;
            this.save_dept_btn.Appearance.BorderColor = System.Drawing.Color.DarkViolet;
            this.save_dept_btn.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_dept_btn.Appearance.ForeColor = System.Drawing.Color.DarkViolet;
            this.save_dept_btn.Appearance.Options.UseBackColor = true;
            this.save_dept_btn.Appearance.Options.UseBorderColor = true;
            this.save_dept_btn.Appearance.Options.UseFont = true;
            this.save_dept_btn.Appearance.Options.UseForeColor = true;
            this.save_dept_btn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.save_dept_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("save_dept_btn.ImageOptions.Image")));
            this.save_dept_btn.Location = new System.Drawing.Point(182, 353);
            this.save_dept_btn.LookAndFeel.SkinName = "Office 2013 Light Gray";
            this.save_dept_btn.LookAndFeel.UseDefaultLookAndFeel = false;
            this.save_dept_btn.Name = "save_dept_btn";
            this.save_dept_btn.Size = new System.Drawing.Size(90, 30);
            this.save_dept_btn.TabIndex = 11;
            this.save_dept_btn.Text = "حفظ";
            this.save_dept_btn.Click += new System.EventHandler(this.save_dept_btn_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.White;
            this.simpleButton1.Appearance.BorderColor = System.Drawing.Color.Orange;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.Orange;
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseBorderColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.simpleButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(278, 353);
            this.simpleButton1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(90, 30);
            this.simpleButton1.TabIndex = 10;
            this.simpleButton1.Text = "الغاء";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.panelControl1.Appearance.Options.UseBorderColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.panelControl1.Controls.Add(this.textEdit2);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.textEdit1);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.dept_type_radiogrp);
            this.panelControl1.Controls.Add(this.dept_type_cb);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Location = new System.Drawing.Point(27, 64);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(344, 279);
            this.panelControl1.TabIndex = 12;
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(11, 104);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.textEdit2.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.textEdit2.Properties.AutoHeight = false;
            this.textEdit2.Properties.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.textEdit2.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.textEdit2.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.textEdit2.Properties.NullValuePrompt = "وصف مختصر للقسم";
            this.textEdit2.Properties.NullValuePromptShowForEmptyValue = true;
            this.textEdit2.Properties.ShowNullValuePromptWhenFocused = true;
            this.textEdit2.Size = new System.Drawing.Size(320, 30);
            this.textEdit2.TabIndex = 20;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(259, 73);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(72, 16);
            this.labelControl4.TabIndex = 19;
            this.labelControl4.Text = "وصف القسم ";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(11, 37);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.textEdit1.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.textEdit1.Properties.AutoHeight = false;
            this.textEdit1.Properties.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.textEdit1.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.textEdit1.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.textEdit1.Properties.NullValuePrompt = "مثال:قسم المبيعات";
            this.textEdit1.Properties.NullValuePromptShowForEmptyValue = true;
            this.textEdit1.Properties.ShowNullValuePromptWhenFocused = true;
            this.textEdit1.Size = new System.Drawing.Size(320, 30);
            this.textEdit1.TabIndex = 18;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(227, 15);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(106, 16);
            this.labelControl3.TabIndex = 17;
            this.labelControl3.Text = "اسم الادارة/القسم ";
            // 
            // dept_type_radiogrp
            // 
            this.dept_type_radiogrp.Location = new System.Drawing.Point(226, 175);
            this.dept_type_radiogrp.Name = "dept_type_radiogrp";
            this.dept_type_radiogrp.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.dept_type_radiogrp.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White;
            this.dept_type_radiogrp.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.dept_type_radiogrp.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.dept_type_radiogrp.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "رئيسي", true, "main"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "فرعي من :", true, "sub")});
            this.dept_type_radiogrp.Size = new System.Drawing.Size(81, 58);
            this.dept_type_radiogrp.TabIndex = 16;
            // 
            // dept_type_cb
            // 
            this.dept_type_cb.FormattingEnabled = true;
            this.dept_type_cb.Location = new System.Drawing.Point(11, 236);
            this.dept_type_cb.Name = "dept_type_cb";
            this.dept_type_cb.Size = new System.Drawing.Size(277, 26);
            this.dept_type_cb.TabIndex = 15;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(232, 153);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(99, 16);
            this.labelControl5.TabIndex = 14;
            this.labelControl5.Text = "نوع الادارة/القسم ";
            // 
            // addDepartment
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 390);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.save_dept_btn);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.separatorControl1);
            this.Controls.Add(this.labelControl2);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LookAndFeel.SkinName = "Office 2013";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "addDepartment";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة قسم جديد";
            this.Load += new System.EventHandler(this.addDepartment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dept_type_radiogrp.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        public DevExpress.XtraEditors.SimpleButton save_dept_btn;
        public DevExpress.XtraEditors.TextEdit textEdit2;
        public DevExpress.XtraEditors.TextEdit textEdit1;
        public DevExpress.XtraEditors.RadioGroup dept_type_radiogrp;
        public System.Windows.Forms.ComboBox dept_type_cb;
    }
}