<%@ Page Language="C#" AutoEventWireup="true" CodeFile="distration_vid.aspx.cs" Inherits="Admin_distration_vid" %>





<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">

<head>

 
<title>Sanjeevani Education || World class Educcation Centre</title>

<script src="../js/jquery-1.10.2.min.js"></script>
<script src="../js/jquery-migrate-1.2.1.min.js"></script>
<link href="../css/bootstrapbranch.css" rel="stylesheet">
<link href="../css/bootstrap.css" rel="stylesheet">

<link rel="stylesheet" type="text/css" href="../css/style.css">
<link href="../newcss/stylesnew.css" rel="stylesheet">
<link rel="stylesheet" type="text/css" href="../newcss/sidemenustyle.css" />
<script src="../js/jquery-ui.js"></script>
<link rel="stylesheet" href="../css/jquery-ui.css">
<!--<script src="http:/ewebcore.net/agarwal/assets/js/picturefill.min.js"></script>-->
<link rel="stylesheet" type="text/css" href="../css/jquery.timepicker.css" />
<script type="text/javascript" src="../js/jquery.timepicker.js"></script>
<link rel="icon" href="../images/favicon.png" type="image/gif" sizes="16x16">
<script type="text/javascript" src="../js/common.js"></script>
<script type="text/javascript" src="../newcss/jqueryslidemenu.html"></script>
<script type="text/javascript" src="../js/jquery.nyroModal.custom.js"></script>
<script src="../js/jquery.ui.core.js"></script>
<script src="../js/jquery.ui.widget.js"></script>
<script src="../js/jquery.ui.datepicker.js"></script>

<link type="text/css" href="../css/fg.menu.css" media="screen" rel="stylesheet" />
<link type="text/css" href="../css/menus/ui.all.css" media="screen" rel="stylesheet" />
<!--[if lte IE 7]>
		<link rel="stylesheet" type="text/css" href="css/ie7.css" />
	<![endif]-->
<style type="text/css">
		.hidden { position:absolute; top:0; left:-9999px; width:1px; height:1px; overflow:hidden; }
		.fg-button { clear:left; margin:0 4px 0 20px; padding: .4em 1em; text-decoration:none !important; cursor:pointer; position: relative; text-align: center; zoom: 1; }
		.fg-button .ui-icon { position: absolute; top: 50%; margin-top: -8px; left: 50%; margin-left: -8px; }
		a.fg-button { float:left;  }
		button.fg-button { width:auto; overflow:visible; } /* removes extra button width in IE */
		.fg-button-icon-left { padding-left: 2.1em; }
		.fg-button-icon-right { padding-right: 2.1em; }
		.fg-button-icon-left .ui-icon { right: auto; left: .2em; margin-left: 0; }
		.fg-button-icon-right .ui-icon { left: auto; right: .2em; margin-left: 0; }
		.fg-button-icon-solo { display:block; width:8px; text-indent: -9999px; }	 /* solo icon buttons must have block properties for the text-indent to work */	
		.fg-button.ui-state-loading .ui-icon { background: url(images/spinner_bar.gif) no-repeat 0 0;}
		.ui-widget {font-size: 0.9em;}
		/*.ui-widget-content .ui-icon {background-image:none;}*/
	.style1
    {
        height: 198px;
    }
	</style>
<script type="text/javascript" src="../js/fg.menu.js"></script>
<script type="text/javascript">
    $(document).ready(function () {
        // BUTTONS
        $('.fg-button').hover(
    		function () { $(this).removeClass('ui-state-default').addClass('ui-state-focus'); },
    		function () { $(this).removeClass('ui-state-focus').addClass('ui-state-default'); }
    	);
        // MENUS
        $('#india').menu({
            content: $('#india').next().html(),
            flyOut: true,
            width: 200
        });
        $('#overseas').menu({
            content: $('#overseas').next().html(),
            flyOut: true,
            width: 200
        });
        /*$('#india').menu({
        content: $('#india').next().html(),
        crumbDefaultText: ' ',
        width: 200,
        maxHeight: 250
        });
        $('#overseas').menu({
        content: $('#overseas').next().html(),
        crumbDefaultText: ' ',
        width: 200,
        maxHeight: 250
        });*/
    });
    </script>
<script>
    (function (i, s, o, g, r, a, m) {
        i['GoogleAnalyticsObject'] = r; i[r] = i[r] || function () {
            (i[r].q = i[r].q || []).push(arguments)
        }, i[r].l = 1 * new Date(); a = s.createElement(o),
  m = s.getElementsByTagName(o)[0]; a.async = 1; a.src = g; m.parentNode.insertBefore(a, m)
    })(window, document, 'script', '../www.google-analytics.com/analytics.js', 'ga');

    ga('create', 'UA-71248731-1', 'auto');
    ga('send', 'pageview');

</script>

<!-- Add mousewheel plugin (this is optional) -->
	<script type="text/javascript" src="../lib/jquery.mousewheel-3.0.6.pack.js"></script>

	<!-- Add fancyBox main JS and CSS files -->
	<script type="text/javascript" src="../source/jquery.fancybox.js?v=2.1.5"></script>
	<link rel="stylesheet" type="text/css" href="../source/jquery.fancybox.css?v=2.1.5" media="screen" />

	<!-- Add Button helper (this is optional) -->
	<link rel="stylesheet" type="text/css" href="../source/helpers/jquery.fancybox-buttons.css?v=1.0.5" />
	<script type="text/javascript" src="../source/helpers/jquery.fancybox-buttons.js?v=1.0.5"></script>

	<!-- Add Thumbnail helper (this is optional) -->
	<link rel="stylesheet" type="text/css" href="../source/helpers/jquery.fancybox-thumbs.css?v=1.0.7" />
	<script type="text/javascript" src="../source/helpers/jquery.fancybox-thumbs.js?v=1.0.7"></script>

	<!-- Add Media helper (this is optional) -->
	<script type="text/javascript" src="../source/helpers/jquery.fancybox-media.js?v=1.0.6"></script>

	<script type="text/javascript">
	    $(document).ready(function () {
	        /*
	        *  Simple image gallery. Uses default settings
	        */

	        $('.fancybox').fancybox();

	        /*
	        *  Different effects
	        */

	        // Change title type, overlay closing speed
	        $(".fancybox-effects-a").fancybox({
	            helpers: {
	                title: {
	                    type: 'outside'
	                },
	                overlay: {
	                    speedOut: 0
	                }
	            }
	        });

	        // Disable opening and closing animations, change title type
	        $(".fancybox-effects-b").fancybox({
	            openEffect: 'none',
	            closeEffect: 'none',

	            helpers: {
	                title: {
	                    type: 'over'
	                }
	            }
	        });

	        // Set custom style, close if clicked, change title type and overlay color
	        $(".fancybox-effects-c").fancybox({
	            wrapCSS: 'fancybox-custom',
	            closeClick: true,

	            openEffect: 'none',

	            helpers: {
	                title: {
	                    type: 'inside'
	                },
	                overlay: {
	                    css: {
	                        'background': 'rgba(238,238,238,0.85)'
	                    }
	                }
	            }
	        });

	        // Remove padding, set opening and closing animations, close if clicked and disable overlay
	        $(".fancybox-effects-d").fancybox({
	            padding: 0,

	            openEffect: 'elastic',
	            openSpeed: 150,

	            closeEffect: 'elastic',
	            closeSpeed: 150,

	            closeClick: true,

	            helpers: {
	                overlay: null
	            }
	        });

	        /*
	        *  Button helper. Disable animations, hide close button, change title type and content
	        */

	        $('.fancybox-buttons').fancybox({
	            openEffect: 'none',
	            closeEffect: 'none',

	            prevEffect: 'none',
	            nextEffect: 'none',

	            closeBtn: false,

	            helpers: {
	                title: {
	                    type: 'inside'
	                },
	                buttons: {}
	            },

	            afterLoad: function () {
	                this.title = 'Image ' + (this.index + 1) + ' of ' + this.group.length + (this.title ? ' - ' + this.title : '');
	            }
	        });


	        /*
	        *  Thumbnail helper. Disable animations, hide close button, arrows and slide to next gallery item if clicked
	        */

	        $('.fancybox-thumbs').fancybox({
	            prevEffect: 'none',
	            nextEffect: 'none',

	            closeBtn: false,
	            arrows: false,
	            nextClick: true,

	            helpers: {
	                thumbs: {
	                    width: 50,
	                    height: 50
	                }
	            }
	        });

	        /*
	        *  Media helper. Group items, disable animations, hide arrows, enable media and button helpers.
	        */
	        $('.fancybox-media')
				.attr('rel', 'media-gallery')
				.fancybox({
				    openEffect: 'none',
				    closeEffect: 'none',
				    prevEffect: 'none',
				    nextEffect: 'none',

				    arrows: false,
				    helpers: {
				        media: {},
				        buttons: {}
				    }
				});

	        /*
	        *  Open manually
	        */

	        $("#fancybox-manual-a").click(function () {
	            $.fancybox.open('1_b.jpg');
	        });

	        $("#fancybox-manual-b").click(function () {
	            $.fancybox.open({
	                href: 'iframe.html',
	                type: 'iframe',
	                padding: 5
	            });
	        });

	        $("#fancybox-manual-c").click(function () {
	            $.fancybox.open([
					{
					    href: '1_b.jpg',
					    title: 'My title'
					}, {
					    href: '2_b.jpg',
					    title: '2nd title'
					}, {
					    href: '3_b.jpg'
					}
				], {
				    helpers: {
				        thumbs: {
				            width: 75,
				            height: 50
				        }
				    }
				});
	        });


	    });
	</script>
	<style type="text/css">
		.fancybox-custom .fancybox-skin {
			box-shadow: 0 0 50px #222;
		}

		
	</style>
</head>
<body>
    <form id="form1" runat="server">
<header class="navbar-fixed-top navbar-default">

  <div class="container header-top">
  
    <div class="top-contact"> CALL US AT +91 7570003313 </div>
<!-- 	<input type="image" height="25px"  src="images/searchimg.png" style="float:right;margin-top:8px;"/>
					<input type="text"  placeholder="search" style="margin-top:8px;float:right; width:125px;"> -->
     <div class="socila-link socila-link1" style="margin-right:12px; margin-bottom:5px;"><a href="https://www.facebook.com/" target="_blank"><i class="social-f fa fa-facebook fa-set_myProperties fa-commonprop"></i></a> <a href="https://twitter.com/" target="_blank"><i class="social-t fa fa-twitter fa-set_myProperties fa-commonprop"></i></a> <a href="https://www.youtube.com/" target="_blank"><i class="social-y fa fa-youtube-play fa-set_myProperties fa-commonprop"></i></a> </div>
	
  </div>
  
  <div class="clearfix"></div>
   <div class="top-menu">
    <nav class="navbar navbar-inverse">
      <div class="container">
        <div class="navbar-header">
          <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1"> <span class="sr-only">Toggle navigation</span> <span class="icon-bar"></span> <span class="icon-bar"></span> <span class="icon-bar"></span> </button>
<a href="../Default.aspx"><img src="../images/logo.png" height="90px" width="130px" style="margin-left:10px; margin-top:-50px"  title="SANJEEVANI EDUCATION"></a></h1>
        </div>
        <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
          <ul class="nav navbar-nav navbar-right custom-menu" style="margin-right:0px;">
          <li><a href="../Default.aspx" class="dropdown-toggle" title="HOME"><strong><IMG src="../faculty/home_logo.png"> </strong><span class="caret"></span></a>
            
            <li class="dropdown"><a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-expanded="false" title="About Us"><strong>About Us </strong><span class="caret"></span></a>
              <ul class="dropdown-menu">
                <li><a href="#" style="font-size:12px;"><strong>History</strong></a></li>
				<li><a href="#" style="font-size:12px;"><strong>Team</strong></a></li>
				
                <li><a href="#" style="font-size:12px;"><strong>Gallery</strong></a></li>
                  <li><a href="#" title="Our Network"><strong>KNOW YOUR TEACHER</strong></a></li>
              </ul>
            </li>
            <li><a href="#" title="Our Network"><strong>EVENTS</strong></a></li>
          
            <li class="dropdown"><a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false" title="BRANCH"><strong>BRANCHE ON MAP</strong><span class="caret"></span></a>
             <!-- <ul class="dropdown-menu">
                <li><a href="#" style="font-size:12px;"><strong>Orthodontics</strong></a></li>
                <li><a href="#" style="font-size:12px;"><strong>Prosthodontics</strong></a></li>
                <li><a href="#" style="font-size:12px;"><strong>Oral Surgury</strong></a></li>
                </ul>-->
            </li>
            <%--<li><a href="#" title="Academics"><strong>STUDENT PROGRAMME</strong></a></li>
           --%> <li><a href="#" title="Academics"><strong>INTERNATIONAL FACULTY</strong></a></li>
            <li><a href="#" title="Careers"><strong>FAQ</strong></a></li>
            <li><a href="#" title="Contact Us"><strong>Contact Us</strong></a></li>
			<li>
          </ul>
        </div>		
      </div>
	  
    </nav>
  </div>
</header>
    <div class="branch_main agarwal-wrapper">
		  <div class="container">
              <h1 class="gl_head1">&nbsp;DISTRACTION  VIDEO SECTION</h1>
           
           <A href="../Distraction.aspx"><img src="../images/Kampanj2014.png" style="width: 25px; height: 25px">Back for other section</a>
		 <div>
              &nbsp;  &nbsp;  &nbsp;  &nbsp;  &nbsp;  &nbsp;  &nbsp;  &nbsp; 
             
             <table style="width: 100%;">
        <tr>
            <td width="850px" class="style1">
             <div>
    </div>
       <asp:DataList ID="DataList1" Visible="true" runat="server" AutoGenerateColumns="false"
        RepeatColumns="3" CellSpacing="5" BorderStyle="Inset" Width="950px">
        <ItemTemplate>
            <u>
                <%# Eval("Video_Name") %></u>
            <hr />
<%--            <a class="player" style="height: 300px; width: 300px; display: block" href='<%# Eval("ID", "VideoHandler.ashx?ID={0}") %>'>
--%>           
<video width="320" height="240" controls="controls"> 
            <source src='<%# Eval("ID", "VideoHandler.ashx?ID={0}") %>' type="video/mp4"> <object data="" width="320" height="240"> 
            <embed width="320" height="240" src='<%# Eval("ID", "VideoHandler.ashx?ID={0}") %>'> 
            </object> 
            </video> </a>
        </ItemTemplate>
    </asp:DataList>
    <script src="FlowPlayer/flowplayer-3.2.12.min.js" type="text/javascript"></script>
    <script type="text/javascript">
        flowplayer("a.player", "FlowPlayer/flowplayer-3.2.16.swf", {
            plugins: {
                pseudo: { url: "FlowPlayer/flowplayer.pseudostreaming-3.2.12.swf" }
            },
            clip: { provider: 'pseudo', autoPlay: false},
        });
    </script></td>
       
             </tr>
       
      
             <tr>
       
            <td>
                 <br/><br/><br/><br/><br/><br/><br/><br/> <br/><br/><br/><br/><br/><br/><br/><br/>  <div class="hm-bner-bttn">
    <div class="container">
      <div class="col-md-3 col-sm-6 hm-bner"><a href="../Stu_Sect.aspx" >
        <button>
        <div class="col-xs-4 col-sm-4 col-md-4 col-lg-4"> 
          <!--<i class="eye-icon"></i>--> 
          <img src="../images/icon_testimonial.png" class="img-responsive"> </div>
        <div class="col-xs-8 col-sm-8 col-md-8 col-lg-8 removePaddingLeft"> <b class="hm-bner-bttn-caption">
         <p class="hm-info-headline">STUDENT SECTION</p>
          <p class="hm-info">Read how every success story inspires us to do better</p>
          </b> </div>
        <span>+</span></button></a></div>
       <div class="col-md-3 col-sm-6 hm-bner"><a href="../implement_ssection.aspx" >
        <button>
        <div class="col-xs-4 col-sm-4 col-md-4 col-lg-4"> 
          <!--<i class="eye-icon"></i>--> 
          <img src="../images/icon_testimonial.png" class="img-responsive"> </div>
        <div class="col-xs-8 col-sm-8 col-md-8 col-lg-8 removePaddingLeft"> <b class="hm-bner-bttn-caption">
         <p class="hm-info-headline">IMPLANT SECTION </p>
          <p class="hm-info">Read how every success story inspires us to do better</p>
          </b> </div>
        <span>+</span></button></a></div> 
        <div class="col-md-3 col-sm-6 hm-bner"> <span class="parent-div-ql"><a href="../Super_Specialty.aspx" >
        <button class="parent-btn-ql btnclickpopup" >
        <div class="col-xs-4 col-sm-4 col-md-4 col-lg-4 btnclickpopup"> 
          <!--<i class="eye-icon"></i>--> 
          <img class="appint-icon btnclickpopup img-responsive" src="../images/icon_findHospital.png"> </div>
        <div class="col-xs-8 col-sm-8 col-md-8 col-lg-8 removePaddingLeft btnclickpopup"> <b class="hm-bner-bttn-caption btnclickpopup">
          <p class="hm-info-headline btnclickpopup">SUPER SPECIALITY</p>
          <p class="hm-info btnclickpopup">MAXILLO FACIAL SURGERY SECTION</p>
          </b> </div>
        <span class="sideNav_plus-ql btnclickpopup">+</span><span class="sideNav_minus-ql btnclickpopup">-</span> </button></a>
        
        </span> </div>
      <div class="col-md-3 col-sm-6 hm-bner"> <a href="../OTHER_DENTAL.aspx" >
        <button>
        <div class="col-xs-4 col-sm-4 col-md-4 col-lg-4"> 
          <!--<i class="eye-icon"></i>--> 
		  
          <img src="../images/icon_InternationalPatients.png" class="img-responsive"> </div>
        <div class="col-xs-8 col-sm-8 col-md-8 col-lg-8 removePaddingLeft"> <b class="hm-bner-bttn-caption">
          <p class="hm-info-headline">OTHER DENTAL</p>
          <p class="hm-info">SPECIALITY SECTION</p>
          </b> </div>
        <span>+</span></button></a>
        </a> </div>
       
    </div>
  </div>
</div>

</div>
            
       
             </tr>
       
    </table>
   
              </div>
            </div>
	     
         
   
         </div>
	
   </div>
   <div class="col-md-6 col-sm-6 col-xs-12 agarwal_over_branches">	 
	<div class="donate_form">
             </div>
            </div>
   </div>
   </div>
  

				<div style="min-height:200px; line-height: 100px; text-align: center; font-size: 15px; font-family: Georgia, "Times New Roman", serif; font-weight: bold;">
					<p>Please Select a Section above to get information</p>
				</div>
				
			
		</div>
		
    </div>
    <!--?php include(INC . "sidebar.php"); ?-->
  </div>
   </div>

   
 
<section>

 <div class="row">                
            </div>
            </div>
                              
      </div>
          </div>
</section>  <br/><br/>
      <div class="col-md-12 footer-link">
        <ul>
          <li class="col-md-2 col-sm-4 col-xs-12 li_set_vr">
            <ul>
			
             
              <li><a href="#">Our Team</a></li>
              <li><a href="#">Gallery</a></li>
			  <li><a href="#">Awards & Honour</a></li>
              <li><a href="#">Testimonials</a></li>
            </ul>
          </li>

          <li class="col-md-2 col-sm-4 col-xs-12 li_set_vr">
            <ul>
              <li><a href="#">Condition's Treatment</a></li>
              <li class="text-lightcolor margin-10-lr"><a href="#"> - Other types 1 </a></li>
              <li class="text-lightcolor margin-10-lr"><a href="#"> - Other types 2</a></li>
              
              <li class="text-lightcolor margin-10-lr"><a href="#"> - Other types 3 </a></li>
             
            </ul>
          </li>
          <li class="col-md-2 col-sm-4 col-xs-12 li_set_vr">
            <ul>
              <li><a href="#">Our Network</a></li>
              <li><a href="#" target="_blank">Camp for health care </a></li>
			  <li><a href="#" target="_blank">Social services</a></li>
             
            </ul>
          </li>
          <li class="col-md-2 col-sm-4 col-xs-12 ">
            <ul>
              <li><a href="#">Careers</a></li>
              <li><a href="#">Books & Study Materials</a></li>
              
              <li><a href="#">Contact Us</a></li>
            </ul>
          </li>
           <li class="col-md-2 col-sm-4 col-xs-12 ">
            <ul>
              <li><a href="#">Careers</a></li>
              <li><a href="#">Books & Study Materials</a></li>
              
              <li><a href="#">Contact Us</a></li>
            </ul>
          </li>
           <li class="col-md-2 col-sm-4 col-xs-12 ">
            <ul>
              <li><a href="#">Careers</a></li>
              <li><a href="#">Books & Study Materials</a></li>
              
              <li><a href="#">Contact Us</a></li>
            </ul>
          </li>
        </ul>
      </div>
   </div>
  

  
<br><br>
  <div class="clearfix"></div>
  <div class="copyright">&copy; Copyright 2015. @ SANJEEVANI EDUCATION. All rights reserved. </div>
</footer>

<!-- script -->
<link href="css/bootstrap-select.css" rel="stylesheet">
<script src="js/bootstrap.js"></script> 
<script src="js/bootstrap-select.js"></script> 
<script src="js/agarwal.js"></script> 
<script>
    //fixed menu on scroll
    var stickyOffset = $('.top-menu').offset().top;

    $(window).scroll(function () {
        var sticky = $('.top-menu'),
            scroll = $(window).scrollTop();

        if (scroll >= stickyOffset) sticky.addClass('fixed-menu');
        else sticky.removeClass('fixed-menu');
    });
    </script> 
    
    </form>
    
</body>


</html>

