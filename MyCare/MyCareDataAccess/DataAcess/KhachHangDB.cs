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
                dt = db.ExecuteDataSet("sp_MyCareDesktop_DanhSachKhachHang", new SqlParameter("@timkiem", timkiem)).Tables[0];
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

        public static DataTable DanhSachGoiYKhachHang(string sdt)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = db.ExecuteDataSet("sp_MyCareDesktop_DanhSachGoiYKhachHang", new SqlParameter("@sdt", sdt)).Tables[0];
                return dt;
            }
            catch (Exception ex)
            {
                return dt;
            }
        }

        public static DataTable DanhSachChonKhachHang(string timkiem)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = db.ExecuteDataSet("select * from v_DanhSachChonKhachHang").Tables[0];
                dt.Rows.Add(0, "Khách hàng mới", "", "");
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

        public static int ThemMoiKhachHang(string tenkhachhang, string diachi, string sdt)
        {
            try
            {
                SqlParameter[] param = new SqlParameter[]
                {
                    new SqlParameter("@tenkhachhang", tenkhachhang),
                    new SqlParameter("@diachi", diachi),
                    new SqlParameter("@sdt", sdt)
                };

                return int.Parse(db.ExecuteScalar("sp_MyCareDesktop_ThemMoiKhachHang", param).ToString());
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
    }
}
