//**************************************************************************
//                               JrC Javascript
//**************************************************************************
//                                Search Start
//**************************************************************************
$(document).ready(function () {
    let searchInput;
    function search(path, product) {
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
    //************************************************
    //                     Global Search
    //************************************************
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
    //**************************************************
    //                   Comments Start
    //**************************************************
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


    //************************************************************
    //                     Comments End
    //************************************************************
    //   if !User.Identity.IsAuthenticated     Add Subscribe
    //************************************************************
    $(document).on('click', `#buttonSub`, function () {
        $("#subError").empty();
        if (userAuthorized) {
           
            $.ajax({
                url: `/Contact/AddSubscribe/`,
                data: {
                    "Email": "kami@mail.ru",
                },
                type: "Post",
                success: function (res) {
                    $("#subError").append(res)
                }
            });
        }
        else {
            let inputEmailSub = $("#Email-jrc").val();
            if (ValidateEmail(inputEmailSub) == true) {
                $.ajax({
                    url: `/Contact/AddSubscribe/`,
                    data: {
                        "Email": inputEmailSub,
                    },
                    type: "Post",
                    success: function (res) {
                        console.log(res)
                        $("#subError").append(res)
                    }
                });
            }
            else if (inputEmailSub==0)
            {
                let subNullError="email is not null"  
                $("#subError").append(subNullError)
            }
            else
            {
                let subNullError = "Please write email!"
                $("#subError").append(subNullError)
            }
           
        }
    })
    function ValidateEmail(email) {
        var mailformat = /^[a-zA-Z0-9.!#$%&'+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:.[a-zA-Z0-9-]+)$/;
        if (email.match(mailformat)) {
            return true;
        }
        else {
            return false;
        }
    }










})