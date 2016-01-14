using HealthCare.DAL;
using HealthCare.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCare.BUS
{
    class ChanDoanBUS
    {
        ChanDoanDAL dal = new ChanDoanDAL();
        public string[] getListStringViTri()
        {
            return dal.getListStringViTri();
        }
        public ViTriBenh[] getListViTri()
        {
            return dal.getListViTri();
        }
        public TrieuChung[] getListTrieuChung(string ViTri)
        {
            return dal.getListTrieuChung(ViTri);
        }

        public Benh[] getListBenh(int maTc)
        {
            return dal.getListBenh(maTc);
        }

        public int addDulieuKham(DuLieuKham dlk)
        {
            return dal.AddDuLieuKham(dlk);
        }

        public bool addTrieuChungKham(int maDLK, int maTC)
        {
            return dal.addTrieuChungKham(maDLK, maTC);
        }
    }
}
