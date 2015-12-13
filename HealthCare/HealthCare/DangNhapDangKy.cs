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
        public delegate void Main_ChangeHandle();
        public event Main_ChangeHandle uscMain;
        public DangNhapDangKy()
        {
            InitializeComponent();
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            BenhNhanBUS bus = new BenhNhanBUS();
            if (bus.hasTaiKhoan(tbTenDangNhap.Text, tbMatKhau.Text))
            {
                uscMain();
            }
            else
            {
                lbWrong.Text = "Tài khoản hoặc mật khẩu sai";
            }
           
        }

        private void btDangKy_Click(object sender, EventArgs e)
        {
            uscDangKy();
        }
    }
}
