<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="User.aspx.cs" Inherits="Fawatir.User" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 560px;
            height: 132px;
        }
        .auto-style2 {
            width: 675px;
            height: 343px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
               <div class="auto-style1">
            &nbsp;Email&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox2" runat="server" TextMode="Email"></asp:TextBox>
                    <br />
             Password&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox1" runat="server" TextMode="Password"></asp:TextBox>
                   <br />
                   <br />
                   <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click1" />
                   <br />
                   </div>
                <div>
            <div class="auto-style2">
                First Name<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                <br />
                Middle Name<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                <br />
                Last Name<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                <br />
                Phone Number<asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                <br />
                Email<asp:TextBox ID="TextBox7" runat="server" TextMode="Email"></asp:TextBox>
                <br />
                Password<asp:TextBox ID="TextBox8" runat="server" TextMode="Password"></asp:TextBox>
                <br />
                Confirm Password<asp:TextBox ID="TextBox9" runat="server" TextMode="Password"></asp:TextBox>
                   <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox8" ControlToValidate="TextBox9" ErrorMessage="Confirm Password does not match" ForeColor="Red"></asp:CompareValidator>
                <br />
                   <asp:Button ID="Button2" runat="server" Text="Create Account" OnClick="Button2_Click1" />
                    </div>  
                        </form>

                </body>
</html>
