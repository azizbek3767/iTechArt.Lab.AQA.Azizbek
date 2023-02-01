using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PageObjectPattert.Lection.Pages;
using SeleniumAdvancedPartOne.Locators;
using SeleniumAdvancedPartOne.Utilities;
using SeleniumExtras.WaitHelpers;
using System;

namespace SeleniumAdvancedPartOne.Pages
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver webDriver) : base(webDriver)
        {
        }
        private IWebElement AlertsFrameAndWindowsButton => WebDriver.FindElement(HomePageLocators.AlertsFrameAndWindowsButtonLocator);
        private IWebElement AlertsButton => WebDriver.FindElement(HomePageLocators.AlertsButtonLocator);
        private IWebElement AlertsForm => WebDriver.FindElement(HomePageLocators.AlertsFormLocator);
        private IWebElement SimpleAlertButton => WebDriver.FindElement(HomePageLocators.SimpleAlertButtonLocator);
        private IWebElement ConfirmBoxButton => WebDriver.FindElement(HomePageLocators.ConfirmBoxButtonLocator);
        private IWebElement ConfirmBoxConfirmationText => WebDriver.FindElement(HomePageLocators.ConfirmBoxConfirmationTextLocator);
        private IWebElement PromptButton => WebDriver.FindElement(HomePageLocators.PromptButtonLocator);
        private IWebElement PromptResult => WebDriver.FindElement(HomePageLocators.PromptResultLocator);
        private IWebElement NestedFramesButton => WebDriver.FindElement(HomePageLocators.NestedFramesButtonLocator);
        private IWebElement ParentFrame => WebDriver.FindElement(HomePageLocators.ParentFrameLocator);
        private IWebElement ChildFrame => WebDriver.FindElement(HomePageLocators.ChildFrameLocator);
        private IWebElement FramesButton => WebDriver.FindElement(HomePageLocators.FramesButtonLocator);
        private IWebElement FirstFrame => WebDriver.FindElement(HomePageLocators.FirstFrameLocator);
        private IWebElement SecondFrame => WebDriver.FindElement(HomePageLocators.SecondFrameLocator);
        private IWebElement WidgetsButton => WebDriver.FindElement(HomePageLocators.WidgetsButtonLocator);
        private IWebElement ProgressBarButton => WebDriver.FindElement(HomePageLocators.ProgressBarButtonLocator);
        private IWebElement ProgressBar => WebDriver.FindElement(HomePageLocators.ProgressBarLocator);
        private IWebElement StartStopButton => WebDriver.FindElement(HomePageLocators.StartStopButtonLocator);
        private IWebElement UniqueProgressBarState => WebDriver.FindElement(HomePageLocators.UniqueProgressBarStateLocator);
        private string randomString = string.Empty;
        protected override By UniqueWebLocator => HomePageLocators.HomePageUniqueLocator;

        protected override string UrlPath => string.Empty;

        public void ClickAlertsFrameAndWindowsButton()
        {
            AlertsFrameAndWindowsButton.Click();
            SafeWaitForPageLoadViaJs();
        }

        public void ClickAlertsButton()
        {
            JavaScriptExecutor.ExecuteScript("arguments[0].scrollIntoView(true);", AlertsButton);
            JavaScriptExecutor.ExecuteScript("arguments[0].click()", AlertsButton);
            SafeWaitForPageLoadViaJs();
        }

        public void ClickSimpleAlertButton()
        {
            SimpleAlertButton.Click();
        }

        public bool IsAlertsFormAppeared
        {
            get
            {
                bool isAlertsFormAppeared;
                try
                {
                    WebDriverWait.Until(ExpectedConditions.ElementIsVisible(HomePageLocators.AlertsFormLocator));
                    isAlertsFormAppeared = AlertsForm.Displayed;
                }
                catch (Exception e)
                {
                    isAlertsFormAppeared = false;
                }

                return isAlertsFormAppeared;
            }
        }

        public bool IsSimpleAlertAppeared
        {
            get
            {
                bool isSimpleAlertAppeared;
                try
                {
                    IAlert alert = WebDriverWait.Until(ExpectedConditions.AlertIsPresent());
                    string text = alert.Text;
                    isSimpleAlertAppeared = text == "You clicked a button";
                }
                catch (Exception e)
                {
                    isSimpleAlertAppeared = false;
                }

                return isSimpleAlertAppeared;
            }
        }

        public bool IsAlertExists
        {
            get
            {
                try
                {
                    WebDriver.SwitchTo().Alert();
                    return true;
                }
                catch (NoAlertPresentException Ex)
                {
                    return false;
                }
            }
        }

        public void AcceptAlert()
        {
            IAlert alert = ExpectedConditions.AlertIsPresent().Invoke(WebDriver);
            alert.Accept();
        }

        public void ClickConfirmBoxButton()
        {
            ConfirmBoxButton.Click();
        }

        public bool IsConfirmBoxAlertPresent
        {
            get
            {
                bool isConfirmBoxAlertPresent;
                try
                {
                    WebDriverWait.Until(ExpectedConditions.AlertIsPresent());
                    IAlert alert = WebDriver.SwitchTo().Alert();
                    string text = alert.Text;
                    isConfirmBoxAlertPresent = text == "Do you confirm action?";
                }
                catch (NoAlertPresentException Ex)
                {
                    isConfirmBoxAlertPresent = false;
                }
                return isConfirmBoxAlertPresent;
            }
        }
        public bool IsConfirmBoxConfirmationTextPresent
        {
            get
            {
                bool isConfirmBoxConfirmationTextPresent;
                try
                {
                    isConfirmBoxConfirmationTextPresent = ConfirmBoxConfirmationText.Displayed;
                }
                catch (NoAlertPresentException Ex)
                {
                    isConfirmBoxConfirmationTextPresent = false;
                }
                return isConfirmBoxConfirmationTextPresent;
            }
        }

        public void ClickOkInConfirmBox()
        {
            IAlert alert = WebDriver.SwitchTo().Alert();
            alert.Accept();
        }

        public void ClickPromptButton()
        {
            PromptButton.Click();
        }

        public bool IsPromptBoxAlertPresent
        {
            get
            {
                bool isPromptBoxAlertPresent;
                try
                {
                    WebDriverWait.Until(ExpectedConditions.AlertIsPresent());
                    IAlert alert = WebDriver.SwitchTo().Alert();
                    string text = alert.Text;
                    isPromptBoxAlertPresent = text == "Please enter your name";
                }
                catch (NoAlertPresentException Ex)
                {
                    isPromptBoxAlertPresent = false;
                }
                return isPromptBoxAlertPresent;
            }
        }

        public void FillInAndSubmitPromptBox()
        {
            IAlert alert = WebDriver.SwitchTo().Alert();
            randomString = HelperMethods.RandomString(10);
            alert.SendKeys(randomString);
            alert.Accept();
        }
        public bool IsPromptResultCorrect
        {
            get
            {
                bool isPromptResultCorrect;
                try
                {
                    isPromptResultCorrect = PromptResult.Text.Contains(randomString);
                   /* var promptResultArray = PromptResult.Text.Split(' ');
                    isPromptResultCorrect = promptResultArray[0] == randomString;*/
                }
                catch (NoAlertPresentException Ex)
                {
                    isPromptResultCorrect = false;
                }
                return isPromptResultCorrect;
            }
        }

        public void ClickNestedFramesButton()
        {
            JavaScriptExecutor.ExecuteScript("arguments[0].scrollIntoView(true);", NestedFramesButton);
            NestedFramesButton.Click();
        }

        public bool IsNestedFramesPageOpen
        {
            get
            {
                bool isNestedFramesPageOpen;
                try
                {
                    isNestedFramesPageOpen = ParentFrame.Displayed;
                }
                catch (NoAlertPresentException Ex)
                {
                    isNestedFramesPageOpen = false;
                }
                return isNestedFramesPageOpen;
            }
        }
        public bool IsParentFrameDisplayed
        {
            get
            {
                bool isParentFrameDisplayed;
                try
                {
                    isParentFrameDisplayed = ParentFrame.Displayed;
                }
                catch (NoAlertPresentException Ex)
                {
                    isParentFrameDisplayed = false;
                }
                return isParentFrameDisplayed;
            }
        }
        public bool IsChildFrameDisplayed
        {
            get
            {
                bool isChildFrameDisplayed;
                try
                {
                    WebDriver.SwitchTo().Frame(ParentFrame);
                    isChildFrameDisplayed = ChildFrame.Displayed;
                }
                catch (NoAlertPresentException Ex)
                {
                    isChildFrameDisplayed = false;
                }
                return isChildFrameDisplayed;
            }
        }

        public void ClickFramesButton()
        {
            WebDriver.SwitchTo().ParentFrame();
            JavaScriptExecutor.ExecuteScript("arguments[0].scrollIntoView(true);", FramesButton);
            FramesButton.Click();
        }
        public bool IsFramesPageOpen
        {
            get
            {
                bool isFramesPageOpen;
                try
                {
                    isFramesPageOpen = FirstFrame.Displayed;
                }
                catch (NoAlertPresentException Ex)
                {
                    isFramesPageOpen = false;
                }
                return isFramesPageOpen;
            }
        }

        public bool CheckTextsFromFrames
        {
            get
            {
                bool isTextsAreEqual;
                try
                {
                    var textFromFirstFrame = string.Empty;
                    var textFromSecondFrame = string.Empty;
                    WebDriver.SwitchTo().Frame(FirstFrame);
                    textFromFirstFrame = WebDriver.FindElement(By.XPath("//h1[@id=\"sampleHeading\"]")).Text;
                    WebDriver.SwitchTo().ParentFrame();
                    WebDriver.SwitchTo().Frame(SecondFrame);
                    textFromSecondFrame = WebDriver.FindElement(By.XPath("//h1[@id=\"sampleHeading\"]")).Text;
                    WebDriver.SwitchTo().ParentFrame();
                    isTextsAreEqual = textFromFirstFrame == textFromSecondFrame;
                }
                catch
                {
                    isTextsAreEqual = false;
                }
                return isTextsAreEqual;
            }
        }

        public void ClickProgressBarButton()
        {
            JavaScriptExecutor.ExecuteScript("arguments[0].scrollIntoView(true);", ProgressBarButton);
            ProgressBarButton.Click();
        }
        public bool IsWidgetsPageOpen
        {
            get
            {
                bool isWidgetsPageOpen;
                try
                {
                    isWidgetsPageOpen = ProgressBar.Displayed;
                }
                catch (NoAlertPresentException Ex)
                {
                    isWidgetsPageOpen = false;
                }
                return isWidgetsPageOpen;
            }
        }
        public bool IsProgressBarPageOpen
        {
            get
            {
                bool isProgressBarPageOpen;
                try
                {
                    isProgressBarPageOpen = ProgressBar.Displayed;
                }
                catch (NoAlertPresentException Ex)
                {
                    isProgressBarPageOpen = false;
                }
                return isProgressBarPageOpen;
            }
        }

        private void StartProgressBar()
        {
            StartStopButton.Click();
        }
        private void StopProgressBar()
        {
            StartStopButton.Click();
        }

        public void StopAtUniquePercent()
        {
            StartProgressBar();
            WebDriverWait.Until(ExpectedConditions.ElementIsVisible(HomePageLocators.UniqueProgressBarStateLocator));
            StopProgressBar();
        }
        public void OpenWidgetsPage()
        {
            WebDriver.Navigate().GoToUrl("https://demoqa.com/widgets");
        }
    }
}
