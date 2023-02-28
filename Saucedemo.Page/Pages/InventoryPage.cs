﻿using OpenQA.Selenium;
using Saucedemo.Core.Elements;
using Saucedemo.Page.Locators;

namespace Saucedemo.Page.Pages
{
    public class InventoryPage : BasePage
    {
        public InventoryPage(IWebDriver webDriver) : base(webDriver)
        {
        }

        protected override By UniqueWebLocator => By.XPath("//span[@class=\"title\" and contains(text(), \"Products\")]");

        protected override string UrlPath => "/inventory.html";
        private Button BurgerMenuButton => new(InventoryPageLocators.BurgerMenuButtonLocator, "Burger Menu Button");
        private Button FirstItemAddToCartButton => new(InventoryPageLocators.FirstItemAddToCartButtonLocator, "First Item AddToCart Button");
        private Button SecondItemAddToCartButton => new(InventoryPageLocators.SecondItemAddToCartButtonLocator, "Second Item AddToCart Button");
        private Label TopCartIconBadgeNumberLabel => new(InventoryPageLocators.TopCartIconBadgeNumberLocator, "Top Cart Icon Badge Number Label");

        public void ClickMenuBurgerButton()
        {
            BurgerMenuButton.Click();
        }
        public void ClickTopCartButton()
        {
            TopCartIconBadgeNumberLabel.Click();
        }
        public void AddSomeItemsToTheCart()
        {
            FirstItemAddToCartButton.Click();
            SecondItemAddToCartButton.Click();
        }
        public bool IsItemsAddedToTheCart
        {
            get
            {
                bool isItemsAddedToTheCart;
                try
                {
                    isItemsAddedToTheCart = TopCartIconBadgeNumberLabel.IsDisplayed();
                }
                catch (Exception e)
                {
                    isItemsAddedToTheCart = false;
                }

                return isItemsAddedToTheCart;
            }
        }
    }
}
