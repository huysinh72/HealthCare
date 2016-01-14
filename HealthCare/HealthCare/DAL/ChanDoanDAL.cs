using HealthCare.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCare.DAL
{
    class ChanDoanDAL
    {
        DataHelper helper = new DataHelper();

        private TrieuChung GetTrieuChungFromDataRow(DataRow row)
        {

            TrieuChung tc = new TrieuChung();
            tc.TenTrieuChung = row["TenTrieuChung"].ToString().Trim();
            tc.MaTrieuChung = int.Parse(row["MaTrieuChung"].ToString());

            return tc;
        }

        public TrieuChung[] getListTrieuChung(string maViTri)
        {
            TrieuChung[] listTrieuChung = null;
            DataTable table = null;
            string command = "select TC.* from TrieuChung_ViTri TCVT, TrieuChung TC " +
                "WHERE TCVT.MaViTri=N'" + maViTri + "' and TCVT.MaTrieuChung = TC.MaTrieuChung";
            table = helper.executeQuery(command);

            if (table.Rows.Count == 0)
                return null;

            listTrieuChung = new TrieuChung[table.Rows.Count];

            for (int i = 0; i < table.Rows.Count; i++)
            {
                listTrieuChung[i] = GetTrieuChungFromDataRow(table.Rows[i]);
            }

            return listTrieuChung;
        }

        private ViTriBenh GetViTriFromDataRow(DataRow row)
        {
            ViTriBenh vt = new ViTriBenh();
            vt.MaViTri = row["MaViTri"].ToString().Trim();
            vt.TenViTri = row["TenViTri"].ToString().Trim();
            return vt;
        }

        public ViTriBenh[] getListViTri()
        {
            ViTriBenh[] listViTri = null;
            DataTable table = null;
            table = helper.executeQuery("Select * from ViTriBenh");

            if (table.Rows.Count == 0)
                return null;

            listViTri = new ViTriBenh[table.Rows.Count];

            for (int i = 0; i < table.Rows.Count; i++)
            {
                listViTri[i] = GetViTriFromDataRow(table.Rows[i]);
            }

            return listViTri;
        }

        public string[] getListStringViTri()
        {

            string[] listViTri = null;
            ViTriBenh[] listViTriCD = getListViTri();

            listViTri = new string[listViTriCD.Length];

            for (int i = 0; i < listViTriCD.Length; i++)
                listViTri[i] = listViTriCD[i].TenViTri;

            return listViTri;
        }

        public Benh[] getListBenh(int maTc)
        {
            Benh[] listBenh = null;
            DataTable table = null;
            table = helper.executeQuery(String.Format("Select Benh.MaBenh, Benh.TenBenh, Benh.NoiDung, Benh.LoiKhuyen "+
            " from Benh, TrieuChung_Benh "+ 
            "Where TrieuChung_Benh.MaTrieuChung = '{0}' and Benh.MaBenh = TrieuChung_Benh.MaBenh", maTc));

            if (table.Rows.Count == 0)
                return null;

            listBenh = new Benh[table.Rows.Count];

            for (int i = 0; i < table.Rows.Count; i++)
            {
                listBenh[i] = new Benh();
                listBenh[i].maBenh = int.Parse(table.Rows[i]["MaBenh"].ToString());
                listBenh[i].noiDung = table.Rows[i]["NoiDung"].ToString().Trim();
                listBenh[i].loiKhuyen = table.Rows[i]["LoiKhuyen"].ToString().Trim();
                listBenh[i].tenBenh = table.Rows[i]["TenBenh"].ToString().Trim();            
            }
            return listBenh;
        }

        public int AddDuLieuKham(DuLieuKham dlk)
        {
            return helper.addDulieuKham(dlk);
        }

        public bool addTrieuChungKham(int maDLK, int maTC)
        {
            helper.executeNonQuery(String.Format("Insert into TrieuChungKham values({0}, {1})", maDLK, maTC));
            return true;
        }
    }
}
