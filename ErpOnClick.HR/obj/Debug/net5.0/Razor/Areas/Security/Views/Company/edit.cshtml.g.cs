#pragma checksum "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\Company\edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1dc9c2361a7b9e3dda0d95d4d8463e3badb27b75"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Security_Views_Company_edit), @"mvc.1.0.view", @"/Areas/Security/Views/Company/edit.cshtml")]
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
#line 1 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\Company\edit.cshtml"
using ErpOnClick.DAL.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1dc9c2361a7b9e3dda0d95d4d8463e3badb27b75", @"/Areas/Security/Views/Company/edit.cshtml")]
    public class Areas_Security_Views_Company_edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Security/Company"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\Company\edit.cshtml"
  
    Company CompanyDetail = Model.CompanyIdDetail;
    bool isEdit = (CompanyDetail != null);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<form id=\"frmEdit\" role=\"form\">\r\n    <input type=\"hidden\" id=\"ACTION_TYPE\" name=\"ACTION_TYPE\"");
            BeginWriteAttribute("value", " value=\"", 232, "\"", 269, 1);
#nullable restore
#line 10 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\Company\edit.cshtml"
WriteAttributeValue("", 240, isEdit ? "update" : "save", 240, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input type=\"hidden\" id=\"CompanyId\" name=\"CompanyId\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 352, "\"", 414, 1);
#nullable restore
#line 11 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\Company\edit.cshtml"
WriteAttributeValue("", 360, CompanyDetail != null ? CompanyDetail.CompanyId : 0, 360, 54, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 11 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\Company\edit.cshtml"
                                                                                                                                         Write(isEdit ? "readonly" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(@" min=""3"" maxlength=""3"">

    <div class=""card card-default card-outline col-lg-8"">

        <div class=""card-header"">
            <h2 class=""card-title"">
                Company Info
            </h2>
            <!-- tools box -->
            <div class=""card-tools float-right"">
                <button type=""submit"" class=""btn  btn-sm btn-primary"">
                    <i class=""fal fa-save fa-fw""></i> Save
                </button>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1dc9c2361a7b9e3dda0d95d4d8463e3badb27b756178", async() => {
                WriteLiteral("\r\n                    <i class=\"fal fa-arrow-left fa-fw\"></i> Return\r\n                ");
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
        <div class=""card-body"">

            <div class=""row"">




                <div class=""col-sm-6"">
                    <div class=""form-group"">
                        <label>Company Name</label>
                        <input type=""text"" id=""CoNameEn"" name=""CoNameEn"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 1449, "\"", 1508, 1);
#nullable restore
#line 40 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\Company\edit.cshtml"
WriteAttributeValue("", 1457, CompanyDetail!=null?CompanyDetail.CoNameEn: null, 1457, 51, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" required>
                    </div>
                </div>
                <div class=""col-sm-6"">
                    <div class=""form-group"">
                        <label>Company Name in Arabic</label>
                        <input type=""text"" id=""CoNameAr"" name=""CoNameAr"" class=""form-control"" dir=""rtl""");
            BeginWriteAttribute("value", " value=\"", 1825, "\"", 1884, 1);
#nullable restore
#line 46 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\Company\edit.cshtml"
WriteAttributeValue("", 1833, CompanyDetail!=null?CompanyDetail.CoNameAr: null, 1833, 51, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                </div>

                <div class=""col-sm-6"">
                    <div class=""form-group"">
                        <label>CR Number</label>
                        <input type=""text"" id=""CrNo"" name=""CrNo"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 2163, "\"", 2216, 1);
#nullable restore
#line 53 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\Company\edit.cshtml"
WriteAttributeValue("", 2171, CompanyDetail!=null?CompanyDetail.CrNo: "", 2171, 45, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                </div>

                <div class=""col-sm-6"">
                    <div class=""form-group"">
                        <label>VAT Number</label>
                        <input type=""text"" id=""VatNo"" name=""VatNo"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 2498, "\"", 2552, 1);
#nullable restore
#line 60 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\Company\edit.cshtml"
WriteAttributeValue("", 2506, CompanyDetail!=null?CompanyDetail.VatNo: "", 2506, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n                </div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n                <div class=\"col-sm-6 d-none\">\r\n                    <div class=\"form-group\">\r\n                        <label>Active Status</label>\r\n                        <select id=\"IsEnable\" name=\"IsEnable\" class=\"form-control\">\r\n");
            WriteLiteral("                            <option value=\"True\" ");
#nullable restore
#line 107 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\Company\edit.cshtml"
                                             Write(CompanyDetail != null && CompanyDetail.IsEnable == true ? "selected" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(">Active</option>\r\n                            <option value=\"False\" ");
#nullable restore
#line 108 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\Company\edit.cshtml"
                                              Write(CompanyDetail != null && CompanyDetail.IsEnable == false ? "selected" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(@">Inactive</option>
                        </select>
                    </div>
                </div>

            </div>
        </div>

    </div>



    <div class=""card card-default card-outline col-lg-8"">
        <div class=""card-header"">
            <h2 class=""card-title"">
                Contact Info
            </h2>
        </div>
        <div class=""card-body"">
            <div class=""row"">
                <div class=""col-sm-6"">
                    <div class=""form-group"">
                        <label>Email</label>
                        <input type=""email"" id=""CoEmail"" name=""CoEmail"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 4596, "\"", 4652, 1);
#nullable restore
#line 131 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\Company\edit.cshtml"
WriteAttributeValue("", 4604, CompanyDetail!=null?CompanyDetail.CoEmail: "", 4604, 48, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                </div>

                <div class=""col-sm-6"">
                    <div class=""form-group"">
                        <label>Phone</label>
                        <input type=""number"" id=""CoPhone"" name=""CoPhone"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 4935, "\"", 4991, 1);
#nullable restore
#line 138 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\Company\edit.cshtml"
WriteAttributeValue("", 4943, CompanyDetail!=null?CompanyDetail.CoPhone: "", 4943, 48, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                </div>

                <div class=""col-sm-6"">
                    <div class=""form-group"">
                        <label>Website</label>
                        <input type=""url"" id=""CoWebsite"" name=""CoWebsite"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 5277, "\"", 5335, 1);
#nullable restore
#line 145 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\Company\edit.cshtml"
WriteAttributeValue("", 5285, CompanyDetail!=null?CompanyDetail.CoWebsite: "", 5285, 50, false);

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
                Address
            </h2>
        </div>
        <div class=""card-body"">
            <div class=""row"">
                <div class=""col-sm-6"">
                    <div class=""form-group"">
                        <label>Address</label>
                        <textarea id=""CoAddressEn"" name=""CoAddressEn"" rows=""5"" class=""form-control"">");
#nullable restore
#line 166 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\Company\edit.cshtml"
                                                                                                Write(CompanyDetail!=null?CompanyDetail.CoAddressEn: "");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</textarea>
                    </div>
                </div>

                <div class=""col-sm-6"">
                    <div class=""form-group"">
                        <label>Address in Arabic</label>
                        <textarea id=""CoAddressAr"" name=""CoAddressAr"" rows=""5"" class=""form-control"" dir=""rtl"">");
#nullable restore
#line 173 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\Company\edit.cshtml"
                                                                                                          Write(CompanyDetail!=null?CompanyDetail.CoAddressAr: "");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</textarea>
                    </div>
                </div>
            </div>
        </div>
    </div>


    <div class=""card card-default card-outline col-lg-8"">
        <div class=""card-header"">
            <h2 class=""card-title"">
                Accounting
            </h2>
        </div>
        <div class=""card-body"">
            <div class=""row"">
                <div class=""col-sm-6"">
                    <div class=""form-group"">
                        <label>Fiscal Start Month</label>
                        <input type=""number"" id=""FiscalYearStartMonth"" name=""FiscalYearStartMonth"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 7000, "\"", 7068, 1);
#nullable restore
#line 192 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\Company\edit.cshtml"
WriteAttributeValue("", 7008, CompanyDetail!=null?CompanyDetail.FiscalYearStartMonth: 0, 7008, 60, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                </div>

                <div class=""col-sm-6"">
                    <div class=""form-group"">
                        <label>Fiscal Year Based on</label>
                        <input type=""number"" id=""FiscalYearIsBasedOn"" name=""FiscalYearIsBasedOn"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 7390, "\"", 7458, 1);
#nullable restore
#line 199 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\Company\edit.cshtml"
WriteAttributeValue("", 7398, CompanyDetail!=null?CompanyDetail.FiscalYearIsBasedOn: "", 7398, 60, false);

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
                Bank Detail
            </h2>
        </div>
        <div class=""card-body"">
            <div class=""row"">
                <div class=""col-sm-6"">
                    <div class=""form-group"">
                        <label>Bank Detail in English</label>
                        <textarea id=""BankDetailEn"" name=""BankDetailEn"" rows=""5"" class=""form-control"">");
#nullable restore
#line 217 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\Company\edit.cshtml"
                                                                                                  Write(CompanyDetail!=null?CompanyDetail.BankDetailEn : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</textarea>
                    </div>
                </div>

                <div class=""col-sm-6"">
                    <div class=""form-group"">
                        <label>Bank Detail in Arabic</label>
                        <textarea id=""BankDetailAr"" name=""BankDetailAr"" rows=""5"" class=""form-control"">");
#nullable restore
#line 224 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\Company\edit.cshtml"
                                                                                                  Write(CompanyDetail!=null?CompanyDetail.BankDetailAr : "");

#line default
#line hidden
#nullable disable
            WriteLiteral("</textarea>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n\r\n\r\n</form>\r\n\r\n\r\n\r\n\r\n\r\n");
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
                    $.ajax({
                        url: getApplicationName() +""Security/Company/"" + actionType,
                        async: false,
                        type: ""POST"",
                        data: params,
                        success: function (data) {
                            if (data.result.isError != true) {
                                showMsg('Saved !', 'Record has been saved !', 'success');
                                setTimeout(function () {
                                    window.location = getApplicationName() +'Security/");
                WriteLiteral(@"Company';
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