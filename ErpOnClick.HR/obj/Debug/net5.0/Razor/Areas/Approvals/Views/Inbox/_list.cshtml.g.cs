#pragma checksum "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Approvals\Views\Inbox\_list.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2c9c1e56ff51229a3c0eda9eb36fa2197ef05d9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Approvals_Views_Inbox__list), @"mvc.1.0.view", @"/Areas/Approvals/Views/Inbox/_list.cshtml")]
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
#line 1 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Approvals\Views\Inbox\_list.cshtml"
using ErpOnClick.ErpMain.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Approvals\Views\Inbox\_list.cshtml"
using ErpOnClick.ErpMain.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2c9c1e56ff51229a3c0eda9eb36fa2197ef05d9", @"/Areas/Approvals/Views/Inbox/_list.cshtml")]
    public class Areas_Approvals_Views_Inbox__list : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Approvals\Views\Inbox\_list.cshtml"
  
    List<ApprovalRouteDetailViewModel> InboxList = Model.ApprovalRouteDetailViewModelList;
    string controllerName = null, areaName = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\r\n    .btnwidth {\r\n        width: 75px;\r\n    }\r\n</style>\r\n");
#nullable restore
#line 14 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Approvals\Views\Inbox\_list.cshtml"
Write(Html.Partial("/Views/Shared/ApprovalLayout/_generalModalPartial.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"table-responsive pb-2 \">\r\n    <div>\r\n        <table id=\"dtList\" class=\"table table-hover table-condensed \" style=\"display:none\">\r\n            <thead class=\"text-sm\">\r\n                <tr>\r\n                    <th> ");
#nullable restore
#line 20 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Approvals\Views\Inbox\_list.cshtml"
                    Write(SharedLocalizer.GetLocalizedHtmlString("Subject"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n                    <th> ");
#nullable restore
#line 21 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Approvals\Views\Inbox\_list.cshtml"
                    Write(SharedLocalizer.GetLocalizedHtmlString("Record Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n                    <th>");
#nullable restore
#line 22 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Approvals\Views\Inbox\_list.cshtml"
                   Write(SharedLocalizer.GetLocalizedHtmlString("Requested By"));

#line default
#line hidden
#nullable disable
            WriteLiteral("  </th>\r\n                    <th>");
#nullable restore
#line 23 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Approvals\Views\Inbox\_list.cshtml"
                   Write(SharedLocalizer.GetLocalizedHtmlString("Requested Date"));

#line default
#line hidden
#nullable disable
            WriteLiteral("  </th>\r\n\r\n                    <th>");
#nullable restore
#line 25 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Approvals\Views\Inbox\_list.cshtml"
                   Write(SharedLocalizer.GetLocalizedHtmlString("Approval"));

#line default
#line hidden
#nullable disable
            WriteLiteral("  </th>\r\n                    <th>");
#nullable restore
#line 26 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Approvals\Views\Inbox\_list.cshtml"
                   Write(SharedLocalizer.GetLocalizedHtmlString("Action Date"));

#line default
#line hidden
#nullable disable
            WriteLiteral("  </th>\r\n                    <th>");
#nullable restore
#line 27 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Approvals\Views\Inbox\_list.cshtml"
                   Write(SharedLocalizer.GetLocalizedHtmlString("Approval Status"));

#line default
#line hidden
#nullable disable
            WriteLiteral("  </th>\r\n                    <th>");
#nullable restore
#line 28 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Approvals\Views\Inbox\_list.cshtml"
                   Write(SharedLocalizer.GetLocalizedHtmlString("Actions"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"  </th>
                </tr>
            </thead>
            <tfoot style=""display:table-row-group"">
                <tr class=""text-center"">

                    <th> Subject </th>
                    <th> Record Name </th>
                    <th> Requested By </th>
                    <th> Requested Date </th>

                    <th> Approval </th>
                    <th> Action Date </th>

                    <th> Approval Status </th>

                    <th> Actions </th>


                </tr>
            </tfoot>
            <tbody>
");
#nullable restore
#line 50 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Approvals\Views\Inbox\_list.cshtml"
                 foreach (var item in InboxList.OrderByDescending(x => x.Route.CreatedDate))
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr class=\"text-center\">\r\n\r\n                        <td align=\"left\"> ");
#nullable restore
#line 55 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Approvals\Views\Inbox\_list.cshtml"
                                     Write(item.Route.RecordNotes);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                        <td align=\"left\"> ");
#nullable restore
#line 56 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Approvals\Views\Inbox\_list.cshtml"
                                     Write(item.Route.RecordName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                        <td align=\"left\"> ");
#nullable restore
#line 57 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Approvals\Views\Inbox\_list.cshtml"
                                     Write(item.RequestedBy);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                        <td>");
#nullable restore
#line 58 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Approvals\Views\Inbox\_list.cshtml"
                        Write(item.Route.CreatedDate != null ? Convert.ToDateTime(item.Route.CreatedDate).ToString("dd-MMM-yyyy") : "");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                        <td align=\"left\"> ");
#nullable restore
#line 60 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Approvals\Views\Inbox\_list.cshtml"
                                     Write(item.ApprovarUser);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                        <td>");
#nullable restore
#line 61 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Approvals\Views\Inbox\_list.cshtml"
                        Write(item.Route.ActionDate != null ? Convert.ToDateTime(item.Route.ActionDate).ToString("dd-MMM-yyyy") : "Waiting for action");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                        <td align=\"center\">\r\n");
#nullable restore
#line 64 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Approvals\Views\Inbox\_list.cshtml"
                             if (item.Status == "Rejected")
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <label class=\"text-danger\"><i class=\"fal fa-times mr-2\"></i>Rejected</label>\r\n");
#nullable restore
#line 67 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Approvals\Views\Inbox\_list.cshtml"
                            }
                            else if (item.Status == "Approved")
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <label class=\"text-success\"><i class=\"fal fa-check mr-2\"></i>Approved</label>\r\n");
#nullable restore
#line 71 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Approvals\Views\Inbox\_list.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <label class=\"text-warning\"><i class=\"fal fa-spinner fa-spin mr-2\"></i>Pending</label>\r\n");
#nullable restore
#line 75 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Approvals\Views\Inbox\_list.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n\r\n                        <td class=\"text-center\" width=\"40px\">\r\n");
            WriteLiteral("                            <a href=\"javascript:void(0)\" class=\"btn btn-sm \"");
            BeginWriteAttribute("onclick", " onclick=\"", 3811, "\"", 3883, 3);
            WriteAttributeValue("", 3821, "showDetail(\'", 3821, 12, true);
#nullable restore
#line 80 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Approvals\Views\Inbox\_list.cshtml"
WriteAttributeValue("", 3833, System.Text.Json.JsonSerializer.Serialize(item), 3833, 48, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3881, "\')", 3881, 2, true);
            EndWriteAttribute();
            WriteLiteral(" title=\"Edit\"><i class=\"fal fa-search\"></i></a>\r\n");
#nullable restore
#line 81 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Approvals\Views\Inbox\_list.cshtml"
                             if (!string.IsNullOrEmpty(item.ApprovalTasks.URL))
                            {
                                var urlArray = item.ApprovalTasks.URL.Split("/");

                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a href=\"javascript:void(0)\" class=\"btn btn-sm \"");
            BeginWriteAttribute("onclick", " onclick=\"", 4396, "\"", 4520, 3);
            WriteAttributeValue("", 4406, "window.open(\'", 4406, 13, true);
#nullable restore
#line 86 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Approvals\Views\Inbox\_list.cshtml"
WriteAttributeValue("", 4419, Url.Action("edit", urlArray[1] , new { Area = urlArray[0],id = item.Route.RecordId,code = "101" }), 4419, 99, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4518, "\')", 4518, 2, true);
            EndWriteAttribute();
            WriteLiteral(" title=\"View Detail\"><i class=\"fal fa-eye\"></i></a>\r\n");
#nullable restore
#line 87 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Approvals\Views\Inbox\_list.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a href=\"javascript:void(0)\" class=\"btn btn-sm \"");
            BeginWriteAttribute("onclick", " onclick=\"", 4750, "\"", 4845, 5);
            WriteAttributeValue("", 4760, "redirectToRequestEdit(\'", 4760, 23, true);
#nullable restore
#line 90 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Approvals\Views\Inbox\_list.cshtml"
WriteAttributeValue("", 4783, item.ApprovalTasks.URL, 4783, 23, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4806, "\',\'", 4806, 3, true);
#nullable restore
#line 90 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Approvals\Views\Inbox\_list.cshtml"
WriteAttributeValue("", 4809, item.ApprovalTasks.ApprovalTaskId, 4809, 34, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4843, "\')", 4843, 2, true);
            EndWriteAttribute();
            WriteLiteral(" title=\"View Detail\"><i class=\"fal fa-eye\"></i></a>\r\n");
#nullable restore
#line 91 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Approvals\Views\Inbox\_list.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n\r\n                    </tr>\r\n");
#nullable restore
#line 96 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Approvals\Views\Inbox\_list.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </tbody>
        </table>
    </div>
</div>
<div class=""modal fade"" id=""TaskDetailModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""importdataModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-lg"" role=""document"" style=""max-width:1024px;"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title pull-left"">Request Detail </h5>
                <button type=""button"" class=""close pull-right"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
                <div class=""clearfix""></div>
            </div>

            <div class=""modal-body"" style=""font-family:Calibri"" id=""TaskDetailModalBody"">

            </div>
        </div>
    </div>
</div>

<script>
    $(function () {

        _initDatatable('#dtList');
        $('#dtList').show();
    });
    var applicationName = getApplicationName();


    //function showDetail(");
            WriteLiteral("LogDetail, requestedBy, approvalUsers) {\r\n    function showDetail(taskDetail) {\r\n\r\n");
            WriteLiteral(@"
        debugger;
        console.log(taskDetail);
        $.ajax({
            url: applicationName + 'Approvals/Inbox/RequestDetailPartialView',
            type: ""post"",
            data: { approvalRouteDetailViewModel: taskDetail },
            success: function (data) {
                //$('#divList').html('').html(data);
                //$('#generalModal .modal-body').html(data);
                //$('#generalModal').modal('show');
                //$('#generalModal .modal-title').html('Request Detail');
                $('#TaskDetailModalBody').html(data);
                $('#TaskDetailModal').modal('show');
            }
        })

        //$('#TaskDetailModal').modal('show');

    }
    function redirectToRequestEdit(requestURL,approvalTaskId) {
        debugger;
        if (requestURL == null || requestURL == '') {
            confirmAction('Confirm ?', 'URL not defined do you want to define now?', 'info', 'Yes', 'No').then(function (result) {
                if (result.va");
            WriteLiteral(@"lue == true) {
                    window.location.href = '/Security/ApprovalTask/edit/' + approvalTaskId;
                }
            });
        }       


    }
    function setStatusVal(status) {
        var valueNotes = $(""#APPROVER_NOTES"").val();
        var id = $(""#ROUTE_DETAIL_ID"").val();

    }
    //

</script>");
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