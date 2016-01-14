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
    public partial class FormThongTinBN : Form
    {
        public FormThongTinBN()
        {
            InitializeComponent();
        }

        private void btSave_Click(object sender, EventArgs e)
        {

        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormThongTinBN_Load(object sender, EventArgs e)
        {
            BenhNhanBUS bus = new BenhNhanBUS();
            BenhNhan bn = bus.getBenhNhan(MainForm.tenDangNhap);
            tbHoTen.Text = bn.TenNguoiDung;
            tbDienThoai.Text = bn.DienThoai;
            tbEmail.Text = bn.Email;
            tbNgaySinh.Text = bn.NgaySinh;
            tbDiaChi.Text = bn.DiaChi;
            if (bn.GioiTinh == "Nam")
            {
                cbNam.Checked = true;
                cbNu.Checked = false;
            }
            else
            {
                cbNu.Checked = true;
                cbNam.Checked = false;
            }
        }
    }
}
