(function ($) {
    "use strict";

    /*------------------------------------
        Sticky Menu 
    --------------------------------------*/
    var windows = $(window);
    var stick = $(".header-sticky");
    windows.on('scroll', function () {
        var scroll = windows.scrollTop();
        if (scroll < 5) {
            stick.removeClass("sticky");
        } else {
            stick.addClass("sticky");
        }
    });
    /*------------------------------------
        jQuery MeanMenu 
    --------------------------------------*/
    $('.main-menu nav').meanmenu({
        meanScreenWidth: "767",
        meanMenuContainer: '.mobile-menu'
    });


    /* last  2 li child add class */
    $('ul.menu>li').slice(-2).addClass('last-elements');
    /*------------------------------------
        Owl Carousel
    --------------------------------------*/
    $('.slider-owl').owlCarousel({
        loop: true,
        nav: true,
        animateOut: 'fadeOut',
        animateIn: 'fadeIn',
        smartSpeed: 2500,
        navText: ['<i class="fa fa-angle-left"></i>', '<i class="fa fa-angle-right"></i>'],
        responsive: {
            0: {
                items: 1
            },
            768: {
                items: 1
            },
            1000: {
                items: 1
            }
        }
    });

    $('.partner-owl').owlCarousel({
        loop: true,
        nav: true,
        navText: ['<i class="fa fa-angle-left"></i>', '<i class="fa fa-angle-right"></i>'],
        responsive: {
            0: {
                items: 1
            },
            768: {
                items: 3
            },
            1000: {
                items: 5
            }
        }
    });

    $('.testimonial-owl').owlCarousel({
        loop: true,
        nav: true,
        navText: ['<i class="fa fa-angle-left"></i>', '<i class="fa fa-angle-right"></i>'],
        responsive: {
            0: {
                items: 1
            },
            768: {
                items: 1
            },
            1000: {
                items: 1
            }
        }
    });
    /*------------------------------------
        Video Player
    --------------------------------------*/
    $('.video-popup').magnificPopup({
        type: 'iframe',
        mainClass: 'mfp-fade',
        removalDelay: 160,
        preloader: false,
        zoom: {
            enabled: true,
        }
    });

    $('.image-popup').magnificPopup({
        type: 'image',
        gallery: {
            enabled: true
        }
    });
    /*----------------------------
        Wow js active
    ------------------------------ */
    new WOW().init();
    /*------------------------------------
        Scrollup
    --------------------------------------*/
    $.scrollUp({
        scrollText: '<i class="fa fa-angle-up"></i>',
        easingType: 'linear',
        scrollSpeed: 900,
        animation: 'fade'
    });
    /*------------------------------------
        Nicescroll
    --------------------------------------*/
    $('body').scrollspy({
        target: '.navbar-collapse',
        offset: 95
    });
    $(".notice-left").niceScroll({
        cursorcolor: "#EC1C23",
        cursorborder: "0px solid #fff",
        autohidemode: false,

    });

})(jQuery);
//*************************
//   JrC Javascript
//*************************
//  Search Start
//*************************
$(document).ready(function () {
    let searchInput;
    function search( path , product) {
        $(document).on('keyup', `#search-input-${product}`, function () {

            searchInput = $(this).val().trim();

            $(`#${product}s-list #${product}-list`).remove();
            $(`#old-${product}s-list`).removeClass(`d-none`);
            $('.pagination').removeClass('d-none');
            if (searchInput.length > 0) {
                $(`#old-${product}s-list`).addClass('d-none');
                $('.pagination').addClass('d-none');
                $.ajax({
                    url: `${path}`,
                    data: { "search": searchInput },
                    type: "Get",
                    success: function (res) {
                        $(`#${product}s-list`).append(res);

                    }

                });
            }
        })
    }
    search("/Course/Search/", "course");
    search("/Event/Search/", "event");
    search("/Teacher/Search/", "teacher");
    search("/Blog/Search/", "blog");
    //*********************
    //  Global Search
    //*********************
    let GsearchInput;
    $(document).on('keyup', `#global-input`, function () {

        GsearchInput = $(this).val().trim();

        $(`#globals-list #global-list`).remove();
        if (GsearchInput.length > 0) {
            $.ajax({
                url: `/Home/GlobalSearch/`,
                data: { "search": GsearchInput },
                type: "Get",
                success: function (res) {
                    
                    $(`#globals-list`).append(res)
                   
                }

            });
        }
    })
    //*******************
    //Comments Start
    //******************
    let username;
    let email;
    let subject;
    let message;
    let product;
    function comment(path, str) {
        product = str;
        $(document).on('click', `.reply-btn-${product}`, function (e) {
            e.preventDefault();
            if (userAuthorized) {
                subject = $(`.subject-${product}`).val();
                message = $(`.message-${product}`).val();


                $.ajax({
                    url: `${path}`,
                    data: {
                        "username": "",
                        "email": "",
                        "subject": subject,
                        "message": message
                    },
                    type: "Post",
                    success: function (res) {
                        $(`#comment-list-${str}`).append(res)
                        //$(`.name-${product}`).val("");
                        //$(`.email-${product}`).val("");
                        $(`.subject-${product}`).val("");
                        $(`.message-${product}`).val("");
                    }
                });
            }
            else {
                username = $(`.name-${product}`).val();
                email = $(`.email-${product}`).val();
                subject = $(`.subject-${product}`).val();
                message = $(`.message-${product}`).val();


                $.ajax({
                    url: `${path}`,
                    data: {
                        "username": username,
                        "email": email,
                        "subject": subject,
                        "message": message
                    },
                    type: "Post",
                    success: function (res) {
                        $(`#comment-list-${str}`).append(res)
                        $(`.name-${product}`).val("");
                        $(`.email-${product}`).val("");
                        $(`.subject-${product}`).val("");
                        $(`.message-${product}`).val("");
                    }
                });
            }
           
            
            
               
            
        })
    }
    if ($("#reply-button").hasClass("reply-btn-course")) {
        comment("/Course/CourseComment/", "course");
    }
    if ($("#reply-button").hasClass("reply-btn-event")) {
        comment("/Event/EventComment/", "event");
    }
    if ($("#reply-button").hasClass("reply-btn-blog")) {
        comment("/Blog/BlogComment/", "blog");
    }
    
    
      //*******************
    //Comments End
    //******************
   

})