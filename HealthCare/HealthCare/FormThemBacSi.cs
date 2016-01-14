using HealthCare.BUS;
using HealthCare.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HealthCare
{
    public partial class FormThemBacSi : Form
    {
        public FormThemBacSi()
        {
            InitializeComponent();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if(tbHoTen.Text == "" || tbDiaChi.Text=="" ||
               tbDienThoai.Text == "" || tbEmail.Text =="" || dtpickerNgaySinh.Text == "" || tbDienThoai.Text == ""||
            (cbNam.Checked == false && cbNu.Checked == false))
            {
                lbWrong.Text = "Thiếu thông tin cung cấp";
                return;
            }
            BacSi bs = new BacSi();
            bs.TenBacSi = tbHoTen.Text;
            bs.NgaySinh = DateTime.Parse(dtpickerNgaySinh.Text).ToShortDateString();
            bs.GioiTinh = cbNam.Checked ? "Nam" : "Nữ";
            bs.DienThoai = tbDienThoai.Text;
            bs.DiaChi = tbDiaChi.Text;
            bs.Email = tbEmail.Text;
            bs.ChuyenNganh = tbChuyenNganh.Text;
            bs.BangCap = tbBangCap.Text;
            BacSiBUS bus = new BacSiBUS();
            bus.addBacSi(bs);
            MessageBox.Show("Đã thêm bác sĩ thành công");
            this.Close();
        }
    }
}
