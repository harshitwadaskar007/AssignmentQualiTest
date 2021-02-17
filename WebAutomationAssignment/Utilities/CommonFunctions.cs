using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace WebAutomationAssignment.Utilities
{
    public class CommonFunctions : ObjectFactory
    {
        //public IWebDriver driver;
        //public CommonFunctions()
        //{
        //    this.driver = driver;
        //}
        public Random random = new Random();
        public void SendKeysAction(string text)
        {
            Log.Info("Test");
            new Actions(driver).SendKeys(text).Build().Perform();
        }

        public void EnterText(IWebElement element,string text)
        {
            Log.Info("Text entered in " + element + " element");
            element.Clear();
            element.SendKeys(text);
        }

        public void ClickButton(IWebElement element)
        {
            Log.Info(element + " element - Button Clicked");
            element.Click();
        }

        public void OpenApplication(string url)
        {
            Log.Info("Navigating to URL");
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
        }

        public string GetText(IWebElement element)
        {
            return element.Text;
        }

        public void MouseOver(IWebDriver driver, IWebElement element)
        {
            Actions action = new Actions(driver);
            action.MoveToElement(element).Build().Perform();
        }

        public string RandomString(int len)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return new string(Enumerable.Repeat(chars, len).Select(s => s[random.Next(s.Length)]).ToArray());
        }

    }
}
