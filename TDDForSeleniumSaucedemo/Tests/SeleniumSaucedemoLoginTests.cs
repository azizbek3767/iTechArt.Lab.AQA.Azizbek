using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

[assembly: LevelOfParallelism(3)]
namespace TDDForSeleniumSaucedemo.Tests
{
    [SingleThreaded]
    [TestFixture]
    [FixtureLifeCycle(LifeCycle.SingleInstance)]
    internal class SeleniumSaucedemoLoginTests
    {
        private IWebDriver _driver;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            Console.WriteLine("I am OneTimeSetup");
        }

        [SetUp]
        public void SetupDriver()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            _driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void TeardownDriver()
        {
            _driver.Quit();
        }

        [Retry(3)]
        [Category("Login")]
        [Test(Description = "Testing the Login functionality of Saucedemo", Author = "Azizbek")]
        public void Test()
        {
            var HomePage = new HomePage(_driver);

            HomePage.Open("https://www.saucedemo.com/");
            HomePage.FillInUsernameField("standard_user");
            HomePage.FillInPasswordField("secret_sauce");
            HomePage.ClickLoginButton();
            Assert.AreEqual(HomePage.GetCurrentUrl(), "https://www.saucedemo.com/inventory.html");
            Assert.IsTrue(HomePage.HomePageLogoExists());
        }

        [Test]
        [Ignore("Ignore a test")]
        public void IgnoredTest()
        {
            Console.WriteLine("I am ignored test");
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            Console.WriteLine("I am OneTimeTearDown");
        }
    }
}
