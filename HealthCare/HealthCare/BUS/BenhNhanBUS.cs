using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthCare.DAL;
using HealthCare.DTO;
namespace HealthCare.BUS
{
    public class BenhNhanBUS
    {
        BenhNhanDAL dal = new BenhNhanDAL();
        public bool hasBenhNhan(string tenDangNhap, string MatKhau)
        {
            return dal.hasBenhNhan(tenDangNhap, MatKhau);
        }
    }
}
