#pragma checksum "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Companies\Views\Company\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "742d99fa7172f82aeac9bac35b1515717c0d687e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Companies_Views_Company_Index), @"mvc.1.0.view", @"/Areas/Companies/Views/Company/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"742d99fa7172f82aeac9bac35b1515717c0d687e", @"/Areas/Companies/Views/Company/Index.cshtml")]
    public class Areas_Companies_Views_Company_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SmartWatch.Areas.Companies.Models.ViewModels.CompanyViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Companies\Views\Company\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script>
    $(document).ready(function () {
        $('#dtDesign').DataTable();
        $('.dataTables_length').addClass('bs-select');
    });
</script>
<p>

    <a class=""btn btn-primary mb-3"" href=""#"" onclick=""AddorEdit(0)"">Add Company</a>

</p>
<table id=""dtDesign"" class=""table table-striped table-bordered table-sm"" cellspacing=""0"" width=""100%"">
    <thead>
        <tr>
");
            WriteLiteral("            <th>\r\n                ");
#nullable restore
#line 26 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Companies\Views\Company\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Companies\Views\Company\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.RegNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Companies\Views\Company\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 35 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Companies\Views\Company\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Logo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Country \r\n            </th>\r\n");
            WriteLiteral("            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 53 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Companies\Views\Company\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n");
            WriteLiteral("                <td>\r\n                    ");
#nullable restore
#line 60 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Companies\Views\Company\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 63 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Companies\Views\Company\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.RegNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 66 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Companies\Views\Company\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 69 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Companies\Views\Company\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Logo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 72 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Companies\Views\Company\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Country1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n");
            WriteLiteral("                <td>\r\n                    <a href=\"#\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2731, "\"", 2767, 3);
            WriteAttributeValue("", 2741, "AddorEdit(", 2741, 10, true);
#nullable restore
#line 84 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Companies\Views\Company\Index.cshtml"
WriteAttributeValue("", 2751, item.CompanyId, 2751, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2766, ")", 2766, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Edit</a>\r\n\r\n\r\n                    <input type=\"button\" class=\"btn btn-danger\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2870, "\"", 2947, 3);
            WriteAttributeValue("", 2880, "DeleteConfirmation(\'/Companies/Company/Delete/?Id=", 2880, 50, true);
#nullable restore
#line 87 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Companies\Views\Company\Index.cshtml"
WriteAttributeValue("", 2930, item.CompanyId, 2930, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2945, "\')", 2945, 2, true);
            EndWriteAttribute();
            WriteLiteral(" value=\" Delete \" />\r\n\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 91 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Companies\Views\Company\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>

<div id=""AddorEdit"" class=""modal"" tabindex=""-1"" role=""dialog"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Company Information</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"" id=""formArea"">

            </div>
            <div class=""modal-footer"">
                <button type=""button"" onclick=""SaveCompany()"" class=""btn btn-primary"">Save changes</button>
                <button type=""button"" class=""btn btn-primary"" data-dismiss=""modal"">Close</button>
            </div>
        </div>
    </div>
</div>

<script>
    function AddorEdit(id) {
        $('#AddorEdit').modal(); //open the model
        $(""#formArea"").html(""""); // Clear existing are

        $.aj");
            WriteLiteral(@"ax({
            method: ""GET"",
            url: ""/Companies/Company/AddorEdit/"" + id,

        })
            .done(function (msg) {
                $(""#formArea"").html(msg);

            });
    }


    function SaveCompany() {

        let postData = new FormData();
        postData.append('CompanyId', $(""#CompanyId"").val());
        postData.append('Name', $(""#Name"").val());
        postData.append('RegNo', $(""#RegNo"").val());
        postData.append('Phone', $(""#Phone"").val());
        postData.append('Logo', $(""#Logo"").val());
        postData.append('CountryId', $(""#CountryId"").val());
        postData.append('CompanyBranchColor', $(""#CompanyBranchColor"").val());
        postData.append('CompanyForColor', $(""#CompanyForColor"").val());

        $.ajax({
            method: ""POST"",
            url: ""/Companies/Company/SaveCompany/"",
            data: postData,
            contentType: false,
            processData: false,
        }).done(function (data) {
            $('#A");
            WriteLiteral("ddorEdit\').modal(\'hide\')\r\n            location.reload();\r\n        });\r\n    }\r\n</script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SmartWatch.Areas.Companies.Models.ViewModels.CompanyViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
