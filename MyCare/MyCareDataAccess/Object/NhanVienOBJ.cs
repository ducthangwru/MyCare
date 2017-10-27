using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCare.MyCareDataAccess.Object
{
    public class NhanVienOBJ
    {
        public NhanVienOBJ()
        {
            idtaikhoan = 0;
            idnhomtk = 0;
            tendangnhap = "";
            tennhanvien = "";
            matkhau = "";
            trangthai = 0;
        }

        public int idtaikhoan { get; set; }
        public int idnhomtk { get; set; }
        public string tennhanvien { get; set; }
        public string tendangnhap { get; set; }
        public string matkhau { get; set; }
        public int trangthai { get; set; }
    }
}
