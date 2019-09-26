using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace control_user_pass
{
    public partial class user_pass: UserControl
    {
        public user_pass()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void Txtuser_Click(object sender, EventArgs e)
        {
            txtuser.Clear();

        }

        private void TxtPass_Click(object sender, EventArgs e)
        {
            txtPass.Clear(); txtPass.PasswordChar = '*';
            pictureBox2.BackColor = Color.FromArgb(192, 192, 255);
        }
    }
}
