#pragma checksum "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\Module\edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e3b63237e97bff81ef6f2e4a2750fd18690cfde"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Security_Views_Module_edit), @"mvc.1.0.view", @"/Areas/Security/Views/Module/edit.cshtml")]
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
#line 1 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\Module\edit.cshtml"
using ErpOnClick.DAL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\Module\edit.cshtml"
using ErpOnClick.ErpMain.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\Module\edit.cshtml"
using ErpOnClick.ErpMain.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e3b63237e97bff81ef6f2e4a2750fd18690cfde", @"/Areas/Security/Views/Module/edit.cshtml")]
    public class Areas_Security_Views_Module_edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Security/Module"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn  btn-sm btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 6 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\Module\edit.cshtml"
  


    IList<Branch> branchList = Model.branchList;
    IList<Company> companyList = Model.companyList;

    Modules ModuleDetails = Model.ModuleDetails;
    bool isEdit = (ModuleDetails != null);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<form id=\"frmEdit\" role=\"form\">\r\n    <input type=\"hidden\" id=\"ACTION_TYPE\" name=\"ACTION_TYPE\"");
            BeginWriteAttribute("value", " value=\"", 448, "\"", 485, 1);
#nullable restore
#line 19 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\Module\edit.cshtml"
WriteAttributeValue("", 456, isEdit ? "update" : "save", 456, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input type=\"hidden\" id=\"ModuleId\" name=\"ModuleId\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 566, "\"", 627, 1);
#nullable restore
#line 20 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\Module\edit.cshtml"
WriteAttributeValue("", 574, ModuleDetails != null ? ModuleDetails.ModuleId : 0, 574, 53, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 20 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\Module\edit.cshtml"
                                                                                                                                      Write(isEdit ? "readonly" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(" min=\"3\" maxlength=\"3\">\r\n    <input type=\"hidden\" id=\"CompanyId\" name=\"CompanyId\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 758, "\"", 820, 1);
#nullable restore
#line 21 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\Module\edit.cshtml"
WriteAttributeValue("", 766, ModuleDetails != null ? ModuleDetails.CompanyId : 0, 766, 54, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" >\r\n    <input type=\"hidden\" id=\"BranchId\" name=\"BranchId\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 900, "\"", 961, 1);
#nullable restore
#line 22 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\Module\edit.cshtml"
WriteAttributeValue("", 908, ModuleDetails != null ? ModuleDetails.BranchId : 0, 908, 53, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" >\r\n\r\n    <div class=\"card card-default card-outline col-lg-8\">\r\n\r\n        <div class=\"card-header\">\r\n            <h2 class=\"card-title\">\r\n                ");
#nullable restore
#line 28 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\Module\edit.cshtml"
           Write(SharedLocalizer.GetLocalizedHtmlString("Details"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </h2>\r\n            <!-- tools box -->\r\n            <div class=\"card-tools float-right\">\r\n                <button type=\"submit\" class=\"btn  btn-sm btn-primary\">\r\n                    <i class=\"fal fa-save fa-fw\"></i> ");
#nullable restore
#line 33 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\Module\edit.cshtml"
                                                 Write(SharedLocalizer.GetLocalizedHtmlString("Save"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </button>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e3b63237e97bff81ef6f2e4a2750fd18690cfde8441", async() => {
                WriteLiteral("\r\n                    <i class=\"fal fa-arrow-left fa-fw\"></i> ");
#nullable restore
#line 36 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\Module\edit.cshtml"
                                                       Write(SharedLocalizer.GetLocalizedHtmlString("Return"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
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
            WriteLiteral("\r\n            </div>\r\n            <!-- /. tools -->\r\n        </div>\r\n        <div class=\"card-body\">\r\n\r\n            <div class=\"row\">\r\n                <div class=\"col-sm-6\">\r\n                    <div class=\"form-group\">\r\n                        <label>");
#nullable restore
#line 46 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\Module\edit.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <input type=\"text\" id=\"ModuleNameEn\" name=\"ModuleNameEn\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 2105, "\"", 2168, 1);
#nullable restore
#line 47 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\Module\edit.cshtml"
WriteAttributeValue("", 2113, ModuleDetails!=null?ModuleDetails.ModuleNameEn: null, 2113, 55, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" required>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-sm-6\">\r\n                    <div class=\"form-group\">\r\n                        <label> ");
#nullable restore
#line 52 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\Module\edit.cshtml"
                           Write(SharedLocalizer.GetLocalizedHtmlString("Name Arabic"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <input type=\"text\" id=\"ModuleNameAr\" name=\"ModuleNameAr\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 2516, "\"", 2579, 1);
#nullable restore
#line 53 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\Module\edit.cshtml"
WriteAttributeValue("", 2524, ModuleDetails!=null?ModuleDetails.ModuleNameAr: null, 2524, 55, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-sm-6\">\r\n                    <div class=\"form-group\">\r\n                        <label>");
#nullable restore
#line 58 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\Module\edit.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Code"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <input type=\"text\" id=\"ModuleCode\" name=\"ModuleCode\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 2906, "\"", 2967, 1);
#nullable restore
#line 59 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\Module\edit.cshtml"
WriteAttributeValue("", 2914, ModuleDetails!=null?ModuleDetails.ModuleCode: null, 2914, 53, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-sm-6\">\r\n                    <div class=\"form-group\">\r\n                        <label>");
#nullable restore
#line 64 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\Module\edit.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Display Order"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <input type=\"number\" id=\"DisplayOrder\" name=\"DisplayOrder\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 3309, "\"", 3369, 1);
#nullable restore
#line 65 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\Module\edit.cshtml"
WriteAttributeValue("", 3317, ModuleDetails!=null?ModuleDetails.DisplayOrder: 0, 3317, 52, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-sm-6\">\r\n                    <div class=\"form-group\">\r\n                        <label>");
#nullable restore
#line 70 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\Module\edit.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Url"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <input type=\"text\" id=\"ModuleUrl\" name=\"ModuleUrl\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 3693, "\"", 3753, 1);
#nullable restore
#line 71 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\Module\edit.cshtml"
WriteAttributeValue("", 3701, ModuleDetails!=null?ModuleDetails.ModuleUrl: null, 3701, 52, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-sm-6\">\r\n                    <div class=\"form-group\">\r\n                        <label>");
#nullable restore
#line 76 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\Module\edit.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Icon Css-Class"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <input type=\"text\" id=\"ModuleIcon\" name=\"ModuleIcon\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 4090, "\"", 4151, 1);
#nullable restore
#line 77 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\Module\edit.cshtml"
WriteAttributeValue("", 4098, ModuleDetails!=null?ModuleDetails.ModuleIcon: null, 4098, 53, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                </div>



            </div>
        </div>

    </div>
    <div class=""card card-default card-outline col-lg-8"">
        <div class=""card-header"">
            <h2 class=""card-title"">
                ");
#nullable restore
#line 90 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\Module\edit.cshtml"
           Write(SharedLocalizer.GetLocalizedHtmlString("More Details"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n            </h2>\r\n        </div>\r\n        <div class=\"card-body\">\r\n            <div class=\"row\">\r\n                <div class=\"col-sm-6\">\r\n                    <div class=\"form-group\">\r\n                        <label>");
#nullable restore
#line 97 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\Module\edit.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Is-Visible"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <select id=\"IsVisible\" name=\"IsVisible\" class=\"form-control\">\r\n");
            WriteLiteral("                            <option value=\"True\" ");
#nullable restore
#line 100 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\Module\edit.cshtml"
                                             Write(ModuleDetails != null && ModuleDetails.IsVisible == true ? "selected" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(">Visible</option>\r\n                            <option value=\"False\" ");
#nullable restore
#line 101 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\Module\edit.cshtml"
                                              Write(ModuleDetails != null && ModuleDetails.IsVisible == false ? "selected" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(">Not Visible</option>\r\n                        </select>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-sm-6\">\r\n                    <div class=\"form-group\">\r\n                        <label>");
#nullable restore
#line 107 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\Module\edit.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Is-Disable"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <select id=\"IsDisable\" name=\"IsDisable\" class=\"form-control\">\r\n");
            WriteLiteral("                            <option value=\"True\" ");
#nullable restore
#line 110 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\Module\edit.cshtml"
                                             Write(ModuleDetails != null && ModuleDetails.IsDisable == true ? "selected" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(">Disable</option>\r\n                            <option value=\"False\" ");
#nullable restore
#line 111 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\Module\edit.cshtml"
                                              Write(ModuleDetails != null && ModuleDetails.IsDisable == false ? "selected" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(">Not-Disable</option>\r\n                        </select>\r\n                    </div>\r\n                </div>\r\n\r\n                <div class=\"col-sm-6\" style=\"display:none\">\r\n                    <div class=\"form-group\">\r\n                        <label>");
#nullable restore
#line 118 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\Module\edit.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Company"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <select id=\"CompanyId\" name=\"CompanyId\" class=\"form-control\">\r\n                            <option></option>\r\n");
#nullable restore
#line 121 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\Module\edit.cshtml"
                             foreach (var item in companyList)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <option");
            BeginWriteAttribute("value", " value=\"", 6437, "\"", 6460, 1);
#nullable restore
#line 123 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\Module\edit.cshtml"
WriteAttributeValue("", 6445, item.CompanyId, 6445, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 123 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\Module\edit.cshtml"
                                                            Write(ModuleDetails != null && ModuleDetails.CompanyId == item.CompanyId ? "selected" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n                                    ");
#nullable restore
#line 124 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\Module\edit.cshtml"
                               Write(item.CoNameEn);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </option>\r\n");
#nullable restore
#line 126 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\Module\edit.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </select>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-sm-6\" style=\"display:none\">\r\n                    <div class=\"form-group\">\r\n                        <label>");
#nullable restore
#line 132 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\Module\edit.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Branch"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <select id=\"BranchId\" name=\"BranchId\" class=\"form-control\">\r\n");
#nullable restore
#line 134 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\Module\edit.cshtml"
                             if (isEdit)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 136 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\Module\edit.cshtml"
                                 foreach (var item in branchList)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <option");
            BeginWriteAttribute("value", " value=\"", 7265, "\"", 7287, 1);
#nullable restore
#line 138 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\Module\edit.cshtml"
WriteAttributeValue("", 7273, item.BranchId, 7273, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 138 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\Module\edit.cshtml"
                                                               Write(ModuleDetails != null && ModuleDetails.BranchId == item.BranchId ? "selected" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n                                        ");
#nullable restore
#line 139 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\Module\edit.cshtml"
                                   Write(item.BranchNameEn);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </option>\r\n");
#nullable restore
#line 141 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\Module\edit.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 141 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\Module\edit.cshtml"
                                 
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </select>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</form>\r\n\r\n\r\n\r\n\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"

    <script>

        $(function () {

        });


        $('#frmEdit').on('submit', function (e) {
            e.preventDefault();
            var actionType = $('#ACTION_TYPE').val();

            confirmAction('Confirm ?', 'Are you sure you want to save changes ?', 'info', 'Yes', 'No').then(function (result) {
                if (result.value == true) {

                    var params = $('#frmEdit').serialize();
                    var formEl = document.forms.frmEdit;
                    var formData = new FormData(formEl);

                    $.ajax({
                        url: getApplicationName() + ""Security/module/"" + actionType,
                        type: ""POST"",
                        data: formData ? formData : params,
                        async: false,
                        cache: false,
                        contentType: false,
                        processData: false,
                        success: function (data) {
                            ");
                WriteLiteral(@"if (data.result.isError != true) {
                                showMsg('Saved !', 'Record has been saved !', 'success');
                                setTimeout(function () {
                                    window.location = getApplicationName() + 'Security/module';
                                }, 500);
                            }
                            else if (data.result.msg != '') {
                                showMsg('Save Failed !', data.result.msg, 'error');
                            }
                            else {
                                showMsg('Save Failed !', 'Something went wrong. Try again', 'error');
                            }
                        }
                    });


                }
            });




        });


        $('#CompanyId').change(function () {

            var id = $('#CompanyId').val();

            $.ajax({
                url: getApplicationName() + ""Ajax/BranchCascading"",
                a");
                WriteLiteral(@"sync: false,
                type: ""POST"",
                data: { id: id },
                success: function (data) {

                    var item = '';

                    $.each(data.result, function (i, product) {

                        item += ""<option value='"" + product.branchId + ""'>"" + product.branchNameEn + ""</option>"";
                    });

                    $(""#BranchId"").html(item);

                }
            });

        });


    </script>

");
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
