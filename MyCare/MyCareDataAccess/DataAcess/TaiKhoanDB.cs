using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCare.MyCareDataAccess.Utils;
using System.Data.SqlClient;
using System.Data;
using MyCare.MyCareDataAccess.Object;

namespace MyCare.MyCareDataAccess.DataAcess
{
    public class TaiKhoanDB
    {
        private static SqlDataHelper db = new SqlDataHelper();
        public TaiKhoanDB() { }
        public static bool DangNhap(string taikhoan, string matkhau)
        {
            string matkhaumd5 = Utils.Utils.md5(matkhau);
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@taikhoan", taikhoan),
                new SqlParameter("@matkhau", matkhaumd5)
            };

            DataTable dt = db.ExecuteDataSet("sp_MyCareDesktop_DangNhap", param).Tables[0];
            if(dt.Rows.Count > 0)
            {
                Config.IDNhanVien = int.Parse(dt.Rows[0]["ID"].ToString());
                if (Config.IDNhanVien >= 0)
                    return true;
            }

            return false;
        }

        public static bool LuuLichSuDangNhap(int idtaikhoan, int type)
        {
            SqlParameter[] param = new SqlParameter[]
              {
                    new SqlParameter("@idtaikhoan", idtaikhoan),
                    new SqlParameter("@type", type)
              };

            return db.ExecuteNonQuery("sp_MyCareDesktop_ThemLichSuDangNhap", param) > 0;
        }

        public static int ThemMoiTaiKhoan(int idnhanvien, NhanVienOBJ obj)
        {
            try
            {
                SqlParameter[] param = new SqlParameter[]
                {
                    new SqlParameter("@idnhanvien", idnhanvien),
                    new SqlParameter("@tennhanvien", obj.tennhanvien),
                    new SqlParameter("@tendangnhap", obj.tendangnhap),
                    new SqlParameter("@trangthai", obj.trangthai),
                    new SqlParameter("@matkhau", obj.matkhau),
                    new SqlParameter("@idnhomtk", obj.idnhomtk)
                };

                return int.Parse(db.ExecuteScalar("sp_MyCareDesktop_ThemMoiTaiKhoan", param).ToString());
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public static int CapNhatTaiKhoan(int idnhanvien, NhanVienOBJ obj)
        {
            try
            {
                SqlParameter[] par = new SqlParameter[]
                {
                    new SqlParameter("@idtaikhoan", obj.idtaikhoan),
                    new SqlParameter("@tendangnhap", obj.tendangnhap)
                };

                if (int.Parse(db.ExecuteScalar("sp_MyCare_KiemTraTenDangNhap", par).ToString()) == 0)
                    return -1;

                SqlParameter[] param = new SqlParameter[]
                {
                    new SqlParameter("@idnhanvien", idnhanvien),
                    new SqlParameter("@idtaikhoan", obj.idtaikhoan),
                    new SqlParameter("@tennhanvien", obj.tennhanvien),
                    new SqlParameter("@trangthai", obj.trangthai),
                    new SqlParameter("@matkhau", obj.matkhau),
                    new SqlParameter("@idnhomtk", obj.idnhomtk)
                };

                return int.Parse(db.ExecuteScalar("sp_MyCareDesktop_CapNhatTaiKhoan", param).ToString());
            }
            catch(Exception ex)
            {
                return 0;
            }
        }

        public static DataTable LichSuDangNhap(int idnhanvien, int loctheonhanvien, int loctheotrangthai)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlParameter[] param = new SqlParameter[]
                {
                    new SqlParameter("@idnhanvien", idnhanvien),
                    new SqlParameter("@loctheonhanvien", loctheonhanvien),
                    new SqlParameter("@loctheotrangthai", loctheotrangthai)
                };

                dt = db.ExecuteDataSet("sp_MyCareDesktop_LichSuDangNhap", param).Tables[0];
                dt.Columns.Add("TrangThai");
                dt.Columns.Add("ThoiGian");
                foreach (DataRow dr in dt.Rows)
                {
                    dr["TrangThai"] = (int.Parse(dr["Type"].ToString()) == Config.DANG_NHAP) ? "Đăng nhập" : "Đăng xuất";
                    dr["ThoiGian"] = DateTime.Parse(dr["NgayTao"].ToString()).ToString("dd/MM/yyyy HH:mm:ss");
                }

                return dt;
            }
            catch (Exception ex)
            {
                return dt;
            }
        }

        public static DataTable DanhSachNhanVien(string timkiem)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlParameter[] param = new SqlParameter[]
                {
                    new SqlParameter("@timkiem", timkiem)
                };

                dt = db.ExecuteDataSet("sp_MyCareDesktop_DanhSachTaiKhoan", param).Tables[0];
                dt.Columns.Add("TrangThai");
                dt.Columns.Add("NgayLap");
                foreach (DataRow dr in dt.Rows)
                {
                    dr["TrangThai"] = (bool.Parse(dr["TrangThaiXoa"].ToString())) ? "Vô hiệu hóa" : "Kích hoạt";
                    dr["NgayLap"] = DateTime.Parse(dr["NgayTao"].ToString()).ToString("dd/MM/yyyy HH:mm:ss");
                }

                return dt;
            }
            catch (Exception ex)
            {
                return dt;
            }
        }

        public static DataTable DanhSachQuyen()
        {
            DataTable dt = new DataTable();
            try
            {
                dt = db.ExecuteDataSet("sp_MyCareDesktop_DanhSachQuyen").Tables[0];
              
                return dt;
            }
            catch (Exception ex)
            {
                return dt;
            }
        }
    }
}
