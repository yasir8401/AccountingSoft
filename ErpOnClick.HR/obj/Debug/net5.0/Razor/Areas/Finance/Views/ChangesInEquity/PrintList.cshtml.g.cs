#pragma checksum "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\ChangesInEquity\PrintList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fcd7709a7311a3aeff12b2f07da5b4c21b3e6e1f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Finance_Views_ChangesInEquity_PrintList), @"mvc.1.0.view", @"/Areas/Finance/Views/ChangesInEquity/PrintList.cshtml")]
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
#line 1 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\ChangesInEquity\PrintList.cshtml"
using ErpOnClick.DAL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\ChangesInEquity\PrintList.cshtml"
using ErpOnClick.ErpMain.Models.Finance;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fcd7709a7311a3aeff12b2f07da5b4c21b3e6e1f", @"/Areas/Finance/Views/ChangesInEquity/PrintList.cshtml")]
    public class Areas_Finance_Views_ChangesInEquity_PrintList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\ChangesInEquity\PrintList.cshtml"
  
    Layout = "_LayoutReport";
    ChangesInEquityViewModel changesInEquityViewModel = Model.changesInEquityViewModel;

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
                        STATEMENT OF OTHER COMPREHENSIVE INCOME
                    </h2>
                    <br>
                    <div class=""table-responsive pb-2 "">
                        <table id=""pltable"" class=""table table-hover table-condensed "">
                            <thead class=""text-sm "">
                                <tr class=""col-lg-12 text-center Grid_HeaderStyle"">
                                    <th width=""60%"" class="" text-center-vertical""> Particulars </th>
                                    <th width=""8%"" class="" text-center-vertical"" colspan=""2""> Issued, subscribed and paid up share capital </th>
                                    <th width=""8%"" class");
            WriteLiteral(@"="" text-center-vertical"" colspan=""2""> Share Premium </th>
                                    <th width=""8%"" class="" text-center-vertical"" colspan=""2""> Reserve </th>
                                    <th width=""8%"" class="" text-center-vertical"" colspan=""2""> Unappropriated profit / (loss) </th>
                                    <th width=""8%"" class="" text-center-vertical"" colspan=""2""> Total Equity </th>
                                </tr>
                                <tr class=""col-lg-12 text-center Grid_HeaderStyle"">
                                    <th width=""60%""");
            BeginWriteAttribute("class", " class=\"", 1866, "\"", 1874, 0);
            EndWriteAttribute();
            WriteLiteral("> </th>\r\n                                    <th");
            BeginWriteAttribute("class", " class=\"", 1923, "\"", 1931, 0);
            EndWriteAttribute();
            WriteLiteral(" width=\"4%\"> 2021 </th>\r\n                                    <th");
            BeginWriteAttribute("class", " class=\"", 1996, "\"", 2004, 0);
            EndWriteAttribute();
            WriteLiteral(" width=\"4%\"> 2020 </th>\r\n                                    <th");
            BeginWriteAttribute("class", " class=\"", 2069, "\"", 2077, 0);
            EndWriteAttribute();
            WriteLiteral(" width=\"4%\"> 2021 </th>\r\n                                    <th");
            BeginWriteAttribute("class", " class=\"", 2142, "\"", 2150, 0);
            EndWriteAttribute();
            WriteLiteral(" width=\"4%\"> 2020 </th>\r\n                                    <th");
            BeginWriteAttribute("class", " class=\"", 2215, "\"", 2223, 0);
            EndWriteAttribute();
            WriteLiteral(" width=\"4%\"> 2021 </th>\r\n                                    <th");
            BeginWriteAttribute("class", " class=\"", 2288, "\"", 2296, 0);
            EndWriteAttribute();
            WriteLiteral(" width=\"4%\"> 2020 </th>\r\n                                    <th");
            BeginWriteAttribute("class", " class=\"", 2361, "\"", 2369, 0);
            EndWriteAttribute();
            WriteLiteral(" width=\"4%\"> 2021 </th>\r\n                                    <th");
            BeginWriteAttribute("class", " class=\"", 2434, "\"", 2442, 0);
            EndWriteAttribute();
            WriteLiteral(" width=\"4%\"> 2020 </th>\r\n                                    <th");
            BeginWriteAttribute("class", " class=\"", 2507, "\"", 2515, 0);
            EndWriteAttribute();
            WriteLiteral(" width=\"4%\"> 2021 </th>\r\n                                    <th");
            BeginWriteAttribute("class", " class=\"", 2580, "\"", 2588, 0);
            EndWriteAttribute();
            WriteLiteral(" width=\"4%\"> 2020 </th>\r\n                                </tr>\r\n                                <tr class=\"col-lg-12 text-center Grid_HeaderStyle\">\r\n                                    <th width=\"60%\"");
            BeginWriteAttribute("class", " class=\"", 2789, "\"", 2797, 0);
            EndWriteAttribute();
            WriteLiteral("> </th>\r\n                                    <th width=\"40%\"");
            BeginWriteAttribute("class", " class=\"", 2858, "\"", 2866, 0);
            EndWriteAttribute();
            WriteLiteral(@" colspan=""10""> --Rupees-- </th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <td class=""text-left""></td>
                                    <td> </td>
                                    <td> </td>
                                    <td> </td>
                                    <td> </td>
                                    <td> </td>
                                    <td> </td>
                                    <td> </td>
                                    <td> </td>
                                    <td> </td>
                                    <td> </td>
                                </tr>
                                <tr>
                                    <td class=""text-left""> Balance as at 1 June </td>
                                    <td class=""text-center""> ");
#nullable restore
#line 67 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\ChangesInEquity\PrintList.cshtml"
                                                        Write(changesInEquityViewModel.R_2021);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                    <td class=\"text-center\"> ");
#nullable restore
#line 68 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\ChangesInEquity\PrintList.cshtml"
                                                        Write(changesInEquityViewModel.R_2020);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                    <td class=\"text-center\"> ");
#nullable restore
#line 69 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\ChangesInEquity\PrintList.cshtml"
                                                        Write(changesInEquityViewModel.SP_2021);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                    <td class=\"text-center\"> ");
#nullable restore
#line 70 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\ChangesInEquity\PrintList.cshtml"
                                                        Write(changesInEquityViewModel.SP_2020);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                    <td class=\"text-center\"> ");
#nullable restore
#line 71 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\ChangesInEquity\PrintList.cshtml"
                                                        Write(changesInEquityViewModel.R_2021);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                    <td class=\"text-center\"> ");
#nullable restore
#line 72 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\ChangesInEquity\PrintList.cshtml"
                                                        Write(changesInEquityViewModel.R_2020);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                    <td class=\"text-center\"> - </td>\r\n                                    <td class=\"text-center\"> - </td>\r\n                                    <td class=\"text-center\"> ");
#nullable restore
#line 75 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\ChangesInEquity\PrintList.cshtml"
                                                         Write(changesInEquityViewModel.R_2021 + changesInEquityViewModel.SP_2021 + changesInEquityViewModel.R_2021);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                    <td class=\"text-center\"> ");
#nullable restore
#line 76 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\ChangesInEquity\PrintList.cshtml"
                                                         Write(changesInEquityViewModel.R_2020 + changesInEquityViewModel.SP_2020 + changesInEquityViewModel.R_2020);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </td>
                                </tr>
                                <tr>
                                    <td class=""text-left""></td>
                                    <td> </td>
                                    <td> </td>
                                    <td> </td>
                                    <td> </td>
                                    <td> </td>
                                    <td> </td>
                                    <td> </td>
                                    <td> </td>
                                    <td> </td>
                                    <td> </td>
                                </tr>
                                <tr>
                                    <td class=""text-left""></td>
                                    <td> </td>
                                    <td> </td>
                                    <td> </td>
                                    <td> </td>
                                    <td> </td>
            ");
            WriteLiteral(@"                        <td> </td>
                                    <td> </td>
                                    <td> </td>
                                    <td> </td>
                                    <td> </td>
                                </tr>
                                <tr>
                                    <td class=""text-left""> Profit / (loss) Before Taxation for the Period </td>
                                    <td class=""text-center""> - </td>
                                    <td class=""text-center""> - </td>
                                    <td class=""text-center""> - </td>
                                    <td class=""text-center""> - </td>
                                    <td class=""text-center""> - </td>
                                    <td class=""text-center""> - </td>
                                    <td class=""text-center""> ");
#nullable restore
#line 112 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\ChangesInEquity\PrintList.cshtml"
                                                        Write(changesInEquityViewModel.PLAT_2021);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                    <td class=\"text-center\"> ");
#nullable restore
#line 113 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\ChangesInEquity\PrintList.cshtml"
                                                        Write(changesInEquityViewModel.PLAT_2020);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                    <td class=\"text-center\"> ");
#nullable restore
#line 114 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\ChangesInEquity\PrintList.cshtml"
                                                        Write(changesInEquityViewModel.PLAT_2021);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                    <td class=\"text-center\"> ");
#nullable restore
#line 115 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\ChangesInEquity\PrintList.cshtml"
                                                        Write(changesInEquityViewModel.PLAT_2020);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </td>
                                </tr>
                                <tr>
                                    <td class=""text-left""></td>
                                    <td> </td>
                                    <td> </td>
                                    <td> </td>
                                    <td> </td>
                                    <td> </td>
                                    <td> </td>
                                    <td> </td>
                                    <td> </td>
                                    <td> </td>
                                    <td> </td>
                                </tr>
                                <tr>
                                    <td class=""text-left""></td>
                                    <td> </td>
                                    <td> </td>
                                    <td> </td>
                                    <td> </td>
                                    <td> </td>
            ");
            WriteLiteral(@"                        <td> </td>
                                    <td> </td>
                                    <td> </td>
                                    <td> </td>
                                    <td> </td>
                                </tr>
                                <tr>
                                    <td class=""text-left""> Other Comprehensive Income for the Period </td>
                                    <td class=""text-center""> - </td>
                                    <td class=""text-center""> - </td>
                                    <td class=""text-center""> - </td>
                                    <td class=""text-center""> - </td>
                                    <td class=""text-center""> - </td>
                                    <td class=""text-center""> - </td>
                                    <td class=""text-center""> ");
#nullable restore
#line 151 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\ChangesInEquity\PrintList.cshtml"
                                                        Write(changesInEquityViewModel.OCI_2021);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                    <td class=\"text-center\"> ");
#nullable restore
#line 152 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\ChangesInEquity\PrintList.cshtml"
                                                        Write(changesInEquityViewModel.OCI_2020);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                    <td class=\"text-center\"> ");
#nullable restore
#line 153 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\ChangesInEquity\PrintList.cshtml"
                                                        Write(changesInEquityViewModel.OCI_2021);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                    <td class=\"text-center\"> ");
#nullable restore
#line 154 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\ChangesInEquity\PrintList.cshtml"
                                                        Write(changesInEquityViewModel.OCI_2020);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </td>
                                </tr>
                                <tr>
                                    <td class=""text-left""></td>
                                    <td> </td>
                                    <td> </td>
                                    <td> </td>
                                    <td> </td>
                                    <td> </td>
                                    <td> </td>
                                    <td> </td>
                                    <td> </td>
                                    <td> </td>
                                    <td> </td>
                                </tr>
                                <tr>
                                    <td class=""text-left""></td>
                                    <td> </td>
                                    <td> </td>
                                    <td> </td>
                                    <td> </td>
                                    <td> </td>
            ");
            WriteLiteral(@"                        <td> </td>
                                    <td> </td>
                                    <td> </td>
                                    <td> </td>
                                    <td> </td>
                                </tr>
                                <tr>
                                    <td class=""text-left""> Balance as at 30 June </td>
                                    <td class=""text-center b-t b-b b-lr""> - </td>
                                    <td class=""text-center b-t b-b b-lr""> - </td>
                                    <td class=""text-center b-t b-b b-lr""> - </td>
                                    <td class=""text-center b-t b-b b-lr""> - </td>
                                    <td class=""text-center b-t b-b b-lr""> - </td>
                                    <td class=""text-center b-t b-b b-lr""> - </td>
                                    <td class=""text-center b-t b-b b-lr""> ");
#nullable restore
#line 190 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\ChangesInEquity\PrintList.cshtml"
                                                                      Write(changesInEquityViewModel.PLAT_2021  + changesInEquityViewModel.OCI_2021);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                    <td class=\"text-center b-t b-b b-lr\"> ");
#nullable restore
#line 191 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\ChangesInEquity\PrintList.cshtml"
                                                                      Write(changesInEquityViewModel.PLAT_2020  + changesInEquityViewModel.OCI_2020);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                    <td class=\"text-center b-t b-b b-lr\"> ");
#nullable restore
#line 192 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\ChangesInEquity\PrintList.cshtml"
                                                                      Write(changesInEquityViewModel.PLAT_2021  + changesInEquityViewModel.OCI_2021);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                    <td class=\"text-center b-t b-b b-lr\"> ");
#nullable restore
#line 193 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\ChangesInEquity\PrintList.cshtml"
                                                                      Write(changesInEquityViewModel.PLAT_2020  + changesInEquityViewModel.OCI_2020);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </td>
                                </tr>
                                <tr>
                                    <td class=""text-left""></td>
                                    <td> </td>
                                    <td> </td>
                                    <td> </td>
                                    <td> </td>
                                    <td> </td>
                                    <td> </td>
                                    <td> </td>
                                    <td> </td>
                                    <td> </td>
                                    <td> </td>
                                </tr>
                                <tr>
                                    <td class=""text-left""></td>
                                    <td> </td>
                                    <td> </td>
                                    <td> </td>
                                    <td> </td>
                                    <td> </td>
            ");
            WriteLiteral(@"                        <td> </td>
                                    <td> </td>
                                    <td> </td>
                                    <td> </td>
                                    <td> </td>
                                </tr>
                                <tr class=""signatrure-table"">
                                    <td colspan=""5"" class=""signatrure-section""><span>Chief Executive Officer</span></td>
                                    <td></td>
                                    <td colspan=""5"" class=""signatrure-section""><span>Director</span></td>
                                </tr>
                            </tbody>
                        </table>
                    </div>

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
