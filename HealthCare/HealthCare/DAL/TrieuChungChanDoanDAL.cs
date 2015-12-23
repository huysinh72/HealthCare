using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthCare.DTO;
using System.Data;
using System.Windows.Forms;

namespace HealthCare.DAL
{
    
    public class TrieuChungChanDoanDAL
    {
        DataHelper helper = new DataHelper();

        private TrieuChung GetTrieuChungFromDataRow(DataRow row)
        {
            
            TrieuChung tc = new TrieuChung();
            tc.TenTrieuChung = row["TenTrieuChung"].ToString().Trim();
            tc.MaTrieuChung = int.Parse(row["MaTrieuChung"].ToString());

            return tc;
        }

        public TrieuChung[] getListTrieuChung(string ViTri)
        {
            TrieuChung[] listTrieuChung = null;
            DataTable table = null;
            string command = "select TC.* from ViTriBenh VT LEFT JOIN TrieuChung_ViTri VTTC ON VT.MaViTri =VTTC.MaViTri " + 
                "LEFT JOIN TrieuChung TC ON TC.MaTrieuChung=VTTC.MaTrieuChung WHERE VT.TenViTri=N'" + ViTri+"'";
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
    }
}
