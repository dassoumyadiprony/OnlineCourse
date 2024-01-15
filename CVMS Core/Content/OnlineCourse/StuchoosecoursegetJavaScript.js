$(document).ready(function () {
    alert('!!!!Wellcome!!!!');
    //bindcompany();
    //bindvendor();
    //bindproject();
    //bindsite();
    //bindround();
    getchooscourse();

});
function getchooscourse() {
    debugger
    $.ajax({
        type: "GET",
        url: "/Index/getalldataaa",
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
                    "<button type='button' class='btn btn-success' data-id=''onclick='Coursechoose(" + value.id + ",event)'>Subscribe</button>" +

                    //" <button type='button' class='btn btn-sm btn-success' data-id=''onclick='Editaudit(" + value.id + ",event)'><i class='fa fa-pencil-square-o' aria-hidden='true'></i></button>" +
                    // "<button type='button' class='btn btn-sm btn-danger' data-id=''onclick='DeleteStudentRegss(" + value.id + ",event)'><i class='fa fa-trash' aria-hidden='true'></i></button>" +
                    "</td>";
                row += "</tr>";       // button delete.......

                rowcount += 1;
            });


            debugger
            $("#mtable").append(row);
           // mid = $("#hiddenId").val();   //append with tbody id........

        },
        error: function (error) {

            alert("Not Found");
        }
    });
    //-----------------------------------------------------------Choose Course Edit--------------------------------------------
};
    function Coursechoose(control, e) {
        debugger
        var Id = control;

        if (Id > 0) {
            $.ajax({
                type: "GET",
                url: "../Index/EditCourse/" + Id,
                dataType: "JSON",
                success: function (data) {
                    debugger
                   // $("#edit-master-toggle").modal('show');
                    $("#subjectid").val(data.company.subjectId);
                    $("#Subjectname").val(data.company.subjectName);
                    // $("#editstatenames").val(data.company.statename);
                    $("#Standard").val(data.company.standard);
                    $("#Teachername").val(data.company.teacherName);
                    $("#Time").val(data.company.time);
                    $("#Courseduration").val(data.company.courseDuration);
                    $("#Fees").val(data.company.fees);


                    $("#hiddenId").val(data.company.id);


                },
                error: function (xhr) {

                    debugger;
                    alert('Some error occured.');
                }
            });
        }
    };
    //-------------------------------------------------Edite Course Post------------------------------------------
////$(document).ready(function () {
//    // Add a click event listener to the "Save" button
//    //alert('!!!!Welcome!!!!');
//    //getemployee();
//    //bindcurrency();
//    //updatebindcurrency();
//    //bindregion();
//    //updatebindregion();
//});
debugger
$("#submit").click(function (event) {
    event.preventDefault();

    var subjectid = $("#subjectid").val();
    var Subjectname = $("#Subjectname").val();
    var Standard = $("#Standard").val();
    var Teachername = $("#Teachername").val();
    var Time = $("#Time").val();
    var Courseduration = $("#Courseduration").val();
    var Fees = $("#Fees").val();

    //var firstthreeletters = Subjectname.substring(0, 3).toUpperCase();

    var isValid = true;

    if (subjectid == '') {
        $('#subjectid').addClass('border-danger');
        isValid = false;
    } else {
        $('#subjectid').removeClass('border-danger');
    }

    if (!/^[a-zA-Z]+$/.test(Subjectname)) {
        $('#Subjectname').addClass('border-danger');
        isValid = false;
    } else {
        $('#Subjectname').removeClass('border-danger');
    }

    if (Standard == '') {
        $('#Standard').addClass('border-danger');
        isValid = false;
    } else {
        $('#Standard').removeClass('border-danger');
    }

    if (Teachername == '') {
        $('#Teachername').addClass('border-danger');
        isValid = false;
    } else {
        $('#Teachername').removeClass('border-danger');
    }

    if (Time == '') {
        $('#Time').addClass('border-danger');
        isValid = false;
    } else {
        $('#Time').removeClass('border-danger');
    }

    if (Courseduration == '') {
        $('#Courseduration').addClass('border-danger');
        isValid = false;
    } else {
        $('#Courseduration').removeClass('border-danger');
    }

    if (Fees == '') {
        $('#Fees').addClass('border-danger');
        isValid = false;
    } else {
        $('#Fees').removeClass('border-danger');
    }

    if (!isValid) {
        alert('Form is not valid');
        return;
    }

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
        url: '../Index/Editpost',
        data: formData,
        contentType: false,
        processData: false,
        success: function (data) {
            alert('Subscribe Successfully');
            window.location.reload();
        },
        error: function (xhr, textStatus, errorThrown) {
            console.error('Error:', errorThrown);
        }
    });
});

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
