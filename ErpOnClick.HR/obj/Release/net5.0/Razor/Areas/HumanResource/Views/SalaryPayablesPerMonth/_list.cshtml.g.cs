#pragma checksum "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SalaryPayablesPerMonth\_list.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e74bd18946a99f4f41bc94a2c7ebda6d0729efa6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_HumanResource_Views_SalaryPayablesPerMonth__list), @"mvc.1.0.view", @"/Areas/HumanResource/Views/SalaryPayablesPerMonth/_list.cshtml")]
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
#line 1 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SalaryPayablesPerMonth\_list.cshtml"
using ErpOnClick.DAL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SalaryPayablesPerMonth\_list.cshtml"
using ErpOnClick.ErpMain.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e74bd18946a99f4f41bc94a2c7ebda6d0729efa6", @"/Areas/HumanResource/Views/SalaryPayablesPerMonth/_list.cshtml")]
    public class Areas_HumanResource_Views_SalaryPayablesPerMonth__list : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 7 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SalaryPayablesPerMonth\_list.cshtml"
  

    List<SalaryPayablesPerMonth> empSalaryPayablesPerMonthList = Model.empSalaryPayablesPerMonthList;


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"table-responsive pb-2 \">\r\n    <table id=\"dtList\" class=\"table table-hover table-condensed \" style=\"display:none\">\r\n        <thead class=\"text-sm\">\r\n            <tr>\r\n                <th>");
#nullable restore
#line 18 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SalaryPayablesPerMonth\_list.cshtml"
               Write(SharedLocalizer.GetLocalizedHtmlString("Payable Id"));

#line default
#line hidden
#nullable disable
            WriteLiteral("  </th>\r\n                <th>");
#nullable restore
#line 19 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SalaryPayablesPerMonth\_list.cshtml"
               Write(SharedLocalizer.GetLocalizedHtmlString("EMP"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 20 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SalaryPayablesPerMonth\_list.cshtml"
               Write(SharedLocalizer.GetLocalizedHtmlString("Other Deduction"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n                <th>");
#nullable restore
#line 21 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SalaryPayablesPerMonth\_list.cshtml"
               Write(SharedLocalizer.GetLocalizedHtmlString("Absent Fine"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n                <th>");
#nullable restore
#line 22 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SalaryPayablesPerMonth\_list.cshtml"
               Write(SharedLocalizer.GetLocalizedHtmlString("Loan Deduction"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n                <th>");
#nullable restore
#line 23 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SalaryPayablesPerMonth\_list.cshtml"
               Write(SharedLocalizer.GetLocalizedHtmlString("Total Deduction"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n                <th>");
#nullable restore
#line 24 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SalaryPayablesPerMonth\_list.cshtml"
               Write(SharedLocalizer.GetLocalizedHtmlString("Additions"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n                <th>");
#nullable restore
#line 25 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SalaryPayablesPerMonth\_list.cshtml"
               Write(SharedLocalizer.GetLocalizedHtmlString("Salary Month"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n                <th>");
#nullable restore
#line 26 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SalaryPayablesPerMonth\_list.cshtml"
               Write(SharedLocalizer.GetLocalizedHtmlString("Salary Year"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n                <th>");
#nullable restore
#line 27 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SalaryPayablesPerMonth\_list.cshtml"
               Write(SharedLocalizer.GetLocalizedHtmlString("Salary Date"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </th>
            </tr>
        </thead>
        <tfoot style=""display:table-row-group"">
            <tr class=""text-center"">
                <th>PayableId </th>
                <th>EMP</th>
                <th>OtherDeduction </th>
                <th>AbsentFine </th>
                <th>Loan Deduction </th>
                <th>TotalDeduction </th>
                <th>Additions </th>
                <th>SalaryMonth </th>
                <th>SalaryYear </th>
                <th>SalaryDate </th>

            </tr>
        </tfoot>
        <tbody>
");
#nullable restore
#line 46 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SalaryPayablesPerMonth\_list.cshtml"
             foreach (var item in empSalaryPayablesPerMonthList)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr class=\"text-center\">\r\n\r\n                <td><input type=\"text\" id=\"PayableId\" hidden");
            BeginWriteAttribute("value", " value=\"", 1972, "\"", 2015, 1);
#nullable restore
#line 51 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SalaryPayablesPerMonth\_list.cshtml"
WriteAttributeValue("", 1980, item !=null ? item.PayableId : 0, 1980, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" readonly name=\"PayableId\" class=\"form-control\" /> ");
#nullable restore
#line 51 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SalaryPayablesPerMonth\_list.cshtml"
                                                                                                                                                      Write(item.PayableId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td><input type=\"text\" id=\"EmpId\" hidden");
            BeginWriteAttribute("value", " value=\"", 2145, "\"", 2184, 1);
#nullable restore
#line 52 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SalaryPayablesPerMonth\_list.cshtml"
WriteAttributeValue("", 2153, item !=null ? item.EmpId : 0, 2153, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" readonly name=\"EmpId\" class=\"form-control\" />");
#nullable restore
#line 52 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SalaryPayablesPerMonth\_list.cshtml"
                                                                                                                                          Write(item.Emp.FirstNameEn + " " + item.Emp.FatherNameEn + " " + item.Emp.GrandNameEn + " " + item.Emp.FamilyNameEn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td><input type=\"number\" id=\"OtherDeduction\"");
            BeginWriteAttribute("value", " value=\"", 2410, "\"", 2458, 1);
#nullable restore
#line 53 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SalaryPayablesPerMonth\_list.cshtml"
WriteAttributeValue("", 2418, item !=null ? item.OtherDeduction : 0, 2418, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"OtherDeduction\" class=\"form-control\" />    </td>\r\n                <td><input type=\"number\" id=\"AbsentFine\"");
            BeginWriteAttribute("value", " value=\"", 2572, "\"", 2616, 1);
#nullable restore
#line 54 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SalaryPayablesPerMonth\_list.cshtml"
WriteAttributeValue("", 2580, item !=null ? item.AbsentFine : 0, 2580, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"AbsentFine\" class=\"form-control\" />    </td>\r\n                <td><input type=\"number\" id=\"LoadDeductionThisMonth\"");
            BeginWriteAttribute("value", " value=\"", 2738, "\"", 2794, 1);
#nullable restore
#line 55 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SalaryPayablesPerMonth\_list.cshtml"
WriteAttributeValue("", 2746, item !=null ? item.LoadDeductionThisMonth : 0, 2746, 48, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"LoadDeductionThisMonth\" class=\"form-control\" />    </td>\r\n                <td><input type=\"number\" id=\"TotalDeduction\" readonly");
            BeginWriteAttribute("value", " value=\"", 2929, "\"", 2977, 1);
#nullable restore
#line 56 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SalaryPayablesPerMonth\_list.cshtml"
WriteAttributeValue("", 2937, item !=null ? item.TotalDeduction : 0, 2937, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"TotalDeduction\" class=\"form-control\" />    </td>\r\n                <td><input type=\"number\" id=\"Additions\"");
            BeginWriteAttribute("value", " value=\"", 3090, "\"", 3133, 1);
#nullable restore
#line 57 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SalaryPayablesPerMonth\_list.cshtml"
WriteAttributeValue("", 3098, item !=null ? item.Additions : 0, 3098, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"Additions\" class=\"form-control\" />    </td>\r\n\r\n                <td><input type=\"text\" id=\"SalaryMonth\"");
            BeginWriteAttribute("value", " value=\"", 3243, "\"", 3288, 1);
#nullable restore
#line 59 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SalaryPayablesPerMonth\_list.cshtml"
WriteAttributeValue("", 3251, item !=null ? item.SalaryMonth : 0, 3251, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" readonly name=\"SalaryMonth\" class=\"form-control\" />     </td>\r\n                <td><input type=\"text\" id=\"SalaryYear\"");
            BeginWriteAttribute("value", " value=\"", 3407, "\"", 3451, 1);
#nullable restore
#line 60 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SalaryPayablesPerMonth\_list.cshtml"
WriteAttributeValue("", 3415, item !=null ? item.SalaryYear : 0, 3415, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" readonly name=\"SalaryYear\" class=\"form-control\" />    </td>\r\n                <td><input type=\"text\" id=\"SalaryDate\"");
            BeginWriteAttribute("value", " value=\"", 3568, "\"", 3623, 1);
#nullable restore
#line 61 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SalaryPayablesPerMonth\_list.cshtml"
WriteAttributeValue("", 3576, item !=null ? item.SalaryDate : DateTime.Now, 3576, 47, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" readonly name=\"SalaryDate\" class=\"form-control\" />    </td>\r\n\r\n\r\n            </tr>\r\n");
#nullable restore
#line 65 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SalaryPayablesPerMonth\_list.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n\r\n\r\n<script>\r\n    $(function () {\r\n\r\n        _initDatatable(\'#dtList\');\r\n        initDatePicker();\r\n        $(\'#dtList\').show();\r\n    });\r\n    var applicationName = getApplicationName();\r\n\r\n   \r\n\r\n</script>\r\n");
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