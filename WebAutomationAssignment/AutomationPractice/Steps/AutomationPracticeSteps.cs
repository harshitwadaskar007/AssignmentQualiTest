using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;

namespace WebAutomationAssignment.AutomationPractice.Steps
{
    [Binding, Scope(Tag = "Assignment")]
    public class AutomationPracticeSteps : ObjectFactory
    {
        
        [Given(@"I login to Automation Practice website")]
        public void GivenILoginToAutomationPracticeWebsite()
        {
            generic.LoginToApplication();
        }

        [When(@"I navigate to '(.*)' Tab")]
        public void WhenINavigateToTab(string tabName)
        {
            Thread.Sleep(2000);
            homePage.ClickOnTab(tabName);
        }

        [When(@"I add a product to cart")]
        public void WhenIAddAProductToCart()
        {
            common.MouseOver(driver, homePage.imgProductImage);
            homePage.AddProductToCart();
        }

        [When(@"I complete Summary stage")]
        public void WhenICompleteSummaryStage()
        {
            common.ClickButton(allStages.lnkProceedToCheckoutSummary);
        }

        [When(@"I complete Address stage")]
        public void WhenICompleteAddressStage()
        {
            common.ClickButton(allStages.lnkProceedToCheckoutAddress);
        }

        [When(@"I complete Shipping stage")]
        public void WhenICompleteShippingStage()
        {
            common.ClickButton(allStages.chkTermsOfService);
            common.ClickButton(allStages.lnkProceedToCheckoutShipping);
        }

        [When(@"I complete Payment stage by select payment option as '(.*)'")]
        public void WhenICompletePaymentStageBySelectPaymentOptionAs(string paymentOption)
        {
            allStages.SelectPaymentMethod(paymentOption);
        }

        [When(@"I confirm my order")]
        public void WhenIConfirmMyOrder()
        {
            common.ClickButton(allStages.btnIConfirmMyOrder);
        }

        [When(@"I get my order reference number")]
        public void WhenIGetMyOrderReferenceNumber()
        {
            string referenceNumber = allStages.GetReferenceNumber();
            ScenarioContext.Current["ReferenceNumber"] = referenceNumber;
        }

        [Then(@"I verify order in Order History")]
        public void ThenIVerifyOrderInOrderHistory()
        {
            string referenceNumber = (string)ScenarioContext.Current["ReferenceNumber"];
            common.ClickButton(orderHistory.lnkMyAccount);
            common.ClickButton(orderHistory.lnkOrderHistory);

            Assert.IsTrue(orderHistory.GetAllProductReferenceNumber(referenceNumber));
        }

        [When(@"I navigate to personal information page")]
        public void WhenINavigateToPersonalInformationPage()
        {
            common.ClickButton(orderHistory.lnkMyAccount);
            common.ClickButton(homePage.lnkPersonalDetails);
        }

        [When(@"I update First Name")]
        public void WhenIUpdateFirstName()
        {
            string firstname = common.RandomString(5);
            common.EnterText(personalInfo.txtFirstName, firstname);
            ScenarioContext.Current["FirstName"] = firstname;
        }

        [When(@"I enter password")]
        public void WhenIEnterPassword()
        {
            common.EnterText(personalInfo.txtPassword, configData.Password);
        }

        [When(@"I save the details")]
        public void WhenISaveTheDetails()
        {
            common.ClickButton(personalInfo.btnSave);
        }

        [Then(@"I verify the updated First Name")]
        public void ThenIVerifyTheUpdatedFirstName()
        {
            string firstName = (string)ScenarioContext.Current["FirstName"];
            Assert.IsTrue(common.GetText(orderHistory.lnkMyAccount).ToLower().Contains(firstName.ToLower()), "First Name not updated successfully");
        }

    }
}
