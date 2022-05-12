using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHang
    {
        public KhachHang(string maKhach, string tenKhach, string diaChi, string dienThoai, string gioiTinh, string namSinh)
        {
            MaKhach = maKhach;
            TenKhach = tenKhach;
            DiaChi = diaChi;
            DienThoai = dienThoai;
            GioiTinh = gioiTinh;
            NamSinh = namSinh;
        }

        public string MaKhach { get; set; }
        public string TenKhach { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public string GioiTinh { get; set; }
        public string NamSinh { get; set; }
      
    }
}
