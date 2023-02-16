using SeleniumWrapper.Core.DriverUtils;
using SeleniumWrapper.Core.Utilities;

namespace SeleniumWrapper.Core.BrowserUtils
{
    public class BrowserProfile
    {
        private const string BrowserKey = "browser";
        public BrowserEnum BrowserName => Enum.Parse<BrowserEnum>(Configurator.GetConfigurator().GetSection(BrowserKey).Value, true);

        public DriverSettings DriverSettings
        {
            get
            {
                switch (BrowserName)
                {
                    case BrowserEnum.Chrome:
                        return new ChromeSettings();
                    default:
                        throw new InvalidOperationException($"Driver settings for browser '{BrowserName}' are not defined");
                }
            }
        }
    }

    public enum BrowserEnum
    {
        Chrome,
        Opera
    }
}
