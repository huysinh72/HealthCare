using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HealthCare.DAL
{
    public class KhamDinhKyDAL
    {
        DataHelper helper = new DataHelper();
        public bool saveDuLieuKham(string maBN, int ntim, string cxuc)
        {
            string query = String.Format("Insert into KhamDinhKy values('{0}', {1}, N'{2}', '{3}')",maBN , ntim, cxuc, DateTime.Now.ToShortDateString());
            helper.executeNonQuery(query);
            return true;
        }
    }
}
