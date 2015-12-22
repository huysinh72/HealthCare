using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthCare.DTO;
using HealthCare.BUS;

namespace HealthCare
{
    public partial class LienHeBacSi : UserControl
    {
        public LienHeBacSi()
        {
            InitializeComponent();
        }

        private void LienHeBacSi_Load(object sender, EventArgs e)
        {

        }

        public void init()
        {
            BacSiBUS bus = new BacSiBUS();
            cbChuyenNganh.DataSource = bus.getDSChuyenNganh();
            groupBox1.Hide();
        }

        private void cbChuyenNganh_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbDSBacSi.Items.Clear();
            BacSi[] DSBacSi = null;
            BacSiBUS bus = new BacSiBUS();
            string CN = cbChuyenNganh.SelectedItem.ToString();
            DSBacSi = bus.getDSBacSiByChuyenNganh(CN);
            string[] DSTenBacSi = new string[DSBacSi.Count()];
            foreach (BacSi i in DSBacSi)
                lbDSBacSi.Items.Add(i);
            lbDSBacSi.DisplayMember = "TenBacSi";
            lbDSBacSi.ValueMember = "MaBacSi";
        }

        private void lbDSBacSi_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBox1.Show();
            BacSi res = (BacSi)lbDSBacSi.SelectedItem;
            lbHoTen.Text = "Họ tên: " +res.TenBacSi;
            lbEmail.Text = "Email: "+ res.Email;
            lbDienThoai.Text = "Số điện thoại: "+res.DienThoai;
            lbDiaChi.Text = "Địa chỉ: "+res.DiaChi;
            lbBangCap.Text = "Bằng cấp: " + res.BangCap;
        }
    }
}
