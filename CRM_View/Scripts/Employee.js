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
            
            '<td style="text-align:left">' + option.fullName + '</td>' +
            '<td style="text-align:left">' + option.lastName + '</td>' +
            '<td style="text-align:left">' + option.dateOfBirth + '</td>' +
            '<td style="text-align:left">' + option.email + '</td>' +
            '<td style="text-align:left">' + option.phoneNumber + '</td>' +
            '<td style="text-align:left">' + option.address + '</td>' +
            '<td style="text-align:left">' + option.city + '</td>' +
            '<td style="text-align:left">' + option.province + '</td>' +
            '<td style="text-align:left">' + option.zipCode + '</td>' +
            
            '</tr>'
        );
    });

}
