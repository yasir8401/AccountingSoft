#pragma checksum "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Areas\Admin\Views\VacantJobs\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "560f8d48717196b28248849622896998cd6ed16d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_VacantJobs_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/VacantJobs/Index.cshtml")]
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
#line 1 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Areas\Admin\Views\VacantJobs\Index.cshtml"
using ErpOnClick.DAL.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"560f8d48717196b28248849622896998cd6ed16d", @"/Areas/Admin/Views/VacantJobs/Index.cshtml")]
    public class Areas_Admin_Views_VacantJobs_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/vacantjobs/edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn  btn-sm btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Areas\Admin\Views\VacantJobs\Index.cshtml"
  
    List<Lookups> deptList = Model.deptList;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            DefineSection("TabName", async() => {
                WriteLiteral("\r\n    Vacant jobs Setup\r\n");
            }
            );
            WriteLiteral("\r\n\r\n<div class=\"card card-default card-outline\">\r\n\r\n    <div class=\"card-header\">\r\n        <h2 class=\"card-title\">\r\n            Jobs\r\n        </h2>\r\n        <!-- tools box -->\r\n        <div class=\"card-tools\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "560f8d48717196b28248849622896998cd6ed16d4660", async() => {
                WriteLiteral("\r\n                <i class=\"fas fa-plus\"></i> Add New\r\n            ");
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
                        <label>Department</label>
                        <select id=""JobDepartmentId"" name=""JobDepartmentId"" class=""form-control input-sm text-sm"" >
                            <option");
            BeginWriteAttribute("value", " value=\"", 966, "\"", 974, 0);
            EndWriteAttribute();
            WriteLiteral(">All</option>\r\n");
#nullable restore
#line 35 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Areas\Admin\Views\VacantJobs\Index.cshtml"
                             foreach (var item in deptList)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <option");
            BeginWriteAttribute("value", " value=\"", 1121, "\"", 1139, 1);
#nullable restore
#line 37 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Areas\Admin\Views\VacantJobs\Index.cshtml"
WriteAttributeValue("", 1129, item.Code, 1129, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    ");
#nullable restore
#line 38 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Areas\Admin\Views\VacantJobs\Index.cshtml"
                               Write(item.LookupNameEn);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </option>\r\n");
#nullable restore
#line 40 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Areas\Admin\Views\VacantJobs\Index.cshtml"
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
            $('#frmSearch button').click();
        });

        $('#frmSearch').find('input, select').change(() => {
            $('#frmSearch button').click();
        });

        $('#frmSearch').submit(function (e) {
            e.preventDefault();
            BindGrid();
        })
        var applicationName = getApplicationName();


        function BindGrid() {



            $('#divList').html('<h5 class=""margin-0""><p><i class=""fa fa-spinner fa-spin fa-fw""></i> Please wait while data is loading...</p></h5>');
            $.ajax({
                url: applicationName+'admin/vacantjobs/_list',
                data: $('#frmSearch').serialize(),
                success: function (data) {
                    $('#divList').html(data);
                }
            })
        };

    </script>
");
            }
            );
        }
        #pragma warning restore 1998
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