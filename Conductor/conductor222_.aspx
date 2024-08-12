<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="conductor222_.aspx.cs" Inherits="PMPML_TIcketGhar.Conductor.conductor222_" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Ticket Validation</title>
    <link rel="stylesheet" href="conductor222_styles.css">
</head>
<body>
    <form id="form1" runat="server">
       <div class="background-container">
        <!-- Content Container -->
        <div class="content-container">
            <div class="form-container">
                <h2 class="form-heading">Ticket Validation</h2>
                <div class="ticket-info">
                    <p><strong>From:</strong> Shivajinagar</p>
                    <p><strong>To:</strong> Swargate</p>
                    <p><strong>Payment Status:</strong> Done</p>
                </div>
                <div class="button-container">
                    <button type="button" class="valid-btn" onclick="showPopup('Valid')">Green (Valid)</button>
                    <button type="button" class="invalid-btn" onclick="showPopup('Not Valid')">Red (Not Valid)</button>
                </div>
            </div>
        </div>
    </div>
    <script src="conductor222_script.js"></script>
    </form>
</body>
</html>
