using MyCare.MyCareDataAccess.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCare.MyCareDataAccess.DataAcess
{
    public class DonViDB
    {
        private static SqlDataHelper db = new SqlDataHelper();
        public DonViDB() { }
        public static DataTable DanhSachDonVi()
        {
            DataTable dt = new DataTable();
            try
            {
                dt = db.ExecuteDataSet("select * from DonVi").Tables[0];
                return dt;
            }
            catch (Exception ex)
            {
                return dt;
            }
        }

    }
}
