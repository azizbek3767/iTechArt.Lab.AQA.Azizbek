using OpenQA.Selenium;

namespace SeleniumAdvancedPartTwo.Locators
{
    public static class HomePageLocators
    {
        public static readonly By HomePageUniqueLocator =
            By.XPath("//h3[text()=\"Basic Auth\"]");
        public static readonly By ElementWithCongratulationLocator =
            By.XPath("//*[contains(text(),\"Congratulations! You must have the proper credentials\")]");
    }
}
