using HealthCare.DAL;
using HealthCare.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HealthCare.BUS
{
    public class ViTriBenhBUS
    {
        ViTriBenhDAL dal = new ViTriBenhDAL();
        public bool addViTriBenh(ViTriBenh vt)
        {

            dal.addViTriBenh(vt);
            return true;
        }

    }
}
