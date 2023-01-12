using OpenQA.Selenium;

namespace BDDForSelenimSaucedemo
{
    internal class HomePage
    {
        private IWebDriver _webDriver;
        public HomePage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public void Open(string url)
        {
            _webDriver.Navigate().GoToUrl(url);
        }

        public IWebElement UsernameInput => _webDriver.FindElement(By.CssSelector("#user-name"));
        public IWebElement PasswordInput => _webDriver.FindElement(By.CssSelector("#password"));
        public IWebElement LoginButton => _webDriver.FindElement(By.CssSelector("#login-button"));
        public IWebElement HomePageLogo => _webDriver.FindElement(By.CssSelector(".app_logo"));
        public IWebElement AddToCartButton => _webDriver.FindElement(By.CssSelector("#add-to-cart-sauce-labs-backpack"));
        public IWebElement CartButton => _webDriver.FindElement(By.CssSelector(".shopping_cart_link"));
        public IWebElement CartInventory => _webDriver.FindElement(By.CssSelector(".cart_item"));
        public IWebElement CartInventoryName => _webDriver.FindElement(By.CssSelector(".inventory_item_name"));
        public IWebElement CheckoutButton => _webDriver.FindElement(By.CssSelector("#checkout"));
        public IWebElement CheckoutFirstnameInput => _webDriver.FindElement(By.CssSelector("#first-name"));
        public IWebElement CheckoutLastnameInput => _webDriver.FindElement(By.CssSelector("#last-name"));
        public IWebElement CheckoutPostalcodeInput => _webDriver.FindElement(By.CssSelector("#postal-code"));
        public IWebElement CheckoutContinueButton => _webDriver.FindElement(By.CssSelector("#continue"));
        public IWebElement CheckoutFinishButton => _webDriver.FindElement(By.CssSelector("#finish"));

        public void FillInUsernameField(string username)
        {
            UsernameInput.SendKeys(username);
        }
        public void FillInPasswordField(string password) 
        {
            PasswordInput.SendKeys(password);
        }

        public void ClickLoginButton()
        {
            LoginButton.Click();
        }

        public string GetCurrentUrl()
        {
            return _webDriver.Url;
        }

        public bool HomePageLogoExists()
        {
            return HomePageLogo != null;
        }
        public void CloseBrowser()
        {
            _webDriver.Quit();
        }
        public void ClickCartButton()
        {
            CartButton.Click();
        }
        public bool IsCartInventoryExists()
        {
            return CartInventory != null;
        }
        public bool IsRightItemIsAddedToCart()
        {
            return CartInventoryName.Text == "Sauce Labs Backpack";
        }
        public void Checkout()
        {
            CheckoutButton.Click();
        }
        public void FillInCheckoutForm()
        {
            CheckoutFirstnameInput.SendKeys("Azizbek");
            CheckoutLastnameInput.SendKeys("Nasriddinov");
            CheckoutPostalcodeInput.SendKeys("100186");
        }
    }
}
