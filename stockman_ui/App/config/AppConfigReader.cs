using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;

namespace stockman_ui.app.config
{
    public sealed class AppConfigReader
    {

        public static string GetConfigValue(string key) {
            string configValue = ConfigurationManager.AppSettings[key].ToString();
            return configValue;
        }
    }
}
