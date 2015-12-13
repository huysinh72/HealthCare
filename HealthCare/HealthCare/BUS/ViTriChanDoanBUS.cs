using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthCare.DAL;
using HealthCare.DTO;
namespace HealthCare.BUS
{
    public class ViTriChanDoanBUS
    {
        ViTriChanDoanDAL dal = new ViTriChanDoanDAL();
        public string[] getListStringViTri()
        {
            return dal.getListStringViTri();
        }
        public ViTriChanDoan[] getListViTri()
        {
            return dal.getListViTri();
        }

    }
}
