#pragma checksum "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Companies\Views\Company\AddorEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e75280782bfd59ff9008f80edd48a501a98eedb7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Companies_Views_Company_AddorEdit), @"mvc.1.0.view", @"/Areas/Companies/Views/Company/AddorEdit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e75280782bfd59ff9008f80edd48a501a98eedb7", @"/Areas/Companies/Views/Company/AddorEdit.cshtml")]
    public class Areas_Companies_Views_Company_AddorEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SmartWatch.Areas.Companies.Models.ViewModels.CompanyViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Companies\Views\Company\AddorEdit.cshtml"
  
    ViewData["Title"] = "AddorEdit";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n\r\n        <form method=\"post\" action=\"/Companies/Company/SaveCompany\">\r\n\r\n            <input name=\"CompanyId\" id=\"CompanyId\" type=\"hidden\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 326, "\"", 350, 1);
#nullable restore
#line 12 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Companies\Views\Company\AddorEdit.cshtml"
WriteAttributeValue("", 334, Model.CompanyId, 334, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>

            <div class=""form-group"">
                <div class=""row"">
                    <div class=""col-md-4 align-self-center""><label asp-for=""CountryId"" class=""col-md-4 text-right"">Country</label></div>
                    <div class=""col-md-8 align-self-cente"">
                        <div class=""form-group"">
                            <select class=""form-control"" name=""CountryId"" id=""CountryId""");
            BeginWriteAttribute("value", " value=\"", 848, "\"", 872, 1);
#nullable restore
#line 20 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Companies\Views\Company\AddorEdit.cshtml"
WriteAttributeValue("", 856, Model.CountryId, 856, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n");
#nullable restore
#line 22 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Companies\Views\Company\AddorEdit.cshtml"
                                 foreach (var type in Model.countryList)
                                {

                                    if (type.CountryCode == Model.CountryId)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <option selected");
            BeginWriteAttribute("value", " value=\"", 1162, "\"", 1187, 1);
#nullable restore
#line 27 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Companies\Views\Company\AddorEdit.cshtml"
WriteAttributeValue("", 1170, type.CountryCode, 1170, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 27 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Companies\Views\Company\AddorEdit.cshtml"
                                                                              Write(type.Country1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 28 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Companies\Views\Company\AddorEdit.cshtml"


                                    }
                                    else
                                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <option selected");
            BeginWriteAttribute("value", " value=\"", 1396, "\"", 1421, 1);
#nullable restore
#line 34 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Companies\Views\Company\AddorEdit.cshtml"
WriteAttributeValue("", 1404, type.CountryCode, 1404, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 34 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Companies\Views\Company\AddorEdit.cshtml"
                                                                              Write(type.Country1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 35 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Companies\Views\Company\AddorEdit.cshtml"

                                    }

                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </select>


                            <span asp-validation-for=""CountryId"" class=""text-danger""></span>
                        </div>
                    </div>
                </div>

            </div>

            <div class=""form-group"">
                <div class=""row"">
                    <div class=""col-md-4 align-self-center""><label asp-for=""Name"" class=""col-md-4 text-right"">Company Name</label></div>
                    <div class=""col-md-8 align-self-cente"">
                        <input name=""Name"" placeholder=""Company Name"" id=""Name"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 2145, "\"", 2164, 1);
#nullable restore
#line 54 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Companies\Views\Company\AddorEdit.cshtml"
WriteAttributeValue("", 2153, Model.Name, 2153, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                        <span asp-validation-for=""Name"" class=""text-danger""></span>
                    </div>
                </div>
            </div>

            <div class=""form-group"">
                <div class=""row"">
                    <div class=""col-md-4 align-self-center""><label asp-for=""RegNo"" class=""col-md-4 text-right"">Registration No</label></div>
                    <div class=""col-md-8 align-self-cente"">
                        <input name=""RegNo"" placeholder=""RegNo"" id=""RegNo"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 2700, "\"", 2720, 1);
#nullable restore
#line 64 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Companies\Views\Company\AddorEdit.cshtml"
WriteAttributeValue("", 2708, Model.RegNo, 2708, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                        <span asp-validation-for=""RegNo"" class=""text-danger""></span>
                    </div>
                </div>
            </div>

            <div class=""form-group"">
                <div class=""row"">
                    <div class=""col-md-4 align-self-center""><label asp-for=""Phone"" class=""col-md-4 text-right"">Phone Number</label></div>
                    <div class=""col-md-8 align-self-cente"">
                        <input name=""Phone"" placeholder=""Phone"" id=""Phone"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 3254, "\"", 3274, 1);
#nullable restore
#line 74 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Companies\Views\Company\AddorEdit.cshtml"
WriteAttributeValue("", 3262, Model.Phone, 3262, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                        <span asp-validation-for=""Phone"" class=""text-danger""></span>
                    </div>
                </div>
            </div>

            <div class=""form-group"">
                <div class=""row"">
                    <div class=""col-md-4 align-self-center""><label asp-for=""Logo"" class=""col-md-4 text-right"">Logo</label></div>
                    <div class=""col-md-8 align-self-cente"">
                        <input name=""Logo"" placeholder=""Logo"" id=""Logo"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 3796, "\"", 3815, 1);
#nullable restore
#line 84 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Companies\Views\Company\AddorEdit.cshtml"
WriteAttributeValue("", 3804, Model.Logo, 3804, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                        <span asp-validation-for=""Logo"" class=""text-danger""></span>
                    </div>
                </div>
            </div>



            <div class=""form-group"">
                <div class=""row"">
                    <div class=""col-md-4 align-self-center""><label asp-for=""CompanyBranchColor"" class=""col-md-4 text-right"">Company Branch Color</label></div>
                    <div class=""col-md-8 align-self-cente"">
                        <input name=""CompanyBranchColor"" placeholder=""CompanyBranchColor"" id=""CompanyBranchColor"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 4412, "\"", 4445, 1);
#nullable restore
#line 96 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Companies\Views\Company\AddorEdit.cshtml"
WriteAttributeValue("", 4420, Model.CompanyBranchColor, 4420, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                        <span asp-validation-for=""CompanyBranchColor"" class=""text-danger""></span>
                    </div>
                </div>
            </div>

            <div class=""form-group"">
                <div class=""row"">
                    <div class=""col-md-4 align-self-center""><label asp-for=""CompanyForColor"" class=""col-md-4 text-right"">Company For Color</label></div>
                    <div class=""col-md-8 align-self-cente"">
                        <input name=""CompanyForColor"" placeholder=""CompanyForColor"" id=""CompanyForColor"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 5037, "\"", 5067, 1);
#nullable restore
#line 106 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Companies\Views\Company\AddorEdit.cshtml"
WriteAttributeValue("", 5045, Model.CompanyForColor, 5045, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                        <span asp-validation-for=\"CompanyForColor\" class=\"text-danger\"></span>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 114 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Companies\Views\Company\AddorEdit.cshtml"
                  await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
                WriteLiteral("            ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SmartWatch.Areas.Companies.Models.ViewModels.CompanyViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
