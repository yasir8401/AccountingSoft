#pragma checksum "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Banks\PrintList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "721f6ae219474911af44b37d70ae2bc3a6867f9b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Finance_Views_Banks_PrintList), @"mvc.1.0.view", @"/Areas/Finance/Views/Banks/PrintList.cshtml")]
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
#line 1 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Banks\PrintList.cshtml"
using ErpOnClick.DAL.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"721f6ae219474911af44b37d70ae2bc3a6867f9b", @"/Areas/Finance/Views/Banks/PrintList.cshtml")]
    public class Areas_Finance_Views_Banks_PrintList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Banks\PrintList.cshtml"
  
    Layout = "_LayoutReport";
    List<Customers> Customers = Model.CustomerIdList;
    Company CompanyDetail = Model.CompanyDetail;

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
                        CUSTOMERS
                    </h2>
                    <br>

                    <table cellspacing=""0"" cellpadding=""5"" rules=""all"" border=""0"" id=""DataGrid1"" style=""width: 100%;  "" class=""tblDetail"">
                        <thead>


                        </thead>
                        <tbody>
                            <tr class=""Grid_HeaderStyle text-center"">
                                <td width=""50%""><i class=""fa fa-filter""></i>Account </td>
                                <td width=""50%""><i class=""fa fa-filter""></i>Status </td>
                            </tr>

                            <tr class=""ItemColor text-center"">

                   ");
            WriteLiteral("             <td width=\"50%\"");
            BeginWriteAttribute("nowrap", " nowrap=\"", 1225, "\"", 1234, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    ");
#nullable restore
#line 34 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Banks\PrintList.cshtml"
                               Write(Model.AccountId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td width=\"50%\">\r\n");
#nullable restore
#line 37 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Banks\PrintList.cshtml"
                                     if (Model.Status == "015001")
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <i> Active</i> \r\n");
#nullable restore
#line 40 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Banks\PrintList.cshtml"
                                }
                                 else if (Model.Status == "015002")
                                  {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <i> InActive</i>\r\n");
#nullable restore
#line 44 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Banks\PrintList.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </td>
                            </tr>
                        </tbody>
                    </table>
                    <br>
                    <br />


                    <table cellspacing=""0"" cellpadding=""5"" rules=""all"" border=""0"" id=""DataGrid1"" style=""width: 100%;  "" class=""tblDetail"">
                        <thead>
");
            WriteLiteral(@"                            <tr class=""Grid_HeaderStyle"">
                                <th style=""width:20px"">Customer Id</th>

                                <th>Name EN</th>
                                <th>Name AR</th>
                                <th>Account</th>
                                <th>Mobile #</th>
                                <th>Email</th>
                                <th>Active Status</th>

                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 78 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Banks\PrintList.cshtml"
                             if (Customers.Count() > 0)
                            {
                                foreach (var item in Customers)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"ItemColor text-center\">\r\n                    <td class=\"text-center\">");
#nullable restore
#line 83 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Banks\PrintList.cshtml"
                                       Write(item.CustomerId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"text-center\">");
#nullable restore
#line 84 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Banks\PrintList.cshtml"
                                       Write(item.CustomerNameEn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"text-center\">");
#nullable restore
#line 85 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Banks\PrintList.cshtml"
                                       Write(item.CustomerNameAr);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    <td class=\"text-center\">");
#nullable restore
#line 87 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Banks\PrintList.cshtml"
                                       Write(item.Account.AccountNameEn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"text-center\">");
#nullable restore
#line 88 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Banks\PrintList.cshtml"
                                       Write(item.MobileNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"text-center\">");
#nullable restore
#line 89 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Banks\PrintList.cshtml"
                                       Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"text-center\">\r\n");
#nullable restore
#line 91 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Banks\PrintList.cshtml"
                         if (item.ActiveStatus == "015001")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <i>Active</i> ");
#nullable restore
#line 93 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Banks\PrintList.cshtml"
                              }
                                    else if (item.ActiveStatus == "015002")
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <i>InActive</i>");
#nullable restore
#line 96 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Banks\PrintList.cshtml"
                               }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                </tr> ");
#nullable restore
#line 98 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Banks\PrintList.cshtml"
                      }
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"ItemColor text-center\">\r\n                    <td colspan=\"7\" class=\"text-center\">Sorry! No Data Found.</td>\r\n                </tr>");
#nullable restore
#line 104 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Banks\PrintList.cshtml"
                     }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </tbody>
                    </table>
                    <br>
                    <br><br>
                    <hr style=""border: 1px solid whitesmoke; margin-bottom:5px;"">
                </td>
            </tr>
        </tbody>
    </table>

</div>");
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