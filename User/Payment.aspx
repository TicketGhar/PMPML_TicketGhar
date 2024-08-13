<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Payment.aspx.cs" Inherits="PMPML_TIcketGhar.User.Payment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Razorpay .Net Sample App</title>
<style>
    #rzp-button1 {
        background-color: #28a745; /* Green background */
        color: #fff; /* White text */
        border: none; /* Remove default border */
        padding: 12px 24px; /* Add padding */
        font-size: 16px; /* Increase font size */
        font-weight: bold; /* Make text bold */
        border-radius: 5px; /* Rounded corners */
        cursor: pointer; /* Pointer cursor on hover */
        transition: background-color 0.3s, transform 0.2s; /* Smooth transitions */
    }

    #rzp-button1:hover {
        background-color: #218838; /* Darker green on hover */
        transform: scale(1.05); /* Slightly larger on hover */
    }
</style>
</head>
<body>
   <form action="Charge.aspx" method="post" name="razorpayForm">
    <input id="razorpay_payment_id" type="hidden" name="razorpay_payment_id" />
    <input id="razorpay_order_id" type="hidden" name="razorpay_order_id" />
    <input id="razorpay_signature" type="hidden" name="razorpay_signature" />
</form>

<button id="rzp-button1">Pay with Razorpay</button>

<script src="https://checkout.razorpay.com/v1/checkout.js"></script>
<script>
    var orderId = "<%=orderId%>";
    var options = {
        "name": "Tejas Patil",
        "description": "Ticket",
        "order_id": orderId,
        "image": "https://s29.postimg.org/r6dj1g85z/daft_punk.jpg",
        "prefill": {
            "name": "Tejaspatil",
            "email": "tejaspatil9637@gmail.com",
            "contact": "+919075157631",
        },
        "notes": {
            "address": "Hello World",
            "merchant_order_id": "12312321",
        },
        "theme": {
            "color": "#F37254"
        }
    };

    options.theme.image_padding = false;

    options.handler = function (response) {
        document.getElementById('razorpay_payment_id').value = response.razorpay_payment_id;
        document.getElementById('razorpay_order_id').value = response.razorpay_order_id; // Ensure this matches the order ID you are using
        document.getElementById('razorpay_signature').value = response.razorpay_signature;
        document.razorpayForm.submit();
    };

    options.modal = {
        ondismiss: function () {
            console.log("This code runs when the popup is closed");
        },
        escape: true,
        backdropclose: false
    };

    var rzp = new Razorpay(options);
    document.getElementById('rzp-button1').onclick = function (e) {
        rzp.open();
        e.preventDefault();
    };
</script>
</body>
</html>
