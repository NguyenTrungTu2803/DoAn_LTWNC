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
    public partial class fromMain : Form
    {
        public fromMain()
        {
            InitializeComponent();
        }

        private void FromMain_Load(object sender, EventArgs e)
        {
            fromlogin fr1 = new fromlogin();
            fr1.Close();
        }
    }
}
