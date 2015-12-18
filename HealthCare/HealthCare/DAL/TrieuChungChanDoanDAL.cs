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

        private TrieuChungChanDoan GetTrieuChungFromDataRow(DataRow row)
        {
            
            TrieuChungChanDoan tc = new TrieuChungChanDoan();
            tc.TrieuChung = row["TenTrieuChung"].ToString().Trim();
            return tc;
        }

        public TrieuChungChanDoan[] getListTrieuChung(string ViTri)
        {
            TrieuChungChanDoan[] listTrieuChung = null;
            DataTable table = null;
            string command = "select * from ViTriBenh VT LEFT JOIN TrieuChung_ViTri VTTC ON VT.MaViTri =VTTC.MaViTri LEFT JOIN TrieuChung TC ON TC.MaTrieuChung=VTTC.MaTrieuChung WHERE VT.TenViTri=N'" + ViTri+"'";
            table = helper.executeQuery(command);

            if (table.Rows.Count == 0)
                return null;

            listTrieuChung = new TrieuChungChanDoan[table.Rows.Count];

            for (int i = 0; i < table.Rows.Count; i++)
            {
                listTrieuChung[i] = GetTrieuChungFromDataRow(table.Rows[i]);
            }

            return listTrieuChung;
        }

        public string[] getListStringTrieuChung(string ViTri)
        {

            
                string[] listTrieuChung = null;
                TrieuChungChanDoan[] listTrieuChungCD = getListTrieuChung(ViTri);

               
                if (listTrieuChungCD != null)
                {
                    listTrieuChung = new string[listTrieuChungCD.Length];
                    for (int i = 0; i < listTrieuChungCD.Length; i++)
                        listTrieuChung[i] = listTrieuChungCD[i].TrieuChung;
                }
                return listTrieuChung;

            
        }

    }
}
