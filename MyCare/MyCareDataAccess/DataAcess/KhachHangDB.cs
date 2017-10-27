using MyCare.MyCareDataAccess.Object;
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
    public class KhachHangDB
    {
        private static SqlDataHelper db = new SqlDataHelper();
        public KhachHangDB() { }

        public static DataTable DanhSachKhachHang(string timkiem)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = db.ExecuteDataSet("sp_MyCareDesktop_DanhSachKhachHang", new SqlParameter("timkiem", timkiem)).Tables[0];
                dt.Columns.Add("TrangThai");
                dt.Columns.Add("NgayLap");
                foreach (DataRow dr in dt.Rows)
                {
                    dr["TrangThai"] = (bool.Parse(dr["TrangThaiXoa"].ToString())) ? "Hết hiệu lực" : "Còn hiệu lực";
                    dr["NgayLap"] = DateTime.Parse(dr["NgayTao"].ToString()).ToString("dd/MM/yyyy HH:mm:ss");
                }

                return dt;
            }
            catch (Exception ex)
            {
                return dt;
            }
        }

        public static int CapNhatKhachHang(KhachHangOBJ obj)
        {
            try
            {
                SqlParameter[] param = new SqlParameter[]
                {
                    new SqlParameter("@idkhachhang", obj.idkhachhang), 
                    new SqlParameter("@tenkhachhang", obj.tenkhachhang),
                    new SqlParameter("@diachi", obj.diachi),
                    new SqlParameter("@sdt", obj.sdt),
                    new SqlParameter("@trangthai", obj.trangthai)
                };

                return db.ExecuteNonQuery("sp_MyCareDesktop_CapNhatKhachHang", param);
            }
            catch(Exception ex)
            {
                return 0;
            }
        }
    }
}
