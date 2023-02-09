using OpenQA.Selenium;
using PracticalExam3.DriverConfiguration;
using PracticalExam3.Pages;

namespace PracticalExam3.Tests
{
    public abstract class BaseTest
    {
        protected IWebDriver WebDriver { get; private set; }


        protected HomePage HomePage { get; private set; }
        protected LoginFormPage LoginFormPage { get; private set; }
        protected AvatarAndInterestsPage AvatarAndInterestsPage { get; private set; }

        [SetUp]
        public void SetUp()
        {
            WebDriver = new WebDriverFactory().GetDriver();
            WebDriver.Manage().Window.Maximize();

            HomePage = new HomePage(WebDriver);
            LoginFormPage = new LoginFormPage(WebDriver);
            AvatarAndInterestsPage = new AvatarAndInterestsPage(WebDriver);
        }

        [TearDown]
        public void TearDown()
        {
            WebDriver.Quit();
        }
    }
}
