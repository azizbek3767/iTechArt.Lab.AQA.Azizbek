using OpenQA.Selenium;
using Saucedemo.Core.Models;
using Saucedemo.Page.Pages;

namespace Saucedemo.Page.Steps
{
    public class CheckoutPageSteps
    {
        private IWebDriver WebDriver { get; set; }
        public CheckoutPageSteps(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }

        private CheckoutStepOnePage CheckoutStepOnePage => new CheckoutStepOnePage(WebDriver);
        private CheckoutCompletePage CheckoutCompletePage => new CheckoutCompletePage(WebDriver);
        public CheckoutPageSteps FillInCheckoutUserDetailsForm(CheckoutUserRequestModel checkoutUserRequestModel)
        {
            CheckoutStepOnePage.InputFirstName(checkoutUserRequestModel.FirstName);
            CheckoutStepOnePage.InputLastName(checkoutUserRequestModel.LastName);
            CheckoutStepOnePage.InputZipCode(checkoutUserRequestModel.ZipCode);
            return this;
        }
        public CheckoutPageSteps ClickContinueButton()
        {
            CheckoutStepOnePage.ContinueButton.Click();
            return this;
        }
        public CheckoutPageSteps ClickFinishButton()
        {
            CheckoutStepOnePage.FinishButton.Click();
            return this;
        }
        public bool IsCheckoutCompletePageOpened
        {
            get
            {
                bool isCheckoutCompletePageOpened;
                try
                {
                    isCheckoutCompletePageOpened = CheckoutCompletePage.IsPageOpened;
                }
                catch (Exception e)
                {
                    isCheckoutCompletePageOpened = false;
                }

                return isCheckoutCompletePageOpened;
            }
        }
        public bool IsCheckoutSuccessful
        {
            get
            {
                bool isCheckoutSuccessful;
                try
                {
                    isCheckoutSuccessful = CheckoutCompletePage.CheckoutConfirmationLabel.IsDisplayed();
                }
                catch (Exception e)
                {
                    isCheckoutSuccessful = false;
                }

                return isCheckoutSuccessful;
            }
        }
    }
}
