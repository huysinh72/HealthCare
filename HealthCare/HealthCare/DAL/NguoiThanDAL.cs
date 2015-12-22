using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthCare.DTO;
using System.Data;

namespace HealthCare.DAL
{
    public class NguoiThanDAL
    {
        DataHelper helper = new DataHelper();
        public DataTable getListNguoiThan(string bn)
        {
            DataTable table = null;
            table = helper.executeQuery(String.Format("Select BenhNhan.* from NguoiThan, BenhNhan Where NguoiThan.NguoiThan = BenhNhan.TenDangNhap and NguoiThan.BenhNhan = '{0}'", bn));
            return table;
        }

        public DataTable findNguoiThan(string name, string bn)
        {
            //return helper.executeQueryFindNguoiThan(name, bn);
            DataTable table = null;
            table = helper.executeQuery(String.Format("Select BN.*"+
                                                       "From BenhNhan BN "+
                                                       "Where BN.TenBenhNhan like '%{0}%' and BN.TenDangNhap != '{1}' "+
                                                        "and BN.TenDangNhap not in (Select NT.NguoiThan "+
																                    "From NguoiThan NT "+
																                    "Where NT.BenhNhan = '{1}')", name, bn));
            return table;
        }

        public bool addNguoiThan(string bn, string nt)
        {
            helper.executeNonQuery(string .Format("insert into NguoiThan values ('{0}','{1}', 'Than')",bn, nt));
            return true;
        }
    }

}
