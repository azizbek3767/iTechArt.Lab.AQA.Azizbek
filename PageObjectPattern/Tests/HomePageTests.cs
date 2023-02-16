using Allure.Net.Commons;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using PageObjectPattern.Locators;
using PageObjectPattern.Pages;

namespace PageObjectPattern.Tests
{
    [TestFixture]
    [AllureNUnit]
    internal class HomePageTests : BaseTest
    {
        [Test]
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureIssue("Issue - 2")]
        [AllureTms("Tms-13")]
        [AllureOwner("Azizbek")]
        [AllureSuite("Onliner")]
        [AllureSubSuite("Positive")]
        public void Test()
        {
            // 1.Зайти на страницу http://onliner.by/
            HomePage.OpenPage();
            // Ожидаемый результат: Главная страница onliner открылась
            Assert.True(HomePage.IsHomePageOpened, "HomePage should be opened");

            // 2.Открыть вкладку «мобильные телефоны»
            MobilePhonesPage.OpenPage();
            // Ожидаемый результат: Нужная вкладка открыта
            Assert.True(MobilePhonesPage.IsPageOpened, "MobilePhonesPage should be opened");

            // 3.Из списка производителей выбрать: Apple, Honor
            MobilePhonesPage.SelectAppleAndHonor();
            Assert.That(WebDriver.FindElement(HomePageLocators.AppleManufacturerInputLocator).Selected, Is.True);
            Assert.That(WebDriver.FindElement(HomePageLocators.HonorManufacturerInputLocator).Selected, Is.True);

            // 4.В отобразившемся списке удалить Honor
            MobilePhonesPage.UnselectHonor();
            Assert.That(WebDriver.FindElement(HomePageLocators.HonorManufacturerInputLocator).Selected, Is.False);

            // Ожидаемый результат: В списке нет моделей с назвнием Honor
            Assert.True(MobilePhonesPage.IsOnlyIphones, "Only Iphones are on the list");

            // 5.Из списка оставшихся телефоном выбрать 1-ый и 3-ий (поставить чекбокс)
            MobilePhonesPage.SelectFirstAndThirdItemCheckboxes();
            Assert.IsTrue(MobilePhonesPage.FirstItemCheckboxInput.Selected);
            Assert.IsTrue(MobilePhonesPage.ThirdItemCheckboxInput.Selected);

            //Ожидаемый результат: Проверить, что в сравнении 2 товара
            Assert.That(HomePage.SpanForComparison.Text, Is.EqualTo("2 товара"));

            //6.Открыть страницу Сравнения
            MobilePhonesPage.GoToComparePageWithSelectedItems();
            //Ожидаемый результат: Страница сравнения открыта
            Assert.True(ComparePage.IsPageOpened, "Compare Page should be opened");

            //7.Навести курсор на «Описание» 
            //Ожидаемый результат: Окно с текстом открылось
            ComparePage.GoToDefinition();

            //8.Проверить что текст в окне равен тексту «Описание
            Assert.That(HomePage.SpanWithOverview.Text, Is.EqualTo("Описание"));

            //9.Открыть предыдущую страницу
            ComparePage.BackToMobilePhonesPage();
            //Ожидаемый результат: Страница со списков телефонов Apple открыта
            Assert.True(MobilePhonesPage.IsPageOpened, "MobilePhonesPage should be opened");
            Assert.That(WebDriver.Url.Contains("apple"));
        }
    }
}
