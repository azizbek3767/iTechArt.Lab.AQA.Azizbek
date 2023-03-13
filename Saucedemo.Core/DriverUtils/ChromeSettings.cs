using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Saucedemo.Core.DriverUtils
{
    public class ChromeSettings : DriverSettings
    {
        public override ChromeOptions DriverOptions
        {
            get
            {
                var options = new ChromeOptions();
                options.PageLoadStrategy = PageLoadStrategy.Normal;
                options.AddArguments(ChromeArguments());
                return options;
            }
        }
        private IEnumerable<string> ChromeArguments()
        {
            yield return "--no-sandbox";
            yield return "--disable-dev-shm-usage";
            yield return "--disable-gpu";
        }
    }
}
