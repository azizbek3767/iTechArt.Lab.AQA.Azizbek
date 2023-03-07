using OpenQA.Selenium;
using PracticalExam4.Core.Locators;

namespace PracticalExam4.Core.Pages
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver webDriver) : base(webDriver)
        {
        }

        protected override By UniqueWebLocator => By.XPath("//pre[contains(text(), \"Using any automation/testing software\")]");

        protected override string UrlPath => string.Empty;
        public IWebElement TestTaskButton => WebDriver.FindElement(HomePageLocators.TestTaskButtonLocator);
        public IWebElement YearPickerButton => WebDriver.FindElement(HomePageLocators.YearPickerButtonLocator);
        public IEnumerable<IWebElement> SelectedDates => WebDriver.FindElements(HomePageLocators.SelectedDatesLocator);

        public void ClickTestTaskButton()
        {
            TestTaskButton.Click(); 
        }
        public void ClearSelectedDatas()
        {
            foreach (var selectedDate in SelectedDates)
            {
                selectedDate.Click();
            }
        }
        public void PickDate(int dateNumber)
        {
            var minDate = DateTime.Parse("1918-01-01");
            var maxDate = DateTime.Parse("2118-12-31");
            try
            {
                var selectedDate = DateTime.Now.AddDays(dateNumber);
                if(selectedDate < minDate) 
                {
                    selectedDate = minDate;
                }
                if(selectedDate > maxDate) 
                {
                    selectedDate = maxDate;
                }
                YearPickerButton.Click();
                WebDriver.FindElement(By.XPath(string.Format("//li[contains(text(), \"{0}\")]", selectedDate.Year))).Click();
                WebDriver.FindElement(By.XPath(string.Format("//div[contains(@class,\"v-btn__content\") and contains(text(),\"{0}\")]", selectedDate.ToString("MMM dd").Split(" ")[0]))).Click();
                WebDriver.FindElement(By.XPath(string.Format("//div[@class=\"v-btn__content\" and text()=\"{0}\"]", selectedDate.Day))).Click();
            }
            catch 
            {
                throw new ArgumentOutOfRangeException("The date is too low or high");
            }

        }
    }
}
