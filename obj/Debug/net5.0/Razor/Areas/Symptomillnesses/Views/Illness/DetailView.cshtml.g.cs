#pragma checksum "D:\ProstyleTechnology\SmartWatch\Solution\SmartWatch\Areas\Symptomillnesses\Views\Illness\DetailView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3a81b134698cce8674980f956bdfa0ad59da1b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Symptomillnesses_Views_Illness_DetailView), @"mvc.1.0.view", @"/Areas/Symptomillnesses/Views/Illness/DetailView.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3a81b134698cce8674980f956bdfa0ad59da1b6", @"/Areas/Symptomillnesses/Views/Illness/DetailView.cshtml")]
    public class Areas_Symptomillnesses_Views_Illness_DetailView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SmartWatch.Areas.Symptomillnesses.Models.ViewModels.IllnessViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\ProstyleTechnology\SmartWatch\Solution\SmartWatch\Areas\Symptomillnesses\Views\Illness\DetailView.cshtml"
  
    ViewData["Title"] = "DetailView";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<meta name=""viewport"" content=""width=device-width, initial-scale=1"">
<link rel=""stylesheet"" href=""https://www.w3schools.com/w3css/4/w3.css"">
<link rel=""stylesheet"" href=""https://www.w3schools.com/w3css/4/w3.css"">
<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"">


<div class=""w3-padding w3-white"">
    <div>
        <button class=""w3-button w3-green"" onclick=""goBack()""><i class=""fa fa-arrow-left""></i></button>
        <button class=""w3-button w3-light-green"" onclick=""updateDiv()""><i class=""fa fa-refresh""></i></button>
");
            WriteLiteral(@"        <button class=""w3-button w3-light-blue"" onclick=""PrintDiv()""><i class=""fa fa-print""></i></button>
    </div>
    <div>
        <a asp-action=""Create"" style=""font-size:15px; padding-left:10px"">戻る</a>
        <a asp-action=""Create"" style=""font-size:15px; padding-left:10px"">編集</a>
        <a asp-action=""Create"" style=""font-size:15px; padding-right:10px"">印刷</a>
    </div>
</div>

<div class=""w3-container w3-margin-top"">
    <h5 style=""text-align:center""><b><u>Detail View</u></b></h5>
</div>

<div id=""divcontent"">

    <dl class=""row"">

        <dt class=""col-sm-2"">
            病気
        </dt>
        <dd class=""col-sm-10"">
            ");
#nullable restore
#line 40 "D:\ProstyleTechnology\SmartWatch\Solution\SmartWatch\Areas\Symptomillnesses\Views\Illness\DetailView.cshtml"
       Write(Html.DisplayFor(model => model.IllNessName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            説明\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 46 "D:\ProstyleTechnology\SmartWatch\Solution\SmartWatch\Areas\Symptomillnesses\Views\Illness\DetailView.cshtml"
       Write(Html.DisplayFor(model => model.IllnessDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n");
            WriteLiteral("<script>\r\n    function goBack() {\r\n        window.location.href = \"/Symptomillnesses/Illness/Index\";\r\n    }\r\n</script>\r\n\r\n");
            WriteLiteral(@"<script>
    $(""input"").on(""keyup"", function () {
        var maxLength = $(this).attr(""maxlength"");
        if (maxLength == $(this).val().length) {
            alert(""Characters length exceeds the Limit, please input less than "" + maxLength + "" characters"");
        }
    })

    $(""textarea"").on(""keyup"", function () {
        var maxLength = $(this).attr(""maxlength"");
        if (maxLength == $(this).val().length) {
            alert(""Characters length exceeds the Limit, please input less than "" + maxLength + "" characters"");
        }
    })
</script>
    </script>-->
");
            WriteLiteral(@"<script type=""text/javascript"">
    function PrintDiv() {
        var divContents = document.getElementById(""divcontent"").innerHTML;
        var printWindow = window.open('', '', 'height=200,width=400');
        printWindow.document.write('<html><head><title>Print DIV Content</title>');
        printWindow.document.write('</head><body >');
        printWindow.document.write(divContents);
        printWindow.document.write('</body></html>');
        printWindow.document.close();
        printWindow.print();
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SmartWatch.Areas.Symptomillnesses.Models.ViewModels.IllnessViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591