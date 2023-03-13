using OpenQA.Selenium;
using Saucedemo.Core.Models;
using Saucedemo.Page.Pages;

namespace Saucedemo.Page.Steps
{
    public class CheckoutStepOnePageSteps
    {
        private IWebDriver WebDriver { get; set; }
        public CheckoutStepOnePageSteps(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }

        private CheckoutStepOnePage CheckoutStepOnePage => new CheckoutStepOnePage(WebDriver);
        private CheckoutCompletePage CheckoutCompletePage => new CheckoutCompletePage(WebDriver);
        public void FillInCheckoutUserDetailsForm(CheckoutUserRequestModel checkoutUserRequestModel)
        {
            CheckoutStepOnePage.InputFirstName(checkoutUserRequestModel.FirstName);
            CheckoutStepOnePage.InputLastName(checkoutUserRequestModel.LastName);
            CheckoutStepOnePage.InputZipCode(checkoutUserRequestModel.ZipCode);
        }
        public void ClickContinueButton()
        {
            CheckoutStepOnePage.ContinueButton.Click();
        }
        public void ClickFinishButton()
        {
            CheckoutStepOnePage.FinishButton.Click();
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