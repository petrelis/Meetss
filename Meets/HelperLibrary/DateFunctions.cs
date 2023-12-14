using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperLibrary
{
    public class DateFunctions
    {
        public static bool IsValidDateTime(string dateInput)
        {
            string format = "yyyy/MM/dd HH:mm";
            if (DateTimeOffset.TryParseExact(dateInput, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTimeOffset dateOut))
            {
                return false;
            }
            return true;
        }
    }
}
