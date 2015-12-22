using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthCare.DAL;
using System.Data;
using HealthCare.DTO;

namespace HealthCare.BUS
{
    public class NguoiThanBUS
    {
        NguoiThanDAL dal = new NguoiThanDAL();
    
        public NguoiThanDTO[] getListNguoiThan(string bn)
        {
            DataTable tb =  dal.getListNguoiThan(bn);
            NguoiThanDTO[] list = new NguoiThanDTO[tb.Rows.Count];
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                list[i] = new NguoiThanDTO();
                list[i].TenNguoiThan = tb.Rows[i]["TenBenhNhan"].ToString().Trim();
                list[i].TenDangNhap = tb.Rows[i]["TenDangNhap"].ToString().Trim();
                list[i].NgaySinh = DateTime.Parse(tb.Rows[i]["NgaySinh"].ToString()).ToShortDateString();
                list[i].GioiTinh = tb.Rows[i]["GioiTinh"].ToString().Trim();
                list[i].Email = tb.Rows[i]["Email"].ToString().Trim();
                list[i].DienThoai = tb.Rows[i]["DienThoai"].ToString().Trim();
                list[i].DiaChi = tb.Rows[i]["DiaChi"].ToString().Trim();
            }
            return list;
        }

        public NguoiThanDTO[] findNguoiThan(string name, string bn)
        {
            string ten = string.Format("'{0}'", name);
            DataTable tb = dal.findNguoiThan(name, bn);
            NguoiThanDTO[] list = new NguoiThanDTO[tb.Rows.Count];
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                list[i] = new NguoiThanDTO();
                list[i].TenNguoiThan = tb.Rows[i]["TenBenhNhan"].ToString();
                list[i].TenDangNhap = tb.Rows[i]["TenDangNhap"].ToString();
                list[i].NgaySinh = DateTime.Parse(tb.Rows[i]["NgaySinh"].ToString()).ToShortDateString();
                list[i].GioiTinh = tb.Rows[i]["GioiTinh"].ToString().Trim();
                list[i].Email = tb.Rows[i]["Email"].ToString().Trim();
                list[i].DienThoai = tb.Rows[i]["DienThoai"].ToString().Trim();
                list[i].DiaChi = tb.Rows[i]["DiaChi"].ToString().Trim();
            }
            return list;
        }

        public bool themNguoithan(string ten)
        {
            //foreach (NguoiThanDTO i in listNguoiTim)
            //    if(i.TenNguoiThan == ten)
            //        return dal.addNguoiThan(MainForm.tenDangNhap, i.TenDangNhap);
            return false;
        }
    }
}
