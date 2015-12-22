using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthCare.DAL;
using HealthCare.DTO;
using System.Data;
namespace HealthCare.BUS
{
    public class BenhNhanBUS
    {
        BenhNhanDAL dal = new BenhNhanDAL();
        public bool hasTaiKhoan(string tenDangNhap, string MatKhau)
        {
            return dal.hasTaiKhoan(tenDangNhap, MatKhau);
        }

        public bool ktTrungTaiKhoan(string tenDangNhap)
        {
            return dal.ktTrungTaiKhoan(tenDangNhap);
        }

        public bool addBenhNhan(BenhNhan bn)
        {
           return dal.addBenhNhan(bn);           
        }

        public DataTable getDuLieuKham(string tenDangNhap)
        {
            return dal.getDuLieuKham(tenDangNhap);
        }

        public BenhNhan getThongTinTaiKhoan(string tenDangNhap)
        {
            return dal.GetThongTinTaiKhoan(tenDangNhap);
        }


    }
}
