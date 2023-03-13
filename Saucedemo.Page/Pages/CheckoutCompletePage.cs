using OpenQA.Selenium;
using Saucedemo.Core.Elements;
using Saucedemo.Page.Locators;

namespace Saucedemo.Page.Pages
{
    public class CheckoutCompletePage : BasePage
    {
        public CheckoutCompletePage(IWebDriver webDriver) : base(webDriver)
        {
        }

        protected override By UniqueWebLocator => By.XPath("//span[@class=\"title\" and contains(text(), \"Checkout\")]");

        protected override string UrlPath => "/checkout-complete.html";

        public Label CheckoutConfirmationLabel => new(CheckoutCompletePageLocators.CheckoutConfirmationLabelLocator, "Checkout Confirmation Label");
    }
}
