<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SecuredPage.aspx.cs" Inherits="Authentication_Security_Web.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Hello, "></asp:Label>
            <asp:Label ID="UserLabel" runat="server" Font-Bold="True" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:Button ID="SignOutButton" runat="server" OnClick="SignOutButton_Click" Text="Sign Out" />
        </div>
    </form>
</body>
</html>
