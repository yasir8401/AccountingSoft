#pragma checksum "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\TrailReport\_list.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa2925823e1a652e5c609cb0587204716d021578"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Finance_Views_TrailReport__list), @"mvc.1.0.view", @"/Areas/Finance/Views/TrailReport/_list.cshtml")]
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
#line 1 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\TrailReport\_list.cshtml"
using ErpOnClick.DAL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\TrailReport\_list.cshtml"
using ErpOnClick.ErpMain.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\TrailReport\_list.cshtml"
using ErpOnClick.ErpMain.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa2925823e1a652e5c609cb0587204716d021578", @"/Areas/Finance/Views/TrailReport/_list.cshtml")]
    public class Areas_Finance_Views_TrailReport__list : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Report.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 6 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\TrailReport\_list.cshtml"
  
    List<TrailBalanceReportModel> listReportTrailBalance = Model.listReportTrailBalance;
    var count = 0;
    var totalcount = listReportTrailBalance.Count;


#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fa2925823e1a652e5c609cb0587204716d0215784446", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<div class=\"table-responsive pb-2 \">\r\n    <table id=\"dtList\" class=\"table table-hover table-condensed \">\r\n        <thead class=\"text-sm \">\r\n            <tr class=\"col-lg-12 text-center\">\r\n                <th colspan=\"5\" class=\"heading-border-right\"> ");
#nullable restore
#line 17 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\TrailReport\_list.cshtml"
                                                         Write(SharedLocalizer.GetLocalizedHtmlString("Account"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n                <th colspan=\"3\" class=\"heading-border-right\"> ");
#nullable restore
#line 18 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\TrailReport\_list.cshtml"
                                                         Write(SharedLocalizer.GetLocalizedHtmlString("Opening Balance"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n                <th colspan=\"3\" class=\"heading-border-right\"> ");
#nullable restore
#line 19 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\TrailReport\_list.cshtml"
                                                         Write(SharedLocalizer.GetLocalizedHtmlString("TRANSACTIONS"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n                <th colspan=\"3\"> ");
#nullable restore
#line 20 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\TrailReport\_list.cshtml"
                            Write(SharedLocalizer.GetLocalizedHtmlString("Balance"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\r\n            </tr>\r\n            <tr class=\"col-lg-12 text-center\">\r\n                <th> ");
#nullable restore
#line 24 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\TrailReport\_list.cshtml"
                Write(SharedLocalizer.GetLocalizedHtmlString("Code"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n                <th> ");
#nullable restore
#line 25 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\TrailReport\_list.cshtml"
                Write(SharedLocalizer.GetLocalizedHtmlString("Account Title"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n                <th> ");
#nullable restore
#line 26 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\TrailReport\_list.cshtml"
                Write(SharedLocalizer.GetLocalizedHtmlString("Type"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n                <th> ");
#nullable restore
#line 27 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\TrailReport\_list.cshtml"
                Write(SharedLocalizer.GetLocalizedHtmlString("Head"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n                <th class=\"border-right\"> ");
#nullable restore
#line 28 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\TrailReport\_list.cshtml"
                                     Write(SharedLocalizer.GetLocalizedHtmlString("Sub Head"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n                <th> ");
#nullable restore
#line 29 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\TrailReport\_list.cshtml"
                Write(SharedLocalizer.GetLocalizedHtmlString("Opening DR."));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th> ");
#nullable restore
#line 30 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\TrailReport\_list.cshtml"
                Write(SharedLocalizer.GetLocalizedHtmlString("Opening CR."));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n                <th class=\"border-right\"> ");
#nullable restore
#line 31 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\TrailReport\_list.cshtml"
                                     Write(SharedLocalizer.GetLocalizedHtmlString("Balance"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n                <th> ");
#nullable restore
#line 32 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\TrailReport\_list.cshtml"
                Write(SharedLocalizer.GetLocalizedHtmlString("Debit DR."));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th> ");
#nullable restore
#line 33 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\TrailReport\_list.cshtml"
                Write(SharedLocalizer.GetLocalizedHtmlString("Credit CR."));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n                <th class=\"border-right\"> ");
#nullable restore
#line 34 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\TrailReport\_list.cshtml"
                                     Write(SharedLocalizer.GetLocalizedHtmlString("Balance"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n                <th> ");
#nullable restore
#line 35 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\TrailReport\_list.cshtml"
                Write(SharedLocalizer.GetLocalizedHtmlString("Total Debit DR."));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th> ");
#nullable restore
#line 36 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\TrailReport\_list.cshtml"
                Write(SharedLocalizer.GetLocalizedHtmlString("Total Credit CR."));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n                <th> ");
#nullable restore
#line 37 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\TrailReport\_list.cshtml"
                Write(SharedLocalizer.GetLocalizedHtmlString("Balance"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </th>

            </tr>
        </thead>
        <tfoot style=""display:table-row-group"">
            <tr class=""text-center"">
                <th> Code</th>
                <th> Account Title </th>
                <th> Type </th>
                <th> Head</th>
                <th class=""border-right""> Sub Head</th>
                <th> Opening DR. </th>
                <th> Opening CR. </th>
                <th class=""border-right"">Balance</th>
                <th> Debit DR. </th>
                <th> Credit CR. </th>
                <th class=""border-right"">Balance</th>
                <th> Total Debit DR. </th>
                <th> Total Credit CR. </th>
                <th> Total</th>

            </tr>
        </tfoot>
        <tbody>
");
#nullable restore
#line 61 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\TrailReport\_list.cshtml"
             foreach (var item in listReportTrailBalance)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"text-center\">\r\n                    <td> ");
#nullable restore
#line 64 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\TrailReport\_list.cshtml"
                    Write(item.Code);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td> ");
#nullable restore
#line 65 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\TrailReport\_list.cshtml"
                    Write(item.Account);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td> ");
#nullable restore
#line 66 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\TrailReport\_list.cshtml"
                    Write(item.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td> ");
#nullable restore
#line 67 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\TrailReport\_list.cshtml"
                    Write(item.Head);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td class=\"border-right\"> ");
#nullable restore
#line 68 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\TrailReport\_list.cshtml"
                                         Write(item.SubHead);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td> ");
#nullable restore
#line 69 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\TrailReport\_list.cshtml"
                     Write(item.ODebit!=null && item.ODebit!=0 ? String.Format("{0:.00}",item.ODebit) : "-");

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td> ");
#nullable restore
#line 70 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\TrailReport\_list.cshtml"
                     Write(item.OCredit != null && item.OCredit!=0 ? String.Format("{0:.00}",item.OCredit) : "-");

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td class=\"border-right\"> ");
#nullable restore
#line 71 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\TrailReport\_list.cshtml"
                                          Write(item.OTotal != null && item.OTotal!=0 ? String.Format("{0:.00}",item.OTotal) : "-");

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td> ");
#nullable restore
#line 72 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\TrailReport\_list.cshtml"
                     Write(item.ADebit != null && item.ADebit!=0 ? String.Format("{0:.00}",item.ADebit) : "-");

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td> ");
#nullable restore
#line 73 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\TrailReport\_list.cshtml"
                     Write(item.ACredit != null && item.ACredit!=0 ? String.Format("{0:.00}",item.ACredit) : "-");

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td class=\"border-right\"> ");
#nullable restore
#line 74 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\TrailReport\_list.cshtml"
                                          Write(item.ATotal != null && item.ATotal!=0 ? String.Format("{0:.00}",item.ATotal) : "-");

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td> ");
#nullable restore
#line 75 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\TrailReport\_list.cshtml"
                     Write(item.CDebit != null && item.CDebit!=0 ? String.Format("{0:.00}",item.CDebit) : "-");

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td> ");
#nullable restore
#line 76 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\TrailReport\_list.cshtml"
                     Write(item.CCredit != null && item.CCredit!=0 ? String.Format("{0:.00}",item.CCredit) : "-");

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td> ");
#nullable restore
#line 77 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\TrailReport\_list.cshtml"
                     Write(item.CTotal != null && item.CTotal!=0 ? String.Format("{0:.00}",item.CTotal) : "-");

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                </tr>\r\n");
#nullable restore
#line 79 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\TrailReport\_list.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </tbody>
        <tfoot>
            <tr style=""background-color:#fff6ea"" class=""text-center order-last"">
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td class=""border-right"">Total</td>
                <td>");
#nullable restore
#line 89 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\TrailReport\_list.cshtml"
                Write(String.Format("{0:.00}", listReportTrailBalance.Sum(x => x.ODebit)));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 90 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\TrailReport\_list.cshtml"
                Write(String.Format("{0:.00}", listReportTrailBalance.Sum(x => x.OCredit)));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"border-right\">");
#nullable restore
#line 91 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\TrailReport\_list.cshtml"
                                     Write(String.Format("{0:.00}", (listReportTrailBalance.Sum(x => x.ODebit) - listReportTrailBalance.Sum(x => x.OCredit))));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 92 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\TrailReport\_list.cshtml"
                Write(String.Format("{0:.00}", listReportTrailBalance.Sum(x => x.ADebit)));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 93 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\TrailReport\_list.cshtml"
                Write(String.Format("{0:.00}", listReportTrailBalance.Sum(x => x.ACredit)));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"border-right\">");
#nullable restore
#line 94 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\TrailReport\_list.cshtml"
                                     Write(String.Format("{0:.00}", listReportTrailBalance.Sum(x => x.ADebit) - listReportTrailBalance.Sum(x => x.ACredit)));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 95 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\TrailReport\_list.cshtml"
                Write(String.Format("{0:.00}", listReportTrailBalance.Sum(x => x.CDebit)));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 96 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\TrailReport\_list.cshtml"
                Write(String.Format("{0:.00}", listReportTrailBalance.Sum(x => x.CCredit)));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 97 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\TrailReport\_list.cshtml"
                Write(String.Format("{0:.00}", listReportTrailBalance.Sum(x => x.CDebit) - listReportTrailBalance.Sum(x => x.CCredit)));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
            </tr>
        </tfoot>
    </table>
</div>


<script>
    $(function () {
        $('#Accli').addClass(""menu-open"");
        $('#Reportsli').addClass(""menu-open"");
        $('#Statementsli').removeClass(""menu-open"");
        $('#AccRli').removeClass(""menu-open"");
        $('#AccPli').removeClass(""menu-open"");
        $('#Setupli').removeClass(""menu-open"");

        _initDatatable('#dtList');
    });
</script>");
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
