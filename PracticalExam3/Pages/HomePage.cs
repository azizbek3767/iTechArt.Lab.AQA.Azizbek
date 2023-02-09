using OpenQA.Selenium;
using PracticalExam3.Locators;

namespace PracticalExam3.Pages
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver webDriver) : base(webDriver)
        {
        }
        private IWebElement ClickHereButton => WebDriver.FindElement(HomePageLocators.ClickHereButtonLocator);
        protected override By UniqueWebLocator => By.XPath("//p[contains(@class, \"start__paragraph\") and contains(text(), \"Hi and welcome to User Inyerface\")]");

        protected override string UrlPath => string.Empty;

        public void ClickClickHereButton()
        {
            ClickHereButton.Click();
        }
    }
}
