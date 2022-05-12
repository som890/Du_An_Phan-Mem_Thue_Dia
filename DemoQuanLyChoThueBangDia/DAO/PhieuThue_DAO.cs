using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAO
{
    public class PhieuThue_DAO : DataProvider
    {
        public DataTable loadPhieuThue()
        {
            string sqlString = @"select PT.MaPhieuThue, PT.MaKhach, KH.TenKhach, PT.NgayThue, PT.MaQuanLy, QL.TenQuanLy, PT.MaDia, BD.TenDia, BD.DonGia, PT.SoLuong, PT.HanTra, PT.ThanhTien from tblPhieuThue PT, tblBangDia BD, tblKhachHangg KH, tblAdmin QL where PT.MaKhach = KH.MaKhach and PT.MaDia = BD.MaDia and PT.MaQuanLy = QL.MaQuanLy";
            return GetData(sqlString);
        }
        public bool CheckExist(string _table, string _str)
        {
            if (_table == "tblKhachHangg")
                if (GetData("select* from tblKhachHangg where MaKhach = '" + _str + "'").Rows.Count > 0)
                    return true;
            if (_table == "tblBangDia")
                if (GetData("select* from tblBangDia where MaDia = '" + _str + "'").Rows.Count > 0)
                    return true;
            if (_table == "tblBangDia")
                if (GetData("select SoLuong from tblBangDia where MaDia = '" + _str + "'").Rows.Count > 0)
                    return true;
            if (_table == "tblAdmin")
                if (GetData("select* from tblAdmin where MaQuanLy = '" + _str + "'").Rows.Count > 0)
                    return true;
            return false;
        }

        public bool Insert(PhieuThue pt)
        {
            if (GetData("select * from tblPhieuThue where MaPhieuThue = '" + pt.MaPhieuThue + "'").Rows.Count > 0)
                return false;
            string sql = string.Format("Insert Into tblPhieuThue values('{0}','{1}','{2}','{3}','{4}','{5}','{6}',{7})",
                pt.MaPhieuThue, pt.MaKhach, pt.NgayThue, pt.MaQuanLy, pt.MaDia,pt.SoLuong,pt.HanTra, pt.ThanhTien);

            Excute(sql);
            return true;
        }
        public bool kiemTra(string table,PhieuThue pt)
        {
            if (table == "tblBangDia")
                if (GetData("SELECT SoLuong FROM tblBangDia WHERE MaDia = N'" + pt.MaDia + "'").Rows.Count > 0)
                    return true;
            return false;

        }

        public void Delete(string _pm)
        {
            Excute("delete from tblPhieuThue where MaPhieuThue = '" + _pm + "'");
        }

        public bool Update(PhieuThue pt)
        {
            string sql = string.Format("update tblPhieuThue set MaKhach = N'{0}', NgayThue = N'{1}', MaQuanLy = '{2}', MaDia = '{3}', SoLuong = '{4}', HanTra = '{5}',ThanhTien = '{6}' where MaPhieuThue = '{7}'",
                pt.MaKhach, pt.NgayThue,pt.MaQuanLy, pt.MaDia, pt.SoLuong, pt.HanTra,pt.ThanhTien, pt.MaPhieuThue);
            Excute(sql);
            return true;
        }
        public DataTable Search(string _timkiem, string _loaitk)
        {
            string sqlString = string.Format("select PT.MaPhieuThue, PT.MaKhach, KH.TenKhach, PT.MaDia, BD.TenDia, PT.NgayThue, PT.HanTra PT.ThanhTien from tblPhieuThue PT, tblBangDia BD, tblKhachHangg KH where PT.MaKhach = KH.MaKhach and PT.MaDia = BD.MaDia and PT.{0} like N'%{1}%'", _loaitk, _timkiem);
            return GetData(sqlString);
        }
      
    }
}
