

using OpenQA.Selenium;

namespace SeleniumWrapper.Page.Locators
{
    internal class ProductsPageLocators
    {
        public static readonly By FIrstItemAddToCardIconLocator =
            By.XPath("//img[@class=\"add_to_cart_icon\"][1]");
        public static readonly By SecondItemAddToCardIconLocator =
            By.XPath("//img[@class=\"add_to_cart_icon\" and @data-product=\"16154\"]");
        public static readonly By CardButtonLocator =
            By.XPath("//a[@class=\"karzinka\"]");
        public static readonly By OpenedCardSidebarLocator =
            By.XPath("//div[@class=\"karzinka-open karzinka-open-active\"]");
        public static readonly By ItemsCountLocator =
            By.XPath("//span[@class=\"totalCount\" and contains(text(), 2)]");
        public static readonly By TopCardItemsCountLocator =
            By.XPath("//span[@class=\"cart_items_count\" and contains(text(), 2)]");
        public static readonly By OrderButtonLocator =
            By.XPath("//a[@class=\"karzinka-open-bottom-block-a2\"]");
    }
}
