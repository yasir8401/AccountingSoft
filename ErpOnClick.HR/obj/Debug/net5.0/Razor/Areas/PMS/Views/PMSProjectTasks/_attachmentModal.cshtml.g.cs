#pragma checksum "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\PMS\Views\PMSProjectTasks\_attachmentModal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ad1bfe5f3e9532a9612291bac3dc4d85ed06a96"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_PMS_Views_PMSProjectTasks__attachmentModal), @"mvc.1.0.view", @"/Areas/PMS/Views/PMSProjectTasks/_attachmentModal.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ad1bfe5f3e9532a9612291bac3dc4d85ed06a96", @"/Areas/PMS/Views/PMSProjectTasks/_attachmentModal.cshtml")]
    public class Areas_PMS_Views_PMSProjectTasks__attachmentModal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""modal fade"" id=""_attachmentModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""_attachmentModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-xl"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title pull-left"" id=""_attachmentModalLabel"">Task Attachments</h5>
                <button type=""button"" class=""close pull-right"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
                <div class=""clearfix""></div>
            </div>

            <div class=""modal-body"" id=""formAttachmentdiv"">
                <form id=""formAttachment"" role=""form"">
                    <div class=""col-md-12"">
                        <div class=""modal-value"">
                            <input hidden id=""TaskId"" name=""TaskId"" />
                        </div>
                        <div class=""row"" id=""hidefordetails"">
              ");
            WriteLiteral(@"              <div class=""col-sm-4"">
                                <div class=""form-group"">
                                    <label>Upload File</label>
                                    <input style=""border:none !important"" type=""file"" id=""AttachmentFile"" name=""AttachmentFile"" class=""form-control"" required>
                                </div>
                            </div>
                            <div class=""col-sm-8"">
                                <div class=""form-group"">
                                    <label>File Name</label>
                                    <input type=""text"" id=""AttachmentName"" name=""AttachmentName"" class=""form-control"" required>
                                </div>
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-md-4"">
                                <button type=""submit"" id=""formsubmit"" class=""btn  btn-sm btn-primary"">
                    ");
            WriteLiteral(@"                <i class=""fa fa-paperclip fa-fw""></i> Upload Now
                                </button>
                            </div>
                            <div class=""col-md-8"">
                                <span style=""color: white;background-color: #8bd8bd;font-weight: 900;"" id=""submitresult""></span>
                            </div>
                        </div>
                    </div>
                </form>


                <div class=""row pt-3"" id=""dtrow"" style=""display:none"">
                    <div class=""col-md-12"">
                        <div class=""table-responsive pb-2"">
                            <table id=""dtList"" class=""table table-hover table-condensed "">
                                <thead>
                                    <tr>
                                        <th>Id</th>
                                        <th>Attachemnt Name</th>
                                        <th></th>
                                        <th></th>");
            WriteLiteral(@"
                                    </tr>
                                </thead>
                                <tbody>
                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

");
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