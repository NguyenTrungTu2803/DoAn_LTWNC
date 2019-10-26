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
    public partial class update_delete_insert : UserControl
    {
        public update_delete_insert()
        {
            InitializeComponent();
        }

        private void update_delete_insert_Load(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnHuy.Enabled = true; btnLuu.Enabled = true; btnThem.Enabled = false; btnXoa.Enabled = btnSua.Enabled = false;
            gridControl1.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                btnLuu.Enabled = true;
                btnHuy.Enabled = true;
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
            }
            catch { }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnHuy.Enabled = false;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            gridControl1.Enabled = true;
        }

    }
}
