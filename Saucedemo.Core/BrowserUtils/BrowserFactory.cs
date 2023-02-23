using OpenQA.Selenium;

namespace Saucedemo.Core.BrowserUtils
{
    public abstract class BrowserFactory
    {
        public BrowserProfile BrowserProfile { get; }

        protected BrowserFactory(BrowserProfile browserProfile)
        {
            BrowserProfile = browserProfile;
        }

        public Browser GetBrowser => new Browser(WebDriver);

        protected abstract WebDriver WebDriver { get; }
    }
}
