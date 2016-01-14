using HealthCare.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HealthCare.BUS
{
    public class KhamDinhKyBUS
    {
        KhamDinhKyDAL dal = new KhamDinhKyDAL();
        public bool SaveDuLieuKham(string maBN, int ntim, string cxuc)
        {
            return dal.saveDuLieuKham(maBN, ntim, cxuc);
        }
    }
}
