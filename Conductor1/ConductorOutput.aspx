<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConductorOutput.aspx.cs" Inherits="PMPML_TIcketGhar.Conductor.ConductorOutput" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Ticket Validation</title>
    <link rel="stylesheet" href="conductor222_styles.css">
</head>
<body>
    <div class="background-container">
        <!-- Content Container -->
        <div class="content-container">
            <div class="form-container">
                <h2 class="form-heading">Ticket Validation</h2>
                <div class="ticket-info">
                    <asp:Label ID="lblFrom" runat="server" Text="From: "></asp:Label>
                <asp:Label ID="lblTo" runat="server" Text="To: "></asp:Label>
                <asp:Label ID="lblPaymentStatus" runat="server" Text="Payment Status: "></asp:Label>
                </div>
                <div class="button-container">
                  <form id="form1" runat="server">
                  <%--<button type="button" class="valid-btn" onclick="showPopup('Valid')">Green (Valid)</button>--%>
                      <asp:Button ID="Button1" runat="server" Text="Green (Valid)" OnClick="Button1_Click1" />
                  <%--<button type="button" class="invalid-btn" onclick="showPopup('Not Valid')">Red (Not Valid)</button>--%>
                      <asp:Button ID="Button2" runat="server" Text="Red (Not Valid)" OnClick="Button2_Click1" />
                   </form>    
                </div>
            </div>
        </div>
    </div>
    <script src="conductor222_script.js"></script>
   
</body>
</html>
