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
//    var Qualification = $("#Qualification").val();
//    var Time = $("#Time").val();
//    var emailPattern = /^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$/;//Email Validation


//    //var firstthreeletters = countryname.substring(0, 3).touppercase();

//    var isvalid = true;

//    if (!/^[a-za-z]+$/.test(Fullname)) {
//        $('#Fullname').addclass('border-danger');
//        isvalid = false;
//    } else {
//        $('#Fullname').removeclass('border-danger');
//    }

//    if (!emailPattern.test(Email) || (Email == '')) {
//        $('#Email').addClass('border-danger');
//        isValid = false;
//    }
//    else {
//        $('#emailid').removeClass('border-danger');
//    }


//    if (Dateofbirth == '') {
//        $('#Dateofbirth').addclass('border-danger');
//        isvalid = false;
//    } else {
//        $('#Dateofbirth').removeclass('border-danger');
//    }

//    if (Gender == '') {
//        $('#Gender').addclass('border-danger');
//        isvalid = false;
//    } else {
//        $('#Gender').removeclass('border-danger');
//    }

//    if (Subject == '') {
//        $('#Subject').addclass('border-danger');
//        isvalid = false;
//    } else {
//        $('#Subject').removeclass('border-danger');
//    }

//    if (Qualification == '') {
//        $('#Qualification').addclass('border-danger');
//        isvalid = false;
//    } else {
//        $('#Qualification').removeclass('border-danger');
//    }

//    if (Time == '') {
//        $('#Time').addclass('border-danger');
//        isvalid = false;
//    } else {
//        $('#Time').removeclass('border-danger');
//    }


//    debugger;


//    if (!isvalid) {
//        alert('form is not valid');
//        return isvalid;
//    }
//    // ------------------------------------------------------------------------------------



//   else {

//    debugger
//    var formData = new FormData();
//    formData.append('Fullname', Fullname);
//    formData.append('Email', Email);
//    formData.append('Dateofbirth', Dateofbirth);
//    formData.append('Gender', Gender);
//    formData.append('Subject', Subject);
//    formData.append('Qualification', Qualification);
//    formData.append('Time', Time);

//    debugger

//    $.ajax({
//        type: "POST",
//        url: "../Index/TeacherReg",
//        data: formData,
//        contentType: false,
//        processData: false,
//        context: document.body,
//        success: function (data) {
//            debugger;
//            alert('Data has been stored in the database');
//            // getemployee();
//            window.location.reload();

//        }




//    })
//    }
//});
//-------------------------------------------------------------------------------------------------------------------------------------------------
//=================================================================================================================================================


$(document).ready(function () {
    // Add a click event listener to the "Save" button
    alert('!!!!Welcome!!!!');
});

$("#submit").click(function (event) {
    event.preventDefault();
    var Fullname = $("#Fullname").val();
    var Email = $("#Email").val();
    var Dateofbirth = $("#Dateofbirth").val();
    var Gender = $("#Gender").val();
    var Subject = $("#Subject").val();
    var Qualification = $("#Qualification").val();
    var Time = $("#Time").val();
    var emailPattern = /^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$/; // Email Validation

    var isValid = true;

    if (!/^[a-zA-Z\s]+$/.test(Fullname)) {
        $('#Fullname').addClass('border-danger');
        $('#errorMessage').text('Please enter Full Name.').addClass('text-danger');
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
        $('#errorr').text('').removeClass('text-danger');
    }

    if (Gender === '') {
        $('#Gender').addClass('border-danger');
        $('#errorrMessage').text('Please enter Gender.').addClass('text-danger');
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

    if (Qualification === '') {
        $('#Qualification').addClass('border-danger');
        $('#errorrMessageeee').text('Please enter Qualification.').addClass('text-danger');
        isValid = false;
    } else {
        $('#Qualification').removeClass('border-danger');
        $('#errorrMessageeee').text('').removeClass('text-danger');
    }

    if (Time === '') {
        $('#Time').addClass('border-danger');
        $('#Messagee').text('Please enter Time.').addClass('text-danger');
        isValid = false;
    } else {
        $('#Time').removeClass('border-danger');
        $('#Messagee').text('').removeClass('text-danger');
    }

    if (!isValid) {
        alert('Form is not valid');
        return false;
    } else {
        var formData = new FormData();
        formData.append('Fullname', Fullname);
        formData.append('Email', Email);
        formData.append('Dateofbirth', Dateofbirth);
        formData.append('Gender', Gender);
        formData.append('Subject', Subject);
        formData.append('Qualification', Qualification);
        formData.append('Time', Time);

        $.ajax({
            type: "POST",
            url: "../Index/TeacherReg",
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
