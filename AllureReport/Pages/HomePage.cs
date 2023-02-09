using OpenQA.Selenium;
using SeleniumAdvancedPartTwo.Locators;

namespace SeleniumAdvancedPartTwo.Pages
{
    internal class HomePage : BasePage
    {
        public HomePage(IWebDriver webDriver) : base(webDriver)
        {
        }

        protected override By UniqueWebLocator => HomePageLocators.HomePageUniqueLocator;
        private IWebElement ElementWithCongratulation => WebDriver.FindElement(HomePageLocators.ElementWithCongratulationLocator);

        protected override string UrlPath => "/basic_auth/";

        public bool IsElementWithCongratulationsVisible
        {
            get
            {
                bool isElementWithCongratulationsVisible;
                try
                {
                    isElementWithCongratulationsVisible = ElementWithCongratulation.Displayed;
                }
                catch (Exception e)
                {
                    isElementWithCongratulationsVisible = false;
                }

                return isElementWithCongratulationsVisible;
            }
        }
    }
}
