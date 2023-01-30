using OpenQA.Selenium;
using PageObjectPattert.Lection.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAdvancedPartOne.Tests
{
    public class TaskTwoTests : BaseTest
    {
        [Test]
        public void CheckTheAlertsOnTheWebSite()
        {
            //1.Перейти на главную страницу
            HomePage.OpenPage();
            //Ожидаемый результат: Главная страница открыта
            Assert.True(HomePage.IsPageOpened, "Homepage should be opened");

            //2.Кликнуть на кнопку Alerts, Frame & Windows.
            HomePage.ClickAlertsFrameAndWindowsButton();
            //На открывшейся странице в левом меню кликнуть пункт Nested Frames
            HomePage.ClickNestedFramesButton();
            //Ожидаемый результат: Открыта страница с формой Nested Frames. В центре страницы присутствуют надписи "Parent frame" и "Child Iframe"
            Assert.True(HomePage.IsNestedFramesPageOpen, "Nested Frames Page should be open");
            Assert.True(HomePage.IsParentFrameDisplayed, "Parent frame should be displayed");
            Assert.True(HomePage.IsChildFrameDisplayed, "Child frame should be displayed");

            //3.В левом меню выбрать пункт Frames
            HomePage.ClickFramesButton();
            //Ожидаемый результат: Открыта страница с формой Frames.Надпись из верхнего фрейма соответствует надписи из нижнего
            Assert.True(HomePage.IsFramesPageOpen, "Frames page should be opened");
            Assert.True(HomePage.CheckTextsFromFrames, "Texts from both frames should be equal");
        }
    }
}
