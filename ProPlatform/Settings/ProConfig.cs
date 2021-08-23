using Microsoft.Extensions.Configuration;
using System.Collections.Specialized;

namespace SmartWatch.ProPlatform.Settings
{
    public static class ProConfig
    {
        /// <summary>
        /// When ever caonfiguration value found function return value 
        /// otherwise return empty string
        /// </summary>
        /// <param name="configKey">key in configuration file</param>
        /// <returns>configuration value</returns>
        public static string GetApplicationConfValue(string configKey)
        {
            IConfiguration configuration = Startup.LocalConfigurtation;
            NameValueCollection applicationSettings = configuration.GetSection("appSettings") as NameValueCollection;
            if (applicationSettings.Count == 0)
            {
                return string.Empty;
            }
            else
            {
                foreach (string key in applicationSettings.AllKeys)
                {
                    if (configKey == key)
                    {
                        return applicationSettings[key];
                    }
                }
            }
            return string.Empty;
        }
    }
}
