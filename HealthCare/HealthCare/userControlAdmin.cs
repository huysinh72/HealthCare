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
    public partial class userControlAdmin : UserControl
    {
        public userControlAdmin()
        {
            InitializeComponent();
        }

        public void init()
        {
            lbDSBenhNhan.Items.Clear();
            BenhNhanBUS BNbus = new BenhNhanBUS(); 
            BenhNhan[] listBN=  BNbus.getListBenhNhan();
            foreach (BenhNhan bn in listBN)
            {
                if (bn.TenDangNhap != "admin")
                lbDSBenhNhan.Items.Add(bn);
            }
            lbDSBenhNhan.DisplayMember = "TenNguoiDung";

            ShowDSBacSi();
            ShowViTriBenh();
            
        }

        public void ShowViTriBenh()
        {
            lbViTriBenh.Items.Clear();
            ChanDoanBUS CDbus = new ChanDoanBUS();
            ViTriBenh[] listViTri = CDbus.getListViTri();
            foreach (ViTriBenh s in listViTri)
            {
                lbViTriBenh.Items.Add(s);
            }
            lbViTriBenh.DisplayMember = "TenViTri";
        }

        public void ShowDSBacSi()
        {
            lbDSBacSi.Items.Clear();
            BacSiBUS BSbus = new BacSiBUS();
            BacSi[] listBS = BSbus.getDSBacSi();
            foreach (BacSi bs in listBS)
            {
                lbDSBacSi.Items.Add(bs);
            }
            lbDSBacSi.DisplayMember = "TenBacSi";
        }

        private void btXemThongTinBN_Click(object sender, EventArgs e)
        {
            BenhNhan bn = (BenhNhan)lbDSBenhNhan.SelectedItem;
            FormThongTinChiTietBN tt = new FormThongTinChiTietBN();
            tt.Show();
            tt.Init(bn);
        }

        private void btXemThongTinBS_Click(object sender, EventArgs e)
        {
            BacSi bs = (BacSi)lbDSBacSi.SelectedItem;
            if (bs == null)
            {
                MessageBox.Show("Bạn chưa chọn bác sĩ");
                return;
            }
            FormThongTinChiTietBS ttbs = new FormThongTinChiTietBS();
            ttbs.Show();
            ttbs.Init(bs);
        }

        private void lbViTriBenh_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbTrieuChung.Items.Clear();
            ChanDoanBUS bus = new ChanDoanBUS();
            ViTriBenh vt = (ViTriBenh)lbViTriBenh.SelectedItem;
            TrieuChung[] tc = bus.getListTrieuChung(vt.MaViTri);
            if (tc == null)
                return;
            foreach (TrieuChung i in tc)
            {
                lbTrieuChung.Items.Add(i);
            }
            lbTrieuChung.DisplayMember = "TenTrieuChung";
        }

        private void lbTrieuChung_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbBenh.Items.Clear();
            ChanDoanBUS bus = new ChanDoanBUS();
            TrieuChung tc = (TrieuChung)lbTrieuChung.SelectedItem;
            Benh[] b = bus.getListBenh(tc.MaTrieuChung);
            if (b == null)
                return;
            foreach (Benh i in b)
            {
                lbBenh.Items.Add(i);
            }
            lbBenh.DisplayMember = "TenBenh";
        }

        private void lbBenh_SelectedIndexChanged(object sender, EventArgs e)
        {
            Benh b = (Benh)lbBenh.SelectedItem;
            FormBenh fb = new FormBenh();
            fb.Text = b.tenBenh;
            fb.init(b, true);
            fb.Show();
        }

        private void btThemBS_Click(object sender, EventArgs e)
        {
            FormThemBacSi fbs = new FormThemBacSi();
            fbs.Show();
        }

        private void btXoaBS_Click(object sender, EventArgs e)
        {
            BacSi bs = (BacSi)lbDSBacSi.SelectedItem;
            if(bs ==null)
            {
                MessageBox.Show("Bạn chưa chọn bác sĩ");
                return;
            }
            BacSiBUS bus = new BacSiBUS();
            bus.deleteBacSi(bs.MaBacSi);
            MessageBox.Show("Xóa thành công");
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            ShowDSBacSi();
            ShowViTriBenh();
        }

        private void btXoaBenhNhan_Click(object sender, EventArgs e)
        {
            //BenhNhan bn = (BenhNhan)lbDSBenhNhan.SelectedItem;
            //if(bn == null)
            //{
            //    MessageBox.Show("Bạn chưa chọn bênh nhân");
            //    return;
            //}
            //BenhNhanBUS bus = new BenhNhanBUS();
            //bus.deleteBenhNhan(bn.TenDangNhap);
            //MessageBox.Show("Xóa thành công");
        }

        private void btThemViTriBenh_Click(object sender, EventArgs e)
        {
            FormThemViTriBenh f = new FormThemViTriBenh();
            f.Show();
        }

        private void btThemTrieuChung_Click(object sender, EventArgs e)
        {
            FormThemTrieuChung f = new FormThemTrieuChung();
            f.Show();
        }

        private void btThemBenh_Click(object sender, EventArgs e)
        {
            FormThemBenh f = new FormThemBenh();
            f.Show();
        }
    }
}
