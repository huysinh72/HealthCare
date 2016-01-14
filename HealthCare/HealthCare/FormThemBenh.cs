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
    public partial class FormThemBenh : Form
    {
        public FormThemBenh()
        {
            InitializeComponent();
        }

        private void FormThemBenh_Load(object sender, EventArgs e)
        {
            ShowViTriBenh();
        }


        private void btThem_Click(object sender, EventArgs e)
        {
            TrieuChung tc = (TrieuChung)lbTrieuChung.SelectedItem;
            if(tc == null || tbTenBenh.Text == "" || tbNoiDung.Text == "" || tbLoiKhuyen.Text == "")
            {
                MessageBox.Show("Bạn chưa đủ thông tin");
                return;
            }

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
    }
}
