using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthCare.DTO;
using System.Data;

namespace HealthCare.DAL
{
    public class BenhNhanDAL
    {
        DataHelper helper = new DataHelper();

        private BenhNhan GetBenhNhanFromDataRow(DataRow row)
        {
            BenhNhan bn = new BenhNhan();
            bn.TenDangNhap = row["TenDangNhap"].ToString().Trim();
            bn.MatKhau = row["TenSP"].ToString().Trim();
            bn.TenNguoiDung = row["TenNguoiDung"].ToString().Trim();
            bn.NgaySinh = DateTime.Parse(row["NgaySinh"].ToString());
            bn.GioiTinh = row["GioiTinh"].ToString().Trim();
            bn.Email = row["Email"].ToString().Trim();
            bn.DienThoai = row["DienThoai"].ToString().Trim();
            bn.NhanBaiDang = int.Parse(row["NhanBaiDang"].ToString());
            bn.LoaiNguoiDung = int.Parse(row["LoaiNguoiDung"].ToString());
            NguoiDung nd = new NguoiDung();
            
            return bn;
        }

        public BenhNhan[] getListBenhNhan()
        {
            BenhNhan[] listBenhNhan = null;
            DataTable table = null;
            table = helper.executeQuery("Select * from NguoiDung");

            if (table.Rows.Count == 0)
                return null;

            listBenhNhan = new BenhNhan[table.Rows.Count];

            for (int i = 0; i < table.Rows.Count; i++)
            {
                listBenhNhan[i] = GetBenhNhanFromDataRow(table.Rows[i]);
            }

            return listBenhNhan;
        }

        public bool hasBenhNhan(string tenDangNhap, string MatKhau)
        {

            DataTable table = null;
            table = helper.executeQuery(String.Format("Select * from NguoiDung where [TenDangNhap] = '{0}' and [MatKhau] = '{1}'", tenDangNhap, MatKhau));

            if (table.Rows.Count == 0)
                return false;
            return true;
        }

        public bool addBenhNhan(BenhNhan product)
        {
            string query = "aa";
            try
            {
                helper.executeNonQuery(query);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
