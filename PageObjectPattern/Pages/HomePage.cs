using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using PageObjectPattern.Utilities;

namespace PageObjectPattern.Pages
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver webDriver) : base(webDriver) { }

        public IWebElement SpanWithOverview => WebDriver.FindElement(By.XPath("//*[@id=\"product-table\"]/tbody[4]/tr[4]/td[1]/span"));
        public IWebElement SpanForComparison => WebDriver.FindElement(By.XPath("//*[@id=\"compare-button-container\"]/div/div[1]/div/div/div[1]/a[2]/span"));

        protected override By UniqueWebLocator => By.XPath("//*[@id=\"canvas\"]");

        protected override string UrlPath => string.Empty;
        
        public bool IsHomePageOpened
        {
            get
            {
                bool isOpened;
                try
                {
                    isOpened = WebDriver.Url == "https://www.onliner.by/";
                }
                catch (Exception e)
                {
                    isOpened = false;
                }
                return isOpened;
            }
        }

        [AllureStep("Open Homepage")]
        public void Open(string url)
        {
            WebDriver.Navigate().GoToUrl(url);
            Logger.Instance.Debug("Home page should be opened");
        }
    }
}
