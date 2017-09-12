using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCare.MyCareDataAccess.Utils
{
    public class Utils
    {
        public Utils instance = new Utils();
        private Utils() {}

        private SqlDataHelper db = new SqlDataHelper();
    }
}
