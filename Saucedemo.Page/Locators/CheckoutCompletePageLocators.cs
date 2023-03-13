using OpenQA.Selenium;

namespace Saucedemo.Page.Locators
{
    internal class CheckoutCompletePageLocators
    {
        public static readonly By CheckoutConfirmationLabelLocator =
            By.XPath("//span[@class=\"title\" and contains(text(), \"Checkout: Complete!\")]");
    }
}
