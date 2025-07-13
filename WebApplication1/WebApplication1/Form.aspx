<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Form.aspx.cs" Inherits="WebApplication1.Form" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>A Simple Form</title>
</head>
<body>
    <form id="form1" runat="server">
        <fieldset>
            <legend>Sign Up</legend>

            <label>UserName</label>
            <asp:TextBox ID="txtusername" runat="server" /> <br /><br />

            <label>Email</label>
            <asp:TextBox ID="txtemail" runat="server" /> <br /><br />

            <label>Password</label>
            <asp:TextBox ID="txtpassword" runat="server" TextMode="Password" /> <br /><br />

            <asp:Button ID="btnsubmit" runat="server" Text="Submit" OnClick="btnsubmit_Click" />
        </fieldset>
    </form>
</body>
</html>