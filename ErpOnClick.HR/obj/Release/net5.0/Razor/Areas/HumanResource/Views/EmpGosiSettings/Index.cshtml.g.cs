#pragma checksum "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpGosiSettings\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87e4424edeef92fadf7de74a5f33c5f5471aa8d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_HumanResource_Views_EmpGosiSettings_Index), @"mvc.1.0.view", @"/Areas/HumanResource/Views/EmpGosiSettings/Index.cshtml")]
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
#line 1 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpGosiSettings\Index.cshtml"
using ErpOnClick.DAL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpGosiSettings\Index.cshtml"
using ErpOnClick.ErpMain.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87e4424edeef92fadf7de74a5f33c5f5471aa8d4", @"/Areas/HumanResource/Views/EmpGosiSettings/Index.cshtml")]
    public class Areas_HumanResource_Views_EmpGosiSettings_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-validation/dist/additional-methods.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-validation/dist/jquery.validate.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpGosiSettings\Index.cshtml"
  
    IList<Emp> empList = Model.empList;
    var empId = Model.empId;
    Emp empDetails = Model.empDetails;
    EmpGosiSettings EmpGosiSettingsDetails = Model.EmpGosiSettingsDetails;
    bool isEdit = (EmpGosiSettingsDetails != null);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<form id=\"frmEdit\" role=\"form\" enctype=\"multipart/form-data\">\r\n    <input type=\"hidden\" id=\"ACTION_TYPE\" name=\"ACTION_TYPE\"");
            BeginWriteAttribute("value", " value=\"", 481, "\"", 518, 1);
#nullable restore
#line 16 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpGosiSettings\Index.cshtml"
WriteAttributeValue("", 489, isEdit ? "update" : "save", 489, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input type=\"hidden\" id=\"GosiSettingsId\" name=\"GosiSettingsId\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 611, "\"", 696, 1);
#nullable restore
#line 17 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpGosiSettings\Index.cshtml"
WriteAttributeValue("", 619, EmpGosiSettingsDetails != null ? EmpGosiSettingsDetails.GosiSettingsId : 0, 619, 77, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 17 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpGosiSettings\Index.cshtml"
                                                                                                                                                                          Write(isEdit ? "readonly" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(@" min=""3"" maxlength=""3"">

    <div class=""card card-default card-outline col-lg-12"">
        <div class=""card-header p-0 border-bottom-0"">
            <div class=""card"" style=""background-color: #496b6a"">
            </div>
            <ul class=""nav nav-tabs"" id=""custom-content-below-tab"" role=""tablist"">
");
            WriteLiteral("\r\n                ");
#nullable restore
#line 28 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpGosiSettings\Index.cshtml"
           Write(Html.Partial("/Areas/HumanResource/Views/Emp/_tabsPartial.cshtml", empDetails));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </ul>\r\n        </div>\r\n        <div class=\"card-header\">\r\n            <h2 class=\"card-title\">\r\n                ");
#nullable restore
#line 34 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpGosiSettings\Index.cshtml"
           Write(SharedLocalizer.GetLocalizedHtmlString("Gosi Settings Detail"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </h2>\r\n            <!-- tools box -->\r\n            <div class=\"card-tools float-right\">\r\n                <button type=\"submit\" class=\"btn  btn-sm btn-primary\">\r\n                    <i class=\"fal fa-save fa-fw\"></i> ");
#nullable restore
#line 39 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpGosiSettings\Index.cshtml"
                                                 Write(SharedLocalizer.GetLocalizedHtmlString("Save"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </button>
            </div>
            <!-- /. tools -->
        </div>
        <div class=""card-body"">

            <div class=""row"">
                <div class=""col-sm-6"">
                    <div class=""form-group"">
                        <label>");
#nullable restore
#line 49 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpGosiSettings\Index.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Employee"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <select id=\"EmpId\" name=\"EmpId\" class=\"form-control\" readonly>\r\n\r\n");
#nullable restore
#line 52 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpGosiSettings\Index.cshtml"
                             foreach (var item in empList)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <option");
            BeginWriteAttribute("value", " value=\"", 2419, "\"", 2438, 1);
#nullable restore
#line 54 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpGosiSettings\Index.cshtml"
WriteAttributeValue("", 2427, item.EmpId, 2427, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 54 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpGosiSettings\Index.cshtml"
                                                        Write(EmpGosiSettingsDetails != null && EmpGosiSettingsDetails.EmpId == item.EmpId ? "selected" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n                                    ");
#nullable restore
#line 55 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpGosiSettings\Index.cshtml"
                                Write(item.FirstNameEn + " " + item.FatherNameEn + " " + item.GrandNameEn + " " + item.FamilyNameEn);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </option>\r\n");
#nullable restore
#line 57 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpGosiSettings\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </select>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-sm-6\">\r\n                    <div class=\"form-group\">\r\n                        <label>");
#nullable restore
#line 63 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpGosiSettings\Index.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Gosi Settings Name En"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <input type=\"text\" id=\"GosiSettingNameEn\" name=\"GosiSettingNameEn\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 3137, "\"", 3223, 1);
#nullable restore
#line 64 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpGosiSettings\Index.cshtml"
WriteAttributeValue("", 3145, EmpGosiSettingsDetails!=null?EmpGosiSettingsDetails.GosiSettingNameEn: null, 3145, 78, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                               maxlength=\"200\">\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-sm-6\">\r\n                    <div class=\"form-group\">\r\n                        <label>");
#nullable restore
#line 70 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpGosiSettings\Index.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Gosi Settings Name Er"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <input type=\"text\" id=\"GosiSettingNameAr\" name=\"GosiSettingNameAr\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 3629, "\"", 3715, 1);
#nullable restore
#line 71 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpGosiSettings\Index.cshtml"
WriteAttributeValue("", 3637, EmpGosiSettingsDetails!=null?EmpGosiSettingsDetails.GosiSettingNameAr: null, 3637, 78, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                               maxlength=\"200\">\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-sm-6\">\r\n                    <div class=\"form-group\">\r\n                        <label>");
#nullable restore
#line 77 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpGosiSettings\Index.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Joining Date"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <input type=\"text\" id=\"JoiningDate\" name=\"JoiningDate\" class=\"form-control DatePicker\"");
            BeginWriteAttribute("value", " value=\"", 4111, "\"", 4283, 1);
#nullable restore
#line 78 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpGosiSettings\Index.cshtml"
WriteAttributeValue("", 4119, EmpGosiSettingsDetails != null && EmpGosiSettingsDetails.JoiningDate !=null ? Convert.ToDateTime(EmpGosiSettingsDetails.JoiningDate).ToString("dd-MMM-yyyy") : "", 4119, 164, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-sm-6\">\r\n                    <div class=\"form-group\">\r\n                        <label>");
#nullable restore
#line 83 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpGosiSettings\Index.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Gosi Code"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <input type=\"text\" id=\"GosiSettingCode\" name=\"GosiSettingCode\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 4625, "\"", 4709, 1);
#nullable restore
#line 84 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpGosiSettings\Index.cshtml"
WriteAttributeValue("", 4633, EmpGosiSettingsDetails!=null?EmpGosiSettingsDetails.GosiSettingCode: null, 4633, 76, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                               maxlength=\"10\">\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n</form>\r\n\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87e4424edeef92fadf7de74a5f33c5f5471aa8d415453", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87e4424edeef92fadf7de74a5f33c5f5471aa8d416553", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script>
        var applicationName = getApplicationName();

        $(function () {

            $(""#tabGosiSettings-tab"").css(""background-color"", ""#496b6a"");
            $(""#tabGosiSettings-tab"").css(""color"", ""white"");

        });
        $.validator.setDefaults({
            submitHandler: function (e) {

                submitForm(e);
            }
        });
        $('#frmEdit').validate({
            rules: {
                GosiSettingNameEn: {
                    maxlength: 200
                },
                GosiSettingNameAr: {
                    maxlength: 200
                },
                GosiSettingCode: {
                    maxlength: 10
                }

            },
            messages: {
                GosiSettingNameEn: {
                    maxlength: ""Maximum 200 characters can be enetered""
                },
                GosiSettingNameAr: {
                    maxlength: ""Maximum 200 characters can be enetered""
               ");
                WriteLiteral(@" },
                GosiSettingCode: {
                    maxlength: ""Maximum 10 characters can be enetered""
                }

            },
            errorElement: 'span',
            errorPlacement: function (error, element) {
                error.addClass('invalid-feedback');
                element.closest('.form-group').append(error);
            },
            highlight: function (element, errorClass, validClass) {
                $(element).addClass('is-invalid');
            },
            unhighlight: function (element, errorClass, validClass) {
                $(element).removeClass('is-invalid');
            }
        });
        function submitForm(e) {
            //$('#frmEdit').on('submit', function (e) {
            //  e.preventDefault();
            var actionType = $('#ACTION_TYPE').val();

            confirmAction('Confirm ?', 'Are you sure you want to save changes ?', 'info', 'Yes', 'No').then(function (result) {
                if (result.value == true) {
");
                WriteLiteral(@"
                    var params = $('#frmEdit').serialize();
                    $.ajax({
                        url: applicationName + ""HumanResource/EmpGosiSettings/"" + actionType,
                        async: false,
                        type: ""POST"",
                        data: params,
                        success: function (data) {
                            if (data.result.isError != true) {
                                showMsg('Saved !', 'Record has been saved !', 'success');
                                setTimeout(function () {
                                    window.location = applicationName + 'HumanResource/EmpGosiSettings/emp/");
#nullable restore
#line 168 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpGosiSettings\Index.cshtml"
                                                                                                      Write(empId);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"';

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




            //});
        }
        function navigation() {
            window.location = applicationName +'HumanResource/emp/edit/");
#nullable restore
#line 189 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpGosiSettings\Index.cshtml"
                                                                  Write(empId);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"'
        };
        //press enter to change input focus
        // register jQuery extension
        jQuery.extend(jQuery.expr[':'], {
            focusable: function (el, index, selector) {
                return $(el).is('a, button, :input, [tabindex]');
            }
        });
        $(document).on('keypress', 'input,select', function (e) {
            if (e.which == 13) {
                e.preventDefault();
                // Get all focusable elements on the page
                var $canfocus = $(':focusable');
                var index = $canfocus.index(document.activeElement) + 1;
                if (index >= $canfocus.length) index = 0;
                $canfocus.eq(index).focus();
            }
        });
        //press enter to change input focus
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
