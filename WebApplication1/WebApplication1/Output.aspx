<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Output.aspx.cs" Inherits="WebApplication1.Output" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form" runat="server">
        <asp:Label ID="lblUsername" runat="server">Username: </asp:Label>
<asp:TextBox ID="txtUsername" runat="server"></asp:TextBox><br /><br />

<asp:Label ID="lblEmail" runat="server">Email: </asp:Label>
<asp:TextBox ID="txtEmail" runat="server"></asp:TextBox><br /><br />


<asp:Label ID="lblPassword" runat="server">Password: </asp:Label>
<asp:TextBox ID="txtPassword" runat="server"></asp:TextBox><br /><br />
    </form>
    

</body>
</html>
