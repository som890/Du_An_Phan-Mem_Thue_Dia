using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data;
namespace BUS
{
    public class KhachHang_BUS
    {
        KhachHang_DAO khDao = new KhachHang_DAO();
        public DataTable GetList()
        {
            return khDao.loadDocGia();
        }
        
        public bool Xoa(string mKH)
        {
          return  khDao.Delete(mKH);
        }
        public bool Sua(KhachHang  kh)
        {
            if (string.IsNullOrEmpty(kh.MaKhach))
                return false;
            khDao.Update(kh);
            return true;
        }
        public bool Them(KhachHang kh)
        {
            if (string.IsNullOrEmpty(kh.MaKhach))
                return false;
            if (!khDao.Insert(kh))
                return true;
            return true;
        }
        public DataTable TimKiem(string _timkiem)
        {
            return khDao.Search(_timkiem);
        }
        
    }
}
