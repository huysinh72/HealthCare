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
            bn.DiaChi = row["LoaiNguoiDung"].ToString();
             
            return bn;
        }

        public BenhNhan[] getListBenhNhan()
        {
            BenhNhan[] listBenhNhan = null;
            DataTable table = null;
            table = helper.executeQuery("Select * from BenhNhan");

            if (table.Rows.Count == 0)
                return null;

            listBenhNhan = new BenhNhan[table.Rows.Count];

            for (int i = 0; i < table.Rows.Count; i++)
            {
                listBenhNhan[i] = GetBenhNhanFromDataRow(table.Rows[i]);
            }

            return listBenhNhan;
        }

        public bool hasTaiKhoan(string tenDangNhap, string MatKhau)
        {

            DataTable table = null;
            table = helper.executeQuery(String.Format("Select * from BenhNhan where [TenDangNhap] = '{0}' and [MatKhau] = '{1}'", tenDangNhap, MatKhau));

            if (table.Rows.Count == 0)
                return false;
            return true;
        }

        public bool ktTrungTaiKhoan(string tenDangNhap)
        {

            DataTable table = null;
            table = helper.executeQuery(String.Format("Select * from BenhNhan where [TenDangNhap] = '{0}'", tenDangNhap));

            if (table.Rows.Count == 0)
                return false;
            return true;
        }

        public bool addBenhNhan(BenhNhan bn)
        {
            try
            {
                helper.executeNonQueryAddBenhNhan(bn);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable getDuLieuKham(string tenDangNhap)
        {
            string query = String.Format("select top 50 dlk.* from DuLieuKham dlk join ChiTietKham ctk on dlk.MaDuLieuKham = ctk.DuLieuKham where ctk.BenhNhan = '{0}'", tenDangNhap);
            DataTable res = helper.executeQuery(query);
            return res;
        }
    }
}
