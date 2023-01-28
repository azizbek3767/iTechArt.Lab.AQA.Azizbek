using Microsoft.Extensions.Options;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using PageObjectPattern.Locators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void GoToDefinition()
        {
            Actions actions = new Actions(WebDriver);
            actions.MoveToElement(SpanWithOverview).Perform();
        }

        public void BackToMobilePhonesPage()
        {
            WebDriver.Navigate().Back();
        }
    }
}
