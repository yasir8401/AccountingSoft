#pragma checksum "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpLeavesReport\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cdb2990409f6399b776d2ad537342eb838ac27eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_HumanResource_Views_EmpLeavesReport_Index), @"mvc.1.0.view", @"/Areas/HumanResource/Views/EmpLeavesReport/Index.cshtml")]
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
#line 1 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpLeavesReport\Index.cshtml"
using ErpOnClick.DAL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpLeavesReport\Index.cshtml"
using ErpOnClick.ErpMain.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cdb2990409f6399b776d2ad537342eb838ac27eb", @"/Areas/HumanResource/Views/EmpLeavesReport/Index.cshtml")]
    public class Areas_HumanResource_Views_EmpLeavesReport_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpLeavesReport\Index.cshtml"
  
    List<Emp> empsList = Model.empsList;
    int EmpId = Model.EmpId;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<div class=\"card card-default card-outline\">\r\n\r\n    <div class=\"card-header\">\r\n        <h2 class=\"card-title\">\r\n            ");
#nullable restore
#line 16 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpLeavesReport\Index.cshtml"
       Write(SharedLocalizer.GetLocalizedHtmlString("Employee Leaves Report"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </h2>\r\n        <!-- tools box -->\r\n        <div class=\"card-tools float-right\">\r\n            <a id=\"printList\"");
            BeginWriteAttribute("href", " href=\"", 499, "\"", 506, 0);
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\" class=\"btn btn-default btn-sm\"><i class=\"fal fa-print fa-fw\"></i>");
#nullable restore
#line 20 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpLeavesReport\Index.cshtml"
                                                                                                                  Write(SharedLocalizer.GetLocalizedHtmlString("Print"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>


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
#line 33 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpLeavesReport\Index.cshtml"
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
#line 39 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpLeavesReport\Index.cshtml"
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
#line 45 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpLeavesReport\Index.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Employee"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <select name=\"EmpId\" id=\"EmpId\" class=\"form-control\">\r\n                            <option></option>\r\n");
#nullable restore
#line 48 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpLeavesReport\Index.cshtml"
                             foreach (var item in empsList)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <option");
            BeginWriteAttribute("value", " value=\"", 1925, "\"", 1944, 1);
#nullable restore
#line 50 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpLeavesReport\Index.cshtml"
WriteAttributeValue("", 1933, item.EmpId, 1933, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 50 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpLeavesReport\Index.cshtml"
                                                        Write(item.EmpId == EmpId ? "selected" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n                                    ");
#nullable restore
#line 51 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpLeavesReport\Index.cshtml"
                                Write(item.FirstNameEn + " " + item.FatherNameEn + " " + item.GrandNameEn + " " + item.FamilyNameEn);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </option>\r\n");
#nullable restore
#line 53 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpLeavesReport\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </select>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-sm-1\">\r\n                    <button style=\"margin-top:29px\" type=\"submit\" class=\"btn btn-primary btn-block\"> ");
#nullable restore
#line 58 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpLeavesReport\Index.cshtml"
                                                                                                Write(SharedLocalizer.GetLocalizedHtmlString("Search"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                </div>\r\n            </div>\r\n        </form>\r\n    </div>\r\n    <div class=\"card-body\">\r\n        <div id=\"divList\"></div>\r\n\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        $(function () {
            $('#printList').hide();

            var start = '2020' + '-' + '01' + '-' + '01';
            today = '2020' + '-' + '12' + '-' + '01';
            $('#FromDate').val(start);
            $('#ToDate').val(today);


            BindGrid();
            $('#frmSearch').submit(function (e) {

                e.preventDefault();
                BindGrid();
            })

        });
        var applicationName = getApplicationName();

        function BindGrid() {

            $('#divList').html('<h5 class=""margin-0""><p><i class=""fa fa-spinner fa-spin fa-fw""></i> Please wait while data is loading...</p></h5>');
            $.ajax({
                url: applicationName + 'HumanResource/EmpLeavesReport/_list',
                data: $('#frmSearch').serialize(),
                success: function (data) {
                    $('#printList').show();

                    $('#divList').html(data);
                }
            })
        }");
                WriteLiteral("\r\n\r\n        $(\'#printList\').click(function (e) {\r\n\r\n            var EmpId = $(\'#EmpId\').val();\r\n\r\n            window.open(applicationName + \"HumanResource/EmpLeavesReport/PrintList?EmpId=\" + EmpId, \"_blank\");\r\n        });\r\n    </script>\r\n");
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
