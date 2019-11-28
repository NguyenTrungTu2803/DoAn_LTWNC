using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainFr
{
    public partial class controlbanve : UserControl
    {
        public controlbanve()
        {
            InitializeComponent();
        }

        private void txt_diemdon_Click(object sender, EventArgs e)
        {
            txt_diemdon.Clear();
        }

        void LoadInt()
        {
            txt_diachiKH.Text = "Địa chỉ khách hàng";
            txt_diemden.Text = "Nhập điểm đến";
            txt_diemdon.Text = "Nhập điểm đón";
            txt_ghichu.Text = "Ghi chú";
            txt_sdtKH.Text = "SDT khách hàng";
            txt_soluong.Text = "Số lượng";
            txt_stt.Text = "Số thứ tự";
            txt_tenKH.Text = "Họ tên khách hàng";
        }

        private void controlbanve_Load(object sender, EventArgs e)
        {
            LoadInt();
        }

        private void txt_diemden_Click(object sender, EventArgs e)
        {
            txt_diemden.Clear();
        }

        private void txt_sdtKH_Click(object sender, EventArgs e)
        {
            txt_sdtKH.Clear();
        }

        private void txt_tenKH_Click(object sender, EventArgs e)
        {
            txt_tenKH.Clear();
        }

        private void txt_diachiKH_Click(object sender, EventArgs e)
        {
            txt_diachiKH.Clear();
        }

        private void txt_ghichu_Click(object sender, EventArgs e)
        {
            txt_ghichu.Clear();
        }

        private void txt_stt_Click(object sender, EventArgs e)
        {
            txt_stt.Clear();
        }

        private void txt_soluong_Click(object sender, EventArgs e)
        {
            txt_soluong.Clear();
        }
    }
}
