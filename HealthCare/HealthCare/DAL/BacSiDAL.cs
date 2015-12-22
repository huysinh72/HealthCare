using HealthCare.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCare.DAL
{
    public class BacSiDAL
    {
        DataHelper helper = new DataHelper();
        private BacSi GetBacSiFromDataRow(DataRow row)
        {

            BacSi b = new BacSi();
            b.MaBacSi = row["MaBacSi"].ToString().Trim();
            b.TenBacSi = row["TenBacSi"].ToString().Trim();
            b.BangCap = row["BangCap"].ToString().Trim();
            b.DiaChi = row["DiaChi"].ToString().Trim();
            b.DienThoai = row["DienThoai"].ToString().Trim();
            b.Email = row["Email"].ToString().Trim();
            b.GioiTinh = row["GioiTinh"].ToString().Trim();
            b.NgaySinh = DateTime.Parse(row["NgaySinh"].ToString()).ToShortDateString();
            return b;
        }
        public string[] getDSChuyenNganh()
        {
            string[] listChuyenNganh = null;

            DataTable table = null;
            string command = "SELECT BS.ChuyenNganh FROM BacSi BS GROUP BY BS.ChuyenNganh";
            table = helper.executeQuery(command);

            if (table.Rows.Count == 0)
                return null;

            listChuyenNganh = new string[table.Rows.Count];

            for (int i = 0; i < table.Rows.Count; i++)
            {
                listChuyenNganh[i] = table.Rows[i]["ChuyenNganh"].ToString().Trim();
            }

            return listChuyenNganh;
        }
        public BacSi[] getDSBacSiByChuyenNganh(string BC)
        {
            BacSi[] listBS = null;

            DataTable table = null;
            string command = "SELECT * FROM BacSi BS Where BS.ChuyenNganh = N'" + BC + "'";
            table = helper.executeQuery(command);

            if (table.Rows.Count == 0)
                return null;

            listBS = new BacSi[table.Rows.Count];

            for (int i = 0; i < table.Rows.Count; i++)
            {
                listBS[i] = GetBacSiFromDataRow(table.Rows[i]);
            }

            return listBS;
        }
        public BacSi[] getDSBacSi()
        {
            BacSi[] listBS = null;

            DataTable table = null;
            string command = "SELECT * FROM BacSi";
            table = helper.executeQuery(command);

            if (table.Rows.Count == 0)
                return null;

            listBS = new BacSi[table.Rows.Count];

            for (int i = 0; i < table.Rows.Count; i++)
            {
                listBS[i] = GetBacSiFromDataRow(table.Rows[i]);
            }

            return listBS;
        }
        public BacSi getBacSiByMaBS(string MaBS)
        {
            BacSi res = new BacSi();

            DataTable table = null;
            string command = "SELECT * FROM BacSi BS WHERE BS.MaBacSi=N'" + MaBS + "'";
            table = helper.executeQuery(command);

            if (table.Rows.Count == 0)
                return null;

            res = GetBacSiFromDataRow(table.Rows[0]);


            return res;
        }
    }
}
