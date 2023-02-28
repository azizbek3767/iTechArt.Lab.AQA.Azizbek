using OpenQA.Selenium;

namespace Saucedemo.Page.Locators
{
    internal class CartPageLocators
    {
        public static readonly By CheckoutButtonLocator =
            By.XPath("//button[@id=\"checkout\"]");
    }
}
