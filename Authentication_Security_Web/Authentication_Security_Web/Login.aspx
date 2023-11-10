<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Authentication_Security_Web.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Please, log in: "></asp:Label>
        </div>
        <br />
        <asp:Label ID="Label2" runat="server" Text="User name: "></asp:Label>
&nbsp;<asp:TextBox ID="UsernameTextBox" runat="server" Wrap="False"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Password: "></asp:Label>
&nbsp;
        <asp:TextBox ID="PasswordTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="OK" />
        <br />
        <br />
        <br />
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">[New user]</asp:LinkButton>
        <br />
    </form>
</body>
</html>
