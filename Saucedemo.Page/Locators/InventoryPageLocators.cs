using OpenQA.Selenium;

namespace Saucedemo.Page.Locators
{
    internal class InventoryPageLocators
    {
        public static readonly By BurgerMenuButtonLocator =
            By.XPath("//button[@id=\"react-burger-menu-btn\"]");
        public static readonly By FirstItemAddToCartButtonLocator =
            By.XPath("//button[@id=\"add-to-cart-sauce-labs-backpack\"]");
        public static readonly By SecondItemAddToCartButtonLocator =
            By.XPath("//button[@id=\"add-to-cart-sauce-labs-bike-light\"]");
        public static readonly By TopCartIconBadgeNumberLocator =
            By.XPath("//a[@class=\"shopping_cart_link\"]//span[@class=\"shopping_cart_badge\" and contains(text(), \"2\")]");
    }
}
