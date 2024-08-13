using Razorpay.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PMPML_TIcketGhar.User
{
    public partial class Charge : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string paymentId = Request.Form["razorpay_payment_id"];
            string orderId = Request.Form["razorpay_order_id"];
            string signature = Request.Form["razorpay_signature"];

            // Ensure these values are not null or empty
            if (string.IsNullOrEmpty(paymentId) || string.IsNullOrEmpty(orderId) || string.IsNullOrEmpty(signature))
            {
                SetMessage("Invalid payment details. Payment failed.", "error");
                return;
            }

            string key = "rzp_test_DOTcz75F10VBzs"; // Your Razorpay Key
            string secret = "GJ0AO2FrRkMBxpCOhzs4njSh"; // Your Razorpay Secret

            RazorpayClient client = new RazorpayClient(key, secret);

            Dictionary<string, string> attributes = new Dictionary<string, string>
            {
                { "razorpay_payment_id", paymentId },
                { "razorpay_order_id", orderId },
                { "razorpay_signature", signature }
            };
            try
            {
                Utils.verifyPaymentSignature(attributes, secret);
                // Signature is valid. Process the payment further.
                SetMessage("Signature is valid. Payment successful.", "success");
            }
            catch (Razorpay.Api.Errors.SignatureVerificationError ex)
            {
                // Invalid signature. Log the error for further investigation.
                SetMessage($"Invalid signature. Payment failed. Error: {ex.Message}", "error");
                // Consider logging the exception to a file or monitoring system
            }

            // Uncomment to refund the payment if needed
            // Refund refund = new Razorpay.Api.Payment(paymentId).Refund();
        }
        private void SetMessage(string message, string type)
        {
            // Set the message text and CSS class
            MessageLiteral.Text = $"<div class='message {type}'>{message}</div>";
        }
    }
    public static class Utils
    {
        public static void verifyPaymentSignature(Dictionary<string, string> attributes, string secret)
        {
            string orderId = attributes["razorpay_order_id"];
            string paymentId = attributes["razorpay_payment_id"];
            string signature = attributes["razorpay_signature"];

            string payload = $"{orderId}|{paymentId}";
            string generatedSignature = GenerateSHA256Hash(payload, secret);

            if (generatedSignature != signature)
            {
                throw new Razorpay.Api.Errors.SignatureVerificationError("Invalid signature passed");
            }
        }

        private static string GenerateSHA256Hash(string payload, string secret)
        {
            var encoding = new System.Text.UTF8Encoding();
            byte[] keyBytes = encoding.GetBytes(secret);
            byte[] messageBytes = encoding.GetBytes(payload);

            using (var hmacsha256 = new System.Security.Cryptography.HMACSHA256(keyBytes))
            {
                byte[] hashMessage = hmacsha256.ComputeHash(messageBytes);
                return BitConverter.ToString(hashMessage).Replace("-", "").ToLower();
            }
        }
    }
}