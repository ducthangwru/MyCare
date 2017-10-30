using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
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
                SqlDataHelper dba = new SqlDataHelper();
                return bool.Parse(dba.ExecuteScalar("select  [dbo].[f_CheckTaiKhoan]("+ idnhanvien + ")").ToString());
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public static int DocFileConfig()
        {
            if (!System.IO.File.Exists("config.txt"))
            {
                System.IO.File.Create("config.txt");
            }

            // doc va hien thi du lieu trong textfile.txt
            string line = "";
            using (StreamReader sr = new StreamReader("config.txt"))
            {
                while (!string.IsNullOrEmpty(line = sr.ReadLine()))
                {
                    Config.CONNECTION_STRING = line;
                }

                if (string.IsNullOrEmpty(Config.CONNECTION_STRING))
                {
                    return -1;
                }

                try
                {
                    SqlDataHelper db = new SqlDataHelper();
                    return 1;
                }
                catch (Exception ex)
                {
                    return 0;
                }
            }
        }
    }
}
