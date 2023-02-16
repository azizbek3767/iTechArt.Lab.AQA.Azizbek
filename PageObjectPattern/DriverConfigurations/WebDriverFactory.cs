using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using PageObjectPattern.Configurations;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using PageObjectPattern.Utilities;

namespace PageObjectPattern.DriverConfigurations
{
    public class WebDriverFactory
    {
        public IWebDriver GetDriver()
        {
            IWebDriver driver;

            var browser = AppConfiguration.Browser;
            Logger.Instance.Debug($"Start browser '{browser}'");

            switch (browser)
            {
                case Browser.Chrome:
                    new DriverManager().SetUpDriver(new ChromeConfig(), "MatchingBrowser");
                    var options = new ChromeOptions();
                    options.AddArguments(ChromeArguments());
                    foreach (var chromeArgument in ChromeArguments())
                    {
                        Logger.Instance.Debug($"Pass argument: '{chromeArgument}'");
                    }
                    driver = new ChromeDriver(options);
                    Logger.Instance.Debug(((WebDriver)driver).AuthenticatorId);
                    return driver;
                case Browser.Edge:
                    driver = new EdgeDriver();
                    return driver;
                case Browser.FireFox:
                    driver = new FirefoxDriver();
                    return driver;
                default: throw new ArgumentException($"Browser '{browser}' is not supported yet");
            }
        }

        private IEnumerable<string> ChromeArguments()
        {
            yield return "--no-sandbox";
            yield return "--disable-dev-shm-usage";
            yield return "--disable-gpu";
        }
    }

    public enum Browser
    {
        Chrome,
        Edge,
        FireFox
    }
}
