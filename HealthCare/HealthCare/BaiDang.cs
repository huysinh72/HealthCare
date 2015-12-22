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
    public partial class BaiDang : UserControl
    {
        public BaiDang()
        {
            InitializeComponent();
        }

        public void init()
        {
            lbChuDe.Items.Clear();
            BaiDangBUS bus = new BaiDangBUS();
            BaiDangDTO[] bd = bus.getListBaiDang();
            foreach(BaiDangDTO i in bd)
            {
                lbChuDe.Items.Add(i);
            }
            lbChuDe.DisplayMember = "ChuDe";
            lbChuDe.ValueMember = "MaBaiDang";
        }

        private void lbChuDe_SelectedIndexChanged(object sender, EventArgs e)
        {
            BaiDangDTO bd = (BaiDangDTO)lbChuDe.SelectedItem;
            tbNoiDung.Text = bd.NoiDung;
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            lbChuDe.Items.Clear();
            tbNoiDung.Text = "";
            BaiDangBUS bus = new BaiDangBUS();
            BaiDangDTO[] bd = bus.timKiemBaiDang(tbChuDe.Text);
            if (bd == null)
                return;
            foreach (BaiDangDTO i in bd)
            {
                lbChuDe.Items.Add(i);
            }
            lbChuDe.DisplayMember = "ChuDe";
            lbChuDe.ValueMember = "MaBaiDang";

        }

    
    }
}
