#pragma checksum "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\OtherComprehensiveIncome\_list.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df056a0c727abb1b55b1be21f498d2ae97b1bd32"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Finance_Views_OtherComprehensiveIncome__list), @"mvc.1.0.view", @"/Areas/Finance/Views/OtherComprehensiveIncome/_list.cshtml")]
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
#line 1 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\OtherComprehensiveIncome\_list.cshtml"
using ErpOnClick.DAL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\OtherComprehensiveIncome\_list.cshtml"
using ErpOnClick.ErpMain.Models.Finance;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\OtherComprehensiveIncome\_list.cshtml"
using ErpOnClick.ErpMain.Resources;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\OtherComprehensiveIncome\_list.cshtml"
using ErpOnClick.DAL.Utilities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df056a0c727abb1b55b1be21f498d2ae97b1bd32", @"/Areas/Finance/Views/OtherComprehensiveIncome/_list.cshtml")]
    public class Areas_Finance_Views_OtherComprehensiveIncome__list : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 10 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\OtherComprehensiveIncome\_list.cshtml"
  
    OtherComprehensiveIncomeViewModel otherComprehensiveIncomeViewModel = Model.otherComprehensiveIncomeViewModel;

    var filePath = NativePaths.GetFilePath(_env);
    var img = "Erponclick.png";



#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "df056a0c727abb1b55b1be21f498d2ae97b1bd324561", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 472, "~/css/Report.css?v=inv_", 472, 23, true);
#nullable restore
#line 18 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\OtherComprehensiveIncome\_list.cshtml"
AddHtmlAttributeValue("", 495, DateTime.Now.ToString("mm"), 495, 28, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<div class=""table-responsive pb-2 "">
    <table id=""pltable"" class=""table table-hover table-condensed "">
        <thead class=""text-sm "">
            <tr class=""text-center"">
                <th colspan=""4"">
                    <img style=""-webkit-user-select: none""");
            BeginWriteAttribute("src", " src=\"", 817, "\"", 836, 2);
#nullable restore
#line 24 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\OtherComprehensiveIncome\_list.cshtml"
WriteAttributeValue("", 823, filePath, 823, 9, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\OtherComprehensiveIncome\_list.cshtml"
WriteAttributeValue("", 832, img, 832, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" width=""20%"" />
                    <h4>
                        STATEMENT OF OTHER COMPREHENSIVE INCOME
                    </h4>
                </th>
            </tr>
            <tr class=""col-lg-12 text-center"">
                <th width=""40%""> ");
#nullable restore
#line 31 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\OtherComprehensiveIncome\_list.cshtml"
                            Write(SharedLocalizer.GetLocalizedHtmlString(""));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n                <th width=\"10%\"> ");
#nullable restore
#line 32 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\OtherComprehensiveIncome\_list.cshtml"
                            Write(SharedLocalizer.GetLocalizedHtmlString("Notes"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n                <th width=\"25%\"> ");
#nullable restore
#line 33 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\OtherComprehensiveIncome\_list.cshtml"
                            Write(SharedLocalizer.GetLocalizedHtmlString("2021"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br /> ");
#nullable restore
#line 33 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\OtherComprehensiveIncome\_list.cshtml"
                                                                                   Write(SharedLocalizer.GetLocalizedHtmlString("--Rupees-- "));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th width=\"25%\"> ");
#nullable restore
#line 34 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\OtherComprehensiveIncome\_list.cshtml"
                            Write(SharedLocalizer.GetLocalizedHtmlString("2020"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br /> ");
#nullable restore
#line 34 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\OtherComprehensiveIncome\_list.cshtml"
                                                                                   Write(SharedLocalizer.GetLocalizedHtmlString("--Rupees-- "));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td class=""text-left""></td>
                <td> </td>
                <td> </td>
                <td> </td>
            </tr>
            <tr>
                <td class=""text-left""> Profit / (loss) After Taxation </td>
                <td></td>
                <td class=""text-center""> ");
#nullable restore
#line 47 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\OtherComprehensiveIncome\_list.cshtml"
                                    Write(otherComprehensiveIncomeViewModel.PLAT_2021);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"text-center\"> ");
#nullable restore
#line 48 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\OtherComprehensiveIncome\_list.cshtml"
                                    Write(otherComprehensiveIncomeViewModel.PLAT_2020);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
            </tr>
            <tr>
                <td class=""text-left""></td>
                <td> </td>
                <td> </td>
                <td> </td>
            </tr>
            <tr>
                <td class=""text-left""></td>
                <td> </td>
                <td> </td>
                <td> </td>
            </tr>
            <tr>
                <td class=""text-left""> Other Comprehensive Income for the Period </td>
                <td></td>
                <td class=""text-center""> ");
#nullable restore
#line 65 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\OtherComprehensiveIncome\_list.cshtml"
                                    Write(otherComprehensiveIncomeViewModel.OCI_2021);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"text-center\"> ");
#nullable restore
#line 66 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\OtherComprehensiveIncome\_list.cshtml"
                                    Write(otherComprehensiveIncomeViewModel.OCI_2020);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
            </tr>
            <tr>
                <td class=""text-left""></td>
                <td> </td>
                <td> </td>
                <td> </td>
            </tr>
            <tr>
                <td class=""text-left""></td>
                <td> </td>
                <td> </td>
                <td> </td>
            </tr>
            <tr>
                <td class=""text-left""> Total Comprehensive Income for the Period </td>
                <td></td>
                <td class=""text-center b-b b-t b-lr""> ");
#nullable restore
#line 83 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\OtherComprehensiveIncome\_list.cshtml"
                                                 Write(otherComprehensiveIncomeViewModel.TCI_2021);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"text-center b-b b-t b-lr\"> ");
#nullable restore
#line 84 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\OtherComprehensiveIncome\_list.cshtml"
                                                 Write(otherComprehensiveIncomeViewModel.TCI_2020);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
            </tr>
            <tr>
                <td class=""text-left""></td>
                <td> </td>
                <td> </td>
                <td> </td>
            </tr>
            <tr class=""signatrure-table"">
                <td style=""display: none;""></td>
                <td colspan=""2"" class=""signatrure-section""><span>Chief Executive Officer</span></td>
                <td colspan=""2"" class=""signatrure-section""><span>Director</span></td>
                <td style=""display: none;""></td>
            </tr>
        </tbody>
    </table>
    <br />
    <br />
    <br />
</div>

<style>
    button.dt-button, div.dt-button, a.dt-button {
        font-weight: 900;
        letter-spacing: 2px;
        border-radius: 5px !important;
        border-color: silver !important;
        background-color: #f8f9fa !important;
        border-color: #ddd !important;
        color: #444 !important;
        padding: .25rem .5rem !important;
        font-size: .875rem !important;
");
            WriteLiteral(@"        line-height: 1.5 !important;
        border-radius: .2rem !important;
        position: relative;
    }

    div.dt-buttons {
        float: right !important;
    }

    button.dt-button:before {
        font-family: ""Font Awesome 5 Free"";
        top: 0;
        left: -5px;
        padding-right: 10px;
        content: ""\f56e"";
    }
</style>


<script>
    $(function () {
        $('#Accli').addClass(""menu-open"");
        $('#Statementsli').addClass(""menu-open"");
        $('#Reportsli').removeClass(""menu-open"");
        $('#AccRli').removeClass(""menu-open"");
        $('#AccPli').removeClass(""menu-open"");
        $('#Setupli').removeClass(""menu-open"");

        // DataTable
        var table = $('#pltable').DataTable({
            //""order"": [[0, ""desc""]],
            dom: 'Bfrtip',
            ordering: false,
            paging: false,
            info: false,
            searching: false,
            buttons: [
                'excel'
            ]
        })");
            WriteLiteral(";\r\n    });\r\n</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public LocService SharedLocalizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Hosting.IHostingEnvironment _env { get; private set; }
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
