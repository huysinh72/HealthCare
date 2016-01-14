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
    public partial class FormThemViTriBenh : Form
    {
        public FormThemViTriBenh()
        {
            InitializeComponent();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            ViTriBenhDAL dal = new ViTriBenhDAL();
            ViTriBenh vt = new ViTriBenh();
           if (tbTenViTri.Text == "")
           {
               MessageBox.Show("Bạn chưa nhập vị trí bênh");
               return;
           }
           else
           {
               vt.TenViTri = tbTenViTri.Text;
               dal.addViTriBenh(vt);
               MessageBox.Show("Thêm vị trí bệnh thành công");
           }
            
        }
    }
}
