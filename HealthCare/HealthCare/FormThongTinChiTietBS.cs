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
    public partial class FormThongTinChiTietBS : Form
    {
        public FormThongTinChiTietBS()
        {
            InitializeComponent();
        }

        public void Init(BacSi bs)
        {
            tbMaBS.Text = bs.MaBacSi;
            tbChuyenNganh.Text = bs.ChuyenNganh;
            tbHoTen.Text = bs.TenBacSi;
            tbBangCap.Text = bs.BangCap;
            tbDienThoai.Text = bs.DienThoai;
            tbEmail.Text = bs.Email;
            tbNgaySinh.Text = bs.NgaySinh;
            tbDiaChi.Text = bs.DiaChi;
            if (bs.GioiTinh == "Nam")
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
