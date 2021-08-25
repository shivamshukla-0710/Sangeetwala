<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <meta charset=utf-8>
    <meta http-equiv=X-UA-Compatible content="IE=edge">
    <meta name=viewport content="width=device-width, initial-scale=1">
    <title>SANGEET KALA SANSTHAN</title>
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



</head>
<body>


    <form id="form1" runat="server">
  <div class="wrapper">
        <!-- header area start -->
        <header class="header">
            <div class="container-fluid tc-bg-2">
                <div class="container epd-x">
                    <ul class="header-left">
                        <li class="fl pd-x-30 lh-10 pd-y-20 tc-5 fz-13 ff-abee"><i class="tc-6 lh-10 pd-x-r-5 fa fa-empire"></i><a href="abhijatsession.aspx" style="color: #FFFFFF; font-weight: bold"> Welcome to SANGEET KALA SANSTHAN ABHIJAT SESSON -1 COMPETITION</a></li>
                        <li class="fl tc-5 fz-13 ff-abee dropdown"><a href="#" data-toggle="dropdown" class="dib pd-x-30 pos-r lh-10 pd-y-20 tc-5 fz-13 ff-abee"><i class="tc-6 fz-10 lh-10 pd-x-r-5 fa fa-chevron-down"></i>Find More</a>
                            <ul class="dropdown-menu">
                                <li><a href="registration.aspx">Admission Open</a></li>
                                <li><a href="course.aspx">Courses Chart</a></li>
           
                            </ul>
                        </li>
                    </ul>
                    <ul class="header-right">
                      
                        <li class="tc-6 fr"><a class="pd-x-20 tc-6 lh-10 pd-y-20 db" href="https://www.youtube.com/channel/UCLnztEhnnEq5oQm6p2rKQbA"><i class="lh-10 fa fa-youtube"></i></a></li>
                        <li class="tc-6 fr"><a class="pd-x-20 tc-6 lh-10 pd-y-20 db" href="https://www.facebook.com/sangeetkala.sansthan"><i class="lh-10 fa fa-facebook"></i></a></li>
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
                       <%-- <li><a href="#">news<i class="fa fa-chevron-down"></i></a>
                            <ul class="dropdown-1">
                                <li><a href="blog-1.html">Latest News</a></li>
                              
                            </ul>
                        </li>--%>
<li><a href="registration.aspx" style="color: #FF0000; font-weight: bold">Registration Here<i class="lh-10 tc-2 fz-18 fa fa-user"></i></a>
                     
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
        <!-- slider-area start -->
        <!-- slider revolution-1 start -->
        <!-- START REVOLUTION SLIDER 5.0 -->
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
    <div id="jssor_1" style="position:relative;margin:0 auto;top:0px;left:0px;width:1300px;height:500px;overflow:hidden;visibility:hidden;">
        <!-- Loading Screen -->
        <div data-u="loading" class="jssorl-004-double-tail-spin" style="position:absolute;top:0px;left:0px;width:100%;height:100%;text-align:center;background-color:rgba(0,0,0,0.7);">
            <img style="margin-top:-19px;position:relative;top:50%;width:38px;height:38px;" src="img/double-tail-spin.svg" />
        </div>
        <div data-u="slides" style="cursor:default;position:relative;top:0px;left:0px;width:1300px;height:500px;overflow:hidden;">
            <div>
                <img data-u="image" src="img/g.jpg" />
            </div>
           <div>
                <img data-u="image" src="img/r.jpg" />
            </div>
            <div>
                <img data-u="image" src="img/red.jpg" />
                 
            </div>
            <div>
                <img data-u="image" src="img/purple.jpg" />
            </div>
            <div>
                <img data-u="image" src="img/blue.jpg" />
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
                   <div style="border: thin inset #009900; background-color: Orange;color:#FFFF00; font-size:18px;"><table style="width: 100%; font-weight: bold; color: #FFFF00; ">
        
        <tr>
            
            
            <td>
            
    <marquee behavior="scroll" direction="left"; scrollamount="4"; onmouseover="this.stop();" onmouseout="this.start();"><asp:Label ID="LblNews" runat="server" Text="News"></asp:Label></marquee>
        
                       </td>
           
        </tr>
       </table>
    </div>
                   

                
    
            <!-- END REVOLUTION SLIDER -->
        </div>
        <!-- END OF SLIDER WRAPPER -->

        <!-- slider-area end-->

        <!-- welcome start -->

        <section class="container-fluid welcome sp-lg" style="margin-top:-130px">
            <div class="container epd-x">
                <h2 class="section-heading-center">welcome to SANGEET KALA SANSTHAN</h2>

                <p class="section-heading-center-detail">
                
                SANGEET KALA SANSTHAN affiliated by Bhatkhande Sangeet Vidyapeeth  . <br/><br/>
                 It is an institute that believes in creating talents. <br/><br/>The course content is administered to the pupils in such a way 
                 that learning becomes a pleasure and the students look forward to their sessions with their mentors.<br/><br/> 
                 Music has rightly been referred to as the "food of love" ... that fills a person with joy and serenity. 
                 It is the most preferred choice as a stress-buster. <br/><br/>Not only humans but animals too have been benefitted by the soothing
                  and calming qualities of music as claimed by experts.. <br/><br/>we all understand that a stress –free mind is like a plain 
                  canvas waiting to be filled and brought to life by the sheer vibrancy of colors ... music provides <br/><br/> that vibrancy ...that "LIFT" that provides the much needed succor to the body, the mind and the soul. </p>
                <div class="welcome-left col-sm-7 epd-x-l">
                    <div class="welcome-left-absolute">
                        <img src="img/resources/welcome-1.png" alt="">
                    </div>
                    <br/>
                    <br/>
                    <br/>
                    <br/><br/>
                    <br/>  <br/>
                    <br/>
                    <br/>
                    <br/><br/>
                    <br/>  <br/>
                    <br/>
                    <br/>
                    <br/><br/>
                    <br/>  <br/>
                    <br/>
                    <br/>
                    <br/><br/>
                    <br/>
                   <div>
                        <h3 class="section-sub-heading-left" style="margin-right: 350px">Dr. Poonam Srivastava</h3>
                        <p class="ff-abee fz-15 tc-4 fw-n pd-y-b-35">M.A. (Vocal Music) from Kanpur University Nipun (Vocal) 1St Div. and first position in India in 1996 from Bhatkhande Music College, Lucknow Nipun (Violin),1St Div. in 1998 from Bhatkhande Music College, Lucknow  Ph.D. from Bhatkhande Sangeet Sansthan Deemed University, Lucknow in</p>
                        <a href="drpoonam.html" class="db btn-two">read more</a>
                       
                    </div>
                </div>
                <div class="welcome-right col-sm-5 pd-x-l-35">
                    <div class="welcome-right-content">
                        <div class="welcome-right-content-text pd-y-b-60">
                            <img src="img/c-slide-3.png">
                            <br/>
                               <p class="fw-n ff-abee fz-15 tc-4"> <strong>Dr. Surendra Shankar Awasthi </strong> was founder of this orgnization . 26 सितम्बर 1929 में उन्नाव जिले के सुमेरपुर गांव में जन्मे , भारतीय शास्त्रीय संगीत के इस महान उपासक को किसी परिचय की आवश्यकता नही है । शास्त्रीय संगीत को समर्पित इनका समस्त जीवनकाल अपने आप में उपलब्धियों का एक सागर है |  </p>
                          
                            <div class="welcome-right-content-text-absolute">
                               
                            </div>
                        </div>
                        <div class="welcome-right-content-text pd-y-b-60">
                            <h3 class="section-sub-heading-left-2">Best Classes</h3>
                            <p class="fw-n ff-abee fz-15 tc-4">We  have all types of indian dance , music classes with best fees structure ... </p>
                            <div class="welcome-right-content-text-absolute">
                              <img src="img/c-slide-1.png">
                            </div>
                        </div>
                        <div class="welcome-right-content-text">
                            <h3 class="section-sub-heading-left-2">Online Admission</h3>
                             <p class="fw-n ff-abee fz-15 tc-4"> In our institute , we  provided online registration  through simple  ways... </p>
                          
                            <div class="welcome-right-content-text-absolute">
                              <img src="img/2.jpg">
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
        
        
        

        <section class="our-promises xs-res sp-lg container epd-x" style ="margin-top:-275px">
            <h2 class="section-heading-center">Our Facilities</h2>
            <p class="section-heading-center-detail">Library, Theory classes, online classes, Forms & submit ion also, workshops (Practical & theoretical) and demonstration by senior and experienced artist,<br/> <br/> air-conditioned class rooms.
           <br/><br/> About us – The institute was established in the year 2002 with the blessing of renound vocalist late Dr. Surendra Shankar Awasthi Ex. Principle Bhatkhande Hindustani <br/><br/>Sangeet Mahavidyalya Lucknow. 
            <br/><br/>Sangeet Kala Sansthan has been facilitated thru affiliation by Bhatkhande Sangeet Vidyapeeth in the year 2004. </p>
            <div class="our-promises-content-wrapper pos-r">
                <!-- our-promises-left -->
                <div class="col-sm-4 epd-x-l pd-x-r-70">
                    <div class="our-promises-content pd-y-b-50">
                        <h3 class="section-sub-heading-left-2"> VOCAL</h3>
                        <p class="ff-abee fz-15 fw-n tc-4 lh-26">Singing is the act of producing musical sounds with the voice, which is often contrasted with speech. Contrary to common thought, air is not expelled with the diaphragm, but is inhaled using the diaphragm and exhaled or expelled using the abdominal and lower pelvic muscles, as with ordinary breathing. </p>
                   
                   <li style="color: #0066FF; font-size: medium; font-weight: bold; font-family: Cambria">Classical</li> 
                   <li style="color: #0066FF; font-size: medium; font-weight: bold; font-family: Cambria">Filmy</li>
                    <li style="color: #0066FF; font-size: medium; font-weight: bold; font-family: Cambria">Folk</li> </div>
                   
                </div>
                <div class="our-promises-content-absolute">
                    <img src="img/resources/our-promises-1.png" alt="">
                </div>
                <!-- our-promises-right -->
                <div class="col-sm-4 col-sm-offset-4 epd-x-r pd-x-l-70">
                    <div class="our-promises-content pd-y-b-50">
                        <h3 class="section-sub-heading-left-3 fr"> Dance</h3>
                        <div class="clr"></div>
                        <p class="ff-abee text-right fz-15 fw-n tc-4 lh-26">Kathak is among the six major classical dances of India and one of the most dynamic theater arts in the world. The word Kathak is derived from katha, meaning "the art of storytelling." It is also synonymous with the community of artists known as Kathakas whose hereditary profession it was to narrate history while entertaining.  </p>
                   <li style="color: #0066FF; font-size: medium; font-weight: bold; font-family: Cambria">Bollywood, hip hop , <br/>lyrical</li>
                   <li style="color: #0066FF; font-size: medium; font-weight: bold; font-family: Cambria"> Kathak Dance</li>
                   <li style="color: #0066FF; font-size: medium; font-weight: bold; font-family: Cambria">Zumba</li>
                    </div>
                   
                  
                </div>
                  <div>
                        <h3 align="center"> Instruments</h3>
                        <div class="clr"></div>
                        <p class="ff-abee text-right fz-15 fw-n tc-4 lh-26">Music which are the accompanions o any form of Dance or Song are an inseperable part to make any composition complete. The knowledge of musical notes and the sound produced with each note instills what we know as "sense of music" .... dancing and singing follow once this "sense of music" is polished. Instrumental knowledge can be considered as the basic knowledge of music. 

<br/><p style="color: #3333FF; font-size: medium; font-family: Constantia">1.♫ Violin,

2.♫ Tabla,
3.♫ Guitar,
4.♫ Ketboard , 5.♫ Harmonium</p> </p>
                    </div>
            </div>
        </section>
        <div class="clr"></div>
        <!-- our-promises end -->

        <!-- callout start -->

        <div class="container-fluid callout sp-lg-2 clearfix">
            <p class="fz-22 ff-abee fw-n tc-6 lh-11 text-center">Become a part our Team</p>
            <h2 class="fz-40 ff-ssp-l fw-n text-center tc-6 lh-28 text-uppercase pd-y-t-50">Support Us for your Better Future</h2>
            <div class="callout-btn pd-y-t-50">
                <div class="btn-four fl ">become a Member</div>
                <div class="btn-five fl m-x-l-20">donate for us</div>
            </div>
        </div>
        <div class="clr"></div>
        <!-- callout end -->


        <!-- politicians start -->


        <!-- politicians end -->
        <div class="clr"></div>
     
        <!-- client end -->

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

                         <div class="footer-recent-posts">
                          <audio controls autoplay>
  <source src="horse.ogg" type="audio/ogg">
  <source src="horse.mp3" type="audio/mpeg">
  Your browser does not support the audio element.
</audio>
</audio>
                        </div>
                        
                    </div>
                    <div class="col-sm-4 epd-x-r pd-x-l-50">
                        <div class="section-sub-heading-left-4">send us a message</div>
                      <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                           <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox> 
                           
                           <input type="text" placeholder="Your Name" id="footer-1-send-name" onclick="return footer-1-send-name_onclick()">
                            <input type="email" placeholder="Your Email" id="footer-1-send-mail">
                            <textarea id="footer-1-send-message" placeholder="Your Message"></textarea>
                            <button class="btn-six db" type="submit">send</button>
                   
                    </div>
                </div>
            </div>
        </footer>
        <div class="clr"></div>
        <!-- footer end-->
        <!-- footer-two start -->

        <footer class="container-fluid pd-y-25 tc-bg-5">
            <div class="container">
                <p class="fz-13 ff-abee fw-n tc-8 text-center"><a href="Admin/Login.aspx">Copyrights &copy; 2016 SANGEET KALA SANSTHAN. All Rights Reserved</a></p>
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
    <script src="../../../malihu.github.io/custom-scrollbar/3.0.0/jquery.mCustomScrollbar.concat.min.js"></script>
    <script src="js/wow.min.js"></script>
    <script src="js/main.js"></script>

    </form>
</body>
</html>

