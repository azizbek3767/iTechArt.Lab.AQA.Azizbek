using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumAdvancedPartTwo.Locators;

namespace SeleniumAdvancedPartTwo.Pages
{
    internal class WindowsPage : BasePage
    {
        public WindowsPage(IWebDriver webDriver) : base(webDriver)
        {
        }

        protected override By UniqueWebLocator => By.XPath("//h3[contains(text(), \"Opening a new window\")]");
        private IWebElement ClickHereButton => WebDriver.FindElement(WindowsPageLocators.ClickHereButtonLocator);
        private string OriginalWindow;
        private string FirstNewTab;
        private string SecondNewTab;
        protected override string UrlPath => "/windows";
        public void Open()
        {
            var uri = new Uri("http://the-internet.herokuapp.com/windows", UriKind.Absolute);
            WebDriver.Navigate().GoToUrl(uri);
        }
        public void ClickClickHereButton()
        {
            OriginalWindow = WebDriver.CurrentWindowHandle;
            ClickHereButton.Click();
            JavaScriptExecutor.ExecuteScript("console.log(arguments[0])", WebDriver.WindowHandles);
        }
        public bool IsInFirstNewTab
        {
            get
            {
                bool isInFirstNewTab;
                try
                {
                    WebDriverWait.Until(driver => driver.WindowHandles.Count == 2);
                    isInFirstNewTab = WebDriver.CurrentWindowHandle == FirstNewTab;
                }
                catch (Exception e)
                {
                    isInFirstNewTab = false;
                }

                return isInFirstNewTab;
            }
        }
        public bool IsInSecondNewTab
        {
            get
            {
                bool isInSecondNewTab;
                try
                {
                    WebDriverWait.Until(driver => driver.WindowHandles.Count == 3);
                    isInSecondNewTab = WebDriver.CurrentWindowHandle == SecondNewTab;
                }
                catch (Exception e)
                {
                    isInSecondNewTab = false;
                }

                return isInSecondNewTab;
            }
        }
        public bool IsFirstNewTabClosed
        {
            get
            {
                bool isFirstNewTabClosed;
                try
                {
                    isFirstNewTabClosed = WebDriver.WindowHandles.Count == 2;
                }
                catch (Exception e)
                {
                    isFirstNewTabClosed = false;
                }

                return isFirstNewTabClosed;
            }
        }
        public bool IsOriginalTabClosed
        {
            get
            {
                bool isOriginalTabClosed;
                try
                {
                    isOriginalTabClosed = WebDriver.WindowHandles.Count == 1;
                }
                catch (Exception e)
                {
                    isOriginalTabClosed = false;
                }

                return isOriginalTabClosed;
            }
        }
        public void GoToFirstNewTab()
        {
            FirstNewTab = WebDriver.WindowHandles[1];
            WebDriver.SwitchTo().Window(FirstNewTab);
        }
        public void GoToSecondNewTab()
        {
            SecondNewTab = WebDriver.WindowHandles[1];
            WebDriver.SwitchTo().Window(SecondNewTab);
        }
        public void GoBackFirstNewTab()
        {
            WebDriver.SwitchTo().Window(FirstNewTab);
        }
        public void GoBackSecondNewTab()
        {
            WebDriver.SwitchTo().Window(WebDriver.WindowHandles[0]);
        }
        public void GoToOriginalTab()
        {
            WebDriver.SwitchTo().Window(OriginalWindow);
        }
        public void CloseCurrentTab()
        {
            WebDriver.Close();
        }
    }
}
