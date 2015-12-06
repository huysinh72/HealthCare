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
    public partial class KhamDinhKy : UserControl
    {
        public KhamDinhKy()
        {
            InitializeComponent();
        }

        private void KhamDinhKy_Load(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Bạn có muốn sử dụng Camera không?", "Xác nhận Camera", MessageBoxButtons.YesNo)==DialogResult.Yes)
            //{
            //    //readoly
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn đã khám thành công!","Noti",MessageBoxButtons.OK);
        }
    }
}
