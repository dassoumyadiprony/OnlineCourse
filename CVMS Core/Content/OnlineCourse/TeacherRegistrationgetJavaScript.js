$(document).ready(function () {
    alert('!!!!Wellcome!!!!');
    //bindcompany();
    //bindvendor();
    //bindproject();
    //bindsite();
    //bindround();
    getTeacher();

});
function getTeacher() {
    debugger
    $.ajax({
        type: "GET",
        url: "/Index/getalldataa",
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
                row += "<td>" + value.fullname + "</td>";
                row += "<td>" + value.email + "</td>";
                row += "<td>" + value.dateofbirth + "</td>";
                row += "<td>" + value.gender + "</td>";
                row += "<td>" + value.subject + "</td>";
                row += "<td>" + value.qualification + "</td>";
                row += "<td>" + value.time + "</td>";



                // row += "<td>" + value.remarks + "</td>";
                row += "<td>" +
                    //" <button type='button' class='btn btn-sm btn-success' data-id=''onclick='Editaudit(" + value.id + ",event)'><i class='fa fa-pencil-square-o' aria-hidden='true'></i></button>" +
                    "<button type='button' class='btn btn-sm btn-danger' data-id=''onclick='DeleteTeacherRegss(" + value.id + ",event)'><i class='fa fa-trash' aria-hidden='true'></i></button>" +
                    "</td>";
                row += "</tr>";       // button delete.......

                rowcount += 1;
            });


            debugger
            $("#mtable").append(row);
            //mid = $("#hiddenId").val();   //append with tbody id........

        },
        error: function (error) {

            alert("Not Found");
        }
    });
}

//----------------------------------------------delete------------------------------------------------------



function DeleteTeacherRegss(control, e) {
    debugger
    // ClearSubmitForm()
    e.preventDefault();
    //Id = cid;

    var id = control;
    $.ajax({
        type: "POST",
        url: "../Index/DeleteTeacherRegs/" + id,
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
    //--------------------------------------------------Search Box---------------------------------------------------------------
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

