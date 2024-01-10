#pragma checksum "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpLoans\edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1400e02af81751506fbfd561ab99d57700c020c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_ESS_Views_EmpLoans_edit), @"mvc.1.0.view", @"/Areas/ESS/Views/EmpLoans/edit.cshtml")]
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
#line 1 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpLoans\edit.cshtml"
using ErpOnClick.DAL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpLoans\edit.cshtml"
using ErpOnClick.ErpMain.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1400e02af81751506fbfd561ab99d57700c020c", @"/Areas/ESS/Views/EmpLoans/edit.cshtml")]
    public class Areas_ESS_Views_EmpLoans_edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpLoans\edit.cshtml"
  


    IList<Branch> branchList = Model.branchList;
    IList<Company> companyList = Model.companyList;
    IList<Emp> empList = Model.empList;
    IList<Lookups> LoansTypeList = Model.LoansTypeList;
    IList<Lookups> attachmentTypeList = Model.attachmentTypeList;
    IList<Lookups> LoansStatusList = Model.LoansStatusList;

    Loans LoansDetails = Model.LoansDetails;
    var empId = Model.empId;
    Emp empDetails = Model.empDetails;

    bool isEdit = (LoansDetails != null);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<form id=\"frmEdit\" role=\"form\" enctype=\"multipart/form-data\">\r\n    <input type=\"hidden\" id=\"ACTION_TYPE\" name=\"ACTION_TYPE\"");
            BeginWriteAttribute("value", " value=\"", 733, "\"", 770, 1);
#nullable restore
#line 23 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpLoans\edit.cshtml"
WriteAttributeValue("", 741, isEdit ? "update" : "save", 741, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input type=\"hidden\" id=\"LoanId\" name=\"LoanId\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 847, "\"", 904, 1);
#nullable restore
#line 24 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpLoans\edit.cshtml"
WriteAttributeValue("", 855, LoansDetails != null ? LoansDetails.LoanId : 0, 855, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 24 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpLoans\edit.cshtml"
                                                                                                                              Write(isEdit ? "readonly" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(" min=\"3\" maxlength=\"3\">\r\n    <input type=\"hidden\" id=\"CompanyId\" name=\"CompanyId\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 1035, "\"", 1095, 1);
#nullable restore
#line 25 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpLoans\edit.cshtml"
WriteAttributeValue("", 1043, LoansDetails != null ? LoansDetails.CompanyId : 0, 1043, 52, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    <input type=\"hidden\" id=\"BranchId\" name=\"BranchId\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 1174, "\"", 1233, 1);
#nullable restore
#line 26 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpLoans\edit.cshtml"
WriteAttributeValue("", 1182, LoansDetails != null ? LoansDetails.BranchId : 0, 1182, 51, false);

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
#line 37 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpLoans\edit.cshtml"
           Write(Html.Partial("/Areas/ESS/Views/Profile/_tabsPartial.cshtml", empDetails));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n            </ul>\r\n        </div>\r\n        <div class=\"card-header\">\r\n            <h2 class=\"card-title\">\r\n                ");
#nullable restore
#line 44 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpLoans\edit.cshtml"
           Write(SharedLocalizer.GetLocalizedHtmlString("Details"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </h2>\r\n            <!-- tools box -->\r\n            <div class=\"card-tools float-right\"\">\r\n");
            WriteLiteral("                <a href=\"~/ESS/EmpLoans/emp/@empId\" type=\"button\" class=\"btn  btn-sm btn-default\">\r\n                    <i class=\"fal fa-arrow-left fa-fw\"></i> ");
#nullable restore
#line 52 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpLoans\edit.cshtml"
                                                       Write(SharedLocalizer.GetLocalizedHtmlString("Return"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </a>
            </div>
            <!-- /. tools -->
        </div>
        <div class=""card-body"">

            <div class=""row"">
                <div class=""col-sm-2 "">
                    <div class=""form-group"">
                        <label>");
#nullable restore
#line 62 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpLoans\edit.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Employee"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <select id=\"EmpId\" name=\"EmpId\" class=\"form-control\" disabled>\r\n                            <option></option>\r\n");
#nullable restore
#line 65 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpLoans\edit.cshtml"
                             foreach (var item in empList)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <option");
            BeginWriteAttribute("value", " value=\"", 3165, "\"", 3184, 1);
#nullable restore
#line 67 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpLoans\edit.cshtml"
WriteAttributeValue("", 3173, item.EmpId, 3173, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" selected>\r\n                                    ");
#nullable restore
#line 68 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpLoans\edit.cshtml"
                                Write(item.FirstNameEn + " " + item.FatherNameEn + " " + item.GrandNameEn + " " + item.FamilyNameEn);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </option>\r\n");
#nullable restore
#line 70 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpLoans\edit.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </select>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-sm-2\">\r\n                    <div class=\"form-group\">\r\n                        <label>");
#nullable restore
#line 76 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpLoans\edit.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Date Start"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <input type=\"text\" disabled id=\"DateStart\" name=\"DateStart\" class=\"form-control DatePicker\"");
            BeginWriteAttribute("value", " value=\"", 3787, "\"", 3925, 1);
#nullable restore
#line 77 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpLoans\edit.cshtml"
WriteAttributeValue("", 3795, LoansDetails != null && LoansDetails.DateStart !=null ? Convert.ToDateTime(LoansDetails.DateStart).ToString("dd-MMM-yyyy") : "", 3795, 130, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n                </div>\r\n\r\n                <div class=\"col-sm-2\">\r\n                    <div class=\"form-group\">\r\n                        <label>");
#nullable restore
#line 83 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpLoans\edit.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Loan Amount"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <input type=\"number\" disabled id=\"LoanAmount\" step=\"any\" name=\"LoanAmount\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 4283, "\"", 4339, 1);
#nullable restore
#line 84 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpLoans\edit.cshtml"
WriteAttributeValue("", 4291, LoansDetails!=null?LoansDetails.LoanAmount: 0, 4291, 48, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n                </div>\r\n\r\n                <div class=\"col-sm-3\">\r\n                    <div class=\"form-group\">\r\n                        <label>");
#nullable restore
#line 90 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpLoans\edit.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("No Of Installments"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <input type=\"number\" disabled id=\"NoOfInstallments\" name=\"NoOfInstallments\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 4705, "\"", 4767, 1);
#nullable restore
#line 91 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpLoans\edit.cshtml"
WriteAttributeValue("", 4713, LoansDetails!=null?LoansDetails.NoOfInstallments: 0, 4713, 54, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-sm-3\">\r\n                    <div class=\"form-group\">\r\n                        <label>");
#nullable restore
#line 96 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpLoans\edit.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Deduct Amount"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <input type=\"number\" disabled id=\"DeductAmount\" name=\"DeductAmount\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 5118, "\"", 5176, 1);
#nullable restore
#line 97 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpLoans\edit.cshtml"
WriteAttributeValue("", 5126, LoansDetails!=null?LoansDetails.DeductAmount: 0, 5126, 50, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n                </div>\r\n\r\n\r\n\r\n\r\n                <div class=\"col-sm-3\">\r\n                    <div class=\"form-group\">\r\n                        <label> ");
#nullable restore
#line 106 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpLoans\edit.cshtml"
                           Write(SharedLocalizer.GetLocalizedHtmlString("Loans Type"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <select id=\"LoanTypeId\" name=\"LoanTypeId\" class=\"form-control\" required disabled>\r\n                            <option></option>\r\n");
#nullable restore
#line 109 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpLoans\edit.cshtml"
                             foreach (var item in LoansTypeList)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <option");
            BeginWriteAttribute("value", " value=\"", 5711, "\"", 5729, 1);
#nullable restore
#line 111 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpLoans\edit.cshtml"
WriteAttributeValue("", 5719, item.Code, 5719, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 111 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpLoans\edit.cshtml"
                                                       Write(LoansDetails != null && LoansDetails.LoanTypeId == item.Code ? "selected" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n                                    ");
#nullable restore
#line 112 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpLoans\edit.cshtml"
                               Write(item.LookupNameEn);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </option>\r\n");
#nullable restore
#line 114 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpLoans\edit.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </select>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-sm-3\">\r\n                    <div class=\"form-group\">\r\n                        <label>");
#nullable restore
#line 120 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpLoans\edit.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Loans Status"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <select id=\"LoanStatus\" name=\"LoanStatus\" class=\"form-control\" required disabled>\r\n\r\n");
#nullable restore
#line 123 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpLoans\edit.cshtml"
                             foreach (var item in LoansStatusList)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <option");
            BeginWriteAttribute("value", " value=\"", 6461, "\"", 6479, 1);
#nullable restore
#line 125 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpLoans\edit.cshtml"
WriteAttributeValue("", 6469, item.Code, 6469, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 125 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpLoans\edit.cshtml"
                                                       Write(LoansDetails != null && LoansDetails.LoanStatus == item.Code ? "selected" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n                                    ");
#nullable restore
#line 126 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpLoans\edit.cshtml"
                               Write(item.LookupNameEn);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </option>\r\n");
#nullable restore
#line 128 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpLoans\edit.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </select>\r\n                    </div>\r\n                </div>\r\n");
            WriteLiteral("                <div class=\"col-md-12\">\r\n                    <hr>\r\n                </div>\r\n                <div class=\"col-md-12 card-header\">\r\n                    <label>");
#nullable restore
#line 165 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpLoans\edit.cshtml"
                      Write(SharedLocalizer.GetLocalizedHtmlString("Reason"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                    <textarea required id=\"Reason\" rows=\"4\" name=\"Reason\" disabled\r\n                              style=\"width: 100%; height: 80px; font-size: 14px; line-height: 18px; border: 1px solid #dddddd; padding: 10px;\">");
#nullable restore
#line 167 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpLoans\edit.cshtml"
                                                                                                                                           Write(LoansDetails != null? LoansDetails.Reason : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</textarea>
                </div>
                <div class=""col-md-12"">
                    <hr>
                </div>
            </div>
        </div>
    </div>
    <div class=""card card-default card-outline col-lg-12"" style=""display:none"">
        <div class=""card-header"">
            <h2 class=""card-title"">
                ");
#nullable restore
#line 178 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpLoans\edit.cshtml"
           Write(SharedLocalizer.GetLocalizedHtmlString("Organization Details"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </h2>\r\n        </div>\r\n        <div class=\"card-body\">\r\n            <div class=\"row\">\r\n\r\n                <div class=\"col-sm-6 \">\r\n                    <div class=\"form-group\">\r\n                        <label>");
#nullable restore
#line 186 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpLoans\edit.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Company"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <select id=\"CompanyId\" name=\"CompanyId\" class=\"form-control\">\r\n                            <option></option>\r\n");
#nullable restore
#line 189 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpLoans\edit.cshtml"
                             foreach (var item in companyList)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <option");
            BeginWriteAttribute("value", " value=\"", 9938, "\"", 9961, 1);
#nullable restore
#line 191 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpLoans\edit.cshtml"
WriteAttributeValue("", 9946, item.CompanyId, 9946, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 191 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpLoans\edit.cshtml"
                                                            Write(LoansDetails != null && LoansDetails.CompanyId == item.CompanyId ? "selected" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n                                    ");
#nullable restore
#line 192 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpLoans\edit.cshtml"
                               Write(item.CoNameEn);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </option>\r\n");
#nullable restore
#line 194 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpLoans\edit.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </select>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-sm-4 \">\r\n                    <div class=\"form-group\">\r\n                        <label>");
#nullable restore
#line 200 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpLoans\edit.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Branch"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <select id=\"BranchId\" name=\"BranchId\" class=\"form-control\">\r\n                            <option></option>\r\n");
#nullable restore
#line 203 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpLoans\edit.cshtml"
                             if (isEdit)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 205 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpLoans\edit.cshtml"
                                 foreach (var item in branchList)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <option");
            BeginWriteAttribute("value", " value=\"", 10791, "\"", 10813, 1);
#nullable restore
#line 207 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpLoans\edit.cshtml"
WriteAttributeValue("", 10799, item.BranchId, 10799, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 207 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpLoans\edit.cshtml"
                                                               Write(empDetails != null && empDetails.BranchId == item.BranchId ? "selected" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n                                        ");
#nullable restore
#line 208 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpLoans\edit.cshtml"
                                   Write(item.BranchNameEn);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </option>\r\n");
#nullable restore
#line 210 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpLoans\edit.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 210 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpLoans\edit.cshtml"
                                 
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </select>\r\n                    </div>\r\n                </div>\r\n\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</form>\r\n\r\n\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"

    <script>

        $(function () {


        });
        var applicationName = getApplicationName();

        $('#CompanyId').change(function () {

            var id = $('#CompanyId').val();

            $.ajax({
                url: applicationName + ""Ajax/BranchCascading"",
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

        $('#frmEdit').on('submit', function (e) {
            e.preventDefault();
            var actionType = $('#ACTION_TYPE').val();

            confirmAction('Confirm ?', 'Are you sure you want to save changes ?', 'info', 'Y");
                WriteLiteral(@"es', 'No').then(function (result) {
                if (result.value == true) {

                    var params = $('#frmEdit').serialize();
                    var formEl = document.forms.frmEdit;
                    var formData = new FormData(formEl);
                    $.ajax({
                        url: applicationName + ""ESS/EmpLoans/"" + actionType,
                        type: ""POST"",
                        data: formData ? formData : params,
                        async: false,
                        cache: false,
                        contentType: false,
                        processData: false,
                        success: function (data) {
                            if (data.result.isError != true) {
                                showMsg('Saved !', 'Record has been saved !', 'success');
                                setTimeout(function () {
                                    window.location = applicationName + 'ESS/EmpLoans/emp/");
#nullable restore
#line 282 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpLoans\edit.cshtml"
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
        $('#btnEmpSearch').click(function () {


            confirmAction('Confirm ?', 'Are you sure you want to Search  ?', 'info', 'Yes', 'No').then(function (result) {
                if (result.value == true) {
                    var empCode = $('#empCode').val();

                    $.ajax({
                        url: applicationName + ""Ajax/GetEmployee"",
                        async: false,
                        type: ""POST"",
                        data: { em");
                WriteLiteral(@"pCode: empCode },
                        success: function (data) {
                            if (data.result != """") {
                                var displayDAta = ""<div class='row' id='empDetail' ><div class='col-sm-4'><div id='DP' style='top: 58px;' class='widget-user-image'><img style=' margin-bottom: 6px; height:155px' id='profilePic' class='img-circle elevation-2'  src='https://www.w3schools.com/html/pic_trulli.jpg' /></div></div><div class='col-sm-8'><div class='row'><div class='col-sm-6'><div class='form-group'><label>Name</label><input type='text'  class='form-control' value='"" + data.result.empName + ""' disabled></div></div><div class='col-sm-6'><div class='form-group'><label>Title</label><input type='text' class='form-control' value='"" + data.result.jobTitle + ""' disabled></div></div><div class='col-sm-6'><div class='form-group'><label>Department</label><input type='text'  class='form-control' value='"" + data.result.departMent + ""' disabled></div></div><div class='col-sm-6'><div class='fo");
                WriteLiteral(@"rm-group'><label>Joining Date</label><input type='text' class='form-control' value='"" + data.result.joiningDate + ""' disabled></div></div></div></div></div>""


                                $('#searchEmpCardBody').show();
                                $('#searchEmpCardBody').html(displayDAta);


                                $(""#EmpId option"").each(function () {
                                    var empId = $(this).val();
                                    if (empId == data.result.empId) {
                                        $(this).prop('selected', true);
                                    }

                                });


                            }
                            else {
                                showMsg(""No Employee for this code found , Please try again!"");
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
