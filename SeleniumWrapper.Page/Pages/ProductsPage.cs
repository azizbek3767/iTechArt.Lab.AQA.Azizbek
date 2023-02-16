

using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using SeleniumWrapper.Page.Locators;

namespace SeleniumWrapper.Page.Pages
{
    public class ProductsPage : BasePage
    {
        public ProductsPage(IWebDriver webDriver) : base(webDriver)
        {
        }
        private IWebElement FIrstItemAddToCardIcon => WebDriver.FindElement(ProductsPageLocators.FIrstItemAddToCardIconLocator);
        private IWebElement SecondItemAddToCardIcon => WebDriver.FindElement(ProductsPageLocators.SecondItemAddToCardIconLocator);
        private IWebElement CardButton => WebDriver.FindElement(ProductsPageLocators.CardButtonLocator);
        private IWebElement OpenedCardSidebar => WebDriver.FindElement(ProductsPageLocators.OpenedCardSidebarLocator);
        private IWebElement ItemsCount => WebDriver.FindElement(ProductsPageLocators.ItemsCountLocator);
        private IWebElement OrderButton => WebDriver.FindElement(ProductsPageLocators.OrderButtonLocator);
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
            //WebDriverWait.Until(JavaScriptExecutor.ExecuteScript("return document.readyState") == "complate");
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
                    isCarditemsCountTrue = ItemsCount.Displayed;
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
