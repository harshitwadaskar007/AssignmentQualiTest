using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAutomationAssignment.AutomationPractice
{
    public partial class AllStages : ObjectFactory
    {
        public AllStages(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//p[contains(@class,'cart_navigation')]//span[contains(text(),'Proceed to checkout')]/parent::a")]
        public IWebElement lnkProceedToCheckoutSummary;

        [FindsBy(How = How.XPath, Using = "//p[contains(@class,'cart_navigation')]//button")]
        public IWebElement lnkProceedToCheckoutAddress;

        [FindsBy(How = How.XPath, Using = "//input[@type='checkbox']")]
        public IWebElement chkTermsOfService;

        [FindsBy(How = How.XPath, Using = "//p[contains(@class,'cart_navigation')]//button")]
        public IWebElement lnkProceedToCheckoutShipping;

        [FindsBy(How = How.XPath, Using = "//a[@title='Pay by bank wire']")]
        public IWebElement lnkPayByBankWire;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'I confirm my order')]/parent::button")]
        public IWebElement btnIConfirmMyOrder;

        [FindsBy(How = How.XPath, Using = "//div[@class='box']//strong[contains(text(),'complete')]")]
        public IWebElement lblOrderCompletion;

        [FindsBy(How = How.XPath, Using = "//div[@class='box']")]
        public IWebElement lblReferenceNo;

        [FindsBy(How = How.XPath, Using = "//a[@title='Pay by bank wire']")]
        public IWebElement lnkPayByCheque;

    }
}
