#pragma checksum "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpShifts\_list.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "95894d1f5704cc68d8f3021091c988777d28c231"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_HumanResource_Views_EmpShifts__list), @"mvc.1.0.view", @"/Areas/HumanResource/Views/EmpShifts/_list.cshtml")]
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
#line 1 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpShifts\_list.cshtml"
using ErpOnClick.DAL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpShifts\_list.cshtml"
using ErpOnClick.ErpMain.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95894d1f5704cc68d8f3021091c988777d28c231", @"/Areas/HumanResource/Views/EmpShifts/_list.cshtml")]
    public class Areas_HumanResource_Views_EmpShifts__list : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpShifts\_list.cshtml"
  
    List<EmpShifts> EmpShiftsList = Model.EmpShiftsList;
    var empId = Model.empId;
    IList<Shifts> shiftList = Model.ShiftLists;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 11 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpShifts\_list.cshtml"
Write(Html.Partial("/Views/Shared/HrLayout/_generalModalPartial.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"table-responsive pb-2 \">\r\n    <table id=\"dtList\" class=\"table table-hover table-condensed \" style=\"display:none\">\r\n        <thead class=\"text-sm\">\r\n            <tr>\r\n\r\n                <th>");
#nullable restore
#line 17 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpShifts\_list.cshtml"
               Write(SharedLocalizer.GetLocalizedHtmlString("Shift Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n                <th>");
#nullable restore
#line 18 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpShifts\_list.cshtml"
               Write(SharedLocalizer.GetLocalizedHtmlString("From"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n                <th>");
#nullable restore
#line 19 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpShifts\_list.cshtml"
               Write(SharedLocalizer.GetLocalizedHtmlString("To"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n                <th>");
#nullable restore
#line 20 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpShifts\_list.cshtml"
               Write(SharedLocalizer.GetLocalizedHtmlString("Shift Hours"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </th>
                <th width=""30px""></th>
                <th width=""30px""></th>
            </tr>
        </thead>
        <tfoot style=""display:table-row-group"">
            <tr class=""text-center"">

                <th>Shift Name </th>
                <th>From </th>
                <th>To </th>
                <th>Shift Hours </th>
                <th></th>
                <th></th>

            </tr>
        </tfoot>
        <tbody>
");
#nullable restore
#line 38 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpShifts\_list.cshtml"
             foreach (var item in EmpShiftsList)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr class=\"text-center\">\r\n                <td>");
#nullable restore
#line 42 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpShifts\_list.cshtml"
               Write(item.Shift.ShiftNameEn);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                <td>");
#nullable restore
#line 43 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpShifts\_list.cshtml"
               Write(item.Shift.FromTime);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                <td>");
#nullable restore
#line 44 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpShifts\_list.cshtml"
               Write(item.Shift.ToTime);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                <td>");
#nullable restore
#line 45 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpShifts\_list.cshtml"
                Write((TimeSpan.Parse(item.Shift.ToTime) - TimeSpan.Parse(item.Shift.FromTime)).ToString(@"hh\:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n\r\n                <td>\r\n                    <a href=\"javascript:void(0)\" class=\"btn btn-default btn-block btn-xs \"");
            BeginWriteAttribute("onclick", " onclick=\"", 1754, "\"", 1823, 7);
            WriteAttributeValue("", 1764, "showDetail(\'", 1764, 12, true);
#nullable restore
#line 48 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpShifts\_list.cshtml"
WriteAttributeValue("", 1776, item.RecId, 1776, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1787, "\',\'", 1787, 3, true);
#nullable restore
#line 48 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpShifts\_list.cshtml"
WriteAttributeValue("", 1790, empId, 1790, 6, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1796, "\',\'update\',\'", 1796, 12, true);
#nullable restore
#line 48 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpShifts\_list.cshtml"
WriteAttributeValue("", 1808, item.ShiftId, 1808, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1821, "\')", 1821, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <i class=\"fal fa-edit\"></i>\r\n                    </a>\r\n                </td>\r\n                <td class=\"text-center padding-5\">\r\n                    <a href=\"javascript:void(0)\" class=\"btn btn-default btn-block btn-xs \"");
            BeginWriteAttribute("onclick", " onclick=\"", 2071, "\"", 2106, 3);
            WriteAttributeValue("", 2081, "deleteItem(\'", 2081, 12, true);
#nullable restore
#line 53 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpShifts\_list.cshtml"
WriteAttributeValue("", 2093, item.RecId, 2093, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2104, "\')", 2104, 2, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fal fa-times text-danger\"></i></a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 56 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpShifts\_list.cshtml"
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
                    url: applicationName + ""HumanResource/EmpShifts/delete"",
                    async: false,
                    type: ""POST"",
                    data: { id },
                    success: function (data) {
                        if (data.result.isError != true) {
                            showMsg('Deleted !', 'Record has been deleted !', 'success');
                            setTimeout(function () {
                                window.location = applicationName +'HumanResource/EmpShifts/emp/");
#nullable restore
#line 83 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpShifts\_list.cshtml"
                                                                                           Write(empId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';
                            }, 500);
                        }
                        else if (data.result.msg != '') {
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
    function showDetail(RecId, empId, actionType,shiftId) {
        var allShifts = null;
         $.ajax({
                    url: applicationName +""HumanResource/EmpShifts/GetShifts"",
                    async: false,
                    type: ""POST"",
                    data: """",
             success: function (data) {

                 allShifts = data.result.scalerVal;
             }
                });


        var displayDAta = ""<form action='/HumanResource/EmpShifts/"" + actionType + ""' method='post'><input type='hidde");
            WriteLiteral(@"n' name='RecId' id='RecId' class='form-control' value='"" + RecId + ""' /><input type='hidden' name='EmpId' id='EmpId' class='form-control' value='"" + empId + ""' /> <div class='form-group'><label>Shifts</label><select id='ShiftId' name='ShiftId' class='form-control'>"";
        $.each(allShifts, function (key, value) {

            if (value.shiftId == shiftId) {
                displayDAta += ""<option value='"" + value.shiftId + ""' selected>"" + '  ' + value.shiftNameEn + '   (' + value.fromTime + '  to  ' + value.toTime + '  )  ' + ""</option>"";
            }
            else
            {
                displayDAta += ""<option value='"" + value.shiftId + ""' >"" + '  ' + value.shiftNameEn + '   (' + value.fromTime + '  to  ' + value.toTime + '  )  ' + ""</option>"";
            }

        });

        displayDAta += "" </select></div> <button type='submit' class='btn  btn-sm btn-primary'><i class='fas fa-save fa-fw'></i> Save</button></form>"";


        $('#generalModal .modal-body').html(displayDAta)");
            WriteLiteral(";\r\n        $(\'#generalModal\').modal(\'show\');\r\n        $(\'#generalModal .modal-title\').html(\'Shifts\');\r\n\r\n    }\r\n</script>");
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
