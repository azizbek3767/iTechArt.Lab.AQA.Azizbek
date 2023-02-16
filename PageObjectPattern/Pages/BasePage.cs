using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PageObjectPattern.Configurations;
using PageObjectPattern.Utilities;
using SeleniumExtras.WaitHelpers;

namespace PageObjectPattern.Pages
{
    public abstract class BasePage
    {
        protected IWebDriver WebDriver { get; }
        protected WebDriverWait WebDriverWait { get; }
        protected BasePage(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }

        protected IWebElement UniqueWebElement => WebDriver.FindElement(UniqueWebLocator);

        protected abstract By UniqueWebLocator { get; }

        private readonly string _baseUrl = AppConfiguration.Url;

        protected abstract string UrlPath { get; }

        [AllureStep("Open page")]
        public virtual void OpenPage()
        {
            var uri = new Uri(_baseUrl.TrimEnd('/') + UrlPath, UriKind.Absolute);
            Logger.Instance.Info(uri.ToString());
            WebDriver.Navigate().GoToUrl(uri);
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
    }
}
