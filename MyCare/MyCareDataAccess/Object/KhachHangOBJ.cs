using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCare.MyCareDataAccess.Object
{
    public class KhachHangOBJ
    {
        public KhachHangOBJ()
        {
            idkhachhang = 0;
            tenkhachhang = "";
            diachi = "";
            sdt = "";
            trangthai = 0;
        }

        public int idkhachhang { get; set; }
        public string tenkhachhang { get; set; }
        public string diachi { get; set; }
        public string sdt { get; set; }
        public int trangthai { get; set; }
    }
}
