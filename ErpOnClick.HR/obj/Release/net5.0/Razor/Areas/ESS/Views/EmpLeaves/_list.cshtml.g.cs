#pragma checksum "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpLeaves\_list.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19fc3e4c2e058888d4daa470eb8b6d8f0d53f712"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_ESS_Views_EmpLeaves__list), @"mvc.1.0.view", @"/Areas/ESS/Views/EmpLeaves/_list.cshtml")]
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
#line 1 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpLeaves\_list.cshtml"
using ErpOnClick.DAL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpLeaves\_list.cshtml"
using ErpOnClick.ErpMain.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19fc3e4c2e058888d4daa470eb8b6d8f0d53f712", @"/Areas/ESS/Views/EmpLeaves/_list.cshtml")]
    public class Areas_ESS_Views_EmpLeaves__list : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default   btn-xs "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpLeaves\_list.cshtml"
  
    List<Leaves> LeaveList = Model.LeaveList;


#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .btnwidth {
        width: 75px;
    }
</style>
<div class=""table-responsive pb-2 "">
    <table id=""dtList"" class=""table table-hover table-condensed "" style=""display:none"">
        <thead class=""text-sm"">
            <tr>
                <th width=""10px""> ");
#nullable restore
#line 18 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpLeaves\_list.cshtml"
                             Write(SharedLocalizer.GetLocalizedHtmlString("Sr No."));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th align=\"left\"> ");
#nullable restore
#line 19 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpLeaves\_list.cshtml"
                             Write(SharedLocalizer.GetLocalizedHtmlString("Employee"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th> ");
#nullable restore
#line 20 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpLeaves\_list.cshtml"
                Write(SharedLocalizer.GetLocalizedHtmlString("From"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th> ");
#nullable restore
#line 21 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpLeaves\_list.cshtml"
                Write(SharedLocalizer.GetLocalizedHtmlString("To"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th> ");
#nullable restore
#line 22 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpLeaves\_list.cshtml"
                Write(SharedLocalizer.GetLocalizedHtmlString("Days"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 23 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpLeaves\_list.cshtml"
               Write(SharedLocalizer.GetLocalizedHtmlString("Type"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 24 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpLeaves\_list.cshtml"
               Write(SharedLocalizer.GetLocalizedHtmlString("Status"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</th>
                <th width=""30px""></th>

            </tr>
        </thead>
        <tfoot style=""display:table-row-group"">
            <tr class=""text-center"">
                <th width=""10px""> Sr No.</th>
                <th align=""left""> Employee</th>
                <th> From</th>
                <th> To</th>
                <th> Days</th>
                <th>Type</th>
                <th>Status</th>
                <th></th>


            </tr>
        </tfoot>
        <tbody>
");
#nullable restore
#line 44 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpLeaves\_list.cshtml"
               var i = 1; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpLeaves\_list.cshtml"
             foreach (var item in LeaveList)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr class=\"text-center\">\r\n                <td>");
#nullable restore
#line 49 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpLeaves\_list.cshtml"
               Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n");
#nullable restore
#line 50 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpLeaves\_list.cshtml"
                   i += 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td align=\"left\"> ");
#nullable restore
#line 51 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpLeaves\_list.cshtml"
                              Write(item.Emp !=null ? item.Emp.FirstNameEn + " " + item.Emp.FatherNameEn + " " + item.Emp.GrandNameEn + " " + item.Emp.FamilyNameEn :"");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 52 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpLeaves\_list.cshtml"
                Write(item.DateFrom != null ? Convert.ToDateTime(item.DateFrom).ToString("dd-MMM-yyyy") : "");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 53 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpLeaves\_list.cshtml"
                Write(item.DateTo != null ? Convert.ToDateTime(item.DateTo).ToString("dd-MMM-yyyy") : "");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 54 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpLeaves\_list.cshtml"
                Write((item.DateTo != null && item.DateFrom != null) ? (Convert.ToDateTime(item.DateTo) - Convert.ToDateTime(item.DateFrom)).TotalDays : "");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 55 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpLeaves\_list.cshtml"
                Write(item.LeaveType !=null ? item.LeaveType.LookupNameEn :"");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td align=\"center\">\r\n");
#nullable restore
#line 57 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpLeaves\_list.cshtml"
                     if (item.LeaveStatusNavigation != null && item.LeaveStatusNavigation.LookupNameEn == "Rejected")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <label class=\"btnwidth p-1 badge badge-danger mb-0\">Rejected</label>\r\n");
#nullable restore
#line 60 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpLeaves\_list.cshtml"

                    }
                    else if (item.LeaveStatusNavigation != null && item.LeaveStatusNavigation.LookupNameEn == "Approved")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <label class=\"btnwidth p-1 badge badge-success mb-0\">Approved</label>\r\n");
#nullable restore
#line 65 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpLeaves\_list.cshtml"
                    }
                    else if (item.LeaveStatusNavigation != null && item.LeaveStatusNavigation.LookupNameEn == "Pending")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <label class=\"btnwidth p-1 badge badge-warning mb-0\">Pending</label>\r\n");
#nullable restore
#line 69 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpLeaves\_list.cshtml"
                    }
                    else
                    {

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n                <td class=\"text-center padding-5\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19fc3e4c2e058888d4daa470eb8b6d8f0d53f71211709", async() => {
                WriteLiteral("<i class=\"fal fa-search\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3309, "~/ESS/EmpLeaves/view/", 3309, 21, true);
#nullable restore
#line 76 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpLeaves\_list.cshtml"
AddHtmlAttributeValue("", 3330, item.LeaveId, 3330, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n\r\n            </tr>\r\n");
#nullable restore
#line 80 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpLeaves\_list.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </tbody>
    </table>
</div>

<script>
    $(function () {

        _initDatatable('#dtList');
        $('#dtList').show();
    });
    var applicationName = getApplicationName();

    function deleteItem(id) {
        confirmAction('Confirm ?', 'Are you sure you want to save changes ?', 'info', 'Yes', 'No').then(function (result) {
            if (result.value == true) {

                $.ajax({
                    url: applicationName + ""ESS/Leave/delete"",
                    async: false,
                    type: ""POST"",
                    data: { id },
                    success: function (data) {
                        if (data.result.isError != true) {
                            showMsg('Deleted !', 'Record has been deleted !', 'success');
                            setTimeout(function () {
                                window.location = applicationName + 'ESS/EmpLeaves';
                            }, 500);
                        }
                        e");
            WriteLiteral(@"lse if (data.result.msg != '') {
                            showMsg('Delete Failed !', data.result.msg, 'error');
                        }
                        else {
                            showMsg('Delete Failed !', 'Something went wrong. Try again', 'error');
                        }
                    }
                });
            }
        });
    }

    function returnFromLeaves(empid, leaveid) {
        $.ajax({
            url: applicationName + ""ESS/LeavesReturn/edit"",
            async: false,
            type: ""POST"",
            data: { empid: empid, leaveid: leaveid },
            success: function (data) {
                $('#leaveReturnModal #leaveReturnModalBody').html(data);
                $('#leaveReturnModal').modal(""show"");
            }
        });
    }

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
