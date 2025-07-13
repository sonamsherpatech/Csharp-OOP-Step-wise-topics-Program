<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="output.aspx.cs" Inherits="WebApplication2.output" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <fieldset>
        <legend>Student Information<</legend>
        <form id="form1" runat="server">
             <asp:Label ID="LblRoll" runat="server" >Rollno:</asp:Label>
               <asp:TextBox ID="TxtRoll" runat="server" ReadOnly="true" />
                <br /><br />
             <asp:Label ID="LblName" runat="server">Name:</asp:Label>
            <asp:TextBox ID="TxtName" runat="server" ReadOnly="true" />
                <br /><br />
             <asp:Label ID="LblAddress" runat="server">Address:</asp:Label>
            <asp:TextBox ID="TxtAddress" runat="server" ReadOnly="true" />
            <br /><br />
             <asp:Label ID="LblDOB" runat="server">DOB:</asp:Label>
               <asp:TextBox ID="TxtDOB" runat="server" ReadOnly="true" />
            <br /><br />
        </form>
    </fieldset>
    
</body>
</html>
