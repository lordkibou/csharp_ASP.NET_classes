<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Furniture_Sessions_1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="listBox" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ListBox_SelectedIndexChanged"></asp:ListBox>
        <asp:Button ID="buttonQueryString" runat="server" Text="Query String" OnClick="buttonQueryString_Click" />
        <asp:Button ID="buttonServerTransfer" runat="server" Text="Server Transfer" OnClick="buttonServerTransfer_Click" />
        <p>
            <asp:Label ID="NameLabel" runat="server" Font-Bold="True" Text="Name: "></asp:Label>
            <asp:Label ID="textViewName" runat="server" Font-Bold="True" Text="inputName"></asp:Label>
        </p>
        <p>
            <asp:Label ID="ManufacturerLabel" runat="server" Font-Bold="True" Text="Manufacturer: "></asp:Label>
            <asp:Label ID="textViewManufacturer" runat="server" Font-Bold="True" Text="inputManufacturer"></asp:Label>
        </p>
        <p>
            <asp:Label ID="CostLabel" runat="server" Font-Bold="True" Text="Cost: "></asp:Label>
            <asp:Label ID="textViewCost" runat="server" Font-Bold="True" Text="inputCost"></asp:Label>
        </p>
        <p>
            <asp:Label ID="textViewCounter" runat="server" Text="0"></asp:Label>
            <asp:Label ID="QueryLabel" runat="server" Text="queries"></asp:Label>
        </p>
        <asp:HiddenField ID="hiddenFieldCounter" runat="server" Value="0" />
    </form>
</body>
</html>
