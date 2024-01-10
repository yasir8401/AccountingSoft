#pragma checksum "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\OtherComprehensiveIncome\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d867c49390d87bdd34e0dbc24598c8245edfe36"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Finance_Views_OtherComprehensiveIncome_Index), @"mvc.1.0.view", @"/Areas/Finance/Views/OtherComprehensiveIncome/Index.cshtml")]
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
#line 1 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\OtherComprehensiveIncome\Index.cshtml"
using ErpOnClick.DAL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\OtherComprehensiveIncome\Index.cshtml"
using ErpOnClick.ErpMain.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d867c49390d87bdd34e0dbc24598c8245edfe36", @"/Areas/Finance/Views/OtherComprehensiveIncome/Index.cshtml")]
    public class Areas_Finance_Views_OtherComprehensiveIncome_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("\n<div class=\"card card-default card-outline\">\n    <div class=\"card-header\">\n        <h2 class=\"card-title\">\n            ");
#nullable restore
#line 12 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\OtherComprehensiveIncome\Index.cshtml"
       Write(SharedLocalizer.GetLocalizedHtmlString("Statement of Other Comprehensive Income"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </h2>\n        <!-- tools box -->\n        <div class=\"card-tools fa-pull-right\">\n            <a id=\"printList\"");
            BeginWriteAttribute("href", " href=\"", 428, "\"", 435, 0);
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\" class=\"btn btn-default btn-sm\"><i class=\"fal fa-print fa-fw\"></i>");
#nullable restore
#line 16 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\OtherComprehensiveIncome\Index.cshtml"
                                                                                                                  Write(SharedLocalizer.GetLocalizedHtmlString("Print"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n        </div>\n        <!-- /. tools -->\n    </div>\n    <div class=\"card-body\">\n        <div id=\"divList\"></div>\n\n    </div>\n</div>\n\n\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        $(function () {
            $('#Accli').addClass(""menu-open"");
            $('#Statementsli').addClass(""menu-open"");
            $('#Reportsli').removeClass(""menu-open"");
            $('#AccRli').removeClass(""menu-open"");
            $('#AccPli').removeClass(""menu-open"");
            $('#Setupli').removeClass(""menu-open"");

            BindGrid();
        });

        function BindGrid() {

            $('#divList').html('<h5 class=""margin-0""><p><i class=""fa fa-spinner fa-spin fa-fw""></i> Please wait while data is loading...</p></h5>');
            $.ajax({
                url: getApplicationName() + 'Finance/OtherComprehensiveIncome/_list',
                data: $('#frmSearch').serialize(),
                success: function (data) {
                    $('#divList').html(data);
                }
            })
        }

        $('#printList').click(function (e) {
            window.open(getApplicationName() + ""Finance/OtherComprehensiveIncome/PrintList"", ""_blank"");
        });
  ");
                WriteLiteral("  </script>\n");
            }
            );
            WriteLiteral("\n");
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
