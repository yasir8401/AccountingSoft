#pragma checksum "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\TaxRates\edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0316381a6b68ed1ef7cf42432f14e8f413aa7620"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Finance_Views_TaxRates_edit), @"mvc.1.0.view", @"/Areas/Finance/Views/TaxRates/edit.cshtml")]
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
#line 1 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\TaxRates\edit.cshtml"
using ErpOnClick.DAL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\TaxRates\edit.cshtml"
using ErpOnClick.ErpMain.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0316381a6b68ed1ef7cf42432f14e8f413aa7620", @"/Areas/Finance/Views/TaxRates/edit.cshtml")]
    public class Areas_Finance_Views_TaxRates_edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Finance/TaxRates"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\TaxRates\edit.cshtml"
  
    TaxRates TaxRateDetail = Model.IdDetail;
    List<Lookups> ActiveStatus = Model.ActiveStatus;
    List<Branch> BranchDetails = Model.branchList;

    bool isEdit = (TaxRateDetail != null);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<form id=\"frmEdit\" role=\"form\">\r\n    <input type=\"hidden\" id=\"ACTION_TYPE\" name=\"ACTION_TYPE\"");
            BeginWriteAttribute("value", " value=\"", 409, "\"", 446, 1);
#nullable restore
#line 16 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\TaxRates\edit.cshtml"
WriteAttributeValue("", 417, isEdit ? "update" : "save", 417, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input type=\"hidden\" id=\"TaxRateId\" name=\"TaxRateId\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 529, "\"", 591, 1);
#nullable restore
#line 17 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\TaxRates\edit.cshtml"
WriteAttributeValue("", 537, TaxRateDetail != null ? TaxRateDetail.TaxRateId : 0, 537, 54, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input type=\"hidden\" id=\"CompanyId\" name=\"CompanyId\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 674, "\"", 736, 1);
#nullable restore
#line 18 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\TaxRates\edit.cshtml"
WriteAttributeValue("", 682, TaxRateDetail != null ? TaxRateDetail.CompanyId : 0, 682, 54, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input type=\"hidden\" id=\"BranchId\" name=\"BranchId\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 817, "\"", 878, 1);
#nullable restore
#line 19 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\TaxRates\edit.cshtml"
WriteAttributeValue("", 825, TaxRateDetail != null ? TaxRateDetail.BranchId : 0, 825, 53, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n\r\n    <div class=\"card card-default card-outline col-lg-8\">\r\n\r\n        <div class=\"card-header\">\r\n            <h2 class=\"card-title\">\r\n                ");
#nullable restore
#line 26 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\TaxRates\edit.cshtml"
           Write(SharedLocalizer.GetLocalizedHtmlString("Tax Rate"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </h2>\r\n            <!-- tools box -->\r\n            <div class=\"card-tools float-right\">\r\n                <button type=\"submit\" class=\"btn  btn-sm btn-primary\">\r\n                    <i class=\"fal fa-save fa-fw\"></i> ");
#nullable restore
#line 31 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\TaxRates\edit.cshtml"
                                                 Write(SharedLocalizer.GetLocalizedHtmlString("Save"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </button>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0316381a6b68ed1ef7cf42432f14e8f413aa76207796", async() => {
                WriteLiteral("\r\n                    <i class=\"fal fa-arrow-left fa-fw\"></i> ");
#nullable restore
#line 34 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\TaxRates\edit.cshtml"
                                                       Write(SharedLocalizer.GetLocalizedHtmlString("Return"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
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
            WriteLiteral("\r\n            </div>\r\n            <!-- /. tools -->\r\n        </div>\r\n    </div>\r\n    <div class=\"card card-default card-outline col-lg-8\">\r\n        <div class=\"card-header\">\r\n            <h2 class=\"card-title\">\r\n                ");
#nullable restore
#line 43 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\TaxRates\edit.cshtml"
           Write(SharedLocalizer.GetLocalizedHtmlString("Tax Rate Info"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </h2>\r\n        </div>\r\n        <div class=\"card-body\">\r\n\r\n            <div class=\"row\">\r\n                <div class=\"col-sm-6\">\r\n                    <div class=\"form-group\">\r\n                        <label>");
#nullable restore
#line 51 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\TaxRates\edit.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Tax Rate Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </label>\r\n                        <input type=\"text\" id=\"TaxRateNameEn\" name=\"TaxRateNameEn\" class=\"form-control\" required");
            BeginWriteAttribute("value", " value=\"", 2300, "\"", 2364, 1);
#nullable restore
#line 52 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\TaxRates\edit.cshtml"
WriteAttributeValue("", 2308, TaxRateDetail!=null?TaxRateDetail.TaxRateNameEn: null, 2308, 56, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-sm-6\">\r\n                    <div class=\"form-group\">\r\n                        <label>");
#nullable restore
#line 57 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\TaxRates\edit.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Tax Rate Name (Arabic)"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <input type=\"text\" id=\"TaxRateNameAr\" name=\"TaxRateNameAr\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 2715, "\"", 2779, 1);
#nullable restore
#line 58 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\TaxRates\edit.cshtml"
WriteAttributeValue("", 2723, TaxRateDetail!=null?TaxRateDetail.TaxRateNameAr: null, 2723, 56, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n                </div>\r\n\r\n                <div class=\"col-sm-6\">\r\n                    <div class=\"form-group\">\r\n                        <label>");
#nullable restore
#line 64 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\TaxRates\edit.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Tax Percentage"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <input type=\"number\" step=\"any\" min=\"0\" id=\"TaxPercent\" required name=\"TaxPercent\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 3148, "\"", 3215, 1);
#nullable restore
#line 65 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\TaxRates\edit.cshtml"
WriteAttributeValue("", 3156, TaxRateDetail != null ? TaxRateDetail.TaxPercent : null , 3156, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-sm-6\">\r\n                    <div class=\"form-group\">\r\n                        <label>");
#nullable restore
#line 70 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\TaxRates\edit.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Active Status"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <select id=\"ActiveStatus\" name=\"ActiveStatus\" class=\"form-control\" required>\r\n                            <option></option>\r\n");
#nullable restore
#line 73 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\TaxRates\edit.cshtml"
                             foreach (var item in ActiveStatus)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <option");
            BeginWriteAttribute("value", " value=\"", 3738, "\"", 3756, 1);
#nullable restore
#line 75 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\TaxRates\edit.cshtml"
WriteAttributeValue("", 3746, item.Code, 3746, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 75 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\TaxRates\edit.cshtml"
                                                       Write(TaxRateDetail != null && TaxRateDetail.ActiveStatus == item.Code ? "selected" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral("> ");
#nullable restore
#line 75 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\TaxRates\edit.cshtml"
                                                                                                                                             Write(item.LookupNameEn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 76 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\TaxRates\edit.cshtml"

                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </select>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-sm-6\">\r\n                    <div class=\"form-group\">\r\n                        <label>");
#nullable restore
#line 83 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\TaxRates\edit.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Is Default"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <select id=\"IsDefault\" name=\"IsDefault\" class=\"form-control\" required>\r\n                            <option disabled selected></option>\r\n                            <option value=true ");
#nullable restore
#line 86 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\TaxRates\edit.cshtml"
                                           Write(TaxRateDetail != null && TaxRateDetail.IsDefault == true ? "selected" : "" );

#line default
#line hidden
#nullable disable
            WriteLiteral("> True</option>\r\n                            <option value=false ");
#nullable restore
#line 87 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\TaxRates\edit.cshtml"
                                            Write(TaxRateDetail != null && TaxRateDetail.IsDefault == false ? "selected" : "" );

#line default
#line hidden
#nullable disable
            WriteLiteral(@"> False</option>
                        </select>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""card card-default card-outline col-lg-8"" style=""display:none"">
        <div class=""card-header"">
            <h2 class=""card-title"">
                ");
#nullable restore
#line 97 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\TaxRates\edit.cshtml"
           Write(SharedLocalizer.GetLocalizedHtmlString("Organization Details"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </h2>\r\n        </div>\r\n        <div class=\"card-body\">\r\n\r\n            <div class=\"row\">\r\n\r\n                <div class=\"col-sm-6\">\r\n                    <div class=\"form-group\">\r\n                        <label>");
#nullable restore
#line 106 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\TaxRates\edit.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Company"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <select id=\"CompanyId\" name=\"CompanyId\" class=\"form-control\">\r\n                            <option></option>\r\n");
#nullable restore
#line 109 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\TaxRates\edit.cshtml"
                             foreach (var item in Model.CompanyDetail)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <option");
            BeginWriteAttribute("value", " value=\"", 5546, "\"", 5569, 1);
#nullable restore
#line 111 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\TaxRates\edit.cshtml"
WriteAttributeValue("", 5554, item.CompanyId, 5554, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 111 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\TaxRates\edit.cshtml"
                                                            Write(TaxRateDetail != null && TaxRateDetail.CompanyId == item.CompanyId ? "selected" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral("> ");
#nullable restore
#line 111 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\TaxRates\edit.cshtml"
                                                                                                                                                    Write(item.CoNameEn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 112 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\TaxRates\edit.cshtml"

                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </select>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-sm-6\">\r\n                    <div class=\"form-group\">\r\n                        <label>");
#nullable restore
#line 119 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\TaxRates\edit.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Branch"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <select id=\"BranchId\" name=\"BranchId\" class=\"form-control\">\r\n                            <option></option>\r\n");
#nullable restore
#line 122 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\TaxRates\edit.cshtml"
                             foreach (var item in BranchDetails)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <option");
            BeginWriteAttribute("value", " value=\"", 6249, "\"", 6271, 1);
#nullable restore
#line 124 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\TaxRates\edit.cshtml"
WriteAttributeValue("", 6257, item.BranchId, 6257, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 124 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\TaxRates\edit.cshtml"
                                                           Write(TaxRateDetail != null && TaxRateDetail.BranchId == item.BranchId ? "selected" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral("> ");
#nullable restore
#line 124 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\TaxRates\edit.cshtml"
                                                                                                                                                 Write(item.BranchNameEn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 125 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\TaxRates\edit.cshtml"

                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </select>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</form>\r\n\r\n\r\n\r\n\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"

    <script>
        $(function () {
            $('#Setupli').addClass(""menu-open"");
            $('#AccPli').removeClass(""menu-open"");
            $('#Statementsli').removeClass(""menu-open"");
            $('#Reportsli').removeClass(""menu-open"");
            $('#AccRli').removeClass(""menu-open"");
            $('#Accli').removeClass(""menu-open"");
        });


        $('#frmEdit').on('submit', function (e) {
            e.preventDefault();

            var actionType = $('#ACTION_TYPE').val();

            confirmAction('Confirm ?', 'Are you sure you want to save changes ?', 'info', 'Yes', 'No').then(function (result) {
                if (result.value == true) {

                    var params = $('#frmEdit').serialize();
                    $.ajax({
                        url: getApplicationName() + ""Finance/TaxRates/"" + actionType,
                        async: false,
                        type: ""POST"",
                        data: params,
                        success: ");
                WriteLiteral(@"function (data) {
                            if (data.result.isError != true) {
                                showMsg('Saved !', 'Record has been saved !', 'success');
                                setTimeout(function () {
                                    window.location = getApplicationName() + 'Finance/TaxRates';
                                }, 500);
                            }
                            else if (data.result.msg != '') {
                                showMsg('Save Failed !', data.result.msg, 'error');
                            }
                            else {
                                showMsg('Save Failed !', 'Something went wrong. Try again', 'error');
                            }
                        }
                    });
                }
            });




        });

        $('#CompanyId').change(function () {

            var id = $('#CompanyId').val();

            $.ajax({
                url: getApplicationName() + ");
                WriteLiteral(@"""Ajax/BranchCascading"",
                async: false,
                type: ""POST"",
                data: { id: id },
                success: function (data) {

                    var item = '';

                    $.each(data.result, function (i, product) {

                        item += ""<option value='"" + product.branchId + ""'>"" + product.branchNameEn + ""</option>"";
                    });

                    $(""#BranchId"").html(item);

                }
            });

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
