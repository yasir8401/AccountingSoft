#pragma checksum "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Payments\edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28780a82904d90f5103aabe3c2a5fd47043b58e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Finance_Views_Payments_edit), @"mvc.1.0.view", @"/Areas/Finance/Views/Payments/edit.cshtml")]
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
#line 1 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Payments\edit.cshtml"
using ErpOnClick.DAL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Payments\edit.cshtml"
using ErpOnClick.ErpMain.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28780a82904d90f5103aabe3c2a5fd47043b58e2", @"/Areas/Finance/Views/Payments/edit.cshtml")]
    public class Areas_Finance_Views_Payments_edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Finance/Payments"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Payments\edit.cshtml"
  
    Payments PaymentDetail = Model.IdDetail;
    List<Branch> BranchDetails = Model.branchList;
    List<Company> CompanyDetail = Model.CompanyDetail;
    List<Vendors> Vendors = Model.Vendors;
    List<Accounts> Accounts = Model.Accounts;
    var paymentNo = Model.paymentNo;



    bool isEdit = (PaymentDetail != null);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<form id=\"frmEdit\" role=\"form\">\r\n    <input type=\"hidden\" id=\"ACTION_TYPE\" name=\"ACTION_TYPE\"");
            BeginWriteAttribute("value", " value=\"", 544, "\"", 581, 1);
#nullable restore
#line 21 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Payments\edit.cshtml"
WriteAttributeValue("", 552, isEdit ? "update" : "save", 552, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input type=\"hidden\" id=\"PaymentId\" name=\"PaymentId\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 664, "\"", 726, 1);
#nullable restore
#line 22 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Payments\edit.cshtml"
WriteAttributeValue("", 672, PaymentDetail != null ? PaymentDetail.PaymentId : 0, 672, 54, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input type=\"hidden\" id=\"CompanyId\" name=\"CompanyId\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 809, "\"", 871, 1);
#nullable restore
#line 23 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Payments\edit.cshtml"
WriteAttributeValue("", 817, PaymentDetail != null ? PaymentDetail.CompanyId : 0, 817, 54, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input type=\"hidden\" id=\"BranchId\" name=\"BranchId\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 952, "\"", 1013, 1);
#nullable restore
#line 24 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Payments\edit.cshtml"
WriteAttributeValue("", 960, PaymentDetail != null ? PaymentDetail.BranchId : 0, 960, 53, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n\r\n    <div class=\"card card-default card-outline col-lg-8\">\r\n\r\n        <div class=\"card-header\">\r\n            <h2 class=\"card-title\">\r\n                ");
#nullable restore
#line 31 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Payments\edit.cshtml"
           Write(SharedLocalizer.GetLocalizedHtmlString("Payment"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </h2>\r\n            <!-- tools box -->\r\n            <div class=\"card-tools fa-pull-right\">\r\n                <button type=\"submit\" class=\"btn  btn-sm btn-primary\">\r\n                    <i class=\"fal fa-save fa-fw\"></i> ");
#nullable restore
#line 36 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Payments\edit.cshtml"
                                                 Write(SharedLocalizer.GetLocalizedHtmlString("Save"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </button>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28780a82904d90f5103aabe3c2a5fd47043b58e27953", async() => {
                WriteLiteral("\r\n                    <i class=\"fal fa-arrow-left fa-fw\"></i>");
#nullable restore
#line 39 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Payments\edit.cshtml"
                                                      Write(SharedLocalizer.GetLocalizedHtmlString("Return"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" \r\n                ");
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
            WriteLiteral("\r\n            </div>\r\n            <!-- /. tools -->\r\n        </div>\r\n    </div>\r\n    <div class=\"card card-default card-outline col-lg-8\">\r\n        <div class=\"card-header\">\r\n            <h2 class=\"card-title\">\r\n                ");
#nullable restore
#line 48 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Payments\edit.cshtml"
           Write(SharedLocalizer.GetLocalizedHtmlString("Payment Info"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </h2>\r\n        </div>\r\n        <div class=\"card-body\">\r\n\r\n            <div class=\"row\">\r\n                <div class=\"col-sm-6\">\r\n                    <div class=\"form-group \">\r\n                        <label>");
#nullable restore
#line 56 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Payments\edit.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Payment Date"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <input type=\"text\" name=\"PaymentDate\" id=\"PaymentDate\" class=\"form-control DatePicker\"");
            BeginWriteAttribute("value", " value=\"", 2432, "\"", 2578, 1);
#nullable restore
#line 57 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Payments\edit.cshtml"
WriteAttributeValue("", 2440, PaymentDetail != null && PaymentDetail.PaymentDate != null ? Convert.ToDateTime(PaymentDetail.PaymentDate).ToString("dd-MMM-yyyy") : "", 2440, 138, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" \r\n                               required/>\r\n\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-sm-6\">\r\n                    <div class=\"form-group\">\r\n                        <label>");
#nullable restore
#line 64 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Payments\edit.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Payment #"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <input type=\"text\" required readonly id=\"PaymentNo\" name=\"PaymentNo\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 2971, "\"", 3036, 1);
#nullable restore
#line 65 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Payments\edit.cshtml"
WriteAttributeValue("", 2979, PaymentDetail!=null?PaymentDetail.PaymentNo: paymentNo, 2979, 57, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-sm-6\">\r\n                    <div class=\"form-group\">\r\n                        <label>");
#nullable restore
#line 70 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Payments\edit.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Vendor"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <select id=\"VendorId\" name=\"VendorId\" class=\"form-control\" required>\r\n                            <option></option>\r\n");
#nullable restore
#line 73 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Payments\edit.cshtml"
                             if (Vendors != null)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 75 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Payments\edit.cshtml"
                                 foreach (var item in Vendors)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <option");
            BeginWriteAttribute("value", " value=\"", 3633, "\"", 3655, 1);
#nullable restore
#line 77 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Payments\edit.cshtml"
WriteAttributeValue("", 3641, item.VendorId, 3641, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 77 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Payments\edit.cshtml"
                                                               Write(PaymentDetail != null && item.VendorId == PaymentDetail.VendorId ? "selected" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral("> ");
#nullable restore
#line 77 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Payments\edit.cshtml"
                                                                                                                                                     Write(item.VendorNameEn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 78 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Payments\edit.cshtml"

                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 79 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Payments\edit.cshtml"
                                 
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </select>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-sm-6\">\r\n                    <div class=\"form-group\">\r\n                        <label>");
#nullable restore
#line 86 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Payments\edit.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Recipient Account"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <select id=\"RecipientAccount\" name=\"RecipientAccount\" class=\"form-control select2\" required>\r\n                            <option>\r\n                            </option>\r\n");
#nullable restore
#line 90 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Payments\edit.cshtml"
                             if (Accounts != null)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 92 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Payments\edit.cshtml"
                                 foreach (var item in Accounts)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <option");
            BeginWriteAttribute("value", " value=\"", 4536, "\"", 4559, 1);
#nullable restore
#line 94 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Payments\edit.cshtml"
WriteAttributeValue("", 4544, item.AccountId, 4544, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 94 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Payments\edit.cshtml"
                                                                Write(PaymentDetail != null && item.AccountId == PaymentDetail.RecipientAccount ? "selected" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(">");
#nullable restore
#line 94 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Payments\edit.cshtml"
                                                                                                                                                              Write(item.AccountCode);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 94 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Payments\edit.cshtml"
                                                                                                                                                                                 Write(item.AccountNameEn);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</option>\r\n");
#nullable restore
#line 95 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Payments\edit.cshtml"

                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 96 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Payments\edit.cshtml"
                                 
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </select>\r\n");
            WriteLiteral("                    </div>\r\n                </div>\r\n                <div class=\"col-sm-6\">\r\n                    <div class=\"form-group\">\r\n                        <label>");
#nullable restore
#line 104 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Payments\edit.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Destination Account"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <select id=\"DestinationAccount\" name=\"DestinationAccount\" class=\"form-control select2\" required>\r\n                            <option>\r\n                            </option>\r\n");
#nullable restore
#line 108 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Payments\edit.cshtml"
                             if (Accounts != null)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 110 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Payments\edit.cshtml"
                                 foreach (var item in Accounts)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <option");
            BeginWriteAttribute("value", " value=\"", 5662, "\"", 5685, 1);
#nullable restore
#line 112 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Payments\edit.cshtml"
WriteAttributeValue("", 5670, item.AccountId, 5670, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 112 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Payments\edit.cshtml"
                                                                Write(PaymentDetail != null && item.AccountId == PaymentDetail.DestinationAccount ? "selected" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(">");
#nullable restore
#line 112 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Payments\edit.cshtml"
                                                                                                                                                                Write(item.AccountCode);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 112 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Payments\edit.cshtml"
                                                                                                                                                                                   Write(item.AccountNameEn);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</option>\r\n");
#nullable restore
#line 113 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Payments\edit.cshtml"

                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 114 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Payments\edit.cshtml"
                                 
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </select>\r\n");
            WriteLiteral("                    </div>\r\n                </div>\r\n");
            WriteLiteral("                <div class=\"col-sm-6\">\r\n                    <div class=\"form-group\">\r\n                        <label>");
#nullable restore
#line 149 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Payments\edit.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Amount"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <input type=\"number\" step=\"any\" id=\"Amount\" name=\"Amount\" required maxlength=\"10\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 7874, "\"", 7931, 1);
#nullable restore
#line 150 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Payments\edit.cshtml"
WriteAttributeValue("", 7882, PaymentDetail!=null?PaymentDetail.Amount: null, 7882, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-sm-6\">\r\n                    <div class=\"form-group\">\r\n                        <label>");
#nullable restore
#line 155 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Payments\edit.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Ref No"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <input type=\"text\" id=\"RefNo\" name=\"RefNo\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 8250, "\"", 8304, 1);
#nullable restore
#line 156 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Payments\edit.cshtml"
WriteAttributeValue("", 8258, PaymentDetail!=null?PaymentDetail.RefNo: "", 8258, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n                </div>\r\n\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"card card-default card-outline col-lg-8\">\r\n        <div class=\"card-header\">\r\n            <h2 class=\"card-title\">\r\n                ");
#nullable restore
#line 167 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Payments\edit.cshtml"
           Write(SharedLocalizer.GetLocalizedHtmlString("Note"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n            </h2>\r\n        </div>\r\n        <div class=\"card-body p-2\">\r\n");
            WriteLiteral("            <textarea id=\"Note\" name=\"Note\" class=\"form-control\" style=\"border:none\" placeholder=\"Enter your comments here...\">");
#nullable restore
#line 175 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Payments\edit.cshtml"
                                                                                                                           Write(PaymentDetail != null ? PaymentDetail.Note:"");

#line default
#line hidden
#nullable disable
            WriteLiteral("</textarea>\r\n\r\n");
            WriteLiteral("        </div>\r\n    </div>\r\n    <div class=\"card card-default card-outline col-lg-8\" style=\"display:none\">\r\n        <div class=\"card-header\">\r\n            <h2 class=\"card-title\">\r\n                ");
#nullable restore
#line 185 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Payments\edit.cshtml"
           Write(SharedLocalizer.GetLocalizedHtmlString("Organization Details"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </h2>\r\n        </div>\r\n        <div class=\"card-body\">\r\n            <div class=\"row\">\r\n\r\n                <div class=\"col-sm-6\">\r\n                    <div class=\"form-group\">\r\n                        <label>");
#nullable restore
#line 193 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Payments\edit.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Company"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <select id=\"CompanyId\" name=\"CompanyId\" class=\"form-control\">\r\n                            <option></option>\r\n");
#nullable restore
#line 196 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Payments\edit.cshtml"
                             foreach (var item in Model.CompanyDetail)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <option");
            BeginWriteAttribute("value", " value=\"", 9921, "\"", 9944, 1);
#nullable restore
#line 198 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Payments\edit.cshtml"
WriteAttributeValue("", 9929, item.CompanyId, 9929, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 198 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Payments\edit.cshtml"
                                                            Write(PaymentDetail != null && PaymentDetail.CompanyId == item.CompanyId ? "selected" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral("> ");
#nullable restore
#line 198 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Payments\edit.cshtml"
                                                                                                                                                    Write(item.CoNameEn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 199 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Payments\edit.cshtml"

                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </select>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-sm-6\">\r\n                    <div class=\"form-group\">\r\n                        <label>");
#nullable restore
#line 206 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Payments\edit.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Branch"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <select id=\"BranchId\" name=\"BranchId\" class=\"form-control\">\r\n");
#nullable restore
#line 208 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Payments\edit.cshtml"
                             if (isEdit)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 210 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Payments\edit.cshtml"
                                 foreach (var item in BranchDetails)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <option");
            BeginWriteAttribute("value", " value=\"", 10662, "\"", 10684, 1);
#nullable restore
#line 212 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Payments\edit.cshtml"
WriteAttributeValue("", 10670, item.BranchId, 10670, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 212 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Payments\edit.cshtml"
                                                               Write(PaymentDetail != null && PaymentDetail.BranchId == item.BranchId ? "selected" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral("> ");
#nullable restore
#line 212 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Payments\edit.cshtml"
                                                                                                                                                     Write(item.BranchNameEn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 213 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Payments\edit.cshtml"

                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 214 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Payments\edit.cshtml"
                                 
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </select>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n\r\n</form>\r\n\r\n\r\n\r\n\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"

    <script>
        $(function () {
            $('#AccPli').addClass(""menu-open"");
            $('#AccRli').removeClass(""menu-open"");
            $('#Accli').removeClass(""menu-open"");
            $('#Setupli').removeClass(""menu-open"");
        });
        $('.select2').select2();
        $('.DatePicker').datepicker({
            format: 'dd-M-yyyy',
            autoclose: true
        });
        $.validator.setDefaults({
            submitHandler: function (e) {

                submitForm(e);
            }
        });
        $('#frmEdit').validate({
            rules: {
                //PlateNo: {
                //    maxlength: 20
                //},
                //AssetNo: {
                //    maxlength: 20
                //},
                //Note: {
                //    maxlength: 600
                //},
                //VehicleDescription: {
                //    required: true,
                //    maxlength: 100
                //}

            ");
                WriteLiteral(@"},
            messages: {
                //PlateNo: {
                //    maxlength: ""Maximum 20 characters can be enetered""
                //},
                //AssetNo: {
                //    maxlength: ""Maximum 20 characters can be enetered""
                //},
                //Note: {
                //    maxlength: ""Maximum 600 characters can be enetered""
                //},
                //VehicleDescription: {
                //    required: ""Field is required"",
                //    maxlength: ""Maximum 100 characters can be enetered""
                //}

            },
            errorElement: 'span',
            errorPlacement: function (error, element) {
                error.addClass('invalid-feedback');
                element.closest('.form-group').append(error);
            },
            highlight: function (element, errorClass, validClass) {
                $(element).addClass('is-invalid');
            },
            unhighlight: function (element, error");
                WriteLiteral(@"Class, validClass) {
                $(element).removeClass('is-invalid');
            }
        });
        function submitForm(e) {
            //$('#frmEdit').on('submit', function (e) {
            //    e.preventDefault();
            var actionType = $('#ACTION_TYPE').val();

            confirmAction('Confirm ?', 'Are you sure you want to save changes ?', 'info', 'Yes', 'No').then(function (result) {
                if (result.value == true) {

                    var params = $('#frmEdit').serialize();
                    $.ajax({
                        url: getApplicationName() + ""Finance/Payments/"" + actionType,
                        async: false,
                        type: ""POST"",
                        data: params,
                        success: function (data) {
                            if (data.result.isError != true) {
                                showMsg('Saved !', 'Record has been saved !', 'success');
                                setTimeout(function ()");
                WriteLiteral(@" {
                                    window.location = getApplicationName() + 'Finance/Payments';
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
        $('#CompanyId').change(function () {
            var id = $('#CompanyId').val();

            $.ajax({
                url: getApplicationName() + ""Ajax/BranchCascading"",
                async: false,
                type: ""POST"",
                data: { id: id },
                success: function (data) {
                    var item = '';

           ");
                WriteLiteral(@"         $.each(data.result, function (i, product) {
                        item += ""<option value='"" + product.branchId + ""'>"" + product.branchNameEn + ""</option>"";
                    });

                    $(""#BranchId"").html(item);

                }
            });

        });

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
      ");
                WriteLiteral("  });\r\n        //press enter to change input focus\r\n    </script>\r\n\r\n");
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