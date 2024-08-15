using System;
using System.Web.UI;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace YourNamespace
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void SendSmsButton_Click(object sender, EventArgs e)
        {
            // Ensure TLS 1.2 is used
            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;

            string accountSid = System.Configuration.ConfigurationManager.AppSettings["TwilioAccountSid"];
            string authToken = System.Configuration.ConfigurationManager.AppSettings["TwilioAuthToken"];
            string twilioPhoneNumber = System.Configuration.ConfigurationManager.AppSettings["TwilioPhoneNumber"];
            string toPhoneNumber = "+918446415121"; // Replace with the recipient's phone number

            // Generate a 5-digit PNR number
            string pnrNumber = GeneratePnrNumber();

            string messageBody = $"Welcome to PMPML TicketGhar Your PNR number is: {pnrNumber}";

            TwilioClient.Init(accountSid, authToken);

            var message = MessageResource.Create(
                to: new PhoneNumber(toPhoneNumber),
                from: new PhoneNumber(twilioPhoneNumber),
                body: messageBody
            );

            Response.Write($"Message sent: {message.Sid}");
        }

        private string GeneratePnrNumber()
        {
            Random random = new Random();
            int pnr = random.Next(10000, 100000); // Generates a number between 10000 and 99999
            return pnr.ToString();
        }
    }
}
