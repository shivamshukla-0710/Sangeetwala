$(document).ready(function() {
 "use strict";
	//===============Mobile nav Function============
	$('#menu').on('click', function() {
		if ($(window).width() <= 991) {
			$('.navigation').slideToggle('normal');
		}
		return false;
	});
	$('.navigation>ul> li>a').on('click', function() {
		if ($(window).width() <= 991) {
			$('.navigation>ul> li').removeClass('on');
			$('.navigation>ul> li> ul').slideUp('normal');
			if ($(this).next().next('ul').is(':hidden') == true) {
				$(this).parent('li').addClass('on');
				$(this).next().next('ul').slideDown('normal');
			}
		}
		//return false;
	});

	//	Releted Project slider
	var relatedProject = $("#related-project");
	relatedProject.owlCarousel({
		loop : true,
		nav : true,
		dots : false,
		margin : 30,
		responsive : {
			0 : {
				items : 1
			},
			767 : {
				items : 2
			},
			992 : {
				items : 2
			},
			1200 : {
				items : 3
			}
		},
		navText : ["<i class='ion-ios-arrow-back'></i>", "<i class='ion-ios-arrow-forward'></i>"]

	});
	//	Blog slider
	var relatedProject = $("#blog-carousel");
	relatedProject.owlCarousel({
		loop : true,
		nav : true,
		dots : false,
		margin : 30,
		responsive : {
			0 : {
				items : 1
			},
			767 : {
				items : 1
			},
			992 : {
				items : 1
			},
			1200 : {
				items : 1
			}
		},
		navText : ["<i class='ion-ios-arrow-back'></i>", "<i class='ion-ios-arrow-forward'></i>"]

	});
	//	Testimonial
	var testimonial_2 = $('.testimonial-carousel');
	testimonial_2.owlCarousel({
		loop : true,
		margin : 10,
		nav : true,
		dots : true,
		center : true,
		navText : ["<i class='ion-ios-arrow-back'></i>", "<i class='ion-ios-arrow-forward'></i>"],
		responsive : {
			0 : {
				items : 1
			},
			767 : {
				items : 1
			},
			992 : {
				items : 1
			},
			1200 : {
				items : 1
			}
		}
	});
	if ($('.owl-testimonial').length) {
		$('.owl-testimonial').owlCarousel({
			loop : true,
			margin : 10,
			nav : true,
			dots : false,
			center : false,
			navText : ["<i class='ion-ios-arrow-back'></i>", "<i class='ion-ios-arrow-forward'></i>"],
			responsive : {
				0 : {
					items : 1
				},
				767 : {
					items : 1
				},
				992 : {
					items : 2
				},
				1200 : {
					items : 2
				}
			}
		});
	}
	if ($('.client-carousel').length) {
		$('.client-carousel').owlCarousel({
			loop : true,
			margin : 10,
			autoplay:true,
			 autoplayTimeout:1000,
    autoplayHoverPause:true,
			nav : false,
			dots : false,
			center : true,
			navText : ["<i class='ion-ios-arrow-back'></i>", "<i class='ion-ios-arrow-forward'></i>"],
			responsive : {
				0 : {
					items : 1
				},
				767 : {
					items : 3
				},
				992 : {
					items : 5
				},
				1200 : {
					items : 5
				}
			}
		});
	}
	
		if ($('.client-logos-owl').length) {
		$('.client-logos-owl').owlCarousel({
			loop : true,
			margin : 10,
			autoplay:true,
			 autoplayTimeout:1000,
    autoplayHoverPause:true,
			nav : false,
			dots : false,
			center : true,
			navText : ["<i class='ion-ios-arrow-back'></i>", "<i class='ion-ios-arrow-forward'></i>"],
			responsive : {
				0 : {
					items : 1
				},
				767 : {
					items : 3
				},
				992 : {
					items : 4
				},
				1200 : {
					items : 4
				}
			}
		});
	}
	if ($('.team-carousel').length) {
		$('.team-carousel').owlCarousel({
			loop : true,
			margin : 30,
			nav : true,
			dots : true,
			center : false,
			navText : ["<i class='icon-arrow-left'></i>", "<i class='icon-arrow-right'></i>"],
			responsive : {
				0 : {
					items : 1
				},
				767 : {
					items : 2
				},
				992 : {
					items : 3
				},
				1200 : {
					items : 4
				}
			}
		});
	}
	//	Releted Project slider
	var relatedProject = $("#choose-slider");
	relatedProject.owlCarousel({
		loop : true,
		nav : true,
		dots : false,
		margin : 30,
		responsive : {
			0 : {
				items : 1
			},
			767 : {
				items : 2
			},
			992 : {
				items : 2
			},
			1200 : {
				items : 3
			}
		},
		navText : ["<i class='ion-ios-arrow-back'></i>", "<i class='ion-ios-arrow-forward'></i>"]

	});
	
	$(window).scroll(function () {
            if ($(this).scrollTop() > 50) {
                $('#back-to-top').fadeIn();
            } else {
                $('#back-to-top').fadeOut();
            }
        });
        // scroll body to 0px on click
        $('#back-to-top').on('click',function () {
            $('#back-to-top').tooltip('hide');
            $('body,html').animate({
                scrollTop: 0
            }, 800);
            return false;
        });
        
       
	/*----------------------------------------------
	 -----------Counter Function  --------------------
	 -------------------------------------------------*/
	var counter = $('.counter');
	if (counter.length) {
		$('.counter').appear(function() {
			counter.each(function() {
				var e = $(this),
				    a = e.attr("data-count");
				$({
					countNum : e.text()
				}).animate({
					countNum : a
				}, {
					duration : 8e3,
					easing : "linear",
					step : function() {
						e.text(Math.floor(this.countNum));
					},
					complete : function() {
						e.text(this.countNum);
					}
				});
			});
		});
	}
	/*----------------------------------------------
	 ----------- parallax Function  --------------------
	 -------------------------------------------------*/

	var parallaxs = $(".parallax");
	parallaxs.parallax("50%", 0.02);

	/*----------------------------------------------
	 -----------Masonry Function  --------------------
	 -------------------------------------------------*/
	var container_masonry = $(".container-masonry");
	container_masonry.imagesLoaded(function() {
		container_masonry.isotope({
			itemSelector : '.nf-item',
			transitionDuration : '1s',
			percentPosition : true,
			masonry : {
				columnWidth : '.grid-sizer'
			}
		});
	});

	/*----------------------------------------------
	 -----------Masonry filter Function  --------------------
	 -------------------------------------------------*/
	var container_filter = $(".container-filter");
	container_filter.on("click", ".categories", function() {
		var a = $(this).attr("data-filter");
		container_masonry.isotope({
			filter : a
		});

	});
	/*----------------------------------------------
	 -----------Masonry filter Active Function  --------------------
	 -------------------------------------------------*/
	container_filter.each(function(e, a) {
		var i = $(a);
		i.on("click", ".categories", function() {
			i.find(".active").removeClass("active"), $(this).addClass("active");
		});
	});

	/*----------------------------------------------
	 -----------Masonry Grid view Function  --------------------
	 -------------------------------------------------*/
	var container_grid = $(".container-grid");
	container_grid.imagesLoaded(function() {
		container_grid.isotope({
			itemSelector : ".nf-item",
			layoutMode : "fitRows"
		});
	});

	/*----------------------------------------------
	 -----------Masonry Grid Filter Function  --------------------
	 -------------------------------------------------*/
	container_filter.on("click", ".categories", function() {
		var e = $(this).attr("data-filter");
		container_grid.isotope({
			filter : e
		});
	});

	/*----------------------------------------------
	 -----------Light Function  --------------------
	 -------------------------------------------------*/
	var fLight = $(".fancylight");
	if (fLight.length) {
		fLight.fancybox({
			openEffect : 'elastic',
			closeEffect : 'elastic',
			helpers : {
				media : {}
			}
		});
	}

	(function($) {
		"use strict";
		if ($("a[rel^='prettyPhoto'], a[data-rel^='prettyPhoto']").length != 0) {
			$("a[rel^='prettyPhoto'], a[data-rel^='prettyPhoto']").prettyPhoto({
				hook : 'data-rel',
				theme : "dark_square",
				social_tools : false,
				deeplinking : false
			});
		}
	})(jQuery);

	/* ---------------------
	 Owl Slider
	 /* --------------------- */
	"use strict";
	if ($('.owl-carousel').length) {
		$(".owl-carousel").each(function(index) {
			var effect_mode = $(this).data('effect');
			var autoplay = $(this).data('autoplay');
			var loop = $(this).data('loop');
			var margin = $(this).data('margin');
			var center = $(this).data('center');
			var autoplay = $(this).data('autoplay');
			var autoplayTimeout = $(this).data('autoplayTimeout');
			var autoplayHoverPause = $(this).data('autoplayHoverPause');
			var navigation = $(this).data('navigation');
			var prev_arrow = $(this).data('prev');
			var next_arrow = $(this).data('next');
			var pagination = $(this).data('pagination');
			var singleitem = $(this).data('singleitem');
			var items = $(this).data('items');
			var itemsdesktop = $(this).data('desktop');
			var itemsdesktopsmall = $(this).data('desktopsmall');
			var itemstablet = $(this).data('tablet');
			var itemsmobile = $(this).data('mobile');
			var nav22 = "namee";

			$(this).owlCarousel({
				loop : loop,
				margin : margin,
				center : center,
				nav : navigation,
				dots : pagination,
				autoplay : autoplay,
				autoplayTimeout : 2000,
				autoplayHoverPause : autoplayHoverPause,
				responsive : {
					0 : {
						items : itemsmobile
					},
					767 : {
						items : itemstablet
					},
					992 : {
						items : itemsdesktopsmall
					},
					1200 : {
						items : itemsdesktop
					}
				},

				navText : ["<i class='" + prev_arrow + "'></i>", "<i class='" + next_arrow + "'></i>"]
			});
		});
	}

	/*----------------------------------------------
	 ----------- Loader Function  --------------------
	 -------------------------------------------------*/
	var preloader = $("#preloader");
	preloader.delay(500).fadeOut();
	// End
});
