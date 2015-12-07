using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthCare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mainMenu.Hide();
            dangKy.Hide();
            chanDoan.Hide();
            khamDinhKy.Hide();
            thongKe.Hide();
            baiDang.Hide();
            lienHeBacSi.Hide();
            nguoiThan.Hide();
        }

        
        private void ClickDangKy()
        {
            dangNhapDangKy.Hide();
            dangKy.Show();

        }

        private void ClickDangNhap()
        {
            dangNhapDangKy.Hide();
            mainMenu.Show();

        }

        private void ClickChanDoan()
        {
            khamDinhKy.Hide();
            thongKe.Hide();
            baiDang.Hide();
            lienHeBacSi.Hide();
            nguoiThan.Hide();
            chanDoan.Show();
        }
        private void ClickKhamDinhKy()
        {
            chanDoan.Hide();
            thongKe.Hide();
            baiDang.Hide();
            lienHeBacSi.Hide();
            nguoiThan.Hide();
            khamDinhKy.Show();
        }
        private void ClickTrangChu()
        {
            thongKe.Hide();
            chanDoan.Hide();
            baiDang.Hide();
            lienHeBacSi.Hide();
            nguoiThan.Hide();
            khamDinhKy.Hide();
        }

        private void ClickThongKe()
        {
            chanDoan.Hide();
            khamDinhKy.Hide();
            baiDang.Hide();
            lienHeBacSi.Hide();
            nguoiThan.Hide();
            thongKe.Show();
        }

        private void ClickBaiDang()
        {
            chanDoan.Hide();
            khamDinhKy.Hide();
            thongKe.Hide();
            lienHeBacSi.Hide();
            nguoiThan.Hide();
            baiDang.Show();
        }

        private void ClickLienHeBacSi()
        {
            chanDoan.Hide();
            khamDinhKy.Hide();
            thongKe.Hide();
            lienHeBacSi.Show();
            nguoiThan.Hide();
            baiDang.Hide();
        }

        private void ClickNguoiThan()
        {
            chanDoan.Hide();
            khamDinhKy.Hide();
            thongKe.Hide();
            lienHeBacSi.Hide();
            nguoiThan.Show();
            baiDang.Hide();
        }

        private void ClickDangXuat()
        {
            chanDoan.Hide();
            khamDinhKy.Hide();
            thongKe.Hide();
            lienHeBacSi.Hide();
            nguoiThan.Hide();
            baiDang.Hide();
            mainMenu.Hide();
            dangNhapDangKy.Show();
        }

        private void dangNhapDangKy_Load(object sender, EventArgs e)
        {
            dangNhapDangKy.uscDangKy += new DangNhapDangKy.DangKy_ChangeHandle(ClickDangKy);
            dangNhapDangKy.uscDangNhap += new DangNhapDangKy.DangNhap_ChangeHandle(ClickDangNhap);
            
        }

        private void mainMenu_Load(object sender, EventArgs e)
        {
            mainMenu.uscChanDoan += new MainMenu.ChanDoan_ChangeHandle(ClickChanDoan);
            mainMenu.uscKhamDinhKy += new MainMenu.KhamDinhKy_ChangeHandle(ClickKhamDinhKy);
            mainMenu.uscTrangChu += new MainMenu.TrangChu_ChangeHandle(ClickTrangChu);
            mainMenu.uscThongKe += new MainMenu.ThongKe_ChangeHandle(ClickThongKe);
            mainMenu.uscBaiDang += new MainMenu.BaiDang_ChangeHandle(ClickBaiDang);
            mainMenu.uscBacSi += new MainMenu.BacSi_ChangeHandle(ClickLienHeBacSi);
            mainMenu.uscNguoiThan += new MainMenu.NguoiThan_ChangeHandle(ClickNguoiThan);
            mainMenu.uscDangXuat += new MainMenu.DangXuat_ChangeHandle(ClickDangXuat);
        }
       
    }
}
