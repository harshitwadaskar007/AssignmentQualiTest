using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAutomationAssignment.AutomationPractice
{
    public partial class OrderHistory : ObjectFactory
    {
        public OrderHistory(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//a[@class='account']")]
        public IWebElement lnkMyAccount;

        [FindsBy(How = How.XPath, Using = "//a[@title='Orders']")]
        public IWebElement lnkOrderHistory;

        [FindsBy(How = How.XPath, Using = "//td[contains(@class,'history_link')]")]
        public IList<IWebElement> lblOrderReference;

    }
}
