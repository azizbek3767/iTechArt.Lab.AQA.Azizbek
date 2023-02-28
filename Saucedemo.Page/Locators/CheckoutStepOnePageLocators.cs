using OpenQA.Selenium;

namespace Saucedemo.Page.Locators
{
    internal class CheckoutStepOnePageLocators
    {
        public static readonly By FirstNameInputLocator =
            By.XPath("//input[@id=\"first-name\"]");
        public static readonly By LastNameInputLocator =
            By.XPath("//input[@id=\"last-name\"]");
        public static readonly By ZipCodeInputLocator =
            By.XPath("//input[@id=\"postal-code\"]");
    }
}
