#pragma checksum "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Notes\_generalModalPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7432f927bc5e1d7271d943595083a7eeb07ad616"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Finance_Views_Notes__generalModalPartial), @"mvc.1.0.view", @"/Areas/Finance/Views/Notes/_generalModalPartial.cshtml")]
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
#line 1 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Notes\_generalModalPartial.cshtml"
using ErpOnClick.DAL.Utilities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7432f927bc5e1d7271d943595083a7eeb07ad616", @"/Areas/Finance/Views/Notes/_generalModalPartial.cshtml")]
    public class Areas_Finance_Views_Notes__generalModalPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Notes\_generalModalPartial.cshtml"
  
    var filePath = NativePaths.GetFilePath(_env);
    var doc = "charts_of_accounts_xc.xlsx";
    var wwwRootPath = _HostEnvironment.WebRootPath;


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""modal fade"" id=""importdataModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""importdataModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-lg"" role=""document"" style=""max-width:500px"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title pull-left"" id=""importdataModalLabel"">Import Data</h5>
                <button type=""button"" class=""close pull-right"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
                <div class=""clearfix""></div>
            </div>

            <div class=""modal-body"" id=""formimportdiv"">
                <form id=""formimportN"" role=""form"">
                    <div class=""col-md-12"">
                        <div class=""modal-value"">
                        </div>
                        <div class=""row"" id=""hidefordetails"">
                            <div class=""col-sm-12"">
                      ");
            WriteLiteral(@"          <div class=""form-group"">
                                    <label>Upload File to Import Data for Notes.</label>
                                    <input style=""border:1px solid double !important"" type=""file"" id=""NoteFile"" name=""File"" class=""form-control"" required>
");
            WriteLiteral("                                    <a style=\"text-decoration:underline;font-size:12px;color: #84ceeb !important;\"");
            BeginWriteAttribute("href", " href=\"", 1985, "\"", 2005, 2);
#nullable restore
#line 34 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Notes\_generalModalPartial.cshtml"
WriteAttributeValue("", 1992, filePath, 1992, 9, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Notes\_generalModalPartial.cshtml"
WriteAttributeValue("", 2001, doc, 2001, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("download", " download=\"", 2006, "\"", 2017, 0);
            EndWriteAttribute();
            WriteLiteral(@">Download Excel File for NOTES. </a>

                                </div>
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-md-12"">
                                <button type=""submit"" id=""formsubmit""  class=""btn  btn-sm btn-primary"">
                                    <i class=""fal fa-paperclip fa-fw""></i> Upload Now
                                </button>
                            </div>
                        </div>
                    </div>
                </form>
            </div>
        </div>
    </div>
</div>

");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Hosting.IWebHostEnvironment _HostEnvironment { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Hosting.IHostingEnvironment _env { get; private set; }
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
