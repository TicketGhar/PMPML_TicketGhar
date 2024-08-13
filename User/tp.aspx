<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="tp.aspx.cs" Inherits="PMPML_TIcketGhar.User.tp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration Form</title>
    <script src="registration_script.js" type="text/javascript"></script>
</head>
<body>
   <div class="background">
            <div class="overlay"></div>
            <div class="form-container">
                <h1>Monthly Bus Pass<br>
                    !!मासिक पास!!
                </h1>
                <div class="form-group">
                    <label for="name">Name:</label>
                    <asp:TextBox ID="txtName" runat="server" required></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="mobile">Mobile No:</label>
                    <asp:TextBox ID="txtMobile" runat="server" required pattern="[0-9]{10}"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="aadhar">Aadhar No:</label>
                    <asp:TextBox ID="txtAadhar" runat="server" required pattern="[0-9]{12}"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="gender">Gender:</label>
                    <asp:DropDownList ID="ddlGender" runat="server" required>
                        <asp:ListItem Value="male">Male</asp:ListItem>
                        <asp:ListItem Value="female">Female</asp:ListItem>
                        <asp:ListItem Value="other">Other</asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="form-group">
                    <label for="doc-code">Document Verification Code:</label>
                    <asp:TextBox ID="txtDocCode" runat="server" required></asp:TextBox>
                </div>
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
            </div>
        </div>
</body>
</html>
