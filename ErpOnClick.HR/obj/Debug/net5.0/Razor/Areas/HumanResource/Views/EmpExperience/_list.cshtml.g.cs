#pragma checksum "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpExperience\_list.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5997827d8371f6304c95f46286692c043435d108"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_HumanResource_Views_EmpExperience__list), @"mvc.1.0.view", @"/Areas/HumanResource/Views/EmpExperience/_list.cshtml")]
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
#line 1 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpExperience\_list.cshtml"
using ErpOnClick.DAL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpExperience\_list.cshtml"
using ErpOnClick.ErpMain.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5997827d8371f6304c95f46286692c043435d108", @"/Areas/HumanResource/Views/EmpExperience/_list.cshtml")]
    public class Areas_HumanResource_Views_EmpExperience__list : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default btn-block  btn-xs "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpExperience\_list.cshtml"
  
    List<EmpExperience> EmpexprnceList = Model.EmpexprnceList;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"table-responsive pb-2 \">\r\n    <table id=\"dtList\" class=\"table table-hover table-condensed \" style=\"display:none\">\r\n        <thead class=\"text-sm\">\r\n            <tr>\r\n                <th> ");
#nullable restore
#line 14 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpExperience\_list.cshtml"
                Write(SharedLocalizer.GetLocalizedHtmlString("Id"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n                <th> ");
#nullable restore
#line 15 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpExperience\_list.cshtml"
                Write(SharedLocalizer.GetLocalizedHtmlString("Job Title"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n                <th> ");
#nullable restore
#line 16 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpExperience\_list.cshtml"
                Write(SharedLocalizer.GetLocalizedHtmlString("Location"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </th>
                <th width=""30px""></th>
                <th width=""30px""></th>
            </tr>
        </thead>
        <tfoot style=""display:table-row-group"">
            <tr class=""text-center"">
                <th> Id </th>
                <th> Job Title </th>
                <th> Location </th>
                <th></th>
                <th></th>
            </tr>
        </tfoot>
        <tbody>
");
#nullable restore
#line 31 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpExperience\_list.cshtml"
             foreach (var item in EmpexprnceList)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"text-center\">\r\n\r\n                    <td");
            BeginWriteAttribute("class", " class=\"", 1146, "\"", 1154, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 36 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpExperience\_list.cshtml"
                            Write(item.EmpExperienceId);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td class=\"text-left\">");
#nullable restore
#line 37 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpExperience\_list.cshtml"
                                     Write(item.JobTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td class=\"text-left\">");
#nullable restore
#line 38 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpExperience\_list.cshtml"
                                     Write(item.WorkLocation);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td class=\"text-center padding-5\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5997827d8371f6304c95f46286692c043435d1087159", async() => {
                WriteLiteral("<i class=\"fal fa-edit\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1406, "~/HumanResource/EmpExperience/edit/", 1406, 35, true);
#nullable restore
#line 40 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpExperience\_list.cshtml"
AddHtmlAttributeValue("", 1441, item.EmpExperienceId, 1441, 21, false);

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
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"text-center padding-5\">\r\n                        <a href=\"javascript:void(0)\" class=\"btn btn-default btn-block btn-xs \"");
            BeginWriteAttribute("onclick", " onclick=\"", 1717, "\"", 1762, 3);
            WriteAttributeValue("", 1727, "deleteItem(\'", 1727, 12, true);
#nullable restore
#line 43 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpExperience\_list.cshtml"
WriteAttributeValue("", 1739, item.EmpExperienceId, 1739, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1760, "\')", 1760, 2, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fal fa-times text-danger\"></i></a>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 46 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpExperience\_list.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </tbody>
    </table>
</div>


<script>
    $(function () {

        _initDatatable('#dtList');
        $('#dtList').show();
    });
    var applicationName = getApplicationName();

    function deleteItem(id) {
        confirmAction('Confirm ?', 'Are you sure you want to save changes ?', 'info', 'Yes', 'No').then(function (result) {
            if (result.value == true) {

                $.ajax({
                    url: applicationName + ""HumanResource/EmpExperience/delete"",
                    async: false,
                    type: ""POST"",
                    data: { id },
                    success: function (data) {
                        if (data.result.isError != true) {
                            showMsg('Deleted !', 'Record has been deleted !', 'success');
                            setTimeout(function () {
                                window.location = applicationName + 'HumanResource/EmpExperience';
                            }, 500);
                  ");
            WriteLiteral(@"      }
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
