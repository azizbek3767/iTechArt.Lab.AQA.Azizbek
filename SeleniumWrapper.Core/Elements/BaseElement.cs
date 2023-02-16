using OpenQA.Selenium;
using SeleniumWrapper.Core.Actions;
using SeleniumWrapper.Core.BrowserUtils;
using SeleniumWrapper.Core.Utilities;

namespace SeleniumWrapper.Core.Elements
{
    public abstract class BaseElement
    {
        protected By Locator { get; }

        protected string Name { get; }

        protected BaseElement(By locator, string name)
        {
            this.Locator = locator;
            Name = name;
        }
        protected MouseActions MouseActions => new MouseActions(WebDriver);
        private WebDriver WebDriver
        {
            get { return BrowserService.Browser.WebDriver; }
        }

        public void Click()
        {
            throw new NotImplementedException();
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
