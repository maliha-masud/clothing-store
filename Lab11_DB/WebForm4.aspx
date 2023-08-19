<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="Lab11_DB.WebForm4" %>

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
    <form id="form2" runat="server" style="background-color: #FFCCCC">
        <div>
        </div>
        <p class="auto-style1">
            <strong>&nbsp;&nbsp; UPDATE RENTAL STATUS FORM</strong></p>
        <p>
            &nbsp;<strong>&nbsp; Rental ID&nbsp;</strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server" Width="294px"></asp:TextBox>
        </p>
        <p>
            <strong>&nbsp;&nbsp; Rental Status</strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox4" runat="server" style="margin-left: 18px" Width="293px"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="margin-left: 77px" Text="Update" Width="147px" />
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
