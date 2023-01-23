using OpenQA.Selenium;

namespace PageObjectPattern.Pages
{
    public abstract class BasePage
    {
        protected IWebDriver _webDriver;
        public BasePage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }
    }
}
