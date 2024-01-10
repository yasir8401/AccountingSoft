#pragma checksum "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\CustomerReport\_list.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5cc69cce2212811df9fa79de62c870ef6cf381f0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Finance_Views_CustomerReport__list), @"mvc.1.0.view", @"/Areas/Finance/Views/CustomerReport/_list.cshtml")]
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
#line 1 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\CustomerReport\_list.cshtml"
using ErpOnClick.DAL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\CustomerReport\_list.cshtml"
using ErpOnClick.ErpMain.Resources;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\CustomerReport\_list.cshtml"
using ErpOnClick.ErpMain.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cc69cce2212811df9fa79de62c870ef6cf381f0", @"/Areas/Finance/Views/CustomerReport/_list.cshtml")]
    public class Areas_Finance_Views_CustomerReport__list : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\CustomerReport\_list.cshtml"
  
    List<CustomerReportModel> listReportCustomer = Model.listReportCustomer;
    int balance = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"table-responsive pb-2 \">\r\n    <table id=\"dtList\" class=\"table table-hover table-condensed \">\r\n        <thead class=\"text-sm \">\r\n            <tr class=\"col-lg-12\">\r\n                <th align=\"center\" width=\"100px\"> ");
#nullable restore
#line 15 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\CustomerReport\_list.cshtml"
                                             Write(SharedLocalizer.GetLocalizedHtmlString("Date"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th align=\"left\"> ");
#nullable restore
#line 16 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\CustomerReport\_list.cshtml"
                             Write(SharedLocalizer.GetLocalizedHtmlString("Account"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th align=\"right\"> ");
#nullable restore
#line 17 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\CustomerReport\_list.cshtml"
                              Write(SharedLocalizer.GetLocalizedHtmlString("Debit"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n                <th align=\"right\"> ");
#nullable restore
#line 18 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\CustomerReport\_list.cshtml"
                              Write(SharedLocalizer.GetLocalizedHtmlString("Credit"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n                <th align=\"right\"> ");
#nullable restore
#line 19 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\CustomerReport\_list.cshtml"
                              Write(SharedLocalizer.GetLocalizedHtmlString("Balance"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</th>

            </tr>
        </thead>
        <tfoot style=""display:table-row-group"">
            <tr>
                <th align=""center"" width=""100px""> Date</th>
                <th align=""left""> Account</th>
                <th align=""right""> Debit </th>
                <th align=""right""> Credit </th>
                <th align=""right""> Balance</th>

            </tr>
        </tfoot>
        <tbody>

");
#nullable restore
#line 35 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\CustomerReport\_list.cshtml"
             foreach (var item in listReportCustomer)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"text-center\">\r\n                    <td align=\"center\" width=\"100px\"> ");
#nullable restore
#line 38 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\CustomerReport\_list.cshtml"
                                                  Write(Convert.ToDateTime(item.CreatedDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td align=\"left\"> ");
#nullable restore
#line 39 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\CustomerReport\_list.cshtml"
                                 Write(item.Account);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td align=\"right\"> ");
#nullable restore
#line 40 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\CustomerReport\_list.cshtml"
                                   Write(String.Format("{0:.00}", item.Debit));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td align=\"right\"> ");
#nullable restore
#line 41 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\CustomerReport\_list.cshtml"
                                   Write(String.Format("{0:.00}", item.Credit));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td align=\"right\"> ");
#nullable restore
#line 42 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\CustomerReport\_list.cshtml"
                                   Write(String.Format("{0:.00}", item.Balance));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 44 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\CustomerReport\_list.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n        <tfoot>\r\n            <tr style=\"background-color:#fff6ea\" class=\"text-center\">\r\n                <td align=\"right\"></td>\r\n                <td align=\"right\">Total</td>\r\n                <td align=\"right\">");
#nullable restore
#line 50 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\CustomerReport\_list.cshtml"
                              Write(String.Format("{0:.00}", listReportCustomer.Sum(x => x.Debit)));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td align=\"right\">");
#nullable restore
#line 51 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\CustomerReport\_list.cshtml"
                              Write(String.Format("{0:.00}", listReportCustomer.Sum(x => x.Credit)));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                <td align=""right""></td>
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
