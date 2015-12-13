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

            //ViTriChanDoanBUS vt = new ViTriChanDoanBUS();
            //TrieuChungChanDoanBUS tc = new TrieuChungChanDoanBUS();
            ////listViTri
            //cbVungDau.DataSource = vt.getListStringViTri();
            ////ListTrieChung
            //string ViTri = cbVungDau.Text;
            //cbTrieuChungTheoVung.DataSource = tc.getListStringTrieuChung(ViTri);
        }

        private void cbVungDau_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ViTri = cbVungDau.Text;

            TrieuChungChanDoanBUS tc = new TrieuChungChanDoanBUS();
            cbTrieuChungTheoVung.DataSource = tc.getListStringTrieuChung(ViTri);
        }
        private void UpdateListBenh()
        {
            //BenhBUS bus = new BenhBUS();
            //List<Benh> listBenh = bus.updateListBenh(listTC);
            //lbBenhChanDoan.Items.Clear();
            //foreach (Benh i in listBenh)
            //{
            //    lbBenhChanDoan.Items.Add(i.TenBenh);
            //}
        }

        private void cbTrieuChungTheoVung_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            //ViTriTrieuChung temp = new ViTriTrieuChung();
            //temp.TrieuChung = cbTrieuChungTheoVung.Text;
            //temp.ViTri = cbVungDau.Text;
            //bool kt = listTC.Exists(x => x == temp);
            //if (!kt)
            //{
            //    listTC.Add(temp);
            //    string tempSTR = temp.ViTri + "-" + temp.TrieuChung;
            //    lbDsTrieuChung.Items.Add(tempSTR);
            //    UpdateListBenh();
            //}
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            // //xoa khoi listTC
            //string VTTC = null;
            //VTTC=lbDsTrieuChung.SelectedItem.ToString();
            //if (VTTC != null)
            //{
            //    string[] split;
            //    split = VTTC.Split('-');
            //    ViTriTrieuChung temp = new ViTriTrieuChung();
            //    temp.ViTri = split[0];
            //    temp.TrieuChung = split[1];
            //    ViTriTrieuChung t = listTC.FirstOrDefault(x => x == temp);
            //    listTC.Remove(t);
            //    //xoa khoi listbox
            //    for (int n = lbDsTrieuChung.Items.Count - 1; n >= 0; --n)
            //    {
            //        string removelistitem = temp.ViTri + "-" + temp.TrieuChung;
            //        if (lbDsTrieuChung.Items[n].ToString().Contains(removelistitem))
            //        {
            //            lbDsTrieuChung.Items.RemoveAt(n);
            //        }
            //    }
            //    UpdateListBenh();
            //}
        }

        private void lbBenhChanDoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            //BenhBUS bus = new BenhBUS();

            //string tenbenh = lbBenhChanDoan.SelectedItem.ToString();
            //if (tenbenh != null)
            //{
            //    Benh benh = bus.getBenhByName(tenbenh);
            //    //labelName.Text = benh.TenBenh;
            //    //labelND.Text = benh.NoiDung;
            //}
        }

        private void ChanDoan_Load(object sender, EventArgs e)
        {
           
        }



    }
}
