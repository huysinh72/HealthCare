using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthCare.DTO;
using System.Data;

namespace HealthCare.DAL
{
    public    class BenhDAL
    {
        DataHelper helper = new DataHelper();
        private Benh GetBenhFromDataRow(DataRow row)
        {

            Benh b = new Benh();
            b.TenBenh = row["TenBenh"].ToString().Trim();
            b.NoiDung = row["NoiDung"].ToString().Trim();
            return b;
        }
        public Benh getBenhByName(string name)
        {
            DataTable table = null;
            string command = "select * from Benh where Benh.TenBenh=N'" + name + "'";
            table = helper.executeQuery(command);

            if (table.Rows.Count == 0)
                return null;

            Benh b=new Benh();
            b = GetBenhFromDataRow(table.Rows[0]);

            return b;
        }

        public Benh[] getListBenh(string ViTri, string TrieuChung)
        {
            Benh[] listBenh = null;
            DataTable table = null;
            string command = "select *from Benh B LEFT JOIN TrieuChungBenh TCB ON B.MaBenh=TCB.MaBenh LEFT JOIN ViTriTrieuChung VTTC ON VTTC.MaLienKet=TCB.MaTrieuChung LEFT JOIN TrieuChungChanDoan TCCD ON TCCD.MaTrieuChung=VTTC.MaTrieuChung LEFT JOIN ViTriChanDoan VTCD ON VTCD.MaViTri =VTTC.MaViTri WHERE VTCD.TenViTri=N'" + ViTri +"' AND TCCD.TenTrieuChung=N'" +TrieuChung + "'";
            table = helper.executeQuery(command);

            if (table.Rows.Count == 0)
                return null;

            listBenh = new Benh[table.Rows.Count];

            for (int i = 0; i < table.Rows.Count; i++)
            {
                listBenh[i] = GetBenhFromDataRow(table.Rows[i]);
            }

            return listBenh;
        }

    }
}
