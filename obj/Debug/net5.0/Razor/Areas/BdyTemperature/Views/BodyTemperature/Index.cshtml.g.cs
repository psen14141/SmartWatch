#pragma checksum "D:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\BdyTemperature\Views\BodyTemperature\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd40a5c3f00b932aa7a9d1c1feb1a0fdf9b836b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_BdyTemperature_Views_BodyTemperature_Index), @"mvc.1.0.view", @"/Areas/BdyTemperature/Views/BodyTemperature/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd40a5c3f00b932aa7a9d1c1feb1a0fdf9b836b1", @"/Areas/BdyTemperature/Views/BodyTemperature/Index.cshtml")]
    public class Areas_BdyTemperature_Views_BodyTemperature_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SmartWatch.DbModels.BodyTemperature>>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\BdyTemperature\Views\BodyTemperature\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd40a5c3f00b932aa7a9d1c1feb1a0fdf9b836b13051", async() => {
                WriteLiteral("\r\n    <script src=\"https://code.jquery.com/jquery-3.3.1.min.js\"></script>\r\n    <script src=\"https://cdn.jsdelivr.net/npm/chart.js@2.8.0/dist/Chart.min.js\"></script>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "D:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\BdyTemperature\Views\BodyTemperature\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Temperature));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "D:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\BdyTemperature\Views\BodyTemperature\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CheckedTimestamp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "D:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\BdyTemperature\Views\BodyTemperature\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.BodyTemperatureIsDelete));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "D:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\BdyTemperature\Views\BodyTemperature\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DeviceTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "D:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\BdyTemperature\Views\BodyTemperature\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Connect));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 37 "D:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\BdyTemperature\Views\BodyTemperature\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.User));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 43 "D:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\BdyTemperature\Views\BodyTemperature\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 47 "D:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\BdyTemperature\Views\BodyTemperature\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Temperature));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 50 "D:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\BdyTemperature\Views\BodyTemperature\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.CheckedTimestamp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 53 "D:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\BdyTemperature\Views\BodyTemperature\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.BodyTemperatureIsDelete));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 56 "D:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\BdyTemperature\Views\BodyTemperature\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.DeviceTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 59 "D:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\BdyTemperature\Views\BodyTemperature\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Connect.ConnectNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 62 "D:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\BdyTemperature\Views\BodyTemperature\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.User.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1976, "\"", 2014, 1);
#nullable restore
#line 65 "D:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\BdyTemperature\Views\BodyTemperature\Index.cshtml"
WriteAttributeValue("", 1991, item.BodyTemperatureId, 1991, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                    <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 2071, "\"", 2109, 1);
#nullable restore
#line 66 "D:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\BdyTemperature\Views\BodyTemperature\Index.cshtml"
WriteAttributeValue("", 2086, item.BodyTemperatureId, 2086, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                    <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 2168, "\"", 2206, 1);
#nullable restore
#line 67 "D:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\BdyTemperature\Views\BodyTemperature\Index.cshtml"
WriteAttributeValue("", 2183, item.BodyTemperatureId, 2183, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 70 "D:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\BdyTemperature\Views\BodyTemperature\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SmartWatch.DbModels.BodyTemperature>> Html { get; private set; }
    }
}
#pragma warning restore 1591
