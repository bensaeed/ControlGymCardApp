using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlGymCardApp.Helpers
{
    class  Utility
    {
        public static string CheckNullString(string x)
        {
            if (x == null)
                return "";
            return x;
        }
        public static decimal CheckNullNumber(string x)
        {
            if (x == null)
                return 0;
            return Convert.ToDecimal(x);
        }
        public static bool IsNull(string x)
        {
            if (x == null || x == "")
                return true;
            return false;
        }
    }
}
