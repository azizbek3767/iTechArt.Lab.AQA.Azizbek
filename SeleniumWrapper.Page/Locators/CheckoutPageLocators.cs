
using OpenQA.Selenium;

namespace SeleniumWrapper.Page.Locators
{
    internal class CheckoutPageLocators
    {
        public static readonly By NameInputLocator =
            By.XPath("//input[@id=\"msordersform-first_name\"]");
        public static readonly By PhoneNumberInputLocator =
            By.XPath("//input[@id=\"msordersform-phone_m\"]");
        public static readonly By AddressInputLocator =
            By.XPath("//input[@id=\"msordersform-address\"]");
    }
}
