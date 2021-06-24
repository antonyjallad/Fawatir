<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="contact-us.aspx.cs" Inherits="Fawatir.contact_us" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="X-UA-Compatible" content="IE=edge"/>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <title>Contact Us - Fawatir</title>
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
    </div> <div class="main-container contact_us">
        <div class="banner">
            <figure style="background: url('/images/ainebel_image_4.jpeg');background-repeat:no-repeat;background-position:center center;background-size:cover"></figure>
        </div>
        <form id="form1" runat="server">
                <div class="content">
                    <div class="section-wrapper">
                        <div class="left">
                            <h1> Contact Us</h1>
                            <p>If you have any questions or queries, a member of Connect with us staff will always be happy to help. Feel free to contact us by phone or email and we will be here for support or any questions to get back to you as soon as possible. Email us at <a href="mailto:fawatirae@hotmail.com">fawatirae@hotmail.com</a></p>
                        </div>
                        <div class="right">
                            <p>Municipality Building</p>
                            <p>3th Floor</p>
                            <p>Ain-Ebel South lebanon</p>
                            <p>Lebanon</p>
                        </div>
                    </div>
                </div>
        </form>
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