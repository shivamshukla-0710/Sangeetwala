<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head  runat="server">
  <meta charset=utf-8>
    <meta http-equiv=X-UA-Compatible content="IE=edge">
    <meta name=viewport content="width=device-width, initial-scale=1">
    <title>Registration Here</title>
    <meta name="description" content="">
    <meta name="viewport" content="width=device-width, initial-scale=1">
<link type="text/css" href="css/ui-lightness/jquery-ui-1.8.19.custom.css" rel="stylesheet" />
<script type="text/javascript" src="js/jquery-1.7.2.min.js"></script>
<script type="text/javascript" src="js/jquery-ui-1.8.19.custom.min.js"></script>
<script type="text/javascript">
$(function() {
    $("#TextBox4").datepicker();
});
</script>
<style type="text/css">
.ui-datepicker { font-size:8pt !important}
</style>


    <!-- Place favicon.ico in the root directory -->
    <!-- all css here -->
    <!-- flaticon -->
    <link rel="stylesheet" href="css/flaticon.css">
    <!-- font-family: 'ABeeZee', sans-serif; -->
    <link href="https://fonts.googleapis.com/css?family=ABeeZee" rel="stylesheet">
    <!-- animate -->
    <link rel="stylesheet" href="../css/animate.min.css">
    <!-- bootstrap v3.3.6 css -->
    <link rel="stylesheet" href="../css/bootstrap.min.css">
    <!-- owl.carousel css -->
    <link rel="stylesheet" href="../css/owl.carousel.css">
    <link rel="stylesheet" href="../css/owl.theme.css">
    <!-- font-awesome css -->
    <link rel="stylesheet" href="../css/font-awesome.min.css">
    <link rel="stylesheet" href="../../../malihu.github.io/custom-scrollbar/3.0.0/jquery.mCustomScrollbar.min.css">


    <!-- RS5.0 Main Stylesheet -->
    <link rel="stylesheet" type="text/css" href="../revolution/css/settings.css">

    <!-- RS5.0 Layers and Navigation Styles -->
    <link rel="stylesheet" type="text/css" href="../revolution/css/layers.css">
    <link rel="stylesheet" type="text/css" href="../revolution/css/navigation.css">


    <link rel=stylesheet href=../style.css>
    <link rel=stylesheet href="../css/responsive.css">
    <script src=../js/vendor/modernizr-2.8.3.min.js></script>
    <!-- REVOLUTION JS FILES -->
    <script src="js/vendor/jquery.js"></script>
    <!-- RS5.0 Core JS Files -->
    <script type="text/javascript" src="../revolution/js/jquery.themepunch.tools.min838f.js?rev=5.0"></script>
    <script type="text/javascript" src="../revolution/js/jquery.themepunch.revolution.min838f.js?rev=5.0"></script>
    <script type="text/javascript" src="../revolution/js/extensions/revolution.extension.slideanims.min.js"></script>
    <script type="text/javascript" src="../revolution/js/extensions/revolution.extension.carousel.min.js"></script>

    <script type="text/javascript" src="../revolution/js/extensions/revolution.extension.layeranimation.min.js"></script>
    <script type="text/javascript" src="../revolution/js/extensions/revolution.extension.navigation.min.js"></script>
     <!--[if lt IE 9]>
		<script src=https://oss.maxcdn.com/html5shiv/3.7.2/html5shiv.min.js></script>
		<script src=https://oss.maxcdn.com/respond/1.4.2/respond.min.js></script>
		<script src=http://html5shiv.googlecode.com/svn/trunk/html5.js></script>
		<![endif]-->
        <style>
		@font-face {
    font-family: myFirstFont;
    src:url(assets/fonts/HammersmithOne-Regular.ttf);
		}
    /* The Modal (background) */
.modal {
    display: none; /* Hidden by default */
    position: fixed; /* Stay in place */
    z-index: 1; /* Sit on top */
    padding-top: 150px; /* Location of the box */
    left: 0;
    top: 0;
    width: 100%; /* Full width */
    height: 100%; /* Full height */
    overflow: auto; /* Enable scroll if needed */
    background-color: rgb(0,0,0); /* Fallback color */
    background-color: rgba(0,0,0,0.4); /* Black w/ opacity */
	font-size:1.3em;
}

/* Modal Content */
.modal-content {
    background-color: #fefefe;
    margin: auto;
    padding: 20px;
    border: 1px solid #888;
    width: 80%;
}

/* The Close Button */
.close {
    color: #aaaaaa;
    float: right;
    font-size: 22px;
    font-weight: bold;
}

.close:hover,
.close:focus {
    color: #000;
    text-decoration: none;
    cursor: pointer;
}

		</style>
</head>

<body>
<form id="form1" runat="server">
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
                        <li class="fr pd-x-30 lh-10 pd-y-20 tc-5 fz-13 ff-abee"><a href="registration.aspx" class="tc-5"><i class="tc-6 lh-10 pd-x-r-5 flaticon-login"></i>Login / Register</a></li>
                    </ul>
                </div>
            </div>
        </header>
        <div class="clr"></div>
          <nav class="navbar-1 stricky">
            <div class="container nav epd-x">
                <div class="nav-logo fl">
                    <a href="../Default2.aspx" ><img src="../img/logo-1.png" alt="Logo"></a>
                </div>
                <div class="fr pd-x-r-60 pd-y-50 hidden-bar-opener-wrapper">
                    <a href="#" class="db tc-3"><i class="fa hidden-bar-opener fa-bars fz-18 lh-10 fr"></i></a>
                </div>
                <div class="nav-item"><span class="fa fa-search cp search-box-btn tc-4 fr pd-x-20"></span>
                    <ul class="nav-right">
                        <li><a href="../contact.aspx">contact</a></li>
                       <%-- <li><a href="#">news<i class="fa fa-chevron-down"></i></a>
                            <ul class="dropdown-1">
                                <li><a href="blog-1.html">Latest News</a></li>
                              
                            </ul>
                        </li>--%>
<li><a href="Default.aspx" style="color: #FF0000; font-weight: bold">Registration Here<i class="lh-10 tc-2 fz-18 fa fa-user"></i></a>
                           
                        </li>
                        <li><a href="#">Courses<i class="fa fa-chevron-down"></i></a>
                            <ul class="dropdown-1">
                                 <li><a href="../vocal.html">Vocal</a></li>
                                <li><a href="../dance.html">Dance</a></li>
                               
                                  <li><a href="../instrument.html">Instruments</a></li>
                            </ul>
                        </li>  <li><a href="#">About<i class="fa fa-chevron-down"></i></a>
                            <ul class="dropdown-1">
                                 <li><a href="../about.html">About Us</a></li>
                         
                                <li><a href="../testimonial.html">About Testimonial</a></li>
                                 
                            </ul>
                        </li>
                        
                         <li><a href="#">Media<i class="fa fa-chevron-down"></i></a>
                            <ul class="dropdown-1">
                                 <li><a href="../portfolio.html">Gallery</a></li>
                                <li><a href="../mediacoverae.html">Media Coverage</a></li>
                                <li><a href="../video.aspx">Video</a></li>
                                  <li><a href="../audio.aspx">Audio</a></li>
                            </ul>
                        </li> 
                      
                        <li class="active"><a href="#">home<i class="fa fa-chevron-down"></i></a>
                            <ul class="dropdown-1">
                                <li><a href="../Default2.aspx">Home</a></li>
                              
                            </ul>
                        </li>
                    </ul>
                </div>
            </div>
        </nav>
        
       
        <div class="clr"></div>
        <div class="rev_slider_wrapper">
            <div id="slider1" class="rev_slider text-uppercase" data-version="5.0">
                
    <!-- #region Jssor Slider Begin -->
    <!-- Generator: Jssor Slider Maker -->
    <!-- Source: https://www.jssor.com -->
    <script src="js/jquery-1.11.3.min.js" type="text/javascript"></script>
    <script src="js/jssor.slider-25.0.7.min.js" type="text/javascript"></script>
    <script type="text/javascript">
        jQuery(document).ready(function ($) {

            var jssor_1_SlideoTransitions = [
              [{ b: 900, d: 2000, x: -379, e: { x: 7}}],
              [{ b: 900, d: 2000, x: -379, e: { x: 7}}],
              [{ b: -1, d: 1, o: -1, sX: 2, sY: 2 }, { b: 0, d: 900, x: -171, y: -341, o: 1, sX: -2, sY: -2, e: { x: 3, y: 3, sX: 3, sY: 3} }, { b: 900, d: 1600, x: -283, o: -1, e: { x: 16}}]
            ];

            var jssor_1_options = {
                $AutoPlay: 1,
                $SlideDuration: 800,
                $SlideEasing: $Jease$.$OutQuint,
                $CaptionSliderOptions: {
                    $Class: $JssorCaptionSlideo$,
                    $Transitions: jssor_1_SlideoTransitions
                },
                $ArrowNavigatorOptions: {
                    $Class: $JssorArrowNavigator$
                },
                $BulletNavigatorOptions: {
                    $Class: $JssorBulletNavigator$
                }
            };

            var jssor_1_slider = new $JssorSlider$("jssor_1", jssor_1_options);

            /*#region responsive code begin*/
            /*remove responsive code if you don't want the slider scales while window resizing*/
            function ScaleSlider() {
                var refSize = jssor_1_slider.$Elmt.parentNode.clientWidth;
                if (refSize) {
                    refSize = Math.min(refSize, 3000);
                    jssor_1_slider.$ScaleWidth(refSize);
                }
                else {
                    window.setTimeout(ScaleSlider, 30);
                }
            }
            ScaleSlider();
            $(window).bind("load", ScaleSlider);
            $(window).bind("resize", ScaleSlider);
            $(window).bind("orientationchange", ScaleSlider);
            /*#endregion responsive code end*/
        });
    </script>
    <style>
        /* jssor slider loading skin double-tail-spin css */

        .jssorl-004-double-tail-spin img {
            animation-name: jssorl-004-double-tail-spin;
            animation-duration: 1.2s;
            animation-iteration-count: infinite;
            animation-timing-function: linear;
        }

        @keyframes jssorl-004-double-tail-spin {
            from {
                transform: rotate(0deg);
            }

            to {
                transform: rotate(360deg);
            }
        }


        .jssorb051 .i {position:absolute;cursor:pointer;}
        .jssorb051 .i .b {fill:#fff;fill-opacity:0.5;stroke:#000;stroke-width:400;stroke-miterlimit:10;stroke-opacity:0.5;}
        .jssorb051 .i:hover .b {fill-opacity:.7;}
        .jssorb051 .iav .b {fill-opacity: 1;}
        .jssorb051 .i.idn {opacity:.3;}

        .jssora051 {display:block;position:absolute;cursor:pointer;}
        .jssora051 .a {fill:none;stroke:#fff;stroke-width:360;stroke-miterlimit:10;}
        .jssora051:hover {opacity:.8;}
        .jssora051.jssora051dn {opacity:.5;}
        .jssora051.jssora051ds {opacity:.3;pointer-events:none;}
    </style>
    <div id="jssor_1" style="position:relative;margin:0 auto;top:0px;left:0px;width:1300px;height:460px;overflow:hidden;visibility:hidden;">
        <!-- Loading Screen -->
        <div data-u="loading" class="jssorl-004-double-tail-spin" style="position:absolute;top:0px;left:0px;width:100%;height:100%;text-align:center;background-color:rgba(0,0,0,0.7);">
            <img style="margin-top:-19px;position:relative;top:50%;width:38px;height:38px;" src="../img/double-tail-spin.svg" />
        </div>
        <div data-u="slides" style="cursor:default;position:relative;top:0px;left:0px;width:1300px;height:460px;overflow:hidden;">
            <div>
                <img data-u="image" src="../img/01banner.jpg" />
            </div>
           <div>
                <img data-u="image" src="../img/dancebanner.jpg" />
            </div>
      
            <div>
                <img data-u="image" src="../img/instrumental.jpg" />
            </div>
             
            <a data-u="any" href="https://www.jssor.com" style="display:none">slider bootstrap</a>
        </div>
        <!-- Bullet Navigator -->
        <div data-u="navigator" class="jssorb051" style="position:absolute;bottom:14px;right:12px;" data-autocenter="1" data-scale="0.5" data-scale-bottom="0.75">
            <div data-u="prototype" class="i" style="width:18px;height:18px;">
                <svg viewbox="0 0 16000 16000" style="position:absolute;top:0;left:0;width:100%;height:100%;">
                    <circle class="b" cx="8000" cy="8000" r="5800"></circle>
                </svg>
            </div>
        </div>
        <!-- Arrow Navigator -->
        <div data-u="arrowleft" class="jssora051" style="width:65px;height:65px;top:0px;left:25px;" data-autocenter="2" data-scale="0.75" data-scale-left="0.75">
            <svg viewbox="0 0 16000 16000" style="position:absolute;top:0;left:0;width:100%;height:100%;">
                <polyline class="a" points="11040,1920 4960,8000 11040,14080 "></polyline>
            </svg>
        </div>
        <div data-u="arrowright" class="jssora051" style="width:65px;height:65px;top:0px;right:25px;" data-autocenter="2" data-scale="0.75" data-scale-right="0.75">
            <svg viewbox="0 0 16000 16000" style="position:absolute;top:0;left:0;width:100%;height:100%;">
                <polyline class="a" points="4960,1920 11040,8000 4960,14080 "></polyline>
            </svg>
        </div>
    </div>
            </div>
        <br/>
         
        </div>
     
            <h1 class="ff-ssp fz-40 fw-b text-center tc-6 lh-26 pd-y-b-60 text-uppercase" 
                style="color: #008000">Register From Here</h1>
            <h4 class="ff-ssp text-center tc-6 fz-14 lh-10 fw-b text-uppercase" 
                style="color: #FF0000; font-size: large; font-weight: bold;">
  If you can't teach me to fly , <br/><br/> then teach me music  -- <br/> <br/><p style="color: #000066; font-size: small">Dr. Poonam Srivastava (Director of Sangeet kala sansthan chinhat lucknow)
            </p>
            </h4>
        </div>
        <div class="clr"></div>
      
         <br/>
            <h3 class="section-sub-heading-left-7" dir="ltr" align="center">
               
            </h3>
<table style=" width:100% ; margin-left: 10%;" align="center">
            <tr><td>&nbsp;</td><td width="35%" 
                    style="color: #000099; font-size: medium; font-weight: bold; font-family: 'Bookman Old Style';">Name</td><td width="45%">
                <asp:TextBox ID="TextBox1" runat="server" 
                    BackColor="#0066FF" Width="250px" Height="30px" ForeColor="White"></asp:TextBox></td></tr>
                    <tr><td>&nbsp;</td><td width="35%" 
                            style="color: #000099; font-size: medium; font-weight: bold; font-family: 'Bookman Old Style';"></td><td width="45%"></td></tr>
            <tr><td>&nbsp;</td><td width="35%" 
                    style="color: #000099; font-size: medium; font-weight: bold; font-family: 'Bookman Old Style';">Father Name</td><td width="45%">
                <asp:TextBox ID="TextBox2" 
                    runat="server" BackColor="#0066FF" Width="250px" Height="30px" 
                        ForeColor="White"></asp:TextBox></td></tr>
                    <tr><td>&nbsp;</td><td width="35%" 
                            style="color: #000099; font-size: medium; font-weight: bold; font-family: 'Bookman Old Style';"></td><td width="45%"></td></tr>
            <tr><td>&nbsp;</td><td width="35%" 
                    style="color: #000099; font-size: medium; font-weight: bold; font-family: 'Bookman Old Style';">Mother Name</td><td width="45%">
                <asp:TextBox ID="TextBox3" 
                    runat="server" BackColor="#0066FF" Width="250px" Height="30px" 
                        ForeColor="White"></asp:TextBox></td></tr>
           <tr><td>&nbsp;</td><td width="35%" 
                   style="color: #000099; font-size: medium; font-weight: bold; font-family: 'Bookman Old Style';"></td><td width="45%"></td></tr>
                       <tr><td>&nbsp;</td><td width="35%" 
                               style="color: #000099; font-size: medium; font-weight: bold; font-family: 'Bookman Old Style';">Date of Birth</td><td width="45%">
                           <asp:TextBox ID="TextBox4" 
                               runat="server" BackColor="#0066FF" Width="250px" Height="30px" 
                                   ForeColor="White"></asp:TextBox>
                                
                                           
                               
                               </td>
                               
                               </tr>
                               <tr><td>&nbsp;</td><td width="35%" 
                                       style="color: #000099; font-size: medium; font-weight: bold; font-family: 'Bookman Old Style';"></td><td width="45%"></td></tr>
            <tr><td>&nbsp;</td><td width="35%" 
                    style="color: #000099; font-size: medium; font-weight: bold; font-family: 'Bookman Old Style';">Address</td><td width="45%">
                <asp:TextBox ID="TextBox5" runat="server" 
                    BackColor="#0066FF" Width="250px" Height="30px" ForeColor="White"></asp:TextBox></td></tr>
                    <tr><td>&nbsp;</td><td width="35%" 
                            style="color: #000099; font-size: medium; font-weight: bold; font-family: 'Bookman Old Style';"></td><td width="45%"></td></tr>
            <tr><td>&nbsp;</td><td width="35%" 
                    style="color: #000099; font-size: medium; font-weight: bold; font-family: 'Bookman Old Style';">City</td><td width="45%">
                <asp:TextBox ID="TextBox6" runat="server" 
                    BackColor="#0066FF" Width="250px" Height="30px" ForeColor="White"></asp:TextBox></td></tr>
            <tr><td>&nbsp;</td><td width="35%" 
                    style="color: #000099; font-size: medium; font-weight: bold; font-family: 'Bookman Old Style';"></td><td width="45%"></td></tr>
                        <tr><td>&nbsp;</td><td width="35%" 
                                style="color: #000099; font-size: medium; font-weight: bold; font-family: 'Bookman Old Style';">Contact</td><td width="45%">
                            <asp:TextBox ID="TextBox7" runat="server" 
                                BackColor="#0066FF" Width="250px" Height="30px" ForeColor="White"></asp:TextBox></td></tr>
                                <tr><td>&nbsp;</td><td width="35%" 
                                        style="color: #000099; font-size: medium; font-weight: bold; font-family: 'Bookman Old Style';"></td><td width="45%"></td></tr>
            <tr><td>&nbsp;</td><td width="35%" 
                    style="color: #000099; font-size: medium; font-weight: bold; font-family: 'Bookman Old Style';">Email Id</td><td width="45%">
                <asp:TextBox ID="TextBox8" runat="server" 
                    BackColor="#0066FF" Width="250px" Height="30px" ForeColor="White"></asp:TextBox></td></tr>
                    <tr><td>&nbsp;</td><td width="35%" 
                            style="color: #000099; font-size: medium; font-weight: bold; font-family: 'Bookman Old Style';"></td><td width="45%"></td></tr>
            <tr><td>&nbsp;</td><td width="35%" 
                    style="color: #000099; font-size: medium; font-weight: bold; font-family: 'Bookman Old Style';">Gender</td><td width="45%">
                    <asp:DropDownList ID="DropDownList2" 
                    runat="server" BackColor="#3366FF" Height="30px" Width="250px" 
                        ForeColor="White">
                <asp:ListItem>Male</asp:ListItem>
                <asp:ListItem>Female</asp:ListItem>
                <asp:ListItem>Other</asp:ListItem>
                </asp:DropDownList></td></tr>
                    <tr><td>&nbsp;</td><td width="35%" 
                            style="color: #000099; font-size: medium; font-weight: bold; font-family: 'Bookman Old Style';"></td><td width="45%"></td></tr>
             <tr><td>&nbsp;</td><td width="35%" 
                     style="color: #000099; font-size: medium; font-weight: bold; font-family: 'Bookman Old Style';">Upload Video</td><td width="45%"><asp:FileUpload ID="FileUpload1" 
                     runat="server" Width="250px"></asp:FileUpload>
                   

                    
                 </td></tr>
                  <tr><td>&nbsp;</td><td width="35%" 
                            style="color: #000099; font-size: medium; font-weight: bold; font-family: 'Bookman Old Style';"></td><td width="45%"></td></tr>
                  <tr><td>&nbsp;</td><td width="35%" 
                     style="color: #000099; font-size: medium; font-weight: bold; font-family: 'Bookman Old Style';"> Or Provide us your Video Youtube Link</td><td width="45%">

                    
                     <asp:TextBox ID="TextBox11" runat="server" BackColor="#3366FF" 
                         ForeColor="White" Height="30px" Width="250px"></asp:TextBox>
                   
                 </td></tr>
                     <tr><td>&nbsp;</td><td width="35%" 
                             style="color: #000099; font-size: medium; font-weight: bold; font-family: 'Bookman Old Style';"></td><td width="45%"></td></tr>
            <tr><td>&nbsp;</td><td width="35%" 
                    style="color: #000099; font-size: medium; font-weight: bold; font-family: 'Bookman Old Style';">Types Of Video</td><td width="45%"><asp:DropDownList ID="DropDownList1" 
                    runat="server" BackColor="#3366FF" Height="30px" Width="250px" 
                        ForeColor="White">
                <asp:ListItem>VOCAL</asp:ListItem>
                <asp:ListItem>DANCE</asp:ListItem>
                <asp:ListItem>INSTRUMENTS</asp:ListItem>
                </asp:DropDownList></td></tr>
                   
            <tr><td>&nbsp;</td><td width="35%" 
                    style="color: #000099; font-size: medium; font-weight: bold; font-family: 'Bookman Old Style';">
                &nbsp;</td><td width="45%">&nbsp;</td></tr>
                   
            <tr><td>&nbsp;</td><td width="35%" 
                    style="color: #000099; font-size: medium; font-weight: bold; font-family: 'Bookman Old Style';">
                Video Category</td><td width="45%">
                    <asp:DropDownList ID="DropDownList3" 
                    runat="server" BackColor="#3366FF" Height="30px" Width="250px" 
                        ForeColor="White">
                <asp:ListItem>Classical</asp:ListItem>
                <asp:ListItem>Filmy</asp:ListItem>
                <asp:ListItem>Folk</asp:ListItem>
                </asp:DropDownList></td></tr>
                   
                     <tr><td></td><td width="5%"></td><td width="55%">
                                                          <asp:CheckBox ID="CheckBox1" runat="server" 
                                            oncheckedchanged="CheckBox1_CheckedChanged" 
                                            Text="I read the Terms and Conditions" />
                                        <label class="checkbox" style="font-size:large;">
                                            Please read the
                                            <a href="#" id="myBtn">Terms and Conditions</a>
                                        </label>
                                </tr>
                    <tr><td>&nbsp;</td><td width="35%" 
                            style="color: #000099; font-size: medium; font-weight: bold; font-family: 'Bookman Old Style';"></td><td width="45%"> 


          
        <asp:TextBox ID="TextBox9" runat="server" />
         </td></tr>
           <tr><td>&nbsp;</td><td width="35%" 
                   style="color: #000099; font-size: medium; font-weight: bold; font-family: 'Bookman Old Style';">&nbsp;</td><td width="45%">
               <asp:ImageButton ID="ImageButton1" runat="server" 
                   ImageUrl="~/img/Submit-Button-PNG-Clipart.png" Width="25%" 
                       onclick="ImageButton1_Click" />
               </td></tr>
           
             </table>

               <div class="clr"></div>

        <!-- contact page content end -->
                    <div id="myModal" class="modal">

  <!-- Modal content -->
  <div class="modal-content">
  
    <span class="close">&times;</span>
    <h1 style="font-weight: bold; font-size: large; color: #003300; font-family: 'Courier New', Courier, monospace">Please pay attention to the following points:*</h1>
    TERMS & CONDITIONS
                                               
 	
 <br/>
  <br/> <br/> 
<p style="color: #000080; font-size: small">1. The audition video should contain a song , sung and recorded by the participant in his/her own voice . 
</p>
<p style="color: #000080; font-size: small">2. 	Studio Recording is  not allowed.
 </p>

<p style="color: #000080; font-size: small">3.	The participant shall ensure that the maximum size of video should not be more than 15 MB , 
 	Last date to apply – 30th September

       </p>
<p style="color: #000080; font-size: small">4.  NOTE:    Any audition video exceeding the foresaid criteria shall be rejected </p>

     
      <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click" 
          Font-Bold="True" ForeColor="#CC0000">Click here for complete your form after Submit</asp:LinkButton>
     
      
  </div>

</div>

<script>
    // Get the modal
    var modal = document.getElementById('myModal');

    // Get the button that opens the modal
    var btn = document.getElementById("myBtn");

    // Get the <span> element that closes the modal
    var span = document.getElementsByClassName("close")[0];

    // When the user clicks the button, open the modal 
    btn.onclick = function () {
        modal.style.display = "block";
    }

    // When the user clicks on <span> (x), close the modal
    span.onclick = function () {
        modal.style.display = "none";
    }

    // When the user clicks anywhere outside of the modal, close it
    window.onclick = function (event) {
        if (event.target == modal) {
            modal.style.display = "none";
        }
    }
</script>
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
                        <li> <a href="about.html">About</a>
                        <li class="dropdown">
                            <a href="#">issues</a>
                            <ul class="submenu">
                                <li><a href="portfolio.html">portfolio</a></li>
                                <li><a href="team.html">team</a></li>
                               
                            </ul>
                        </li>
                        <li class=" dropdown">
                            <a href="#">events</a>
                            <ul class="submenu">
                                <li><a href="events-1.html">events 1</a></li>
                      
                              
                            </ul>
                        </li>
                        <li class=" dropdown ">
                            <a href="#">news</a>
                            <ul class="submenu">
                 
                   
                              
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
                        <li><a href="#">Politics</a></li>
                        <li><a href="#">Future Plan</a></li>
                        <li><a href="#">Logistics</a></li>
                        <li><a href="#">Freedom</a></li>
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
    <script src="http://maps.google.com/maps/api/js"></script>
    <script src="js/owl.carousel.min.js"></script>
    <script src="js/jquery.mixitup.min.js"></script>
    <script src="js/gmaps.min.js"></script>
    <script src="js/map-helper.js"></script>
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
