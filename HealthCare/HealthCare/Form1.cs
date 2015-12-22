﻿using System;
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
            tabDangKy.Appearance = TabAppearance.FlatButtons;
            tabDangKy.ItemSize = new Size(0, 1);
            tabDangKy.SizeMode = TabSizeMode.Fixed;
            tabDangKy.SelectedIndex = 6;
            ChanDoan.init();
           
        }

        private void change2ChanDoan()
        {
            tabDangKy.SelectedIndex = 0;
            ChanDoan.init();
        }
        private void change2KhamDinhKy()
        {
            tabDangKy.SelectedIndex = 1;
        }
        private void change2ThongKe()
        {
            tabDangKy.SelectedIndex = 2;
            thongKe.init();
        }
        private void change2BaiDang()
        {
            tabDangKy.SelectedIndex = 3;
            baiDang.init();
        }
        private void change2LienHeBacSi()
        {
            tabDangKy.SelectedIndex = 4;
            lienHeBacSi.init();
        }
        private void change2NguoiThan()
        {
            nguoiThan.init();
            tabDangKy.SelectedIndex = 5;
        }
        private void changeMain(string tenDN)
        {
            tabDangKy.SelectedIndex = 0;
            tenDangNhap = tenDN;
            BenhNhanBUS bus = new BenhNhanBUS();
            BenhNhan bn = bus.getThongTinTaiKhoan(tenDN);
            mainMenu.setTenDangNhap(bn.TenNguoiDung);
            mainMenu.Show(); 
        }
        private void change2DangKy()
        {
            tabDangKy.SelectedIndex = 7;
        }
        private void change2DangNhap()
        {
            tabDangKy.SelectedIndex = 6;
        }
        private void change2DangXuat()
        {
            tabDangKy.SelectedIndex = 6;
            mainMenu.Hide();
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
        }

        private void dangKy1_Load(object sender, EventArgs e)
        {
            dangKy.uscDangKyToDangNhap += new DangKy.DangKyToDangNhap_ChangeHandle(change2DangNhap);
        } 
    }
}
