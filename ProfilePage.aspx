<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProfilePage.aspx.cs" Inherits="Fawatir.ProfilePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [ServicesProvider]"></asp:SqlDataSource>
        </div>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Infos.aspx">My Profile</asp:HyperLink>
        <br />
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/NewService.aspx">Add New Service</asp:HyperLink>
        <br />
        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/Map.aspx">Go To Map</asp:HyperLink>
        <br />
        <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/NewJob.aspx">New Job Opportunity</asp:HyperLink>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Log Out" />
        </p>
    </form>
</body>
</html>
