using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace BDDForSelenimSaucedemo.Tests
{
    [Binding]
    public class LoginSteps
    {
        private HomePage _homePage;

        [Given(@"Open a website")]
        public void GivenOpenAWebsite()
        {
            var _driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            _driver.Manage().Window.Maximize();

            _homePage = new HomePage(_driver);
            _homePage.Open("https://www.saucedemo.com/");
        }

        [Given(@"Fill in the form")]
        public void GivenFillInTheForm()
        {
            _homePage.FillInUsernameField("standard_user");
            _homePage.FillInPasswordField("secret_sauce");
        }

        [Given(@"Submit the form")]
        public void GivenSubmitTheForm()
        {
            _homePage.ClickLoginButton();
        }

        [Then(@"User should be logged in successfully")]
        public void ThenUserShouldBeLoggedInSuccessfully()
        {
            Assert.AreEqual(_homePage.GetCurrentUrl(), "https://www.saucedemo.com/inventory.html");
        }

        [Then(@"Get redirected to the Main Page")]
        public void ThenGetRedirectedToTheMainPage()
        {
            Assert.IsTrue(_homePage.HomePageLogoExists());
        }

        [Then(@"Quit browser")]
        public void ThenQuitBrowser()
        {
            _homePage.CloseBrowser();
        }

    }
}
