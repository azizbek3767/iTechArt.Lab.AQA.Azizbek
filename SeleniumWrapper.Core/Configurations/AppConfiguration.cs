using SeleniumWrapper.Core.BrowserUtils;
using SeleniumWrapper.Core.Utilities;

namespace SeleniumWrapper.Core.Configurations
{
    public static class AppConfiguration
    {
        private const string BrowserKey = "browser";

        private const string UrlKey = "url";

        public static readonly BrowserEnum Browser =
            Enum.Parse<BrowserEnum>(Configurator.GetConfigurator().GetSection(BrowserKey).Value, true);
        public static readonly string Url =
            Configurator.GetConfigurator().GetSection(UrlKey).Value;
        public static readonly int ConditionTimeout =
            Convert.ToInt32(Configurator.GetConfigurator().GetSection("conditionTimeout").Value);
    }
}
