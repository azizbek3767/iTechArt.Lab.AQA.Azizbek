using OpenQA.Selenium;
using Saucedemo.Core.Elements;

namespace Saucedemo.Page.Components
{
    public class LeftSidebarComponent
    {
        protected IWebDriver WebDriver { get; }
        public LeftSidebarComponent(IWebDriver webDriver) 
        {
            WebDriver = webDriver;
        }
        private Button AllItemsButton => new Button(By.XPath("//a[@id=\"inventory_sidebar_link\"]"), "All items button");
        private Button AboutButton => new Button(By.XPath("//a[@id=\"about_sidebar_link\"]"), "About button");
        private Button LogoutButton => new Button(By.XPath("//a[@id=\"logout_sidebar_link\"]"), "Logout button");
        private Button ResetAppStateButton => new Button(By.XPath("//a[@id=\"reset_sidebar_link\"]"), "ResetAppState button");
        
        public void ClickAllItemsButton()
        {
            AllItemsButton.Click();
        }
        public void ClickAboutButton()
        {
            AboutButton.Click();
        }
        public void ClickLogoutButton()
        {
            LogoutButton.Click();
        }
        public void ClickResetAppStateButton()
        {
            ResetAppStateButton.Click();
        }
    }
}
