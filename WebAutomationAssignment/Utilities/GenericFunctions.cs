using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAutomationAssignment
{
    public class GenericFunctions : ObjectFactory
    {
        
        public void LoginToApplication()
        {
            common.OpenApplication(configData.URL);
            common.ClickButton(login.lnkSignIn);
            common.EnterText(login.txtEmailAddress, configData.Username);
            common.EnterText(login.txtPassword, configData.Password);
            common.ClickButton(login.btnSignIn);
        }

        
    }
}
