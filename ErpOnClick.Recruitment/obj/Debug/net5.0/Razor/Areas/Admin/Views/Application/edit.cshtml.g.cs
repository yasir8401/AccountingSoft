#pragma checksum "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Areas\Admin\Views\Application\edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "febee0d5c730af527bbb446c892e3c7871f81454"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Application_edit), @"mvc.1.0.view", @"/Areas/Admin/Views/Application/edit.cshtml")]
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
#line 1 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Areas\Admin\Views\Application\edit.cshtml"
using ErpOnClick.DAL.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"febee0d5c730af527bbb446c892e3c7871f81454", @"/Areas/Admin/Views/Application/edit.cshtml")]
    public class Areas_Admin_Views_Application_edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/application"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Areas\Admin\Views\Application\edit.cshtml"
  

    IList<Lookups> applicationSourceList = Model.applicationSourceList;
    IList<Lookups> applicationStatusList = Model.applicationStatusList;
    IList<Lookups> degreeList = Model.degreeList;
    IList<Lookups> deptList = Model.deptList;
    IList<Branch> branchList = Model.branchList;
    IList<Company> companyList = Model.companyList;
    IList<VacantJobs> vacantJobList = Model.vacantJobList;


    Applications applicationDetails = Model.applicationDetails;
    bool isEdit = (applicationDetails != null);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<form id=\"frmEdit\" role=\"form\">\r\n    <input type=\"hidden\" id=\"ACTION_TYPE\" name=\"ACTION_TYPE\"");
            BeginWriteAttribute("value", " value=\"", 663, "\"", 700, 1);
#nullable restore
#line 20 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Areas\Admin\Views\Application\edit.cshtml"
WriteAttributeValue("", 671, isEdit ? "update" : "save", 671, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input type=\"hidden\" id=\"ApplicationId\" name=\"ApplicationId\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 791, "\"", 867, 1);
#nullable restore
#line 21 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Areas\Admin\Views\Application\edit.cshtml"
WriteAttributeValue("", 799, applicationDetails != null ? applicationDetails.ApplicationId : 0, 799, 68, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 21 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Areas\Admin\Views\Application\edit.cshtml"
                                                                                                                                                               Write(isEdit ? "readonly" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(@" min=""3"" maxlength=""3"">

    <div class=""card card-default card-outline col-lg-8"">

        <div class=""card-header"">
            <h2 class=""card-title"">
                Details
            </h2>
            <!-- tools box -->
            <div class=""card-tools"">
                <button type=""submit"" class=""btn  btn-sm btn-primary"">
                    <i class=""fas fa-save fa-fw""></i> Save
                </button>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "febee0d5c730af527bbb446c892e3c7871f814546689", async() => {
                WriteLiteral("\r\n                    <i class=\"fas fa-arrow-left fa-fw\"></i> Return\r\n                ");
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
                        <label>Applicant Id</label>
                        <input type=""text"" id=""ApplicantId"" name=""ApplicantId"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 1884, "\"", 1956, 1);
#nullable restore
#line 46 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Areas\Admin\Views\Application\edit.cshtml"
WriteAttributeValue("", 1892, applicationDetails!=null?applicationDetails.ApplicantId: null, 1892, 64, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" required>
                    </div>
                </div>
                <div class=""col-sm-6"">
                    <div class=""form-group"">
                        <label>Name</label>
                        <input type=""text"" id=""ApplicantName"" name=""ApplicantName"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 2255, "\"", 2329, 1);
#nullable restore
#line 52 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Areas\Admin\Views\Application\edit.cshtml"
WriteAttributeValue("", 2263, applicationDetails!=null?applicationDetails.ApplicantName: null, 2263, 66, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" required>
                    </div>
                </div>
                <div class=""col-sm-6"">
                    <div class=""form-group"">
                        <label>Email</label>
                        <input type=""email"" id=""Email"" name=""Email"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 2614, "\"", 2680, 1);
#nullable restore
#line 58 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Areas\Admin\Views\Application\edit.cshtml"
WriteAttributeValue("", 2622, applicationDetails!=null?applicationDetails.Email: null, 2622, 58, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" required>
                    </div>
                </div>
                <div class=""col-sm-6"">
                    <div class=""form-group"">
                        <label>Phone</label>
                        <input type=""number"" id=""Phone"" name=""Phone"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 2966, "\"", 3032, 1);
#nullable restore
#line 64 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Areas\Admin\Views\Application\edit.cshtml"
WriteAttributeValue("", 2974, applicationDetails!=null?applicationDetails.Phone: null, 2974, 58, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" required>
                    </div>
                </div>

                <div class=""col-sm-6"">
                    <div class=""form-group"">
                        <label>Expected Salary</label>
                        <input type=""number"" id=""ExpectedSalary"" name=""ExpectedSalary"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 3348, "\"", 3423, 1);
#nullable restore
#line 71 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Areas\Admin\Views\Application\edit.cshtml"
WriteAttributeValue("", 3356, applicationDetails!=null?applicationDetails.ExpectedSalary: null, 3356, 67, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" required>
                    </div>
                </div>
                <div class=""col-sm-6"">
                    <div class=""form-group"">
                        <label>Expected Extra</label>
                        <input type=""number"" id=""ExpectedExtra"" name=""ExpectedExtra"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 3734, "\"", 3808, 1);
#nullable restore
#line 77 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Areas\Admin\Views\Application\edit.cshtml"
WriteAttributeValue("", 3742, applicationDetails!=null?applicationDetails.ExpectedExtra: null, 3742, 66, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" required>
                    </div>
                </div>
                <div class=""col-sm-6"">
                    <div class=""form-group"">
                        <label>Proposed Salary</label>
                        <input type=""number"" id=""ProposedSalary"" name=""ProposedSalary"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 4122, "\"", 4197, 1);
#nullable restore
#line 83 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Areas\Admin\Views\Application\edit.cshtml"
WriteAttributeValue("", 4130, applicationDetails!=null?applicationDetails.ProposedSalary: null, 4130, 67, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" required>
                    </div>
                </div>
                <div class=""col-sm-6"">
                    <div class=""form-group"">
                        <label>Proposed Extra</label>
                        <input type=""number"" id=""ProposedExtra"" name=""ProposedExtra"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 4508, "\"", 4582, 1);
#nullable restore
#line 89 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Areas\Admin\Views\Application\edit.cshtml"
WriteAttributeValue("", 4516, applicationDetails!=null?applicationDetails.ProposedExtra: null, 4516, 66, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" required>
                    </div>
                </div>
                <div class=""col-sm-6"">
                    <div class=""form-group"">
                        <label>Availability</label>
                        <input type=""text"" id=""Availability"" required name=""Availability"" class=""form-control DatePicker""");
            BeginWriteAttribute("value", " value=\"", 4907, "\"", 5069, 1);
#nullable restore
#line 95 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Areas\Admin\Views\Application\edit.cshtml"
WriteAttributeValue("", 4915, applicationDetails != null && applicationDetails.Availability !=null ? Convert.ToDateTime(applicationDetails.Availability).ToString("dd-MMM-yyyy") : "", 4915, 154, false);

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
                More Details
            </h2>
        </div>
        <div class=""card-body"">
            <div class=""row"">

                <div class=""col-sm-6 "">
                    <div class=""form-group"">
                        <label>Source Type</label>
                        <select id=""ApplicationSourceType"" name=""ApplicationSourceType"" class=""form-control"" required>

");
#nullable restore
#line 116 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Areas\Admin\Views\Application\edit.cshtml"
                             foreach (var item in applicationSourceList)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <option");
            BeginWriteAttribute("value", " value=\"", 5842, "\"", 5860, 1);
#nullable restore
#line 118 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Areas\Admin\Views\Application\edit.cshtml"
WriteAttributeValue("", 5850, item.Code, 5850, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 118 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Areas\Admin\Views\Application\edit.cshtml"
                                                       Write(applicationDetails != null && applicationDetails.ApplicationSourceType == item.Code ? "selected" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n                                    ");
#nullable restore
#line 119 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Areas\Admin\Views\Application\edit.cshtml"
                               Write(item.LookupNameEn);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </option>\r\n");
#nullable restore
#line 121 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Areas\Admin\Views\Application\edit.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </select>
                    </div>
                </div>


                <div class=""col-sm-6 "">
                    <div class=""form-group"">
                        <label>Degree</label>
                        <select id=""DegreeId"" name=""DegreeId"" class=""form-control"" required>

");
#nullable restore
#line 132 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Areas\Admin\Views\Application\edit.cshtml"
                             foreach (var item in degreeList)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <option");
            BeginWriteAttribute("value", " value=\"", 6553, "\"", 6571, 1);
#nullable restore
#line 134 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Areas\Admin\Views\Application\edit.cshtml"
WriteAttributeValue("", 6561, item.Code, 6561, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 134 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Areas\Admin\Views\Application\edit.cshtml"
                                                       Write(applicationDetails != null && applicationDetails.DegreeId == item.Code ? "selected" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n                                    ");
#nullable restore
#line 135 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Areas\Admin\Views\Application\edit.cshtml"
                               Write(item.LookupNameEn);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </option>\r\n");
#nullable restore
#line 137 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Areas\Admin\Views\Application\edit.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </select>
                    </div>
                </div>
                <div class=""col-sm-6 "">
                    <div class=""form-group"">
                        <label> Job</label>
                        <select id=""VacantJobId"" name=""VacantJobId"" class=""form-control"" required>

");
#nullable restore
#line 146 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Areas\Admin\Views\Application\edit.cshtml"
                             foreach (var item in vacantJobList)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <option");
            BeginWriteAttribute("value", " value=\"", 7254, "\"", 7273, 1);
#nullable restore
#line 148 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Areas\Admin\Views\Application\edit.cshtml"
WriteAttributeValue("", 7262, item.JobId, 7262, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 148 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Areas\Admin\Views\Application\edit.cshtml"
                                                        Write(applicationDetails != null && applicationDetails.VacantJobId == item.JobId ? "selected" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n                                    ");
#nullable restore
#line 149 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Areas\Admin\Views\Application\edit.cshtml"
                               Write(item.JobTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </option>\r\n");
#nullable restore
#line 151 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Areas\Admin\Views\Application\edit.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </select>
                    </div>
                </div>
                <div class=""col-sm-6 "">
                    <div class=""form-group"">
                        <label>Job Department</label>
                        <select id=""JobDepartmentId"" name=""JobDepartmentId"" class=""form-control"" required>

");
#nullable restore
#line 160 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Areas\Admin\Views\Application\edit.cshtml"
                             foreach (var item in deptList)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <option");
            BeginWriteAttribute("value", " value=\"", 7969, "\"", 7987, 1);
#nullable restore
#line 162 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Areas\Admin\Views\Application\edit.cshtml"
WriteAttributeValue("", 7977, item.Code, 7977, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 162 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Areas\Admin\Views\Application\edit.cshtml"
                                                       Write(applicationDetails != null && applicationDetails.JobDepartmentId == item.Code ? "selected" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n                                    ");
#nullable restore
#line 163 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Areas\Admin\Views\Application\edit.cshtml"
                               Write(item.LookupNameEn);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </option>\r\n");
#nullable restore
#line 165 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Areas\Admin\Views\Application\edit.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </select>
                    </div>
                </div>
                <div class=""col-sm-6 "">
                    <div class=""form-group"">
                        <label>Company</label>
                        <select id=""CompanyId"" name=""CompanyId"" class=""form-control"" required>
                            <option></option>
");
#nullable restore
#line 174 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Areas\Admin\Views\Application\edit.cshtml"
                             foreach (var item in companyList)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <option");
            BeginWriteAttribute("value", " value=\"", 8719, "\"", 8742, 1);
#nullable restore
#line 176 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Areas\Admin\Views\Application\edit.cshtml"
WriteAttributeValue("", 8727, item.CompanyId, 8727, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 176 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Areas\Admin\Views\Application\edit.cshtml"
                                                            Write(applicationDetails != null && applicationDetails.CompanyId == item.CompanyId ? "selected" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n                                    ");
#nullable restore
#line 177 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Areas\Admin\Views\Application\edit.cshtml"
                               Write(item.CoNameEn);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </option>\r\n");
#nullable restore
#line 179 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Areas\Admin\Views\Application\edit.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </select>
                    </div>
                </div>
                <div class=""col-sm-6 "">
                    <div class=""form-group"">
                        <label>Branch</label>
                        <select id=""BranchId"" name=""BranchId"" class=""form-control"" required>
");
#nullable restore
#line 187 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Areas\Admin\Views\Application\edit.cshtml"
                             if (isEdit)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 189 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Areas\Admin\Views\Application\edit.cshtml"
                                 foreach (var item in branchList)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <option");
            BeginWriteAttribute("value", " value=\"", 9503, "\"", 9525, 1);
#nullable restore
#line 191 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Areas\Admin\Views\Application\edit.cshtml"
WriteAttributeValue("", 9511, item.BranchId, 9511, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 191 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Areas\Admin\Views\Application\edit.cshtml"
                                                               Write(applicationDetails != null && applicationDetails.BranchId == item.BranchId ? "selected" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n                                        ");
#nullable restore
#line 192 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Areas\Admin\Views\Application\edit.cshtml"
                                   Write(item.BranchNameEn);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </option>\r\n");
#nullable restore
#line 194 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Areas\Admin\Views\Application\edit.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 194 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Areas\Admin\Views\Application\edit.cshtml"
                                 
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </select>
                    </div>
                </div>
                <div class=""col-sm-6 "">
                    <div class=""form-group"">
                        <label>Status</label>
                        <select id=""ApplicationStatus"" name=""ApplicationStatus"" class=""form-control"" required>

");
#nullable restore
#line 204 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Areas\Admin\Views\Application\edit.cshtml"
                             foreach (var item in applicationStatusList)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <option");
            BeginWriteAttribute("value", " value=\"", 10277, "\"", 10295, 1);
#nullable restore
#line 206 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Areas\Admin\Views\Application\edit.cshtml"
WriteAttributeValue("", 10285, item.Code, 10285, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 206 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Areas\Admin\Views\Application\edit.cshtml"
                                                       Write(applicationDetails != null && applicationDetails.ApplicationStatus == item.Code ? "selected" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n                                    ");
#nullable restore
#line 207 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Areas\Admin\Views\Application\edit.cshtml"
                               Write(item.LookupNameEn);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </option>\r\n");
#nullable restore
#line 209 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Areas\Admin\Views\Application\edit.cshtml"
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
    <div class=""card card-outline card-outline col-lg-8"">
        <div class=""card-header"">
            <h3 class=""card-title"">
                Summary
            </h3>

        </div>
        <!-- /.card-header -->
        <div class=""card-body pad"">
            <div class=""mb-3"">
                <textarea id=""ApplicationSummary"" rows=""8"" name=""ApplicationSummary""
                          style=""width: 100%; height: 200px; font-size: 14px; line-height: 18px; border: 1px solid #dddddd; padding: 10px;"">");
#nullable restore
#line 227 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Areas\Admin\Views\Application\edit.cshtml"
                                                                                                                                        Write(applicationDetails != null? applicationDetails.ApplicationSummary : "");

#line default
#line hidden
#nullable disable
            WriteLiteral("</textarea>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n</form>\r\n\r\n\r\n\r\n\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"

    <script>
        var applicationName = getApplicationName();

        $(function () {

            $('#ApplicationSummary').summernote(
                {
                    height: 200,

                }
            );
        });


        $('#frmEdit').on('submit', function (e) {
            e.preventDefault();
            var actionType = $('#ACTION_TYPE').val();

            confirmAction('Confirm ?', 'Are you sure you want to save changes ?', 'info', 'Yes', 'No').then(function (result) {
                if (result.value == true) {

                    var params = $('#frmEdit').serialize();
                    $.ajax({
                        url: applicationName+""admin/application/"" + actionType,
                        async: false,
                        type: ""POST"",
                        data: params,
                        success: function (data) {
                            if (data.result.isError != true) {
                                showMsg('Save");
                WriteLiteral(@"d !', 'Record has been saved !', 'success');
                                setTimeout(function () {
                                    window.location = applicationName+'admin/application';
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
            debugger;
            var id = $('#CompanyId').val();

            $.ajax({
                url: applicationName+""Ajax/BranchCascading"",
                async: false,
                type: ""POST"",
                data: { id: id },");
                WriteLiteral(@"
                success: function (data) {
               
                    var item = '';

                    $.each(data.result, function (i, product) {
                        debugger;
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
