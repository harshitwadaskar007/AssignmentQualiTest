using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAutomationAssignment.AutomationPractice;
using WebAutomationAssignment.Utilities;

namespace WebAutomationAssignment
{
    public class ObjectFactory
    {

        public static readonly log4net.ILog Log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public static IWebDriver driver;
        #region Lazy Lading

        Lazy<Login> LazyLogin = new Lazy<Login>(() =>
        {
            Login internalObject = new Login(driver);
            return internalObject;
        });

        Lazy<HomePage> LazyHomePage = new Lazy<HomePage>(() =>
        {
            HomePage internalObject = new HomePage(driver);
            return internalObject;
        });

        Lazy<AllStages> LazyAllStages = new Lazy<AllStages>(() =>
        {
            AllStages internalObject = new AllStages(driver);
            return internalObject;
        });

        Lazy<OrderHistory> LazyOrderHistory = new Lazy<OrderHistory>(() =>
        {
            OrderHistory internalObject = new OrderHistory(driver);
            return internalObject;
        });

        Lazy<CommonFunctions> LazyCommonFunctions = new Lazy<CommonFunctions>(() =>
        {
            CommonFunctions internalObject = new CommonFunctions();
            return internalObject;
        });

        Lazy<ConfigData> LazyConfigData = new Lazy<ConfigData>(() =>
        {
            ConfigData internalObject = new ConfigData();
            return internalObject;
        });

        Lazy<GenericFunctions> LazyGenericFunctions = new Lazy<GenericFunctions>(() =>
        {
            GenericFunctions internalObject = new GenericFunctions();
            return internalObject;
        });

        Lazy<PersonalInformation> LazyPersonalInformation = new Lazy<PersonalInformation>(() =>
        {
            PersonalInformation internalObject = new PersonalInformation(driver);
            return internalObject;
        });
        #endregion



        #region Class Instances
        public Login login { get { return LazyLogin.Value; } }
        public HomePage homePage { get { return LazyHomePage.Value; } }
        public AllStages allStages { get { return LazyAllStages.Value; } }
        public OrderHistory orderHistory { get { return LazyOrderHistory.Value; } }
        public CommonFunctions common { get { return LazyCommonFunctions.Value; } }
        public ConfigData configData { get { return LazyConfigData.Value; } }
        public GenericFunctions generic { get { return LazyGenericFunctions.Value; } }
        public PersonalInformation personalInfo { get { return LazyPersonalInformation.Value; } }
        #endregion

    }
}
