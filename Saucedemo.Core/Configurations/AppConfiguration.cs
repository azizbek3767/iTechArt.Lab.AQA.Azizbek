
using Saucedemo.Core.BrowserUtils;
using Saucedemo.Core.Utilities;

namespace Saucedemo.Core.Configurations
{
    public static class AppConfiguration
    {
        private const string UrlKey = "url";
        private const string ConditionTimeoutKey = "conditionTimeout";

        public static readonly string Url = 
            Configurator.GetConfigurator().GetSection(UrlKey).Value;
        public static readonly int ConditionTimeout =
            Convert.ToInt32(Configurator.GetConfigurator().GetSection(ConditionTimeoutKey).Value);
    }
}
