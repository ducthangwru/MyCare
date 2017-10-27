using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCare.MyCareDataAccess.Object
{
    public class ThuocOBJ
    {
        public ThuocOBJ()
        {
            IDDanhMuc = 0;
            IDDonVi = 0;
            IDThuoc = 0;
            TenThuoc = "";
            GiaNhap = 0;
            GiaXuat = 0;
            NoiDung = "";
            TrangThai = 0;
            GhiChu = "";
        }
        public int IDDanhMuc { get; set; }
        public int IDDonVi { get; set; }
        public int IDThuoc { get; set; }
        public string TenThuoc { get; set; }
        public double GiaNhap { get; set; }
        public double GiaXuat { get; set; }
        public string NoiDung { get; set; }
        public int TrangThai { get; set; }
        public string GhiChu { get; set; }
    }
}
