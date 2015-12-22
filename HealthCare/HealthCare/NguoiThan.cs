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
    public partial class NguoiThan : UserControl
    {
        
        public NguoiThan()
        {
            InitializeComponent();
        }

        public void init()
        {
            lbDSNguoiThan.Items.Clear();
            NguoiThanBUS bus =  new NguoiThanBUS();
            NguoiThanDTO[] listNguoiThan = bus.getListNguoiThan(MainForm.tenDangNhap);
            foreach (NguoiThanDTO i in listNguoiThan)
                lbDSNguoiThan.Items.Add(i);
            lbDSNguoiThan.DisplayMember = "TenNguoiThan";
            lbDSNguoiThan.ValueMember = "TenDangNhap";
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            lbDSNguoiThanCanTim.Items.Clear();
            NguoiThanBUS bus = new NguoiThanBUS();
            NguoiThanDTO[] listTimNguoiThan = bus.findNguoiThan(tbTenTim.Text, MainForm.tenDangNhap);
            foreach (NguoiThanDTO i in listTimNguoiThan)          
                lbDSNguoiThanCanTim.Items.Add(i);
            lbDSNguoiThanCanTim.DisplayMember = "TenNguoiThan";
            lbDSNguoiThanCanTim.ValueMember = "TenDangNhap";
            
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            string ten = lbDSNguoiThanCanTim.SelectedItem.ToString();
            NguoiThanBUS bus = new NguoiThanBUS();
            bus.themNguoithan(ten);
        }

        private void lbDSNguoiThan_SelectedIndexChanged(object sender, EventArgs e)
        {
            NguoiThanDTO nt = (NguoiThanDTO)lbDSNguoiThan.SelectedItem;
            lbHoTen.Text = "Họ tên: " + nt.TenNguoiThan;
            lbGioiTinh.Text = "Giới tính: " + nt.GioiTinh;
            lbNgaySinh.Text = "Ngày sinh: " + nt.NgaySinh.ToString();
            lbEmail.Text = "Email: " + nt.Email;
            lbDienThoai.Text = "Điện thoại: " + nt.DienThoai;
            lbDiaChi.Text = "Địa chỉ: " + nt.DiaChi;
        }
    }
}
