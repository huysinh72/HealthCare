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
using System.Threading;

namespace HealthCare
{
    public partial class ThongTinKham : Form
    {
        CamTTKhamBUS cb;
        Thread pulse;
        bool stop;
        public delegate void Update(string s);

        public bool isStop()
        {
            return stop;
        }
        public void Stop()
        {
            stop = true;
        }
        private void KhamDinhKy_Load(object sender, EventArgs e)
        {

        }
        public void UpdateEmotion(string s)
        {
            if (!this.isStop())
            {
                Update up = new Update(changeEmotion);
                this.BeginInvoke(up, s);
            }
        }
        public void UpdatePulse(string s)
        {
            if (!this.isStop())
            {
                Update up = new Update(changePulse);
                this.BeginInvoke(up, s);
            }
        }
        private void changePulse(string s)
        {
            tbNhipTim.Text = s;
        }
        private void changeEmotion(string s)
        {
            cbCamXuc.Text = s;
        }
        public void changePicture(Bitmap databitmap)
        {
            if (!this.isStop())
            {
                CamBox.Image = databitmap;
            }
        }

        public ThongTinKham()
        {

            stop = false;
            InitializeComponent();
        }

        private void btXong_Click(object sender, EventArgs e)
        {
            this.Stop();
            ThongTinThem tt = ThongTinThem.getInstance();
            tt.NhipTim = int.Parse(tbNhipTim.Text.ToString());
            tt.CamXuc = cbCamXuc.Text.ToString();
            tt.ChieuCao = int.Parse(tbChieuCao.Text.ToString());
            tt.CanNang = int.Parse(tbCanNang.Text.ToString());
            this.Close();
        }

        private void btSuDungCamera_Click(object sender, EventArgs e)
        {
            stop = false;
            cb = new CamTTKhamBUS(this);
            pulse = new Thread(new ThreadStart(cb.Pulse));
            pulse.Start();
        }
        private void Closing(Object sender, EventArgs e)
        {
            this.Stop();
        }
    }
}
