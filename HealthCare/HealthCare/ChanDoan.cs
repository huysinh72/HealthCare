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
            ViTriChanDoanBUS vt = new ViTriChanDoanBUS();
            TrieuChungChanDoanBUS tc = new TrieuChungChanDoanBUS();
            cbVungDau.DataSource = vt.getListStringViTri();
        }

        private void cbVungDau_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbDSTrieuChungTheoVung.Items.Clear();
            TrieuChungChanDoanBUS bus = new TrieuChungChanDoanBUS();
            TrieuChung[] tc = bus.getListTrieuChung(cbVungDau.Text);
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
            lbDsTrieuChungChon.Items.Add(tc);
            lbDsTrieuChungChon.DisplayMember = "TenTrieuChung";
            lbDsTrieuChungChon.ValueMember = "MaTrieuChung";
        }



    }
}
