#pragma checksum "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\PayRunM\edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5dfb642ac630880bf133df82f24e79c89e7eacfd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_HumanResource_Views_PayRunM_edit), @"mvc.1.0.view", @"/Areas/HumanResource/Views/PayRunM/edit.cshtml")]
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
#line 1 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\PayRunM\edit.cshtml"
using ErpOnClick.DAL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\PayRunM\edit.cshtml"
using ErpOnClick.ErpMain.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5dfb642ac630880bf133df82f24e79c89e7eacfd", @"/Areas/HumanResource/Views/PayRunM/edit.cshtml")]
    public class Areas_HumanResource_Views_PayRunM_edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/HumanResource/PayRunM"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn  btn-sm btn-default "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\PayRunM\edit.cshtml"
  



    IList<Branch> branchList = Model.branchList;
    IList<Company> companyList = Model.companyList;
    IList<Emp> empList = Model.empList;


    PayrunM PayRunMDetails = Model.PayRunMDetails;

    bool isEdit = (PayRunMDetails != null);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<form id=\"frmEdit\" role=\"form\">\r\n    <input type=\"hidden\" id=\"ACTION_TYPE\" name=\"ACTION_TYPE\"");
            BeginWriteAttribute("value", " value=\"", 464, "\"", 501, 1);
#nullable restore
#line 22 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\PayRunM\edit.cshtml"
WriteAttributeValue("", 472, isEdit ? "update" : "save", 472, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input type=\"hidden\" id=\"PayrunId\" name=\"PayrunId\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 582, "\"", 645, 1);
#nullable restore
#line 23 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\PayRunM\edit.cshtml"
WriteAttributeValue("", 590, PayRunMDetails != null ? PayRunMDetails.PayrunId : 0, 590, 55, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 23 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\PayRunM\edit.cshtml"
                                                                                                                                        Write(isEdit ? "readonly" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(" min=\"4\" maxlength=\"4\">\r\n\r\n    <div class=\"card card-default card-outline col-lg-12\" style=\"text-align:center\">\r\n\r\n        <div class=\"card-header\">\r\n            <h2 class=\"card-title\">\r\n                ");
#nullable restore
#line 29 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\PayRunM\edit.cshtml"
           Write(SharedLocalizer.GetLocalizedHtmlString("PAYRUN HISTORY"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </h2>\r\n            <!-- tools box -->\r\n            <div class=\"card-tools float-right\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5dfb642ac630880bf133df82f24e79c89e7eacfd6823", async() => {
                WriteLiteral("\r\n                    <i class=\"fal fa-arrow-left fa-fw\"></i> ");
#nullable restore
#line 34 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\PayRunM\edit.cshtml"
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
            WriteLiteral("\r\n            </div>\r\n            <br />\r\n            <br />\r\n\r\n");
#nullable restore
#line 40 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\PayRunM\edit.cshtml"
              
                DateTime? dateM = (PayRunMDetails != null ? new DateTime(PayRunMDetails.YearId, PayRunMDetails.MonthId, 1) : DateTime.Now); ;


#line default
#line hidden
#nullable disable
            WriteLiteral("                <input type=\"month\" class=\"form-control col-md-3\"");
            BeginWriteAttribute("value", " value=\"", 1557, "\"", 1615, 1);
#nullable restore
#line 43 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\PayRunM\edit.cshtml"
WriteAttributeValue("", 1565, dateM.Value.Year+"-"+dateM.Value.ToString("MM"), 1565, 50, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"DatePayRun\" />\r\n");
            WriteLiteral("            <!-- /. tools -->\r\n        </div>\r\n        <div class=\"card-body\">\r\n\r\n            <div class=\"row\">\r\n\r\n                <div id=\"divList\" class=\"table-responsive\"></div>\r\n\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n\r\n\r\n</form>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"

    <script>

        $(function () {
            BindGrid();
        });
        var applicationName = getApplicationName();

        function BindGrid() {
            var date = $('#DatePayRun').val();
            var PayrunId = $('#PayrunId').val();
            $('#divList').html('<h5 class=""margin-0""><p><i class=""fa fa-spinner fa-spin fa-fw""></i> Please wait while data is loading...</p></h5>');
            $.ajax({
                url: applicationName + 'HumanResource/PayRunM/_listPayRunD',
                data: { date: date, id: PayrunId },
                success: function (data) {
                    $('#divList').html(data);
                }
            })
        };

        $('#DatePayRun').change(function () {
            BindGrid();
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
