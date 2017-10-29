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
    public class KhoThuocDB
    {
        private static SqlDataHelper db = new SqlDataHelper();
        public KhoThuocDB() { }
        public static DataTable DanhSachKhoThuoc(int idnhanvien, string timkiem)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlParameter[] param = new SqlParameter[]
                {
                    new SqlParameter("@idnhanvien", idnhanvien),
                    new SqlParameter("@timkiem", timkiem)
                };

                dt = db.ExecuteDataSet("sp_MyCareDesktop_DanhSachThuoc", param).Tables[0];
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

        public static DataTable DanhSachChonThuoc(int idnhanvien)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = db.ExecuteDataSet("sp_MyCareDesktop_DanhSachChonThuoc", new SqlParameter("@idnhanvien", idnhanvien)).Tables[0];
                dt.Rows.Add("0", "Tất cả");
                return dt;
            }
            catch (Exception ex)
            {
                return dt;
            }
        }

        public static bool KiemTraSoLuongThuoc(int idthuoc, int soluong)
        {
            try
            {
                return bool.Parse(db.ExecuteScalar(string.Format("select [dbo].[f_CheckSoLuongThuoc] ({0}, {1})", idthuoc, soluong)).ToString());
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public static int CapNhatThuoc(int idnhanvien, ThuocOBJ obj)
        {
            try
            {
                SqlParameter[] param = new SqlParameter[]
                {
                    new SqlParameter("@idnhanvien", idnhanvien),
                    new SqlParameter("@idthuoc", obj.IDThuoc),
                    new SqlParameter("@iddanhmuc", obj.IDDanhMuc), 
                    new SqlParameter("@iddonvi", obj.IDDonVi),
                    new SqlParameter("@giaban", obj.GiaXuat),
                    new SqlParameter("@gianhap", obj.GiaNhap),
                    new SqlParameter("@noidung", obj.NoiDung),
                    new SqlParameter("@ghichu", obj.GhiChu),
                    new SqlParameter("@trangthai", obj.TrangThai),
                    new SqlParameter("@tenthuoc", obj.TenThuoc)
                };

                return int.Parse(db.ExecuteScalar("sp_MyCareDesktop_CapNhatThuoc", param).ToString());
            }
            catch(Exception ex)
            {
                return 0;
            }
        }

        public static int ThemMoiThuoc(int idnhanvien, ThuocOBJ obj)
        {
            try
            {
                SqlParameter[] param = new SqlParameter[]
                {
                    new SqlParameter("@idnhanvien", idnhanvien),
                    new SqlParameter("@iddanhmuc", obj.IDDanhMuc),
                    new SqlParameter("@iddonvi", obj.IDDonVi),
                    new SqlParameter("@giaban", obj.GiaXuat),
                    new SqlParameter("@gianhap", obj.GiaNhap),
                    new SqlParameter("@noidung", obj.NoiDung),
                    new SqlParameter("@ghichu", obj.GhiChu),
                    new SqlParameter("@trangthai", obj.TrangThai),
                    new SqlParameter("@tenthuoc", obj.TenThuoc)
                };

                return int.Parse(db.ExecuteScalar("sp_MyCareDesktop_ThemMoiThuoc", param).ToString());
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public static DataTable LichSuThaoTacThuoc(int idnhanvien, int loctheothuoc, int loctheothaotac)
        {
            DataTable dt = new DataTable();
            
            try
            {
                SqlParameter[] param = new SqlParameter[]
               {
                    new SqlParameter("@idnhanvien", idnhanvien),
                    new SqlParameter("@loctheothuoc", loctheothuoc),
                    new SqlParameter("@loctheothaotac", loctheothaotac)
               };

                dt = db.ExecuteDataSet("sp_MyCareDesktop_LichSuThaoTacThuoc", param).Tables[0];
                dt.Columns.Add("NgayThaoTac");
                foreach (DataRow dr in dt.Rows)
                {
                    dr["NgayThaoTac"] = DateTime.Parse(dr["NgayTao"].ToString()).ToString("dd/MM/yyyy HH:mm:ss");
                }

                return dt;
            }
            catch (Exception ex)
            {
                return dt;
            }
        }

        public static DataTable LichSuThaoTacDanhMuc(int idnhanvien, int loctheodanhmuc, int loctheothaotac)
        {
            DataTable dt = new DataTable();

            try
            {
                SqlParameter[] param = new SqlParameter[]
               {
                    new SqlParameter("@idnhanvien", idnhanvien),
                    new SqlParameter("@loctheodanhmuc", loctheodanhmuc),
                    new SqlParameter("@loctheothaotac", loctheothaotac)
               };

                dt = db.ExecuteDataSet("sp_MyCareDesktop_LichSuThaoTacDM", param).Tables[0];
                dt.Columns.Add("NgayThaoTac");
                foreach (DataRow dr in dt.Rows)
                {
                    dr["NgayThaoTac"] = DateTime.Parse(dr["NgayTao"].ToString()).ToString("dd/MM/yyyy HH:mm:ss");
                }

                return dt;
            }
            catch (Exception ex)
            {
                return dt;
            }
        }
    }
}
