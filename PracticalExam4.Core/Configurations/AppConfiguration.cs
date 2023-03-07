using PracticalExam4.Core.DriverConfigurations;
using PracticalExam4.Core.Utilities;

namespace PracticalExam4.Core.Configurations
{
    public static class AppConfiguration
    {
        private const string BrowserKey = "browser";
        private const string UrlKey = "url";

        public static readonly Browser Browser = 
            Enum.Parse<Browser>(Configurator.GetConfigurator().GetSection(BrowserKey).Value, true);

        public static readonly string Url =
            Configurator.GetConfigurator().GetSection(UrlKey).Value;
    }
}
