using HealthCare.BUS;
using HealthCare.DTO;
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
    public partial class FormThongTinChiTietBN : Form
    {
        public FormThongTinChiTietBN()
        {
            InitializeComponent();
        }

        public void Init(BenhNhan bn)
        {
            tbMatKhau.Text = bn.MatKhau;
            tbTenDangNhap.Text = bn.TenDangNhap;
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

            BenhNhanBUS bus = new BenhNhanBUS();

            DataTable dt = bus.getDuLieuKhamVaBenh(bn.TenDangNhap);

            foreach(DataRow r in dt.Rows)
            {
                dataGridViewDSBenhAn.Rows.Add(r["NgayKham"], r["NhipTim"], r["CamXuc"], r["TenBenh"]);
            }
        }
    }
}
