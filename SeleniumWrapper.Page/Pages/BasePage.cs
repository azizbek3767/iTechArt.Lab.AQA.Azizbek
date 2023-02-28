using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumWrapper.Core.Configurations;
using NUnit.Framework;

namespace SeleniumWrapper.Page.Pages
{
    public abstract class BasePage
    {
        protected IWebDriver WebDriver { get; }
        protected WebDriverWait WebDriverWait { get; }
        protected IJavaScriptExecutor JavaScriptExecutor { get; }
        protected Actions Builder { get; }
        protected BasePage(IWebDriver webDriver)
        {
            WebDriver = webDriver;
            WebDriverWait = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(AppConfiguration.ConditionTimeout));
            WebDriverWait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));
            JavaScriptExecutor = (IJavaScriptExecutor)WebDriver;
            Builder = new Actions(WebDriver);
        }

        protected IWebElement UniqueWebElement => WebDriver.FindElement(UniqueWebLocator);

        protected abstract By UniqueWebLocator { get; }

        private readonly string _baseUrl = AppConfiguration.Url;

        protected abstract string UrlPath { get; }

        public void OpenPage()
        {
            var uri = new Uri(_baseUrl.TrimEnd('/') + UrlPath, UriKind.Absolute);
            WebDriver.Navigate().GoToUrl(uri);
            WaitForPageLoad();
        }

        public bool IsPageOpened
        {
            get
            {
                bool isOpened;
                try
                {
                    isOpened = UniqueWebElement.Displayed;
                }
                catch (Exception e)
                {
                    isOpened = false;
                }

                return isOpened;
            }
        }

        public void WaitForPageLoad()
        {
            var driverWait = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(10));

            try
            {
                driverWait.Until(driver => driver.FindElement(UniqueWebLocator).Displayed);
            }
            catch (WebDriverTimeoutException e)
            {
                throw new AssertionException($"Page with unique locator: '{UniqueWebLocator}' was not opened", e);
            }
        }
    }
}
