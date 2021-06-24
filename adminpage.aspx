<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adminpage.aspx.cs" Inherits="Fawatir.adminpage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="X-UA-Compatible" content="IE=edge"/>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <title>Admin Home Page - Fawatir</title>
    <meta property="og:title" content="Fawatir"/>
    <meta property="og:description" content="Fawatir"/>
    <meta property="og:url" content="/"/>
    <link rel="stylesheet" href="assets/css/slick.css"/>
    <link rel="stylesheet" href="assets/css/slick-theme.css"/>
    <link rel="stylesheet" href="assets/css/main.css?112" />
</head>
<body style="background:#FAFAFA">
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
    

    <div class="main-container user-profile">
        <div class="section-wrapper">
            <form id="form1" runat="server">
                <div class="form-wrapper">
                    <div class="profile_links">
                        <asp:HyperLink ID="Hyperlink1" runat="server" NavigateUrl="~/new-provider.aspx" class="links">New Provider</asp:HyperLink> 
                        <asp:HyperLink ID="Hyperlink2" runat="server" NavigateUrl="~/reports.aspx" class="links">Reports</asp:HyperLink> 
                        <asp:HyperLink ID="Hyperlink3" runat="server" NavigateUrl="~/users.aspx" class="links">Users</asp:HyperLink>
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" class="links" Text="Log Out" />
                    </div>
                </div>
             </form>
            </div>
            <asp:Label ID="Label1" runat="server" Font-Size="20px" Text=" "></asp:Label>
        </div>
    <div class="data_table">
       <h1 id="h1">Paid Bills For This Month</h1>
       <%=getWhileLoopData()%>
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
