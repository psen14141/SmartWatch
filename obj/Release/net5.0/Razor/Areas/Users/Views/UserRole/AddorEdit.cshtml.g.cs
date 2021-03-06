#pragma checksum "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Users\Views\UserRole\AddorEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b5234d679c998ca3ede33574cfae1b68250f6fa7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Users_Views_UserRole_AddorEdit), @"mvc.1.0.view", @"/Areas/Users/Views/UserRole/AddorEdit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5234d679c998ca3ede33574cfae1b68250f6fa7", @"/Areas/Users/Views/UserRole/AddorEdit.cshtml")]
    public class Areas_Users_Views_UserRole_AddorEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SmartWatch.Areas.Users.Models.ViewModels.RoleViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Users\Views\UserRole\AddorEdit.cshtml"
  
    ViewData["Title"] = "AddorEdit";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n\r\n        <form method=\"post\" action=\"/Users/UserRole/SaveRole\">\r\n\r\n            <input name=\"RoleId\" id=\"RoleId\" type=\"hidden\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 307, "\"", 328, 1);
#nullable restore
#line 12 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Users\Views\UserRole\AddorEdit.cshtml"
WriteAttributeValue("", 315, Model.RoleId, 315, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>



            <div class=""form-group"">
                <div class=""row"">
                    <div class=""col-md-3 align-self-center""><label asp-for=""RoleName"" class=""col-md-4 text-right"">Role Name</label></div>
                    <div class=""col-md-5 align-self-cente"">
                        <input name=""RoleName"" placeholder=""Role Name"" id=""RoleName"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 798, "\"", 821, 1);
#nullable restore
#line 21 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Users\Views\UserRole\AddorEdit.cshtml"
WriteAttributeValue("", 806, Model.RoleName, 806, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                        <span asp-validation-for=""RoleName"" class=""text-danger""></span>
                    </div>
                </div>
            </div>

            <div class=""form-group"">
                <div class=""row"">
                    <div class=""col-md-3 align-self-center""><label asp-for=""CreatedAt"" class=""col-md-4 text-right"">CreatedAt</label></div>
                    <div class=""col-md-5 align-self-cente"">
                        <input type=""text"" class=""form-control"" id=""CreatedAt"" name=""CreatedAt"" placeholder=""Created Date and Time""");
            BeginWriteAttribute("value", " value=\'", 1395, "\'", 1451, 1);
#nullable restore
#line 31 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Users\Views\UserRole\AddorEdit.cshtml"
WriteAttributeValue("", 1403, Model.CreatedAt.ToString("yyyy/MM/dd HH:mm:ss"), 1403, 48, false);

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
                    <div class=""col-md-3 align-self-center""><label asp-for=""UpdatedAt"" class=""col-md-4 text-right"">UpdatedAt</label></div>
                    <div class=""col-md-5 align-self-cente"">
                        <input type=""text"" class=""form-control"" id=""UpdatedAt"" name=""UpdatedAt"" placeholder=""Updated Date and Time""");
            BeginWriteAttribute("value", " value=\'", 2088, "\'", 2144, 1);
#nullable restore
#line 44 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Users\Views\UserRole\AddorEdit.cshtml"
WriteAttributeValue("", 2096, Model.UpdatedAt.ToString("yyyy/MM/dd HH:mm:ss"), 2096, 48, false);

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
                    <div class=""col-md-3 align-self-center""><label asp-for=""IsActive"" class=""col-md-4 text-right"">IsActive</label></div>

                    <div class=""col-md-2 align-self-cente"">
                        <input type=""checkbox"" class=""form-control fa-align-left"" name=""IsActive"" id=""IsActive"" value=""false"" />
                    </div>


                    <script>
                        $('#checkbox-value').text($('#IsActive').val());

                        $(""#IsActive"").on('change', function () {
                            if ($(this).is(':checked')) {
                                $(this).attr('value', 'true');
                            } else {
                       ");
            WriteLiteral(@"         $(this).attr('value', 'false');
                            }

                            $('#checkbox-value').text($('#IsActive').val());
                        });
                    </script>

                </div>
            </div>

            <div class=""form-group"">
                <div class=""row"">
                    <div class=""col-md-3 align-self-center""><label asp-for=""IsSystem"" class=""col-md-4 text-right"">IsSystem</label></div>

                    <div class=""col-md-2 align-self-cente"">
                        <input type=""checkbox"" class=""form-control fa-align-left"" name=""IsSystem"" id=""IsSystem"" value=""false"" />
                    </div>


                    <script>
                        $('#checkbox-value').text($('#IsSystem').val());

                        $(""#IsSystem"").on('change', function () {
                            if ($(this).is(':checked')) {
                                $(this).attr('value', 'true');
                            } e");
            WriteLiteral(@"lse {
                                $(this).attr('value', 'false');
                            }

                            $('#checkbox-value').text($('#IsSystem').val());
                        });
                    </script>

                </div>
            </div>

            <div class=""form-group"">
                <div class=""row"">
                    <div class=""col-md-3 align-self-center""><label asp-for=""IsSuperadmin"" class=""col-md-4 text-right"">IsSuperadmin</label></div>

                    <div class=""col-md-2 align-self-cente"">
                        <input type=""checkbox"" class=""form-control fa-align-left"" name=""IsSuperadmin"" id=""IsSuperadmin"" value=""false"" />
                    </div>


                    <script>
                        $('#checkbox-value').text($('#IsSuperadmin').val());

                        $(""#IsSuperadmin"").on('change', function () {
                            if ($(this).is(':checked')) {
                                $(this).a");
            WriteLiteral(@"ttr('value', 'true');
                            } else {
                                $(this).attr('value', 'false');
                            }

                            $('#checkbox-value').text($('#IsSuperadmin').val());
                        });
                    </script>

                </div>
            </div>

            <div class=""form-group"">
                <div class=""row"">
                    <div class=""col-md-3 align-self-center""><label asp-for=""IsClientRoot"" class=""col-md-4 text-right"">IsClientRoot</label></div>

                    <div class=""col-md-2 align-self-cente"">
                        <input type=""checkbox"" class=""form-control fa-align-left"" name=""IsClientRoot"" id=""IsClientRoot"" value=""false"" />
                    </div>


                    <script>
                        $('#checkbox-value').text($('#IsClientRoot').val());

                        $(""#IsClientRoot"").on('change', function () {
                            if ($(this).is");
            WriteLiteral(@"(':checked')) {
                                $(this).attr('value', 'true');
                            } else {
                                $(this).attr('value', 'false');
                            }

                            $('#checkbox-value').text($('#IsClientRoot').val());
                        });
                    </script>

                </div>
            </div>

            <div class=""form-group"">
                <div class=""row"">
                    <div class=""col-md-3 align-self-center""><label asp-for=""IsClient"" class=""col-md-4 text-right"">IsClient</label></div>

                    <div class=""col-md-2 align-self-cente"">
                        <input type=""checkbox"" class=""form-control fa-align-left"" name=""IsClient"" id=""IsClient"" value=""false"" />
                    </div>


                    <script>
                        $('#checkbox-value').text($('#IsClient').val());

                        $(""#IsClient"").on('change', function () {
        ");
            WriteLiteral(@"                    if ($(this).is(':checked')) {
                                $(this).attr('value', 'true');
                            } else {
                                $(this).attr('value', 'false');
                            }

                            $('#checkbox-value').text($('#IsClient').val());
                        });
                    </script>

                </div>
            </div>

           

        </form>
    </div>
</div>

<script src=""/assets/js/plugin/datepicker/bootstrap-datetimepicker.min.js""></script>
<script>

    $('#CreatedAt').datetimepicker({
        format: 'YYYY/MM/DD HH:mm',

    });
    $('#UpdatedAt').datetimepicker({
        format: 'YYYY/MM/DD HH:mm',
    });

</script>


");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 204 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Users\Views\UserRole\AddorEdit.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SmartWatch.Areas.Users.Models.ViewModels.RoleViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
