using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace FirstSeleniumTask
{
    internal class SeleniumBegin
    {
        [Test]
        public void SeleniumBeginTest()
        {
            var pathToChromeDriver = Path.Combine(AppContext.BaseDirectory, "Resources", "chromedriver.exe");

            IWebDriver driver = new ChromeDriver(pathToChromeDriver);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            var baseUrl = "https://uzmarketing.com/";
            var baseUrlLikeUri = new Uri(baseUrl, UriKind.Absolute);
            driver.Navigate().GoToUrl(baseUrlLikeUri);

            IWebElement services = driver.FindElement(By.CssSelector("#menu-item-1079 > a"));
            services.Click();

            IWebElement creativeExec =
                driver.FindElement(By.CssSelector("#section-content > div > div > div.list-group > a:nth-child(1)"));
            creativeExec.Click();

            IWebElement contact = driver.FindElement(By.CssSelector("#menu-item-1077 > a"));
            contact.Click();

            IWebElement fax = driver.FindElement(By.XPath("//*[@id='google_map']/div/p[1]/span[4]"));

            string faxValue = fax.GetAttribute("value");
            var actualValue = faxValue.Split("(")[1];
            string expectedValue = "(800) 217-9962";

            Assert.AreEqual(expectedValue, actualValue, "Wrong");
            
            driver.Quit();
        }
    }
}
