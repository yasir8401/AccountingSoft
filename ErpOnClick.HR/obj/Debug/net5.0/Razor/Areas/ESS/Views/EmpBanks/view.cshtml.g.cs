#pragma checksum "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpBanks\view.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85c7ad4cbd06acb150f393f931ac13fb6d7a0d78"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_ESS_Views_EmpBanks_view), @"mvc.1.0.view", @"/Areas/ESS/Views/EmpBanks/view.cshtml")]
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
#line 1 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpBanks\view.cshtml"
using ErpOnClick.DAL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpBanks\view.cshtml"
using ErpOnClick.ErpMain.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85c7ad4cbd06acb150f393f931ac13fb6d7a0d78", @"/Areas/ESS/Views/EmpBanks/view.cshtml")]
    public class Areas_ESS_Views_EmpBanks_view : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn  btn-sm btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpBanks\view.cshtml"
  
    IList<Branch> branchList = Model.branchList;
    IList<Company> companyList = Model.companyList;
    IList<Emp> empList = Model.empList;

    IList<Lookups> banksList = Model.banksList;

    var empId = Model.empId;

    Emp empDetails = Model.empDetails;
    EmpBanks EmpBanksDetails = Model.EmpBanksDetails;
    bool isEdit = (EmpBanksDetails != null);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<form id=\"frmEdit\" role=\"form\" enctype=\"multipart/form-data\">\r\n    <input type=\"hidden\" id=\"ACTION_TYPE\" name=\"ACTION_TYPE\"");
            BeginWriteAttribute("value", " value=\"", 611, "\"", 648, 1);
#nullable restore
#line 22 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpBanks\view.cshtml"
WriteAttributeValue("", 619, isEdit ? "update" : "save", 619, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input type=\"hidden\" id=\"EmpBankId\" name=\"EmpBankId\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 731, "\"", 797, 1);
#nullable restore
#line 23 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpBanks\view.cshtml"
WriteAttributeValue("", 739, EmpBanksDetails != null ? EmpBanksDetails.EmpBankId : 0, 739, 58, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 23 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpBanks\view.cshtml"
                                                                                                                                             Write(isEdit ? "readonly" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(" min=\"3\" maxlength=\"3\">\r\n    <input type=\"hidden\" id=\"CompanyId\" name=\"CompanyId\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 928, "\"", 994, 1);
#nullable restore
#line 24 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpBanks\view.cshtml"
WriteAttributeValue("", 936, EmpBanksDetails != null ? EmpBanksDetails.CompanyId : 0, 936, 58, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    <input type=\"hidden\" id=\"BranchId\" name=\"BranchId\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 1073, "\"", 1138, 1);
#nullable restore
#line 25 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpBanks\view.cshtml"
WriteAttributeValue("", 1081, EmpBanksDetails != null ? EmpBanksDetails.BranchId : 0, 1081, 57, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">

    <div class=""card card-default card-outline col-lg-12"">
        <div class=""card-header p-0 border-bottom-0"">
            <div class=""card"" style=""background-color: #496b6a"">
            </div>
            <ul class=""nav nav-tabs"" id=""custom-content-below-tab"" role=""tablist"">
");
            WriteLiteral("\r\n                ");
#nullable restore
#line 36 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpBanks\view.cshtml"
           Write(Html.Partial("/Areas/ESS/Views/Profile/_tabsPartial.cshtml", empDetails));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </ul>\r\n        </div>\r\n        <div class=\"card-header\">\r\n            <h2 class=\"card-title\">\r\n                ");
#nullable restore
#line 42 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpBanks\view.cshtml"
           Write(SharedLocalizer.GetLocalizedHtmlString("Details"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </h2>\r\n            <!-- tools box -->\r\n            <div class=\"card-tools float-right\">\r\n               \r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "85c7ad4cbd06acb150f393f931ac13fb6d7a0d788203", async() => {
                WriteLiteral("\r\n                    <i class=\"fal fa-arrow-left fa-fw\"></i> ");
#nullable restore
#line 48 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpBanks\view.cshtml"
                                                       Write(SharedLocalizer.GetLocalizedHtmlString("Return"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2093, "~/ESS/empbanks/emp/", 2093, 19, true);
#nullable restore
#line 47 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpBanks\view.cshtml"
AddHtmlAttributeValue("", 2112, empId, 2112, 6, false);

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
            WriteLiteral("\r\n            </div>\r\n            <!-- /. tools -->\r\n        </div>\r\n        <div class=\"card-body\">\r\n\r\n            <div class=\"row\">\r\n                <div class=\"col-sm-6\">\r\n                    <div class=\"form-group\">\r\n                        <label>");
#nullable restore
#line 58 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpBanks\view.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Employee"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <select id=\"EmpId\" name=\"EmpId\" class=\"form-control\" disabled>\r\n\r\n");
#nullable restore
#line 61 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpBanks\view.cshtml"
                             foreach (var item in empList)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <option");
            BeginWriteAttribute("value", " value=\"", 2832, "\"", 2851, 1);
#nullable restore
#line 63 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpBanks\view.cshtml"
WriteAttributeValue("", 2840, item.EmpId, 2840, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 63 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpBanks\view.cshtml"
                                                        Write(EmpBanksDetails != null && EmpBanksDetails.EmpId == item.EmpId ? "selected" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n                                    ");
#nullable restore
#line 64 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpBanks\view.cshtml"
                                Write(item.FirstNameEn + " " + item.FatherNameEn + " " + item.GrandNameEn + " " + item.FamilyNameEn);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </option>\r\n");
#nullable restore
#line 66 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpBanks\view.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </select>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-sm-6\">\r\n                    <div class=\"form-group\">\r\n                        <label>");
#nullable restore
#line 72 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpBanks\view.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Title"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <input disabled type=\"text\" id=\"BankAccountTitle\" name=\"BankAccountTitle\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 3527, "\"", 3598, 1);
#nullable restore
#line 73 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpBanks\view.cshtml"
WriteAttributeValue("", 3535, EmpBanksDetails!=null?EmpBanksDetails.BankAccountTitle: null, 3535, 63, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-sm-6\">\r\n                    <div class=\"form-group\">\r\n                        <label>");
#nullable restore
#line 78 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpBanks\view.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Account No"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <input disabled type=\"text\" id=\"BankAccountNo\" name=\"BankAccountNo\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 3946, "\"", 4014, 1);
#nullable restore
#line 79 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpBanks\view.cshtml"
WriteAttributeValue("", 3954, EmpBanksDetails!=null?EmpBanksDetails.BankAccountNo: null, 3954, 60, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n                </div>\r\n\r\n\r\n                <div class=\"col-sm-6\">\r\n                    <div class=\"form-group\">\r\n                        <label>");
#nullable restore
#line 86 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpBanks\view.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Iban"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </label>\r\n");
            WriteLiteral("                        <input disabled type=\"text\" id=\"BankIban\" name=\"BankIban\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 4515, "\"", 4578, 1);
#nullable restore
#line 88 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpBanks\view.cshtml"
WriteAttributeValue("", 4523, EmpBanksDetails!=null?EmpBanksDetails.BankIban: null, 4523, 55, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-sm-6 \">\r\n                    <div class=\"form-group\">\r\n                        <label> ");
#nullable restore
#line 93 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpBanks\view.cshtml"
                           Write(SharedLocalizer.GetLocalizedHtmlString("Bank"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <select id=\"BankId\" name=\"BankId\" class=\"form-control\" disabled>\r\n\r\n");
#nullable restore
#line 96 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpBanks\view.cshtml"
                             foreach (var item in banksList)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <option");
            BeginWriteAttribute("value", " value=\"", 5036, "\"", 5054, 1);
#nullable restore
#line 98 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpBanks\view.cshtml"
WriteAttributeValue("", 5044, item.Code, 5044, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 98 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpBanks\view.cshtml"
                                                       Write(EmpBanksDetails != null && EmpBanksDetails.BankId == item.Code ? "selected" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n                                    ");
#nullable restore
#line 99 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpBanks\view.cshtml"
                               Write(item.LookupNameEn);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </option>\r\n");
#nullable restore
#line 101 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpBanks\view.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </select>
                    </div>
                </div>
            </div>
        </div>

    </div>

    <div class=""card card-outline card-outline col-lg-12"">
        <div class=""card-header"">
            <h3 class=""card-title"">
                ");
#nullable restore
#line 113 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpBanks\view.cshtml"
           Write(SharedLocalizer.GetLocalizedHtmlString("Note"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </h3>

        </div>
        <!-- /.card-header -->
        <div class=""card-body pad"">
            <div class=""mb-3"">
                <textarea id=""Note"" rows=""3"" name=""Note"" disabled
                          style=""width: 100%; height: 100px; font-size: 14px; line-height: 18px; border: 1px solid #dddddd; padding: 10px;"">");
#nullable restore
#line 121 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpBanks\view.cshtml"
                                                                                                                                        Write(EmpBanksDetails != null? EmpBanksDetails.Note : "");

#line default
#line hidden
#nullable disable
            WriteLiteral("</textarea>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n    <div class=\"card card-outline card-outline col-lg-12\" style=\"display:none\">\r\n        <div class=\"card-header\">\r\n            <h3 class=\"card-title\">\r\n                ");
#nullable restore
#line 129 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpBanks\view.cshtml"
           Write(SharedLocalizer.GetLocalizedHtmlString("Organization Details"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </h3>

        </div>
        <!-- /.card-header -->
        <div class=""card-body pad"">
            <div class=""row"">
                <div class=""col-sm-6 "">
                    <div class=""form-group"">
                        <label>");
#nullable restore
#line 138 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpBanks\view.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Company"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <select id=\"CompanyId\" name=\"CompanyId\" class=\"form-control\">\r\n                            <option></option>\r\n");
#nullable restore
#line 141 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpBanks\view.cshtml"
                             foreach (var item in companyList)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <option");
            BeginWriteAttribute("value", " value=\"", 6886, "\"", 6909, 1);
#nullable restore
#line 143 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpBanks\view.cshtml"
WriteAttributeValue("", 6894, item.CompanyId, 6894, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 143 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpBanks\view.cshtml"
                                                            Write(EmpBanksDetails != null && EmpBanksDetails.CompanyId == item.CompanyId ? "selected" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n                                    ");
#nullable restore
#line 144 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpBanks\view.cshtml"
                               Write(item.CoNameEn);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </option>\r\n");
#nullable restore
#line 146 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpBanks\view.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </select>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-sm-6 \">\r\n                    <div class=\"form-group\">\r\n                        <label>");
#nullable restore
#line 152 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpBanks\view.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Branch"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <select id=\"BranchId\" name=\"BranchId\" class=\"form-control\">\r\n                            <option></option>\r\n");
#nullable restore
#line 155 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpBanks\view.cshtml"
                             if (isEdit)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 157 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpBanks\view.cshtml"
                                 foreach (var item in branchList)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <option");
            BeginWriteAttribute("value", " value=\"", 7745, "\"", 7767, 1);
#nullable restore
#line 159 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpBanks\view.cshtml"
WriteAttributeValue("", 7753, item.BranchId, 7753, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 159 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpBanks\view.cshtml"
                                                               Write(EmpBanksDetails != null && EmpBanksDetails.BranchId == item.BranchId ? "selected" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n                                        ");
#nullable restore
#line 160 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpBanks\view.cshtml"
                                   Write(item.BranchNameEn);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </option>\r\n");
#nullable restore
#line 162 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpBanks\view.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 162 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpBanks\view.cshtml"
                                 
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </select>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n\r\n\r\n</form>\r\n\r\n\r\n\r\n\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>

        $(function () {
            //$(""#tabBanks-tab"").addClass(""nav-link active"");
            $(""#tabBanks-tab"").css(""background-color"", ""#496b6a"");
            $(""#tabBanks-tab"").css(""color"", ""white"");
            var applicationName = getApplicationName();
            $(""#BankIban"").inputmask({ ""mask"": ""(AA) 9999999999999999999999"" });

            $('#CompanyId').change(function () {

                var id = $('#CompanyId').val();

                $.ajax({
                    url: applicationName +""Ajax/BranchCascading"",
                    async: false,
                    type: ""POST"",
                    data: { id: id },
                    success: function (data) {

                        var item = '';

                        $.each(data.result, function (i, product) {

                            item += ""<option value='"" + product.branchId + ""'>"" + product.branchNameEn + ""</option>"";
                        });

                        $(""#BranchId");
                WriteLiteral(@""").html(item);

                    }
                });

            });


        });

        $('#frmEdit').on('submit', function (e) {
            e.preventDefault();
            var actionType = $('#ACTION_TYPE').val();

            confirmAction('Confirm ?', 'Are you sure you want to save changes ?', 'info', 'Yes', 'No').then(function (result) {
                if (result.value == true) {

                    var params = $('#frmEdit').serialize();
                    $.ajax({
                        url: applicationName + ""ESS/empbanks/"" + actionType,
                        async: false,
                        type: ""POST"",
                        data: params,
                        success: function (data) {
                            if (data.result.isError != true) {
                                showMsg('Saved !', 'Record has been saved !', 'success');
                                setTimeout(function () {
                                    window.location = ap");
                WriteLiteral("plicationName +\'ESS/empbanks/emp/");
#nullable restore
#line 235 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpBanks\view.cshtml"
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




        });
        function navigation() {
            window.location = applicationName +'ESS/Profile/Index'
        };
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
