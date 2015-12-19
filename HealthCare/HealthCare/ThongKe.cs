using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using HealthCare.DAL;

namespace HealthCare
{
    public partial class ThongKe : UserControl
    {
        int max, min;
        public ThongKe()
        {
            InitializeComponent();
        }

        int DrawChart()
        {
            int res = 0;
            min = 2000000000;
            max = 0;
            BenhNhanDAL bndal = new BenhNhanDAL();
            DataTable table = bndal.getDuLieuKham("team04");
            chartNhipTim.Series["NhipTim"].Points.Clear();

            for (int i = 0; i < table.Rows.Count; ++i)
            {
                int y = (int)table.Rows[i]["NhipTim"];
                res += y;
                chartNhipTim.Series["NhipTim"].Points.AddXY(i + 1, y);
                if (y < min) min = y;
                if (y > max) max = y;
            }

            return (table.Rows.Count == 0) ? 0 : (res / table.Rows.Count);
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            chartNhipTim.Series["NhipTim"].ChartType = SeriesChartType.Line;
            tbNhipTimTB.Text = DrawChart().ToString();
        }
    }
}
