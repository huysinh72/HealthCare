using HealthCare.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HealthCare.DAL
{
    public class TrieuChungDAL
    {
        DataHelper helper = new DataHelper();
        public bool addTrieuChung(TrieuChung tc, string maViTri)
        {
            return helper.addTrieuChung(tc, maViTri);
        }
    }
}
