#pragma checksum "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Users\Views\DoctorProfile\AddorEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ffa5b3df2d8a19b5e3afe054887b6e1b16a3cc6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Users_Views_DoctorProfile_AddorEdit), @"mvc.1.0.view", @"/Areas/Users/Views/DoctorProfile/AddorEdit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ffa5b3df2d8a19b5e3afe054887b6e1b16a3cc6", @"/Areas/Users/Views/DoctorProfile/AddorEdit.cshtml")]
    public class Areas_Users_Views_DoctorProfile_AddorEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SmartWatch.Areas.Users.Models.ViewModels.ProfileViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Users\Views\DoctorProfile\AddorEdit.cshtml"
  
    ViewData["Title"] = "AddorEdit";
   

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        <form asp-action=\"AddorEdit\">\r\n            <input name=\"UserId\" id=\"UserId\" type=\"hidden\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 286, "\"", 307, 1);
#nullable restore
#line 11 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Users\Views\DoctorProfile\AddorEdit.cshtml"
WriteAttributeValue("", 294, Model.UserId, 294, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            <div asp-validation-summary=\"ModelOnly\" class=\"text-danger\"></div>\r\n\r\n            <input name=\"ProfileId\" id=\"ProfileId\" type=\"hidden\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 480, "\"", 504, 1);
#nullable restore
#line 14 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Users\Views\DoctorProfile\AddorEdit.cshtml"
WriteAttributeValue("", 488, Model.ProfileId, 488, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            <div asp-validation-summary=\"ModelOnly\" class=\"text-danger\"></div>\r\n\r\n            <input name=\"RoleId\" id=\"RoleId\" type=\"hidden\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 671, "\"", 692, 1);
#nullable restore
#line 17 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Users\Views\DoctorProfile\AddorEdit.cshtml"
WriteAttributeValue("", 679, Model.RoleId, 679, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            <div asp-validation-summary=\"ModelOnly\" class=\"text-danger\"></div>\r\n\r\n            <input name=\"CreateTime\" id=\"CreateTime\" type=\"hidden\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 867, "\"", 892, 1);
#nullable restore
#line 20 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Users\Views\DoctorProfile\AddorEdit.cshtml"
WriteAttributeValue("", 875, Model.CreateTime, 875, 17, false);

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
            BeginWriteAttribute("value", " value=\"", 1365, "\"", 1389, 1);
#nullable restore
#line 28 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Users\Views\DoctorProfile\AddorEdit.cshtml"
WriteAttributeValue("", 1373, Model.FirstName, 1373, 16, false);

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
            BeginWriteAttribute("value", " value=\"", 1821, "\"", 1844, 1);
#nullable restore
#line 35 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Users\Views\DoctorProfile\AddorEdit.cshtml"
WriteAttributeValue("", 1829, Model.LastName, 1829, 15, false);

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
            BeginWriteAttribute("value", " value=\"", 2397, "\"", 2420, 1);
#nullable restore
#line 48 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Users\Views\DoctorProfile\AddorEdit.cshtml"
WriteAttributeValue("", 2405, Model.Username, 2405, 15, false);

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
            BeginWriteAttribute("value", " value=\"", 2835, "\"", 2855, 1);
#nullable restore
#line 55 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Users\Views\DoctorProfile\AddorEdit.cshtml"
WriteAttributeValue("", 2843, Model.Email, 2843, 12, false);

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
            BeginWriteAttribute("value", " value=\"", 3393, "\"", 3414, 1);
#nullable restore
#line 68 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Users\Views\DoctorProfile\AddorEdit.cshtml"
WriteAttributeValue("", 3401, Model.Mobile, 3401, 13, false);

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
            BeginWriteAttribute("value", " value=\"", 3837, "\"", 3859, 1);
#nullable restore
#line 75 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Users\Views\DoctorProfile\AddorEdit.cshtml"
WriteAttributeValue("", 3845, Model.Address, 3845, 14, false);

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
            BeginWriteAttribute("value", " value=\"", 4389, "\"", 4408, 1);
#nullable restore
#line 88 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Users\Views\DoctorProfile\AddorEdit.cshtml"
WriteAttributeValue("", 4397, Model.City, 4397, 11, false);

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
            BeginWriteAttribute("value", " value=\"", 4844, "\"", 4869, 1);
#nullable restore
#line 95 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Users\Views\DoctorProfile\AddorEdit.cshtml"
WriteAttributeValue("", 4852, Model.PostalCode, 4852, 17, false);

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
            BeginWriteAttribute("value", " value=\"", 5461, "\"", 5485, 1);
#nullable restore
#line 109 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Users\Views\DoctorProfile\AddorEdit.cshtml"
WriteAttributeValue("", 5469, Model.CountryId, 5469, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n");
#nullable restore
#line 111 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Users\Views\DoctorProfile\AddorEdit.cshtml"
                                 foreach (var type in Model.countries)
                                {

                                    if (type.CountryCode == Model.CountryId)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <option selected");
            BeginWriteAttribute("value", " value=\"", 5773, "\"", 5798, 1);
#nullable restore
#line 116 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Users\Views\DoctorProfile\AddorEdit.cshtml"
WriteAttributeValue("", 5781, type.CountryCode, 5781, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 116 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Users\Views\DoctorProfile\AddorEdit.cshtml"
                                                                              Write(type.Country1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 117 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Users\Views\DoctorProfile\AddorEdit.cshtml"


                                    }
                                    else
                                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <option selected");
            BeginWriteAttribute("value", " value=\"", 6007, "\"", 6032, 1);
#nullable restore
#line 123 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Users\Views\DoctorProfile\AddorEdit.cshtml"
WriteAttributeValue("", 6015, type.CountryCode, 6015, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 123 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Users\Views\DoctorProfile\AddorEdit.cshtml"
                                                                              Write(type.Country1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 124 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Users\Views\DoctorProfile\AddorEdit.cshtml"

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
            BeginWriteAttribute("value", " value=\"", 6682, "\"", 6706, 1);
#nullable restore
#line 140 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Users\Views\DoctorProfile\AddorEdit.cshtml"
WriteAttributeValue("", 6690, Model.CompanyId, 6690, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n");
#nullable restore
#line 142 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Users\Views\DoctorProfile\AddorEdit.cshtml"
                                 foreach (var type in Model.companies)
                                {

                                    if (type.CompanyId == Model.CompanyId)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <option selected");
            BeginWriteAttribute("value", " value=\"", 6992, "\"", 7015, 1);
#nullable restore
#line 147 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Users\Views\DoctorProfile\AddorEdit.cshtml"
WriteAttributeValue("", 7000, type.CompanyId, 7000, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 147 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Users\Views\DoctorProfile\AddorEdit.cshtml"
                                                                            Write(type.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 148 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Users\Views\DoctorProfile\AddorEdit.cshtml"


                                    }
                                    else
                                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <option selected");
            BeginWriteAttribute("value", " value=\"", 7220, "\"", 7243, 1);
#nullable restore
#line 154 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Users\Views\DoctorProfile\AddorEdit.cshtml"
WriteAttributeValue("", 7228, type.CompanyId, 7228, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 154 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Users\Views\DoctorProfile\AddorEdit.cshtml"
                                                                            Write(type.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 155 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Users\Views\DoctorProfile\AddorEdit.cshtml"

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
                    <div class=""col-md-2 align-self-center""><label asp-for=""Mobile"" class=""col-md-4 text-right"">Password</label></div>
                    <div class=""col-md-4 align-self-cente"">
                        <input name=""Password"" id=""Password"" placeholder=""Password"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 7969, "\"", 7992, 1);
#nullable restore
#line 176 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Users\Views\DoctorProfile\AddorEdit.cshtml"
WriteAttributeValue("", 7977, Model.Password, 7977, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                        <span asp-validation-for=""Password"" class=""text-danger""></span>

                    </div>

                    <div class=""col-md-2 align-self-center""><label asp-for=""UserSecret"" class=""col-md-4 text-right"">UserSecret</label></div>
                    <div class=""col-md-4 align-self-cente"">
                        <input name=""UserSecret"" id=""UserSecret"" placeholder=""UserSecret"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 8432, "\"", 8457, 1);
#nullable restore
#line 183 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Users\Views\DoctorProfile\AddorEdit.cshtml"
WriteAttributeValue("", 8440, Model.UserSecret, 8440, 17, false);

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
            BeginWriteAttribute("value", " value=\"", 9042, "\"", 9071, 1);
#nullable restore
#line 197 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Users\Views\DoctorProfile\AddorEdit.cshtml"
WriteAttributeValue("", 9050, Model.UserDynamickey, 9050, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                        <span asp-validation-for=""UserDynamickey"" class=""text-danger""></span>

                    </div>

                    <div class=""col-md-2 align-self-center""><label asp-for=""Profilecol"" class=""col-md-4 text-right"">Profilecol</label></div>
                    <div class=""col-md-4 align-self-cente"">
                        <input name=""Profilecol"" id=""Profilecol"" placeholder=""Profilecol"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 9517, "\"", 9542, 1);
#nullable restore
#line 204 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Users\Views\DoctorProfile\AddorEdit.cshtml"
WriteAttributeValue("", 9525, Model.Profilecol, 9525, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                        <span asp-validation-for=\"Profilecol\" class=\"text-danger\"></span>\r\n\r\n                    </div>\r\n\r\n                </div>\r\n\r\n            </div>\r\n\r\n\r\n\r\n        </form>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 220 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Users\Views\DoctorProfile\AddorEdit.cshtml"
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
