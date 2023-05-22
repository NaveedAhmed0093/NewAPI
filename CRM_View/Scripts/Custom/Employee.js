$(document).ready(function () {

    GetAllEmployee();

});

function GetAllEmployee()
{
    $.ajax({
        type: "GET", 
        contentType: "application/json; charset=utf-8",
        url: 'https://localhost:44329/api/Employees/GetEmployee',
        data: "",
        contentType: "application/json",
        success: OSGetAllEmployee,
        cache: false
    });
}
function OSGetAllEmployee(data,status) {

    var json = jsonParse(data.Result);
    $.each(json, function (i, option) {

        $('#GetAllData tbody').append(
            '<tr>' +
            
            '<td style="text-align:left">' + option.FirstName + '</td>' +
            
            '</tr>'
        );
    });

}
