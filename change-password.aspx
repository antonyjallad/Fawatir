<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="change-password.aspx.cs" Inherits="Fawatir.change_password" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="X-UA-Compatible" content="IE=edge"/>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <title>Change Password - Fawatir</title>
    <meta property="og:title" content="Fawatir"/>
    <meta property="og:description" content="Fawatir"/>
    <meta property="og:url" content="/"/>
    <link rel="stylesheet" href="assets/css/slick.css"/>
    <link rel="stylesheet" href="assets/css/slick-theme.css"/>
    <link rel="stylesheet" href="assets/css/main.css?98" />
</head>
<body>
    <header>
        <div class="section-wrapper">
            <a class="menu-icon mobile" href="#">
                <span></span>
            </a>
            <div class="logo">
                <a href="/Homepage">
                    <img src="images/fawatir_logo.png"/>
                </a>
            </div>
            <nav class="main-menu">
                <ul>
                    <li>
                        <a href="/about-us">About Us</a>
                    </li>
                    <li>
                        <a href="/contact-us">Contact Us</a>
                    </li>
                </ul>
            </nav>
        </div>
    </header>
    <div class="mobile-menu mobile">
       <nav>
           <ul>
               <li>
                   <a href="/about-us">About us</a>
               </li>
               <li>
                   <a href="/contact-us">Contact Us</a>
               </li>
           </ul>
       </nav>
    </div>
    <div class="main-container change_password user-profile">
        <div class="section-wrapper">
            <div class="form-wrapper">
                <form id="form1" runat="server">
                    <div class="profile_links">
                       <asp:HyperLink ID="Hyperlink4" runat="server" NavigateUrl="~/UserHomePage.aspx" class="links">Home</asp:HyperLink> 
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/UserProfilePage.aspx" class="links">My Profile</asp:HyperLink>
                        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/AvailableServices.aspx" class="links"> Available Services</asp:HyperLink>
                        <asp:HyperLink ID="Hyperlink3" runat="server" NavigateUrl="~/registeredservices.aspx" class="links">Registered Services</asp:HyperLink> 
                        <asp:HyperLink ID="Hyperlink5" runat="server" NavigateUrl="~/jobs.aspx" CssClass="links">Jobs</asp:HyperLink>
                        <asp:HyperLink ID="Hyperlink6" runat="server" NavigateUrl="~/bills.aspx" CssClass="links">Paid Bills</asp:HyperLink>
                        <asp:HyperLink ID="Hyperlink8" runat="server" NavigateUrl="~/latepayments.aspx" CssClass="links">Late Payments</asp:HyperLink>                        
                        <asp:HyperLink ID="Hyperlink7" runat="server" NavigateUrl="~/report.aspx" CssClass="links">Report</asp:HyperLink>
                        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" class="links" Text="Log Out" />
                    </div>
                    <div class="change_password_form">
                        <div class="top">
                            <h1>Change Password</h1>
                        </div>
                        <asp:TextBox ID="TextBox1" runat="server" TextMode="Password" placeholder="Current Password*" class="login_inputs"></asp:TextBox>
                        <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" placeholder="New Password*" class="login_inputs"></asp:TextBox>
                        <asp:TextBox ID="TextBox3" runat="server" TextMode="Password" placeholder="Re-Type Your Password*" class="login_inputs"></asp:TextBox>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" Font-Size="20px" BorderColor="Red" ControlToCompare="TextBox2" ControlToValidate="TextBox3" ErrorMessage="Confirm Password doesn not match" ForeColor="Red"></asp:CompareValidator> 
                        <asp:Label ID="Label11" runat="server" ForeColor="Red"></asp:Label>
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Save" class="login-btn"/>
                     </div>
                </form>
            </div>
        </div>
    </div>
 <footer>
        <div class="section-wrapper">
            <div class="logo">
                <a href="/Homepage">
                    <img src="images/fawatir_logo.png"/>
                </a>
            </div>
            <nav class="main-menu">
                <ul>
                    <li>
                        <a href="/about-us">About Us</a>
                    </li>
                    <li>
                        <a href="/contact-us">Contact Us</a>
                    </li>
                </ul>
            </nav>
        </div>
    </footer>
    <script type="text/javascript" src="Scripts/jquery-3.4.1.min.js"></script>
    <script type="text/javascript" src="assets/js/slick.min.js"></script>
    <script type="text/javascript" src="assets/js/main.js"></script>
    </body>
</html>

