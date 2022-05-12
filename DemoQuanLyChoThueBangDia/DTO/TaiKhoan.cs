using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoan
    {
        private string idAccount;
        private string useName;
        private string password;
        private string maQuanLy;

      

        public TaiKhoan() { }

        public string IdAccount { get => idAccount; set => idAccount = value; }
        public string UseName { get => useName; set => useName = value; }
        public string Password { get => password; set => password = value; }
        public string MaQuanLy { get => maQuanLy; set => maQuanLy = value; }
    }
}
