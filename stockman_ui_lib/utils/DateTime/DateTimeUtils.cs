using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stockman_ui.Utils
{
    public sealed class DateTimeUtils
    {



        public static String CurrentDateAsString(string dateFormat) 
        {
            string date = DateTime.Now.ToString(dateFormat);
            return date;
        }

    }
}
