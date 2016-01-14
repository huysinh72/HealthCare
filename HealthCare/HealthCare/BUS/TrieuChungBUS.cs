using HealthCare.DAL;
using HealthCare.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HealthCare.BUS
{
    public class TrieuChungBUS
    {
        TrieuChungDAL dal = new TrieuChungDAL();
        public bool addTrieuChung(TrieuChung tc, string maVT)
        {
            return dal.addTrieuChung(tc, maVT);
        }
    }
}
