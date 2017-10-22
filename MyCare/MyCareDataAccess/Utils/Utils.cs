using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCare.MyCareDataAccess.Utils
{
    public class Utils
    {
        public static Utils instance = new Utils();
        private Utils() {}
        public static SqlDataHelper db = new SqlDataHelper();

        public static byte[] encryptData(string data)
        {
            System.Security.Cryptography.MD5CryptoServiceProvider md5Hasher = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] hashedBytes;
            System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();
            hashedBytes = md5Hasher.ComputeHash(encoder.GetBytes(data));
            return hashedBytes;
        }
        public static string md5(string data)
        {
            return BitConverter.ToString(encryptData(data)).Replace("-", "").ToLower();
            //return data;
        }

        public static string DinhDangTienTe(string Tien)
        {
            double tienTe = double.Parse(Tien);
            string tien = string.Format("{0:0,0.##}", tienTe);
            return tien;
        }

        public static bool CheckQuyenAdmin(int idnhanvien)
        {
            try
            {
                return bool.Parse(db.ExecuteScalar("select  [dbo].[f_CheckTaiKhoan](" + idnhanvien + ")").ToString());
            }
            catch(Exception ex)
            {
                return false;
            }
        }
    }
}
