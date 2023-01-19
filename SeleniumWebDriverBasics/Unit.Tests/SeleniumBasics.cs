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
            actions.SendKeys(Keys.PageDown).Build().Perform();
            _driver.FindElement(By.XPath("//*[@id='schema-filter']/div[5]/div[4]/div[2]/ul/li[1]/label/span[2]")).Click();
            Assert.That(_driver.FindElement(By.XPath("//*[@id='schema-filter']/div[5]/div[4]/div[2]/ul/li[1]/label/span[1]/input")).Selected, Is.True);
            _driver.FindElement(By.XPath("//*[@id='schema-filter']/div[5]/div[4]/div[2]/ul/li[5]/label/span[2]")).Click();
            Assert.That(_driver.FindElement(By.XPath("//*[@id='schema-filter']/div[5]/div[4]/div[2]/ul/li[5]/label/span[1]/input")).Selected, Is.True);

            // 4.В отобразившемся списке удалить Honor
            _driver.FindElement(By.XPath("//*[@id='schema-filter']/div[5]/div[4]/div[2]/ul/li[5]/label/span[2]")).Click();
            Assert.That(_driver.FindElement(By.XPath("//*[@id='schema-filter']/div[5]/div[4]/div[2]/ul/li[5]/label/span[1]/input")).Selected, Is.False);
            // Ожидаемый результат: В списке нет моделей с назвнием Honor
            var Phones = _driver.FindElements(By.XPath("//div[@class='schema-product__group']/div/div[3]/div[2]/div/a/span"));
            foreach(var Phone in Phones)
            {
                Assert.That(Phone.Text, Does.Not.Contain("Honor"));
            }

            // 5.Из списка оставшихся телефоном выбрать 1-ый и 3-ий (поставить чекбокс)
            actions.SendKeys(Keys.PageUp).Build().Perform();
            var FirstItemCheckbox = _driver.FindElement(By.XPath("//div[@class='schema-product__group']/div/div/div/div/label/span/input[1]"));
            FirstItemCheckbox.Click();
            Assert.That(FirstItemCheckbox.Selected, Is.True);

            actions.SendKeys(Keys.PageDown).Build().Perform();
            actions.SendKeys(Keys.PageDown).Build().Perform();
            var ThirdItemCheckbox = _driver.FindElement(By.XPath("//div[@class='schema-product__group']/div/div/div/div/label/span/input[3]"));
            ThirdItemCheckbox.Click();
            Assert.That(ThirdItemCheckbox.Selected, Is.True);

            //Ожидаемый результат: Проверить, что в сравнении 2 товара
            Assert.That(HomePage.SpanForComparison.Text, Is.EqualTo("2 товара"));

            //6.Открыть страницу Сравнения
            //Ожидаемый результат: Страница сравнения открыта
            actions.MoveToElement(HomePage.ButtonWithTwoElementsToCompare).Click().Build().Perform();

            //7.Навести курсор на «Описание» 
            //Ожидаемый результат: Окно с текстом открылось
            actions.MoveToElement(HomePage.SpanWithOverview).Perform();

            //8.Проверить что текст в окне равен тексту «Описание
            Assert.That(HomePage.SpanWithOverview.Text, Is.EqualTo("Описание"));

            //9.Открыть предыдущую страницу
            //Ожидаемый результат: Страница со списков телефонов Apple открыта
            _driver.Navigate().Back();




            // The below code is the old version 

            /*Actions actions = new Actions(_driver);
            actions.SendKeys(Keys.PageDown).Build().Perform();
            //actions.MoveToElement(HomePage.AppleManufacturerCheckbox);
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
            _driver.Navigate().Back();*/
        }

        [TearDown]
        public void TeardownDriver()
        {
            _driver.Quit();
        }
    }
}
