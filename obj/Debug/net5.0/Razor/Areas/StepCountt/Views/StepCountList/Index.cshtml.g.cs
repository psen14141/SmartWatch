#pragma checksum "D:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\StepCountt\Views\StepCountList\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "895c444bcccaf88c7658164dfcbfcfdcc935578f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_StepCountt_Views_StepCountList_Index), @"mvc.1.0.view", @"/Areas/StepCountt/Views/StepCountList/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"895c444bcccaf88c7658164dfcbfcfdcc935578f", @"/Areas/StepCountt/Views/StepCountList/Index.cshtml")]
    public class Areas_StepCountt_Views_StepCountList_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SmartWatch.DbModels.Profile>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\ProstyleTechnology\smart-watch\Solution\SmartWatch\Areas\StepCountt\Views\StepCountList\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h3>Patients Step Count</h3>


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
                Patient Name
            </th>

            <th>
                Contact Number
            </th>
");
            WriteLiteral("            <th>\r\n                Daily Step Count\r\n            </th>\r\n");
            WriteLiteral(@"            <th>
                View Details
            </th>
        </tr>
    </thead>
    <tbody id=""PatientDashboard"">
    </tbody>
</table>

<script type=""text/javascript"">
    getData();


    function getData() {
        var json_url = ""/StepCountt/StepCountList/PatientsDetailsView"";
        var data1 = data1 || {};

        $.getJSON(json_url, data1).done(function (patient) {

            $(""#PatientDashboard"").empty();
            for (i = 0; i < patient.length; i++) {

                //var fillbpu = getBloodPUpper(patient[i].bloodPressureUpper);
                //var fillbpl = getBloodPLower(patient[i].bloodPressureLower);
                //var fillhr  = getHeartRate(patient[i].PulseRate);
                //var fillbt  = getBodytemp(patient[i].Temperature);
                var fillsc = getStepsCount(patient[i].Steps);

                $(""#PatientDashboard"").append(""<tr><td>"" + patient[i].Username + ""</td><td>"" + patient[i].Mobile + ""</td><td>"" + fillsc + ""</td><td><but");
            WriteLiteral(@"ton type='button' class='btn btn-primary' onclick='sendPatientDetailView("" + patient[i].UserId + "")'>View</button></td></tr>"");
            }
            setTimeout(getData, 1000);

        });

    }


    function getStepsCount(sc) {

        var fillsc;
        if (sc < 8000) {

            fillsc = fillColor(""#ffd966"", sc);
        } else if (sc >= 8000 && sc < 12000) {

            fillsc = fillColor(""#00b050"", sc);
        } else if (sc >= 12000) {

            fillsc = fillColor(""#ffd966"", sc);
        }
        return fillsc;
    }
    function fillColor(colorcode, value) {
        var tag = ""<b><p style='font-size: 15px;color:"" + colorcode + "";'>"" + value + ""</p></b>"";
        return tag;
    }
    function sendPatientDetailView(userid) {

        window.location.href = ""/StepCountt/StepCount/Index/?userid="" + userid;

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SmartWatch.DbModels.Profile>> Html { get; private set; }
    }
}
#pragma warning restore 1591