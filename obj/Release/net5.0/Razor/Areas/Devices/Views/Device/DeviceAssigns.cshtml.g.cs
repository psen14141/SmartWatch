#pragma checksum "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Devices\Views\Device\DeviceAssigns.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66ecfd1e72966c742cb59bfd9931574893aaf4ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Devices_Views_Device_DeviceAssigns), @"mvc.1.0.view", @"/Areas/Devices/Views/Device/DeviceAssigns.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66ecfd1e72966c742cb59bfd9931574893aaf4ab", @"/Areas/Devices/Views/Device/DeviceAssigns.cshtml")]
    public class Areas_Devices_Views_Device_DeviceAssigns : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SmartWatch.Areas.Devices.Models.ViewModels.DeviceAssignViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Devices\Views\Device\DeviceAssigns.cshtml"
  
    ViewData["Title"] = "DeviceAssigns";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<p>\r\n\r\n    <a class=\"btn btn-primary mb-3\" href=\"#\"");
            BeginWriteAttribute("onclick", " onclick=\"", 241, "\"", 289, 3);
            WriteAttributeValue("", 251, "DeviceAssignAdd(0,", 251, 18, true);
#nullable restore
#line 12 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Devices\Views\Device\DeviceAssigns.cshtml"
WriteAttributeValue(" ", 269, ViewBag.deviceids, 270, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 288, ")", 288, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">Assign User</a>

</p>
<script>
    $(document).ready(function () {
        $('#dtDesign').DataTable();
        $('.dataTables_length').addClass('bs-select');
    });
</script>

<table id=""dtDesign"" class=""table table-striped table-bordered table-sm"" cellspacing=""0"" width=""100%"">
    <thead>
        <tr>
");
            WriteLiteral("            <th>\r\n                User Name\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 35 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Devices\Views\Device\DeviceAssigns.cshtml"
           Write(Html.DisplayNameFor(model => model.AssignDateStart));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 38 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Devices\Views\Device\DeviceAssigns.cshtml"
           Write(Html.DisplayNameFor(model => model.AssignDateEnd));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n");
            WriteLiteral("            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 47 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Devices\Views\Device\DeviceAssigns.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n");
            WriteLiteral("                <td>\r\n                    ");
#nullable restore
#line 57 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Devices\Views\Device\DeviceAssigns.cshtml"
               Write(Html.DisplayFor(modelItem => item.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 60 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Devices\Views\Device\DeviceAssigns.cshtml"
               Write(Html.DisplayFor(modelItem => item.AssignDateStart));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 63 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Devices\Views\Device\DeviceAssigns.cshtml"
               Write(Html.DisplayFor(modelItem => item.AssignDateEnd));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n");
            WriteLiteral("            <td>\r\n");
            WriteLiteral("                <a href=\"#\" class=\"btn btn-primary \"");
            BeginWriteAttribute("onclick", " onclick=\"", 2610, "\"", 2672, 5);
            WriteAttributeValue("", 2620, "DeviceAssignAdd(", 2620, 16, true);
#nullable restore
#line 72 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Devices\Views\Device\DeviceAssigns.cshtml"
WriteAttributeValue("", 2636, item.ConnectNo, 2636, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2651, ",", 2651, 1, true);
#nullable restore
#line 72 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Devices\Views\Device\DeviceAssigns.cshtml"
WriteAttributeValue(" ", 2652, ViewBag.deviceids, 2653, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2671, ")", 2671, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Edit</a>\r\n\r\n                <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 2728, "\"", 2783, 2);
            WriteAttributeValue("", 2735, "/Devices/Device/DeviceStatus/?Id=", 2735, 33, true);
#nullable restore
#line 74 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Devices\Views\Device\DeviceAssigns.cshtml"
WriteAttributeValue("", 2768, item.ConnectNo, 2768, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Connection Status</a>\r\n                <input type=\"button\" class=\"btn btn-danger\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2867, "\"", 2953, 3);
            WriteAttributeValue("", 2877, "DeleteConfirmation(\'/Devices/Device/DeviceAssignDelete/?Id=", 2877, 59, true);
#nullable restore
#line 75 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Devices\Views\Device\DeviceAssigns.cshtml"
WriteAttributeValue("", 2936, item.ConnectNo, 2936, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2951, "\')", 2951, 2, true);
            EndWriteAttribute();
            WriteLiteral(" value=\" Delete \" />\r\n            </td>\r\n            </tr>\r\n");
#nullable restore
#line 78 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\Devices\Views\Device\DeviceAssigns.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>

<div id=""DeviceAssignAdd"" class=""modal"" tabindex=""-1"" role=""dialog"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Device Assign</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"" id=""formArea"">

            </div>
            <div class=""modal-footer"">
                <button type=""button"" onclick=""SaveDeviceAssign()"" class=""btn btn-primary"">Save</button>
                <button type=""button"" class=""btn btn-primary"" data-dismiss=""modal"">Close</button>
            </div>
        </div>
    </div>
</div>


<script>
    function DeviceAssignAdd(id, deviceids) {
        $('#DeviceAssignAdd').modal(); //open the model
        $(""#formArea"").html(""""); // Clear existi");
            WriteLiteral(@"ng are
        $.ajax({
            method: ""GET"",
            //url: ""/Devices/Device/DeviceAssignAdd/?deviceids="" + id,
            url: ""/Devices/Device/DeviceAssignAdd/?Id="" + id + ""&deviceids="" + deviceids,

        })
            .done(function (msg) {
                $(""#formArea"").html(msg);

            });
    }


    function SaveDeviceAssign() {
        let postData = new FormData();
        postData.append('ConnectNo', $(""#ConnectNo"").val());
        postData.append('DeviceId', $(""#DeviceId"").val());
        postData.append('UserId', $(""#UserId"").val());
        postData.append('AssignDateStart', $(""#AssignDateStart"").val());
        postData.append('AssignDateEnd', $(""#AssignDateEnd"").val());

        $.ajax({
            method: ""POST"",
            url: ""/Devices/Device/SaveDeviceAssign/"",
            data: postData,
            contentType: false,
            processData: false,
        }).done(function (data) {
            $('#AddorEdit').modal('hide')
          ");
            WriteLiteral("  location.reload();\r\n        });\r\n    }\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SmartWatch.Areas.Devices.Models.ViewModels.DeviceAssignViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
