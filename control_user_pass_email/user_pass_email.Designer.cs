namespace control_user_pass_email
{
    partial class user_pass_email
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.user_pass1 = new control_user_pass.user_pass();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel2.Location = new System.Drawing.Point(12, 197);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(478, 1);
            this.panel2.TabIndex = 12;
            // 
            // txtemail
            // 
            this.txtemail.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtemail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtemail.Location = new System.Drawing.Point(62, 157);
            this.txtemail.Margin = new System.Windows.Forms.Padding(5);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(437, 27);
            this.txtemail.TabIndex = 11;
            this.txtemail.Text = "Email";
            this.txtemail.Click += new System.EventHandler(this.Txtemail_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::control_user_pass_email.Properties.Resources.email;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(12, 152);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 35);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // user_pass1
            // 
            this.user_pass1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.user_pass1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_pass1.Location = new System.Drawing.Point(10, 5);
            this.user_pass1.Margin = new System.Windows.Forms.Padding(5);
            this.user_pass1.Name = "user_pass1";
            this.user_pass1.Size = new System.Drawing.Size(499, 153);
            this.user_pass1.TabIndex = 13;
            this.user_pass1.Load += new System.EventHandler(this.User_pass1_Load);
            // 
            // user_pass_email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Controls.Add(this.user_pass1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.pictureBox2);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "user_pass_email";
            this.Size = new System.Drawing.Size(516, 221);
            this.Load += new System.EventHandler(this.User_pass_email_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.PictureBox pictureBox2;
        private control_user_pass.user_pass user_pass1;
    }
}
