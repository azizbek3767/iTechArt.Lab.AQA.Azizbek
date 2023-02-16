using OpenQA.Selenium;

namespace SeleniumWrapper.Page.Pages
{
    internal class HomePage : BasePage
    {
        public HomePage(IWebDriver webDriver) : base(webDriver)
        {
        }

        protected override By UniqueWebLocator => throw new NotImplementedException();

        protected override string UrlPath => throw new NotImplementedException();
    }
}
