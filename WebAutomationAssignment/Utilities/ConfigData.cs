using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAutomationAssignment
{
    public class ConfigData 
    {

        public string Username { get { return ConfigurationManager.AppSettings.Get("username"); } }
        public string Password { get { return ConfigurationManager.AppSettings.Get("password"); } }
        public string URL { get { return ConfigurationManager.AppSettings.Get("url"); } }


    }
}
