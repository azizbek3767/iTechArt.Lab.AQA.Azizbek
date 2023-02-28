

using OpenQA.Selenium;

namespace SeleniumWrapper.Core.Actions
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
