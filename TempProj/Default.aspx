<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="YourNamespace._Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Send SMS with Twilio</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="SendSmsButton" runat="server" Text="Send SMS" OnClick="SendSmsButton_Click" Height="38px" Width="99px" />
        </div>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
