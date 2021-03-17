<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewJob.aspx.cs" Inherits="Fawatir.NewJob" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Published By:
            <asp:Label ID="Label1" runat="server"></asp:Label>
&nbsp;<asp:Label ID="Label2" runat="server"></asp:Label>
&nbsp;<asp:Label ID="Label3" runat="server"></asp:Label>
            <br />
            Email: <asp:Label ID="Label5" runat="server"></asp:Label>
            <br />
            Phone Number: <asp:Label ID="Label6" runat="server"></asp:Label>
            <br />
            Job Title<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            Sector<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            Field<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            Schedule<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <br />
            Experience<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            <br />
            Shift<asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            <br />
            Salary Range<asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
            <br />
            Location<asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
            <br />
            Department<asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
            <br />
            Description<asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
            <br />
            Email To Contact
            <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Share" />
        </div>
    </form>
</body>
</html>
