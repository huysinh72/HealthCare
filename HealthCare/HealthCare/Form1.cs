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
        }

        private void mainMenu_Load(object sender, EventArgs e)
        {
            
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
            chanDoan.Show();
        }
        private void ClickKhamDinhKy()
        {
            chanDoan.Hide();
            khamDinhKy.Show();
        }
        private void ClickTrangChu()
        {
            chanDoan.Hide();
            khamDinhKy.Hide();
        }

        private void dangNhapDangKy_Load(object sender, EventArgs e)
        {
            dangNhapDangKy.uscDangKy += new DangNhapDangKy.DangKy_ChangeHandle(ClickDangKy);
            dangNhapDangKy.uscDangNhap += new DangNhapDangKy.DangNhap_ChangeHandle(ClickDangNhap);
            mainMenu.uscChanDoan += new MainMenu.ChanDoan_ChangeHandle(ClickChanDoan);
            mainMenu.uscKhamDinhKy += new MainMenu.KhamDinhKy_ChangeHandle(ClickKhamDinhKy);
            mainMenu.uscTrangChu += new MainMenu.TrangChu_ChangeHandle(ClickTrangChu);
        }


       
    }
}
