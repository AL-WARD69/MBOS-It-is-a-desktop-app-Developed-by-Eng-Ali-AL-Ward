namespace MBOS_Full_System
{
    partial class Departments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Departments));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.dept_tree_list = new DevExpress.XtraTreeList.TreeList();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.update_dept = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.add_dept_btn = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dept_tree_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dept_tree_list
            // 
            this.dept_tree_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dept_tree_list.Location = new System.Drawing.Point(3, 89);
            this.dept_tree_list.Name = "dept_tree_list";
            this.dept_tree_list.Size = new System.Drawing.Size(885, 335);
            this.dept_tree_list.TabIndex = 10;
            this.dept_tree_list.RowClick += new DevExpress.XtraTreeList.RowClickEventHandler(this.dept_tree_list_RowClick);
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(98)))), ((int)(((byte)(112)))));
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.update_dept);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.add_dept_btn);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.panelControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(888, 83);
            this.panelControl1.TabIndex = 9;
            // 
            // update_dept
            // 
            this.update_dept.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.False;
            this.update_dept.Appearance.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.update_dept.Appearance.BackColor2 = System.Drawing.Color.MediumSeaGreen;
            this.update_dept.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.update_dept.Appearance.ForeColor = System.Drawing.Color.White;
            this.update_dept.Appearance.Options.UseBackColor = true;
            this.update_dept.Appearance.Options.UseFont = true;
            this.update_dept.Appearance.Options.UseForeColor = true;
            this.update_dept.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.update_dept.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("update_dept.ImageOptions.Image")));
            this.update_dept.Location = new System.Drawing.Point(102, 31);
            this.update_dept.LookAndFeel.UseDefaultLookAndFeel = false;
            this.update_dept.Name = "update_dept";
            this.update_dept.Size = new System.Drawing.Size(74, 25);
            this.update_dept.TabIndex = 3;
            this.update_dept.Text = "تعديل";
            this.update_dept.Click += new System.EventHandler(this.update_dept_Click);
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
            this.labelControl2.Location = new System.Drawing.Point(267, 55);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(603, 14);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "قائمة بالأقسام الرئيسية و الفرعية الموجوده فى كل فروع المؤسسة";
            // 
            // add_dept_btn
            // 
            this.add_dept_btn.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.False;
            this.add_dept_btn.Appearance.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.add_dept_btn.Appearance.BackColor2 = System.Drawing.Color.MediumSeaGreen;
            this.add_dept_btn.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.add_dept_btn.Appearance.ForeColor = System.Drawing.Color.White;
            this.add_dept_btn.Appearance.Options.UseBackColor = true;
            this.add_dept_btn.Appearance.Options.UseFont = true;
            this.add_dept_btn.Appearance.Options.UseForeColor = true;
            this.add_dept_btn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.add_dept_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("add_dept_btn.ImageOptions.Image")));
            this.add_dept_btn.Location = new System.Drawing.Point(23, 31);
            this.add_dept_btn.LookAndFeel.UseDefaultLookAndFeel = false;
            this.add_dept_btn.Name = "add_dept_btn";
            this.add_dept_btn.Size = new System.Drawing.Size(73, 25);
            this.add_dept_btn.TabIndex = 2;
            this.add_dept_btn.Text = "أضافة";
            this.add_dept_btn.Click += new System.EventHandler(this.add_dept_btn_Click);
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
            this.labelControl1.Location = new System.Drawing.Point(538, 21);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(332, 28);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "الأقسام";
            // 
            // Departments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 425);
            this.Controls.Add(this.dept_tree_list);
            this.Controls.Add(this.panelControl1);
            this.Name = "Departments";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "DepartmentForm";
            ((System.ComponentModel.ISupportInitialize)(this.dept_tree_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        public DevExpress.XtraTreeList.TreeList dept_tree_list;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton update_dept;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton add_dept_btn;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}