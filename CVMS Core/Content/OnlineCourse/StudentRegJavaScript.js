//$(document).ready(function () {
//    // Add a click event listener to the "Save" button
//    alert('!!!!Welcome!!!!');

//});
//debugger
//$("#submit").click(function (event) {
//    event.preventDefault();
//    debugger;
//    var Fullname = $("#Fullname").val();
//    var Email = $("#Email").val();
//    var Dateofbirth = $("#Dateofbirth").val();
//    var Gender = $("#Gender").val();
//    var Subject = $("#Subject").val();
//    var Standard = $("#Standard").val();
//    var emailPattern = /^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$/; // Email Validation



//    //var firstThreeLetters = countryname.substring(0, 3).toUpperCase();

//    var isValid = true;

//    if (Fullname === '') {
//        $('#Fullname').addClass('border-danger');
//        isValid = false;
//    } else {
//        $('#Fullname').removeClass('border-danger');
//    }

//    if (!emailPattern.test(Email) || Email === '') {
//        $('#Email').addClass('border-danger');
//        isValid = false;
//    } else {
//        $('#Email').removeClass('border-danger');
//    }

//    if (Dateofbirth === '') {
//        $('#Dateofbirth').addClass('border-danger');
//        isValid = false;
//    } else {
//        $('#Dateofbirth').removeClass('border-danger');
//    }

//    if (Gender === '') {
//        $('#Gender').addClass('border-danger');
//        isValid = false;
//    } else {
//        $('#Gender').removeClass('border-danger');
//    }

//    if (Subject === '') {
//        $('#Subject').addClass('border-danger');
//        isValid = false;
//    } else {
//        $('#Subject').removeClass('border-danger');
//    }

//    if (Standard === '') {
//        $('#Standard').addClass('border-danger');
//        isValid = false;
//    } else {
//        $('#Standard').removeClass('border-danger');
//    }


//    debugger;


//    if (!isvalid) {
//        alert('form is not valid');
//        return isvalid;
//    }
//    // ------------------------------------------------------------------------------------


//     else {

//    debugger
//    var formData = new FormData();
//    formData.append('Fullname', Fullname);
//    formData.append('Email', Email);
//    formData.append('Dateofbirth', Dateofbirth);
//    formData.append('Gender', Gender);
//    formData.append('Subject', Subject);
//    formData.append('Standard', Standard);


//    debugger

//    $.ajax({
//        type: "POST",
//        url: "../Index/StudentReg",
//        data: formData,
//        contentType: false,
//        processData: false,
//        context: document.body,
//        success: function (data) {
//            debugger;
//            alert('Data has been stored in the database');
//            // getemployee();
//            window.location.reload();

//        },

// error: function (xhr, status, error) {
//            console.error(xhr.responseText);
//            alert('An error occurred while processing the request.');
//        }


//    })
//    }
//});
//=================================================================================================================================================


//$(document).ready(function () {
//    // Add a click event listener to the "Save" button
//    alert('!!!!Welcome!!!!');

//});
//debugger
//$("#submit").click(function (event) {
//    event.preventDefault();
//    debugger;
//    var Fullname = $("#Fullname").val();
//    var Email = $("#Email").val();
//    var Dateofbirth = $("#Dateofbirth").val();
//    var Gender = $("#Gender").val();
//    var Subject = $("#Subject").val();
//    var Standard = $("#Standard").val();
//    var emailPattern = /^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$/; // Email Validation



//    //var firstThreeLetters = countryname.substring(0, 3).toUpperCase();

//    var isValid = true;

//    if (Fullname == '') {
//        $('#Fullname').addClass('border-danger');
//        isValid = false;
//    } else {
//        $('#Fullname').removeClass('border-danger');
//    }

//    if (!emailPattern.test(Email) || Email == '') {
//        $('#Email').addClass('border-danger');
//        isValid = false;
//    } else {
//        $('#Email').removeClass('border-danger');
//    }

//    if (Dateofbirth == '') {
//        $('#Dateofbirth').addClass('border-danger');
//        isValid = false;
//    } else {
//        $('#Dateofbirth').removeClass('border-danger');
//    }

//    if (Gender == '') {
//        $('#Gender').addClass('border-danger');
//        isValid = false;
//    } else {
//        $('#Gender').removeClass('border-danger');
//    }

//    if (Subject == '') {
//        $('#Subject').addClass('border-danger');
//        isValid = false;
//    } else {
//        $('#Subject').removeClass('border-danger');
//    }

//    if (Standard == '') {
//        $('#Standard').addClass('border-danger');
//        isValid = false;
//    } else {
//        $('#Standard').removeClass('border-danger');
//    }


//    debugger;


//    if (!isvalid) {
//        alert('form is not valid');
//        return isvalid;
//    }
//    // ------------------------------------------------------------------------------------


//    else {

//        debugger
//        var formData = new FormData();
//        formData.append('Fullname', Fullname);
//        formData.append('Email', Email);
//        formData.append('Dateofbirth', Dateofbirth);
//        formData.append('Gender', Gender);
//        formData.append('Subject', Subject);
//        formData.append('Standard', Standard);


//        debugger

//        $.ajax({
//            type: "POST",
//            url: "../Index/StudentReg",
//            data: formData,
//            contentType: false,
//            processData: false,
//            context: document.body,
//            success: function (data) {
//                debugger;
//                alert('Data has been stored in the database');
//                // getemployee();
//                window.location.reload();

//            },

//            error: function (xhr, status, error) {
//                console.error(xhr.responseText);
//                alert('An error occurred while processing the request.');
//            }


//        })
//    }
//});
//============================================================================================================

$(document).ready(function () {
    // Add a click event listener to the "Save" button
    alert('!!!!Welcome!!!!');

});
debugger
$("#submit").click(function (event) {
    event.preventDefault();
    var Fullname = $("#Fullname").val();
    var Email = $("#Email").val();
    var Dateofbirth = $("#Dateofbirth").val();
    var Gender = $("#Gender").val();
    var Subject = $("#Subject").val();
    var Standard = $("#Standard").val();
    var emailPattern = /^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$/; // Email Validation

    var isValid = true;

    if (!/^[a-zA-Z\s]+$/.test(Fullname)) {
        $('#Fullname').addClass('border-danger');
        $('#errorMessage').text('Please enter a Full Name.').addClass('text-danger');
        isValid = false;
    } else {
        $('#Fullname').removeClass('border-danger');
        $('#errorMessage').text('').removeClass('text-danger');

    }


    if (!emailPattern.test(Email) || Email === '') {
        $('#Email').addClass('border-danger');
        $('#error').text('Please enter a valid Email id.').addClass('text-danger');

        isValid = false;
    } else {
        $('#Email').removeClass('border-danger');
        $('#error').text('').removeClass('text-danger');

    }

    if (Dateofbirth === '') {
        $('#Dateofbirth').addClass('border-danger');
        $('#errorr').text('Please enter Date of birth.').addClass('text-danger');
        isValid = false;
    } else {
        $('#Dateofbirth').removeClass('border-danger');
        $('#errore').text('').removeClass('text-danger');

    }

    if (Gender === '') {
        $('#Gender').addClass('border-danger');
        $('#errorrMessage').text('Please enter Gender .').addClass('text-danger');
        isValid = false;
    } else {
        $('#Gender').removeClass('border-danger');
        $('#errorrMessage').text('').removeClass('text-danger');
    }

    if (Subject === '') {
        $('#Subject').addClass('border-danger');
        $('#errorrMessagee').text('Please enter Subject.').addClass('text-danger');
        isValid = false;
    } else {
        $('#Subject').removeClass('border-danger');
        $('#errorrMessagee').text('').removeClass('text-danger');
    }

    if (Standard === '') {
        $('#Standard').addClass('border-danger');
        $('#errorrMesssage').text('Please enter Class.').addClass('text-danger');
        isValid = false;
    } else {
        $('#Standard').removeClass('border-danger');
        $('#errorrMesssage').text('').removeClass('text-danger');
    }

    if (!isValid) {
        alert('Form is not valid');
        return isValid;
    } else {
        var formData = new FormData();
        formData.append('Fullname', Fullname);
        formData.append('Email', Email);
        formData.append('Dateofbirth', Dateofbirth);
        formData.append('Gender', Gender);
        formData.append('Subject', Subject);
        formData.append('Standard', Standard);

        $.ajax({
            type: "POST",
            url: "../Index/StudentReg",
            data: formData,
            contentType: false,
            processData: false,
            context: document.body,
            success: function (data) {
                alert('Data has been stored in the database');
                window.location.reload();
            },
            error: function (xhr, status, error) {
                console.error(xhr.responseText);
                alert('An error occurred while processing the request.');
            }
        });
    }
});
