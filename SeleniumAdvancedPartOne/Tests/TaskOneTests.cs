using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using PageObjectPattert.Lection.Tests;
using NUnit.Framework;

namespace SeleniumAdvancedPartOne.Tests
{
    internal class TaskOneTests : BaseTest
    {
        [Test]
        public void CheckTheAlertsOnTheWebSite()
        {
            //Задание 1:

            //1.Перейти на главную страницу https://demoqa.com/
            HomePage.OpenPage();
            //Ожидаемый результат: Главная страница открыта
            Assert.True(HomePage.IsPageOpened, "Homepage should be opened");

            //2.Кликнуть на кнопку Alerts, Frame & Windows.
            HomePage.ClickAlertsFrameAndWindowsButton();
            //На открывшейся странице в левом меню кликнуть пункт Alerts
            HomePage.ClickAlertsButton();
            //Ожидаемый результат: На странице появилась форма Alerts
            Assert.True(HomePage.IsAlertsFormAppeared, "Alerts Form should be appeared");

            //3.Нажать на кнопку Click Button to see alert
            HomePage.ClickSimpleAlertButton();
            //Ожидаемый результат: Открыт алерт с текстом "You clicked a button"
            Assert.True(HomePage.IsSimpleAlertAppeared, "Alert box should be appeared");

            //4.Нажать на кнопку OK
            HomePage.AcceptAlert();
            //Ожидаемый результат: Алерт закрылся
            Assert.False(HomePage.IsAlertExists, "Alert should be closed");

            //5.Нажать на кнопку On button click, confirm box will appear
            HomePage.ClickConfirmBoxButton();
            //Ожидаемый результат: Открыт алерт с текстом "Do you confirm action?"
            Assert.True(HomePage.IsConfirmBoxAlertPresent, "Confirm box should be appeared");

            //6.Нажать на кнопку OK
            HomePage.ClickOkInConfirmBox();
            //Ожидаемый результат: Алерт закрылся. Рядом с кнопкой появилась надпись "You selected Ok"
            Assert.True(HomePage.IsConfirmBoxConfirmationTextPresent, "Confirmbox confirmation text should be present");

            //7.Нажать на кнопку On button click, prompt box will appear
            HomePage.ClickPromptButton();
            //Ожидаемый результат: Открыт алерт с текстом "Please enter your name"
            Assert.True(HomePage.IsPromptBoxAlertPresent, "Prompt box present");

            //8.Ввести случайно сгенерированный текст, нажать на кнопку OK
            HomePage.FillInAndSubmitPromptBox();
            //Ожидаемый результат: Алерт закрылся
            Assert.False(HomePage.IsAlertExists, "Prompt box should be closed");
            //Появившийся текст соответствует введенному в алерт
            Assert.True(HomePage.IsPromptResultCorrect, "Prompt box result should be correct");
        }
    }
}
