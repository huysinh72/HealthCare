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
    }
}
