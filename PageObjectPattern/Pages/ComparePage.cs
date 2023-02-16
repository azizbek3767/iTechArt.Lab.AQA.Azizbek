
using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using PageObjectPattern.Locators;
using PageObjectPattern.Utilities;

namespace PageObjectPattern.Pages
{
    public class ComparePage : BasePage
    {
        public ComparePage(IWebDriver webDriver) : base(webDriver)
        {
        }
        public IWebElement SpanWithOverview => WebDriver.FindElement(HomePageLocators.SpanWithOverview);
        public IWebElement OfMobilePhonesPage => WebDriver.FindElement(HomePageLocators.UniqueWebLocatorOfMobilePhonesPage);

        protected override By UniqueWebLocator => By.XPath("//h1[text()=\"Сравнение товаров\"]");

        protected override string UrlPath => string.Empty;

        [AllureStep("Go to definition part of the items")]
        public void GoToDefinition()
        {
            Actions actions = new Actions(WebDriver);
            actions.MoveToElement(SpanWithOverview).Perform();
            Logger.Instance.Info("Going to the definition");
        }

        [AllureStep("Go back to the mobile phones page")]
        public void BackToMobilePhonesPage()
        {
            WebDriver.Navigate().Back();
            Logger.Instance.Info("Going back to the home page");
        }
    }
}
