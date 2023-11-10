<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UnsecuredPage.aspx.cs" Inherits="Authentication_Security_Web.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Anyone can access this page."></asp:Label>
            <br />
        </div>
        <asp:Label ID="Label2" runat="server" Text="Are you authenticated?"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="BooleanResult" runat="server" Font-Bold="True" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:Button ID="SecuredButton" runat="server" OnClick="Button1_Click" Text="Secured User" />
        <br />
        <asp:Button ID="AdminButton" runat="server" OnClick="Button2_Click" Text="Admin" />
    </form>
</body>
</html>
