using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using SeleniumWebDriverBasics.Locators;
using Microsoft.Extensions.Configuration;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace SeleniumWebDriverBasics.Unit.Tests
{
    [TestFixture]
    internal class SeleniumBasics
    {
        private IWebDriver _driver;
        private IJavaScriptExecutor _executor;

        private IConfigurationBuilder _builder;

        [SetUp]
        public void SetupDriver()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(7);
            _driver.Manage().Window.Maximize();
            _executor = (IJavaScriptExecutor)_driver;
        }

        [Test]
        public void Test()
        {
            var HomePage = new HomePage(_driver);

            // 1.Зайти на страницу http://onliner.by/
            HomePage.Open("http://onliner.by/");
            // Ожидаемый результат: Главная страница onliner открылась
            Assert.AreEqual("https://www.onliner.by/", _driver.Url);

            // 2.Открыть вкладку «мобильные телефоны»
            HomePage.MobilePhonesButton.Click();
            // Ожидаемый результат: Нужная вкладка открыта
            Assert.AreEqual("https://catalog.onliner.by/mobile", _driver.Url);

            // 3.Из списка производителей выбрать: Apple, Honor
            Actions actions = new Actions(_driver);
            var AppleManufacturerSpan = _driver.FindElement(HomePageLocators.AppleManufacturerSpanLocator);
            _executor.ExecuteScript("arguments[0].click();", AppleManufacturerSpan);
            Assert.That(_driver.FindElement(HomePageLocators.AppleManufacturerInputLocator).Selected, Is.True);

            var HonorManufacturerSpan = _driver.FindElement(HomePageLocators.HonorManufacturerSpanLocator);
            _executor.ExecuteScript("arguments[0].click();", HonorManufacturerSpan);
            Assert.That(_driver.FindElement(HomePageLocators.HonorManufacturerInputLocator).Selected, Is.True);

            // 4.В отобразившемся списке удалить Honor
            _executor.ExecuteScript("arguments[0].click();", HonorManufacturerSpan);
            Assert.That(_driver.FindElement(HomePageLocators.HonorManufacturerInputLocator).Selected, Is.False);

            // Ожидаемый результат: В списке нет моделей с назвнием Honor
            var Phones = _driver.FindElements(HomePageLocators.PhonesListLocator);
            foreach(var Phone in Phones)
            {
                Assert.That(Phone.Text, Does.Not.Contain("Honor"));
            }

            // 5.Из списка оставшихся телефоном выбрать 1-ый и 3-ий (поставить чекбокс)
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"schema-products\"]/div[2]/div/div[3]/div[2]/div[1]/a/span[contains(text(), 'Apple')]")));
           
            var FirstItemCheckboxLabel = _driver.FindElement(HomePageLocators.FirstItemCheckboxLabel);
            _executor.ExecuteScript("arguments[0].click();", FirstItemCheckboxLabel);
            var FirstItemCheckboxInput = _driver.FindElement(HomePageLocators.FirstItemCheckboxInput);
            Assert.IsTrue(FirstItemCheckboxInput.Selected);

            var ThirdItemCheckboxLabel = _driver.FindElement(HomePageLocators.ThirdItemCheckboxLabel);
            _executor.ExecuteScript("arguments[0].click();", ThirdItemCheckboxLabel);
            var ThirdItemCheckboxInput = _driver.FindElement(HomePageLocators.ThirdItemCheckboxInput);
            Assert.IsTrue(ThirdItemCheckboxInput.Selected);

            //Ожидаемый результат: Проверить, что в сравнении 2 товара
            Assert.That(HomePage.SpanForComparison.Text, Is.EqualTo("2 товара"));

            //6.Открыть страницу Сравнения
            actions.MoveToElement(HomePage.ButtonWithTwoElementsToCompare).Click().Build().Perform();
            //Ожидаемый результат: Страница сравнения открыта
            Assert.AreEqual("https://catalog.onliner.by/compare/appl2bmwlt2+appl2amq6g2", _driver.Url);

            //7.Навести курсор на «Описание» 
            //Ожидаемый результат: Окно с текстом открылось
            actions.MoveToElement(HomePage.SpanWithOverview).Perform();

            //8.Проверить что текст в окне равен тексту «Описание
            Assert.That(HomePage.SpanWithOverview.Text, Is.EqualTo("Описание"));

            //9.Открыть предыдущую страницу
            _driver.Navigate().Back();
            //Ожидаемый результат: Страница со списков телефонов Apple открыта
            Assert.AreEqual("https://catalog.onliner.by/mobile/apple", _driver.Url);
        }

        [TearDown]
        public void TeardownDriver()
        {
            _driver.Quit();
        }
    }
}
