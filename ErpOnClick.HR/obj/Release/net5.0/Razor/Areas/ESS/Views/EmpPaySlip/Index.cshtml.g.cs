#pragma checksum "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpPaySlip\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c636a60bd9d9ee0de22104754db5fa96cea4f85c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_ESS_Views_EmpPaySlip_Index), @"mvc.1.0.view", @"/Areas/ESS/Views/EmpPaySlip/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpPaySlip\Index.cshtml"
using ErpOnClick.DAL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpPaySlip\Index.cshtml"
using ErpOnClick.ErpMain.Resources;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpPaySlip\Index.cshtml"
using ErpOnClick.ErpMain.Areas.ESS.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c636a60bd9d9ee0de22104754db5fa96cea4f85c", @"/Areas/ESS/Views/EmpPaySlip/Index.cshtml")]
    public class Areas_ESS_Views_EmpPaySlip_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpPaySlip\Index.cshtml"
  

    DateTime? PaySlipDate = Model.PaySlipDate;
    //var PaySlipDetails = Model.PaySlipDetails;


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("TabName", async() => {
                WriteLiteral("\r\n    Vacant jobs Setup\r\n");
            }
            );
            WriteLiteral(@"<style>
    .ui-datepicker-calendar {
        display: none;
    }

    .text {
        display: inline-block;
        padding: 0.5em 1em;
        min-width: 20em;
        line-height: 1.2em;
        background: #84ceeb;
        position: relative;
    }
</style>

<div class=""card card-default card-outline"">

    <div class=""card-header"">
        <div class=""row"">
            <div class=""col-md-3"">
                <h2 class=""card-title"">
                    ");
#nullable restore
#line 37 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpPaySlip\Index.cshtml"
               Write(SharedLocalizer.GetLocalizedHtmlString("Emp Pay Slip"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </h2>\r\n            </div>\r\n\r\n            <div class=\"col-md-3\">\r\n");
            WriteLiteral("                <input type=\"month\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 1193, "\"", 1288, 1);
#nullable restore
#line 43 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpPaySlip\Index.cshtml"
WriteAttributeValue("", 1201, PaySlipDate!=null ? PaySlipDate.Value.Year+"-"+PaySlipDate.Value.ToString("MM") : "", 1201, 87, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"PaySlipDate\" name=\"PaySlipDate\" />\r\n            </div>\r\n            <div class=\"col-md-4\">\r\n                <button class=\"btn  btn-sm btn-primary\" onclick=\"searchByDate()\"><i class=\"fal fa-search fa-fw\"></i>");
#nullable restore
#line 46 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpPaySlip\Index.cshtml"
                                                                                                               Write(SharedLocalizer.GetLocalizedHtmlString("Search"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                <a id=\"printPaySlip\"");
            BeginWriteAttribute("href", " href=\"", 1598, "\"", 1605, 0);
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\" class=\"btn btn-default btn-sm\"><i class=\"fal fa-print fa-fw\"></i>");
#nullable restore
#line 47 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpPaySlip\Index.cshtml"
                                                                                                                         Write(SharedLocalizer.GetLocalizedHtmlString("Print"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            </div>\r\n\r\n        </div>\r\n\r\n        <!-- /. tools -->\r\n    </div>\r\n    <div class=\"card-body\">\r\n\r\n        <div id=\"divList\"></div>\r\n\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        $(function () {
            BindGrid();

        });
        var applicationName = getApplicationName();

       
        function searchByDate() {
            //var date = $('#AttendanceDate').val();
            debugger;
            var paySlipDate = $('#PaySlipDate').val();

            //if (date == """") {
            if (paySlipDate == """") {
                showMsg('Enter !', '!Date First');
            }
            else {

                $.ajax({
                    url: applicationName + ""ESS/EmpPaySlip/_list"",
                    data: { date: paySlipDate },
                    success: function (data) {
                        window.location = applicationName + 'ESS/EmpPaySlip?paySlipDate=' + paySlipDate;
                    }
                });

                //    BindGrid(date);
            }


        };

        function BindGrid(paySlipDate) {
            paySlipDate = (paySlipDate == null ? $('#PaySlipDate').val() : paySlipDate);
 ");
                WriteLiteral(@"           $('#divList').html('<h5 class=""margin-0""><p><i class=""fal fa-spinner fa-spin fa-fw""></i> Please wait while data is loading...</p></h5>');
            $.ajax({
                url: applicationName + 'ESS/EmpPaySlip/_list',
                data: { date: paySlipDate },
                success: function (data) {
                    $('#divList').html(data);
                }
            })
        };


        $('#printPaySlip').click(function (e) {
            debugger;
            var paySlipDate = $('#PaySlipDate').val();
            /*window.open(getApplicationName() + ""ESS/EmpAttendances/PrintAttendance?attendanceDate="" + attendaceDate, ""_blank"");*/
            window.open(getApplicationName() + ""ESS/EmpPaySlip/PrintPaySlip/"" + paySlipDate, ""_blank"");

        });
    </script>
");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public LocService SharedLocalizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
