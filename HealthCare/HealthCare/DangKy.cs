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
using HealthCare.DTO;

namespace HealthCare
{
    public partial class DangKy : UserControl
    {
        public delegate void DangKyToDangNhap_ChangeHandle();
        public event DangKyToDangNhap_ChangeHandle uscDangKyToDangNhap;
        public DangKy()
        {
            InitializeComponent();
            btDangKy.Enabled = false;
        }

        private void cbNam_CheckedChanged(object sender, EventArgs e)
        {
            cbNu.Checked = false;
            //cbNam.Checked = true;
        }

        private void cbNu_CheckedChanged(object sender, EventArgs e)
        {
            cbNam.Checked = false;
            //cbNu.Checked = true;
        }

        private void btDangKy_Click(object sender, EventArgs e)
        {
           if(tbTenDangNhap.Text == "" || tbMatKhau.Text == ""||tbHoTen.Text == "" || tbDiaChi.Text=="" || tbXacNhanMatkhau.Text == ""||
               tbDienThoai.Text == "" || tbEmail.Text =="" || dtpickerNgaySinh.Text == "" || tbDienThoai.Text == ""||
            (cbNam.Checked == false && cbNu.Checked == false))
           {
               lbWrong.Text = "Thiếu thông tin cung cấp";
               return;
           }

            if(tbMatKhau.Text != tbXacNhanMatkhau.Text)
            {
                lbWrong.Text = "Xác nhận mật khẩu sai";
                return;
            }
           
           BenhNhanBUS bus = new BenhNhanBUS();
           if (bus.ktTrungTaiKhoan(tbTenDangNhap.Text))
                lbWrong.Text = "Tài khoản đã tồn tại";
           BenhNhan bn = new BenhNhan();
           bn.TenDangNhap = tbTenDangNhap.Text;
           bn.TenNguoiDung = tbHoTen.Text;
           bn.MatKhau = tbMatKhau.Text;
           bn.NgaySinh = DateTime.Parse(dtpickerNgaySinh.Text);
           bn.Email = tbEmail.Text;
           bn.DienThoai = tbDienThoai.Text;
           bn.GioiTinh = cbNam.Checked ? "Nam" : "Nữ";
           bus.addBenhNhan(bn);
           if (MessageBox.Show("Bạn đã đăng ký thành công!", "Đăng ký", MessageBoxButtons.OK)==DialogResult.OK)
           {
               uscDangKyToDangNhap();
           } 
        }

        private void cbDongYDieuKhoan_CheckedChanged(object sender, EventArgs e)
        {
            btDangKy.Enabled = true;
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            uscDangKyToDangNhap();
        }
    }
}
