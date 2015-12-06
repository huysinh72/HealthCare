using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthCare
{
    public partial class MainMenu : UserControl
    {
        public delegate void ChanDoan_ChangeHandle();
        public event ChanDoan_ChangeHandle uscChanDoan;
        public delegate void KhamDinhKy_ChangeHandle();
        public event KhamDinhKy_ChangeHandle uscKhamDinhKy;
        public delegate void TrangChu_ChangeHandle();
        public event TrangChu_ChangeHandle uscTrangChu;
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btChanDoan_Click(object sender, EventArgs e)
        {
            uscChanDoan();
        }

        private void btKhamDinhKy_Click(object sender, EventArgs e)
        {
            uscKhamDinhKy();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            uscTrangChu();
        }
    }
}
