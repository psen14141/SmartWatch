#pragma checksum "D:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\StepCountt\Views\StepCount\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad332ec9261dd2b1af08ea2ce18cd8d467ea9726"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_StepCountt_Views_StepCount_Index), @"mvc.1.0.view", @"/Areas/StepCountt/Views/StepCount/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad332ec9261dd2b1af08ea2ce18cd8d467ea9726", @"/Areas/StepCountt/Views/StepCount/Index.cshtml")]
    public class Areas_StepCountt_Views_StepCount_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SmartWatch.Areas.StepCountt.Models.StepCountAPIRequest>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\StepCountt\Views\StepCount\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<script src=\"https://cdnjs.cloudflare.com/ajax/libs/jquery/1.7/jquery.min.js\"></script>\r\n\r\n<h1>Index</h1>\r\n\r\n");
            WriteLiteral("<!--");
#nullable restore
#line 42 "D:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\StepCountt\Views\StepCount\Index.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" |
<a asp-action=""Index"">Back to List</a>-->
<!--</div>-->

<div class=""row"">
    <div class=""column"">
        <div class=""column"">
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
                   ");
            WriteLiteral(@"             'rgba(255, 159, 64, 0.2)'
                            ],
                            borderColor: [
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
    </div>

  ");
            WriteLiteral(@"  <div class=""column"">
        <div class=""column""></div>
        <div class=""column""></div>
    </div>
</div>

<script src=""https://code.jquery.com/jquery-3.3.1.min.js""></script>
<script src=""https://cdn.jsdelivr.net/npm/chart.js@2.8.0/dist/Chart.min.js""></script>
<canvas id=""myChart"" width=""400"" height=""400""></canvas>
<script>
    function grab() {
        /* Promise to make sure data loads */
        return new Promise((resolve, reject) => {
            $.ajax({
                url: ""/StepCountt/StepCount/GetData"",
                method: ""GET"",
                dataType: 'JSON',
                success: function (data) {
                    //alert(JSON.stringify(data));
                    resolve(data);
                },
                error: function (error) {
                    reject(error);
                }
            })
        })
    }

    $(document).ready(function () {
        grab().then((data) => {
            console.log('Recieved our data', data);
        ");
            WriteLiteral(@"    alert(JSON.stringify(data));
            let regions = [];
            let value = [];

            try {
                data.forEach((item) => {
                    regions.push(item.REGION)
                    value.push(item.REV_VALUE)
                });

                let chartdata = {
                    labels: [...regions],
                    datasets: [{
                        label: 'Region',
                        backgroundColor: 'rgba(200, 200, 200, 0.75)',
                        borderColor: 'rgba(200, 200, 200, 0.75)',
                        hoverBackgroundColor: 'rgba(200, 200, 200, 1)',
                        hoverBorderColor: 'rgba(200, 200, 200, 1)',
                        data: [...value]
                    }]
                };

                let ctx = $(""#myChart"");

                let barGraph = new Chart(ctx, {
                    type: 'bar',
                    data: chartdata
                });

            } catch (error) {
         ");
            WriteLiteral("       console.log(\'Error parsing JSON data\', error)\r\n            }\r\n\r\n        }).catch((error) => {\r\n            console.log(error);\r\n        })\r\n    });\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SmartWatch.Areas.StepCountt.Models.StepCountAPIRequest> Html { get; private set; }
    }
}
#pragma warning restore 1591