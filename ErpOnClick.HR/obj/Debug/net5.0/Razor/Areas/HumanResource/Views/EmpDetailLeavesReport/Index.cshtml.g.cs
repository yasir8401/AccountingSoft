#pragma checksum "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpDetailLeavesReport\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b6e73a4253a305ca0da5774fc0f0b34371c8e67a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_HumanResource_Views_EmpDetailLeavesReport_Index), @"mvc.1.0.view", @"/Areas/HumanResource/Views/EmpDetailLeavesReport/Index.cshtml")]
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
#line 1 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpDetailLeavesReport\Index.cshtml"
using ErpOnClick.DAL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpDetailLeavesReport\Index.cshtml"
using ErpOnClick.ErpMain.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6e73a4253a305ca0da5774fc0f0b34371c8e67a", @"/Areas/HumanResource/Views/EmpDetailLeavesReport/Index.cshtml")]
    public class Areas_HumanResource_Views_EmpDetailLeavesReport_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/HumanResource/EmpLeavesReport"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn  btn-sm btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpDetailLeavesReport\Index.cshtml"
  
    List<Emp> empsList = Model.empsList;
    int empId = Model.empId;
    DateTime fromDate = Model.fromDate;
    DateTime toDate = Model.toDate;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<div class=\"card card-default card-outline\">\r\n\r\n    <div class=\"card-header\">\r\n        <h2 class=\"card-title\">\r\n            ");
#nullable restore
#line 18 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpDetailLeavesReport\Index.cshtml"
       Write(SharedLocalizer.GetLocalizedHtmlString("Leave Summary Report"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </h2>\r\n        <!-- tools box -->\r\n        <div class=\"card-tools float-right\">\r\n            <a id=\"printList\"");
            BeginWriteAttribute("href", " href=\"", 575, "\"", 582, 0);
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\" class=\"btn btn-default btn-sm\"><i class=\"fa fa-print fa-fw\"></i>");
#nullable restore
#line 22 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpDetailLeavesReport\Index.cshtml"
                                                                                                                 Write(SharedLocalizer.GetLocalizedHtmlString("Print"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b6e73a4253a305ca0da5774fc0f0b34371c8e67a6002", async() => {
                WriteLiteral("\r\n                <i class=\"fal fa-arrow-left fa-fw\"></i> ");
#nullable restore
#line 24 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpDetailLeavesReport\Index.cshtml"
                                                   Write(SharedLocalizer.GetLocalizedHtmlString("Return"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

        </div>
        <!-- /. tools -->
    </div>
    <div class=""card-footer pb-0 pt-2 text-sm"">
        <form id=""frmSearch"">
            <div class=""row"">


                <div class=""col-sm-3"">
                    <div class=""form-group"">
                        <label>");
#nullable restore
#line 37 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpDetailLeavesReport\Index.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("From Date"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </label>
                        <input type=""text"" id=""FromDate"" name=""FromDate"" class=""form-control DatePicker"">
                    </div>
                </div>
                <div class=""col-sm-3"">
                    <div class=""form-group"">
                        <label>");
#nullable restore
#line 43 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpDetailLeavesReport\Index.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("To Date"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </label>
                        <input type=""text"" id=""ToDate"" name=""ToDate"" class=""form-control DatePicker"">
                    </div>
                </div>
                <div class=""col-sm-4"">
                    <div class=""form-group "">
                        <label>");
#nullable restore
#line 49 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpDetailLeavesReport\Index.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Employee"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <select name=\"EmpId\" id=\"EmpId\" class=\"form-control\" required>\r\n\r\n                            <option></option>\r\n");
#nullable restore
#line 53 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpDetailLeavesReport\Index.cshtml"
                             foreach (var item in empsList)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <option");
            BeginWriteAttribute("value", " value=\"", 2236, "\"", 2255, 1);
#nullable restore
#line 55 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpDetailLeavesReport\Index.cshtml"
WriteAttributeValue("", 2244, item.EmpId, 2244, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 55 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpDetailLeavesReport\Index.cshtml"
                                                        Write(item.EmpId == empId ? "selected" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral("> ");
#nullable restore
#line 55 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpDetailLeavesReport\Index.cshtml"
                                                                                                  Write(item.FirstNameEn + " " + item.FatherNameEn + " " + item.GrandNameEn + " " + item.FamilyNameEn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 56 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpDetailLeavesReport\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </select>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-sm-1\">\r\n                    <button style=\"margin-top:29px\" type=\"submit\" class=\"btn btn-primary btn-block\"> ");
#nullable restore
#line 61 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpDetailLeavesReport\Index.cshtml"
                                                                                                Write(SharedLocalizer.GetLocalizedHtmlString("Search"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                </div>\r\n            </div>\r\n        </form>\r\n    </div>\r\n    <div class=\"card-body\">\r\n        <div id=\"divList\"></div>\r\n\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        var applicationName = getApplicationName();\r\n\r\n        $(function () {\r\n\r\n\r\n            if (");
#nullable restore
#line 80 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpDetailLeavesReport\Index.cshtml"
           Write(empId);

#line default
#line hidden
#nullable disable
                WriteLiteral(" != 0) {\r\n\r\n                var newfromdate =\"");
#nullable restore
#line 82 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpDetailLeavesReport\Index.cshtml"
                             Write(fromDate);

#line default
#line hidden
#nullable disable
                WriteLiteral("\";\r\n                var fdate = new Date(\"");
#nullable restore
#line 83 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpDetailLeavesReport\Index.cshtml"
                                 Write(fromDate);

#line default
#line hidden
#nullable disable
                WriteLiteral("\");\r\n                var tdate = new Date(\"");
#nullable restore
#line 84 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpDetailLeavesReport\Index.cshtml"
                                 Write(toDate);

#line default
#line hidden
#nullable disable
                WriteLiteral(@""");
                var FROMDATE = fdate.getFullYear() + '-' + String(fdate.getMonth() + 1).padStart(2, '0') + '-' + String(fdate.getDate()).padStart(2, '0');
                var TODATE = tdate.getFullYear() + '-' + String(tdate.getMonth() + 1).padStart(2, '0') + '-' + String(tdate.getDate()).padStart(2, '0');

                $('#FromDate').val((FROMDATE));
                $('#ToDate').val(TODATE);
                $('#divList').html('<h5 class=""margin-0""><p><i class=""fa fa-spinner fa-spin fa-fw""></i> Please wait while data is loading...</p></h5>');
                $.ajax({
                    url: applicationName + 'HumanResource/EmpDetailLeavesReport/_list',
                    data: $('#frmSearch').serialize(),
                    success: function (data) {
                        $('#printList').show();

                        $('#divList').html(data);
                    }
                });
            }
            else {
            $('#printList').hide();

            var start ");
                WriteLiteral(@"= '2020' + '-' + '01' + '-' + '01';
            today = '2020' + '-' + '12' + '-' + '01';
            $('#FromDate').val(start);
            $('#ToDate').val(today);


            BindGrid();
            $('#frmSearch').submit(function (e) {

                e.preventDefault();
                BindGrid();
            })
            }
        });

        function BindGrid() {

            $('#divList').html('<h5 class=""margin-0""><p><i class=""fa fa-spinner fa-spin fa-fw""></i> Please wait while data is loading...</p></h5>');
            $.ajax({
                url: applicationName + 'HumanResource/EmpDetailLeavesReport/_list',
                data: $('#frmSearch').serialize(),
                success: function (data) {
                    $('#printList').show();

                    $('#divList').html(data);
                }
            })
        }

        $('#printList').click(function (e) {
            var FromDate = $('#FromDate').val();
            var ToDate = $('#ToDate'");
                WriteLiteral(").val();\r\n            var EmpId = $(\'#EmpId\').val();\r\n            window.open(applicationName + \"HumanResource/EmpDetailLeavesReport/PrintList?FromDate=\" + FromDate + \"&ToDate=\" + ToDate + \"&EmpId=\" + EmpId, \"_blank\");\r\n        });\r\n    </script>\r\n");
            }
            );
            WriteLiteral("\r\n");
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