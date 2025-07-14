<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrationForm.aspx.cs" Inherits="WebApplication3.RegistrationForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <fieldset>
            <legend>
                Form Validation
            </legend>
            <asp:Label ID="lblName" runat="server">Name: </asp:Label><br />
            <asp:TextBox ID="txtName" runat="server" />
            <asp:RequiredFieldValidator ID="rfName" runat="server" ControlToValidate="txtName" ErrorMessage="*Name field is required" ForeColor="Red" />
            <asp:RegularExpressionValidator ID="regName" runat="server" ControlToValidate="txtName" ErrorMessage="*Name cannot contain numbers and special characters" ForeColor="Red" ValidationExpression="^[A-Za-z\s]+$" />
            <br /><br />
            <asp:Label ID="lblPassword" runat="server">Password: </asp:Label><br />
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" />
            <asp:RequiredFieldValidator ID="rfPassword" runat="server" ControlToValidate="txtPassword" ErrorMessage="*Password field is required" ForeColor="Red"/>
            <asp:CustomValidator ID="cvPassword" runat="server" ControlToValidate="txtPassword" ErrorMessage="*Password must be greater than 8 character" ForeColor="Red" ValidateEmptyText="true" OnServerValidate="cvPassword_ServerValidate" />
            <br /><br />
            <asp:Label ID="lblRePassword" runat="server">Re-Type Password</asp:Label><br />
            <asp:TextBox ID="txtRePassword" runat="server" TextMode="Password" />
            <asp:RequiredFieldValidator ID="rfRePassword" runat="server" ControlToValidate="txtRePassword" ForeColor="Red" ErrorMessage="*ReType Password Field is required" /> 
            <asp:CompareValidator ID="cmpRePass" runat="server" ControlToValidate="txtRePassword" ErrorMessage="*Password field Doesn't Match" ForeColor="Red" ControlToCompare="txtPassword" />
            <br /><br />
            <asp:Label ID="lblAge" runat="server">Age</asp:Label><br />
            <asp:TextBox ID="txtAge" runat="server" TextMode="Number" />
            <asp:RequiredFieldValidator ID="rfAge" runat="server" ControlToValidate="txtAge" ErrorMessage="*Age field is required" ForeColor="Red" />
            <asp:RangeValidator ID="rvAge" runat="server" ControlToValidate="txtAge" ErrorMessage="*Age must be between 16 to 60" ForeColor="Red" MinimumValue="16" MaximumValue="60" />
            <br /><br />

            <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
        </fieldset>

        <hr />
        <h2>Form Data</h2>
        <asp:Label ID="lblResult" runat="server" />
    </form>
</body>
</html>
