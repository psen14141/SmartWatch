#pragma checksum "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Users\Views\PatientProfile\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "acc907bd727d785bf65d74cf217dac9f22034bcd"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"acc907bd727d785bf65d74cf217dac9f22034bcd", @"/Areas/Users/Views/PatientProfile/Index.cshtml")]
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
<h1>Patients</h1>

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
            WriteLiteral("                <td>\r\n                    <a href=\"#\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3153, "\"", 3186, 3);
            WriteAttributeValue("", 3163, "AddorEdit(", 3163, 10, true);
#nullable restore
#line 96 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Users\Views\PatientProfile\Index.cshtml"
WriteAttributeValue("", 3173, item.UserId, 3173, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3185, ")", 3185, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Edit</a>\r\n                    ");
#nullable restore
#line 97 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Users\Views\PatientProfile\Index.cshtml"
               Write(Html.ActionLink("Delete", "Delete", new { id = item.UserId }, new { @class = "btn btn-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("                </td>\r\n            </tr>\r\n");
#nullable restore
#line 103 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Users\Views\PatientProfile\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<div id=\"AddorEdit\" class=\"modal\" tabindex=\"-1\" role=\"dialog\">\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 3782, "\"", 3790, 0);
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
        alert(""this is save"");
        let postData = new FormData();
        postData.append('UserId', $(""#UserId"").val());
        postData.append('RoleId', $(""#RoleId"").val());
        postData.append('ProfileId', $(""#ProfileId"").val());
        postData.append('Username', $(""#Username"").val());
        postData.append('Email', $(""#Email"").val());
        postData.append('Password', $(""#Password"").val());
        postData.append('CreateTime', $(""#CreateTime"").val());
        postData.append('Mobile', $(""#Mobile"").val());
        postData.append('UserSecret', $(""#UserSecret"").val());
        postData.append('UserDynamickey', $(""#UserDynamickey"").val());
        postData.append('FirstName', $(""#FirstName"").val());
        postData.append('LastName', $(""#LastName"").val());
        postData.appe");
            WriteLiteral(@"nd('Address', $(""#Address"").val());
        postData.append('City', $(""#City"").val());
        postData.append('PostalCode', $(""#PostalCode"").val());
        postData.append('CountryId', $(""#CountryId"").val());
        postData.append('CompanyId', $(""#CompanyId"").val());
        postData.append('Profilecol', $(""#Profilecol"").val());
        //alert(""save2"");

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
");
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