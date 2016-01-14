using HealthCare.BUS;
using HealthCare.DAL;
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
    public partial class FormThemTrieuChung : Form
    {
        public FormThemTrieuChung()
        {
            InitializeComponent();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            ViTriBenh vt = (ViTriBenh)lbViTri.SelectedItem;
            if (tbTenTrieuChung.Text == "" || vt == null)
            {
                MessageBox.Show("Ban chua nhap du thong tin");
                return;
            }

            TrieuChung tc = new TrieuChung();
            tc.TenTrieuChung = tbTenTrieuChung.Text;
            TrieuChungBUS bus = new TrieuChungBUS();
            bus.addTrieuChung(tc, vt.MaViTri);
            MessageBox.Show("Thêm thành công");
            this.Close();
            
        }

        private void FormThemTrieuChung_Load(object sender, EventArgs e)
        {
            ChanDoanBUS bus = new ChanDoanBUS(); 
            ViTriBenh[] listVT = bus.getListViTri();

            foreach (ViTriBenh vt in listVT)
                lbViTri.Items.Add(vt);
            lbViTri.DisplayMember = "TenViTri";

        }
    }
}
