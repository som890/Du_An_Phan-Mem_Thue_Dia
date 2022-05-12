using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class TaiKhoan_BUS
    {
        TaiKhoan_DAO tvDao = new TaiKhoan_DAO();
        public bool DangNhap(string tk, string mk)
        {
            if (tvDao.login(tk, mk) == true)
                return true;
            return false;
        }
    }
}
