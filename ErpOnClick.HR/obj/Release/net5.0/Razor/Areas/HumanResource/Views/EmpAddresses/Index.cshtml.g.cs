#pragma checksum "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpAddresses\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b7b79f1ed970ae6be0f968383fd73abd20797c6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_HumanResource_Views_EmpAddresses_Index), @"mvc.1.0.view", @"/Areas/HumanResource/Views/EmpAddresses/Index.cshtml")]
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
#line 1 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpAddresses\Index.cshtml"
using ErpOnClick.DAL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpAddresses\Index.cshtml"
using ErpOnClick.ErpMain.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b7b79f1ed970ae6be0f968383fd73abd20797c6", @"/Areas/HumanResource/Views/EmpAddresses/Index.cshtml")]
    public class Areas_HumanResource_Views_EmpAddresses_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn  btn-sm btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpAddresses\Index.cshtml"
  

    var empId = Model.empId;
    Emp empDetails = Model.empDetails;


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("TabName", async() => {
                WriteLiteral("\r\n    Vacant jobs Setup\r\n");
            }
            );
            WriteLiteral("\r\n\r\n<form id=\"frmList\">\r\n    <input type=\"hidden\" id=\"EmpId\" name=\"EmpId\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 327, "\"", 341, 1);
#nullable restore
#line 18 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpAddresses\Index.cshtml"
WriteAttributeValue("", 335, empId, 335, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />

    <div class=""card card-default card-outline"">
        <div class=""card-header p-0 border-bottom-0"">
            <div class=""card"" style=""background-color: #496b6a"">
            </div>
            <ul class=""nav nav-tabs"" id=""custom-content-below-tab"" role=""tablist"">
");
            WriteLiteral("                ");
#nullable restore
#line 28 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpAddresses\Index.cshtml"
           Write(Html.Partial("/Areas/HumanResource/Views/Emp/_tabsPartial.cshtml", empDetails));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </ul>\r\n        </div>\r\n\r\n\r\n        <div class=\"card-header\">\r\n            <h2 class=\"card-title\">\r\n                ");
#nullable restore
#line 35 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpAddresses\Index.cshtml"
           Write(SharedLocalizer.GetLocalizedHtmlString("Employee Addresses"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </h2>\r\n            <!-- tools box -->\r\n            <div class=\"card-tools float-right\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b7b79f1ed970ae6be0f968383fd73abd20797c66166", async() => {
                WriteLiteral("\r\n                    <i class=\"fal fa-plus\"></i>");
#nullable restore
#line 40 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpAddresses\Index.cshtml"
                                          Write(SharedLocalizer.GetLocalizedHtmlString("Add New"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1288, "~/HumanResource/EmpAddresses/edit/emp/", 1288, 38, true);
#nullable restore
#line 39 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpAddresses\Index.cshtml"
AddHtmlAttributeValue("", 1326, empId, 1326, 6, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n            <!-- /. tools -->\r\n        </div>\r\n\r\n\r\n\r\n        <div class=\"card-body\">\r\n            <div id=\"divList\"></div>\r\n\r\n        </div>\r\n    </div>\r\n</form>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        $(function () {
            $(""#tabAddress-tab"").css(""background-color"", ""#496b6a"");
            $(""#tabAddress-tab"").css(""color"", ""white"");
            //$(""#tabAddress-tab"").addClass(""nav-link active"");
            BindGrid();
        });

        var applicationName = getApplicationName();

        function BindGrid() {

            var test = $('#frmSearch').serialize();

            $('#divList').html('<h5 class=""margin-0""><p><i class=""fa fa-spinner fa-spin fa-fw""></i> Please wait while data is loading...</p></h5>');
            $.ajax({
                url: applicationName + 'HumanResource/EmpAddresses/_list',
                data: $('#frmList').serialize(),
                success: function (data) {
                    $('#divList').html(data);
                }
            })
        };
        function navigation() {
            window.location = applicationName +'HumanResource/emp/edit/");
#nullable restore
#line 80 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpAddresses\Index.cshtml"
                                                                  Write(empId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\'\r\n        };\r\n    </script>\r\n");
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
