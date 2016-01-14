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
    public partial class ChanDoan : UserControl
    {
        public ChanDoan()
        {
            InitializeComponent();
   
        }

        public void init()
        {
            lbDsTrieuChungChon.Items.Clear();
            lbBenhChanDoan.Items.Clear();
            lbDSTrieuChungTheoVung.Items.Clear();
            ChanDoanBUS bus = new ChanDoanBUS();
            cbVungDau.DataSource = bus.getListViTri();
            cbVungDau.DisplayMember = "TenViTri";
        }

        private void cbVungDau_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbDSTrieuChungTheoVung.Items.Clear();
            ChanDoanBUS bus = new ChanDoanBUS();
            ViTriBenh vt = (ViTriBenh)cbVungDau.SelectedItem;
            TrieuChung[] tc = bus.getListTrieuChung(vt.MaViTri);
            if (tc == null)
                return;
            foreach(TrieuChung i in tc)
            {
                lbDSTrieuChungTheoVung.Items.Add(i);
            }
            lbDSTrieuChungTheoVung.DisplayMember = "TenTrieuChung";
            lbDSTrieuChungTheoVung.ValueMember = "MaTrieuChung";
        }
       
        private void btDel_Click(object sender, EventArgs e)
        {
            int i = lbDsTrieuChungChon.SelectedIndex;
            if (i >=0)
            lbDsTrieuChungChon.Items.RemoveAt(i);
        }

        private void lbDSTrieuChungTheoVung_SelectedIndexChanged(object sender, EventArgs e)
        {
            TrieuChung tc = (TrieuChung)lbDSTrieuChungTheoVung.SelectedItem;
            if (!lbDsTrieuChungChon.Items.Contains(tc))
            {
                lbDsTrieuChungChon.Items.Add(tc);
                lbDsTrieuChungChon.DisplayMember = "TenTrieuChung";
                lbDsTrieuChungChon.ValueMember = "MaTrieuChung";
            }
        }

        private void btChanDoan_Click(object sender, EventArgs e)
        {
            lbBenhChanDoan.Items.Clear();
            ChanDoanBUS bus = new ChanDoanBUS();

            TrieuChung tc;
             for(int i = 0; i < lbDsTrieuChungChon.Items.Count; i++)
             {
                 tc = (TrieuChung)lbDsTrieuChungChon.Items[i];
                 Benh[] listBenh = bus.getListBenh(tc.MaTrieuChung);
                 if (listBenh != null)
                 foreach(Benh b in listBenh)
                 {
                     bool check = false;
                     for (int j = 0; j < lbBenhChanDoan.Items.Count; j++ )
                     {
                         Benh bb = (Benh)lbBenhChanDoan.Items[j];
                         if (bb.maBenh == b.maBenh)
                             check = true;
                     }
                         if (!check)
                         {
                             lbBenhChanDoan.Items.Add(b);
                             lbBenhChanDoan.DisplayMember = "TenBenh";
                         }
                 }
             }
        }

        private void lbBenhChanDoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            Benh b = (Benh)lbBenhChanDoan.SelectedItem;
            FormBenh fb = new FormBenh();
            fb.Text = b.tenBenh;
            fb.init(b, false);
            fb.Show();
        }

        private void btLayThongtin_Click(object sender, EventArgs e)
        {
            ThongTinKham form = new ThongTinKham();
            form.Show();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            Benh b = (Benh)lbBenhChanDoan.SelectedItem;
            if (b == null)
            {
                MessageBox.Show("Bạn chưa chuẩn đoán");
                return;
            }
            ThongTinThem tt = ThongTinThem.getInstance();

            DuLieuKham dlk = new DuLieuKham();
            dlk.NhipTim = tt.NhipTim;
            dlk.CamXuc = tt.CamXuc;
            dlk.ChieuCao = tt.ChieuCao;
            dlk.CanNang = tt.CanNang;
            dlk.MaBenh = b.maBenh;
            ChanDoanBUS bus = new ChanDoanBUS();
            int maDLK = bus.addDulieuKham(dlk);

            for (int i = 0; i < lbDsTrieuChungChon.Items.Count; i++)
            {
                TrieuChung tc = (TrieuChung)lbDsTrieuChungChon.Items[i];
                bus.addTrieuChungKham(maDLK, tc.MaTrieuChung);
            }
            MessageBox.Show("Thông tin kham đã được lưu");
            tt.delete();

        }
    }
}
