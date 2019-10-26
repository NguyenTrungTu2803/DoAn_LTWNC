namespace control_user_pass
{
    partial class update_delete_insert
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(update_delete_insert));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.imgicon = new System.Windows.Forms.ImageList();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5);
            this.gridControl1.Location = new System.Drawing.Point(5, 5);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(5);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(860, 367);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // btnThem
            // 
            this.btnThem.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.ImageOptions.ImageIndex = 2;
            this.btnThem.ImageOptions.ImageList = this.imgicon;
            this.btnThem.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnThem.Location = new System.Drawing.Point(5, 414);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(119, 43);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // imgicon
            // 
            this.imgicon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgicon.ImageStream")));
            this.imgicon.TransparentColor = System.Drawing.Color.Transparent;
            this.imgicon.Images.SetKeyName(0, "Cance_icon.png");
            this.imgicon.Images.SetKeyName(1, "delete_icon.png");
            this.imgicon.Images.SetKeyName(2, "plus_icon.png");
            this.imgicon.Images.SetKeyName(3, "luu_icon.png");
            this.imgicon.Images.SetKeyName(4, "repair_icon.png");
            this.imgicon.Images.SetKeyName(5, "repair-icon-png-1.jpg");
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.ImageOptions.ImageIndex = 1;
            this.btnXoa.ImageOptions.ImageList = this.imgicon;
            this.btnXoa.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnXoa.Location = new System.Drawing.Point(188, 414);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(119, 43);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.ImageOptions.ImageIndex = 0;
            this.btnHuy.ImageOptions.ImageList = this.imgicon;
            this.btnHuy.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnHuy.Location = new System.Drawing.Point(737, 414);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(119, 43);
            this.btnHuy.TabIndex = 5;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.ImageOptions.ImageIndex = 3;
            this.btnLuu.ImageOptions.ImageList = this.imgicon;
            this.btnLuu.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnLuu.Location = new System.Drawing.Point(554, 414);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(119, 43);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "Lưu";
            // 
            // btnSua
            // 
            this.btnSua.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.btnSua.Appearance.Options.UseFont = true;
            this.btnSua.ImageOptions.ImageIndex = 5;
            this.btnSua.ImageOptions.ImageList = this.imgicon;
            this.btnSua.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnSua.Location = new System.Drawing.Point(371, 414);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(119, 43);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // update_delete_insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.gridControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "update_delete_insert";
            this.Size = new System.Drawing.Size(868, 526);
            this.Load += new System.EventHandler(this.update_delete_insert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private System.Windows.Forms.ImageList imgicon;
    }
}
