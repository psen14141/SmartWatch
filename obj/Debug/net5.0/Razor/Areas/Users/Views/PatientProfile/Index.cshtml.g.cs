#pragma checksum "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Users\Views\PatientProfile\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a567b0bf4b707a88ee6732959b27856c2f8b9fdc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Users_Views_PatientProfile_Index), @"mvc.1.0.view", @"/Areas/Users/Views/PatientProfile/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a567b0bf4b707a88ee6732959b27856c2f8b9fdc", @"/Areas/Users/Views/PatientProfile/Index.cshtml")]
    public class Areas_Users_Views_PatientProfile_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SmartWatch.Areas.Users.Models.ViewModels.ProfileViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Users\Views\PatientProfile\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h5>Patients Registration</h5>

<script>
    $(document).ready(function () {
        $('#dtDesign').DataTable();
        $('.dataTables_length').addClass('bs-select');
    });
</script>
<p>

    <a class=""btn btn-primary mb-3"" href=""#"" onclick=""AddorEdit(0)"">Add New Patient</a>

</p>

<table id=""dtDesign"" class=""table table-striped table-bordered table-sm"" cellspacing=""0"" width=""100%"">
    <thead>
        <tr>
");
            WriteLiteral("            <th>\r\n                ");
#nullable restore
#line 29 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Users\Views\PatientProfile\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Users\Views\PatientProfile\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n");
            WriteLiteral("            <th>\r\n                ");
#nullable restore
#line 41 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Users\Views\PatientProfile\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Mobile));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n");
            WriteLiteral("            <th>\r\n                ");
#nullable restore
#line 50 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Users\Views\PatientProfile\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.RoleName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n");
            WriteLiteral("            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 62 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Users\Views\PatientProfile\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n");
            WriteLiteral("                <td>\r\n                    ");
#nullable restore
#line 69 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Users\Views\PatientProfile\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 72 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Users\Views\PatientProfile\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n");
            WriteLiteral("                <td>\r\n                    ");
#nullable restore
#line 81 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Users\Views\PatientProfile\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Mobile));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n");
            WriteLiteral("                <td>\r\n                    ");
#nullable restore
#line 90 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Users\Views\PatientProfile\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.RoleName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n");
            WriteLiteral("            <td>\r\n");
            WriteLiteral("                <a href=\"#\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3258, "\"", 3293, 3);
            WriteAttributeValue("", 3268, "EditPatient(", 3268, 12, true);
#nullable restore
#line 97 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Users\Views\PatientProfile\Index.cshtml"
WriteAttributeValue("", 3280, item.UserId, 3280, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3292, ")", 3292, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Edit</a>\r\n               \r\n");
            WriteLiteral("                <input type=\"button\" class=\"btn btn-danger\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3524, "\"", 3601, 3);
            WriteAttributeValue("", 3534, "DeleteConfirmation(\'/Users/PatientProfile/Delete/?Id=", 3534, 53, true);
#nullable restore
#line 100 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Users\Views\PatientProfile\Index.cshtml"
WriteAttributeValue("", 3587, item.UserId, 3587, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3599, "\')", 3599, 2, true);
            EndWriteAttribute();
            WriteLiteral(" value=\" Delete \" />\r\n");
            WriteLiteral("            </td>\r\n            </tr>\r\n");
#nullable restore
#line 106 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Users\Views\PatientProfile\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<div id=\"AddorEdit\" class=\"modal\" tabindex=\"-1\" role=\"dialog\">\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 4049, "\"", 4057, 0);
            EndWriteAttribute();
            WriteLiteral(@" modal-dialog-full-width modal-dialog momodel modal-fluid"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Patient Information</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"" id=""formArea"">

            </div>
            <div class=""modal-footer"">
                <button type=""button"" onclick=""SaveProfilePatient()"" class=""btn btn-primary"">Save changes</button>
                <button type=""button"" class=""btn btn-primary"" data-dismiss=""modal"">Close</button>
            </div>
        </div>
    </div>
</div>

<script>
    function AddorEdit(id) {
        $('#AddorEdit').modal(); //open the model
        $(""#formArea"").html(""""); // Clear existing are


        $.ajax({
            method: ""GET"",
            url: """);
            WriteLiteral(@"/Users/PatientProfile/AddorEdit/"" + id,

        })

            .done(function (msg) {
                $(""#formArea"").html(msg);

            });

    }


    function SaveProfilePatient() {
       
        let postData = new FormData();
        postData.append('UserId', $(""#UserId"").val());
        postData.append('RoleId', $(""#RoleId"").val());
        postData.append('ProfileId', $(""#ProfileId"").val());

        //if (!IsFilled(""Username"", ""Username"", ""Please fill the User name"")) {
        //    return;
        //}
        postData.append('Username', $(""#Username"").val());


        //if (!IsFilled(""Email"", ""Email"", ""Please fill the Email"")) {
        //    return;
        //}
        postData.append('Email', $(""#Email"").val());


        //if (!IsFilled(""Password"", ""Password"", ""Please fill the Password"")) {
        //    return;
        //}
        postData.append('Password', $(""#Password"").val());


        postData.append('CreateTime', $(""#CreateTime"").val());


");
            WriteLiteral(@"        //if (!IsFilled(""Mobile"", ""Mobile"", ""Please fill the Mobile"")) {
        //    return;
        //}
        postData.append('Mobile', $(""#Mobile"").val());


        //if (!IsFilled(""UserSecret"", ""UserSecret"", ""Please fill the UserSecret"")) {
        //    return;
        //}
        postData.append('UserSecret', $(""#UserSecret"").val());


        //if (!IsFilled(""UserDynamickey"", ""UserDynamickey"", ""Please fill the UserDynamickey"")) {
        //    return;
        //}
        postData.append('UserDynamickey', $(""#UserDynamickey"").val());


        //if (!IsFilled(""FirstName"", ""FirstName"", ""Please fill the FirstName"")) {
        //    return;
        //}
        postData.append('FirstName', $(""#FirstName"").val());


        //if (!IsFilled(""LastName"", ""LastName"", ""Please fill the LastName"")) {
        //    return;
        //}
        postData.append('LastName', $(""#LastName"").val());


        //if (!IsFilled(""Address"", ""Address"", ""Please fill the Address"")) {
        //  ");
            WriteLiteral(@"  return;
        //}
        postData.append('Address', $(""#Address"").val());


        //if (!IsFilled(""City"", ""City"", ""Please fill the City"")) {
        //    return;
        //}
        postData.append('City', $(""#City"").val());


        //if (!IsFilled(""PostalCode"", ""PostalCode"", ""Please fill the PostalCode"")) {
        //    return;
        //}
        postData.append('PostalCode', $(""#PostalCode"").val());


        //if (!IsFilled(""CountryId"", ""CountryId"", ""Please fill the CountryName"")) {
        //    return;
        //}
        postData.append('CountryId', $(""#CountryId"").val());


        //if (!IsFilled(""CompanyId"", ""CompanyId"", ""Please fill the CompanyName"")) {
        //    return;
        //}
        postData.append('CompanyId', $(""#CompanyId"").val());


        //if (!IsFilled(""Profilecol"", ""Profilecol"", ""Please fill the Profilecol"")) {
        //    return;
        //}
        postData.append('Profilecol', $(""#Profilecol"").val());
        //alert(""save2"");
");
            WriteLiteral(@"
        $.ajax({
            method: ""POST"",
            url: ""/Users/PatientProfile/SaveProfilePatient/"",
            data: postData,
            contentType: false,
            processData: false,
        }).done(function (data) {
            $('#AddorEdit').modal('hide')
            location.reload();
        });
    }
</script>

<div id=""EditPatient"" class=""modal"" tabindex=""-1"" role=""dialog"">
    <div");
            BeginWriteAttribute("class", " class=\"", 8577, "\"", 8585, 0);
            EndWriteAttribute();
            WriteLiteral(@" modal-dialog-full-width modal-dialog momodel modal-fluid"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Patient Information</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"" id=""formArea1"">

            </div>
            <div class=""modal-footer"">
                <button type=""button"" onclick=""EditSaveProfilePatient()"" class=""btn btn-primary"">Save changes</button>
                <button type=""button"" class=""btn btn-primary"" data-dismiss=""modal"">Close</button>
            </div>
        </div>
    </div>
</div>

<script>
    function EditPatient(id) {
        $('#EditPatient').modal(); //open the model
        $(""#formArea1"").html(""""); // Clear existing are


        $.ajax({
            method: ""GET"",
        ");
            WriteLiteral(@"    url: ""/Users/PatientProfile/EditPatient/"" + id,

        })

            .done(function (msg) {
                $(""#formArea1"").html(msg);

            });

    }



    function EditSaveProfilePatient() {

        let postData = new FormData();
        postData.append('UserId', $(""#UserId"").val());
        postData.append('RoleId', $(""#RoleId"").val());
        postData.append('ProfileId', $(""#ProfileId"").val());

        if (!IsFilled(""Username"", ""Username"", ""Please fill the User name"")) {
            return;
        }
        postData.append('Username', $(""#Username"").val());


        if (!IsFilled(""Email"", ""Email"", ""Please fill the Email"")) {
            return;
        }
        postData.append('Email', $(""#Email"").val());


        postData.append('CreateTime', $(""#CreateTime"").val());


        if (!IsFilled(""Mobile"", ""Mobile"", ""Please fill the Mobile"")) {
            return;
        }
        postData.append('Mobile', $(""#Mobile"").val());


        if (!IsF");
            WriteLiteral(@"illed(""UserSecret"", ""UserSecret"", ""Please fill the UserSecret"")) {
            return;
        }
        postData.append('UserSecret', $(""#UserSecret"").val());


        if (!IsFilled(""UserDynamickey"", ""UserDynamickey"", ""Please fill the UserDynamickey"")) {
            return;
        }
        postData.append('UserDynamickey', $(""#UserDynamickey"").val());


        if (!IsFilled(""FirstName"", ""FirstName"", ""Please fill the FirstName"")) {
            return;
        }
        postData.append('FirstName', $(""#FirstName"").val());


        if (!IsFilled(""LastName"", ""LastName"", ""Please fill the LastName"")) {
            return;
        }
        postData.append('LastName', $(""#LastName"").val());


        if (!IsFilled(""Address"", ""Address"", ""Please fill the Address"")) {
            return;
        }
        postData.append('Address', $(""#Address"").val());


        if (!IsFilled(""City"", ""City"", ""Please fill the City"")) {
            return;
        }
        postData.append('City', ");
            WriteLiteral(@"$(""#City"").val());


        if (!IsFilled(""PostalCode"", ""PostalCode"", ""Please fill the PostalCode"")) {
            return;
        }
        postData.append('PostalCode', $(""#PostalCode"").val());



        if (!IsFilled(""CountryId"", ""CountryId"", ""Please fill the CountryName"")) {
            return;
        }
        postData.append('CountryId', $(""#CountryId"").val());


        if (!IsFilled(""CompanyId"", ""CompanyId"", ""Please fill the CompanyName"")) {
            return;
        }
        postData.append('CompanyId', $(""#CompanyId"").val());


        if (!IsFilled(""Profilecol"", ""Profilecol"", ""Please fill the Profilecol"")) {
            return;
        }
        postData.append('Profilecol', $(""#Profilecol"").val());


        $.ajax({
            method: ""POST"",
            url: ""/Users/PatientProfile/EditSaveProfilePatient/"",
            data: postData,
            contentType: false,
            processData: false,
        }).done(function (data) {
            $('#formArea");
            WriteLiteral("1\').modal(\'hide\')\r\n            location.reload();\r\n        });\r\n    }\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SmartWatch.Areas.Users.Models.ViewModels.ProfileViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
