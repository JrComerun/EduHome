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
$(document).ready(function () {
    let searchInput;
    $(document).on('keyup', '#search-input-event', function () {

        searchInput = $(this).val().trim();
        $("#events-list #event-list").remove();
        $('#old-events-list').removeClass('d-none');
        if (searchInput.length > 0) {
            $('#old-events-list').addClass('d-none');
            $.ajax({
                url: "/Event/Search/",
                data: { "search": searchInput },
                type: "Get",
                success: function (res) {
                    $("#events-list").append(res);
                }

            });
        }
    })
    $(document).on('keyup', '#search-input-course', function () {

        searchInput = $(this).val().trim();
        $("#courses-list #course-list").remove();
        $('#old-courses-list').removeClass('d-none');
        if (searchInput.length > 0) {
            $('#old-courses-list').addClass('d-none');
            $.ajax({
                url: "/Course/Search/",
                data: { "search": searchInput },
                type: "Get",
                success: function (res) {
                    $("#courses-list").append(res);
                }

            });
        }
    })
    $(document).on('keyup', '#search-input-blog', function () {

        searchInput = $(this).val().trim();
        $("#blogs-list #blog-list").remove();
        $('#old-blogs-list').removeClass('d-none');
        $('.pagination').removeClass('d-none');
        if (searchInput.length > 0) {
            $('.pagination').addClass('d-none');
            $('#old-blogs-list').addClass('d-none');
            $.ajax({
                url: "/Blog/Search/",
                data: { "search": searchInput },
                type: "Get",
                success: function (res) {
                    console.log(res)
                    $("#blogs-list").append(res);
                }

            });
        }
    })
    $(document).on('keyup', '#search-input-teacher', function () {

        searchInput = $(this).val().trim();
        $("#teachers-list #teacher-list").remove();
        $('#old-teachers-list').removeClass('d-none');
        if (searchInput.length > 0) {
            $('#old-teachers-list').addClass('d-none');
            $.ajax({
                url: "/Teacher/Search/",
                data: { "search": searchInput },
                type: "Get",
                success: function (res) {
                    
                    $("#teachers-list").append(res);
                }

            });
        }
    })
    //let panigation;
    //$(document).on('click', '.pagination-jrc', function () {
    //    panigation = $(this).text();
    //    &
       
    //        $.ajax({
    //            url: "/Blog/Pagination/",
    //            data: { "page": panigation },
    //            type: "Get",
    //            success: function (res) {
    //                $("#old-blogs-list").empty()
    //                $("#old-blogs-list").append(res)
    //            }
    //        });   
    //})

})