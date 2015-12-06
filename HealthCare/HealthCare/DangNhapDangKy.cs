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
    public partial class DangNhapDangKy : UserControl
    {
        public delegate void DangKy_ChangeHandle();
        public event DangKy_ChangeHandle uscDangKy;
        public delegate void DangNhap_ChangeHandle();
        public event DangNhap_ChangeHandle uscDangNhap;
        public DangNhapDangKy()
        {
            InitializeComponent();
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            uscDangNhap();
        }

        private void btDangKy_Click(object sender, EventArgs e)
        {
            uscDangKy();
        }
    }
}
