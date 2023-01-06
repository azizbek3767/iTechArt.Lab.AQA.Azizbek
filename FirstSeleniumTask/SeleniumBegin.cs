using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstSeleniumTask
{
    internal class SeleniumBegin
    {
        [Test]
        public void SeleniumBeginTest()
        {
            var pathToChromeDriver = Path.Combine(AppContext.BaseDirectory, "Resources", "chromedriver.exe");

            IWebDriver _driver = new ChromeDriver(pathToChromeDriver);

            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            var baseUrl = "https://uzmarketing.com/";
            var baseUrlLikeUri = new Uri(baseUrl, UriKind.Absolute);
            _driver.Navigate().GoToUrl(baseUrlLikeUri);

            IWebElement services = _driver.FindElement(By.CssSelector("#menu-item-1079 > a"));
            services.Click();
            Thread.Sleep(1000);

            IWebElement creative_exec =
                _driver.FindElement(By.CssSelector("#section-content > div > div > div.list-group > a:nth-child(1)"));
            creative_exec.Click();

            Thread.Sleep(1000);

            IWebElement contact = _driver.FindElement(By.CssSelector("#menu-item-1077 > a"));
            contact.Click();
            Thread.Sleep(1000);

            IWebElement fax = _driver.FindElement(By.XPath("//*[@id='google_map']/div/p[1]/span[4]"));

            string faxValue = fax.GetAttribute("value");
            var actualValue = faxValue.Split("(")[1];
            string expectedValue = "(800) 217-9962";

            Assert.AreEqual(expectedValue, actualValue, "Wrong");



            _driver.Quit();
        }
    }
}
