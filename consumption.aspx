<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="consumption.aspx.cs" Inherits="Fawatir.consumption" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="X-UA-Compatible" content="IE=edge"/>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <title>Consumption - Fawatir</title>
    <meta property="og:title" content="Fawatir"/>
    <meta property="og:description" content="Fawatir"/>
    <meta property="og:url" content="/"/>
    <link rel="stylesheet" href="assets/css/slick.css"/>
    <link rel="stylesheet" href="assets/css/slick-theme.css"/>
    <link rel="stylesheet" href="assets/css/main.css?0" />
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
     <div class="main-container activation_page">
        <div class="section-wrapper">
            <form id="form1" runat="server" class="activation_form">
                             <asp:Label ID="Label2" class="texts" Font-Size="25px" runat="server" Text="Please do not fill this without contacting your provider"></asp:Label>
                            <asp:TextBox ID="TextBox1" runat="server" placeholder="KW" class="login_inputs" MaxLength="7"></asp:TextBox>
                            <br /><asp:Label ID="Label1" runat="server" ForeColor="Red" Font-Size="20px"></asp:Label>
                            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Procced" class="login-btn"/>
                     
            </form>
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
