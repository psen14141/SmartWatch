#pragma checksum "E:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\Dashboard\Views\Dashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4413e813667e8253d50e6eff80b5d26363aecf22"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Dashboard_Views_Dashboard_Index), @"mvc.1.0.view", @"/Areas/Dashboard/Views/Dashboard/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4413e813667e8253d50e6eff80b5d26363aecf22", @"/Areas/Dashboard/Views/Dashboard/Index.cshtml")]
    public class Areas_Dashboard_Views_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SmartWatch.Areas.Dashboard.Models.ViewModels.ProfileViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\Dashboard\Views\Dashboard\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Index</h1>

<p>
    <a asp-action=""Create"">Create New</a>
</p>
<table class=""table"">
    <thead>
        <tr>
            <th>
                Patient Name
            </th>

            <th>
                Contact Number
            </th>
            <th>
                Blood Pressur
            </th>
            <th>
                Step Count
            </th>
            <th>
                Heart Rate
            </th>
            <th>
                Body Temparature
            </th>



            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 41 "E:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\Dashboard\Views\Dashboard\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 45 "E:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\Dashboard\Views\Dashboard\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n                ");
#nullable restore
#line 49 "E:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\Dashboard\Views\Dashboard\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Mobile));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n\r\n");
#nullable restore
#line 53 "E:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\Dashboard\Views\Dashboard\Index.cshtml"
                 foreach (var bp in item.bloodPressure)
                {

                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "E:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\Dashboard\Views\Dashboard\Index.cshtml"
               Write(Html.DisplayFor(modelItem => bp.BloodPreesureLower));

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "E:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\Dashboard\Views\Dashboard\Index.cshtml"
                                                                        

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 61 "E:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\Dashboard\Views\Dashboard\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Mobile));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 64 "E:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\Dashboard\Views\Dashboard\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Mobile));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 67 "E:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\Dashboard\Views\Dashboard\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Mobile));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 70 "E:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\Dashboard\Views\Dashboard\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SmartWatch.Areas.Dashboard.Models.ViewModels.ProfileViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
