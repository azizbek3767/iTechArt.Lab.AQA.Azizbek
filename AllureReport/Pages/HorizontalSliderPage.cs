using OpenQA.Selenium;
using SeleniumAdvancedPartTwo.Locators;

namespace SeleniumAdvancedPartTwo.Pages
{
    internal class HorizontalSliderPage : BasePage
    {
        public HorizontalSliderPage(IWebDriver webDriver) : base(webDriver)
        {
        }
        
        private IWebElement RangeInput => WebDriver.FindElement(HorizontalSliderPageLocators.RangeInputLocator);
        private IWebElement RangeSpan => WebDriver.FindElement(HorizontalSliderPageLocators.RangeSpanLocator);

        public void Open()
        {
            var uri = new Uri("http://the-internet.herokuapp.com/horizontal_slider", UriKind.Absolute);
            WebDriver.Navigate().GoToUrl(uri);
        }
        protected override By UniqueWebLocator => By.XPath("//h3[contains(text(), \"Horizontal Slider\")]");

        protected override string UrlPath => "/horizontal_slider/";
        public void ChangeValueOfSlider(int times)
        {
            for(var i = 0; i < times; i++)
            {
                RangeInput.SendKeys(Keys.Right);
            }
        }
        public bool IsSpanValueCorrect
        {
            get
            {
                bool isSpanValueCorrect;
                try
                {
                    isSpanValueCorrect = RangeSpan.Text == "1.5";
                }
                catch (Exception e)
                {
                    isSpanValueCorrect = false;
                }

                return isSpanValueCorrect;
            }
        }
    }
}
