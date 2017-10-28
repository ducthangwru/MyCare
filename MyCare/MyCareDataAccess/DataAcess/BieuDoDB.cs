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
    public class BieuDoDB
    {
        private static SqlDataHelper db = new SqlDataHelper();
        public BieuDoDB() { }

        public static DataTable BieuDoThongKeHoaDon(string tungay, string denngay)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlParameter[] param = new SqlParameter[]
                {
                    new SqlParameter("@tungay", tungay),
                    new SqlParameter("@denngay", denngay)
                };

                dt = db.ExecuteDataSet("sp_MyCareDesktop_BieuDoHoaDon", param).Tables[0];
                dt.Columns.Add("NgayTao");

                foreach (DataRow dr in dt.Rows)
                {
                    dr["NgayTao"] = DateTime.Parse(dr["Ngay"].ToString()).ToString("dd/MM/yyyy");
                }
                return dt;
            }
            catch(Exception ex)
            {
                return dt;
            }
        }

        public static DataTable BieuDoThongKeDoanhThu(string tungay, string denngay)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlParameter[] param = new SqlParameter[]
                {
                    new SqlParameter("@tungay", tungay),
                    new SqlParameter("@denngay", denngay)
                };

                dt = db.ExecuteDataSet("sp_MyCareDesktop_BieuDoDoanhThu", param).Tables[0];
                dt.Columns.Add("NgayTao");

                foreach(DataRow dr in dt.Rows)
                {
                    dr["NgayTao"] = DateTime.Parse(dr["Ngay"].ToString()).ToString("dd/MM/yyyy");
                }

                return dt;
            }
            catch (Exception ex)
            {
                return dt;
            }
        }

        public static DataTable BieuDoThongKeSanLuongNV(string tungay, string denngay)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlParameter[] param = new SqlParameter[]
                {
                    new SqlParameter("@tungay", tungay),
                    new SqlParameter("@denngay", denngay)
                };

                dt = db.ExecuteDataSet("sp_MyCareDesktop_BieuDoSanLuongNV", param).Tables[0];
                return dt;
            }
            catch (Exception ex)
            {
                return dt;
            }
        }
    }
}
