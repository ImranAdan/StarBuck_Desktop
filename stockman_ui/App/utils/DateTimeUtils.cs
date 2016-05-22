using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stockman_ui.app.utils
{
    public class DateTimeUtils
    {

        public static String CurrentDate() {
            return DateTime.Now.ToString();
        }

        public static String CurrentDate(string dateFormat) {
            return DateTime.Now.ToString(dateFormat);
        }

    }
}
