#pragma checksum "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Views\Application\edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53a002a00e53ec7d7e0cdd00e7cb45c296b45617"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Application_edit), @"mvc.1.0.view", @"/Views/Application/edit.cshtml")]
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
#line 1 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Views\_ViewImports.cshtml"
using ErpOnClick.Recruitment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Views\_ViewImports.cshtml"
using ErpOnClick.Recruitment.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Views\Application\edit.cshtml"
using ErpOnClick.DAL.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53a002a00e53ec7d7e0cdd00e7cb45c296b45617", @"/Views/Application/edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3259d57ca07a25c716fb0d896aec9aac938e8c62", @"/Views/_ViewImports.cshtml")]
    public class Views_Application_edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("frmEdit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-contact contact_form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("contact_process.php"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("novalidate", new global::Microsoft.AspNetCore.Html.HtmlString("novalidate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Views\Application\edit.cshtml"
  

    IList<Lookups> degreeList = Model.degreeList;
    Applications applicationDetails = Model.applicationDetails;
    IList<VacantJobs> vacantJobList = Model.vacantJobList;
    VacantJobs vacantJobDetail = Model.vacantJobDetail;
    bool isEdit = (applicationDetails != null);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""slider-area "">
    <div class=""single-slider section-overly slider-height2 d-flex align-items-center"" data-background=""../../assets/img/hero/about.jpg"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-xl-12"">
                    <div class=""hero-cap text-center"">
                        <h2>Apply Now</h2>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Hero Area End -->
<!-- ================ contact section start ================= -->
<section class=""contact-section"">
    <div class=""container"">


        <div class=""row"">
            <div class=""col-12"">
                <h2 class=""contact-title"">Get in Touch</h2>
            </div>
            <div class=""col-lg-8"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "53a002a00e53ec7d7e0cdd00e7cb45c296b456176752", async() => {
                WriteLiteral(@"
                    <div class=""row"">

                        <div class=""col-sm-6"">
                            <div class=""form-group"">
                                <label>CV</label>
                                <input type=""file"" id=""CVFile"" name=""CVFile"" value=""Upload CV"" class=""form-control"">

                            </div>
                        </div>
                        <div class=""col-sm-6"">
                            <div class=""form-group"">
                                <label>Cover Letter</label>
                                <input type=""file"" id=""CoverLetterFile"" name=""CoverLetterFile"" value=""Upload CV"" class=""form-control"">

                            </div>
                        </div>
                        <div class=""col-6"">
                            <div class=""form-group"">
                                <label>Degree</label>
                                <select id=""DegreeId"" style=""width:100% "" name=""DegreeId"" class=""form-control"" requir");
                WriteLiteral("ed>\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "53a002a00e53ec7d7e0cdd00e7cb45c296b456178151", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 58 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Views\Application\edit.cshtml"
                                     foreach (var item in degreeList)
                                    {
                                        if (applicationDetails != null && item.Code == applicationDetails.DegreeId)
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "53a002a00e53ec7d7e0cdd00e7cb45c296b456179660", async() => {
                    WriteLiteral("\r\n                                                ");
#nullable restore
#line 63 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Views\Application\edit.cshtml"
                                           Write(item.LookupNameEn);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 62 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Views\Application\edit.cshtml"
                                                        WriteLiteral(item.Code);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 65 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Views\Application\edit.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "53a002a00e53ec7d7e0cdd00e7cb45c296b4561712524", async() => {
                    WriteLiteral("\r\n                                                ");
#nullable restore
#line 69 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Views\Application\edit.cshtml"
                                           Write(item.LookupNameEn);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 68 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Views\Application\edit.cshtml"
                                               WriteLiteral(item.Code);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 71 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Views\Application\edit.cshtml"
                                        }

                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                </select>
                            </div>
                        </div>
                        <div class=""col-6"">
                            <div class=""form-group"">
                                <label> Job</label>
                                <select id=""VacantJobId"" name=""VacantJobId"" class=""form-control"" required>

");
#nullable restore
#line 82 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Views\Application\edit.cshtml"
                                     foreach (var item in vacantJobList)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "53a002a00e53ec7d7e0cdd00e7cb45c296b4561715728", async() => {
                    WriteLiteral("\r\n                                            ");
#nullable restore
#line 85 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Views\Application\edit.cshtml"
                                       Write(item.JobTitle);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 84 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Views\Application\edit.cshtml"
                                           WriteLiteral(item.JobId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 87 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Views\Application\edit.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                </select>
                            </div>
                        </div>
                        <div class=""col-sm-12"">
                            <div class=""form-group"">
                                <label>Summary</label>
                                <textarea id=""ApplicationSummary"" rows=""3"" required name=""ApplicationSummary""
                                          style=""width: 100%; height: 100px; font-size: 14px; line-height: 18px; border: 1px solid #dddddd; padding: 10px;"">");
#nullable restore
#line 95 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Views\Application\edit.cshtml"
                                                                                                                                                        Write(applicationDetails != null? applicationDetails.ApplicationSummary : "");

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</textarea>
                            </div>
                        </div>

                    </div>
                    <div class=""form-group mt-3"">
                        <button type=""submit"" class=""button button-contactForm boxed-btn"">Apply</button>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
            <div class=""col-lg-3 offset-lg-1"">
                <div class=""media contact-info"">
                    <span class=""contact-info__icon""><i class=""fas fa-heading""></i></span>
                    <div class=""media-body"">
                        <h3>Title</h3>
                        <p>
                            ");
#nullable restore
#line 111 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Views\Application\edit.cshtml"
                       Write(vacantJobDetail.JobTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </p>
                    </div>
                </div>
                <div class=""media contact-info"">
                    <span class=""contact-info__icon""><i class=""fas fa-briefcase""></i></span>
                    <div class=""media-body"">
                        <h3>Description</h3>
                        <p>
                            ");
#nullable restore
#line 120 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Views\Application\edit.cshtml"
                       Write(Html.Raw(Convert.ToString(vacantJobDetail.JobDescription)));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                       
                        </p>
                    </div>
                </div>
                <div class=""media contact-info"">
                    <span class=""contact-info__icon""><i class=""fas fa-hourglass-start""></i></span>
                    <div class=""media-body"">
                        <h3>Start Date</h3>
                        <p>
                            ");
#nullable restore
#line 130 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Views\Application\edit.cshtml"
                        Write(vacantJobDetail != null && vacantJobDetail.JobStartDate !=null ? Convert.ToDateTime(vacantJobDetail.JobStartDate).ToString("dd-MMM-yyyy") : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                        </p>
                    </div>
                </div>
                <div class=""media contact-info"">
                    <span class=""contact-info__icon""><i class=""fas fa-hourglass-end""></i></span>
                    <div class=""media-body"">
                        <h3>End Date</h3>
                        <p>  ");
#nullable restore
#line 139 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Views\Application\edit.cshtml"
                         Write(vacantJobDetail != null && vacantJobDetail != null ? Convert.ToDateTime(vacantJobDetail.JobEndDate).ToString("dd-MMM-yyyy") : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    </div>
                </div>
                <div class=""media contact-info"">
                    <span class=""contact-info__icon""><i class=""fas fa-calendar-plus""></i></span>
                    <div class=""media-body"">
                        <h3>Created Date</h3>
                        <p> ");
#nullable restore
#line 146 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Views\Application\edit.cshtml"
                        Write(vacantJobDetail != null && vacantJobDetail != null ? Convert.ToDateTime(vacantJobDetail.CreatedDate).ToString("dd-MMM-yyyy") : "");

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n<!-- ================ contact section end ================= -->\r\n\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"

    <script>

        $(function () {
        });

        var applicationName = getApplicationName();

        $('#frmEdit').on('submit', function (e) {
            e.preventDefault();
            var actionType = $('#ACTION_TYPE').val();

            confirmAction('Confirm ?', 'Are you sure you want to save changes ?', 'info', 'Yes', 'No').then(function (result) {
                if (result.value == true) {
                    var params = $('#frmEdit').serialize();
                    var formEl = document.forms.frmEdit;
                    var formData = new FormData(formEl);
                    
                    $.ajax({
                        url: applicationName+""application/save/"",
                        type: ""POST"",
                        data: formData ? formData : params,
                        async: false,
                        cache: false,
                        contentType: false,
                        processData: false,
                        succes");
                WriteLiteral(@"s: function (data) {
                            if (data.result.isError != true) {
                                showMsg('Saved !', 'Record has been saved !', 'success');
                                setTimeout(function () {
                                    window.location = applicationName+'application/';
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
                url: applicationName+""Ajax/BranchCas");
                WriteLiteral(@"cading"",
                async: false,
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