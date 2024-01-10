#pragma checksum "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\PMS\Views\PMSInbox\_list.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70714074c805e1dbab7e6c0cdd7a1ea0a3816ad3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_PMS_Views_PMSInbox__list), @"mvc.1.0.view", @"/Areas/PMS/Views/PMSInbox/_list.cshtml")]
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
#line 1 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\PMS\Views\PMSInbox\_list.cshtml"
using ErpOnClick.DAL.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70714074c805e1dbab7e6c0cdd7a1ea0a3816ad3", @"/Areas/PMS/Views/PMSInbox/_list.cshtml")]
    public class Areas_PMS_Views_PMSInbox__list : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\PMS\Views\PMSInbox\_list.cshtml"
  
    List<PmsMessages> Messages = Model.Messages;

    var userid = User.Claims.FirstOrDefault(c => c.Type == "UserId").Value;


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""table-responsive pb-2"">
    <table id=""dtList"" class=""table table-hover table-condensed"">
        <thead>
            <tr>
                <th>Project</th>
                <th>Task </th>
                <th>Message</th>
                <th>Sent By</th>
                <th>Received By</th>
                <th>Message Date</th>
                <th></th>
            </tr>
        </thead>
        <tfoot style=""display:table-row-group"">
            <tr class=""text-center"">
                <th>Project</th>
                <th>Task </th>
                <th>Message</th>
                <th>Sent By</th>
                <th>Received By</th>
                <th>Message Date</th>
                <th></th>
            </tr>
        </tfoot>
        <tbody>
");
#nullable restore
#line 34 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\PMS\Views\PMSInbox\_list.cshtml"
             foreach (var item in Messages)
            {
                var bgcolor = "";
                var type = "";
                if (item.SendBy == Convert.ToInt32(userid))
                {
                    bgcolor = "danger";
                    type = "Sent";
                }
                else if (item.SendTo == Convert.ToInt32(userid))
                {
                    bgcolor = "success";
                    type = "Received";
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr");
            BeginWriteAttribute("class", " class=\"", 1471, "\"", 1500, 2);
            WriteAttributeValue("", 1479, "text-center", 1479, 11, true);
#nullable restore
#line 48 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\PMS\Views\PMSInbox\_list.cshtml"
WriteAttributeValue("  ", 1490, bgcolor, 1492, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <td>");
#nullable restore
#line 49 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\PMS\Views\PMSInbox\_list.cshtml"
                    Write(item.Task != null && item.Task.Project != null && item.Task.Project.ProjectName != null ? item.Task.Project.ProjectName : null);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"text-left\">");
#nullable restore
#line 50 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\PMS\Views\PMSInbox\_list.cshtml"
                                      Write(item.Task != null && item.Task.TaskName != null ? item.Task.TaskName : null);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"text-center\">");
#nullable restore
#line 51 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\PMS\Views\PMSInbox\_list.cshtml"
                                       Write(item.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"text-center\">");
#nullable restore
#line 52 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\PMS\Views\PMSInbox\_list.cshtml"
                                        Write(item.SendByNavigation != null && item.SendByNavigation.UserName != null ? item.SendByNavigation.UserName : null);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"text-center\">");
#nullable restore
#line 53 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\PMS\Views\PMSInbox\_list.cshtml"
                                        Write(item.SendToNavigation != null && item.SendToNavigation.UserName != null ? item.SendToNavigation.UserName : null);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"text-center\">");
#nullable restore
#line 54 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\PMS\Views\PMSInbox\_list.cshtml"
                                        Write(item.Date != null ? Convert.ToDateTime(item.Date).ToString("dd-MMM-yyyy") : System.DateTime.Now.ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"text-center font-weight-bolder\">");
#nullable restore
#line 55 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\PMS\Views\PMSInbox\_list.cshtml"
                                                          Write(type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 57 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\PMS\Views\PMSInbox\_list.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n\r\n<script>\r\n    $(function () {\r\n        _initDatatable(\'#dtList\');\r\n    });\r\n</script>");
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