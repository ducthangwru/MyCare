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
        public static DataTable DanhSachHoatDongGanDay(int idnhanvien, string timkiem)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlParameter[] param = new SqlParameter[]
                {
                    new SqlParameter("@idnhanvien", idnhanvien),
                    new SqlParameter("@timkiem", timkiem)
                };

                dt = db.ExecuteDataSet("sp_MyCareDesktop_DanhSachHoatDongGanDay", param).Tables[0];
                dt.Columns.Add("ThanhTien");
                dt.Columns.Add("NgayLap");
                foreach (DataRow dr in dt.Rows)
                {
                    dr["ThanhTien"] = Utils.Utils.DinhDangTienTe(dr["TongTien"].ToString()) + " VNĐ";
                    dr["NgayLap"] = DateTime.Parse(dr["NgayTaoHD"].ToString()).ToString("dd/MM/yyyy HH:mm:ss");
                }

                return dt;
            }
            catch(Exception ex)
            {
                return dt;
            }
        }
    }
}
