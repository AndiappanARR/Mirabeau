using System.Configuration;

namespace Mirabeau.Common.Common
{
    /// <summary>
    /// Constants
    /// </summary>
    public static class Constants
    {
        public readonly static string JsonServiceUrl = ConfigurationManager.AppSettings["JsonServiceUrl"];
        public readonly static string TablePageRowCount = ConfigurationManager.AppSettings["TablePageRowCount"];
        public readonly static string JsonFeederRefreshRate = ConfigurationManager.AppSettings["JsonFeederRefreshRate"];
        public readonly static string iataStr = "iata";
       
    }
}
