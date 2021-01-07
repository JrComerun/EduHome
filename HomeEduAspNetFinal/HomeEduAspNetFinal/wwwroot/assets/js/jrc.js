//**************************************************************************
//                               JrC Javascript
//**************************************************************************
//          Course Event Teacher and Blog       Search Start 
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
    //**************************************************************************
    //          Course Event Teacher and Blog       Search End
    //**************************************************************************


    //************************************************
    //                Global Search  Start
    //************************************************
    let GsearchInput;
    $("#global-input").val("");
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
    //************************************************
    //                Global Search  End
    //************************************************





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
            else if (inputEmailSub == 0) {
                let subNullError = "Email can't be empty!!!"
                $("#subError").append(subNullError)
            }
            else {
                let subNullError = "Please write email!!!"
                $("#subError").append(subNullError)
            }

        }
    })
    //*********************************************************
    //                  Add Subscribe  End
    //*********************************************************




    //*********************************************************
    //         Email Validate ready function start
    //*********************************************************
    function ValidateEmail(email) {
        var mailformat = /^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$/;
                         
        if (email.match(mailformat)) {
            return true;
        }
        else {
            return false;
        }
    }
    //*********************************************************
    //         Email Validate ready function end
    //*********************************************************




    //*********************************************************
    //                Send Message to Me  Start
    //*********************************************************

    $(document).on('click', `#buttonCon`, function () {
        $(`#buttonCon`).prop("disabled", true);
        $("#ConEmailError").empty();
        $("#ConSubjectError").empty();
        $("#ConMessageError").empty();
        $("#ConNameError").empty();
        $("#Form-contact").empty();
        let inputMessageCon = $("#Message-contact").val();
        let inputSubjectCon = $("#Subject-contact").val();
        if (inputMessageCon == 0) {
            let conNullMessage = "Message can't be empty !!!";
            $("#ConMessageError").append(conNullMessage);
            $(`#buttonCon`).removeProp("disabled")
        }
        if (inputSubjectCon == 0) {
            let conNullSubject = "Subject can't be empty !!!";
            $("#ConSubjectError").append(conNullSubject);
            $(`#buttonCon`).removeProp("disabled")
        }
        if (userAuthorized) {

            $.ajax({
                url: `/Contact/MessageToMe/`,
                data: {
                    "Subject": inputSubjectCon,
                    "Message": inputMessageCon,
                },
                type: "Post",
                success: function (res) {
                    console.log(res)
                    $("#Form-contact").append(res);

                    $(`#buttonCon`).removeProp("disabled")

                    $("#Message-contact").val("");
                    $("#Subject-contact").val("");
                }
            });
        }
        else {
           
            let inputEmailCon = $("#Email-contact").val();
            let inputNameCon = $("#Name-contact").val();

            if (inputNameCon == 0) {
                let conNullName = "Name can't be empty !!!";
                $("#ConNameError").append(conNullName);
                $(`#buttonCon`).removeProp("disabled")
            }
            if (ValidateEmail(inputEmailCon) == true) {
                console.log("salam")
                $.ajax({
                    url: `/Contact/MessageToMe/`,
                    data: {
                        "Name": inputNameCon,
                        "Email": inputEmailCon,
                        "Subject": inputSubjectCon,
                        "Message": inputMessageCon,
                    },
                    type: "Post",
                    success: function (res) {
                        console.log(res)
                        $("#Form-contact").append(res);
                        $("#Message-contact").val("");
                        $("#Email-contact").val("");
                        $("#Name-contact").val("");
                        $("#Subject-contact").val("");
                        $(`#buttonCon`).removeProp("disabled")

                    }
                });

            } else {
                console.log("sdasda")
                let conNullError = "Please write Email !!!";
                $("#ConEmailError").append(conNullError);
                $(`#buttonCon`).removeProp("disabled")

            }
            //if (inputEmailCon == 0) {
            //    let conNullEmail = "Email can't be empty !!!";
            //    $("#ConEmailError").append(conNullEmail);
            //    $(`#buttonCon`).removeProp("disabled")
            //}



        }
    })

    //*********************************************************
    //                Send Message to Me  ENd
    //*********************************************************







})