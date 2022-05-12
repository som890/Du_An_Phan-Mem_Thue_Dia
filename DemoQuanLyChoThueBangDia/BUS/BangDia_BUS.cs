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
    public class BangDia_BUS
    {
        BangDia_DAO bangDia = new BangDia_DAO();

        public DataTable GetList()
        {
            return bangDia.loadDia();
        }
        public bool Xoa(string mS)
        {
            return bangDia.Delete(mS);

        }
        public bool Sua(BangDia bd)
        {
            if (string.IsNullOrEmpty(bd.MaDia))
                return false;
            bangDia.Update(bd);
            return true;
        }
        public bool Them(BangDia bd)
        {
            if (string.IsNullOrEmpty(bd.MaDia))
                return false;
            if (!bangDia.Insert(bd))
                return true;
            return true;
        }
        public DataTable TimKiem(string _timkiem, string _loaitk)
        {
            return bangDia.Search(_timkiem, _loaitk);
        }
    }
}
