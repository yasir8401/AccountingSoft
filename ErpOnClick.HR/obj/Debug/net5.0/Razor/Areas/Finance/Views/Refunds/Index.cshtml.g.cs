#pragma checksum "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Refunds\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3fa968ef7456300397c24a91909aa9876066f337"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Finance_Views_Refunds_Index), @"mvc.1.0.view", @"/Areas/Finance/Views/Refunds/Index.cshtml")]
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
#line 1 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Refunds\Index.cshtml"
using ErpOnClick.DAL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Refunds\Index.cshtml"
using ErpOnClick.ErpMain.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3fa968ef7456300397c24a91909aa9876066f337", @"/Areas/Finance/Views/Refunds/Index.cshtml")]
    public class Areas_Finance_Views_Refunds_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Finance/Refunds/edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn  btn-sm btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Refunds\Index.cshtml"
   List<Vendors> VendorsDetails = Model.vendorsList; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("TabName", async() => {
                WriteLiteral("\r\n    Lookup Setup\r\n");
            }
            );
            WriteLiteral("\r\n<div class=\"card card-default card-outline\">\r\n\r\n    <div class=\"card-header\">\r\n        <h2 class=\"card-title\">\r\n            ");
#nullable restore
#line 15 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Refunds\Index.cshtml"
       Write(SharedLocalizer.GetLocalizedHtmlString("Refunds"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </h2>\r\n        <!-- tools box -->\r\n        <div class=\"card-tools fa-pull-right\">\r\n            <a id=\"printList\" target=\"_blank\" class=\"btn btn-default btn-sm\"><i class=\"fal fa-print fa-fw\"></i>");
#nullable restore
#line 19 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Refunds\Index.cshtml"
                                                                                                          Write(SharedLocalizer.GetLocalizedHtmlString("Print"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3fa968ef7456300397c24a91909aa9876066f3375711", async() => {
                WriteLiteral("\r\n                <i class=\"fal fa-plus\"></i> ");
#nullable restore
#line 22 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Refunds\Index.cshtml"
                                       Write(SharedLocalizer.GetLocalizedHtmlString("Add New"));

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
                <div class=""col-sm-2"">
                    <div class=""form-group "">
                        <label>");
#nullable restore
#line 33 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Refunds\Index.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Refund Date From"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                        <input class=""form-control  DatePicker"" type=""text"" name=""RefundDateFrom"" id=""RefundDateFrom"" />
                    </div>
                </div>
                <div class=""col-sm-2"">
                    <div class=""form-group "">
                        <label>");
#nullable restore
#line 39 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Refunds\Index.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Refund Date To"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                        <input class=""form-control  DatePicker"" type=""text"" name=""RefundDateTo"" id=""RefundDateTo"" />
                    </div>
                </div>
                <div class=""col-sm-3"">
                    <div class=""form-group "">
                        <label>");
#nullable restore
#line 45 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Refunds\Index.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Vendor"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <select name=\"VendorId\" id=\"VendorId\" class=\"form-control input-sm text-sm \">\r\n                            <option");
            BeginWriteAttribute("value", " value=\"", 2045, "\"", 2053, 0);
            EndWriteAttribute();
            WriteLiteral(">All</option>\r\n");
#nullable restore
#line 48 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Refunds\Index.cshtml"
                             foreach (var item in VendorsDetails)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <option");
            BeginWriteAttribute("value", " value=\"", 2206, "\"", 2228, 1);
#nullable restore
#line 50 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Refunds\Index.cshtml"
WriteAttributeValue("", 2214, item.VendorId, 2214, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 50 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Refunds\Index.cshtml"
                                                           Write(item.VendorNameEn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 51 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Refunds\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </select>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-sm-2\">\r\n                    <div class=\"form-group \">\r\n                        <label>");
#nullable restore
#line 57 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Refunds\Index.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Due Date From"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                        <input class=""form-control  DatePicker"" type=""text"" name=""DueDateFrom"" id=""DueDateFrom"" />
                    </div>
                </div>
                <div class=""col-sm-2"">
                    <div class=""form-group "">
                        <label>");
#nullable restore
#line 63 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Refunds\Index.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Due Date To"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                        <input class=""form-control  DatePicker"" type=""text"" name=""DueDateTo"" id=""DueDateTo"" />
                    </div>
                </div>
                <div style=""display:none"">
                    <button type=""submit"" class=""btn btn-default btn-block"">Refresh</button>
                </div>
            </div>
        </form>
    </div>


    <div class=""card-body"">
        <div id=""divList""></div>

    </div>
</div>



");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        $(function () {
            $('#AccPli').addClass(""menu-open"");
            $('#AccRli').removeClass(""menu-open"");
            $('#Accli').removeClass(""menu-open"");
            $('#Setupli').removeClass(""menu-open"");

            var date = new Date();
            var dd = String(date.getDate()).padStart(2, '0');
            var mm = String(date.getMonth() + 1).padStart(2, '0')
            var yyyy = date.getFullYear();
            var premonth = parseInt(mm) - 1;
            var start = yyyy + '-' + mm + '-' + '01';
            today = yyyy + '-' + mm + '-' + dd;
            $('#RefundDateFrom').val(start);
            $('#RefundDateTo').val(today);
            $('#DueDateFrom').val(start);
            $('#DueDateTo').val(today);
            $('#frmSearch button').click();
            initDatePicker();

        });

        $('#frmSearch').find('input, select').change(() => {
            $('#frmSearch button').click();
        });

        $('#frmSearch').sub");
                WriteLiteral(@"mit(function (e) {
            e.preventDefault();
            BindGrid();
        })


        function BindGrid() {
            $('#divList').html('<h5 class=""margin-0""><p><i class=""fa fa-spinner fa-spin fa-fw""></i> Please wait while data is loading...</p></h5>');
            $.ajax({
                url: getApplicationName() + 'Finance/Refunds/_list',
                data: $('#frmSearch').serialize(),
                success: function (data) {
                    $('#divList').html(data);
                }
            })
        }

        $('#printList').click(function (e) {
            var refunddatefrom = $('#RefundDateFrom').val();
            var refunddateto = $('#RefundDateTo').val();
            var duedatefrom = $('#DueDateFrom').val();
            var duedateto = $('#DueDateTo').val();
            var vendor = parseInt($('#VendorId').val());
            window.open(getApplicationName() + ""Finance/Refunds/PrintList?RefundDateFrom="" + refunddatefrom + ""&RefundDateTo="" + refun");
                WriteLiteral("ddateto + \"&VendorId=\" + vendor + \"&DueDateFrom=\" + duedatefrom + \"&DueDateTo=\" + duedateto, \"_blank\");\r\n        });\r\n    </script>\r\n");
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
