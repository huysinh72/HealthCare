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
            bn.MatKhau = row["MatKhau"].ToString().Trim();
            bn.TenNguoiDung = row["TenBenhNhan"].ToString().Trim();
            bn.NgaySinh = DateTime.Parse(row["NgaySinh"].ToString()).ToShortDateString();
            bn.GioiTinh = row["GioiTinh"].ToString().Trim();
            bn.Email = row["Email"].ToString().Trim();
            bn.DienThoai = row["DienThoai"].ToString().Trim();
            bn.DiaChi = row["DiaChi"].ToString().Trim();
            //bn.NhanBaiDang = int.Parse(row["NhanBaiDang"].ToString());          
            return bn;
        }

        public BenhNhan getBenhNhan(string tenDN)
        {
            BenhNhan bn = null;
            DataTable table = null;
            table = helper.executeQuery(String.Format("Select * from BenhNhan where BenhNhan.TenDangNhap = '{0}'", tenDN));

            if (table.Rows.Count == 0)
                return null;

            bn = new BenhNhan();

            for (int i = 0; i < table.Rows.Count; i++)
            {
                bn = GetBenhNhanFromDataRow(table.Rows[i]);
            }

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

        public BenhNhan GetThongTinTaiKhoan(string tenDangNhap)
        {
            DataTable table = null;
            table = helper.executeQuery(String.Format("Select * from BenhNhan where [TenDangNhap] = '{0}'", tenDangNhap));

            if (table.Rows.Count != 0)
                return GetBenhNhanFromDataRow(table.Rows[0]);
            return null;
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
            string query = String.Format("select top 50 kdk.* from KhamDinhKy kdk where kdk.MaBenhNhan = '{0}'", tenDangNhap);
            DataTable res = helper.executeQuery(query);
            return res;
        }

        public DataTable getDuLieuKhamVaBenh(string tenDangNhap)
        {
            string query = String.Format("select top 50 dlk.*, b.TenBenh from DuLieuKham dlk, ChiTietKham ctk, Benh b " +
                "where dlk.MaDuLieuKham = ctk.DuLieuKham and ctk.BenhNhan = '{0}' and dlk.BenhChanDoan = b.MaBenh", tenDangNhap);
            DataTable res = helper.executeQuery(query);
            return res;
        }

        public bool deleteBenhNhan(string maBN)
        {
            string query = String.Format("Delete from BenhNhan where BenhNhan.TenDangNhap = '{0}'", maBN);
            helper.executeNonQuery(query);
            return true;
        }
    }
}
