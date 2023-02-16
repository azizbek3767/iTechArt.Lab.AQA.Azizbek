
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using SeleniumWrapper.Page.Configurations;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager;

namespace SeleniumWrapper.Page.DriverConfiguration
{
    public class WebDriverFactory
    {
        public IWebDriver GetDriver()
        {
            IWebDriver driver;

            var browser = AppConfiguration.Browser;

            switch (browser)
            {
                case Browser.Chrome:
                    new DriverManager().SetUpDriver(new ChromeConfig(), "MatchingBrowser");
                    var options = new ChromeOptions();
                    options.PageLoadStrategy = PageLoadStrategy.Normal;
                    options.AddArguments(ChromeArguments());
                    driver = new ChromeDriver(options);
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
