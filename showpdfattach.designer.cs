namespace MBOS_Full_System
{
    partial class showpdfattach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(showpdfattach));
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.label_attachttille = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton_saveattachment = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            this.SuspendLayout();
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(12, 63);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(674, 633);
            this.axAcroPDF1.TabIndex = 49;
            // 
            // label_attachttille
            // 
            this.label_attachttille.Location = new System.Drawing.Point(25, 24);
            this.label_attachttille.Name = "label_attachttille";
            this.label_attachttille.Size = new System.Drawing.Size(79, 17);
            this.label_attachttille.TabIndex = 50;
            this.label_attachttille.Text = "labelControl1";
            // 
            // simpleButton_saveattachment
            // 
            this.simpleButton_saveattachment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton_saveattachment.Appearance.BackColor = System.Drawing.Color.DarkOrchid;
            this.simpleButton_saveattachment.Appearance.BorderColor = System.Drawing.Color.DarkOrchid;
            this.simpleButton_saveattachment.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton_saveattachment.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton_saveattachment.Appearance.Options.UseBackColor = true;
            this.simpleButton_saveattachment.Appearance.Options.UseBorderColor = true;
            this.simpleButton_saveattachment.Appearance.Options.UseFont = true;
            this.simpleButton_saveattachment.Appearance.Options.UseForeColor = true;
            this.simpleButton_saveattachment.AppearanceHovered.BackColor = System.Drawing.Color.MediumOrchid;
            this.simpleButton_saveattachment.AppearanceHovered.Options.UseBackColor = true;
            this.simpleButton_saveattachment.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.simpleButton_saveattachment.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton_saveattachment.ImageOptions.Image")));
            this.simpleButton_saveattachment.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.simpleButton_saveattachment.ImageOptions.ImageToTextIndent = 5;
            this.simpleButton_saveattachment.Location = new System.Drawing.Point(564, 13);
            this.simpleButton_saveattachment.LookAndFeel.SkinName = "Office 2013 Light Gray";
            this.simpleButton_saveattachment.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.simpleButton_saveattachment.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButton_saveattachment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.simpleButton_saveattachment.Name = "simpleButton_saveattachment";
            this.simpleButton_saveattachment.Size = new System.Drawing.Size(122, 43);
            this.simpleButton_saveattachment.TabIndex = 51;
            this.simpleButton_saveattachment.Text = "حفظ المرفق ";
            this.simpleButton_saveattachment.Click += new System.EventHandler(this.simpleButton_saveattachment_Click);
            // 
            // showpdfattach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(698, 708);
            this.Controls.Add(this.simpleButton_saveattachment);
            this.Controls.Add(this.label_attachttille);
            this.Controls.Add(this.axAcroPDF1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.MaximizeBox = false;
            this.Name = "showpdfattach";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "عرض المرفقات ";
            this.Load += new System.EventHandler(this.showpdfattach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
        private DevExpress.XtraEditors.LabelControl label_attachttille;
        private DevExpress.XtraEditors.SimpleButton simpleButton_saveattachment;
    }
}