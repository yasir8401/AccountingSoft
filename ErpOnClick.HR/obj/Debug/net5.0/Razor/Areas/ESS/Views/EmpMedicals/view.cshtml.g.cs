#pragma checksum "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpMedicals\view.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff60be0646fce249e902cb0651f7f64937ed28eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_ESS_Views_EmpMedicals_view), @"mvc.1.0.view", @"/Areas/ESS/Views/EmpMedicals/view.cshtml")]
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
#line 1 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpMedicals\view.cshtml"
using ErpOnClick.DAL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpMedicals\view.cshtml"
using ErpOnClick.ErpMain.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff60be0646fce249e902cb0651f7f64937ed28eb", @"/Areas/ESS/Views/EmpMedicals/view.cshtml")]
    public class Areas_ESS_Views_EmpMedicals_view : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpMedicals\view.cshtml"
  
    IList<Branch> branchList = Model.branchList;
    IList<Company> companyList = Model.companyList;
    IList<Emp> empList = Model.empList;

    IList<Lookups> medicalCompanyList = Model.medicalCompanyList;
    IList<Lookups> medicalClassList = Model.medicalClassList;
    IList<Lookups> bloodGroupList = Model.bloodGroupList;
    IList<Lookups> SpecialList = Model.SpecialList;

    var empId = Model.empId;
    Emp empDetails = Model.empDetails;
    EmpMedicals EmpMedicalsDetails = Model.EmpMedicalsDetails;
    bool isEdit = (EmpMedicalsDetails != null);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<form id=\"frmEdit\" role=\"form\" enctype=\"multipart/form-data\">\r\n    <input type=\"hidden\" id=\"ACTION_TYPE\" name=\"ACTION_TYPE\"");
            BeginWriteAttribute("value", " value=\"", 814, "\"", 851, 1);
#nullable restore
#line 24 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpMedicals\view.cshtml"
WriteAttributeValue("", 822, isEdit ? "update" : "save", 822, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input type=\"hidden\" id=\"EmpMedicalId\" name=\"EmpMedicalId\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 940, "\"", 1015, 1);
#nullable restore
#line 25 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpMedicals\view.cshtml"
WriteAttributeValue("", 948, EmpMedicalsDetails != null ? EmpMedicalsDetails.EmpMedicalId : 0, 948, 67, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 25 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpMedicals\view.cshtml"
                                                                                                                                                            Write(isEdit ? "readonly" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(" min=\"3\" maxlength=\"3\">\r\n    <input type=\"hidden\" id=\"CompanyId\" name=\"CompanyId\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 1146, "\"", 1218, 1);
#nullable restore
#line 26 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpMedicals\view.cshtml"
WriteAttributeValue("", 1154, EmpMedicalsDetails != null ? EmpMedicalsDetails.CompanyId : 0, 1154, 64, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" >\r\n    <input type=\"hidden\" id=\"BranchId\" name=\"BranchId\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 1298, "\"", 1369, 1);
#nullable restore
#line 27 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpMedicals\view.cshtml"
WriteAttributeValue("", 1306, EmpMedicalsDetails != null ? EmpMedicalsDetails.BranchId : 0, 1306, 63, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" >

    <div class=""card card-default card-outline col-lg-12"">
        <div class=""card-header p-0 border-bottom-0"">
            <div class=""card"" style=""background-color: #496b6a"">
            </div>
            <ul class=""nav nav-tabs"" id=""custom-content-below-tab"" role=""tablist"">
");
            WriteLiteral("\r\n\r\n                ");
#nullable restore
#line 39 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpMedicals\view.cshtml"
           Write(Html.Partial("/Areas/ESS/Views/Profile/_tabsPartial.cshtml", empDetails));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n            </ul>\r\n        </div>\r\n        <div class=\"card-header\">\r\n            <h2 class=\"card-title\">\r\n                ");
#nullable restore
#line 46 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpMedicals\view.cshtml"
           Write(SharedLocalizer.GetLocalizedHtmlString("Details"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </h2>
            <!-- tools box -->
            <div class=""card-tools float-right"""">
               
                <a href=""~/ESS/EmpMedicals/emp/@empId"" type=""button"" class=""btn  btn-sm btn-default"">
                    <i class=""fal fa-arrow-left fa-fw""></i> ");
#nullable restore
#line 52 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpMedicals\view.cshtml"
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
                <div class=""col-sm-6 "">
                    <div class=""form-group"">
                        <label>");
#nullable restore
#line 62 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpMedicals\view.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Employee"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <select id=\"EmpId\" name=\"EmpId\" class=\"form-control\" disabled>\r\n\r\n");
#nullable restore
#line 65 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpMedicals\view.cshtml"
                             foreach (var item in empList)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <option");
            BeginWriteAttribute("value", " value=\"", 3073, "\"", 3092, 1);
#nullable restore
#line 67 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpMedicals\view.cshtml"
WriteAttributeValue("", 3081, item.EmpId, 3081, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 67 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpMedicals\view.cshtml"
                                                        Write(EmpMedicalsDetails != null && EmpMedicalsDetails.EmpId == item.EmpId ? "selected" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n                                    ");
#nullable restore
#line 68 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpMedicals\view.cshtml"
                                Write(item.FirstNameEn + " " + item.FatherNameEn + " " + item.GrandNameEn + " " + item.FamilyNameEn);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </option>\r\n");
#nullable restore
#line 70 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpMedicals\view.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </select>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-sm-6\">\r\n                    <div class=\"form-group\">\r\n                        <label>");
#nullable restore
#line 76 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpMedicals\view.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Med Card"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <input disabled type=\"text\" id=\"MedicalCardNo\" name=\"MedicalCardNo\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 3771, "\"", 3845, 1);
#nullable restore
#line 77 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpMedicals\view.cshtml"
WriteAttributeValue("", 3779, EmpMedicalsDetails!=null?EmpMedicalsDetails.MedicalCardNo: null, 3779, 66, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-sm-6\">\r\n                    <div class=\"form-group\">\r\n                        <label>");
#nullable restore
#line 82 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpMedicals\view.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Issued Date"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <input disabled type=\"text\" id=\"IssueDate\" name=\"IssueDate\" class=\"form-control DatePicker\"");
            BeginWriteAttribute("value", " value=\"", 4197, "\"", 4353, 1);
#nullable restore
#line 83 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpMedicals\view.cshtml"
WriteAttributeValue("", 4205, EmpMedicalsDetails != null && EmpMedicalsDetails.IssueDate !=null ? Convert.ToDateTime(EmpMedicalsDetails.IssueDate).ToString("dd-MMM-yyyy") : "", 4205, 148, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-sm-6\">\r\n                    <div class=\"form-group\">\r\n                        <label>");
#nullable restore
#line 89 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpMedicals\view.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Expiry Date"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <input disabled type=\"text\" id=\"ExpiryDate\" name=\"ExpiryDate\" class=\"form-control DatePicker\"");
            BeginWriteAttribute("value", " value=\"", 4709, "\"", 4867, 1);
#nullable restore
#line 90 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpMedicals\view.cshtml"
WriteAttributeValue("", 4717, EmpMedicalsDetails != null && EmpMedicalsDetails.ExpiryDate !=null ? Convert.ToDateTime(EmpMedicalsDetails.ExpiryDate).ToString("dd-MMM-yyyy") : "", 4717, 150, false);

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
    <div class=""card card-default card-outline col-lg-12"">
        <div class=""card-header"">
            <h2 class=""card-title"">
                ");
#nullable restore
#line 102 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpMedicals\view.cshtml"
           Write(SharedLocalizer.GetLocalizedHtmlString("More Details"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </h2>\r\n        </div>\r\n        <div class=\"card-body\">\r\n            <div class=\"row\">\r\n\r\n\r\n                <div class=\"col-sm-6 \">\r\n                    <div class=\"form-group\">\r\n                        <label> ");
#nullable restore
#line 111 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpMedicals\view.cshtml"
                           Write(SharedLocalizer.GetLocalizedHtmlString("Blood Group"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <select id=\"BloodGroupId\" name=\"BloodGroupId\" class=\"form-control\" disabled>\r\n\r\n");
#nullable restore
#line 114 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpMedicals\view.cshtml"
                             foreach (var item in bloodGroupList)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <option");
            BeginWriteAttribute("value", " value=\"", 5709, "\"", 5727, 1);
#nullable restore
#line 116 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpMedicals\view.cshtml"
WriteAttributeValue("", 5717, item.Code, 5717, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 116 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpMedicals\view.cshtml"
                                                       Write(EmpMedicalsDetails != null && EmpMedicalsDetails.BloodGroupId == item.Code ? "selected" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n                                    ");
#nullable restore
#line 117 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpMedicals\view.cshtml"
                               Write(item.LookupNameEn);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </option>\r\n");
#nullable restore
#line 119 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpMedicals\view.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </select>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-sm-6 \">\r\n                    <div class=\"form-group\">\r\n                        <label> ");
#nullable restore
#line 125 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpMedicals\view.cshtml"
                           Write(SharedLocalizer.GetLocalizedHtmlString("Medical Company"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <select id=\"MedicalCompanyId\" name=\"MedicalCompanyId\" class=\"form-control\" disabled>\r\n\r\n");
#nullable restore
#line 128 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpMedicals\view.cshtml"
                             foreach (var item in medicalCompanyList)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <option");
            BeginWriteAttribute("value", " value=\"", 6484, "\"", 6502, 1);
#nullable restore
#line 130 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpMedicals\view.cshtml"
WriteAttributeValue("", 6492, item.Code, 6492, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 130 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpMedicals\view.cshtml"
                                                       Write(EmpMedicalsDetails != null && EmpMedicalsDetails.MedicalCompanyId == item.Code ? "selected" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n                                    ");
#nullable restore
#line 131 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpMedicals\view.cshtml"
                               Write(item.LookupNameEn);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </option>\r\n");
#nullable restore
#line 133 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpMedicals\view.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </select>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-sm-6\">\r\n                    <div class=\"form-group\">\r\n                        <label> ");
#nullable restore
#line 139 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpMedicals\view.cshtml"
                           Write(SharedLocalizer.GetLocalizedHtmlString("Medical Class"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <select id=\"MedicalClassId\" name=\"MedicalClassId\" class=\"form-control\" disabled>\r\n\r\n");
#nullable restore
#line 142 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpMedicals\view.cshtml"
                             foreach (var item in medicalClassList)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <option");
            BeginWriteAttribute("value", " value=\"", 7254, "\"", 7272, 1);
#nullable restore
#line 144 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpMedicals\view.cshtml"
WriteAttributeValue("", 7262, item.Code, 7262, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 144 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpMedicals\view.cshtml"
                                                       Write(EmpMedicalsDetails != null && EmpMedicalsDetails.MedicalClassId == item.Code ? "selected" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n                                    ");
#nullable restore
#line 145 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpMedicals\view.cshtml"
                               Write(item.LookupNameEn);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </option>\r\n");
#nullable restore
#line 147 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpMedicals\view.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </select>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-sm-6\">\r\n                    <div class=\"form-group\">\r\n                        <label> ");
#nullable restore
#line 153 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpMedicals\view.cshtml"
                           Write(SharedLocalizer.GetLocalizedHtmlString("Special Needs"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <input disabled type=\"checkbox\" id=\"SpecialNeeds\" name=\"SpecialNeeds\" style=\"margin-left:5px;width:15px\" class=\"form-control\" value=\"true\" ");
#nullable restore
#line 154 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpMedicals\view.cshtml"
                                                                                                                                                               Write(EmpMedicalsDetails != null && EmpMedicalsDetails.SpecialNeeds != null ? (Convert.ToBoolean(EmpMedicalsDetails.SpecialNeeds) ? "checked" : "") : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-sm-6\" id=\"special\">\r\n                    <div class=\"form-group\">\r\n                        <label> ");
#nullable restore
#line 160 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpMedicals\view.cshtml"
                           Write(SharedLocalizer.GetLocalizedHtmlString("Special Need"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <select id=\"SpecialNeed\" name=\"SpecialNeed\" class=\"form-control\">\r\n                            <option></option>\r\n");
#nullable restore
#line 163 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpMedicals\view.cshtml"
                             foreach (var item in SpecialList)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <option");
            BeginWriteAttribute("value", " value=\"", 8612, "\"", 8630, 1);
#nullable restore
#line 165 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpMedicals\view.cshtml"
WriteAttributeValue("", 8620, item.Code, 8620, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 165 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpMedicals\view.cshtml"
                                                       Write(EmpMedicalsDetails != null && EmpMedicalsDetails.SpecialNeed == item.Code ? "selected" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n                                    ");
#nullable restore
#line 166 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpMedicals\view.cshtml"
                               Write(item.LookupNameEn);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 166 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpMedicals\view.cshtml"
                                                    Write(item.LookupNameAr);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </option>\r\n");
#nullable restore
#line 168 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpMedicals\view.cshtml"
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
#line 178 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpMedicals\view.cshtml"
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
#line 185 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpMedicals\view.cshtml"
                                                                                                                                        Write(EmpMedicalsDetails != null? EmpMedicalsDetails.Note : "");

#line default
#line hidden
#nullable disable
            WriteLiteral("</textarea>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n    <div class=\"card card-outline card-outline col-lg-12\" style=\"display:none\">\r\n        <div class=\"card-header\">\r\n            <h3 class=\"card-title\">\r\n                ");
#nullable restore
#line 193 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpMedicals\view.cshtml"
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
#line 202 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpMedicals\view.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Company"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <select id=\"CompanyId\" name=\"CompanyId\" class=\"form-control\">\r\n\r\n");
#nullable restore
#line 205 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpMedicals\view.cshtml"
                             foreach (var item in companyList)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <option");
            BeginWriteAttribute("value", " value=\"", 10449, "\"", 10472, 1);
#nullable restore
#line 207 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpMedicals\view.cshtml"
WriteAttributeValue("", 10457, item.CompanyId, 10457, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 207 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpMedicals\view.cshtml"
                                                            Write(EmpMedicalsDetails != null && EmpMedicalsDetails.CompanyId == item.CompanyId ? "selected" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n                                    ");
#nullable restore
#line 208 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpMedicals\view.cshtml"
                               Write(item.CoNameEn);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </option>\r\n");
#nullable restore
#line 210 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpMedicals\view.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </select>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-sm-6 \">\r\n                    <div class=\"form-group\">\r\n                        <label>");
#nullable restore
#line 216 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpMedicals\view.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Branch"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <select id=\"BranchId\" name=\"BranchId\" class=\"form-control\">\r\n\r\n");
#nullable restore
#line 219 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpMedicals\view.cshtml"
                             foreach (var item in branchList)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <option");
            BeginWriteAttribute("value", " value=\"", 11184, "\"", 11206, 1);
#nullable restore
#line 221 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpMedicals\view.cshtml"
WriteAttributeValue("", 11192, item.BranchId, 11192, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 221 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpMedicals\view.cshtml"
                                                           Write(EmpMedicalsDetails != null && EmpMedicalsDetails.BranchId == item.BranchId ? "selected" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n                                    ");
#nullable restore
#line 222 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpMedicals\view.cshtml"
                               Write(item.BranchNameEn);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </option>\r\n");
#nullable restore
#line 224 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpMedicals\view.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </select>\r\n                    </div>\r\n                </div>\r\n\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n\r\n</form>\r\n\r\n\r\n\r\n\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"

    <script>
        var applicationName = getApplicationName();
        $(function () {
            //$(""#tabMedicals-tab"").addClass(""nav-link active"");
            $(""#tabMedicals-tab"").css(""background-color"", ""#496b6a"");
            $(""#tabMedicals-tab"").css(""color"", ""white"");
            var SpecialNeeds = $('#SpecialNeeds').prop('checked');
            if (SpecialNeeds == true) {
                $('#special').show();
            }
            else {
                $('#special').hide();
            }

        });

        $('#SpecialNeeds').change(function () {

            var SpecialNeeds = $('#SpecialNeeds').prop('checked');
            if (SpecialNeeds == true) {
                $('#special').show();
            }
            else {
                $('#special').hide();
            }
        });

        $('#frmEdit').on('submit', function (e) {
            e.preventDefault();
            var actionType = $('#ACTION_TYPE').val();

            confirmAction('Confirm ");
                WriteLiteral(@"?', 'Are you sure you want to save changes ?', 'info', 'Yes', 'No').then(function (result) {
                if (result.value == true) {

                    var params = $('#frmEdit').serialize();
                    $.ajax({
                        url: applicationName +""ESS/EmpMedicals/"" + actionType,
                        async: false,
                        type: ""POST"",
                        data: params,
                        success: function (data) {
                            if (data.result.isError != true) {
                                showMsg('Saved !', 'Record has been saved !', 'success');
                                setTimeout(function () {
                                    window.location = applicationName +'ESS/EmpMedicals/emp/");
#nullable restore
#line 286 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpMedicals\view.cshtml"
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