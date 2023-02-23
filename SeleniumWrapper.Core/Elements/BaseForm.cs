using OpenQA.Selenium;
using SeleniumWrapper.Core.Actions;
using SeleniumWrapper.Core.BrowserUtils;
using SeleniumWrapper.Core.Utilities;

namespace SeleniumWrapper.Core.Elements
{
    public abstract class BaseForm
    {
        protected By Locator { get; }

        protected string Name { get; }

        protected BaseForm(By locator, string name)
        {
            Locator = locator;
            Name = name;
        }
        protected MouseActions MouseActions => new MouseActions(WebDriver);
        private WebDriver WebDriver
        {
            get { return BrowserService.Browser.WebDriver; }
        }

        public void Click()
        {
            FindElement().Click();
        }
        public void SimpleClick()
        {
            WebDriver.FindElement(Locator).Click();
        }

        public string GetText()
        {
            return FindElement().Text;
        }

        public bool IsDisplayed()
        {
            return FindElement().Displayed;
        }

        protected IWebElement FindElement()
        {
            return ElementFinder.GetWebElement(Locator);
        }

        private ElementFinder ElementFinder => new ElementFinder(WebDriver);
    }
}
