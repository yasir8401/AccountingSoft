#pragma checksum "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Views\Shared\_LayoutReport.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03c944594427775e85b3bd6d3693d83ae98669c6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__LayoutReport), @"mvc.1.0.view", @"/Views/Shared/_LayoutReport.cshtml")]
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
#line 1 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Views\_ViewImports.cshtml"
using ErpOnClick.ErpMain;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Views\_ViewImports.cshtml"
using ErpOnClick.ErpMain.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Views\Shared\_LayoutReport.cshtml"
using ErpOnClick.DAL.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03c944594427775e85b3bd6d3693d83ae98669c6", @"/Views/Shared/_LayoutReport.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a52f8120c10a7cae26c552afa865fcb7fc4d996b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__LayoutReport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("body"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!doctype html>\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Views\Shared\_LayoutReport.cshtml"
  
    Company CompanyDetail = Model.CompanyDetail;


#line default
#line hidden
#nullable disable
            WriteLiteral("<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "03c944594427775e85b3bd6d3693d83ae98669c64214", async() => {
                WriteLiteral(@"
    <title>Report</title>
    <meta name=""GENERATOR"" content=""Microsoft Visual Studio .NET 7.1"">
    <meta name=""CODE_LANGUAGE"" content=""Visual Basic .NET 7.1"">
    <meta name=""vs_defaultClientScript"" content=""JavaScript"">
    <meta name=""vs_targetSchema"" content=""http://schemas.microsoft.com/intellisense/ie5"">


    <link");
                BeginWriteAttribute("href", " href=\"", 455, "\"", 526, 2);
#nullable restore
#line 17 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Views\Shared\_LayoutReport.cshtml"
WriteAttributeValue("", 462, Url.Content("~/"), 462, 18, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 480, "adminlte/plugins/summernote/summernote-bs4.css", 480, 46, true);
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\" />\r\n    <link");
                BeginWriteAttribute("href", " href=\"", 558, "\"", 625, 2);
#nullable restore
#line 18 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Views\Shared\_LayoutReport.cshtml"
WriteAttributeValue("", 565, Url.Content("~/"), 565, 18, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 583, "adminlte/plugins/summernote/summernote.css", 583, 42, true);
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\" />\r\n    <link");
                BeginWriteAttribute("href", " href=\"", 657, "\"", 722, 2);
#nullable restore
#line 19 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Views\Shared\_LayoutReport.cshtml"
WriteAttributeValue("", 664, Url.Content("~/"), 664, 18, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 682, "adminlte/plugins/fontawesome/css/all.css", 682, 40, true);
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\" />\r\n    <link");
                BeginWriteAttribute("href", " href=\"", 754, "\"", 793, 2);
#nullable restore
#line 20 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Views\Shared\_LayoutReport.cshtml"
WriteAttributeValue("", 761, Url.Content("~/"), 761, 18, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 779, "css/Report.css", 779, 14, true);
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\" />\r\n    <link");
                BeginWriteAttribute("href", " href=\"", 825, "\"", 890, 2);
#nullable restore
#line 21 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Views\Shared\_LayoutReport.cshtml"
WriteAttributeValue("", 832, Url.Content("~/"), 832, 18, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 850, "adminlte/plugins/fontawesome/css/all.css", 850, 40, true);
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\" />\r\n\r\n    <link");
                BeginWriteAttribute("href", " href=\"", 924, "\"", 997, 2);
#nullable restore
#line 23 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Views\Shared\_LayoutReport.cshtml"
WriteAttributeValue("", 931, Url.Content("~/"), 931, 18, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 949, "adminlte/plugins/fontawesome/css/fontawesome.css", 949, 48, true);
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\" />\r\n    <style type=\"text/css\" media=\"print\">\r\n\r\n        ");
                WriteLiteral(@"@page {
            size: letter;
            margin: 5mm 5mm 10mm 5mm; /* this affects the margin in the printer settings */
        }

        #divParams {
            display: none;
        }
    </style>

    <style>
        #divParams {
            width: 200px;
            position: absolute;
            top: 10px;
            left: 10px;
            background-color: #47739f;
            padding: 15px 25px 15px 15px;
            border-radius: 5px;
            border: 2px solid #47739f;
            color: white;
            font-family: monospace;
            font-size: 15px;
        }

            #divParams input {
                width: 100%;
                margin-top: 5px;
                margin-bottom: 10px;
                border: 0px solid silver;
                padding: 5px 5px 5px 5px;
            }
    </style>

");
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "03c944594427775e85b3bd6d3693d83ae98669c69782", async() => {
                WriteLiteral(@"


    <table id=""Outline"" style=""height: 100%; z-index: 101; left: 8px; top: 8px; border-collapse: collapse"" bordercolor=""silver"" cellspacing=""0"" cellpadding=""10"" width=""100%"" align=""center"">
        <tbody>
            <tr valign=""top"">
                <td width=""100%"" valign=""top"">



                    <div class=""divHeader"" style=""position:initial !important"">
                        <div class=""actionBar"">
                            <input class=""btnPrint"" onclick=""CallPrint()"" type=""button"" value=""Print"">
                            <input class=""btnPrint"" onclick=""window.close();"" type=""button"" value=""Close"" style=""float:right"">
                            <div style=""clear: both;""></div>
                        </div>

                        <table id=""Outline1"" style=""border-collapse: collapse"" bordercolor=""silver"" cellspacing=""0"" cellpadding=""3"" width=""100%"" border=""0"">
                            <tbody>
                                <tr valign=""top"">
                     ");
                WriteLiteral(@"               <td valign=""top"" width=""100%"" style=""text-align:center"">
                                        <br>
                                        <table width=""100%"">
                                            <tbody>
                                                <tr>
                                                    <td style=""text-align:left; line-height:1"" width=""45%"">
                                                        ");
#nullable restore
#line 89 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Views\Shared\_LayoutReport.cshtml"
                                                    Write(CompanyDetail != null && CompanyDetail.CoNameEn != null ? CompanyDetail.CoNameEn : "");

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                                                        <small>\r\n                                                            <br>\r\n                                                            <b>Adress:</b> ");
#nullable restore
#line 93 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Views\Shared\_LayoutReport.cshtml"
                                                                       Write(CompanyDetail != null && CompanyDetail.CoAddressEn != null ? CompanyDetail.CoAddressEn : "");

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                            <br>\r\n                                                            <b>Email:</b> ");
#nullable restore
#line 95 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Views\Shared\_LayoutReport.cshtml"
                                                                      Write(CompanyDetail != null && CompanyDetail.CoEmail != null ? CompanyDetail.CoEmail : "");

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                            <br>\r\n                                                            <b>Phone: </b> ");
#nullable restore
#line 97 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Views\Shared\_LayoutReport.cshtml"
                                                                       Write(CompanyDetail != null && CompanyDetail.CoPhone != null ? CompanyDetail.CoPhone : "");

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                            <br>\r\n                                                            <b>CR No: </b> ");
#nullable restore
#line 99 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Views\Shared\_LayoutReport.cshtml"
                                                                       Write(CompanyDetail != null && CompanyDetail.CrNo != null ? CompanyDetail.CrNo : "");

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                                        </small>
                                                    </td>
                                                    <td style=""text-align:center; "" width=""10%"">
                                                        <img style=""-webkit-user-select: none""");
                BeginWriteAttribute("src", " src=\"", 4937, "\"", 4993, 2);
#nullable restore
#line 103 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Views\Shared\_LayoutReport.cshtml"
WriteAttributeValue("", 4943, Url.Content("~/"), 4943, 18, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 4961, "adminlte/dist/img/Erponclick.png", 4961, 32, true);
                EndWriteAttribute();
                WriteLiteral(" width=\"100%\" />\r\n");
                WriteLiteral(@"                                                        <div class=""clearfix""></div>
                                                    </td>
                                                    <td style=""text-align:right;font-family: tahoma;line-height: 1;"" id=""tdPrint"" width=""45%"">


                                                        <div dir=""rtl"">
                                                            <span style=""letter-spacing:1px"">
                                                                ");
#nullable restore
#line 112 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Views\Shared\_LayoutReport.cshtml"
                                                            Write(CompanyDetail != null && CompanyDetail.CoNameAr != null ? CompanyDetail.CoNameAr : "");

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                                            </span>
                                                            <small>
                                                                <br>
                                                                <b>العنوان:</b>
                                                                ");
#nullable restore
#line 117 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Views\Shared\_LayoutReport.cshtml"
                                                            Write(CompanyDetail != null && CompanyDetail.CoAddressAr != null ? CompanyDetail.CoAddressAr : "");

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                                <br>\r\n                                                                <b>البريد الإلكتروني:</b> ");
#nullable restore
#line 119 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Views\Shared\_LayoutReport.cshtml"
                                                                                      Write(CompanyDetail != null && CompanyDetail.CoEmail != null ? CompanyDetail.CoEmail : "");

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                                <br>\r\n                                                                <b>هاتف: </b><span dir=\"ltr\"> ");
#nullable restore
#line 121 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Views\Shared\_LayoutReport.cshtml"
                                                                                          Write(CompanyDetail != null && CompanyDetail.CoPhone != null ? CompanyDetail.CoPhone : "");

#line default
#line hidden
#nullable disable
                WriteLiteral(" </span>\r\n                                                                <br>\r\n                                                                <b>رقم تسجيل الشركة: </b> ");
#nullable restore
#line 123 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Views\Shared\_LayoutReport.cshtml"
                                                                                      Write(CompanyDetail != null && CompanyDetail.CrNo != null ? CompanyDetail.CrNo : "");

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                                            </small>
                                                        </div>
                                                        <div style=""display:none"" width=""200px"">

                                                        </div>
                                                    </td>

                                                </tr>
                                            </tbody>
                                        </table>
                                        <hr style=""border: 2px solid #0a1e60; margin-bottom:0px;"">
                                    </td>
                                </tr>
                            </tbody>
                        </table>


");
                WriteLiteral("\r\n\r\n                    </div>\r\n\r\n                    <div class=\"divData\" style=\"margin-top:0% !important\">\r\n                        ");
#nullable restore
#line 185 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Views\Shared\_LayoutReport.cshtml"
                   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n\r\n\r\n\r\n                </td>\r\n            </tr>\r\n        </tbody>\r\n    </table>\r\n\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 10401, "\"", 10462, 2);
#nullable restore
#line 195 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Views\Shared\_LayoutReport.cshtml"
WriteAttributeValue("", 10407, Url.Content("~/"), 10407, 18, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 10425, "adminlte/plugins/jquery/jquery.min.js", 10425, 37, true);
                EndWriteAttribute();
                WriteLiteral("></script>\r\n");
                WriteLiteral("    <script type=\"text/javascript\">\r\n\r\n        function CallPrint() {\r\n            window.print();\r\n\r\n        }\r\n\r\n    </script>\r\n    ");
#nullable restore
#line 205 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Views\Shared\_LayoutReport.cshtml"
Write(RenderSection("script", false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
