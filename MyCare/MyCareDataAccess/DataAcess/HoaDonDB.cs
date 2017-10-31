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

        public static DataTable XemHoaDon(int idhoadon)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = db.ExecuteDataSet("sp_MyCareDesktop_XemHoaDon", new SqlParameter("@idhoadon", idhoadon)).Tables[0];
                return dt;
            }
            catch(Exception ex)
            {
                return dt;
            }
        }
        public static DataTable XemHoaDonTheoKhachHang(int idkhachhang)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = db.ExecuteDataSet("select * from [dbo].f_XemHoaDonTheoKhachHang(" + idkhachhang + ")").Tables[0];
                dt.Columns.Add("ThanhTien");
                dt.Columns.Add("NgayLap");

                foreach(DataRow dr in dt.Rows)
                {
                    dr["ThanhTien"] = Utils.Utils.DinhDangTienTe(dr["TongTien"].ToString()) + " VNĐ";
                    dr["NgayLap"] = DateTime.Parse(dr["NgayTao"].ToString()).ToString("dd/MM/yyyy HH:mm:ss");
                }

                return dt;
            }
            catch (Exception ex)
            {
                return dt;
            }
        }


        public static DataTable XemChiTietHoaDon(int idhoadon)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = db.ExecuteDataSet("select * from [dbo].f_XemChiTietHoaDon(" + idhoadon + ")").Tables[0];
                dt.Columns.Add("ThanhTien");

                foreach(DataRow dr in dt.Rows)
                {
                    dr["ThanhTien"] = Utils.Utils.DinhDangTienTe(dr["TongTien"].ToString()) + " VNĐ";
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
