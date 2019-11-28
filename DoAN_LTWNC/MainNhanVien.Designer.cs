namespace DoAn_LTWNC
{
    partial class MainNhanVien
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
            this.controlnhanvien1 = new MainFr.controlnhanvien();
            this.SuspendLayout();
            // 
            // controlnhanvien1
            // 
            this.controlnhanvien1.Location = new System.Drawing.Point(-2, 12);
            this.controlnhanvien1.Name = "controlnhanvien1";
            this.controlnhanvien1.Size = new System.Drawing.Size(1487, 558);
            this.controlnhanvien1.TabIndex = 0;
            // 
            // MainNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1527, 590);
            this.Controls.Add(this.controlnhanvien1);
            this.Name = "MainNhanVien";
            this.Text = "MainNhanVien";
            this.ResumeLayout(false);

        }

        #endregion

        private MainFr.controlnhanvien controlnhanvien1;


    }
}