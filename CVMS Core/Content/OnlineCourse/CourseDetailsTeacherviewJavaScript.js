$(document).ready(function () {
    alert('!!!!Wellcome!!!!');
    //bindcompany();
    //bindvendor();
    //bindproject();
    //bindsite();
    //bindround();
    getchooscoursee();

});
function getchooscoursee() {
    debugger
    $.ajax({
        type: "GET",
        url: "/Index/coursejoininn",
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
                    "<button type='button' class='btn btn-sm btn-danger' data-id=''onclick='DeleteStudentCoursedetailsTv(" + value.id + ",event)'><i class='fa fa-trash' aria-hidden='true'></i></button>" +
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
    //-----------------------------------Choose Course Details Teacher Views Delete-----------------------------------------------------

function DeleteStudentCoursedetailsTv(control, e) {
    debugger
    // ClearSubmitForm()
    e.preventDefault();
    //Id = cid;

    var id = control;
    $.ajax({
        type: "POST",
        url: "../Index/DeleteChooseCO/" + id,
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
