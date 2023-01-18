using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace SeleniumWebDriverBasics.Unit.Tests
{
    [TestFixture]
    internal class SeleniumBasics
    {
        private IWebDriver _driver;

        [SetUp]
        public void SetupDriver()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test()
        {
            var HomePage = new HomePage(_driver);
            HomePage.Open("http://onliner.by/");
            HomePage.MobilePhonesButton.Click();


            Actions actions = new Actions(_driver);

            actions.SendKeys(Keys.PageDown).Build().Perform();

            //actions.MoveToElement(HomePage.AppleManufacturerCheckbox).Click().Build().Perform();
            HomePage.AppleManufacturerCheckbox.Click();
            Assert.That(HomePage.AppleCheckboxInput.Selected, Is.True);
            
            //actions.MoveToElement(HomePage.HonorManufacturerCheckbox).Click().Build().Perform();
            HomePage.HonorManufacturerCheckbox.Click();
            Assert.That(HomePage.HonorCheckboxInput.Selected, Is.True);
            
            actions.MoveToElement(HomePage.HonorManufacturerCheckbox).Click().Build().Perform();

            actions.MoveToElement(HomePage.FirstItemWithClass).Click().Build().Perform();
            //HomePage.FirstItemWithClass.Click();
            
            actions.MoveToElement(HomePage.ThirdItemWithClass).Click().Build().Perform();
            //HomePage.ThirdItemWithClass.Click();

            Assert.That(HomePage.SpanForComparison.Text, Is.EqualTo("2 товара"));
            actions.MoveToElement(HomePage.ButtonWithTwoElementsToCompare).Click().Build().Perform();
            actions.MoveToElement(HomePage.SpanWithOverview).Perform();
            Assert.That(HomePage.SpanWithOverview.Text, Is.EqualTo("Описание"));

            _driver.Navigate().Back();
        }

        [TearDown]
        public void TeardownDriver()
        {
            _driver.Quit();
        }
    }
}
