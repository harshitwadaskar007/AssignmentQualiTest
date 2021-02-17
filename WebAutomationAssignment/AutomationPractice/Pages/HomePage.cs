using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WebAutomationAssignment.AutomationPractice
{
    public partial class HomePage : ObjectFactory
    {

        public void ClickOnTab(string tabName)
        {
            switch(tabName)
            {
                case "Tshirt":
                    common.ClickButton(homePage.lnkTShirtsTab);
                    break;
                case "Women":
                    common.ClickButton(homePage.lnkWomen);
                    //To Be Implemented
                    break;
                case "Dresses":
                    common.ClickButton(homePage.lnkDresses);
                    //To Be Implemented
                    break;
            }
        }

        public void AddProductToCart()
        {
            common.ClickButton(homePage.lnkAddToCart);
            Thread.Sleep(4000);
            common.ClickButton(homePage.lnkProceedToCheckout);
        }

    }
}
