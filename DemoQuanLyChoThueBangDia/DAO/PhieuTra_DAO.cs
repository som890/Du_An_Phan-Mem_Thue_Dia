using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
namespace DAO
{
    public class PhieuTra_DAO :DataProvider
    {
        public DataTable loadPhieuTra()
        {
            string sqlString = @"select PT.MaPhieuGia, PT.SoLuong, PT.NgayTra, PT.MaKhachHang, KH.TenKhach, PT.MaDia, BD.TenDia,  PT.HanTra, PT.QuaHan, PT.PhatQuaHan, PT.SoDiaHuHong, PT.PhatHuHong, PT.ThanhTien from tblKhachHangg KH, tblPhieuGia PT, tblBangDia BD where PT.MaKhachHang = KH.MaKhach and PT.MaDia = BD.MaDia";
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
            return false;
        }

        public bool Insert(PhieuTra  pt)
        {
            if (GetData("select* from tblPhieuGia where MaPhieuGia = '" + pt.MaPhieuGia + "'").Rows.Count > 0)
                return false;
            string sql = string.Format("Insert Into tblPhieuGia values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')",
                pt.MaPhieuGia,pt.SoLuong, pt.NgayTra, pt.MaKhach, pt.MaDia, pt.HanTra, pt.QuaHan, pt.PhatQuaHan,pt.SoDiaHong,pt.PhatHuHong,pt.ThanhTien);

            Excute(sql);
            return true;
        }
        
        public void Delete(string pt)
        {
            Excute("delete from tblPhieuGia where MaPhieuGia = '" + pt + "'");
        }

        public void Update(PhieuTra pt)
        {
            string sql = string.Format("update tblPhieuGia set SoLuong = N'{0}', NgayTra = N'{1}', MaKhachHang = '{2}', MaDia = '{3}', HanTra = '{4}', QuaHan = '{5}', PhatQuaHan = '{6}', SoDiaHuHong = '{7}', PhatHuHong = '{8}', ThanhTien = '{9}' where MaPhieuGia = '{10}'",
                 pt.SoLuong, pt.NgayTra, pt.MaKhach, pt.MaDia, pt.HanTra, pt.QuaHan, pt.PhatQuaHan, pt.SoDiaHong, pt.PhatHuHong, pt.ThanhTien, pt.MaPhieuGia);
            Excute(sql);
        }
      
        public DataTable Search(string _timkiem, string _loaitk)
        {
            string sqlString = string.Format("select PT.MaPhieuGia, PT.MaKhachHang, KH.TenKhach, PT.MaDia, BD.TenDia, PT.NgayTra from tblKhachHangg KH, tblPhieuGia PT, tblBangDia BD where PT.MaKhachHang = KH.MaKhach and PT.MaDia = BD.MaDia and PT.{0} like N'%{1}%'", _loaitk, _timkiem);
            return GetData(sqlString);
        }
    
    }
}
