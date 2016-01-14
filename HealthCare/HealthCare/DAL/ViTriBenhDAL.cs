using HealthCare.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HealthCare.DAL
{
    public class ViTriBenhDAL
    {
        DataHelper helper = new DataHelper();
        public bool addViTriBenh(ViTriBenh vt)
        {
            string query = String.Format("Insert into ViTriBenh values(N'{0}')", vt.TenViTri);
            helper.executeNonQuery(query);
            return true;
        }
    }
}
