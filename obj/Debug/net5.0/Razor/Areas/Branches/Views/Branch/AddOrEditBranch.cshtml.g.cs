#pragma checksum "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Branches\Views\Branch\AddOrEditBranch.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b892de909afc93115a9bc6b3af966ead8700460c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Branches_Views_Branch_AddOrEditBranch), @"mvc.1.0.view", @"/Areas/Branches/Views/Branch/AddOrEditBranch.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b892de909afc93115a9bc6b3af966ead8700460c", @"/Areas/Branches/Views/Branch/AddOrEditBranch.cshtml")]
    public class Areas_Branches_Views_Branch_AddOrEditBranch : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SmartWatch.Areas.Branches.Models.ViewModels.BranchViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Branches\Views\Branch\AddOrEditBranch.cshtml"
  
    ViewData["Title"] = "AddOrEditBranch";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h4>Branch</h4>\r\n<hr />\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n\r\n        <form method=\"post\" action=\"/Branches/Branch/SaveBranch\">\r\n            <input name=\"BranchId\" id=\"BranchId\" type=\"hidden\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 352, "\"", 375, 1);
#nullable restore
#line 15 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Branches\Views\Branch\AddOrEditBranch.cshtml"
WriteAttributeValue("", 360, Model.BranchId, 360, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>


            <div class=""form-group"">
                <div class=""row"">
                    <div class=""col-md-2 align-self-center""><label asp-for=""CompanyId"" class=""col-md-4 text-right"">Company Name</label></div>
                    <div class=""col-md-4 align-self-cente"">
                        <div class=""form-group"">
                            <select class=""form-control"" name=""CompanyId"" id=""CompanyId"">

");
#nullable restore
#line 26 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Branches\Views\Branch\AddOrEditBranch.cshtml"
                                 foreach (var type in Model.companies)
                                {
                                    if (type.CompanyId == Model.CompanyId)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <option selected");
            BeginWriteAttribute("value", " value=\"", 1163, "\"", 1186, 1);
#nullable restore
#line 30 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Branches\Views\Branch\AddOrEditBranch.cshtml"
WriteAttributeValue("", 1171, type.CompanyId, 1171, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 30 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Branches\Views\Branch\AddOrEditBranch.cshtml"
                                                                            Write(type.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 31 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Branches\Views\Branch\AddOrEditBranch.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <option selected");
            BeginWriteAttribute("value", " value=\"", 1385, "\"", 1408, 1);
#nullable restore
#line 34 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Branches\Views\Branch\AddOrEditBranch.cshtml"
WriteAttributeValue("", 1393, type.CompanyId, 1393, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 34 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Branches\Views\Branch\AddOrEditBranch.cshtml"
                                                                            Write(type.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 35 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Branches\Views\Branch\AddOrEditBranch.cshtml"
                                    }

                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </select>

                            <span asp-validation-for=""CompanyId"" class=""text-danger""></span>
                        </div>
                    </div>
                   
                            <div class=""col-md-2 align-self-center""><label asp-for=""CountryCode"" class=""col-md-4 text-right"">Country Name</label></div>
                            <div class=""col-md-4 align-self-cente"">
                                <div class=""form-group"">
                                    <select class=""form-control"" name=""CountryCode"" id=""CountryId"">

");
#nullable restore
#line 50 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Branches\Views\Branch\AddOrEditBranch.cshtml"
                                         foreach (var type in Model.countries)
                                        {
                                            if (type.CountryCode == Model.CountryId)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <option selected");
            BeginWriteAttribute("value", " value=\"", 2428, "\"", 2453, 1);
#nullable restore
#line 54 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Branches\Views\Branch\AddOrEditBranch.cshtml"
WriteAttributeValue("", 2436, type.CountryCode, 2436, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 54 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Branches\Views\Branch\AddOrEditBranch.cshtml"
                                                                                      Write(type.Country1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 55 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Branches\Views\Branch\AddOrEditBranch.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <option selected");
            BeginWriteAttribute("value", " value=\"", 2688, "\"", 2713, 1);
#nullable restore
#line 58 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Branches\Views\Branch\AddOrEditBranch.cshtml"
WriteAttributeValue("", 2696, type.CountryCode, 2696, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 58 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Branches\Views\Branch\AddOrEditBranch.cshtml"
                                                                                      Write(type.Country1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 59 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Branches\Views\Branch\AddOrEditBranch.cshtml"
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
                    <div class=""col-md-2 align-self-center""><label asp-for=""BranchCode"" class=""col-md-4 text-right"">Branch Code</label></div>
                    <div class=""col-md-4 align-self-cente"">
                        <input name=""BranchCode"" placeholder=""Branch Code "" id=""BranchCode"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 3554, "\"", 3579, 1);
#nullable restore
#line 79 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Branches\Views\Branch\AddOrEditBranch.cshtml"
WriteAttributeValue("", 3562, Model.BranchCode, 3562, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                        <span asp-validation-for=""BranchCode"" class=""text-danger""></span>
                    </div>

                    <div class=""col-md-2 align-self-center""><label asp-for=""BranchName"" class=""col-md-4 text-right"">Branch Name</label></div>
                    <div class=""col-md-4 align-self-cente"">
                        <input name=""BranchName"" placeholder=""BranchName"" id=""BranchName"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 4020, "\"", 4045, 1);
#nullable restore
#line 85 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Branches\Views\Branch\AddOrEditBranch.cshtml"
WriteAttributeValue("", 4028, Model.BranchName, 4028, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                        <span asp-validation-for=""BranchName"" class=""text-danger""></span>
                    </div>
                </div>
            </div>
         

            <div class=""form-group"">
                <div class=""row"">
                    <div class=""col-md-2 align-self-center""><label asp-for=""Location"" class=""col-md-4 text-right""> Location</label></div>
                    <div class=""col-md-4 align-self-cente"">
                        <input name=""Location"" placeholder=""Location"" id=""Location"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 4604, "\"", 4627, 1);
#nullable restore
#line 96 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Branches\Views\Branch\AddOrEditBranch.cshtml"
WriteAttributeValue("", 4612, Model.Location, 4612, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                        <span asp-validation-for=""Location"" class=""text-danger""></span>
                    </div>

                    <div class=""col-md-2 align-self-center""><label asp-for=""Address"" class=""col-md-4 text-right"">Address</label></div>
                    <div class=""col-md-4 align-self-cente"">
                        <input name=""Address"" placeholder=""Address"" id=""Address"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 5050, "\"", 5072, 1);
#nullable restore
#line 102 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Branches\Views\Branch\AddOrEditBranch.cshtml"
WriteAttributeValue("", 5058, Model.Address, 5058, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                        <span asp-validation-for=""Address"" class=""text-danger""></span>
                    </div>
                </div>
            </div>

          
            <div class=""form-group"">
                <div class=""row"">
                    <div class=""col-md-2 align-self-center""><label asp-for=""Phone"" class=""col-md-4 text-right"">Phone</label></div>
                    <div class=""col-md-4 align-self-cente"">
                        <input name=""Phone"" placeholder=""Phone"" id=""Phone"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 5613, "\"", 5633, 1);
#nullable restore
#line 113 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Branches\Views\Branch\AddOrEditBranch.cshtml"
WriteAttributeValue("", 5621, Model.Phone, 5621, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                        <span asp-validation-for=\"Phone\" class=\"text-danger\"></span>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n\r\n        </form>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 127 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Branches\Views\Branch\AddOrEditBranch.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SmartWatch.Areas.Branches.Models.ViewModels.BranchViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
