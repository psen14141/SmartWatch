#pragma checksum "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Devices\Views\ConnectionStatus\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a76f8255dc6ffac4634af2feb67c8bf27c0b3be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Devices_Views_ConnectionStatus_Index), @"mvc.1.0.view", @"/Areas/Devices/Views/ConnectionStatus/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a76f8255dc6ffac4634af2feb67c8bf27c0b3be", @"/Areas/Devices/Views/ConnectionStatus/Index.cshtml")]
    public class Areas_Devices_Views_ConnectionStatus_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SmartWatch.DbModels.ConnectionStatus>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Devices\Views\ConnectionStatus\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h5>Connection Status</h5>
<script>
    $(document).ready(function () {
        $('#dtDesign').DataTable();
        $('.dataTables_length').addClass('bs-select');
    });
</script>

<p>

    <a class=""btn btn-primary mb-3"" href=""#"" onclick=""AddorEdit(0)"">New Connection Status</a>

</p>
<table id=""dtDesign"" class=""table table-striped table-bordered table-sm"" cellspacing=""0"" width=""100%"">
    <thead>
        <tr>
");
            WriteLiteral("            <th>\r\n                ");
#nullable restore
#line 28 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Devices\Views\ConnectionStatus\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ConnectId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Devices\Views\ConnectionStatus\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Devices\Views\ConnectionStatus\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.SyncPeriodStartTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 37 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Devices\Views\ConnectionStatus\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.SyncPeriodEndTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 43 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Devices\Views\ConnectionStatus\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n");
            WriteLiteral("                <td>\r\n                    ");
#nullable restore
#line 50 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Devices\Views\ConnectionStatus\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ConnectId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 53 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Devices\Views\ConnectionStatus\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 56 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Devices\Views\ConnectionStatus\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.SyncPeriodStartTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 59 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Devices\Views\ConnectionStatus\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.SyncPeriodEndTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <a href=\"#\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1903, "\"", 1948, 3);
            WriteAttributeValue("", 1913, "AddorEdit(", 1913, 10, true);
#nullable restore
#line 62 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Devices\Views\ConnectionStatus\Index.cshtml"
WriteAttributeValue("", 1923, item.ConnectionstatusId, 1923, 24, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1947, ")", 1947, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Edit</a>\r\n\r\n\r\n                    <input type=\"button\" class=\"btn btn-danger\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2051, "\"", 2144, 3);
            WriteAttributeValue("", 2061, "DeleteConfirmation(\'/Devices/ConnectionStatus/Delete/?Id=", 2061, 57, true);
#nullable restore
#line 65 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Devices\Views\ConnectionStatus\Index.cshtml"
WriteAttributeValue("", 2118, item.ConnectionstatusId, 2118, 24, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2142, "\')", 2142, 2, true);
            EndWriteAttribute();
            WriteLiteral(" value=\" Delete \" />\r\n\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 69 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Devices\Views\ConnectionStatus\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>

<div id=""AddorEdit"" class=""modal"" tabindex=""-1"" role=""dialog"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Connection Status Information</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"" id=""formArea"">

            </div>
            <div class=""modal-footer"">
                <button type=""button"" onclick=""SaveConnectionStatus()"" class=""btn btn-primary"">Save changes</button>
                <button type=""button"" class=""btn btn-primary"" data-dismiss=""modal"">Close</button>
            </div>
        </div>
    </div>
</div>

<script>
    function AddorEdit(id) {
        $('#AddorEdit').modal(); //open the model
        $(""#formArea"").html(""""); // Clear existing ");
            WriteLiteral(@"are

        $.ajax({
            method: ""GET"",
            url: ""/Devices/ConnectionStatus/AddorEdit/"" + id,

        })
            .done(function (msg) {
                $(""#formArea"").html(msg);

            });
    }


    function SaveConnectionStatus() {

        let postData = new FormData();
        postData.append('ConnectionstatusId', $(""#ConnectionstatusId"").val());
        postData.append('ConnectId', $(""#ConnectId"").val());
        postData.append('Status', $(""#Status"").val());
        postData.append('SyncPeriodStartTime', $(""#SyncPeriodStartTime"").val());
        postData.append('SyncPeriodEndTime', $(""#SyncPeriodEndTime"").val());

        $.ajax({
            method: ""POST"",
            url: ""/Devices/ConnectionStatus/SaveConnectionStatus/"",
            data: postData,
            contentType: false,
            processData: false,
        }).done(function (data) {
            $('#AddorEdit').modal('hide')
            location.reload();
        });
    }
</s");
            WriteLiteral("cript>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SmartWatch.DbModels.ConnectionStatus>> Html { get; private set; }
    }
}
#pragma warning restore 1591