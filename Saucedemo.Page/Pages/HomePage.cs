using OpenQA.Selenium;

namespace Saucedemo.Page.Pages
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver webDriver) : base(webDriver)
        {
        }

        protected override By UniqueWebLocator => throw new NotImplementedException();

        protected override string UrlPath => throw new NotImplementedException();
    }
}
