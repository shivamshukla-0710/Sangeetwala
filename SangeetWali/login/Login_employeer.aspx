<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login_employeer.aspx.cs" Inherits="login_Login_employeer" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
 <meta http-equiv="content-type" content="text/html; charset=utf-8" />
		<title>Deutsche Coin</title>
		<meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0" />
		<!--[if IE]>
		<meta http-equiv='X-UA-Compatible' content='IE=edge,chrome=1'>
		<![endif]-->
		<!-- Favicone Icon -->
		<link rel="shortcut icon" type="image/x-icon" href="favicon.ico">
		<!-- CSS -->
		<link href="https://fonts.googleapis.com/css?family=Raleway:300,400,700,800%7CLato:300,400,700" rel="stylesheet" type="text/css">
		<link href="assets/css/bootstrap.min.css" rel="stylesheet" type="text/css">
		<link href="assets/css/font-awesome.css" rel="stylesheet" type="text/css">
		<link href="assets/css/ionicons.css" rel="stylesheet" type="text/css">
		<!-- carousel -->
		<link href="assets/css/owl.carousel.css" rel="stylesheet" type="text/css">
		<!--Light box-->
		<link href="assets/css/jquery.fancybox.css" rel="stylesheet" type="text/css">
		<!-- Revolution Style-sheet -->
		<!--Main Slider-->
		<link href="assets/css/settings.css" type="text/css" rel="stylesheet" media="screen">
		<link href="assets/css/layers.css" type="text/css" rel="stylesheet" media="screen">
		<!--Main Style-->
		<link href="assets/css/style.css" rel="stylesheet" type="text/css">
</head>
<body background="../img/creative.JPG">
    <form id="form1" runat="server">
    <div id="preloader">
			<div class="sk-circle">
				<div class="sk-circle1 sk-child"></div>
				<div class="sk-circle2 sk-child"></div>
				<div class="sk-circle3 sk-child"></div>
				<div class="sk-circle4 sk-child"></div>
				<div class="sk-circle5 sk-child"></div>
				<div class="sk-circle6 sk-child"></div>
				<div class="sk-circle7 sk-child"></div>
				<div class="sk-circle8 sk-child"></div>
				<div class="sk-circle9 sk-child"></div>
				<div class="sk-circle10 sk-child"></div>
				<div class="sk-circle11 sk-child"></div>
				<div class="sk-circle12 sk-child"></div>
			</div>
		</div>
		<!--loader-->
		<!-- Site Wraper -->
		<div class="wrapper">
			<!-- HEADER -->
			<header class="header">
			<div class="top-head ptb-10">
				<div class="container">
					<div class="row">
						<div class="col-lg-6">
							<div class="fleg-top">
								<ul>
									<li><i class="fa fa-paper-plane" aria-hidden="true"></i> info@deutschedigicoin.com </li>
									<li class="offset-sm-1">
                                     
										<i class="fa fa-location-arrow" aria-hidden="true"></i><span>+31 (0)70 - 426 02 60</span>
									</li>
                                    <ul>
        
        
        </ul>


								</ul>
							</div>
						</div>

						<div class="col-lg-6 d-flex justify-content-end respo-mob">
							<div class="search">
								<a href="sign_up.aspx">Register From Here</a>
							</div>
							<div class="social-top">
								<ul>
									<li>
										<a href="#"><i class="fa fa-facebook" aria-hidden="true"></i></a>
									</li>
									<li>
										<a href="#"><i class="fa fa-twitter" aria-hidden="true"></i></a>
									</li>
									<li>
										<a href="#"><i class="fa fa-google-plus" aria-hidden="true"></i></a>
									</li>
									<li>
										<a href="#"><i class="fa fa-linkedin" aria-hidden="true"></i></a>
									</li>
									<li>
										<a href="#"><i class="fa fa-skype" aria-hidden="true"></i></a>
									</li>
								</ul>
							</div>
						</div>
					</div>
				</div>
			</div>

			 <div align="center">
      
        <img src="../images/logo/logo.png" />
      </div>
			

		</header>
			<!-- END HEADER -->
			<!--Intro Section-->
			
			<!--Intro Section-->
			<!-- Login Section -->
			<div id="login" class="ptb ptb-xs-60 page-signin">
				<div class="container">
					<div class="row">
						<div class="col-sm-12">
							<div class="main-body">
								<div class="body-inner">
									<div class="card bg-white">
										<div class="card-content">
											<section class="logo text-center">
												<h2>Login</h2>
											</section>
											<form class="form-horizontal ng-pristine ng-valid">
												<fieldset>
                                                <div class="form-group">
														<div class="ui-input-group">
															
                                                            <asp:DropDownList ID="DropDownList1" runat="server" required class="form-control" Font-Bold="True" ForeColor="Maroon">
                                                            <asp:ListItem>Selcet User Type...</asp:ListItem>
                                                            <asp:ListItem>Berojgar</asp:ListItem>
                                                            <asp:ListItem>Employer</asp:ListItem>
                                                            </asp:DropDownList>
															<span class="input-bar"></span>
															<%--<label>User Type</label>--%>
														</div>
													</div>
													<div class="form-group">
														<div class="ui-input-group">
															
                                                            <asp:TextBox  ID="TextBox1" runat="server" required class="form-control"></asp:TextBox>
															<span class="input-bar"></span>
															<label>Email</label>
														</div>
													</div>
													<div class="form-group">
														<div class="ui-input-group">
															 <asp:TextBox  ID="TextBox2" runat="server" required class="form-control"></asp:TextBox>
															<span class="input-bar"></span>
															<label>Password</label>
														</div>
													</div>
												</fieldset>
											</form>
										</div>
										<div class="card-action no-border text-right">
											
         <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/img/login-button (2).png" 
                                                onclick="ImageButton1_Click2" />
										</div>
									</div>
									<div class="additional-info">
										<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                                        <br/><a href="sign_up.aspx">Register</a><span class="divider-h"></span><a href="#/page/forgot-password">Forgot your password?</a>
									</div>
								</div>
							</div>
						</div>
					</div>
				</div>
			</div>
           

			<!-- End Login Section -->
			<!-- FOOTER -->
			<footer id="footer">
			<div id="footer-widgets" class="container style-1">
				<div class="row">
					<div class="col-md-3">
						<div class="widget widget_text">

							<div class="textwidget">
								
								<i class="fa fa-copyright" aria-hidden="true"></i>2017 @ by Deutsche Coin
							
							</div>
						</div>
					</div>
					<div class="col-md-3">
						<div class="widget widget_links">
							<h2 class="widget-title">Our <span>Service</span></h2>
							<ul class="wprt-links clearfix col2">
							

							</ul>
						</div>
					</div>
					<div class="col-md-3">
						<div class="widget widget_links">
							<h2 class="widget-title">Subscription<span> News</span></h2>
							<ul class="wprt-links clearfix col2">
								
							</ul>
						</div>
					</div>

					<div class="col-md-3">
						<div class="widget widget_information">
							

								<input type="email" class="newsletter-input input-md newsletter-input mb-0" placeholder="Your email here">
								<button class="newsletter-btn btn btn-xs btn-color" type="submit" value="">
									<i class="fa fa-paper-plane" aria-hidden="true"></i>
								</button>
							
						</div>
						
					</div>

				</div>
			</div>
			<div id="bottom" class="clearfix style-1">
				<div id="bottom-bar-inner" class="wprt-container">
					<div class="bottom-bar-inner-wrap">
						<div class="bottom-bar-content">
							
							<!-- /#copyright -->
						</div>

					</div>
				</div>
			</div>
		</footer>
			<!-- END FOOTER -->
		</div>
		<!-- Site Wraper End -->
		<script src="assets/js/jquery.min.js" type="text/javascript"></script>
		<!-- Easing Effect Js -->
		<script type="text/javascript" src="assets/js/tether.min.js"></script>
		<script src="assets/js/jquery.easing.js" type="text/javascript"></script>
		<!-- bootstrap Js -->
		<script src="assets/js/bootstrap.min.js" type="text/javascript"></script>
		<!-- carousel Js -->
		<script src="assets/js/owl.carousel.js" type="text/javascript"></script>
		<!-- imagesloaded Js -->
		<script src="assets/js/imagesloaded.pkgd.min.js" type="text/javascript"></script>
		<!-- masonry,isotope Effect Js -->
		<script src="assets/js/isotope.pkgd.min.js" type="text/javascript"></script>
		<script src="assets/js/masonry.pkgd.min.js" type="text/javascript"></script>
		<script src="assets/js/jquery.appear.js" type="text/javascript"></script>
		<!-- parallax Js -->
		<script src="assets/js/jquery.parallax-1.1.3.js" type="text/javascript"></script>
		<!-- custom Js -->
		<script src="assets/js/custom.js" type="text/javascript"></script>
    </form>
</body>
</html>
