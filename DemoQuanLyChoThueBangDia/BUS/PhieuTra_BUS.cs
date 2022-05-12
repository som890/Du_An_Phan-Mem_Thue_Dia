using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using DAO;
namespace BUS
{
    public class PhieuTra_BUS
    {
        PhieuTra_DAO ptDao = new PhieuTra_DAO();

        public DataTable GetList()
        {
            return ptDao.loadPhieuTra();
        }
        public bool CheckExist(string _table, string _str)
        {
            return ptDao.CheckExist(_table, _str);

        }
        public void Xoa(string mp)
        {
            ptDao.Delete(mp);
        }
        public bool Sua(PhieuTra pt)
        {
            if (string.IsNullOrEmpty(pt.MaPhieuGia))
                return false;
            ptDao.Update(pt);
            return true;
        }
        public int Them(PhieuTra pt)
        {
            if (string.IsNullOrEmpty(pt.MaPhieuGia))
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
