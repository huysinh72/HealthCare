using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthCare.DTO;
using HealthCare.DAL;

namespace HealthCare.BUS
{
    public class BenhBUS
    {
        BenhDAL dal = new BenhDAL();
        public Benh[] getListBenh(string ViTri, string TrieuChung)
        {
            return dal.getListBenh(ViTri, TrieuChung);
        }
        public Benh getBenhByName(string name)
        {
            return dal.getBenhByName(name);
            
        }
        public List<Benh> updateListBenh(List<ViTriTrieuChung> listTC)
        {
            List<Benh> listBenh = new List<Benh>();
            BenhBUS bus = new BenhBUS();
            foreach (ViTriTrieuChung i in listTC)
            {
                Benh[] list = null;
                list = bus.getListBenh(i.ViTri, i.TrieuChung);
                if (list != null)
                    foreach (Benh a in list)
                    {
                        bool kt = listBenh.Exists(x => x.TenBenh == a.TenBenh);
                        if (!kt)
                        {
                            listBenh.Add(a);

                        }
                    }
            }
            return listBenh;
        }
    }
}
