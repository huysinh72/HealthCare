using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCare.DTO
{
    public class Benh
    {
        string _TenBenh;
        string _NoiDung;
        public string TenBenh
        {
            set { _TenBenh = value; }
            get { return _TenBenh; }
        }

        public string NoiDung
        {
            set { _NoiDung = value; }
            get { return _NoiDung; }
        }

       
    }
}
