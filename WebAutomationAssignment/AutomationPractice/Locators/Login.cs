using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAutomationAssignment.AutomationPractice
{
    public class Login : ObjectFactory
    {
        public Login(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Sign in')]")]
        public IWebElement lnkSignIn;

        [FindsBy(How = How.XPath, Using = "//input[@id='email']")]
        public IWebElement txtEmailAddress;

        [FindsBy(How = How.XPath, Using = "//input[@id='passwd']")]
        public IWebElement txtPassword;

        [FindsBy(How = How.XPath, Using = "//button[@id='SubmitLogin']")]
        public IWebElement btnSignIn;



    }
}
