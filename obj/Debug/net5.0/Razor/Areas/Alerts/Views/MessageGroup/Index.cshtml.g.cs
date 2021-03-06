#pragma checksum "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Alerts\Views\MessageGroup\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18b8d43cf104cdb6024939b138add7988b56136f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Alerts_Views_MessageGroup_Index), @"mvc.1.0.view", @"/Areas/Alerts/Views/MessageGroup/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18b8d43cf104cdb6024939b138add7988b56136f", @"/Areas/Alerts/Views/MessageGroup/Index.cshtml")]
    public class Areas_Alerts_Views_MessageGroup_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SmartWatch.DbModels.MessageGroup>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Alerts\Views\MessageGroup\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h5>Message Groups</h5>
<script>
    $(document).ready(function () {
        $('#dtDesign').DataTable();
        $('.dataTables_length').addClass('bs-select');
    });
</script>

<p>

    <a class=""btn btn-primary mb-3"" href=""#"" onclick=""AddorEdit(0)"">New Message Group</a>

</p>
<table id=""dtDesign"" class=""table table-striped table-bordered table-sm"" cellspacing=""0"" width=""100%"">
    <thead>
        <tr>
            <th>
                ");
#nullable restore
#line 25 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Alerts\Views\MessageGroup\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.GroupId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Alerts\Views\MessageGroup\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n");
            WriteLiteral("            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 37 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Alerts\Views\MessageGroup\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 41 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Alerts\Views\MessageGroup\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.GroupId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 44 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Alerts\Views\MessageGroup\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n");
            WriteLiteral("                <td>\r\n                    <a href=\"#\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1412, "\"", 1446, 3);
            WriteAttributeValue("", 1422, "AddorEdit(", 1422, 10, true);
#nullable restore
#line 50 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Alerts\Views\MessageGroup\Index.cshtml"
WriteAttributeValue("", 1432, item.GroupId, 1432, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1445, ")", 1445, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Edit</a>\r\n\r\n\r\n                    <input type=\"button\" class=\"btn btn-danger\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1549, "\"", 1626, 3);
            WriteAttributeValue("", 1559, "DeleteConfirmation(\'/Alerts/MessageGroup/Delete/?Id=", 1559, 52, true);
#nullable restore
#line 53 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Alerts\Views\MessageGroup\Index.cshtml"
WriteAttributeValue("", 1611, item.GroupId, 1611, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1624, "\')", 1624, 2, true);
            EndWriteAttribute();
            WriteLiteral(" value=\" Delete \" />\r\n\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 57 "D:\.NET Daiki Vedios\SMARTWATCH\Solution\SmartWatch\Areas\Alerts\Views\MessageGroup\Index.cshtml"
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
                <h5 class=""modal-title"">Message Groups</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"" id=""formArea"">

            </div>
            <div class=""modal-footer"">
                <button type=""button"" onclick=""SaveMessageGroup()"" class=""btn btn-primary"">Save changes</button>
                <button type=""button"" class=""btn btn-primary"" data-dismiss=""modal"">Close</button>
            </div>
        </div>
    </div>
</div>

<script>
    function AddorEdit(id) {
        $('#AddorEdit').modal(); //open the model
        $(""#formArea"").html(""""); // Clear existing are

        $.aj");
            WriteLiteral(@"ax({
            method: ""GET"",
            url: ""/Alerts/MessageGroup/AddorEdit/"" + id,

        })
            .done(function (msg) {
                $(""#formArea"").html(msg);

            });
    }


    function SaveMessageGroup() {

        let postData = new FormData();
        postData.append('GroupId', $(""#GroupId"").val());
        postData.append('Name', $(""#Name"").val());
       
        $.ajax({
            method: ""POST"",
            url: ""/Alerts/MessageGroup/SaveMessageGroup/"",
            data: postData,
            contentType: false,
            processData: false,
        }).done(function (data) {
            $('#AddorEdit').modal('hide')
            location.reload();
        });
    }
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SmartWatch.DbModels.MessageGroup>> Html { get; private set; }
    }
}
#pragma warning restore 1591
