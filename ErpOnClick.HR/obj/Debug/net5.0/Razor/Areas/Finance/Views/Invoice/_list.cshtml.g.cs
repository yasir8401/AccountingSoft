#pragma checksum "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Invoice\_list.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12f9e8673802e708bd497acc9ab91bc3d1f28a33"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Finance_Views_Invoice__list), @"mvc.1.0.view", @"/Areas/Finance/Views/Invoice/_list.cshtml")]
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
#line 1 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Invoice\_list.cshtml"
using ErpOnClick.DAL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Invoice\_list.cshtml"
using ErpOnClick.ErpMain.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12f9e8673802e708bd497acc9ab91bc3d1f28a33", @"/Areas/Finance/Views/Invoice/_list.cshtml")]
    public class Areas_Finance_Views_Invoice__list : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 5 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Invoice\_list.cshtml"
   List<Invoices> InvoiceMDetails = Model.invoiceMList; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"table-responsive pb-2 \">\n    <table id=\"dtList\" class=\"table table-hover table-condensed \">\n        <thead class=\"text-sm\">\n            <tr class=\"col-lg-12\">\n                <th style=\"width:20px\">");
#nullable restore
#line 10 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Invoice\_list.cshtml"
                                  Write(SharedLocalizer.GetLocalizedHtmlString("Id"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                <th>");
#nullable restore
#line 11 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Invoice\_list.cshtml"
               Write(SharedLocalizer.GetLocalizedHtmlString("Customer"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                <th>");
#nullable restore
#line 12 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Invoice\_list.cshtml"
               Write(SharedLocalizer.GetLocalizedHtmlString("Date"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                <th>");
#nullable restore
#line 13 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Invoice\_list.cshtml"
               Write(SharedLocalizer.GetLocalizedHtmlString("Due Date"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                <th>");
#nullable restore
#line 14 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Invoice\_list.cshtml"
               Write(SharedLocalizer.GetLocalizedHtmlString("Amount"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                <th style=\"width:25px\">");
#nullable restore
#line 15 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Invoice\_list.cshtml"
                                  Write(SharedLocalizer.GetLocalizedHtmlString("Edit"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                <th style=\"width:25px\">");
#nullable restore
#line 16 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Invoice\_list.cshtml"
                                  Write(SharedLocalizer.GetLocalizedHtmlString("Delete"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</th>
            </tr>
        </thead>
        <tfoot style=""display:table-row-group"">
            <tr class=""text-center"">
                <th style=""width:20px"">Id</th>
                <th>Customer</th>
                <th>Date</th>
                <th>DueDate</th>
                <th>Amount</th>
                <td></td>
                <td></td>

            </tr>
        </tfoot>
        <tbody>
");
#nullable restore
#line 32 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Invoice\_list.cshtml"
             foreach (var item in InvoiceMDetails)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("<tr class=\"text-center\">\n    <td style=\"width:20px\">");
#nullable restore
#line 36 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Invoice\_list.cshtml"
                      Write(item.InvoiceId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td class=\"text-left\">");
#nullable restore
#line 37 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Invoice\_list.cshtml"
                     Write(item.Customer.CustomerNameEn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 38 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Invoice\_list.cshtml"
   Write(Convert.ToDateTime(item.InvoiceDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 39 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Invoice\_list.cshtml"
   Write(Convert.ToDateTime(item.DueDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td class=\"text-right\">");
#nullable restore
#line 40 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Invoice\_list.cshtml"
                      Write(item.SubTotal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td class=\"text-center padding-5\">\n        <a");
            BeginWriteAttribute("href", " href=\"", 1750, "\"", 1811, 3);
#nullable restore
#line 42 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Invoice\_list.cshtml"
WriteAttributeValue("", 1757, Url.Content("~/"), 1757, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1775, "Finance/Invoice/edit/", 1775, 21, true);
#nullable restore
#line 42 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Invoice\_list.cshtml"
WriteAttributeValue("", 1796, item.InvoiceId, 1796, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-default btn-block  btn-xs \"><i class=\"fal fa-edit\"></i></a>\n    </td>\n    <td class=\"text-center padding-5\">\n        <a href=\"javascript:void(0)\" class=\"btn btn-default btn-block btn-xs \"");
            BeginWriteAttribute("onclick", " onclick=\"", 2015, "\"", 2054, 3);
            WriteAttributeValue("", 2025, "deleteItem(\'", 2025, 12, true);
#nullable restore
#line 45 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Invoice\_list.cshtml"
WriteAttributeValue("", 2037, item.InvoiceId, 2037, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2052, "\')", 2052, 2, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fal fa-times text-danger\"></i></a>\n    </td>\n</tr>            ");
#nullable restore
#line 47 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Invoice\_list.cshtml"
                 }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </tbody>
    </table>
</div>

<script>
    $(function () {
        $('#AccRli').addClass(""menu-open"");
        $('#AccPli').removeClass(""menu-open"");
        $('#Accli').removeClass(""menu-open"");
        $('#Setupli').removeClass(""menu-open"");
        _initDatatable('#dtList');
    });

    function deleteItem(id) {
        confirmAction('Confirm ?', 'Are you sure you want to save changes ?', 'info', 'Yes', 'No').then(function (result) {
            if (result.value == true) {
                $.ajax({
                    url: getApplicationName() + ""Finance/Invoice/Delete"",
                    async: false,
                    type: ""POST"",
                    data: { id },
                    success: function (data) {
                        if (data.result.isError == true) {
                            showMsg('Deleted !', 'Record has been deleted !', 'success');
                            setTimeout(function () {
                                window.location = getApplicationName() + 'Finance/In");
            WriteLiteral(@"voice';
                            }, 500);
                        }
                        else if (data.result.msg != '') {
                            showMsg('Delete Failed !', data.result.msg, 'error');
                        }
                        else {
                            showMsg('Delete Failed !', 'Something went wrong. Try again', 'error');
                        }
                    }
                });
            }
        });
    }
</script>
");
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
