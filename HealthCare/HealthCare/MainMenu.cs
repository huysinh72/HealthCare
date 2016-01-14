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

        public void setTenDangNhap(string tenDN)
        {
            btTenBenhNhan.Text = tenDN; 
        }

        private void btTenBenhNhan_Click(object sender, EventArgs e)
        {
            FormThongTinBN t = new FormThongTinBN();
            t.Show();
        }

        private void btDangXuat_Click(object sender, EventArgs e)
        {
            uscDangXuat();
        }

        public void disableButton()
        {
            btChanDoan.Enabled = false;
            btBaiDang.Enabled = false;
            btKhamDinhKy.Enabled = false;
            btLienHe.Enabled = false;
            btNguoiThan.Enabled = false;
            btThongKe.Enabled = false;
            btTenBenhNhan.Enabled = false;
        }
        public void enableButton()
        {
            btChanDoan.Enabled = true;
            btBaiDang.Enabled = true;
            btKhamDinhKy.Enabled = true;
            btLienHe.Enabled = true;
            btNguoiThan.Enabled = true;
            btThongKe.Enabled = true;
            btTenBenhNhan.Enabled = true;
        }
    }
}
