using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCare.DTO
{
    public class ViTriTrieuChung
    {
        private string _ViTri;
        private string _TrieuChung;

        public string ViTri
        {
            get { return _ViTri; }
            set
            {
                _ViTri = value;
            }
        }
        public string TrieuChung
        {
            get { return _TrieuChung; }
            set { _TrieuChung = value; }
        }

        public static bool operator !=(ViTriTrieuChung c1, ViTriTrieuChung c2) 
        {
            if ( c1.TrieuChung==c2.TrieuChung && c1.ViTri==c2.ViTri ) return false;
            return true;
        }

        public static bool operator ==(ViTriTrieuChung c1, ViTriTrieuChung c2)
        {
            if (c1.TrieuChung == c2.TrieuChung && c1.ViTri == c2.ViTri) return true;
            return false;
        }


    }
}
