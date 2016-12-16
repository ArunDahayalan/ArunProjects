//$(document).ready(function () {
    
//    var filter = /^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$/;
//    var numeric = /[0123456789]/;
//    var specialcharfilter = /[!$%^&*()_+|~=`{}\[\]:"#;'@<>?,.\/]/;
//    var phonefilter = /[!$%^&*_|~=`{}\[\]:";'<>?,\/]/;
//    $(".contactus-label").css("display", "none");

//    //contactus form submission
//    $("#booksubmit").click(function () {
//        $(".section").showWaitingPopUp();
//        var validatationError = false;
//        var name = $("#Name").val();
//        var author = $("#Author").val();
//        var language = $("#Language").val();
//        var number = $("#Number").val();
//        $(".form-control").css("border", "1px solid #a6a6a6");
//        $(".contactus-label").css("display", "none");
//        var headers = {};
//        token = $('input[name="__RequestVerificationToken"]').val();
//        headers["__RequestVerificationToken"] = token;
//        var hasNumber = /^\d+$/;
//        if (author == "" || author.trim().length < 1 || author == null) {
//            validatationError = true;
//            $("#contact-author ").css("border", "1px solid #a32626");
//            $("#validation-author").html("Please enter book author name");
//            $("#validation-author").css("display", "block");
//            $(".section").removeWaitingPopUp();
//        }

//        if (name == "" || name.trim().length < 1 || name == null) {
//            validatationError = true;
//            $("#contact-name").css("border", "1px solid #a32626");
//            $("#validation-name").html("Please enter your name");
//            $("#validation-name").css("display", "block");
//            $(".section").removeWaitingPopUp();
//        }

//        else (numeric.test(name) || specialcharfilter.test(name)) {
//            validatationError = true;
//            $("#contact-name").css("border", "1px solid #a32626");
//            $("#validation-name").css("display", "block");
//            $("#validation-name").html("Special characters and numbers are not allowed");
//            $(".section").removeWaitingPopUp();
//        }
//        if (language == "" || language.trim().length < 1 || language == null) {
//            validatationError = true;
//            $("#contact-language").css("border", "1px solid #a32626");
//            $("#validation-language").html("Please enter book language");
//            $("#validation-language").css("display", "block");
//            $(".section").removeWaitingPopUp();
//        }
//        if (number == "" || number.trim().length < 1 || number == null) {
//            validatationError = true;
//            $("#contact-phone").css("border", "1px solid #a32626");
//            $("#validation-phone").html("Please enter your book number");
//            $("#validation-phone").css("display", "block");
//            $(".section").removeWaitingPopUp();
//        }

//        else if ((/[a-zA-Z]/.test(number)) || (phonefilter.test(number))) {

//            validatationError = true;
//            $("#contact-phone").css("border", "1px solid #a32626");
//            $("#validation-phone").html("Please enter a valid book number");
//            $("#validation-phone").css("display", "block");
//            $(".section").removeWaitingPopUp();
//        }

//        var formDetails = { Name: name, Language: language, Number: number, Author: author};

//        if (!validatationError) {
//            $.ajax({
//                type: 'POST',
//                url: "/home/bookform/",
//                headers: headers,
//                data: formDetails,
//                cache: true,
//                success: function (result) {
//                    if (result.success) {
//                        $(".section").removeWaitingPopUp();
//                        $(".error-message").addClass("hide");
//                        $(".section").removeClass("hide");
//                    }
//                    else {
//                        $(".section").removeWaitingPopUp();
//                        $(".error-message").removeClass("hide");
//                        $(".section").addClass("hide");
//                    }
//                }
//            });
//        }
//    });
//})