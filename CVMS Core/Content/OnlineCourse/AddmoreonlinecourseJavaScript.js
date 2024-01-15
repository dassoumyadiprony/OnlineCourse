$(document).ready(function () {
    // Add a click event listener to the "Save" button
    alert('!!!!Welcome!!!!');
    getchooscourse();
});

$("#submit").click(function (event) {
    event.preventDefault();
    var subjectid = $("#subjectid").val();
    var Subjectname = $("#Subjectname").val();
    var Standard = $("#Standard").val();
    var Teachername = $("#Teachername").val();
    var Time = $("#Time").val();
    var Courseduration = $("#Courseduration").val();
    var Fees = $("#Fees").val();
    var firstThreeLetters = Subjectname.substring(0, 3).toUpperCase();
    var isValid = true;

    // Validation for subjectid
    if ((subjectid.substring(0, 3) !== firstThreeLetters) || (subjectid === '')) {
        $('#subjectid').addClass('border-danger');
        $('#errorMessage').text('Please enter a valid subject id.').addClass('text-danger');
        isValid = false;
    } else {
        $('#subjectid').removeClass('border-danger');
        $('#errorMessage').text('').removeClass('text-danger');
    }



    // Validation for Subjectname
    if (!/^[a-zA-Z]+$/.test(Subjectname)) {
        $('#Subjectname').addClass('border-danger');
        $('#error').text('Please enter a valid subject name with only letters.').addClass('text-danger');
        isValid = false;
    } else {
        $('#Subjectname').removeClass('border-danger');
        $('#error').text('').removeClass('text-danger');
    }

    // Validation for Standard
    if (Standard === '') {
        $('#Standard').addClass('border-danger');
        $('#errorr').text('Please enter Class.').addClass('text-danger');
        isValid = false;
    } else {
        $('#Standard').removeClass('border-danger');
        $('#errorr').text('').removeClass('text-danger');
    }

    // Validation for Teachername
    if (!/^[a-zA-Z\s]+$/.test(Teachername)) {
        $('#Teachername').addClass('border-danger');
        $('#errorrMessage').text('Please enter Teacher Name.').addClass('text-danger');
        isValid = false;
    } else {
        $('#Teachername').removeClass('border-danger');
        $('#errorrMessage').text('').removeClass('text-danger');
    }

    // Validation for Time
    if (Time === '') {
        $('#Time').addClass('border-danger');
        $('#errorrMessagee').text('Please enter Time.').addClass('text-danger');
        isValid = false;
    } else {
        $('#Time').removeClass('border-danger');
        $('#errorrMessagee').text('').removeClass('text-danger');
    }

    // Validation for Courseduration
    if (Courseduration === '') {
        $('#Courseduration').addClass('border-danger');
        $('#errorrMessageeee').text('Please enter Courseduration.').addClass('text-danger');
        isValid = false;
    } else {
        $('#Courseduration').removeClass('border-danger');
        $('#errorrMessageeee').text('').removeClass('text-danger');
    }

    // Validation for Fees
    if (Fees === '' || !/^\d+$/.test(Fees)) {
        $('#Fees').addClass('border-danger');
        $('#Messagee').text('Please enter Fees.').addClass('text-danger');
        isValid = false;
    } else {
        $('#Fees').removeClass('border-danger');
        $('#Messagee').text('').removeClass('text-danger');
    }

    if (!isValid) {
        alert('Form is not valid');
        return false;
    } else {
        var formData = new FormData();
        formData.append('subjectid', subjectid);
        formData.append('Subjectname', Subjectname);
        formData.append('Standard', Standard);
        formData.append('Teachername', Teachername);
        formData.append('Time', Time);
        formData.append('Courseduration', Courseduration);
        formData.append('Fees', Fees);

        $.ajax({
            type: 'POST',
            url: '../Index/Addmoreadminn',
            data: formData,
            contentType: false,
            processData: false,
            context: document.body,
            success: function (data) {
                alert('Data has been stored in the database');
                window.location.reload();
            },
            error: function (error) {
                console.error('Error storing data in the database:', error);
            }
        });
    }
});

//-----------------------------------Get ADDMore----------------------------------------------------------------

function getchooscourse() {
    debugger
    $.ajax({
        type: "GET",
        url: "/Index/courseAddMore",
        data: {},
        dataType: "JSON",
        context: document.body,
        success: function (data) {

            var row = "";
            var rowcount = 1;
            $.each(data.gdta, function (item, value) {
                debugger
                row += "<tr>";
                row += "<td>" + rowcount + "</td>";
                row += "<td>" + value.subjectId + "</td>";
                row += "<td>" + value.subjectName + "</td>";
                row += "<td>" + value.standard + "</td>";
                row += "<td>" + value.teacherName + "</td>";
                row += "<td>" + value.time + "</td>";
                row += "<td>" + value.courseDuration + "</td>";
                row += "<td>" + value.fees + "</td>";



                // row += "<td>" + value.remarks + "</td>";
                row += "<td>" +
                    //"<button type='button' class='btn btn-success' data-id=''onclick='Coursechoose(" + value.id + ",event)'>Subscribe</button>" +

                    //" <button type='button' class='btn btn-sm btn-success' data-id=''onclick='Editaudit(" + value.id + ",event)'><i class='fa fa-pencil-square-o' aria-hidden='true'></i></button>" +
                    "<button type='button' class='btn btn-sm btn-danger' data-id=''onclick='DeleteAdminAddmore(" + value.id + ",event)'><i class='fa fa-trash' aria-hidden='true'></i></button>" +
                    "</td>";
                row += "</tr>";       // button delete.......

                rowcount += 1;
            });


            debugger
            $("#adddmoretable").append(row);
            // mid = $("#hiddenId").val();   //append with tbody id........

        },
        error: function (error) {

            alert("Not Found");
        }
    });
}
    //--------------------------------------------------Search Box----------------------------------------------
    $('#search').on('keyup', function () {
        var searchTerm = $(this).val().toLowerCase();
        $('#usertbl tbody tr').each(function () {
            var lineStr = $(this).text().toLowerCase();
            if (lineStr.indexOf(searchTerm) === -1) {
                $(this).hide();
            } else {
                $(this).show();
            }
        });
    });

//-----------------------------------------Admin Addmore Delete--------------------------------------------------
function DeleteAdminAddmore(control, e) {
    debugger
    // ClearSubmitForm()
    e.preventDefault();
    //Id = cid;

    var id = control;
    $.ajax({
        type: "POST",
        url: "../Index/DeleteChooseCourseAdmin/" + id,
        dataType: "JSON",
        contentType: "application/json; charset=utf-8",
        success: function (data) {
            debugger

            window.location.reload();
        },
        error: function (error) {

            debugger;
            alert('Some error occured.');
        }
    });
}