#pragma checksum "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Branches\Views\Branch\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5127df1c7acf8753d16d2eda05d75d63d812bada"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Branches_Views_Branch_Index), @"mvc.1.0.view", @"/Areas/Branches/Views/Branch/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5127df1c7acf8753d16d2eda05d75d63d812bada", @"/Areas/Branches/Views/Branch/Index.cshtml")]
    public class Areas_Branches_Views_Branch_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SmartWatch.Areas.Branches.Models.ViewModels.BranchViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Branches\Views\Branch\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h5>Branches</h5>

<script>
    $(document).ready(function () {
        $('#dtDesign').DataTable();
        $('.dataTables_length').addClass('bs-select');
    });


</script>
<p>

    <a class=""btn btn-primary mb-3"" href=""#"" onclick=""AddOrEditBranch(0)"">Add New Branch</a>

</p>

<table id=""dtDesign"" class=""table table-striped table-bordered table-sm"" cellspacing=""0"" width=""100%"">
    <thead>
        <tr>
");
            WriteLiteral(@"            <th>
                Branch Name
            </th>
            <th>
                Company Name
            </th>
            <th>
                Country Name
            </th>
            <th>
                Branch Code
            </th>
            <th>
                Location
            </th>

");
            WriteLiteral("            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 59 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Branches\Views\Branch\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n");
            WriteLiteral("                <td>\r\n                    ");
#nullable restore
#line 66 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Branches\Views\Branch\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.BranchName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 69 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Branches\Views\Branch\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 72 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Branches\Views\Branch\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Country1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 75 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Branches\Views\Branch\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.BranchCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 78 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Branches\Views\Branch\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Location));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n");
            WriteLiteral("            <td>\r\n                <a href=\"#\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2609, "\"", 2650, 3);
            WriteAttributeValue("", 2619, "AddOrEditBranch(", 2619, 16, true);
#nullable restore
#line 91 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Branches\Views\Branch\Index.cshtml"
WriteAttributeValue("", 2635, item.BranchId, 2635, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2649, ")", 2649, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Edit</a>\r\n\r\n                <input type=\"button\" class=\"btn btn-danger\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2747, "\"", 2821, 3);
            WriteAttributeValue("", 2757, "DeleteConfirmation(\'/Branches/Branch/Delete/?Id=", 2757, 48, true);
#nullable restore
#line 93 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Branches\Views\Branch\Index.cshtml"
WriteAttributeValue("", 2805, item.BranchId, 2805, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2819, "\')", 2819, 2, true);
            EndWriteAttribute();
            WriteLiteral(" value=\" Delete \" />\r\n            </td>\r\n            </tr>\r\n");
#nullable restore
#line 96 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Branches\Views\Branch\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>

<div id=""AddOrEditBranch"" class=""modal"" tabindex=""-1"" role=""dialog"">
    <div class=""modal-dialog  modal-lg"" modal-dialog-full-width modal-dialog momodel modal-fluid"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Branch Information</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"" id=""formArea"">

            </div>
            <div class=""modal-footer"">
                <button type=""button"" onclick=""SaveBranch()"" class=""btn btn-primary"">Save changes</button>
                <button type=""button"" class=""btn btn-primary"" data-dismiss=""modal"">Close</button>
            </div>
        </div>
    </div>
</div>

<script>
    function AddOrEditBranch(id) {
        $('#AddOrEditBranch').modal(); //op");
            WriteLiteral(@"en the model
        $(""#formArea"").html(""""); // Clear existing are


        $.ajax({
            method: ""GET"",
            url: ""/Branches/Branch/AddOrEditBranch/"" + id,

        })

            .done(function (msg) {
                $(""#formArea"").html(msg);

            });

    }


    function SaveBranch() {
        let postData = new FormData();
        postData.append('BranchId', $(""#BranchId"").val());
        postData.append('CompanyId', $(""#CompanyId"").val());
        postData.append('CountryId', $(""#CountryId"").val());
        postData.append('BranchCode', $(""#BranchCode"").val());
        postData.append('BranchName', $(""#BranchName"").val());
        postData.append('Location', $(""#Location"").val());
        postData.append('Address', $(""#Address"").val());
        postData.append('Phone', $(""#Phone"").val());


        $.ajax({
            method: ""POST"",
            url: ""/Branches/Branch/SaveBranch/"",
            data: postData,
            contentType: false,
 ");
            WriteLiteral("           processData: false,\r\n        }).done(function (data) {\r\n            $(\'#AddOrEditBranch\').modal(\'hide\')\r\n            location.reload();\r\n        });\r\n    }\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SmartWatch.Areas.Branches.Models.ViewModels.BranchViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
