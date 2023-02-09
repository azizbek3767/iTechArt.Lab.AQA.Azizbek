using PracticalExam3.DriverConfiguration;
using PracticalExam3.Utilities;

namespace PracticalExam3.Configurations
{
    public static class AppConfiguration
    {
        private const string BrowserKey = "browser";

        private const string UrlKey = "url";

        public static readonly Browser Browser = 
            Enum.Parse<Browser>(Configurator.GetConfigurator().GetSection(BrowserKey).Value, true);

        public static readonly string Url = 
            Configurator.GetConfigurator().GetSection(UrlKey).Value;
        public static readonly int ConditionTimeout = 
            Convert.ToInt32(Configurator.GetConfigurator().GetSection("conditionTimeout").Value);
    }
}
