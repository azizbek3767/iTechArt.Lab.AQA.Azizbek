using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PracticalExam4.Core.Configurations;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace PracticalExam4.Core.DriverConfigurations
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
                    options.AddArguments(ChromeArguments());
                    driver = new ChromeDriver(options);
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
