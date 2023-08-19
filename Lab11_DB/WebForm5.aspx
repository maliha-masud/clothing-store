<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm5.aspx.cs" Inherits="Lab11_DB.WebForm5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .auto-style1 {
            font-size: xx-large;
        }
    </style>
</head>
<body>
    <form id="form2" runat="server" style="background-color: #003399">
        <div>
        </div>
        <p class="auto-style1" style="background-color: #003399; color: #FFFFFF;">
            &nbsp;<strong>&nbsp; DELETE PRODUCT FORM</strong></p>
        <p style="color: #FFFFFF">
            <strong>&nbsp; Product ID</strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server" Width="294px" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="margin-left: 77px" Text="Delete" Width="147px" />
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
