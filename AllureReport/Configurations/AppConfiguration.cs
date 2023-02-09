using SeleniumAdvancedPartTwo.DriverConfiguration;
using SeleniumAdvancedPartTwo.Utilities;

namespace SeleniumAdvancedPartTwo.Configurations
{
    public static class AppConfiguration
    {
        private const string BrowserKey = "browser";

        private const string UrlKey = "url";

        public static readonly Browser Browser = Browser.Chrome;
        //Enum.Parse<Browser>(Configurator.GetConfigurator().GetSection(BrowserKey).Value, true);

        public static readonly string Url = "http://admin:admin@the-internet.herokuapp.com";
        //Configurator.GetConfigurator().GetSection(UrlKey).Value;
        public static readonly int ConditionTimeout = 10;
            //Convert.ToInt32(Configurator.GetConfigurator().GetSection("conditionTimeout").Value);
    }
}
