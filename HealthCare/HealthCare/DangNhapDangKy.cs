using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthCare.BUS;

namespace HealthCare
{
    public partial class DangNhapDangKy : UserControl
    {
        public delegate void DangKy_ChangeHandle();
        public event DangKy_ChangeHandle uscDangKy;
        public delegate void DangNhap_ChangeHandle();
        public event DangNhap_ChangeHandle uscDangNhap;
        BenhNhanBUS bnBus = new BenhNhanBUS();
        public DangNhapDangKy()
        {
            InitializeComponent();
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            if (bnBus.hasBenhNhan(tbTenDangNhap.Text, tbMatKhau.Text))
                uscDangNhap();
            else
            {
                lbWrong.Text = "Tên đăng nhập hoặc mật khẩu sai";
            }
        }

        private void btDangKy_Click(object sender, EventArgs e)
        {
            uscDangKy();
        }
    }
}
