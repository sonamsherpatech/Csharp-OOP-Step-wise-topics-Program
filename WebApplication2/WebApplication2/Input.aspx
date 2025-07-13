<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Input.aspx.cs" Inherits="WebApplication2.Input" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <fieldset>
        <legend>Store Student Information</legend>
        <form id="form1" runat="server">
            <asp:Label ID="LblRollNo" runat="server">Roll No: </asp:Label>
            <asp:TextBox ID="TxtRollNo" runat="server" /> <br /><br />

            <asp:Label ID="LblName" runat="server">Name: </asp:Label>
            <asp:TextBox ID="TxtName" runat="server" /> <br /><br />

            <asp:Label ID="LblAddress" runat="server">Address: </asp:Label>
            <asp:TextBox ID="TxtAddress" runat="server" /> <br /><br />
            
            <asp:Label ID="LblDOB" runat="server">DOB(Date of Birth): </asp:Label>
            <asp:TextBox ID="TxtDOB" runat="server" /> <br /><br />

            <asp:Button ID="BtnSubmit" Text="Submit" runat="server" OnClick="BtnSubmit_Click" />
           </form>
    </fieldset>
    
</body>
</html>
