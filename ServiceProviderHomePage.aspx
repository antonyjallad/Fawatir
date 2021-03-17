<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ServiceProviderHomePage.aspx.cs" Inherits="Fawatir.ServiceProviderHomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Email
            <asp:TextBox ID="TextBox1" runat="server" TextMode="Email"></asp:TextBox>
            <br />
            Password<asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
        </div>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Login" />
        <br />
    </form>
</body>
</html>
