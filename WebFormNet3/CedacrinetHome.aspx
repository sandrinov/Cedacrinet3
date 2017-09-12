<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CedacrinetHome.aspx.cs" Inherits="WebFormNet3.CedacrinetHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
            <br />
            <br />
            <asp:ListBox ID="ListBox1" runat="server" Width="250px"></asp:ListBox>
            <br />
            <br />
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" Height="19px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="255px">
                <asp:ListItem Value="MI">MIlano</asp:ListItem>
                <asp:ListItem Value="BO">Bologna</asp:ListItem>
                <asp:ListItem Value="FI">Firenze</asp:ListItem>
            </asp:DropDownList>
        </div>
    </form>
</body>
</html>
