#pragma checksum "D:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\Devices\Views\Device\DeviceStatus.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "527791db87fbaf9f352f3771bf5eb9637b4515e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Devices_Views_Device_DeviceStatus), @"mvc.1.0.view", @"/Areas/Devices/Views/Device/DeviceStatus.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"527791db87fbaf9f352f3771bf5eb9637b4515e9", @"/Areas/Devices/Views/Device/DeviceStatus.cshtml")]
    public class Areas_Devices_Views_Device_DeviceStatus : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SmartWatch.DbModels.ConnectionStatus>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\Devices\Views\Device\DeviceStatus.cshtml"
  
    ViewData["Title"] = "DeviceStatus";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h5>DeviceStatus</h5>\r\n\r\n<p>\r\n    <a class=\"btn btn-primary mb-3\" href=\"#\"");
            BeginWriteAttribute("onclick", " onclick=\"", 233, "\"", 281, 3);
            WriteAttributeValue("", 243, "DeviceStatusChanges(0,", 243, 22, true);
#nullable restore
#line 12 "D:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\Devices\Views\Device\DeviceStatus.cshtml"
WriteAttributeValue("", 265, ViewBag.connId, 265, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 280, ")", 280, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">Add Connection status</a>
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
            <th>
                Status
            </th>
            <th>
                Sync Start Time
            </th>
            <th>
                Sync EndTime
            </th>
");
            WriteLiteral("            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 42 "D:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\Devices\Views\Device\DeviceStatus.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 46 "D:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\Devices\Views\Device\DeviceStatus.cshtml"
               Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 49 "D:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\Devices\Views\Device\DeviceStatus.cshtml"
               Write(Html.DisplayFor(modelItem => item.SyncPeriodStartTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 52 "D:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\Devices\Views\Device\DeviceStatus.cshtml"
               Write(Html.DisplayFor(modelItem => item.SyncPeriodEndTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n");
            WriteLiteral("            <td>\r\n                <a href=\"#\" class=\"btn btn-primary \"");
            BeginWriteAttribute("onclick", " onclick=\"", 1599, "\"", 1671, 5);
            WriteAttributeValue("", 1609, "DeviceStatusChanges(", 1609, 20, true);
#nullable restore
#line 58 "D:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\Devices\Views\Device\DeviceStatus.cshtml"
WriteAttributeValue("", 1629, item.ConnectionstatusId, 1629, 24, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1653, ",", 1653, 1, true);
#nullable restore
#line 58 "D:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\Devices\Views\Device\DeviceStatus.cshtml"
WriteAttributeValue(" ", 1654, ViewBag.connId, 1655, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1670, ")", 1670, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Edit</a>\r\n");
            WriteLiteral("                <input type=\"button\" class=\"btn btn-danger\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1935, "\"", 2034, 3);
            WriteAttributeValue("", 1945, "DeleteConfirmation(\'/Devices/Device/DeviceConnectionDelete/?Id=", 1945, 63, true);
#nullable restore
#line 61 "D:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\Devices\Views\Device\DeviceStatus.cshtml"
WriteAttributeValue("", 2008, item.ConnectionstatusId, 2008, 24, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2032, "\')", 2032, 2, true);
            EndWriteAttribute();
            WriteLiteral(" value=\" Delete \" />\r\n            </td>\r\n            </tr>\r\n");
#nullable restore
#line 64 "D:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\Devices\Views\Device\DeviceStatus.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>

<div id=""DeviceStatusChanges"" class=""modal"" tabindex=""-1"" role=""dialog"">
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
    function DeviceStatusChanges(id, connId) {
        $('#DeviceStatusChanges').modal(); //open the model
        $(""#f");
            WriteLiteral(@"ormArea"").html(""""); // Clear existing are

        $.ajax({
            method: ""GET"",
            //url: ""/Devices/Device/DeviceStatusChanges/"" + id,
            url: ""/Devices/Device/DeviceStatusChanges/?Id="" + id + ""&connId="" + connId,
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
            url: ""/Devices/Device/SaveConnectionStatus/"",
            data: postData,
            contentType: false,
            processData: false,
        }).done(");
            WriteLiteral("function (data) {\r\n            $(\'#DeviceStatusChanges\').modal(\'hide\')\r\n            location.reload();\r\n        });\r\n    }\r\n</script>\r\n");
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
