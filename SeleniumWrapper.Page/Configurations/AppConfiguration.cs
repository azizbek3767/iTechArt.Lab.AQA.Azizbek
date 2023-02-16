﻿
using SeleniumWrapper.Page.DriverConfiguration;
using SeleniumWrapper.Page.Utilities;

namespace SeleniumWrapper.Page.Configurations
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
