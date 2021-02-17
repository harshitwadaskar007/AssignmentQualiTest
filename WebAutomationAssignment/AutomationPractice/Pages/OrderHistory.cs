using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAutomationAssignment.AutomationPractice
{
    public partial class OrderHistory : ObjectFactory
    {
        public bool GetAllProductReferenceNumber(string actualReferenceNumber)
        {
            bool flag = false;
            foreach (var item in lblOrderReference)
            {
                if(item.Text == actualReferenceNumber)
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }
    }
}
