using OpenQA.Selenium;

namespace Saucedemo.Core.Actions
{
    public class MouseActions
    {
        public IWebDriver WebDriver { get; }
        public MouseActions(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }

    }
}
