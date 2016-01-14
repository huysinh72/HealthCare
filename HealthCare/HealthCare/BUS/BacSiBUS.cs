using HealthCare.DAL;
using HealthCare.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCare.BUS
{
    public class BacSiBUS
    {
        BacSiDAL dal = new BacSiDAL();
        public string[] getDSChuyenNganh()
        {
            return dal.getDSChuyenNganh();
        }
        public BacSi getBacSiByMaBS(string MaBS)
        {
            return dal.getBacSiByMaBS(MaBS);
        }
        public BacSi[] getDSBacSiByChuyenNganh(string CN)
        {
            return dal.getDSBacSiByChuyenNganh(CN);
        }
        public BacSi[] getDSBacSi()
        {
            return dal.getDSBacSi();
        }

        public bool addBacSi(BacSi bs)
        {
            return dal.addBacSi(bs);
        }

        public bool deleteBacSi(string maBS)
        {
            return dal.deleteBacSi(maBS);
        }
    }
}
