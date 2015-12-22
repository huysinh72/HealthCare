using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthCare.DTO;
using HealthCare.DAL;

namespace HealthCare.BUS
{
    public class BaiDangBUS
    {
        BaiDangDAL dal = new BaiDangDAL();
        public BaiDangDTO[] getListBaiDang()
        {
            return dal.GetListBaiDang();
        }

        public BaiDangDTO[] timKiemBaiDang(string s)
        {
            return dal.TimKiemBaiDang(s);
        }
    }
}
