#pragma checksum "D:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\BloodPressur\Views\BloodPressureList\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2f487912601ae736d508229ace3ed5913874eda"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_BloodPressur_Views_BloodPressureList_Index), @"mvc.1.0.view", @"/Areas/BloodPressur/Views/BloodPressureList/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2f487912601ae736d508229ace3ed5913874eda", @"/Areas/BloodPressur/Views/BloodPressureList/Index.cshtml")]
    public class Areas_BloodPressur_Views_BloodPressureList_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SmartWatch.Areas.BloodPressur.Models.ViewModels.BloodPressureViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\BloodPressur\Views\BloodPressureList\Index.cshtml"
  
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

<h3>Blood Pressure</h3>

<table id=""dtDesign"" class=""table table-striped table-bordered table-sm"" cellspacing=""0"" width=""100%"">
    <thead>
        <tr>
            <th>
");
            WriteLiteral("#\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 24 "D:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\BloodPressur\Views\BloodPressureList\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Users));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n");
            WriteLiteral("            <th>\r\n                ");
#nullable restore
#line 30 "D:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\BloodPressur\Views\BloodPressureList\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Checkedtime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 33 "D:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\BloodPressur\Views\BloodPressureList\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.BloodPressureUpper));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 36 "D:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\BloodPressur\Views\BloodPressureList\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.BloodPreesureLower));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 39 "D:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\BloodPressur\Views\BloodPressureList\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DeviceTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 45 "D:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\BloodPressur\Views\BloodPressureList\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 49 "D:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\BloodPressur\Views\BloodPressureList\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.BloodPressureId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 52 "D:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\BloodPressur\Views\BloodPressureList\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.username));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n");
            WriteLiteral("                <td>\r\n                    ");
#nullable restore
#line 58 "D:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\BloodPressur\Views\BloodPressureList\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Checkedtime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 61 "D:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\BloodPressur\Views\BloodPressureList\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.BloodPressureUpper));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 64 "D:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\BloodPressur\Views\BloodPressureList\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.BloodPreesureLower));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 67 "D:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\BloodPressur\Views\BloodPressureList\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.DeviceTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
            WriteLiteral("                    <a href=\"/BloodPressur/BloodPressure/\" class=\"btn btn-primary\">Details</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 75 "D:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\BloodPressur\Views\BloodPressureList\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SmartWatch.Areas.BloodPressur.Models.ViewModels.BloodPressureViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591