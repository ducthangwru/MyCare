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
    public class ThaoTacDB
    {
        private static SqlDataHelper db = new SqlDataHelper();
        public ThaoTacDB() { }

        public static DataTable DanhSachChonThaoTac()
        {
            DataTable dt = new DataTable();
            try
            {
                dt = db.ExecuteDataSet("sp_MyCareDesktop_DanhSachChonThaoTac").Tables[0];
                dt.Rows.Add("0", "Tất cả");
                return dt;
            }
            catch (Exception ex)
            {
                return dt;
            }
        }
    }
}
