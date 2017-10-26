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
    public class DanhMucThuocDB
    {
        private static SqlDataHelper db = new SqlDataHelper();
        public DanhMucThuocDB() { }

        public static DataTable DanhSachDanhMuc(string timkiem)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = db.ExecuteDataSet("sp_MyCareDesktop_DanhSachDanhMuc", new SqlParameter("timkiem", timkiem)).Tables[0];
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

        public static bool ThemMoiDanhMuc(int idnhanvien, string tendanhmuc, int trangthai, string ghichu)
        {
            try
            {
                SqlParameter[] par = new SqlParameter[]
                {
                    new SqlParameter("@idnhanvien", idnhanvien),
                    new SqlParameter("@tendanhmuc", tendanhmuc),
                    new SqlParameter("@trangthai", trangthai),
                    new SqlParameter("@ghichu", ghichu)
                };

                return int.Parse(db.ExecuteScalar("sp_MyCareDesktop_ThemDanhMuc", par).ToString()) > 0;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public static bool CapNhatDanhMuc(int idnhanvien, int iddanhmuc, string tendanhmuc, int trangthai, string ghichu)
        {
            try
            {
                SqlParameter[] par = new SqlParameter[]
                {
                    new SqlParameter("@iddanhmuc", iddanhmuc),
                    new SqlParameter("@idnhanvien", idnhanvien),
                    new SqlParameter("@tendanhmuc", tendanhmuc),
                    new SqlParameter("@trangthai", trangthai),
                    new SqlParameter("@ghichu", ghichu)
                };

                return db.ExecuteNonQuery("sp_MyCareDesktop_CapNhatDanhMuc", par) > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
