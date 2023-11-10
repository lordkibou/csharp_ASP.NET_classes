<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateUser.aspx.cs" Inherits="Authentication_Security_Web.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Text="Please, sign up for your new account"></asp:Label>
        <p>
            <asp:Label ID="Label2" runat="server" Text="User name: "></asp:Label>
&nbsp;<asp:TextBox ID="UsernameTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Profile: "></asp:Label>
&nbsp;<asp:DropDownList ID="ProfileDropDown" runat="server">
            </asp:DropDownList>
        </p>
        <p>
            <asp:Label ID="Label4" runat="server" Text="Password: "></asp:Label>
&nbsp;<asp:TextBox ID="PasswordTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="OK" OnClick="Button1_Click" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="Cancel" OnClick="Button2_Click" />
        </p>
    </form>
</body>
</html>
