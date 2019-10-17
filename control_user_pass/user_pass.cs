using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace control_user_pass
{
    public partial class user_pass: UserControl
    {
        public user_pass()
        {
            InitializeComponent();
           
        }
        //
        //
        //

        private void UserControl1_Load(object sender, EventArgs e)
        {
           
        }
        private string s;
        SqlConnection connec = new SqlConnection(Properties.Settings.Default.QL_NhanVien);
        private void Txtuser_Click(object sender, EventArgs e)
        {
            txtuser.Clear();
            pictureBox1.BackgroundImage = Properties.Resources.phone_icon2;
            panel1.BackColor = Color.FromArgb(78, 184, 206);
            txtuser.ForeColor = Color.FromArgb(78, 184, 206);

            pictureBox2.BackgroundImage = Properties.Resources.Lock_Icon_Main_Page;
            panel2.BackColor = Color.WhiteSmoke;
            txtPass.ForeColor = Color.WhiteSmoke;

            pictureBox3.BackgroundImage = Properties.Resources.email;
            panel3.BackColor = Color.WhiteSmoke;
            txtemail.ForeColor = Color.WhiteSmoke;

        }

        private void TxtPass_Click(object sender, EventArgs e)
        {
            txtPass.Clear(); txtPass.PasswordChar = '*';
            pictureBox2.BackgroundImage = Properties.Resources.Lock_Icon_Main_Page2;
            panel2.BackColor = Color.FromArgb(78, 184, 206);
            txtPass.ForeColor = Color.FromArgb(78, 184, 206);

            pictureBox1.BackgroundImage = Properties.Resources.phone_icon;
            panel1.BackColor = Color.WhiteSmoke;
            txtuser.ForeColor = Color.WhiteSmoke;

            pictureBox3.BackgroundImage = Properties.Resources.email;
            panel3.BackColor = Color.WhiteSmoke;
            txtemail.ForeColor = Color.WhiteSmoke;


        }

        private void Txtemail_Click(object sender, EventArgs e)
        {
            txtemail.Clear();
            pictureBox3.BackgroundImage = Properties.Resources.email2;
            panel3.BackColor = Color.FromArgb(78, 184, 206);
            txtemail.ForeColor = Color.FromArgb(78, 184, 206);

            pictureBox1.BackgroundImage = Properties.Resources.phone_icon;
            panel1.BackColor = Color.WhiteSmoke;
            txtuser.ForeColor = Color.WhiteSmoke;

            pictureBox2.BackgroundImage = Properties.Resources.Lock_Icon_Main_Page;
            panel2.BackColor = Color.WhiteSmoke;
            txtPass.ForeColor = Color.WhiteSmoke;


        }

        private void BtnDangNhap_Click(object sender, EventArgs e)
        {
            timer1.Start();
            if (txtuser.Text.Trim().Length == 0 || txtPass.Text.Trim().Length == 0 || txtemail.Text.Trim().Length == 0)
                MessageBox.Show("Nhập thông tin đầy đủ!", "Thông báo", MessageBoxButtons.OK);
            else
            {
                if (radHanhKhach.Checked) { }
                if (radNV.Checked) {
                    
                }
            }
            
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

        }

        private void Timer2_Tick(object sender, EventArgs e)
        {

        }
        public RadioButton rad;
    }
}
