using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;

namespace Utilities
{
    public static class AppConfiguration
    {
        public static string ReadKey()
        {
            return ConfigurationManager.AppSettings["MyKey"].ToString();
        }

        public static void WriteKey(string key)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            config.AppSettings.Settings.Remove("MyKey");
            config.AppSettings.Settings.Add("MyKey", key);

            config.AppSettings.SectionInformation.ForceSave = true;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("MyKey");
        }
    }
}
