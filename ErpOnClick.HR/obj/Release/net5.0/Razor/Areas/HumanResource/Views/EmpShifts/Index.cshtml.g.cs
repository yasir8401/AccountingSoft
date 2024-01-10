#pragma checksum "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpShifts\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "386bda8170d08d13274668a3eac98b749550d804"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_HumanResource_Views_EmpShifts_Index), @"mvc.1.0.view", @"/Areas/HumanResource/Views/EmpShifts/Index.cshtml")]
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
#line 1 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpShifts\Index.cshtml"
using ErpOnClick.DAL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpShifts\Index.cshtml"
using ErpOnClick.ErpMain.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"386bda8170d08d13274668a3eac98b749550d804", @"/Areas/HumanResource/Views/EmpShifts/Index.cshtml")]
    public class Areas_HumanResource_Views_EmpShifts_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpShifts\Index.cshtml"
  

    var empId = Model.empId;
    Emp empDetails = Model.empDetails;
    IList<Shifts> shiftList = Model.ShiftLists;


#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpShifts\Index.cshtml"
Write(Html.Partial("/Views/Shared/HrLayout/_generalModalPartial.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<form id=\"frmList\">\r\n    <input type=\"hidden\" id=\"EmpId\" name=\"EmpId\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 396, "\"", 410, 1);
#nullable restore
#line 15 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpShifts\Index.cshtml"
WriteAttributeValue("", 404, empId, 404, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />

    <div class=""card card-default card-outline"">
        <div class=""card-header p-0 border-bottom-0"">
            <div class=""card"" style=""background-color: #496b6a"">
            </div>
            <ul class=""nav nav-tabs"" id=""custom-content-below-tab"" role=""tablist"">
");
            WriteLiteral("                ");
#nullable restore
#line 25 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpShifts\Index.cshtml"
           Write(Html.Partial("/Areas/HumanResource/Views/Emp/_tabsPartial.cshtml", empDetails));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </ul>\r\n        </div>\r\n\r\n\r\n        <div class=\"card-header\">\r\n            <h2 class=\"card-title\">\r\n                ");
#nullable restore
#line 32 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpShifts\Index.cshtml"
           Write(SharedLocalizer.GetLocalizedHtmlString("Employee Shifts"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </h2>\r\n            <!-- tools box -->\r\n            <div class=\"card-tools float-right\">\r\n                <a href=\"javascript:void(0)\" class=\"btn  btn-sm btn-primary\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1405, "\"", 1449, 3);
            WriteAttributeValue("", 1415, "showDetail(\'0\',\'", 1415, 16, true);
#nullable restore
#line 36 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpShifts\Index.cshtml"
WriteAttributeValue("", 1431, empId, 1431, 6, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1437, "\',\'save\',\'\')", 1437, 12, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <i class=\"fal fa-plus\"></i> ");
#nullable restore
#line 37 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpShifts\Index.cshtml"
                                           Write(SharedLocalizer.GetLocalizedHtmlString("Add New"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </a>\r\n            </div>\r\n            <!-- /. tools -->\r\n        </div>\r\n\r\n\r\n\r\n        <div class=\"card-body\">\r\n            <div id=\"divList\"></div>\r\n\r\n        </div>\r\n    </div>\r\n</form>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        $(function () {
            $(""#tabEmpShifts-tab"").css(""background-color"", ""#496b6a"");
            $(""#tabEmpShifts-tab"").css(""color"", ""white"");

            BindGrid();
        });
        var applicationName = getApplicationName();


        function BindGrid() {

            $('#divList').html('<h5 class=""margin-0""><p><i class=""fa fa-spinner fa-spin fa-fw""></i> Please wait while data is loading...</p></h5>');
            $.ajax({
                url: applicationName + 'HumanResource/EmpShifts/_list',
                data: $('#frmList').serialize(),
                success: function (data) {
                    $('#divList').html(data);
                }
            })
        };

     function navigation() {
            window.location = applicationName +'HumanResource/emp/edit/");
#nullable restore
#line 76 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpShifts\Index.cshtml"
                                                                  Write(empId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\'\r\n        };\r\n\r\n\r\n    </script>\r\n");
            }
            );
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