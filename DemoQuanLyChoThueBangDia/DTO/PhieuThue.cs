using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuThue
    {
       
        public PhieuThue() { }

        public string MaPhieuThue { get; set; }
        public string MaKhach { get; set; }
        public DateTime NgayThue { get; set; }
        public string MaQuanLy { get; set; }
        public string MaDia { get; set; }
        public float SoLuong { get; set; }
        public DateTime HanTra { get; set; }
        public float ThanhTien { get; set; }
    }
}
