using PageObjectPattert.Lection.Tests;
using SeleniumAdvancedPartOne.Pages;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAdvancedPartOne.Tests
{
    public class TaskThreeTests : BaseTest
    {
        [Test]
        public void CheckProgressBarTest()
        {
            //1.	Перейти на страницу ToolsQA(demoqa.com)
            HomePage.OpenWidgetsPage();
            //Ожидаемый результат: Страница открыта 
            Assert.True(HomePage.IsWidgetsPageOpen, "Widgets Page should be opened");

            //2.	В левом меню выбрать пункт Progress Bar
            //HomePage.ClickWidgetsButton();
            HomePage.ClickProgressBarButton();
            //Ожидаемый результат: Открыта страница с формой Progress Bar 
            Assert.True(HomePage.IsProgressBarPageOpen, "Progress bar page should be opened");

            //3.	Нажать кнопку Start
            //4.	Когда счетчик дойдет до 46%(допускается погрешность +-5%) нажать Stop
            HomePage.StopAtUniquePercent();
        }
    }
}
