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
using System.Threading;
using System.Windows.Forms.DataVisualization.Charting;

namespace HealthCare
{
    public partial class KhamDinhKy : UserControl
    {
        CamBUS cb;
        Thread pulse;
        bool stop;
        public delegate void Update(string s);
        public KhamDinhKy()
        {
            InitializeComponent();
            stop = false;
        }
        public void Stop()
        {
            stop = true;
        }
        public bool isStop()
        {
            return stop;
        }
        private void KhamDinhKy_Load(object sender, EventArgs e)
        {
            chartNhipTim.Series["NhipTim"].ChartType = SeriesChartType.Line;
            EmoBox.Image = HealthCare.Properties.Resources.joy;
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
            tbNhipTimTB.Text = updateChart().ToString();
        }
        private void changeEmotion(string s)
        {
            tbCamXuc.Text = s;
            switch (s)
            {
                case "Vui":
                    EmoBox.Image = HealthCare.Properties.Resources.joy;
                    lbDongVien.Text = "Trông bạn đang rất vui vẻ ! Hãy luôn giữ tinh thần vui vẻ này nha !";
                    break;
                case "Buồn":
                    EmoBox.Image = HealthCare.Properties.Resources.sad;
                    lbDongVien.Text = "Bạn đang buồn à, hãy chia sẻ với ai đó để vơi đi nỗi buồn!";
                    break;
                case "Tức giận":
                    EmoBox.Image = HealthCare.Properties.Resources.anger;
                    lbDongVien.Text = "Trông bạn rất xấu khi tức giân, hãy vui vẻ nào !";
                    break;
                case "Ngạc nhiên":
                    EmoBox.Image = HealthCare.Properties.Resources.suprise;
                    lbDongVien.Text = "Bạn ngạc nhiên à, bạn quá dễ thương phải không!";
                    break;
                case "Khinh thường":
                    EmoBox.Image = HealthCare.Properties.Resources.CONTEMPT;
                    lbDongVien.Text = "Đang khinh thường mình à! Hãy cười lên xem ai đẹp hơn !";
                    break;
                default:
                    EmoBox.Image = HealthCare.Properties.Resources.Normal;
                    break;
            }
        }
        public void changePicture(Bitmap databitmap)
        {
            if (!this.isStop())
            {
                CamBox.Image = databitmap;
            }
        }

    

        private void btSuDungCamera_Click_1(object sender, EventArgs e)
        {
            chartNhipTim.Series["NhipTim"].Points.Clear();
            arrPulse = new List<int>();
            stop = false;
            cb = new CamBUS(this);
            pulse = new Thread(new ThreadStart(cb.Pulse));
            pulse.Start();
            initChart();
            
        }
        void initChart()
        {
            for (int i = 0; i < 15; ++i)
            {
                chartNhipTim.Series["NhipTim"].Points.AddXY(i + 1, 80);
            }
            tbNhipTimTB.Text = "80";
        }

        List<int> arrPulse;
        int updateChart()
        {
            arrPulse.Add((int)float.Parse(tbNhipTim.Text.ToString()));
            if (arrPulse.Count > 15)
                arrPulse.RemoveAt(0);

            chartNhipTim.Series["NhipTim"].Points.Clear();

            for (int i = 0; i < arrPulse.Count(); ++i)
            {
                int y = arrPulse[i];
                chartNhipTim.Series["NhipTim"].Points.AddXY(i + 1, y);
            }

            return arrPulse.Sum()/arrPulse.Count;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            Stop();
            KhamDinhKyBUS bus = new KhamDinhKyBUS();
            bus.SaveDuLieuKham(MainForm.tenDangNhap, int.Parse(tbNhipTim.Text), tbCamXuc.Text);
            MessageBox.Show("Bạn đã khám thành công!", "Notification", MessageBoxButtons.OK);
        }
    }
}
