#pragma checksum "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Devices\Views\Device\DeviceAssignAdd.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3efa41c6be5faa8848f3c7a64ed24b60f278845f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Devices_Views_Device_DeviceAssignAdd), @"mvc.1.0.view", @"/Areas/Devices/Views/Device/DeviceAssignAdd.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3efa41c6be5faa8848f3c7a64ed24b60f278845f", @"/Areas/Devices/Views/Device/DeviceAssignAdd.cshtml")]
    public class Areas_Devices_Views_Device_DeviceAssignAdd : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SmartWatch.Areas.Devices.Models.ViewModels.DeviceAssignViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Devices\Views\Device\DeviceAssignAdd.cshtml"
  
    ViewData["Title"] = "DeviceAssignAdd";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-lg-11\">\r\n\r\n        <form method=\"post\" action=\"/Devices/Device/SaveDevice\">\r\n\r\n            <input name=\"ConnectNo\" id=\"ConnectNo\" type=\"hidden\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 337, "\"", 361, 1);
#nullable restore
#line 15 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Devices\Views\Device\DeviceAssignAdd.cshtml"
WriteAttributeValue("", 345, Model.ConnectNo, 345, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            <div asp-validation-summary=\"ModelOnly\" class=\"text-danger\"></div>\r\n\r\n\r\n\r\n            <input name=\"DeviceId\" placeholder=\"Device Name\" type=\"hidden\" id=\"DeviceId\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 562, "\"", 585, 1);
#nullable restore
#line 20 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Devices\Views\Device\DeviceAssignAdd.cshtml"
WriteAttributeValue("", 570, Model.DeviceId, 570, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n");
            WriteLiteral(@"


            <div class=""form-group"">
                <div class=""row"">
                    <div class=""col-md-4 align-self-center""><label asp-for=""UserId"" class=""col-md-4 text-right"">User Name</label></div>
                    <div class=""col-md-8 align-self-lg-start"">
                        <select class=""form-control"" name=""UserId"" id=""UserId"">
");
#nullable restore
#line 39 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Devices\Views\Device\DeviceAssignAdd.cshtml"
                             foreach (var type in Model.users)
                            {
                                if (type.UserId == Model.UserId)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <option selected");
            BeginWriteAttribute("value", " value=\"", 1789, "\"", 1809, 1);
#nullable restore
#line 43 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Devices\Views\Device\DeviceAssignAdd.cshtml"
WriteAttributeValue("", 1797, type.UserId, 1797, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 43 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Devices\Views\Device\DeviceAssignAdd.cshtml"
                                                                     Write(type.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 44 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Devices\Views\Device\DeviceAssignAdd.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <option selected");
            BeginWriteAttribute("value", " value=\"", 1996, "\"", 2016, 1);
#nullable restore
#line 47 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Devices\Views\Device\DeviceAssignAdd.cshtml"
WriteAttributeValue("", 2004, type.UserId, 2004, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 47 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Devices\Views\Device\DeviceAssignAdd.cshtml"
                                                                     Write(type.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 48 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Devices\Views\Device\DeviceAssignAdd.cshtml"
                                }
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </select>
                    </div>
                </div>
            </div>

            <div class=""form-group"">
                <div class=""row"">
                    <div class=""col-md-4 align-self-center""><label asp-for=""AssignDateStart"" class=""col-md-4 text-right"">AssignDateStart</label></div>
                    <div class=""col-md-8 align-self-lg-start input-group-append"">
                        <input type=""text"" class=""form-control"" id=""AssignDateStart"" name=""AssignDateStart"" placeholder=""ClassEndDateTime""");
            BeginWriteAttribute("value", " value=\'", 2664, "\'", 2726, 1);
#nullable restore
#line 59 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Devices\Views\Device\DeviceAssignAdd.cshtml"
WriteAttributeValue("", 2672, Model.AssignDateStart.ToString("yyyy/MM/dd HH:mm:ss"), 2672, 54, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">

                        <span class=""input-group-text"">
                            <i class=""la la-calendar-o""></i>
                        </span>
                    </div>
                </div>
            </div>

            <div class=""form-group"">
                <div class=""row"">
                    <div class=""col-md-4 align-self-center""><label asp-for=""AssignDateEnd"" class=""col-md-4 text-right"">AssignDateEnd</label></div>
                    <div class=""col-md-8 align-self-lg-start"">
                        <input name=""AssignDateEnd"" placeholder=""AssignDateEnd"" id=""AssignDateEnd"" class=""form-control""");
            BeginWriteAttribute("value", " value=\'", 3362, "\'", 3424, 1);
#nullable restore
#line 72 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Devices\Views\Device\DeviceAssignAdd.cshtml"
WriteAttributeValue("", 3370, Model.AssignDateStart.ToString("yyyy/MM/dd HH:mm:ss"), 3370, 54, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                        <span asp-validation-for=""AssignDateEnd"" class=""text-danger""></span>
                    </div>
                </div>
            </div>

        </form>
    </div>
</div>

<script src=""/assets/js/plugin/datepicker/bootstrap-datetimepicker.min.js""></script>
<script>

                $('#AssignDateStart').datetimepicker({
                    format: 'YYYY/MM/DD HH:mm',

                });
                 $('#AssignDateEnd').datetimepicker({
                    format: 'YYYY/MM/DD HH:mm',
                });

</script>



");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 98 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Devices\Views\Device\DeviceAssignAdd.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SmartWatch.Areas.Devices.Models.ViewModels.DeviceAssignViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
