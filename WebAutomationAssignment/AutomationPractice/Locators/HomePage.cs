using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAutomationAssignment.AutomationPractice
{
    public partial class HomePage : ObjectFactory
    {
        public HomePage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//ul[contains(@class,'sf')]/li/a[contains(text(),'T-shirts')]")]
        public IWebElement lnkTShirtsTab;

        [FindsBy(How = How.XPath, Using = "//ul[contains(@class,'sf')]/li[contains(@class,'sfHoverForce')]//a[contains(text(),'T-shirts')]")]
        public IWebElement lnkWomen;

        [FindsBy(How = How.XPath, Using = "//ul[contains(@class,'sf')]/li[contains(@class,'sfHoverForce')]//a[contains(text(),'T-shirts')]")]
        public IWebElement lnkDresses;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Add to cart')]/parent::a")]
        public IWebElement lnkAddToCart;

        [FindsBy(How = How.XPath, Using = "//a[contains(@class,'product_img_link')]/img")]
        public IWebElement imgProductImage;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Proceed to checkout')]/parent::a")]
        public IWebElement lnkProceedToCheckout;

        [FindsBy(How = How.XPath, Using = "//a[@title='Information']")]
        public IWebElement lnkPersonalDetails;

    }
}
