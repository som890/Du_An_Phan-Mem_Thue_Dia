using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
namespace DAO
{
    public class KhachHang_DAO: DataProvider
    {
        public DataTable loadDocGia()
        {
            string sqlString = @"SELECT tblKhachHangg.MaKhach,tblKhachHangg.TenKhach,tblKhachHangg.DiaChi, tblKhachHangg.DienThoai,tblKhachHangg.GioiTinh,tblKhachHangg.NamSinh
                                FROM tblKhachHangg";
            
            return GetData(sqlString);
        }
      public bool Insert(KhachHang kh)
        {
            if (GetData("select* from tblKhachHangg where MaKhach = '" + kh.MaKhach + "'").Rows.Count > 0)
                return false;
            string sql = string.Format("Insert Into tblKhachHangg values('{0}','{1}','{2}','{3}','{4}','{5}')",
                kh.MaKhach, kh.TenKhach, kh.DiaChi, kh.DienThoai,kh.GioiTinh, kh.NamSinh);
               

            Excute(sql);
            return true;
    
        }
       public bool Delete(string maKH)
        {
            string sql = string.Format("delete from tblKhachHangg where MaKhach = '" + maKH + "'");
            Excute(sql);
            return true;
        }

        public bool Update(KhachHang kh)
        {
            string sql = string.Format("update tblKhachHangg set TenKhach = N'{0}', DiaChi= N'{1}', DienThoai = '{2}', GioiTinh = '{3}', NamSinh = '{4}' where MaKhach = '{5}'",
                kh.TenKhach, kh.DiaChi, kh.DienThoai,kh.GioiTinh,kh.NamSinh, kh.MaKhach);
            Excute(sql);
            return true;
        }
        public DataTable Search(string _timkiem)
        {
            string sqlString = string.Format("select * from tblKhachHangg where MaKhach like N'%{0}%'", _timkiem);
            return GetData(sqlString);
        }
     
    
    }
}
