using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAutomationAssignment.AutomationPractice
{
    public partial class AllStages : ObjectFactory
    {
        public void SelectPaymentMethod(string method)
        {
            switch (method)
            {
                case "Bank":
                    common.ClickButton(allStages.lnkPayByBankWire);
                    break;
                case "Cheque":
                    common.ClickButton(allStages.lnkPayByBankWire);
                    //To Be Implemented
                    break;
            }
        }

        public string GetReferenceNumber()
        {
            string confirmationText = common.GetText(allStages.lblReferenceNo);
            string[] everyWord = confirmationText.Split(new string[] { "reference" }, StringSplitOptions.None);
            string[] referencePara = everyWord[1].Split(' ');
            return referencePara[1];
        }
    }
}
