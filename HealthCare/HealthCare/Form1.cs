using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthCare.DTO;
using HealthCare.BUS;

namespace HealthCare
{
    public partial class MainForm : Form
    {

        static public string tenDangNhap = string.Empty;
        public MainForm()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
           // mainMenu.Hide();
            tabControl.Appearance = TabAppearance.FlatButtons;
            tabControl.ItemSize = new Size(0, 1);
            tabControl.SizeMode = TabSizeMode.Fixed;
            tabControl.SelectedIndex = 6;
            ChanDoan.init();
           
        }

        private void change2ChanDoan()
        {
            tabControl.SelectedIndex = 0;
            ChanDoan.init();
        }
        private void change2KhamDinhKy()
        {
            tabControl.SelectedIndex = 1;
        }
        private void change2ThongKe()
        {
            tabControl.SelectedIndex = 2;
            thongKe.init();
        }
        private void change2BaiDang()
        {
            tabControl.SelectedIndex = 3;
            baiDang.init();
        }
        private void change2LienHeBacSi()
        {
            tabControl.SelectedIndex = 4;
            lienHeBacSi.init();
        }
        private void change2NguoiThan()
        {
            nguoiThan.init();
            tabControl.SelectedIndex = 5;
        }
        private void changeMain(string tenDN)
        {
            if (tenDN != "admin")
            {
                tabControl.SelectedIndex = 0;
                tenDangNhap = tenDN;
                BenhNhanBUS bus = new BenhNhanBUS();
                BenhNhan bn = bus.getThongTinTaiKhoan(tenDN);
                mainMenu.setTenDangNhap(bn.TenNguoiDung);
                mainMenu.enableButton();
                mainMenu.Show();
            }
            else
            {
                tabControl.SelectedIndex = 8;
                tenDangNhap = tenDN;
                mainMenu.setTenDangNhap(tenDN);
                mainMenu.disableButton();
                mainMenu.Show();
                userControlAdmin.init();
            }
        }
        private void change2DangKy()
        {
            tabControl.SelectedIndex = 7;
        }
        private void change2DangNhap()
        {
            tabControl.SelectedIndex = 6;
        }
        private void change2DangXuat()
        {
            tabControl.SelectedIndex = 6;
            mainMenu.Hide();
        }

        private void change2TrangChu()
        {
            tabControl.SelectedIndex = 0;
           // mainMenu.Hide();
        }

        private void dangNhapDangKy_Load(object sender, EventArgs e)
        {
            mainMenu.Hide();
            dangNhapDangKy.uscMain += new DangNhapDangKy.Main_ChangeHandle(changeMain);
            dangNhapDangKy.uscDangKy += new DangNhapDangKy.DangKy_ChangeHandle(change2DangKy);
        }

        private void mainMenu_Load(object sender, EventArgs e)
        {
            mainMenu.uscChanDoan += new MainMenu.ChanDoan_ChangeHandle(change2ChanDoan);
            mainMenu.uscBacSi += new MainMenu.BacSi_ChangeHandle(change2LienHeBacSi);
            mainMenu.uscBaiDang += new MainMenu.BaiDang_ChangeHandle(change2BaiDang);
            mainMenu.uscKhamDinhKy += new MainMenu.KhamDinhKy_ChangeHandle(change2KhamDinhKy);
            mainMenu.uscNguoiThan += new MainMenu.NguoiThan_ChangeHandle(change2NguoiThan);
            mainMenu.uscThongKe += new MainMenu.ThongKe_ChangeHandle(change2ThongKe);
            mainMenu.uscDangXuat += new MainMenu.DangXuat_ChangeHandle(change2DangXuat);
            mainMenu.uscTrangChu += new MainMenu.TrangChu_ChangeHandle(change2TrangChu);
        }

        private void dangKy1_Load(object sender, EventArgs e)
        {
            dangKy.uscDangKyToDangNhap += new DangKy.DangKyToDangNhap_ChangeHandle(change2DangNhap);
        }
        private void Form1_Closing(Object sender, EventArgs e)
        {
            khamDinhKy.Stop();
        }
    }
}
