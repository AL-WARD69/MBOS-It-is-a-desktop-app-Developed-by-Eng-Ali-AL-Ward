namespace MBOS_Full_System
{
    partial class main
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
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition4 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition5 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition6 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition3 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition4 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableSpan tableSpan2 = new DevExpress.XtraEditors.TableLayout.TableSpan();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement5 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement6 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement7 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement8 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            this.colمنذ = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colبوسطة = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colاسمالمهمة = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colالتعليق = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lastComment = new DevExpress.XtraGrid.GridControl();
            this.tileView1 = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.lastFourCommentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mBOSDataSet1 = new MBOS_Full_System.MBOSDataSet1();
            this.tasksUnLimited = new DevExpress.XtraGrid.GridControl();
            this.tileView2 = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lastFourCommentTableAdapter = new MBOS_Full_System.MBOSDataSet1TableAdapters.LastFourCommentTableAdapter();
            this.lastFourCommentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.lastComment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastFourCommentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mBOSDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksUnLimited)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastFourCommentBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // colمنذ
            // 
            this.colمنذ.Caption = "منذ";
            this.colمنذ.FieldName = "منذ";
            this.colمنذ.MinWidth = 21;
            this.colمنذ.Name = "colمنذ";
            this.colمنذ.OptionsColumn.ShowCaption = true;
            this.colمنذ.Visible = true;
            this.colمنذ.VisibleIndex = 0;
            this.colمنذ.Width = 81;
            // 
            // colبوسطة
            // 
            this.colبوسطة.AppearanceHeader.Options.UseTextOptions = true;
            this.colبوسطة.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colبوسطة.FieldName = "بوسطة";
            this.colبوسطة.MinWidth = 21;
            this.colبوسطة.Name = "colبوسطة";
            this.colبوسطة.OptionsColumn.ShowCaption = true;
            this.colبوسطة.OptionsEditForm.Caption = "بوسطة";
            this.colبوسطة.Visible = true;
            this.colبوسطة.VisibleIndex = 2;
            this.colبوسطة.Width = 81;
            // 
            // colاسمالمهمة
            // 
            this.colاسمالمهمة.Caption = "على ";
            this.colاسمالمهمة.FieldName = "اسم المهمة";
            this.colاسمالمهمة.MinWidth = 21;
            this.colاسمالمهمة.Name = "colاسمالمهمة";
            this.colاسمالمهمة.OptionsColumn.ShowCaption = true;
            this.colاسمالمهمة.Visible = true;
            this.colاسمالمهمة.VisibleIndex = 3;
            this.colاسمالمهمة.Width = 81;
            // 
            // colالتعليق
            // 
            this.colالتعليق.FieldName = "التعليق";
            this.colالتعليق.ImageOptions.Alignment = System.Drawing.StringAlignment.Center;
            this.colالتعليق.MinWidth = 21;
            this.colالتعليق.Name = "colالتعليق";
            this.colالتعليق.Visible = true;
            this.colالتعليق.VisibleIndex = 1;
            this.colالتعليق.Width = 81;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.labelControl1.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleRight;
            this.labelControl1.ImageOptions.Image = global::MBOS_Full_System.Properties.Resources.icons8_Communication;
            this.labelControl1.Location = new System.Drawing.Point(42, 154);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(194, 36);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "احدث التعليقات عن المهام";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(556, 150);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(102, 16);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "مهام غير منتهية ";
            // 
            // lastComment
            // 
            this.lastComment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lastComment.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastComment.Location = new System.Drawing.Point(42, 189);
            this.lastComment.LookAndFeel.UseDefaultLookAndFeel = false;
            this.lastComment.MainView = this.tileView1;
            this.lastComment.Name = "lastComment";
            this.lastComment.Size = new System.Drawing.Size(423, 484);
            this.lastComment.TabIndex = 5;
            this.lastComment.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tileView1});
            this.lastComment.Click += new System.EventHandler(this.lastComment_Click);
            // 
            // tileView1
            // 
            this.tileView1.Appearance.ItemNormal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tileView1.Appearance.ItemNormal.Options.UseBorderColor = true;
            this.tileView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.tileView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colمنذ,
            this.colالتعليق,
            this.colبوسطة,
            this.colاسمالمهمة});
            this.tileView1.GridControl = this.lastComment;
            this.tileView1.Name = "tileView1";
            this.tileView1.OptionsBehavior.AllowSmoothScrolling = true;
            this.tileView1.OptionsTiles.GroupTextPadding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.tileView1.OptionsTiles.IndentBetweenGroups = 0;
            this.tileView1.OptionsTiles.IndentBetweenItems = 9;
            this.tileView1.OptionsTiles.ItemSize = new System.Drawing.Size(350, 120);
            this.tileView1.OptionsTiles.LayoutMode = DevExpress.XtraGrid.Views.Tile.TileViewLayoutMode.List;
            this.tileView1.OptionsTiles.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tileView1.OptionsTiles.Padding = new System.Windows.Forms.Padding(0);
            this.tileView1.OptionsTiles.RowCount = 0;
            tableColumnDefinition4.Length.Value = 138D;
            tableColumnDefinition5.Length.Value = 83D;
            tableColumnDefinition6.Length.Value = 111D;
            this.tileView1.TileColumns.Add(tableColumnDefinition4);
            this.tileView1.TileColumns.Add(tableColumnDefinition5);
            this.tileView1.TileColumns.Add(tableColumnDefinition6);
            this.tileView1.TileRows.Add(tableRowDefinition3);
            this.tileView1.TileRows.Add(tableRowDefinition4);
            tableSpan2.ColumnSpan = 3;
            tableSpan2.RowIndex = 1;
            this.tileView1.TileSpans.Add(tableSpan2);
            tileViewItemElement5.Column = this.colمنذ;
            tileViewItemElement5.ColumnIndex = 1;
            tileViewItemElement5.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement5.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement5.Text = "colمنذ";
            tileViewItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileViewItemElement6.Appearance.Normal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            tileViewItemElement6.Appearance.Normal.Options.UseForeColor = true;
            tileViewItemElement6.Column = this.colبوسطة;
            tileViewItemElement6.ColumnIndex = 2;
            tileViewItemElement6.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement6.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement6.Text = "colبواسطة";
            tileViewItemElement6.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileViewItemElement7.Appearance.Normal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            tileViewItemElement7.Appearance.Normal.Options.UseForeColor = true;
            tileViewItemElement7.Column = this.colاسمالمهمة;
            tileViewItemElement7.Text = "colاسمالمهمة";
            tileViewItemElement7.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileViewItemElement8.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileViewItemElement8.Appearance.Normal.ForeColor = System.Drawing.Color.Black;
            tileViewItemElement8.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement8.Appearance.Normal.Options.UseForeColor = true;
            tileViewItemElement8.Column = this.colالتعليق;
            tileViewItemElement8.ColumnIndex = 2;
            tileViewItemElement8.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement8.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement8.RowIndex = 1;
            tileViewItemElement8.Text = "colالتعليق";
            tileViewItemElement8.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            this.tileView1.TileTemplate.Add(tileViewItemElement5);
            this.tileView1.TileTemplate.Add(tileViewItemElement6);
            this.tileView1.TileTemplate.Add(tileViewItemElement7);
            this.tileView1.TileTemplate.Add(tileViewItemElement8);
            this.tileView1.ViewCaption = "احدث التعليقات";
            // 
            // lastFourCommentBindingSource
            // 
            this.lastFourCommentBindingSource.DataMember = "LastFourComment";
            this.lastFourCommentBindingSource.DataSource = this.mBOSDataSet1;
            // 
            // mBOSDataSet1
            // 
            this.mBOSDataSet1.DataSetName = "MBOSDataSet1";
            this.mBOSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tasksUnLimited
            // 
            this.tasksUnLimited.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tasksUnLimited.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tasksUnLimited.Location = new System.Drawing.Point(556, 173);
            this.tasksUnLimited.LookAndFeel.UseDefaultLookAndFeel = false;
            this.tasksUnLimited.MainView = this.tileView2;
            this.tasksUnLimited.Name = "tasksUnLimited";
            this.tasksUnLimited.Size = new System.Drawing.Size(493, 295);
            this.tasksUnLimited.TabIndex = 6;
            this.tasksUnLimited.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tileView2});
            // 
            // tileView2
            // 
            this.tileView2.GridControl = this.tasksUnLimited;
            this.tileView2.Name = "tileView2";
            this.tileView2.OptionsTiles.GroupTextPadding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.tileView2.OptionsTiles.IndentBetweenGroups = 0;
            this.tileView2.OptionsTiles.IndentBetweenItems = 0;
            this.tileView2.OptionsTiles.LayoutMode = DevExpress.XtraGrid.Views.Tile.TileViewLayoutMode.List;
            this.tileView2.OptionsTiles.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tileView2.OptionsTiles.Padding = new System.Windows.Forms.Padding(0);
            this.tileView2.OptionsTiles.RowCount = 0;
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.pictureEdit1);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.LookAndFeel.SkinName = "Office 2016 Colorful";
            this.panelControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1077, 116);
            this.panelControl1.TabIndex = 7;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(395, 73);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(163, 17);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "الادارة العامة للتخطيط والمشاريع";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::MBOS_Full_System.Properties.Resources.index;
            this.pictureEdit1.Location = new System.Drawing.Point(601, 10);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.LookAndFeel.SkinName = "Office 2016 Colorful";
            this.pictureEdit1.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.pictureEdit1.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(181, 96);
            this.pictureEdit1.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(397, 22);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(161, 22);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "الموسسة العامة للاتصالات";
            // 
            // lastFourCommentTableAdapter
            // 
            this.lastFourCommentTableAdapter.ClearBeforeFill = true;
            // 
            // lastFourCommentBindingSource1
            // 
            this.lastFourCommentBindingSource1.DataMember = "LastFourComment";
            // 
            // main
            // 
            this.AccessibleDescription = "r";
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 609);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.tasksUnLimited);
            this.Controls.Add(this.lastComment);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.LookAndFeel.SkinName = "Office 2016 Colorful";
            this.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lastComment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastFourCommentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mBOSDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksUnLimited)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastFourCommentBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.GridControl lastComment;
        private DevExpress.XtraGrid.GridControl tasksUnLimited;
        private DevExpress.XtraGrid.Views.Tile.TileView tileView2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.Views.Tile.TileView tileView1;
        private MBOSDataSet1 mBOSDataSet1;
        private System.Windows.Forms.BindingSource lastFourCommentBindingSource;
        private MBOSDataSet1TableAdapters.LastFourCommentTableAdapter lastFourCommentTableAdapter;
        private DevExpress.XtraGrid.Columns.TileViewColumn colمنذ;
        private DevExpress.XtraGrid.Columns.TileViewColumn colالتعليق;
        private DevExpress.XtraGrid.Columns.TileViewColumn colبوسطة;
        private DevExpress.XtraGrid.Columns.TileViewColumn colاسمالمهمة;
     //   private MBOSDataSet2 mBOSDataSet2;
        private System.Windows.Forms.BindingSource lastFourCommentBindingSource1;
       // private MBOSDataSet2TableAdapters.LastFourCommentTableAdapter lastFourCommentTableAdapter1;
    }
}