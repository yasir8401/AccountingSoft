#pragma checksum "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\PrintList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a2531523c2222e72e1515fa5c3f181e767a63f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_HumanResource_Views_Emp_PrintList), @"mvc.1.0.view", @"/Areas/HumanResource/Views/Emp/PrintList.cshtml")]
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
#line 1 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\PrintList.cshtml"
using ErpOnClick.DAL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\PrintList.cshtml"
using ErpOnClick.ErpMain.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a2531523c2222e72e1515fa5c3f181e767a63f4", @"/Areas/HumanResource/Views/Emp/PrintList.cshtml")]
    public class Areas_HumanResource_Views_Emp_PrintList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\PrintList.cshtml"
  
    Layout = "_LayoutReport";

    bool empSalaryCheck = Model.empSalaryCheck;
    List<ReportModel> empListReport = Model.empListReport;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div>
    <br />

    <table id=""Outline1"" style=""border-collapse: collapse"" bordercolor=""silver"" cellspacing=""0"" cellpadding=""3"" width=""100%"" border=""0"">
        <tbody>
            <tr>
                <td>
                    <h2 class=""ReportTitle text-center"" style=""font-size: 25px ; margin:0px;  "">
                        Employees ");
#nullable restore
#line 18 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\PrintList.cshtml"
                              Write(empSalaryCheck ? "Salary":"List");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </h2>\r\n                    <br>\r\n\r\n\r\n                    <br>\r\n                    <br />\r\n");
#nullable restore
#line 25 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\PrintList.cshtml"
                     if (empSalaryCheck)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <table cellspacing=""0"" cellpadding=""5"" rules=""all"" border=""0"" id=""DataGrid1"" style=""width: 100%;  "" class=""tblDetail"">
                            <thead>

                                <tr class=""Grid_HeaderStyle"">
                                    <th align=""left"">  Name</th>
                                    <th> Basic Salary </th>
                                    <th> Housing </th>
                                    <th> Transport  </th>
                                    <th> Food  </th>
                                    <th> Other  </th>
                                    <th>  Leave Pay </th>
                                    <th>  Indemnity </th>



                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 45 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\PrintList.cshtml"
                                 foreach (var item in empListReport)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr class=\"ItemColor text-center\">\r\n\r\n                                        <td align=\"left\">");
#nullable restore
#line 49 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\PrintList.cshtml"
                                                    Write(item.EmpName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                        <td align=\"right\">\r\n                                            ");
#nullable restore
#line 51 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\PrintList.cshtml"
                                        Write(String.Format("{0:.00}", item.BasicSalray));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td align=\"right\">\r\n                                            ");
#nullable restore
#line 54 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\PrintList.cshtml"
                                        Write(String.Format("{0:.00}", item.Housing));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td align=\"right\"> ");
#nullable restore
#line 56 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\PrintList.cshtml"
                                                       Write(String.Format("{0:.00}", @item.Transport));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                        <td align=\"right\"> ");
#nullable restore
#line 57 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\PrintList.cshtml"
                                                       Write(String.Format("{0:.00}", @item.Food));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td align=\"right\"> ");
#nullable restore
#line 58 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\PrintList.cshtml"
                                                       Write(String.Format("{0:.00}", @item.Other));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                        <td align=\"right\"> ");
#nullable restore
#line 59 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\PrintList.cshtml"
                                                       Write(String.Format("{0:.00}", @item.LeavePay));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                        <td align=\"right\"> ");
#nullable restore
#line 60 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\PrintList.cshtml"
                                                       Write(String.Format("{0:.00}", @item.Indemnity));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n\r\n\r\n                                    </tr>\r\n");
#nullable restore
#line 64 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\PrintList.cshtml"

                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </tbody>
                            <tfoot>
                                <tr class=""Grid_HeaderStyle"">
                                    <th align=""left"">Total</th>
                                    <th align=""right"">");
#nullable restore
#line 70 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\PrintList.cshtml"
                                                  Write(String.Format("{0:.00}", empListReport.Sum(x => x.BasicSalray)));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                    <th align=\"right\">");
#nullable restore
#line 71 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\PrintList.cshtml"
                                                  Write(String.Format("{0:.00}", empListReport.Sum(x => x.Housing)));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                    <th align=\"right\">");
#nullable restore
#line 72 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\PrintList.cshtml"
                                                  Write(String.Format("{0:.00}", empListReport.Sum(x => x.Transport)));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                    <th align=\"right\">");
#nullable restore
#line 73 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\PrintList.cshtml"
                                                  Write(String.Format("{0:.00}", empListReport.Sum(x => x.Food)));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                    <th align=\"right\">");
#nullable restore
#line 74 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\PrintList.cshtml"
                                                  Write(String.Format("{0:.00}", @empListReport.Sum(x => x.Other)));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                    <th align=\"right\">");
#nullable restore
#line 75 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\PrintList.cshtml"
                                                  Write(String.Format("{0:.00}", @empListReport.Sum(x => x.LeavePay)));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                    <th align=\"right\">");
#nullable restore
#line 76 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\PrintList.cshtml"
                                                  Write(String.Format("{0:.00}", empListReport.Sum(x => x.Indemnity)));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                </tr>\r\n                            </tfoot>\r\n                        </table>\r\n");
#nullable restore
#line 80 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\PrintList.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <table cellspacing=""0"" cellpadding=""5"" rules=""all"" border=""0"" id=""DataGrid1"" style=""width: 100%;  "" class=""tblDetail"">
                            <thead>

                                <tr class=""Grid_HeaderStyle"">
                                    <th align=""left"">  Name</th>
");
            WriteLiteral(@"                                    <th>Divison</th>
                                    <th> Department </th>
                                    <th> Section </th>
                                    <th> Sub Section </th>
                                    <th> Unit </th>
                                    <th> Team </th>
                                    <th> Company </th>
                                    <th> Branch </th>
                                    <th> Salaray </th>


                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 103 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\PrintList.cshtml"
                                 foreach (var item in empListReport)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr class=\"ItemColor text-center\">\r\n\r\n                                        <td align=\"left\">");
#nullable restore
#line 107 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\PrintList.cshtml"
                                                    Write(item.EmpName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n\r\n");
            WriteLiteral("                                        <td>");
#nullable restore
#line 110 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\PrintList.cshtml"
                                       Write(item.EmpDivison);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                        <td>");
#nullable restore
#line 111 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\PrintList.cshtml"
                                       Write(item.EmpDepartment);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                        <td>");
#nullable restore
#line 112 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\PrintList.cshtml"
                                       Write(item.EmpSection);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                        <td>");
#nullable restore
#line 113 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\PrintList.cshtml"
                                       Write(item.EmpSubSection);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                        <td>");
#nullable restore
#line 114 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\PrintList.cshtml"
                                       Write(item.EmpUnit);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                        <td>");
#nullable restore
#line 115 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\PrintList.cshtml"
                                       Write(item.EmpTeam);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                        <td>");
#nullable restore
#line 116 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\PrintList.cshtml"
                                       Write(item.EmpCompany);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                        <td>");
#nullable restore
#line 117 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\PrintList.cshtml"
                                       Write(item.EmpBranch);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                        <td align=\"right\">");
#nullable restore
#line 118 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\PrintList.cshtml"
                                                      Write(String.Format("{0:.00}",(item.BasicSalray + item.Housing + item.Transport + item.Food + item.Other + item.LeavePay + item.Indemnity)));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    </tr>\r\n");
#nullable restore
#line 120 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\PrintList.cshtml"

                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tbody>\r\n\r\n                        </table>\r\n");
#nullable restore
#line 125 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\PrintList.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <br>\r\n                    <br><br>\r\n                    <hr style=\"border: 1px solid whitesmoke; margin-bottom:5px;\">\r\n                </td>\r\n            </tr>\r\n        </tbody>\r\n    </table>\r\n\r\n</div>\r\n\r\n");
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
