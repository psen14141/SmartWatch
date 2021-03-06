#pragma checksum "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\BdyTemperature\Views\BodyTemperature\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf89258f9af7a7a8826014dee9cd355206db7dcb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_BdyTemperature_Views_BodyTemperature_Index), @"mvc.1.0.view", @"/Areas/BdyTemperature/Views/BodyTemperature/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf89258f9af7a7a8826014dee9cd355206db7dcb", @"/Areas/BdyTemperature/Views/BodyTemperature/Index.cshtml")]
    public class Areas_BdyTemperature_Views_BodyTemperature_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SmartWatch.DbModels.BodyTemperature>>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Bench\Daiki\ProstyleTechnology\15.SmartWatch\00.gitSP\Solution\SmartWatch\Areas\BdyTemperature\Views\BodyTemperature\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf89258f9af7a7a8826014dee9cd355206db7dcb3097", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"" src=""assets/js/jquery-3.4.0.min.js""></script>
    <!-- Bootstrap tooltips -->
    <script type=""text/javascript"" src=""assets/js/popper.min.js""></script>
    <!-- Bootstrap core JavaScript -->
    <script type=""text/javascript"" src=""assets/js/bootstrap.min.js""></script>
    <!-- MDB core JavaScript -->
    <script type=""text/javascript"" src=""assets/js/mdb.min.js""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<div class=""container"">
    <div class=""panel panel-primary"">
        <div class=""panel-heading"">
            <h3 class=""panel-title""><center>BODY TEMPERATURE VISULIZATION</h3>
        </div>

        <div class=""panel-body"">
            <canvas id=""lineChart""></canvas>
            <script>
                var today = new Date();
                var time = today.getHours() + "":"" + today.getMinutes() + "":"" + today.getSeconds();
                var ctxL = document.getElementById(""lineChart"").getContext('2d');
                var myLineChart = new Chart(ctxL, {
                    type: 'line',
                    data:
                    {
                        labels: [time],
                        datasets: [{
                            label: ""Body Temperature"",
                            fill: false,
                            lineTension: 0.1,
                            backgroundColor: ""rgba(75,192,192,0.4)"",
                            borderColor: ""rgba(255,0,0,1)"",
    ");
            WriteLiteral(@"                        borderCapStyle: 'butt',
                            borderDash: [],
                            borderDashOffset: 0.0,
                            borderJoinStyle: 'miter',
                            pointBorderColor: ""rgba(75,192,192,1)"",
                            pointBackgroundColor: ""#fff"",
                            pointBorderWidth: 1,
                            pointHoverRadius: 5,
                            pointHoverBackgroundColor: ""rgba(75,192,192,1)"",
                            pointHoverBorderColor: ""rgba(220,220,220,1)"",
                            pointHoverBorderWidth: 2,
                            pointRadius: 1,
                            pointHitRadius: 10,
                            data: [],
                            spanGaps: false,
                        }
                        ]
                    },
                    options:
                    {
                        responsive: true
                    }
            ");
            WriteLiteral(@"    });
                function add_data() {
                    var json_url = ""/BdyTemperature/BodyTemperature/GetBodyTemperatureData"";
                    var data1 = data1 || {};

                    $.getJSON(json_url, data1).done(function (response) {
                        //alert(JSON.stringify(response));
                        myLineChart.data.labels = response.labels;
                        myLineChart.data.datasets[0].data = response.data.bodyTemperature; // or you can iterate for multiple datasets
                        myLineChart.update(); // finally update our chart
                    });

                }
                setInterval(add_data, 1000); //milisecond
            </script>
        </div>
    </div>
</div>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SmartWatch.DbModels.BodyTemperature>> Html { get; private set; }
    }
}
#pragma warning restore 1591
