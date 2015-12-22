using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthCare.DTO;
using System.Data;

namespace HealthCare.DAL
{
    public class BaiDangDAL
    {
        DataHelper helper = new DataHelper();
        public BaiDangDTO[] GetListBaiDang()
        {
            DataTable table = null;
            table = helper.executeQuery("Select * from BaiDang");

            if (table.Rows.Count == 0)
                return null;
            BaiDangDTO[] bd = new BaiDangDTO[table.Rows.Count];
            for(int i = 0; i < table.Rows.Count; i++)
            {
                bd[i] = new BaiDangDTO();
                bd[i].MaBaiDang = int.Parse(table.Rows[i]["MaBaiDang"].ToString());
                bd[i].ChuDe = table.Rows[i]["TieuDe"].ToString().Trim();
                bd[i].NoiDung = table.Rows[i]["NoiDung"].ToString().Trim();
            }
            return bd;
        }

        public BaiDangDTO[] TimKiemBaiDang(string s)
        {
            DataTable table = null;
            table = helper.executeQuery(string.Format("Select * from BaiDang Where BaiDang.TieuDe like '%{0}%'", s));

            if (table.Rows.Count == 0)
                return null;
            BaiDangDTO[] bd = new BaiDangDTO[table.Rows.Count];
            for (int i = 0; i < table.Rows.Count; i++)
            {
                bd[i] = new BaiDangDTO();
                bd[i].MaBaiDang = int.Parse(table.Rows[i]["MaBaiDang"].ToString());
                bd[i].ChuDe = table.Rows[i]["TieuDe"].ToString().Trim();
                bd[i].NoiDung = table.Rows[i]["NoiDung"].ToString().Trim();
            }
            return bd;
        }
    }
}
