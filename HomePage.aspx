<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="Fawatir.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="X-UA-Compatible" content="IE=edge"/>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <title>Home - Fawatir</title>
    <meta property="og:title" content="Fawatir"/>
    <meta property="og:description" content="Fawatir"/>
    <meta property="og:url" content="/"/>
    <link rel="stylesheet" href="assets/css/slick.css"/>
    <link rel="stylesheet" href="assets/css/slick-theme.css"/>
    <link rel="stylesheet" href="assets/css/main.css?1" />
</head>
<body class="homepage">
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
    <div class="main-container homepage">
        <div class="homepage_carousel">
            <div class="wrapper slick">
                <div class="slides">
                    <figure style="background-image:url('/images/ainebel_image_2.jpg');background-repeat:no-repeat;background-position:center center;background-size:cover"></figure>
                    <div class="description">
                        <div class="section-wrapper">
                            <h1>Welcome To Fawatir</h1>
                            <p>Fawatir is an E-Commerce website that helps residents in Ain Ebel to pay their bills online</p>
                            <a href="#visitor_login" class="get_started">Get Started</a>
                        </div>
                    </div>
                </div>
                <div class="slides">
                    <figure style="background-image:url('/images/ainebel_image_1.jpg');background-repeat:no-repeat;background-position:center center;background-size:cover"></figure>
                </div>
                <div class="slides">
                    <figure style="background-image:url('/images/ainebel_image_4.jpg');background-repeat:no-repeat;background-position:center center;background-size:cover"></figure>
                </div>
                <div class="slides">
                    <figure style="background-image:url('/images/ainebel_image_11.jpg');background-repeat:no-repeat;background-position:center center;background-size:cover"></figure>
                </div>
                <div class="slides">
                    <figure style="background-image:url('/images/ainebel_image_3.jpg');background-repeat:no-repeat;background-position:center center;background-size:cover"></figure>
                </div>
                <div class="slides">
                    <figure style="background-image:url('/images/ae.jpg');background-repeat:no-repeat;background-position:center center;background-size:cover"></figure>
                </div>
            </div>
        </div>
        <div id="visitor_login" class="visitor_login">
            <div class="wrapper">
                <div class="top">
                    <h1>Enroll in Fawatir</h1>
                    <p>If you are a User please click on enroll as a User, if you are a service provider please login</p>
                </div>
                <form id="form1" runat="server">
                <div>
                </div>
                <asp:Button ID="Button1" class="login_buttons" runat="server" OnClick="Button1_Click" Text="Enroll as User" />
                <div class="service_provider">
                    <asp:Button ID="Button2" class="login_buttons" runat="server" OnClick="Button2_Click" Text="Login as a Provider" />
                    <span class="question-sign">?</span>
                    <div class="info hide">Service Provider is a user who provides a service (Internet, Electricity, Water or Local) </div>
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
