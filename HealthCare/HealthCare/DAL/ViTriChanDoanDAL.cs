using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthCare.DTO;
using System.Data;

namespace HealthCare.DAL
{
    public class ViTriChanDoanDAL
    {
        DataHelper helper = new DataHelper();

        private ViTriChanDoan GetViTriFromDataRow(DataRow row)
        {
            ViTriChanDoan vt = new ViTriChanDoan();
            vt.VT = row["TenViTri"].ToString().Trim();
            return vt;
        }

        public ViTriChanDoan[] getListViTri()
        {
            ViTriChanDoan[] listViTri = null;
            DataTable table = null;
            table = helper.executeQuery("Select * from ViTriChanDoan");

            if (table.Rows.Count == 0)
                return null;

            listViTri = new ViTriChanDoan[table.Rows.Count];

            for (int i = 0; i < table.Rows.Count; i++)
            {
                listViTri[i] = GetViTriFromDataRow(table.Rows[i]);
            }

            return listViTri;
        }
        
        public string[] getListStringViTri()
        {

            string[] listViTri = null;
            ViTriChanDoan[] listViTriCD = getListViTri();

            listViTri= new string[listViTriCD.Length];

            for (int i = 0; i < listViTriCD.Length; i++)
                listViTri[i] = listViTriCD[i].VT;
            
            return listViTri;
        }
    }
}
