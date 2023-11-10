<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminPage.aspx.cs" Inherits="Authentication_Security_Web.WebForm5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Text="This page is only for the administrator."></asp:Label>
            <br />
            <br />
            <asp:Button ID="SignOutAdminButton" runat="server" OnClick="SignOutAdminButton_Click" Text="Sign Out" />
        </div>
    </form>
</body>
</html>
