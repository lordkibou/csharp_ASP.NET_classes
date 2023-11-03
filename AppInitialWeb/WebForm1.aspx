<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="AppInitialWeb.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <span>
            <asp:ListBox ID="ListBox2" runat="server" Height="206px" style="margin-right: 69px" Width="301px"></asp:ListBox>
            <asp:HiddenField ID="HiddenField1" runat="server" />
            <!--In order to save data we can use hiddenfield, session, url queries,-->
            <!--Customer customer = (Customer) session["key"]-->
        </div>
        </span>
        <p>
            <span>
            <asp:Label ID="lbMessage" runat="server" Text="Label"></asp:Label>
            </span>
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
