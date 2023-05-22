#pragma checksum "C:\Users\MettisDev4\source\repos\API_CRM\CRM_View\Views\Employee\Employees.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31a79374f6801697bf1836d97c3bb1272ebf5c39"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Employees), @"mvc.1.0.view", @"/Views/Employee/Employees.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\MettisDev4\source\repos\API_CRM\CRM_View\Views\_ViewImports.cshtml"
using CRM_View;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MettisDev4\source\repos\API_CRM\CRM_View\Views\_ViewImports.cshtml"
using CRM_View.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31a79374f6801697bf1836d97c3bb1272ebf5c39", @"/Views/Employee/Employees.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73ee5cfd69b6f989dbfcbb5ba2af8b0861f38f58", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Employees : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\MettisDev4\source\repos\API_CRM\CRM_View\Views\Employee\Employees.cshtml"
  
    ViewData["Title"] = "Employees";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"
<style>
    .alignLeft {
        text-align: left;
    }
</style>
<h1>Employees</h1>

<div class=""row"">
    <div class=""row col-md-12"">
        <div class=""col-md-6"">
            <label style=""font-size: large;font-weight: bold;"">First Name</label>
            <input id=""FirstName"" type=""text"" class=""form-control form-control-lg"" />
        </div>
        <div class=""col-md-6"">
            <label style=""font-size: large;font-weight: bold;"">Last Name</label>
            <input id=""LastName"" type=""text"" class=""form-control form-control-lg"" />
        </div>
    </div>
    <div class=""row col-md-12"">
        <div class=""col-md-6"">
            <label style=""font-size: large;font-weight: bold;"">Date Of Birth</label>
            <input id=""DateOfBirth"" type=""date"" class=""form-control form-control-lg"" />
        </div>
        <div class=""col-md-6"">
            <label style=""font-size: large;font-weight: bold;"">Email</label>
            <input id=""Email"" type=""email"" class=""form-control fo");
            WriteLiteral(@"rm-control-lg"" />
        </div>
    </div>
    <div class=""row col-md-12"">
        <div class=""col-md-12"">
            <label style=""font-size: large;font-weight: bold;"">Address</label>
            <textarea id=""Address"" class=""form-control form-control-lg""></textarea>
        </div>
    </div>
    <div class=""row col-md-12"">
        <div class=""col-md-6"">
            <label style=""font-size: large;font-weight: bold;"">Phone Number</label>
            <input id=""PhoneNumber"" type=""number"" class=""form-control form-control-lg"" />
        </div>
        <div class=""col-md-6"">
            <label style=""font-size: large;font-weight: bold;"">City</label>
            <input id=""City"" type=""text"" class=""form-control form-control-lg"" />
        </div>
    </div>
    <div class=""row col-md-12"">
        <div class=""col-md-6"">
            <label style=""font-size: large;font-weight: bold;"">Province</label>
            <input id=""Province"" type=""text"" class=""form-control form-control-lg"" />
        </");
            WriteLiteral(@"div>
        <div class=""col-md-6"">
            <label style=""font-size: large;font-weight: bold;"">Zip Code</label>
            <input id=""ZipCode"" type=""number"" class=""form-control form-control-lg"" />
        </div>
    </div>
    <div class=""row col-md-12"" style=""justify-content: right;"">
        <div class=""d-flex justify-content-end pt-3 "">
            <button type=""button"" id=""btnSave"" class=""btn btn-warning btn-lg ms-2"" onclick=""addEdit()"">Save</button>
            <button type=""reset"" id=""btnReset"" class=""btn btn-light btn-lg"" onclick=""Reset()"">Clear</button>
        </div>
    </div>
</div>
<div class=""table-responsive"">
    <table class=""table table-striped table-bordered"" id=""GetAllData"">
        <thead>
            <tr>
                <th>FirstName</th>
                <th>LastName</th>
                <th>DateOfBirth</th>
                <th>Email</th>
                <th>PhoneNumber</th>
                <th>Address</th>
                <th>City</th>
                <th>Pr");
            WriteLiteral("ovince</th>\r\n                <th>ZipCode</th>\r\n                <th>Actions</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n        </tbody>\r\n    </table>\r\n</div>\r\n");
            WriteLiteral(@"
<script>
    var employeeId = 0;
    $(document).ready(function () {

        GetAllEmployee();

    });

    function GetAllEmployee() {
        $.ajax({
            type: ""GET"",
            url: 'https://localhost:44377/api/Employee',
            contentType: ""application/json"",
            success: OSGetAllEmployee,
            cache: false
        });
    }
    function OSGetAllEmployee(data, status) {
        if (data.length <= 0) {
            return;
        }
        var json = JSON.parse(data);
        var html = """";

        $.each(json, function (i, option) {
            html += '<tr id=""' + option.EmployeeId + '"">';
            html += '<td class=""alignLeft fullName"">' + option.FullName + '</td>';
            html += '<td class=""alignLeft lastName"">' + option.LastName + '</td>';
            // html += '<td class=""alignLeft dob"">' + option.dateOfBirth + '</td>';
            html += '<td class=""alignLeft dob"">' + new Date(option.DateOfBirth).toLocaleDateString() + '</t");
            WriteLiteral(@"d>';
            html += '<td class=""alignLeft email"">' + option.Email + '</td>';
            html += '<td class=""alignLeft phoneNumber"">' + option.PhoneNumber + '</td>';
            html += '<td class=""alignLeft address"">' + option.Address + '</td>';
            html += '<td class=""alignLeft city"">' + option.City + '</td>';
            html += '<td class=""alignLeft province"">' + option.Province + '</td>';
            html += '<td class=""alignLeft zipCode"">' + option.ZipCode + '</td>';
            html += '<td class=""alignLeft""><button type=""button"" class=""btn btn-light btn-lg"" onclick=""FillFields(this)"">Edit</button><button type=""button"" class=""btn btn-light btn-lg"" onclick=""Delete(' + option.EmployeeId + ')"">Delete</button></td>';
            html += '</tr>';
        });
        $('#GetAllData tbody').empty();
        $('#GetAllData tbody').append(html);
        /*$('#GetAllData').DataTable();*/
    }
    function FillFields(btn) {


        $(""html, body"").animate({
            scrollTop:");
            WriteLiteral(@" 0
        }, 500);


        employeeId = $(btn).parents('tr').attr('id');
        var firstName = $(btn).parents('tr').find('.fullName').text();
        var lastName = $(btn).parents('tr').find('.lastName').text();
        var dob = $(btn).parents('tr').find('.dob').text();
        var email = $(btn).parents('tr').find('.email').text();
        var phoneNumber = $(btn).parents('tr').find('.phoneNumber').text();
        var address = $(btn).parents('tr').find('.address').text();
        var city = $(btn).parents('tr').find('.city').text();
        var province = $(btn).parents('tr').find('.province').text();
        var zipCode = $(btn).parents('tr').find('.zipCode').text();


        var fullDatestart = new Date(dob);
        var twoDigitMonthstart = (fullDatestart.getMonth() + 1) + """";
        if (twoDigitMonthstart.length == 1)
            twoDigitMonthstart = ""0"" + twoDigitMonthstart;

        var twoDigitDatestart = fullDatestart.getDate() + """";
        if (twoDigitDatestart.length");
            WriteLiteral(@" == 1)
            twoDigitDatestart = ""0"" + twoDigitDatestart;

        let DOBDate = fullDatestart.getFullYear() + ""-"" + twoDigitMonthstart + ""-"" + twoDigitDatestart;

        $('#btnSave').text('Edit');
        $('#FirstName').val(firstName);
        $('#LastName').val(lastName);
        $('#DateOfBirth').val(DOBDate);
        $('#Email').val(email);
        $('#PhoneNumber').val(phoneNumber);
        $('#Address').val(address);
        $('#City').val(city);
        $('#Province').val(province);
        $('#ZipCode').val(zipCode);
    }
    function Reset() {
        $('#FirstName').val('');
        $('#LastName').val('');
        $('#DateOfBirth').val('');
        $('#Email').val('');
        $('#PhoneNumber').val('');
        $('#Address').val('');
        $('#City').val('');
        $('#Province').val('');
        $('#ZipCode').val('');
        $('#btnSave').text('Save');
    }
    function addEdit() {
        if (!validateControls()) {
            return;
        }

   ");
            WriteLiteral(@"     var firstName = $('#FirstName').val();
        var lastName = $('#LastName').val();
        var dob = $('#DateOfBirth').val();
        var email = $('#Email').val();
        var phoneNumber = $('#PhoneNumber').val();
        var address = $('#Address').val();
        var city = $('#City').val();
        var province = $('#Province').val();
        var zipCode = $('#ZipCode').val();
        var mode = $('#btnSave').text();

        var data = {
            ""EmployeeId"": mode == ""Save"" ? 0 : parseInt(employeeId),
            ""FullName"": firstName,
            ""LastName"": lastName,
            ""DateOfBirth"": dob,
            ""Email"": email,
            ""PhoneNumber"": parseInt(phoneNumber),
            ""Address"": address,
            ""City"": city,
            ""Province"": province,
            ""ZipCode"": parseInt(zipCode)
        }

        var url = mode == ""Save"" ? 'https://localhost:44377/api/Employee' : 'https://localhost:44377/api/Employee/' + parseInt(employeeId);
        $.ajax");
            WriteLiteral(@"({
            type: mode == ""Save"" ? ""POST"" : ""PUT"",
            url: url,
            data: JSON.stringify(data),
            //data: JSON.parse(data),
            dataType: 'json',
            contentType: 'application/json',
            cache: false,
            success: function (response) {
                alert(""Data "" + mode + "" successfully"");
                GetAllEmployee();
                Reset();
            }
        });

    }
    function Delete(id) {
        $.ajax({
            type: ""DELETE"",
            url: 'https://localhost:44377/api/Employee/' + id,
            contentType: ""application/json"",
            cache: false,
            success: function (response) {
                alert(""Data deleted successfully"");
                GetAllEmployee();
                Reset();
            },
        });
    }
    function validateControls() {
        var errors = '';
        var isValidated = true;
        $('.spanError').remove();
        if ($('#FirstName')");
            WriteLiteral(@".val() == '') {
            $('#FirstName').after('<span class=""spanError text-danger"">FirstName is required</span>');
            //errors += ""FirstName is required <br/>"";
            isValidated = false;
        }
        if ($('#LastName').val() == '') {
            $('#LastName').after('<span class=""spanError text-danger"">LastName is required</span>');
            //errors += ""LastName is requied <br/>"";
            isValidated = false;
        }
        if ($('#DateOfBirth').val() == '') {
            $('#DateOfBirth').after('<span class=""spanError text-danger"">DateOfBirth is required</span>');
            //errors += ""Date Of Birth is requied <br/>"";
            isValidated = false;
        }
        if ($('#Email').val() == '') {
            $('#Email').after('<span class=""spanError text-danger"">Email is required</span>');
            //errors += ""Email is requied <br/>"";
            isValidated = false;
        }
        if ($('#Address').val() == '') {
            $('#Address').");
            WriteLiteral(@"after('<span class=""spanError text-danger"">Address is required</span>');
            //errors += ""Address is requied <br/>"";
            isValidated = false;
        }
        if ($('#PhoneNumber').val() == '') {
            $('#PhoneNumber').after('<span class=""spanError text-danger"">PhoneNumber is required</span>');
            //errors += ""Phone Number is requied <br/>"";
            isValidated = false;
        }
        if ($('#City').val() == '') {
            $('#City').after('<span class=""spanError text-danger"">City is required</span>');
            //errors += ""City is requied <br/>"";
            isValidated = false;
        }
        if ($('#Province').val() == '') {
            $('#Province').after('<span class=""spanError text-danger"">Province is required</span>');
            //errors += ""Province is requied <br/>"";
            isValidated = false;
        }
        if ($('#ZipCode').val() == '') {
            $('#ZipCode').after('<span class=""spanError text-danger"">ZipCode is r");
            WriteLiteral("equired</span>\');\r\n            //errors += \"Zip Code is requied <br/>\";\r\n            isValidated = false;\r\n        }\r\n        //$(\'#errors\').empty().html(errors);\r\n        return isValidated;\r\n\r\n    }\r\n\r\n</script>\r\n\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591