#pragma checksum "E:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\BloodPressur\Views\Blood\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5e45d652fb799a9d946716e58e23d9b410668ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_BloodPressur_Views_Blood_Index), @"mvc.1.0.view", @"/Areas/BloodPressur/Views/Blood/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5e45d652fb799a9d946716e58e23d9b410668ec", @"/Areas/BloodPressur/Views/Blood/Index.cshtml")]
    public class Areas_BloodPressur_Views_Blood_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SmartWatch.DbModels.BloodPressure>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\BloodPressur\Views\Blood\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<div>\r\n    <h4>BloodPressure</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "E:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\BloodPressur\Views\Blood\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.BloodPressureId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "E:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\BloodPressur\Views\Blood\Index.cshtml"
       Write(Html.DisplayFor(model => model.BloodPressureId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "E:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\BloodPressur\Views\Blood\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.UserId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "E:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\BloodPressur\Views\Blood\Index.cshtml"
       Write(Html.DisplayFor(model => model.UserId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "E:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\BloodPressur\Views\Blood\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.ConnectionId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "E:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\BloodPressur\Views\Blood\Index.cshtml"
       Write(Html.DisplayFor(model => model.ConnectionId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "E:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\BloodPressur\Views\Blood\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Checkedtime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "E:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\BloodPressur\Views\Blood\Index.cshtml"
       Write(Html.DisplayFor(model => model.Checkedtime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "E:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\BloodPressur\Views\Blood\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.BloodPressureUpper));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "E:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\BloodPressur\Views\Blood\Index.cshtml"
       Write(Html.DisplayFor(model => model.BloodPressureUpper));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "E:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\BloodPressur\Views\Blood\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.BloodPreesureLower));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "E:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\BloodPressur\Views\Blood\Index.cshtml"
       Write(Html.DisplayFor(model => model.BloodPreesureLower));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 51 "E:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\BloodPressur\Views\Blood\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.DeviceTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 54 "E:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\BloodPressur\Views\Blood\Index.cshtml"
       Write(Html.DisplayFor(model => model.DeviceTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
#nullable restore
#line 59 "E:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\BloodPressur\Views\Blood\Index.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" |
    <a asp-action=""Index"">Back to List</a>
</div>
<canvas id=""myChart"" width=""400"" height=""400""></canvas>
<script>
                var ctx = document.getElementById('myChart').getContext('2d');
                var myChart = new Chart(ctx, {
                    type: 'line',
                    data: {
                        labels: ['Red', 'Blue', 'Yellow', 'Green', 'Purple', 'Orange'],
                        datasets: [{
                            label: '# of Votes',
                            data: [12, 19, 3, 5, 2, 3],
                            backgroundColor: [
                                'rgba(255, 99, 132, 0.2)',
                                'rgba(54, 162, 235, 0.2)',
                                'rgba(255, 206, 86, 0.2)',
                                'rgba(75, 192, 192, 0.2)',
                                'rgba(153, 102, 255, 0.2)',
                                'rgba(255, 159, 64, 0.2)'
                            ],
                            borderC");
            WriteLiteral(@"olor: [
                                'rgba(255, 99, 132, 1)',
                                'rgba(54, 162, 235, 1)',
                                'rgba(255, 206, 86, 1)',
                                'rgba(75, 192, 192, 1)',
                                'rgba(153, 102, 255, 1)',
                                'rgba(255, 159, 64, 1)'
                            ],
                            borderWidth: 1
                        }]
                    },
                    options: {
                        scales: {
                            yAxes: [{
                                ticks: {
                                    beginAtZero: true
                                }
                            }]
                        }
                    }
                });
</script>
        </div>
<div class=""column""></div>
    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SmartWatch.DbModels.BloodPressure> Html { get; private set; }
    }
}
#pragma warning restore 1591