

using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using SeleniumWrapper.Core.Elements;
using SeleniumWrapper.Page.Locators;

namespace SeleniumWrapper.Page.Pages
{
    public class ProductsPage : BasePage
    {
        public ProductsPage(IWebDriver webDriver) : base(webDriver)
        {
        }
        private Icon FIrstItemAddToCardIcon => new Icon(WebDriver, ProductsPageLocators.FIrstItemAddToCardIconLocator, "FIrst Item AddToCard Icon");
        private Icon SecondItemAddToCardIcon => new Icon(WebDriver, ProductsPageLocators.SecondItemAddToCardIconLocator, "Second Item AddToCard Icon");
        private Button CardButton => new Button(WebDriver, ProductsPageLocators.CardButtonLocator, "Card Button");
        private IWebElement OpenedCardSidebar => WebDriver.FindElement(ProductsPageLocators.OpenedCardSidebarLocator);
        private IWebElement ItemsCountIconEl => WebDriver.FindElement(ProductsPageLocators.ItemsCountLocator);
        private Button OrderButton => new Button(WebDriver, ProductsPageLocators.OrderButtonLocator, "Order Button");
        protected override By UniqueWebLocator => By.XPath("//div[@class=\"goods-section-right-blocks\"]");

        protected override string UrlPath => "/products/category/8";

        public void AddTwoItemsToTheCard()
        {
            FIrstItemAddToCardIcon.Click();
            SecondItemAddToCardIcon.Click();
        }
        public void ClickCardButton()
        {
            WaitForPageLoad();
            WebDriverWait.Until(ExpectedConditions.ElementIsVisible(ProductsPageLocators.TopCardItemsCountLocator));
            CardButton.Click();
        }
        public bool IsCardSidebarOpened
        {
            get
            {
                bool isCardSidebarOpened;
                try
                {
                    WebDriverWait.Until(ExpectedConditions.ElementIsVisible(ProductsPageLocators.OpenedCardSidebarLocator));
                    isCardSidebarOpened = OpenedCardSidebar.Displayed;
                }
                catch (Exception e)
                {
                    isCardSidebarOpened = false;
                }

                return isCardSidebarOpened;
            }
        }
        public bool IsCarditemsCountTrue
        {
            get
            {
                bool isCarditemsCountTrue;
                try
                {
                    isCarditemsCountTrue = ItemsCountIconEl.Displayed;
                }
                catch (Exception e)
                {
                    isCarditemsCountTrue = false;
                }
                return isCarditemsCountTrue;
            }
        }
        public void ClickOrderButton()
        {
            OrderButton.Click();
        }
    }
}
