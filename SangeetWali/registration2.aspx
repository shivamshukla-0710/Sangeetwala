﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="registration2.aspx.cs" Inherits="registration2" %>



<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <meta charset=utf-8>
    <meta http-equiv=X-UA-Compatible content="IE=edge">
    <meta name=viewport content="width=device-width, initial-scale=1">
    <title> Abhijat Session </title>
    <meta name="description" content="">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <!-- Place favicon.ico in the root directory -->
    <!-- all css here -->
    <!-- flaticon -->
    <link rel="stylesheet" href="css/flaticon.css">
    <!-- font-family: 'ABeeZee', sans-serif; -->
    <link href="https://fonts.googleapis.com/css?family=ABeeZee" rel="stylesheet">
    <!-- animate -->
    <link rel="stylesheet" href="css/animate.min.css">
    <!-- bootstrap v3.3.6 css -->
    <link rel="stylesheet" href="css/bootstrap.min.css">
    <!-- owl.carousel css -->
    <link rel="stylesheet" href="css/owl.carousel.css">
    <link rel="stylesheet" href="css/owl.theme.css">
    <!-- font-awesome css -->
    <link rel="stylesheet" href="css/font-awesome.min.css">
    <link rel="stylesheet" href="../../../malihu.github.io/custom-scrollbar/3.0.0/jquery.mCustomScrollbar.min.css">


    <!-- RS5.0 Main Stylesheet -->
    <link rel="stylesheet" type="text/css" href="revolution/css/settings.css">

    <!-- RS5.0 Layers and Navigation Styles -->
    <link rel="stylesheet" type="text/css" href="revolution/css/layers.css">
    <link rel="stylesheet" type="text/css" href="revolution/css/navigation.css">


    <link rel=stylesheet href=style.css>
    <link rel=stylesheet href=css/responsive.css>
    <script src=js/vendor/modernizr-2.8.3.min.js></script>
    <!-- REVOLUTION JS FILES -->
    <script src=js/vendor/jquery.js></script>
    <!-- RS5.0 Core JS Files -->
    <script type="text/javascript" src="revolution/js/jquery.themepunch.tools.min838f.js?rev=5.0"></script>
    <script type="text/javascript" src="revolution/js/jquery.themepunch.revolution.min838f.js?rev=5.0"></script>
    <script type="text/javascript" src="revolution/js/extensions/revolution.extension.slideanims.min.js"></script>
    <script type="text/javascript" src="revolution/js/extensions/revolution.extension.carousel.min.js"></script>

    <script type="text/javascript" src="revolution/js/extensions/revolution.extension.layeranimation.min.js"></script>
    <script type="text/javascript" src="revolution/js/extensions/revolution.extension.navigation.min.js"></script>

    <!--[if lt IE 9]>
		<script src=https://oss.maxcdn.com/html5shiv/3.7.2/html5shiv.min.js></script>
		<script src=https://oss.maxcdn.com/respond/1.4.2/respond.min.js></script>
		<script src=http://html5shiv.googlecode.com/svn/trunk/html5.js></script>
		<![endif]-->
    <style type="text/css">
        .style1
        {
           
            color: #003366;
            font-size: large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
     <div class="wrapper">
        <!-- header area start -->
          <header class="header">
            <div class="container-fluid tc-bg-2">
                <div class="container epd-x">
                    <ul class="header-left">
                        <li class="fl pd-x-30 lh-10 pd-y-20 tc-5 fz-13 ff-abee"><i class="tc-6 lh-10 pd-x-r-5 fa fa-empire"></i>Welcome to SANGEET KALA SANSTHAN</li>
                        <li class="fl tc-5 fz-13 ff-abee dropdown"><a href="#" data-toggle="dropdown" class="dib pd-x-30 pos-r lh-10 pd-y-20 tc-5 fz-13 ff-abee"><i class="tc-6 fz-10 lh-10 pd-x-r-5 fa fa-chevron-down"></i>Find More</a>
                            <ul class="dropdown-menu">
                                <li><a href="registration.aspx">Admission Open</a></li>
                                <li><a href="course.aspx">Courses Chart</a></li>
           
                            </ul>
                        </li>
                    </ul>
                    <ul class="header-right">
                        
                        <li class="tc-6 fr"><a class="pd-x-20 tc-6 lh-10 pd-y-20 db" href="#"><i class="lh-10 fa fa-instagram"></i></a></li>
                        <li class="tc-6 fr"><a class="pd-x-20 tc-6 lh-10 pd-y-20 db" href="#"><i class="lh-10 fa fa-facebook"></i></a></li>
                        <li class="fr pd-x-30 lh-10 pd-y-20 tc-5 fz-13 ff-abee"><a href="download.aspx" class="tc-5"><i class="tc-6 lh-10 pd-x-r-5 flaticon-login"></i>Download Registration Form</a></li>
                    </ul>
                </div>
            </div>
        </header>
        <div class="clr"></div>
        <!-- header area end -->

        <!-- navbar start -->

        <nav class="navbar-1 stricky">
            <div class="container nav epd-x">
                <div class="nav-logo fl">
                    <a href="Default2.aspx" ><img src="img/logo-1.png" alt="Logo"></a>
                </div>
                <div class="fr pd-x-r-60 pd-y-50 hidden-bar-opener-wrapper">
                    <a href="#" class="db tc-3"><i class="fa hidden-bar-opener fa-bars fz-18 lh-10 fr"></i></a>
                </div>
                <div class="nav-item"><span class="fa fa-search cp search-box-btn tc-4 fr pd-x-20"></span>
                    <ul class="nav-right">
                        <li><a href="contact.aspx">contact</a></li>
                     
<li><a href="registration.aspx" style="color: #FF0000; font-weight: bold">Registration Here<i class="lh-10 tc-2 fz-18 fa fa-user"></i></a>
                            <ul class="dropdown-1">
                               
                               
                                
                                  



</a></li>
 

                            </ul>
                        </li>
                        <li><a href="#">Courses<i class="fa fa-chevron-down"></i></a>
                            <ul class="dropdown-1">
                                 <li><a href="vocal.html">Vocal</a></li>
                                <li><a href="dance.html">Dance</a></li>
                               
                                  <li><a href="instrument.html">Instruments</a></li>
                            </ul>
                        </li>  <li><a href="#">About<i class="fa fa-chevron-down"></i></a>
                            <ul class="dropdown-1">
                                 <li><a href="about.html">About Us</a></li>
                         
                                <li><a href="testimonial.html">About Testimonial</a></li>
                                 
                            </ul>
                        </li>
                        
                         <li><a href="#">Media<i class="fa fa-chevron-down"></i></a>
                            <ul class="dropdown-1">
                                 <li><a href="gallery.aspx">Gallery</a></li>
                                <li><a href="mediacoverae.html">Media Coverage</a></li>
                                <li><a href="video.aspx">Video</a></li>
                                  <li><a href="audio.aspx">Audio</a></li>
                            </ul>
                        </li> 
                      
                        <li class="active"><a href="#">home<i class="fa fa-chevron-down"></i></a>
                            <ul class="dropdown-1">
                                <li><a href="Default2.aspx">Home</a></li>
                              
                            </ul>
                        </li>
                    </ul>
                </div>
            </div>
        </nav>
        <div class="clr"></div>


        <!-- navbar end -->

        <!-- page heading start -->

        <div  
             
             style="background-image: url('img/Online_Bill_Pay_Banner1.gif'); height: 300px;">
             </div>
        <div class="clr"></div>
        <!-- page heading end -->

         <div align="center"><span class="style1"><strong>Enter Your Email&nbsp; </strong>
             </span>
             <asp:TextBox ID="TextBox1" runat="server" BackColor="Maroon" Font-Bold="True" 
                 Font-Size="Larger" ForeColor="White" Height="25px" Width="250px"></asp:TextBox>
&nbsp; <asp:ImageButton ID="ImageButton1" runat="server" 
             ImageUrl="~/revolution/pay-buttons-png-1.png" Width="20%" 
                 onclick="ImageButton1_Click"/></div>
         <asp:Panel ID="Panel1" runat="server">

          <section class="error-page container epd-x sp-lg">
            <h2 align="center" style="color: #FF0000">Payment from here</h2>
           


          
        <div align="center">  There are different fee structure for all age groups 


        <br/>

           5 - 15 : Rs.300 <div class='pm-button'><a href='https://www.payumoney.com/paybypayumoney/#/5545A463E02CEF8C1B32A82C05435172'><img src='https://www.payumoney.com/media/images/payby_payumoney/new_buttons/21.png' /></a></div> 
        
       16 - 25 : Rs.400 <div class='pm-button'><a href='https://www.payumoney.com/paybypayumoney/#/9AFED3C4F0AB3AC57B5FEC6C91DE0071'><img src='https://www.payumoney.com/media/images/payby_payumoney/new_buttons/21.png' /></a></div> 
        26 - 35 : Rs.500<div class='pm-button'><a href='https://www.payumoney.com/paybypayumoney/#/438B1A41F60FD28B681F97E54153A8C0'><img src='https://www.payumoney.com/media/images/payby_payumoney/new_buttons/21.png' /></a></div> 
     36 & above : Rs.600   <div class='pm-button'><a href='https://www.payumoney.com/paybypayumoney/#/A48C235DF1272117D68A2F125132B7C8'><img src='https://www.payumoney.com/media/images/payby_payumoney/new_buttons/21.png' />
                </a></div> 
        
        </div>
        </section>
         </asp:Panel>
 <br/> <br/> <br/> <br/>
      <div class="error-page-img-holder" align="center">
                <img src="img/point-and-play.png" alt="">
            </div>

        <!-- error 404 page content end -->


        <!-- footer start-->
<footer class="container-fluid sp-md tc-bg-4 clearfix">
            <div class="container tc-bg-5 epd-x  pd-y-20 footer-top">
                <div class="col-md-4 pd-x-l-110 epd-x-r">
                    <i class="fa fa-phone"></i>
                    <div class="dib">
                        <p class="ff-ssp pd-x-l-15 lh-13 tc-7 text-uppercase fz-18 fw-b">phone</p>
                        <p class="tc-7 fz-16 fw-n pd-x-l-15 pd-y-t-10 lh-11 ff-abee">(+91 9452205411 )</p>
                    </div>
                </div>
                <div class="col-md-4 pd-x-l-75 epd-x-r">
                    <i class="flaticon-location-marker"></i>
                    <div class="dib">
                        <p class="ff-ssp pd-x-l-15 lh-13 tc-7 text-uppercase fz-18 fw-b">address</p>
                        <p class="tc-7 fz-16 fw-n pd-x-l-15 pd-y-t-10 lh-11 ff-abee">New Gulista, Chinhat-226028</p>
                    </div>
                </div>

 
                <div class="col-md-4 pd-x-l-35 epd-x-r">
                    <i class="fa fa-paper-plane"></i>
                    <div class="dib">
                        <p class="ff-ssp pd-x-l-15 lh-13 tc-7 text-uppercase fz-18 fw-b">email</p>
                        <p class="tc-7 fz-16 fw-n pd-x-l-15 pd-y-t-10 lh-11 ff-abee">info@sangeetkalasansthan.com</p>
                    </div>
                </div>
                <div class="clr"></div>
                <!-- footer second row -->
            </div>
            <div class="clr"></div>
            <div class="container epd-x ">
                <div class="footer-bottom-wrapper pd-y-t-80">
                    <div class="col-sm-4 epd-x-l pd-x-r-40">
                        <img src="img/logo-1.png" alt="logo">
                        <p class="ff-abee fw-n fz-15 lh-26 tc-8 pd-y-t-20 m-y-b-25 pd-y-b-25">SANGEET KALA SANSTHAN Music Institute  offers various courses for Diploma to aspiring students</p>

                        <div class="section-sub-heading-left-4">subscribe us</div>
                        <form action="#" class="pos-r">
                            <input type="email" placeholder="mail@yourdomian.com" id="footer-1-subscribe-mail">
                            <button type="submit" id="footer-1-subscribe-btn"><i class="fa fa-envelope-o"></i></button>
                        </form>
                    </div>
                    <div class="col-sm-4 pd-x-l-60 pd-x-r-25">
                        <div class="section-sub-heading-left-4">Related News</div>
                        <div class="footer-recent-posts pd-y-b-30">
                            <div class="footer-recent-posts-img pd-x-r-20">
                                <img src="img/footer/footer-1.png" alt="">
                            </div>
                            <a class="footer-recent-posts-text db" href="#">
                                <span class="tc-2 ff-abee fw-n fz-13">26 July 2016</span>
                                <h6 class="text-uppercase pd-y-t-15 fz-14 ff-ssp fw-n tc-8">Nirtya Kala aayojan with new talentors </h6>
                            </a>
                        </div>
                      
                        <div class="footer-recent-posts">
                            <div class="footer-recent-posts-img pd-x-r-20">
                                <img src="img/footer/footer-3.png" alt="">
                            </div>
                            <a class="footer-recent-posts-text db" href="#">
                                <span class="tc-2 ff-abee fw-n fz-13">15 September 2016</span>
                                <h6 class="text-uppercase pd-y-t-15 fz-14 ff-ssp fw-n tc-8">We organized a  abhijat competition for all new talentors</h6>
                            </a>
                        </div>
                    </div>
                    <div class="col-sm-4 epd-x-r pd-x-l-50">
                        <div class="section-sub-heading-left-4">send us a message</div>
                        <form action="http://world5.commonsupport.com/2017/SANGEET KALA SANSTHAN/posr">
                            <input type="text" placeholder="Your Name" id="footer-1-send-name">
                            <input type="email" placeholder="Your Email" id="footer-1-send-mail">
                            <textarea id="footer-1-send-message" placeholder="Your Message"></textarea>
                            <button class="btn-six db" type="submit">send</button>
                        </form>
                    </div>
                </div>
            </div>
        </footer>
        <div class="clr"></div>
        <!-- footer end-->
        <!-- footer-two start -->

       
        <footer class="container-fluid pd-y-25 tc-bg-5">
            <div class="container">
                <p class="fz-13 ff-abee fw-n tc-8 text-center">Copyrights &copy; 2016 SANGEET KALA SANSTHAN. All Rights Reserved</p>
            </div>
        </footer>
        <div class="clr"></div>
        <!-- footer-two end -->

        <!-- .hidden-bar -->
        <div class="hidden-bar ff-ssp anim-5">
            <div class="hidden-bar-closer">
                <button class="btn">
                    <i class="fa fa-close"></i>
                </button>
            </div>
            <!-- .hidden-bar-wrapper -->
            <div class="hidden-bar-wrapper">

                <!-- .logo -->
                <div class="logo text-center">
                    <a href="Default2.aspx">
                        <img src="img/logo-1.png" alt="">
                    </a>
                </div>
                <!-- /.logo -->
                <!-- .main-menu -->
                <div class="main-menu text-center">
                    <!-- .navigation -->
                    <ul class="navigation clearfix">
                        <li class="current dropdown">
                            <a href="#">Home</a>
                            <ul class="submenu">
                                <li><a href="Default2.aspx">HOME</a></li>
                              
                            </ul>
                        </li>
                        <li class="dropdown"> <a href="#">About</a>
                          <ul class="submenu">
                                 <li><a href="about.html">About Us</a></li>
                         
                                <li><a href="testimonial.html">About Testimonial</a></li>
                                 
                            </ul>
                        </li>
                            <li class="dropdown">
                                <a href="#">Media</a>
                                <ul class="submenu">
                                  
                                 <li><a href="gallery.aspx">Gallery</a></li>
                                <li><a href="mediacoverae.html">Media Coverage</a></li>
                                <li><a href="video.aspx">Video</a></li>
                                  <li><a href="audio.aspx">Audio</a></li>
                     
                                </ul>
                            </li>
                            <li class=" dropdown">
                                <a href="#">Courses</a>
                                <ul class="submenu">
                                      <li><a href="vocal.html">Vocal</a></li>
                                <li><a href="dance.html">Dance</a></li>
                               
                                  <li><a href="instrument.html">Instruments</a></li>
                                </ul>
                            </li>
                            <li class=" dropdown ">
                                <a href="#">Classes</a>
                                <ul class="submenu">
                                       
                               
                                
                                  



</a></li>
                                </ul>
                            </li>
                            <li> <a href="contact.html">Contact</a>
                            </li>

                    </ul>
                    <!-- /.navigation -->
                </div>
                <!-- /.main-menu -->
            </div>
            <!-- /.hidden-bar-wrapper -->
        </div>
        <!-- /.hidden-bar -->


        <!--Search Popup-->
        <div id="search-popup" class="search-popup">
            <div class="close-search theme-btn"><span class="fa fa-close"></span></div>
            <div class="popup-inner">

                <div class="search-form">
                    <form method="post" action="http://world5.commonsupport.com/2017/SANGEET KALA SANSTHAN/index.html">
                        <div class="form-group">
                            <fieldset>
                                <input type="search" class="form-control" name="search-input" value="" placeholder="Search Here" required>
                                <input type="submit" value="Search" class="theme-btn">
                            </fieldset>
                        </div>
                    </form>

                    <br>
                    <h3>Recent Search Keywords</h3>
                    <ul class="recent-searches">
                        <li><a href="#">SANGEET KALA SANSTHAN</a></li>
                    
                        <li><a href="#">Vocal Music</a></li>
                    </ul>

                </div>

            </div>
        </div>

        <!--  scroll to top  -->
        <div class="scroll-to-top">
            <i class="fa fa-long-arrow-up"></i>
        </div>

    </div>
    <!--wrapper end -->

    <script src="js/bootstrap.min.js"></script>
    <script src="js/owl.carousel.min.js"></script>
    <script src="js/jquery.mixitup.min.js"></script>
    <script src="js/SmoothScroll.js"></script>
    <script src="js/jquery.countdown.min.js"></script>
    <script src="js/ion.rangeSlider.min.js"></script>
    <script src="js/html5lightbox/html5lightbox.js"></script>
    <script src="js/jquery.counterup.min.js"></script>
    <script src="js/wow.min.js"></script>
    <script src="../../../malihu.github.io/custom-scrollbar/3.0.0/jquery.mCustomScrollbar.concat.min.js"></script>
    <script src="js/main.js"></script>
   
 
    </form>
</body>
</html>

