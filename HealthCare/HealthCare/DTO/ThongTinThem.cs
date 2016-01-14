using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCare.DTO
{
    public class ThongTinThem
    {
        private static ThongTinThem current;
        public int NhipTim  { get; set; }
        public string CamXuc { get; set; }
        public int ChieuCao { get; set; }
        public int CanNang { get; set; }

        public static ThongTinThem getInstance()
        {
           if(current == null)
           {
               current = new ThongTinThem();
               current.NhipTim = 0;
               current.ChieuCao = 0;
               current.CanNang = 0;
               current.CamXuc = "Vui";
           }
           return current;
        }

        public void delete()
        {
            current = null;
        }

    }
}
