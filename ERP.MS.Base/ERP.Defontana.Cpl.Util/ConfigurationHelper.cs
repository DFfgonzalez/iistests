using System.Web.Configuration;

namespace ERP.Defontana.Cpl.Util
{
    public static class ConfigurationHelper
    {

        public static string GetConfigurationParameterResource(string key)
        {
            return UtilResources.ResourceManager.GetString(key);
        }

        public static string GetWebConfigurationParameter(string key)
        {
            return WebConfigurationManager.AppSettings[key];
        }

        public static bool IsSentryLoggerEnabled()
        {
            string logger = GetWebConfigurationParameter("SentryLoggerActive");

            return !string.IsNullOrEmpty(logger) && logger.Contains("true");
        }

        public static bool IsLog4NetLoggerEnabled()
        {
            string logger = GetWebConfigurationParameter("Log4NetLoggerActive");

            return !string.IsNullOrEmpty(logger) && logger.Contains("true");
        }

    }
}
