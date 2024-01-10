#pragma checksum "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\AccountGroups\_list.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f97e9d1586e8f6faa7c3f62a7d87cd4bdda4a94d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Finance_Views_AccountGroups__list), @"mvc.1.0.view", @"/Areas/Finance/Views/AccountGroups/_list.cshtml")]
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
#line 1 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\AccountGroups\_list.cshtml"
using ErpOnClick.DAL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\AccountGroups\_list.cshtml"
using ErpOnClick.ErpMain.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f97e9d1586e8f6faa7c3f62a7d87cd4bdda4a94d", @"/Areas/Finance/Views/AccountGroups/_list.cshtml")]
    public class Areas_Finance_Views_AccountGroups__list : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\AccountGroups\_list.cshtml"
  
    List<AccountGroups> AccountGroupIdList = Model.AccountGroupsIdList;
    List<AccountGroups> AccountsGroups = Model.AccountsGroups;


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"table-responsive pb-2 \">\r\n    <table id=\"dtList\" class=\"table table-hover table-condensed \">\r\n        <thead class=\"text-sm \">\r\n            <tr class=\"col-lg-12\">\r\n                <th style=\"width:20px\">");
#nullable restore
#line 15 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\AccountGroups\_list.cshtml"
                                  Write(SharedLocalizer.GetLocalizedHtmlString("Id"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 16 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\AccountGroups\_list.cshtml"
               Write(SharedLocalizer.GetLocalizedHtmlString("Group Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 17 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\AccountGroups\_list.cshtml"
               Write(SharedLocalizer.GetLocalizedHtmlString("Group Name Arabic"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 18 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\AccountGroups\_list.cshtml"
               Write(SharedLocalizer.GetLocalizedHtmlString("Group Code"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 19 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\AccountGroups\_list.cshtml"
               Write(SharedLocalizer.GetLocalizedHtmlString("Parent Category"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</th>


                <th > </th>
    
            </tr>
        </thead>
        <tfoot style=""display:table-row-group"">
            <tr class=""text-center"">
                <th style=""width:20px"">ID</th>
                <th>Group Name EN</th>
                <th>Group Name AR</th>
                <th>Group Code</th>
                <th>Parent Category</th>


                <td></td>
            
            </tr>
        </tfoot>
        <tbody>
");
#nullable restore
#line 40 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\AccountGroups\_list.cshtml"
             foreach (var item in AccountGroupIdList)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"text-center\">\r\n                    <td style=\"width:20px\">");
#nullable restore
#line 44 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\AccountGroups\_list.cshtml"
                                       Write(item.AccountGroupId != 0 ? item.AccountGroupId : 0);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"text-left\">");
#nullable restore
#line 45 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\AccountGroups\_list.cshtml"
                                      Write(item.AccountGroupNameEn != null ? item.AccountGroupNameEn : "-");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"text-right\">");
#nullable restore
#line 46 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\AccountGroups\_list.cshtml"
                                       Write(item.AccountGroupNameAr != null ? item.AccountGroupNameAr: "-");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 47 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\AccountGroups\_list.cshtml"
                    Write(item.AccountGroupCode != null ? item.AccountGroupCode : "-");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n");
#nullable restore
#line 49 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\AccountGroups\_list.cshtml"
                         foreach (var list in AccountsGroups)
                        {
                            if (item.ParentAccountGroupId == list.AccountGroupId)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\AccountGroups\_list.cshtml"
                           Write(list.AccountGroupNameEn);

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\AccountGroups\_list.cshtml"
                                                        
                            }
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                    <td class=\"text-center\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 2306, "\"", 2378, 3);
#nullable restore
#line 58 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\AccountGroups\_list.cshtml"
WriteAttributeValue("", 2313, Url.Content("~/"), 2313, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2331, "Finance/AccountGroups/edit/", 2331, 27, true);
#nullable restore
#line 58 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\AccountGroups\_list.cshtml"
WriteAttributeValue("", 2358, item.AccountGroupId, 2358, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-default   btn-xs \"><i class=\"fal fa-edit\"></i></a>\r\n                 \r\n                        <a href=\"javascript:void(0)\" class=\"btn btn-default  btn-xs \"");
            BeginWriteAttribute("onclick", " onclick=\"", 2551, "\"", 2595, 3);
            WriteAttributeValue("", 2561, "deleteItem(\'", 2561, 12, true);
#nullable restore
#line 60 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\AccountGroups\_list.cshtml"
WriteAttributeValue("", 2573, item.AccountGroupId, 2573, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2593, "\')", 2593, 2, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fal fa-times text-danger\"></i></a>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 63 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\AccountGroups\_list.cshtml"
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
                    url: getApplicationName() + 'Finance/AccountGroups/delete',
                    async: false,
                    type: ""POST"",
                    data: { id },
                    success: function (data) {
                        if (data.result.isError != true) {
                            showMsg('Deleted !', 'Record has been deleted !', 'success'");
            WriteLiteral(@");
                            setTimeout(function () {
                                window.location = getApplicationName() + 'Finance/AccountGroups';
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
