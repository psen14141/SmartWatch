#pragma checksum "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Devices\Views\ConnectionStatus\AddorEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91b5f805a744d39f330ea17086fbc0873efafc6b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Devices_Views_ConnectionStatus_AddorEdit), @"mvc.1.0.view", @"/Areas/Devices/Views/ConnectionStatus/AddorEdit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91b5f805a744d39f330ea17086fbc0873efafc6b", @"/Areas/Devices/Views/ConnectionStatus/AddorEdit.cshtml")]
    public class Areas_Devices_Views_ConnectionStatus_AddorEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SmartWatch.Areas.Devices.Models.ViewModels.ConnectionStatusViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Devices\Views\ConnectionStatus\AddorEdit.cshtml"
  
    ViewData["Title"] = "AddorEdit";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n\r\n        <form method=\"post\" action=\"/Devices/ConnectionStatus/SaveConnectionStatus\">\r\n\r\n            <input name=\"ConnectionstatusId\" id=\"ConnectionstatusId\" type=\"hidden\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 371, "\"", 404, 1);
#nullable restore
#line 14 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Devices\Views\ConnectionStatus\AddorEdit.cshtml"
WriteAttributeValue("", 379, Model.ConnectionstatusId, 379, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>



            <div class=""form-group"">
                <div class=""row"">
                    <div class=""col-md-5 align-self-center""><label asp-for=""ConnectId"" class=""col-md-4 text-right"">ConnectId</label></div>
                    <div class=""col-md-5 align-self-cente"">
                        <input name=""ConnectId"" placeholder=""ConnectId"" id=""ConnectId"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 877, "\"", 901, 1);
#nullable restore
#line 23 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Devices\Views\ConnectionStatus\AddorEdit.cshtml"
WriteAttributeValue("", 885, Model.ConnectId, 885, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                        <span asp-validation-for=""ConnectId"" class=""text-danger""></span>
                    </div>
                </div>
            </div>



            <div class=""form-group"">
                <div class=""row"">
                    <div class=""col-md-5 align-self-center""><label asp-for=""Status"" class=""col-md-4 text-right"">Status</label></div>
                    <div class=""col-md-5 align-self-cente"">
                        <input name=""Status"" placeholder=""Status"" id=""Status"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 1441, "\"", 1462, 1);
#nullable restore
#line 35 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Devices\Views\ConnectionStatus\AddorEdit.cshtml"
WriteAttributeValue("", 1449, Model.Status, 1449, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                        <span asp-validation-for=""Status"" class=""text-danger""></span>
                    </div>
                </div>
            </div>


            <div class=""form-group"">
                <div class=""row"">
                    <div class=""col-md-5 align-self-center""><label asp-for=""SyncPeriodStartTime"" class=""col-md-4 text-right"">SyncPeriodStartTime</label></div>
                    <div class=""col-md-6 align-self-cente"">
                        <input name=""SyncPeriodStartTime"" placeholder=""SyncPeriodStartTime"" id=""SyncPeriodStartTime"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 2062, "\"", 2096, 1);
#nullable restore
#line 46 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Devices\Views\ConnectionStatus\AddorEdit.cshtml"
WriteAttributeValue("", 2070, Model.SyncPeriodStartTime, 2070, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                        <span asp-validation-for=""SyncPeriodStartTime"" class=""text-danger""></span>
                    </div>
                </div>
            </div>

            <div class=""form-group"">
                <div class=""row"">
                    <div class=""col-md-5 align-self-center""><label asp-for=""SyncPeriodEndTime"" class=""col-md-4 text-right"">SyncPeriodEndTime</label></div>
                    <div class=""col-md-6 align-self-cente"">
                        <input name=""SyncPeriodEndTime"" placeholder=""SyncPeriodEndTime"" id=""SyncPeriodEndTime"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 2697, "\"", 2729, 1);
#nullable restore
#line 56 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Devices\Views\ConnectionStatus\AddorEdit.cshtml"
WriteAttributeValue("", 2705, Model.SyncPeriodEndTime, 2705, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                        <span asp-validation-for=\"SyncPeriodEndTime\" class=\"text-danger\"></span>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n        </form>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 69 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Devices\Views\ConnectionStatus\AddorEdit.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SmartWatch.Areas.Devices.Models.ViewModels.ConnectionStatusViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
