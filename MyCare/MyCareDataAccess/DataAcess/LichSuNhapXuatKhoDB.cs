using MyCare.MyCareDataAccess.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCare.MyCareDataAccess.DataAcess
{
    public class LichSuNhapXuatKhoDB
    {
        private static SqlDataHelper db = new SqlDataHelper();
        public LichSuNhapXuatKhoDB() { }
        public static DataTable DanhSachHoatDongGanDay(int idnhanvien)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = db.ExecuteDataSet("sp_MyCareDesktop_DanhSachHoatDongGanDay", new SqlParameter("@idnhanvien", idnhanvien)).Tables[0];
                return dt;
            }
            catch(Exception ex)
            {
                return dt;
            }
        }
    }
}
