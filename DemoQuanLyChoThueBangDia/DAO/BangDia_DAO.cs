using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
namespace DAO
{
    public class BangDia_DAO:DataProvider
    {

        public DataTable loadDia()
        {
            string sqlString = @"select * from tblBangDia";
            return GetData(sqlString);
        }
        public bool Insert(BangDia bd)
        {
            if (GetData("select* from tblBangDia where MaDia = '" + bd.MaDia + "'").Rows.Count > 0)
                return false;
            string sql = string.Format("Insert Into tblBangDia values(N'{0}',N'{1}',N'{2}',N'{3}','{4}','{5}')",
                bd.MaDia, bd.TenDia, bd.TheLoai, bd.DanhMuc, bd.SoLuong, bd.DonGia);

            Excute(sql);
            return true;
        }
        public bool Delete(string bd)
        {
            string sql = string.Format("delete from tblBangDia where MaDia = '" + bd + "'");
            Excute(sql);
            return true;
        }

        public bool Update(BangDia bd)
        {
            string sql = string.Format("update tblbangDia set TenDia = N'{0}', TheLoai = N'{1}', DanhMuc = N'{2}', SoLuong = '{3}', DonGia = '{4}' where MaDia = '{5}'",
                bd.TenDia, bd.TheLoai, bd.DanhMuc, bd.SoLuong, bd.DonGia, bd.MaDia);
            Excute(sql);
            return true;
        }
        public DataTable Search(string _timkiem, string _loaitk)
        {
            string sqlString = string.Format("select * from tblBangDia where {0} like N'%{1}%'", _loaitk, _timkiem);
            return GetData(sqlString);
        }

    }
}
