<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Aadhar_registration.aspx.cs" Inherits="PMPML_TIcketGhar.Conductor.Aadhar_registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Aadhaar Registration</title>
    <link rel="stylesheet" href="Addhar_register_styles.css">
</head>
<body>
    <form id="form1" runat="server">
       <div class="background-container">
        <div class="content-container">
            <div class="form-container">
                <h2 class="form-heading">Aadhaar Registration</h2>
                <form id="aadhaar-form">
                    <label for="name">Name:</label>
                    <input type="text" id="name" name="name" placeholder="Enter your name" required>

                    <label for="mobile">Mobile Number:</label>
                    <input type="text" id="mobile" name="mobile" placeholder="Enter your mobile number" required>

                    <label for="aadhaar">Aadhaar Number:</label>
                    <input type="text" id="aadhaar" name="aadhaar" placeholder="Enter your Aadhaar number" required>

                    <label for="gender">Gender:</label>
                    <input type="text" id="gender" name="gender" placeholder="Enter your gender" required>

                    <button type="submit">Submit</button>
                </form>
            </div>
        </div>
    </div>
    <script src="Addhar_register_script.js"></script>
    </form>
</body>
</html>
