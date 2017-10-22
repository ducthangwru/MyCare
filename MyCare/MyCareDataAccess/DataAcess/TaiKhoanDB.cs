﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCare.MyCareDataAccess.Utils;
using System.Data.SqlClient;
using System.Data;

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
    }
}
