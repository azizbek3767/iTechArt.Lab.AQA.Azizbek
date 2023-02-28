using OpenQA.Selenium;
using Saucedemo.Core.Elements;
using Saucedemo.Page.Locators;

namespace Saucedemo.Page.Pages
{
    public class CartPage : BasePage
    {
        public CartPage(IWebDriver webDriver) : base(webDriver)
        {
        }

        protected override By UniqueWebLocator => By.XPath("//span[@class=\"title\" and contains(text(), \"Your Cart\")]");

        protected override string UrlPath => "/cart.html";
        private Button CheckoutButton => new(CartPageLocators.CheckoutButtonLocator, "Checkout button");
        public void ClickCheckOutButton()
        {
            CheckoutButton.Click();
        }
    }
}
