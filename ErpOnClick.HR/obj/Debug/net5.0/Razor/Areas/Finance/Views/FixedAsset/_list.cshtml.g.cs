#pragma checksum "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\FixedAsset\_list.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37b077f89ab2872bbbeccde3afe0fed61c037a8f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Finance_Views_FixedAsset__list), @"mvc.1.0.view", @"/Areas/Finance/Views/FixedAsset/_list.cshtml")]
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
#line 1 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\FixedAsset\_list.cshtml"
using ErpOnClick.DAL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\FixedAsset\_list.cshtml"
using ErpOnClick.ErpMain.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37b077f89ab2872bbbeccde3afe0fed61c037a8f", @"/Areas/Finance/Views/FixedAsset/_list.cshtml")]
    public class Areas_Finance_Views_FixedAsset__list : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\FixedAsset\_list.cshtml"
  
    List<FixedAsset> FixedAssetIdList = Model.FixedAssetIdList;


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"table-responsive pb-2 \">\r\n    <table id=\"dtList\" class=\"table table-hover table-condensed \">\r\n        <thead class=\"text-sm \">\r\n            <tr class=\"col-lg-12\">\r\n                <th style=\"width:20px\">");
#nullable restore
#line 14 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\FixedAsset\_list.cshtml"
                                  Write(SharedLocalizer.GetLocalizedHtmlString("Id"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 15 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\FixedAsset\_list.cshtml"
               Write(SharedLocalizer.GetLocalizedHtmlString("Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 16 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\FixedAsset\_list.cshtml"
               Write(SharedLocalizer.GetLocalizedHtmlString("Chart of Account"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 17 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\FixedAsset\_list.cshtml"
               Write(SharedLocalizer.GetLocalizedHtmlString("Asset Type"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 18 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\FixedAsset\_list.cshtml"
               Write(SharedLocalizer.GetLocalizedHtmlString("Purchase Date"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n                <th>");
#nullable restore
#line 19 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\FixedAsset\_list.cshtml"
               Write(SharedLocalizer.GetLocalizedHtmlString("Warranty Date"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n                <th>");
#nullable restore
#line 20 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\FixedAsset\_list.cshtml"
               Write(SharedLocalizer.GetLocalizedHtmlString("Purchase Price"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n\r\n                <th style=\"width:25px\">");
#nullable restore
#line 22 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\FixedAsset\_list.cshtml"
                                  Write(SharedLocalizer.GetLocalizedHtmlString("Edit"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th style=\"width:25px\">");
#nullable restore
#line 23 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\FixedAsset\_list.cshtml"
                                  Write(SharedLocalizer.GetLocalizedHtmlString("Delete"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</th>
            </tr>
        </thead>
        <tfoot style=""display:table-row-group"">
            <tr class=""text-center"">
                <th style=""width:20px"">ID</th>
                <th>Name</th>
                <th>Chart of Account</th>
                <th>Asset Type</th>
                <th>Purchase Date</th>
                <th>Warranty Date</th>
                <th>Purchase Price </th>

                <td></td>
                <td></td>
            </tr>
        </tfoot>
        <tbody>
");
#nullable restore
#line 41 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\FixedAsset\_list.cshtml"
             foreach (var item in FixedAssetIdList)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"text-center\">\r\n                    <td style=\"width:20px\">");
#nullable restore
#line 44 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\FixedAsset\_list.cshtml"
                                      Write(item.FixedAssetId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"text-left\">");
#nullable restore
#line 45 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\FixedAsset\_list.cshtml"
                                      Write(item.FixedAssetEn != null ? item.FixedAssetEn : "-");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"text-left\">");
#nullable restore
#line 46 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\FixedAsset\_list.cshtml"
                                      Write(item.Account != null && item.Account.AccountNameEn != null ? item.Account.AccountNameEn : "-");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 47 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\FixedAsset\_list.cshtml"
                    Write(item.AssetType != null && item.AssetType.LookupNameEn != null ? item.AssetType.LookupNameEn : "");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 48 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\FixedAsset\_list.cshtml"
                    Write(item.PurchaseDate!= null ? Convert.ToDateTime(item.PurchaseDate).ToString("dd-MMM-yyyy") : "-");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 49 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\FixedAsset\_list.cshtml"
                    Write(item.WarrantyExpiry != null ? Convert.ToDateTime(item.WarrantyExpiry).ToString("dd-MMM-yyyy") : "-");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"text-right\">");
#nullable restore
#line 50 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\FixedAsset\_list.cshtml"
                                       Write(item.PurchasePrice != 0 ? item.PurchasePrice : 0);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    <td class=\"text-center\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 2638, "\"", 2705, 3);
#nullable restore
#line 53 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\FixedAsset\_list.cshtml"
WriteAttributeValue("", 2645, Url.Content("~/"), 2645, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2663, "Finance/FixedAsset/edit/", 2663, 24, true);
#nullable restore
#line 53 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\FixedAsset\_list.cshtml"
WriteAttributeValue("", 2687, item.FixedAssetId, 2687, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-default btn-block  btn-xs \"><i class=\"fal fa-edit\"></i></a>\r\n                    </td>\r\n                    <td class=\"text-center\">\r\n                        <a href=\"javascript:void(0)\" class=\"btn btn-default btn-block btn-xs \"");
            BeginWriteAttribute("onclick", " onclick=\"", 2950, "\"", 2992, 3);
            WriteAttributeValue("", 2960, "deleteItem(\'", 2960, 12, true);
#nullable restore
#line 56 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\FixedAsset\_list.cshtml"
WriteAttributeValue("", 2972, item.FixedAssetId, 2972, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2990, "\')", 2990, 2, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fal fa-times text-danger\"></i></a>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 59 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\FixedAsset\_list.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </tbody>
    </table>
</div>


<script>
    $(function () {
        $('#Accli').addClass(""menu-open"");
        $('#Reportsli').removeClass(""menu-open"");
        $('#Statementsli').removeClass(""menu-open"");
        $('#AccPli').removeClass(""menu-open"");
        $('#AccRli').removeClass(""menu-open"");
        $('#Setupli').removeClass(""menu-open"");

        _initDatatable('#dtList');
    });

    function deleteItem(id) {
        confirmAction('Confirm ?', 'Are you sure you want to save changes ?', 'info', 'Yes', 'No').then(function (result) {
            if (result.value == true) {

                $.ajax({
                    url: getApplicationName() + 'Finance/FixedAsset/delete',
                    async: false,
                    type: ""POST"",
                    data: { id },
                    success: function (data) {
                        if (data.result.isError != true) {
                            showMsg('Deleted !', 'Record has been deleted !', 'success');");
            WriteLiteral(@"
                            setTimeout(function () {
                                window.location = getApplicationName() + 'Finance/FixedAsset';
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
