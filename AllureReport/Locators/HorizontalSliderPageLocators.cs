using OpenQA.Selenium;

namespace SeleniumAdvancedPartTwo.Locators
{
    public static class HorizontalSliderPageLocators
    {
        public static readonly By RangeInputLocator =
            By.XPath("//input[@type=\"range\"]");
        public static readonly By RangeSpanLocator =
            By.XPath("//span[@id=\"range\"]");
    }
}
