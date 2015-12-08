using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCare.DTO
{
    public class NguoiDung
    {
        public string TenDangNhap { get; set;}
        public string MatKhau { get; set; }
        public string TenNguoiDung { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string Email { get; set; }
        public string DienThoai { get; set; }
        public int NhanBaiDang { get; set; }
        public int LoaiNguoiDung { get; set; }

    }
}
