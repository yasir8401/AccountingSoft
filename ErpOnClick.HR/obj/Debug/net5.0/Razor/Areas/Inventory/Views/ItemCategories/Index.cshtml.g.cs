#pragma checksum "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Inventory\Views\ItemCategories\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "911b91dba5b5ce6e2a152bcfca88c8c345878e68"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Inventory_Views_ItemCategories_Index), @"mvc.1.0.view", @"/Areas/Inventory/Views/ItemCategories/Index.cshtml")]
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
#line 1 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Inventory\Views\ItemCategories\Index.cshtml"
using ErpOnClick.DAL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Inventory\Views\ItemCategories\Index.cshtml"
using ErpOnClick.ErpMain.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"911b91dba5b5ce6e2a152bcfca88c8c345878e68", @"/Areas/Inventory/Views/ItemCategories/Index.cshtml")]
    public class Areas_Inventory_Views_ItemCategories_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Inventory/ItemCategories/edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 5 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Inventory\Views\ItemCategories\Index.cshtml"
   List<ItemCategories> ItemCategories = Model.ItemsIdList; 

#line default
#line hidden
#nullable disable
            DefineSection("TabName", async() => {
                WriteLiteral("\n    Lookup Setup\n");
            }
            );
            WriteLiteral("\n\n<div class=\"card card-default card-outline\">\n\n    <div class=\"card-header\">\n        <h2 class=\"card-title\">\n            ");
#nullable restore
#line 15 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Inventory\Views\ItemCategories\Index.cshtml"
       Write(SharedLocalizer.GetLocalizedHtmlString("Item Categories"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </h2>\n        <!-- tools box -->\n        <div class=\"card-tools float-right\">\n            <a id=\"printList\"");
            BeginWriteAttribute("href", " href=\"", 496, "\"", 503, 0);
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\" class=\"btn btn-default btn-sm\"><i class=\"fal fa-print fa-fw\"></i>");
#nullable restore
#line 19 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Inventory\Views\ItemCategories\Index.cshtml"
                                                                                                                  Write(SharedLocalizer.GetLocalizedHtmlString("Print"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "911b91dba5b5ce6e2a152bcfca88c8c345878e685907", async() => {
                WriteLiteral("\n                <i class=\"fal fa-plus\"></i> ");
#nullable restore
#line 22 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Inventory\Views\ItemCategories\Index.cshtml"
                                       Write(SharedLocalizer.GetLocalizedHtmlString("Add New"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            ");
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
            WriteLiteral(@"
        </div>
        <!-- /. tools -->
    </div>

    <div class=""card-footer pb-0 pt-2 text-sm"">
        <form id=""frmSearch"">
            <div class=""row"">
                <div class=""col-sm-3"">
                    <div class=""form-group "">
                        <label>");
#nullable restore
#line 33 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Inventory\Views\ItemCategories\Index.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Parent Item Category"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n                        <select name=\"ItemCategoryId\" id=\"ItemCategoryId\" class=\"form-control input-sm text-sm \">\n                            <option");
            BeginWriteAttribute("value", " value=\"", 1350, "\"", 1358, 0);
            EndWriteAttribute();
            WriteLiteral(">All</option>\n");
#nullable restore
#line 36 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Inventory\Views\ItemCategories\Index.cshtml"
                                 foreach (var item in ItemCategories)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <option");
            BeginWriteAttribute("value", " value=\"", 1520, "\"", 1548, 1);
#nullable restore
#line 38 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Inventory\Views\ItemCategories\Index.cshtml"
WriteAttributeValue("", 1528, item.ItemCategoryId, 1528, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 38 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Inventory\Views\ItemCategories\Index.cshtml"
                                                                     Write(item.ItemCategoryNameEn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\n");
#nullable restore
#line 39 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Inventory\Views\ItemCategories\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </select>
                    </div>
                </div>
                <div style=""display:none"">
                    <button type=""submit"" class=""btn btn-default btn-block"">Refresh</button>
                </div>
            </div>
        </form>
    </div>
    <div class=""card-body"">
        <div id=""divList""></div>

    </div>
</div>



");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        $(function () {
            $('#Inventoryli').addClass(""menu-open"");
            $('#ACReceivablesli').removeClass(""menu-open"");
            $('#ACPayablesli').removeClass(""menu-open"");
            $('#Accountingli').removeClass(""menu-open"");
            $('#Setupli').removeClass(""menu-open"");
            $('#frmSearch button').click();
        });

        $('#frmSearch').find('input, select').change(() => {
            $('#frmSearch button').click();
        });

        $('#frmSearch').submit(function (e) {
            e.preventDefault();
            BindGrid();

        });


        function BindGrid() {
            
            $('#divList').html('<h5 class=""margin-0""><p><i class=""fal fa-spinner fa-spin fa-fw""></i> Please wait while data is loading...</p></h5>');
            $.ajax({
                url: getApplicationName() + 'Inventory/ItemCategories/_list',
                data: $('#frmSearch').serialize(),
                success: function (data) {
                    $('#divLi");
                WriteLiteral(@"st').html(data);
                }
            })
        }

        $('#printList').click(function (e) {
            var ItemCategoryId = $('#ItemCategoryId').val();
            window.open(getApplicationName() + ""Inventory/ItemCategories/PrintList?ItemCategoryId="" + ItemCategoryId, ""_blank"");
        });
    </script>
");
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
