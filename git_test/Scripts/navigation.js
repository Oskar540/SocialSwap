$(window).scroll(function() {
                var scroll = $(window).scrollTop();
                if (scroll >= 100) {
                    $(".nav-script").fadeOut(300);
                    $(".aboutnav").addClass("active");
                    $(".home").removeClass("active");
                }
                else {
                    $(".home").addClass("active");
                    $(".aboutnav").removeClass("active");
                    $(".nav-script").fadeIn(400);

                }

                if (scroll >= 700) {
                    $(".sticky-nav-script").fadeIn(800);
                    $(".sticky-nav-script").addClass("navbar-fixed-top");
                    $(".sticky-nav-script").removeClass("unvisible");
                }   
                else {
                    $(".sticky-nav-script").fadeOut(200);
                } 
                    
                if (scroll >= 1800) {
                    $(".aboutnav").removeClass("active");
                    $(".services").addClass("active");
                }  
                else {
                    $(".services").removeClass("active");
                }   
                
                if (scroll >= 2400) {
                    $(".services").removeClass("active");
                    $(".statsnav").addClass("active");
                }
                  
                else {
                    $(".statsnav").removeClass("active");
                }
    
                if (scroll >= 2900) {
                    $(".statsnav").removeClass("active");
                    $(".teamnav").addClass("active");
                }
                  
                else {
                    $(".teamnav").removeClass("active");
                }
    
                if (scroll >= 3400) {
                    $(".teamnav").removeClass("active");
                    $(".contactnav").addClass("active");
                }
                  
                else {
                    $(".contactnav").removeClass("active");
                }
            });