using OpenQA.Selenium;

namespace SeleniumAdvancedPartOne.Locators
{
    public static class HomePageLocators
    {
        public static readonly By HomePageUniqueLocator =
            By.XPath("//*[@id=\"app\"]/div/div/div[1]/a/img");
        public static readonly By AlertsFrameAndWindowsButtonLocator =
            By.XPath("//*[@id=\"app\"]/div/div/div[2]/div/div[3]");
        public static readonly By AlertsButtonLocator =
            By.XPath("//span[text()=\"Alerts\"]");
        public static readonly By AlertsFormLocator =
            By.XPath("//*[@id=\"javascriptAlertsWrapper\"]");
        public static readonly By SimpleAlertButtonLocator =
            By.XPath("//button[@id=\"alertButton\"]");
        public static readonly By ConfirmBoxButtonLocator =
            By.XPath("//button[@id=\"confirmButton\"]");
        public static readonly By ConfirmBoxConfirmationTextLocator =
            By.XPath("//span[@id=\"confirmResult\"]");
        public static readonly By PromptButtonLocator =
            By.XPath("//button[@id=\"promtButton\"]");
        public static readonly By PromptResultLocator =
            By.XPath("//span[@id=\"promptResult\"]");
        public static readonly By NestedFramesButtonLocator =
            By.XPath("//span[text() = \"Nested Frames\"]");
        public static readonly By ParentFrameLocator =
            By.XPath("//iframe[@id=\"frame1\"]");
        public static readonly By ChildFrameLocator =
            By.XPath("//iframe[@srcdoc=\"<p>Child Iframe</p>\"]");
        public static readonly By FramesButtonLocator =
            By.XPath("//span[text()=\"Frames\"]");
        public static readonly By FirstFrameLocator =
            By.XPath("//iframe[@id=\"frame1\"]");
        public static readonly By SecondFrameLocator =
            By.XPath("//iframe[@id=\"frame2\"]");
        public static readonly By WidgetsButtonLocator =
            By.XPath("//div[text()=\"Widgets\"]");
        public static readonly By ProgressBarButtonLocator =
            By.XPath("//span[text()=\"Progress Bar\"]");
        public static readonly By ProgressBarLocator =
            By.XPath("//div[@id=\"progressBar\"]");
        public static readonly By StartStopButtonLocator =
            By.XPath("//button[@id=\"startStopButton\"]");
        public static readonly By UniqueProgressBarStateLocator =
            By.XPath("//div[@aria-valuenow=\"46\"]");
    }
}
