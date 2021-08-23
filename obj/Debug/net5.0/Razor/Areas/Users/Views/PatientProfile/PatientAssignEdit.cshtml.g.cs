#pragma checksum "D:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\Users\Views\PatientProfile\PatientAssignEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1d8a46bd2a0595b0594fc0e2ecb49b9b80c3fdc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Users_Views_PatientProfile_PatientAssignEdit), @"mvc.1.0.view", @"/Areas/Users/Views/PatientProfile/PatientAssignEdit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1d8a46bd2a0595b0594fc0e2ecb49b9b80c3fdc", @"/Areas/Users/Views/PatientProfile/PatientAssignEdit.cshtml")]
    public class Areas_Users_Views_PatientProfile_PatientAssignEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SmartWatch.Areas.Users.Models.ViewModels.PatientAssignViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\Users\Views\PatientProfile\PatientAssignEdit.cshtml"
  
    ViewData["Title"] = "Patient Assign Edit";
   

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        <form method=\"post\" action=\"/Users/PatientProfile/PatientAssignEdit\">\r\n            <input name=\"PatientAssignId\" type=\"hidden\" id=\"PatientAssignId\" placeholder=\"Patient Assign Id\"");
            BeginWriteAttribute("value", " value=\"", 371, "\"", 401, 1);
#nullable restore
#line 11 "D:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\Users\Views\PatientProfile\PatientAssignEdit.cshtml"
WriteAttributeValue("", 379, Model.PatientAssignId, 379, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" />
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>

            <div class=""form-group"">
                <div class=""row"">
                    <div class=""col-md-6 align-self-center""><label asp-for=""PatientId"" class=""col-md-4 text-right"">Patient</label></div>
                    <div class=""col-md-8 align-self-center"">
                        <select class=""form-control"" name=""PatientId"" placeholder=""Select Patient"" id=""PatientId"">
");
#nullable restore
#line 19 "D:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\Users\Views\PatientProfile\PatientAssignEdit.cshtml"
                             foreach (var user in Model.users)
                            {
                                if (user.UserId == Model.PatientId)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <option selected");
            BeginWriteAttribute("value", " value=\"", 1150, "\"", 1170, 1);
#nullable restore
#line 23 "D:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\Users\Views\PatientProfile\PatientAssignEdit.cshtml"
WriteAttributeValue("", 1158, user.UserId, 1158, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 23 "D:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\Users\Views\PatientProfile\PatientAssignEdit.cshtml"
                                                                     Write(user.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 24 "D:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\Users\Views\PatientProfile\PatientAssignEdit.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <option selected");
            BeginWriteAttribute("value", " value=\"", 1357, "\"", 1377, 1);
#nullable restore
#line 27 "D:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\Users\Views\PatientProfile\PatientAssignEdit.cshtml"
WriteAttributeValue("", 1365, user.UserId, 1365, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 27 "D:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\Users\Views\PatientProfile\PatientAssignEdit.cshtml"
                                                                     Write(user.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 28 "D:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\Users\Views\PatientProfile\PatientAssignEdit.cshtml"
                                }
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </select>
                        <span asp-validation-for=""PatientId"" class=""text-danger""></span>
                    </div>
                </div>
            </div>

            <div class=""form-group"">
                <div class=""row"">
                    <div class=""col-md-6 align-self-center""><label asp-for=""AssignedStaffId"" class=""col-md-4 text-right"">Assigned Staff</label></div>
                    <div class=""col-md-8 align-self-center"">
                        <select class=""form-control"" name=""AssignedStaffId"" placeholder=""Select Staff"" id=""PatientId"">
");
#nullable restore
#line 41 "D:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\Users\Views\PatientProfile\PatientAssignEdit.cshtml"
                             foreach (var user in Model.users)
                            {
                                if (user.UserId == Model.AssignedStaffId)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <option selected");
            BeginWriteAttribute("value", " value=\"", 2332, "\"", 2352, 1);
#nullable restore
#line 45 "D:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\Users\Views\PatientProfile\PatientAssignEdit.cshtml"
WriteAttributeValue("", 2340, user.UserId, 2340, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 45 "D:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\Users\Views\PatientProfile\PatientAssignEdit.cshtml"
                                                                     Write(user.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 46 "D:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\Users\Views\PatientProfile\PatientAssignEdit.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <option selected");
            BeginWriteAttribute("value", " value=\"", 2539, "\"", 2559, 1);
#nullable restore
#line 49 "D:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\Users\Views\PatientProfile\PatientAssignEdit.cshtml"
WriteAttributeValue("", 2547, user.UserId, 2547, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 49 "D:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\Users\Views\PatientProfile\PatientAssignEdit.cshtml"
                                                                     Write(user.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 50 "D:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\Users\Views\PatientProfile\PatientAssignEdit.cshtml"
                                }
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </select>\r\n                        <span asp-validation-for=\"AssignedStaffId\" class=\"text-danger\"></span>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n        </form>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SmartWatch.Areas.Users.Models.ViewModels.PatientAssignViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591