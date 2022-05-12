using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class TaiKhoan_DAO:DataProvider
    {
        public bool login(string tk, string mk)
        {
            if (GetData("select tblTaiKhoan.MaTaiKhoan, tblTaiKhoan.TenTaiKhoan, tblTaiKhoan.MatKhau from tblTaiKhoan where TenTaiKhoan = '" + tk + "' and MatKhau = '" + mk + "'").Rows.Count > 0)
                return true;
            return false;
        }
    }
}
