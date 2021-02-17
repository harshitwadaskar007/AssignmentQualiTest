using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAutomationAssignment.AutomationPractice
{
    public class PersonalInformation : ObjectFactory
    {

        public PersonalInformation(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "firstname")]
        public IWebElement txtFirstName;

        [FindsBy(How = How.Id, Using = "old_passwd")]
        public IWebElement txtPassword;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Save')]/parent::button")]
        public IWebElement btnSave;
    }
}
