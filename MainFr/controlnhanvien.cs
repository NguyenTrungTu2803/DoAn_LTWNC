using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace MainFr
{
    public partial class controlnhanvien : UserControl
    {
        TruyVanData data;
        public controlnhanvien()
        {
            InitializeComponent();
            data = new TruyVanData();
        }

        private void controlnhanvien_Load(object sender, EventArgs e)
        {
            LoadGrdi();
        }
        void LoadGrdi()
        {
            dtgv_tkDoanhso.DataSource = data.LoadNhanVien();
            //dtgv_tkDoanhso.DataSource = data.LoadNhanVienPQ();
        }

    }
}
