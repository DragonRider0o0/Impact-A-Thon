using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Globalization;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;


using Twilio;
using Twilio.TwiML;

namespace Impactathon.Controllers
{
    public class PhoneController : Controller
    {
        string docType = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>";
        string responseOpen = "<Response>";
        string responseClose = "</Response>";

        public void Index()
        {
            List<string> phoneNumbers = new List<string>();
            phoneNumbers.Add("+18017878026");
            string message = "Impactathon";

            foreach (string phoneNumber in phoneNumbers)
            {
                SendSMS(phoneNumber, message);
            }
            
            //SendCall("+18017878026");
            //SendCall("+19737692717");

        }

        void SetupTwilio()
        {
            // put your Twilio API credentials here
            string accountSid = "AC2cbe631411b305e102ac2e3ce2da0407";
            string authToken = "9093223b161f8d4a9a97577b5cddbc20";

            //var capability = new TwilioCapability(accountSid, authToken);
            //capability.AllowClientIncoming;
            //capability.AllowClientOutgoing("APabe7650f654fc34655fc81ae71caa3ff");
            //string token = capability.GenerateToken();
        }

        public void SendSMS(string targetNumber, string message)
        {
            string twilioNumber = "+18014299303";
            string accountSid = "AC2cbe631411b305e102ac2e3ce2da0407";
            string authToken = "9093223b161f8d4a9a97577b5cddbc20";

            var client = new TwilioRestClient(accountSid, authToken);

            client.SendSmsMessage(twilioNumber, targetNumber, message);
        }
    }
}