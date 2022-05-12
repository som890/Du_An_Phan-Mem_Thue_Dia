using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BangDia
    {

        public BangDia() { }
        public BangDia(string maDia, string tenDia, string theLoai, string danhMuc, float soLuong, float donGia)
        {
            MaDia = maDia;
            TenDia = tenDia;
            TheLoai = theLoai;
            DanhMuc = danhMuc;
            SoLuong = soLuong;
            DonGia = donGia;
        }

        public string MaDia { get; set; }
        public string TenDia { get; set; }
        public string TheLoai { get; set; }
        public string DanhMuc { get; set; }
        public float SoLuong { get; set; }
        public float DonGia { get; set; }
    }
}
