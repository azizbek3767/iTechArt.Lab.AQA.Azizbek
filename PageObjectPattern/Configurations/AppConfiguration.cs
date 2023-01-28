using PageObjectPattern.DriverConfigurations;

namespace PageObjectPattern.Configurations
{
    public static class AppConfiguration
    {
        private const string BrowserKey = "browser";
        private const string UrlKey = "url";

        public static readonly Browser Browser = Browser.Chrome;
        //Enum.Parse<Browser>(Configurator.GetConfigurator().GetSection(BrowserKey).Value, true);

        public static readonly string Url = "https://onliner.by"; 
            //Configurator.GetConfigurator().GetSection(UrlKey).Value;
    }
}
