using OpenQA.Selenium;
using PracticalExam4.Core.Configurations;

namespace PracticalExam4.Core.Pages
{
    public abstract class BasePage
    {
        protected IWebDriver WebDriver { get; }

        protected BasePage(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }

        protected IWebElement UniqueWebElement => WebDriver.FindElement(UniqueWebLocator);

        protected abstract By UniqueWebLocator { get; }

        private readonly string _baseUrl = AppConfiguration.Url;

        protected abstract string UrlPath { get; }

        public virtual void OpenPage()
        {
            var uri = new Uri(_baseUrl.TrimEnd('/') + UrlPath, UriKind.Absolute);
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
