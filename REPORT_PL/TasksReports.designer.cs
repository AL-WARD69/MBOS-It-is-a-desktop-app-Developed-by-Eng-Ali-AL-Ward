namespace MBOS_Full_System.REPORT_PL
{
    partial class TasksReports
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.checkPirode = new DevExpress.XtraEditors.CheckEdit();
            this.dateEdit2 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.combReportDetail = new System.Windows.Forms.ComboBox();
            this.lblRepotDetail = new DevExpress.XtraEditors.LabelControl();
            this.combReportType = new System.Windows.Forms.ComboBox();
            this.lblReportType = new DevExpress.XtraEditors.LabelControl();
            this.btnReportTasks = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkPirode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.White;
            this.groupControl1.AppearanceCaption.Options.UseBackColor = true;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl1.Controls.Add(this.panelControl1);
            this.groupControl1.Controls.Add(this.combReportDetail);
            this.groupControl1.Controls.Add(this.lblRepotDetail);
            this.groupControl1.Controls.Add(this.combReportType);
            this.groupControl1.Controls.Add(this.lblReportType);
            this.groupControl1.Controls.Add(this.btnReportTasks);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.LookAndFeel.SkinName = "Office 2013 Light Gray";
            this.groupControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.groupControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(453, 295);
            this.groupControl1.TabIndex = 14;
            this.groupControl1.Text = "تقرير عن المهام";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.checkPirode);
            this.panelControl1.Controls.Add(this.dateEdit2);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.dateEdit1);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Location = new System.Drawing.Point(25, 115);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(395, 117);
            this.panelControl1.TabIndex = 24;
            // 
            // checkPirode
            // 
            this.checkPirode.Location = new System.Drawing.Point(149, 13);
            this.checkPirode.Name = "checkPirode";
            this.checkPirode.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkPirode.Properties.Appearance.Options.UseFont = true;
            this.checkPirode.Properties.Caption = "تحديد الفترة";
            this.checkPirode.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.checkPirode.Size = new System.Drawing.Size(238, 20);
            this.checkPirode.TabIndex = 19;
            this.checkPirode.CheckedChanged += new System.EventHandler(this.checkPirode_CheckedChanged);
            // 
            // dateEdit2
            // 
            this.dateEdit2.EditValue = null;
            this.dateEdit2.Enabled = false;
            this.dateEdit2.Location = new System.Drawing.Point(5, 61);
            this.dateEdit2.Name = "dateEdit2";
            this.dateEdit2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEdit2.Properties.Appearance.Options.UseFont = true;
            this.dateEdit2.Properties.AutoHeight = false;
            this.dateEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Properties.LookAndFeel.SkinName = "Office 2013 Light Gray";
            this.dateEdit2.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.dateEdit2.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.dateEdit2.Size = new System.Drawing.Size(184, 30);
            this.dateEdit2.TabIndex = 23;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(126, 39);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(63, 16);
            this.labelControl2.TabIndex = 22;
            this.labelControl2.Text = "إلى تاريخ :";
            this.labelControl2.Visible = false;
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Enabled = false;
            this.dateEdit1.Location = new System.Drawing.Point(208, 61);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEdit1.Properties.Appearance.Options.UseFont = true;
            this.dateEdit1.Properties.AutoHeight = false;
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.LookAndFeel.SkinName = "Office 2013 Light Gray";
            this.dateEdit1.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.dateEdit1.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.dateEdit1.Size = new System.Drawing.Size(179, 30);
            this.dateEdit1.TabIndex = 21;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.LineVisible = true;
            this.labelControl1.Location = new System.Drawing.Point(327, 39);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 16);
            this.labelControl1.TabIndex = 20;
            this.labelControl1.Text = "من تاريخ :";
            this.labelControl1.UseMnemonic = false;
            this.labelControl1.Visible = false;
            // 
            // combReportDetail
            // 
            this.combReportDetail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combReportDetail.Enabled = false;
            this.combReportDetail.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combReportDetail.FormattingEnabled = true;
            this.combReportDetail.Location = new System.Drawing.Point(25, 67);
            this.combReportDetail.MaxDropDownItems = 100;
            this.combReportDetail.Name = "combReportDetail";
            this.combReportDetail.Size = new System.Drawing.Size(189, 27);
            this.combReportDetail.TabIndex = 19;
            // 
            // lblRepotDetail
            // 
            this.lblRepotDetail.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepotDetail.Appearance.Options.UseFont = true;
            this.lblRepotDetail.Location = new System.Drawing.Point(147, 45);
            this.lblRepotDetail.LookAndFeel.SkinName = "Office 2013 Light Gray";
            this.lblRepotDetail.LookAndFeel.UseDefaultLookAndFeel = false;
            this.lblRepotDetail.Name = "lblRepotDetail";
            this.lblRepotDetail.Size = new System.Drawing.Size(38, 16);
            this.lblRepotDetail.TabIndex = 18;
            this.lblRepotDetail.Text = "المهام";
            this.lblRepotDetail.Visible = false;
            // 
            // combReportType
            // 
            this.combReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combReportType.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combReportType.FormattingEnabled = true;
            this.combReportType.Location = new System.Drawing.Point(241, 67);
            this.combReportType.MaxDropDownItems = 100;
            this.combReportType.Name = "combReportType";
            this.combReportType.Size = new System.Drawing.Size(179, 27);
            this.combReportType.TabIndex = 17;
            this.combReportType.SelectedIndexChanged += new System.EventHandler(this.combReportType_SelectedIndexChanged);
            // 
            // lblReportType
            // 
            this.lblReportType.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportType.Appearance.Options.UseFont = true;
            this.lblReportType.Location = new System.Drawing.Point(294, 45);
            this.lblReportType.Name = "lblReportType";
            this.lblReportType.Size = new System.Drawing.Size(126, 16);
            this.lblReportType.TabIndex = 16;
            this.lblReportType.Text = "تقرير المهام بحسب :";
            // 
            // btnReportTasks
            // 
            this.btnReportTasks.Appearance.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnReportTasks.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportTasks.Appearance.Options.UseBackColor = true;
            this.btnReportTasks.Appearance.Options.UseFont = true;
            this.btnReportTasks.AppearanceHovered.BackColor = System.Drawing.Color.LightSalmon;
            this.btnReportTasks.AppearanceHovered.Options.UseBackColor = true;
            this.btnReportTasks.Location = new System.Drawing.Point(25, 248);
            this.btnReportTasks.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.btnReportTasks.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnReportTasks.Name = "btnReportTasks";
            this.btnReportTasks.Size = new System.Drawing.Size(131, 33);
            this.btnReportTasks.TabIndex = 12;
            this.btnReportTasks.Text = "تقرير";
            this.btnReportTasks.Click += new System.EventHandler(this.btnReportTasks_Click);
            // 
            // TasksReports
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 295);
            this.Controls.Add(this.groupControl1);
            this.LookAndFeel.SkinName = "Office 2013 Light Gray";
            this.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TasksReports";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.Text = "TasksReports";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkPirode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.CheckEdit checkPirode;
        private DevExpress.XtraEditors.DateEdit dateEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ComboBox combReportDetail;
        private DevExpress.XtraEditors.LabelControl lblRepotDetail;
        private System.Windows.Forms.ComboBox combReportType;
        private DevExpress.XtraEditors.LabelControl lblReportType;
        private DevExpress.XtraEditors.SimpleButton btnReportTasks;
    }
}