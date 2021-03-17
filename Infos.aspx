<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Infos.aspx.cs" Inherits="Fawatir.Infos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table class="UserInfo">
            <tr>
                <td><asp:Label ID="Label1" runat="server" Text="First Name" Font-Bold="True"></asp:Label></td>
                <td><asp:Label ID="lblFn" runat="server" Text=""></asp:Label></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label2" runat="server" Text="Last Name" Font-Bold="True"></asp:Label></td>
                <td><asp:Label ID="lblLn" runat="server" Text=""></asp:Label></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label3" runat="server" Text="Middle Name" Font-Bold="True"></asp:Label></td>
                <td><asp:Label ID="lblMn" runat="server" Text=""></asp:Label></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label4" runat="server" Text="Email" Font-Bold="True"></asp:Label></td>
                <td><asp:Label ID="lblEmail" runat="server" Text=""></asp:Label></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label5" runat="server" Text="Type" Font-Bold="True"></asp:Label></td>
                <td><asp:Label ID="lblType" runat="server" Text=""></asp:Label></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label6" runat="server" Text="Phone Number" Font-Bold="True"></asp:Label></td>
                <td><asp:Label ID="lblPn" runat="server" Text=""></asp:Label></td>
            </tr>
        </table>
        <br />
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/ProfilePage.aspx">Back</asp:HyperLink>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Log Out" />
    </form>
</body>
</html>
