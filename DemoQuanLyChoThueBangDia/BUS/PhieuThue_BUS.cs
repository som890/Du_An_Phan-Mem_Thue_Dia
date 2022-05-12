using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using System.Data;
namespace BUS
{
    public class PhieuThue_BUS
    {

        PhieuThue_DAO ptDao = new PhieuThue_DAO();
        public DataTable GetList()
        {
            return ptDao.loadPhieuThue();
        }
        public bool CheckExist(string _table, string _str)
        {
            return ptDao.CheckExist(_table, _str);

        }
        public void Xoa(string pt)
        {
             ptDao.Delete(pt);
        }
        public bool Sua(PhieuThue pt)
        {
            if (string.IsNullOrEmpty(pt.MaPhieuThue))
                return false;
            ptDao.Update(pt);
            return true;
        }
        public int Them(PhieuThue pt)
        {
            if (string.IsNullOrEmpty(pt.MaPhieuThue))
                return 0;
            if (!ptDao.Insert(pt))
                return -1;
            return 1;
        }
    public DataTable TimKiem(string _timkiem, string _loaitk)
       {
            return ptDao.Search(_timkiem, _loaitk);
        }
    }
}
