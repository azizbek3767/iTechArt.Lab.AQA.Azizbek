using OpenQA.Selenium;

namespace PracticalExam4.Core.Locators
{
    internal static class HomePageLocators
    {
        public static readonly By TestTaskButtonLocator = By.XPath("//a[@href=\"#test-task\"]");
        public static readonly By YearPickerButtonLocator = By.XPath("//div[contains(@class,\"v-picker__title__btn v-date-picker-title__year\")]");
        public static readonly By SelectedDatesLocator = By.XPath("//button[contains(@class,\"v-btn--active\")]");
    }
}
