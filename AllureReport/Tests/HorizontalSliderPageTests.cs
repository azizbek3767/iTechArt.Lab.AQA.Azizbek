namespace SeleniumAdvancedPartTwo.Tests
{
    internal class HorizontalSliderPageTests : BaseTest
    {
        [Test]
        public void Check_Slider_Test()
        {
            //1.Перейти на главную страницу
            HorizontalSliderPage.Open();
            //Ожидаемый результат: Главная страница открыта
            Assert.True(HorizontalSliderPage.IsPageOpened, "Horizontal  Slider Page should be opened");
            //2.Установить случайное значение слайдера(отличное от граничных)
            HorizontalSliderPage.ChangeValueOfSlider(3);
            //Ожидаемый результат: Отображается корректное значение рядом со слайдером
            Assert.True(HorizontalSliderPage.IsSpanValueCorrect, "Span Range should be correct");
        }
    }
}
