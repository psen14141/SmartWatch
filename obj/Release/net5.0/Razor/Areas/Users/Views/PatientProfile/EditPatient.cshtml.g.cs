#pragma checksum "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Users\Views\PatientProfile\EditPatient.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2568fd0266e6c2ad6e9bd04660c592975a82a8e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Users_Views_PatientProfile_EditPatient), @"mvc.1.0.view", @"/Areas/Users/Views/PatientProfile/EditPatient.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2568fd0266e6c2ad6e9bd04660c592975a82a8e6", @"/Areas/Users/Views/PatientProfile/EditPatient.cshtml")]
    public class Areas_Users_Views_PatientProfile_EditPatient : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SmartWatch.Areas.Users.Models.ViewModels.ProfileViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Users\Views\PatientProfile\EditPatient.cshtml"
  
    ViewData["Title"] = "EditPatient";


#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        <form asp-action=\"AddorEdit\">\r\n            <input name=\"UserId\" id=\"UserId\" type=\"hidden\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 283, "\"", 304, 1);
#nullable restore
#line 10 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Users\Views\PatientProfile\EditPatient.cshtml"
WriteAttributeValue("", 291, Model.UserId, 291, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            <div asp-validation-summary=\"ModelOnly\" class=\"text-danger\"></div>\r\n\r\n            <input name=\"ProfileId\" id=\"ProfileId\" type=\"hidden\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 477, "\"", 501, 1);
#nullable restore
#line 13 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Users\Views\PatientProfile\EditPatient.cshtml"
WriteAttributeValue("", 485, Model.ProfileId, 485, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            <div asp-validation-summary=\"ModelOnly\" class=\"text-danger\"></div>\r\n\r\n            <input name=\"RoleId\" id=\"RoleId\" type=\"hidden\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 668, "\"", 689, 1);
#nullable restore
#line 16 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Users\Views\PatientProfile\EditPatient.cshtml"
WriteAttributeValue("", 676, Model.RoleId, 676, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            <div asp-validation-summary=\"ModelOnly\" class=\"text-danger\"></div>\r\n\r\n            <input name=\"CreateTime\" id=\"CreateTime\" type=\"hidden\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 864, "\"", 889, 1);
#nullable restore
#line 19 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Users\Views\PatientProfile\EditPatient.cshtml"
WriteAttributeValue("", 872, Model.CreateTime, 872, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>


            <div class=""form-group"">
                <div class=""row"">
                    <div class=""col-md-2 align-self-center""><label asp-for=""FirstName"" class=""col-md-4 text-right"">First Name</label></div>
                    <div class=""col-md-4 align-self-cente"">
                        <input name=""FirstName"" id=""FirstName"" placeholder=""First Name"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 1362, "\"", 1386, 1);
#nullable restore
#line 27 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Users\Views\PatientProfile\EditPatient.cshtml"
WriteAttributeValue("", 1370, Model.FirstName, 1370, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                        <span asp-validation-for=""FirstName"" class=""text-danger""></span>

                    </div>

                    <div class=""col-md-2 align-self-center""><label asp-for=""LastName"" class=""col-md-4 text-right"">Last Name</label></div>
                    <div class=""col-md-4 align-self-cente"">
                        <input name=""LastName"" id=""LastName"" placeholder=""LastName"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 1818, "\"", 1841, 1);
#nullable restore
#line 34 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Users\Views\PatientProfile\EditPatient.cshtml"
WriteAttributeValue("", 1826, Model.LastName, 1826, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                        <span asp-validation-for=""LastName"" class=""text-danger""></span>

                    </div>

                </div>

            </div>

            <div class=""form-group"">
                <div class=""row"">
                    <div class=""col-md-2 align-self-center""><label asp-for=""Username"" class=""col-md-4 text-right"">User Name</label></div>
                    <div class=""col-md-4 align-self-cente"">
                        <input name=""Username"" id=""Username"" placeholder=""User name"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 2394, "\"", 2417, 1);
#nullable restore
#line 47 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Users\Views\PatientProfile\EditPatient.cshtml"
WriteAttributeValue("", 2402, Model.Username, 2402, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                        <span asp-validation-for=""Username"" class=""text-danger""></span>

                    </div>

                    <div class=""col-md-2 align-self-center""><label asp-for=""Email"" class=""col-md-4 text-right"">Email</label></div>
                    <div class=""col-md-4 align-self-cente"">
                        <input name=""Email"" id=""Email"" placeholder=""Email"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 2832, "\"", 2852, 1);
#nullable restore
#line 54 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Users\Views\PatientProfile\EditPatient.cshtml"
WriteAttributeValue("", 2840, Model.Email, 2840, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                        <span asp-validation-for=""Email"" class=""text-danger""></span>

                    </div>

                </div>

            </div>

            <div class=""form-group"">
                <div class=""row"">
                    <div class=""col-md-2 align-self-center""><label asp-for=""Mobile"" class=""col-md-4 text-right"">Mobile</label></div>
                    <div class=""col-md-4 align-self-cente"">
                        <input name=""Mobile"" id=""Mobile"" placeholder=""Mobile"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 3390, "\"", 3411, 1);
#nullable restore
#line 67 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Users\Views\PatientProfile\EditPatient.cshtml"
WriteAttributeValue("", 3398, Model.Mobile, 3398, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                        <span asp-validation-for=""Mobile"" class=""text-danger""></span>

                    </div>

                    <div class=""col-md-2 align-self-center""><label asp-for=""Address"" class=""col-md-4 text-right"">Address</label></div>
                    <div class=""col-md-4 align-self-cente"">
                        <input name=""Address"" id=""Address"" placeholder=""Address"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 3834, "\"", 3856, 1);
#nullable restore
#line 74 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Users\Views\PatientProfile\EditPatient.cshtml"
WriteAttributeValue("", 3842, Model.Address, 3842, 14, false);

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
                    <div class=""col-md-2 align-self-center""><label asp-for=""City"" class=""col-md-4 text-right"">City</label></div>
                    <div class=""col-md-4 align-self-cente"">
                        <input name=""City"" id=""City"" placeholder=""City"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 4386, "\"", 4405, 1);
#nullable restore
#line 87 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Users\Views\PatientProfile\EditPatient.cshtml"
WriteAttributeValue("", 4394, Model.City, 4394, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                        <span asp-validation-for=""City"" class=""text-danger""></span>

                    </div>

                    <div class=""col-md-2 align-self-center""><label asp-for=""PostalCode"" class=""col-md-4 text-right"">PostalCode</label></div>
                    <div class=""col-md-4 align-self-cente"">
                        <input name=""PostalCode"" id=""PostalCode"" placeholder=""PostalCode"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 4841, "\"", 4866, 1);
#nullable restore
#line 94 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Users\Views\PatientProfile\EditPatient.cshtml"
WriteAttributeValue("", 4849, Model.PostalCode, 4849, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                        <span asp-validation-for=""PostalCode"" class=""text-danger""></span>

                    </div>

                </div>

            </div>

            <div class=""form-group"">
                <div class=""row"">
                    <div class=""col-md-2 align-self-center""><label asp-for=""CountryId"" class=""col-md-4 text-right"">Country Name</label></div>
                    <div class=""col-md-4 align-self-cente"">
                        <div class=""form-group"">
                            <select class=""form-control"" name=""CountryId"" id=""CountryId""");
            BeginWriteAttribute("value", " value=\"", 5458, "\"", 5482, 1);
#nullable restore
#line 108 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Users\Views\PatientProfile\EditPatient.cshtml"
WriteAttributeValue("", 5466, Model.CountryId, 5466, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n");
#nullable restore
#line 110 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Users\Views\PatientProfile\EditPatient.cshtml"
                                 foreach (var type in Model.countries)
                                {

                                    if (type.CountryCode == Model.CountryId)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <option selected");
            BeginWriteAttribute("value", " value=\"", 5770, "\"", 5795, 1);
#nullable restore
#line 115 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Users\Views\PatientProfile\EditPatient.cshtml"
WriteAttributeValue("", 5778, type.CountryCode, 5778, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 115 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Users\Views\PatientProfile\EditPatient.cshtml"
                                                                              Write(type.Country1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 116 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Users\Views\PatientProfile\EditPatient.cshtml"


                                    }
                                    else
                                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <option selected");
            BeginWriteAttribute("value", " value=\"", 6004, "\"", 6029, 1);
#nullable restore
#line 122 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Users\Views\PatientProfile\EditPatient.cshtml"
WriteAttributeValue("", 6012, type.CountryCode, 6012, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 122 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Users\Views\PatientProfile\EditPatient.cshtml"
                                                                              Write(type.Country1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 123 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Users\Views\PatientProfile\EditPatient.cshtml"

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

                    <div class=""col-md-2 align-self-center""><label asp-for=""CompanyId"" class=""col-md-4 text-right"">Company Name</label></div>
                    <div class=""col-md-4 align-self-cente"">
                        <div class=""form-group"">
                            <select class=""form-control"" name=""CompanyId"" id=""CompanyId""");
            BeginWriteAttribute("value", " value=\"", 6679, "\"", 6703, 1);
#nullable restore
#line 139 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Users\Views\PatientProfile\EditPatient.cshtml"
WriteAttributeValue("", 6687, Model.CompanyId, 6687, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n");
#nullable restore
#line 141 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Users\Views\PatientProfile\EditPatient.cshtml"
                                 foreach (var type in Model.companies)
                                {

                                    if (type.CompanyId == Model.CompanyId)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <option selected");
            BeginWriteAttribute("value", " value=\"", 6989, "\"", 7012, 1);
#nullable restore
#line 146 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Users\Views\PatientProfile\EditPatient.cshtml"
WriteAttributeValue("", 6997, type.CompanyId, 6997, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 146 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Users\Views\PatientProfile\EditPatient.cshtml"
                                                                            Write(type.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 147 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Users\Views\PatientProfile\EditPatient.cshtml"


                                    }
                                    else
                                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <option selected");
            BeginWriteAttribute("value", " value=\"", 7217, "\"", 7240, 1);
#nullable restore
#line 153 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Users\Views\PatientProfile\EditPatient.cshtml"
WriteAttributeValue("", 7225, type.CompanyId, 7225, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 153 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Users\Views\PatientProfile\EditPatient.cshtml"
                                                                            Write(type.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 154 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Users\Views\PatientProfile\EditPatient.cshtml"

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

                </div>

            </div>

            <div class=""form-group"">
                <div class=""row"">
                    <div class=""col-md-2 align-self-center""><label asp-for=""Profilecol"" class=""col-md-4 text-right"">Profilecol</label></div>
                    <div class=""col-md-4 align-self-cente"">
                        <input name=""Profilecol"" id=""Profilecol"" placeholder=""Profilecol"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 7978, "\"", 8003, 1);
#nullable restore
#line 175 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Users\Views\PatientProfile\EditPatient.cshtml"
WriteAttributeValue("", 7986, Model.Profilecol, 7986, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                        <span asp-validation-for=""Profilecol"" class=""text-danger""></span>

                    </div>


                    <div class=""col-md-2 align-self-center""><label asp-for=""UserSecret"" class=""col-md-4 text-right"">UserSecret</label></div>
                    <div class=""col-md-4 align-self-cente"">
                        <input name=""UserSecret"" id=""UserSecret"" placeholder=""UserSecret"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 8447, "\"", 8472, 1);
#nullable restore
#line 183 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Users\Views\PatientProfile\EditPatient.cshtml"
WriteAttributeValue("", 8455, Model.UserSecret, 8455, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                        <span asp-validation-for=""UserSecret"" class=""text-danger""></span>

                    </div>

                </div>

            </div>


            <div class=""form-group"">
                <div class=""row"">
                    <div class=""col-md-2 align-self-center""><label asp-for=""UserDynamickey"" class=""col-md-4 text-right"">UserDynamickey</label></div>
                    <div class=""col-md-4 align-self-cente"">
                        <input name=""UserDynamickey"" id=""UserDynamickey"" placeholder=""UserDynamickey"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 9057, "\"", 9086, 1);
#nullable restore
#line 197 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Users\Views\PatientProfile\EditPatient.cshtml"
WriteAttributeValue("", 9065, Model.UserDynamickey, 9065, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                        <span asp-validation-for=\"UserDynamickey\" class=\"text-danger\"></span>\r\n\r\n                    </div>\r\n\r\n\r\n\r\n\r\n\r\n                </div>\r\n\r\n            </div>\r\n\r\n\r\n\r\n        </form>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 217 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Users\Views\PatientProfile\EditPatient.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SmartWatch.Areas.Users.Models.ViewModels.ProfileViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
