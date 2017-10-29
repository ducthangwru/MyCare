using MyCare.MyCareDataAccess.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCare.MyCareDataAccess.DataAcess
{
    public class HoaDonDB
    {

        private static SqlDataHelper db = new SqlDataHelper();
        public HoaDonDB() { }

        public static string GetIDHoaDon(int idnhanvien)
        {
            try
            {
                SqlParameter[] param = new SqlParameter[]
                {
                    new SqlParameter("@idnhanvien", idnhanvien)
                };
                
                return db.ExecuteScalar("sp_MyCareDesktop_LayIDHoaDonTiepTheo", param).ToString();
            }
            catch(Exception ex)
            {
                return "0";
            }
        }

        public static int ThemHoaDon(int idnhanvien, int idkhachhang, double tongtien, string ghichu)
        {
            try
            {
                SqlParameter[] param = new SqlParameter[]
                {
                    new SqlParameter("@idnhanvien", idnhanvien),
                    new SqlParameter("@idkhachhang", idkhachhang),
                    new SqlParameter("@tongtien", tongtien),
                    new SqlParameter("@ghichu", ghichu)
                };

                return int.Parse(db.ExecuteScalar("sp_MyCareDesktop_ThemHoaDon", param).ToString());
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public static bool ThemChiTietHoaDonNhapKho(int idthuoc, int idhoadon, int soluongthem, double giaban, int donvi, string ghichu)
        {
            try
            {
                SqlParameter[] param = new SqlParameter[]
                {
                    new SqlParameter("@idthuoc", idthuoc),
                    new SqlParameter("@idhoadon", idhoadon),
                    new SqlParameter("@soluongthem", soluongthem),
                    new SqlParameter("@giaban", giaban),
                    new SqlParameter("@donvi", donvi),
                    new SqlParameter("@ghichu", ghichu)
                };

                return db.ExecuteNonQuery("sp_MyCareDesktop_ThemSoLuongThuocQlyKho", param) > 0;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public static bool ThemChiTietHoaDonXuatKho(int idthuoc, int idhoadon, int soluongthem, double giaban, int donvi, string ghichu)
        {
            try
            {
                SqlParameter[] param = new SqlParameter[]
                {
                    new SqlParameter("@idthuoc", idthuoc),
                    new SqlParameter("@idhoadon", idhoadon),
                    new SqlParameter("@soluongthem", soluongthem),
                    new SqlParameter("@giaban", giaban),
                    new SqlParameter("@donvi", donvi),
                    new SqlParameter("@ghichu", ghichu)
                };

                return db.ExecuteNonQuery("sp_MyCareDesktop_XuatSoLuongThuocQlyKho", param) > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool KiemTraChiTietHoaDon(int idhoadon)
        {
            try
            {
                return bool.Parse(db.ExecuteScalar("sp_MyCareDesktop_KiemTraChiTietHoaDon", new SqlParameter("@idhoadon", idhoadon)).ToString());
            }
            catch(Exception ex)
            {
                return false;
            }
        }

    }
}
