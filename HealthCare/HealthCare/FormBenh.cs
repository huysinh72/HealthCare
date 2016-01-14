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
    public partial class FormBenh : Form
    {
        int maBenh;
        public FormBenh()
        {
            InitializeComponent();
        }
        public void init(Benh b, bool admin)
        {
            maBenh = b.maBenh;
            tbNoiDungBenh.Text = b.noiDung;
            tbLoiKhuyen.Text = b.loiKhuyen;
            if (!admin)
            {
                btSave.Hide();
                tbLoiKhuyen.Enabled = false;
                tbNoiDungBenh.Enabled = false;
            }
            else
                btSave.Show();
        }

        private void btSave_Click(object sender, EventArgs e)
        {

        }
    }
}
