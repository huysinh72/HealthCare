﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthCare.DAL;
using HealthCare.DTO;
namespace HealthCare.BUS
{
    public class TrieuChungChanDoanBUS
    {
        TrieuChungChanDoanDAL dal = new TrieuChungChanDoanDAL();
        public TrieuChung[] getListTrieuChung(string ViTri)
        {
            return dal.getListTrieuChung(ViTri);
        }

    }
}
