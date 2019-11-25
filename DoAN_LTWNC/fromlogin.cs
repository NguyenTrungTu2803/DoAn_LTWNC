using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_LTWNC
{
    public partial class fromlogin : Form
    {
        public fromlogin()
        {
            InitializeComponent();
        }

        private void Fromlogin_Load(object sender, EventArgs e)
        {
               
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void user_pass1_Click(object sender, EventArgs e)
        {

        }

        private void fromlogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            fr_MainBanVe fr_MainBanVe = new fr_MainBanVe();
            fr_MainBanVe.Show();
        }

    }
}
