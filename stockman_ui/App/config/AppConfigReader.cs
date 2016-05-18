using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stockman_ui.app.config
{
    public sealed class AppConfigReader
    {

        public static string ConfigValueAsString(string key) {
            string configValue = ConfigurationManager.AppSettings[key].ToString();
            return configValue;
        }

        public static T ConfigStringValueAs<T>(string key)
        {
            string configValue = ConfigurationManager.AppSettings[key].ToString();
            return (T) Convert.ChangeType(configValue, typeof(T));
        }
    }
}
