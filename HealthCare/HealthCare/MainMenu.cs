using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthCare
{
    public partial class MainMenu : UserControl
    {
        public delegate void TrangChu_ChangeHandle();
        public event TrangChu_ChangeHandle uscTrangChu;

        public delegate void ChanDoan_ChangeHandle();
        public event ChanDoan_ChangeHandle uscChanDoan;

        public delegate void KhamDinhKy_ChangeHandle();
        public event KhamDinhKy_ChangeHandle uscKhamDinhKy;
        
        public delegate void ThongKe_ChangeHandle();
        public event ThongKe_ChangeHandle uscThongKe;

        public delegate void BaiDang_ChangeHandle();
        public event BaiDang_ChangeHandle uscBaiDang;

        public delegate void BacSi_ChangeHandle();
        public event BacSi_ChangeHandle uscBacSi;

        public delegate void NguoiThan_ChangeHandle();
        public event NguoiThan_ChangeHandle uscNguoiThan;

        public delegate void DangXuat_ChangeHandle();
        public event DangXuat_ChangeHandle uscDangXuat;
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btChanDoan_Click(object sender, EventArgs e)
        {
            uscChanDoan();
        }

        private void btKhamDinhKy_Click(object sender, EventArgs e)
        {
            uscKhamDinhKy();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            uscTrangChu();
        }

        private void btThongKe_Click(object sender, EventArgs e)
        {
            uscThongKe();
        }

        private void btBaiDang_Click(object sender, EventArgs e)
        {
            uscBaiDang();
        }

        private void btLienHe_Click(object sender, EventArgs e)
        {
            uscBacSi();
        }

        private void btNguoiThan_Click(object sender, EventArgs e)
        {
            uscNguoiThan();
        }

        private void lbDangXuat_Click(object sender, EventArgs e)
        {
            uscDangXuat();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
