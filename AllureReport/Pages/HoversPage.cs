using OpenQA.Selenium;
using SeleniumAdvancedPartTwo.Locators;
using SeleniumAdvancedPartTwo.Utilities;

namespace SeleniumAdvancedPartTwo.Pages
{
    internal class HoversPage : BasePage
    {
        public HoversPage(IWebDriver webDriver) : base(webDriver)
        {
        }
        private IWebElement FirstUser => WebDriver.FindElement(HoversPageLocators.FirstUserLocator);
        private IWebElement SecondUser => WebDriver.FindElement(HoversPageLocators.SecondUserLocator);
        private IWebElement ThirdUser => WebDriver.FindElement(HoversPageLocators.ThirdUserLocator);
        private IWebElement FirstUserNameLabel => WebDriver.FindElement(HoversPageLocators.FirstUserNameLocator);
        private IWebElement SecondUserNameLabel => WebDriver.FindElement(HoversPageLocators.SecondUserNameLocator);
        private IWebElement ThirdUserNameLabel => WebDriver.FindElement(HoversPageLocators.ThirdUserNameLocator);
        public IWebElement FirstUserLink => WebDriver.FindElement(HoversPageLocators.FirstUserLinkLocator);
        public IWebElement SecondUserLink => WebDriver.FindElement(HoversPageLocators.SecondUserLinkLocator);
        public IWebElement ThirdUserLink => WebDriver.FindElement(HoversPageLocators.ThirdUserLinkLocator);
        public string FirstUserName { get; set; }
        public string SecondUserName { get; set; }
        public string ThirdUserName { get; set; }
        protected override By UniqueWebLocator => By.XPath("//h3[contains(text(), \"Hovers\")]");

        protected override string UrlPath => "/hovers";
        public void HoverFirstUserItem()
        {
            Builder.MoveToElement(FirstUser).Perform();
            FirstUserName = HelperMethods.SplitElement(FirstUserNameLabel);
        }
        public void HoverSecondUserItem()
        {
            Builder.MoveToElement(SecondUser).Perform();
            SecondUserName = HelperMethods.SplitElement(SecondUserNameLabel);
        }
        public void HoverThirdUserItem()
        {
            Builder.MoveToElement(ThirdUser).Perform();
            ThirdUserName = HelperMethods.SplitElement(ThirdUserNameLabel);
        }
        public void ClickFirstUserButton()
        {
            FirstUserLink.Click();
        }
        public void ClickSecondUserButton()
        {
            SecondUserLink.Click();
        }
        public void ClickThirdUserButton()
        {
            ThirdUserLink.Click();
        }
        public void GoBack()
        {
            WebDriver.Navigate().Back();
        }
    }
}
