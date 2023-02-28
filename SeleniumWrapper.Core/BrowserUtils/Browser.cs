

using OpenQA.Selenium;

namespace SeleniumWrapper.Core.BrowserUtils
{
    public class Browser : IBrowser
    {
        public WebDriver WebDriver { get; }

        public Browser(WebDriver webDriver)
        {
            WebDriver = webDriver;
            MaximizeWindow();
            SetImplicitTime();
        }
        public void GoBack()
        {
            WebDriver.Navigate().Back();
        }
        public void GoForward()
        {
            WebDriver.Navigate().Forward();
        }
        public void Refresh()
        {
            WebDriver.Navigate().Refresh(); 
        }
        public string GetCurrentUrl()
        {
            return WebDriver.Url.ToString();
        }
        public void GoToUrl(Uri uri)
        {
            GoToUrl(uri.ToString());
        }
        public string GetTitle()
        {
            return WebDriver.Title.ToString();
        }
        public void GoToUrl(string uri)
        {
            WebDriver.Navigate().GoToUrl(uri);
        }
        public void Close()
        {
            WebDriver.Close();
        }

        public void Quit()
        {
            WebDriver.Quit();
        }
        public string GetPageSource()
        {
            return WebDriver.PageSource.ToString();
        }

        private void MaximizeWindow()
        {
            WebDriver.Manage().Window.Maximize();
        }

        private void SetImplicitTime()
        {
            WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        public bool IsStarted => WebDriver.SessionId != null;
    }
}
