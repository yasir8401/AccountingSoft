#pragma checksum "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\PMS\Views\PMSProjects\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a17d9b59980d855381bd0046e9ded0102a03146"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_PMS_Views_PMSProjects_Edit), @"mvc.1.0.view", @"/Areas/PMS/Views/PMSProjects/Edit.cshtml")]
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
#line 1 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\PMS\Views\PMSProjects\Edit.cshtml"
using ErpOnClick.DAL.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a17d9b59980d855381bd0046e9ded0102a03146", @"/Areas/PMS/Views/PMSProjects/Edit.cshtml")]
    public class Areas_PMS_Views_PMSProjects_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/adminlte/dist/css/EditAbleTableCss.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/PMS/PMSProjects"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn  btn-sm btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\PMS\Views\PMSProjects\Edit.cshtml"
  
    List<PmsUser> user = Model.User;
    List<PmsProjectTeam> ProjectTeam = Model.ProjectTeam;
    List<PmsCompany> Companies = Model.Companies;
    PmsProjects Project = Model.Project;
    bool isEdit = (Project != null);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2a17d9b59980d855381bd0046e9ded0102a031465125", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<form id=\"frmEdit\" role=\"form\">\r\n    <input type=\"hidden\" id=\"ACTION_TYPE\" name=\"ACTION_TYPE\"");
            BeginWriteAttribute("value", " value=\"", 440, "\"", 477, 1);
#nullable restore
#line 14 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\PMS\Views\PMSProjects\Edit.cshtml"
WriteAttributeValue("", 448, isEdit ? "update" : "save", 448, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input type=\"hidden\" id=\"ProjectId\" name=\"ProjectId\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 560, "\"", 610, 1);
#nullable restore
#line 15 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\PMS\Views\PMSProjects\Edit.cshtml"
WriteAttributeValue("", 568, Project != null ? Project.ProjectId : 0, 568, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 15 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\PMS\Views\PMSProjects\Edit.cshtml"
                                                                                                                             Write(isEdit ? "readonly" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(@" min=""3"" maxlength=""3"">

    <div class=""card card-default card-outline col-lg-12"">

        <div class=""card-header"">
            <h2 class=""card-title"">
                Project
            </h2>
            <!-- tools box -->
            <div class=""card-tools"">
                <button type=""submit"" class=""btn  btn-sm btn-primary"">
                    <i class=""fas fa-save fa-fw""></i> Save
                </button>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a17d9b59980d855381bd0046e9ded0102a031468119", async() => {
                WriteLiteral("\r\n                    <i class=\"fas fa-arrow-left fa-fw\"></i> Return\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
            <!-- /. tools -->
        </div>
        <div class=""card-body"">

            <div class=""row"">
                <div class=""col-sm-6"">
                    <div class=""form-group"">
                        <label>Project Name</label>
                        <input type=""text"" id=""ProjectName"" name=""ProjectName"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 1626, "\"", 1676, 1);
#nullable restore
#line 40 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\PMS\Views\PMSProjects\Edit.cshtml"
WriteAttributeValue("", 1634, Project!=null?Project.ProjectName: null, 1634, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" required>
                    </div>
                </div>
                <div class=""col-sm-6"">
                    <div class=""form-group"">
                        <label>Company</label>
                        <select id=""CompanyId"" name=""CompanyId"" class=""form-control"" required>
                            <option></option>
");
#nullable restore
#line 48 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\PMS\Views\PMSProjects\Edit.cshtml"
                             foreach (var company in Companies)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <option");
            BeginWriteAttribute("value", " value=\"", 2153, "\"", 2179, 1);
#nullable restore
#line 50 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\PMS\Views\PMSProjects\Edit.cshtml"
WriteAttributeValue("", 2161, company.CompanyId, 2161, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 50 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\PMS\Views\PMSProjects\Edit.cshtml"
                                                               Write(Project != null && Project.CompanyId == company.CompanyId ? "selected" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n                                    ");
#nullable restore
#line 51 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\PMS\Views\PMSProjects\Edit.cshtml"
                               Write(company.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </option>\r\n");
#nullable restore
#line 53 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\PMS\Views\PMSProjects\Edit.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </select>
                    </div>
                </div>
                <div class=""col-sm-12"">
                    <div class=""form-group"">
                        <label>Project Description</label>
                        <textarea required id=""ProjectDesc"" rows=""3"" name=""ProjectDesc"" style=""width: 100%; height: 100px; font-size: 14px; line-height: 18px; border: 1px solid #dddddd; padding: 10px;"">");
#nullable restore
#line 60 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\PMS\Views\PMSProjects\Edit.cshtml"
                                                                                                                                                                                                      Write(Project != null? Project.ProjectDesc : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</textarea>
                    </div>
                </div>
            </div>
        </div>

    </div>

    <div class=""card card-default card-outline"">
        <div class=""card-header"">
            <h2 class=""card-title pt-1"">
                Team
            </h2>
            <div class=""card-tools"">
                <a href=""javascript:void(0)"" class=""btn btn-sm btn-default"" onclick=""addRow(1)"">Add Row</a>
                <a href=""javascript:void(0)"" class=""btn btn-sm btn-default"" onclick=""addRow(3)"">Add 3 Rows</a>
                <a href=""javascript:void(0)"" class=""btn btn-sm btn-default"" onclick=""addRow(5)"">Add 5 Rows</a>

            </div>
        </div>
        <div class=""card-body p-0"">

            <div class=""table-responsive"">
                <table id=""tblLines"" class=""table table-bordered m-0 table-condensed"">
                    <thead>
                        <tr>
                            <th>Team Member</th>

                            <th width=""30px""></t");
            WriteLiteral(@"h>
                        </tr>
                    </thead>
                    <tbody>
                        <tr id=""trSample"" style=""display:none"">
                            <td style=""display:none"">
                                <input type=""hidden"" id=""TeamId"" name=""TeamId"" value=""0"">
                            </td>
                            <td class=""text-center"">
                                <select id=""ProjectUserId"" name=""ProjectUserId"" class=""form-control  text-center"">
");
#nullable restore
#line 98 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\PMS\Views\PMSProjects\Edit.cshtml"
                                     if (isEdit)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <option");
            BeginWriteAttribute("value", " value=\"", 4544, "\"", 4552, 0);
            EndWriteAttribute();
            WriteLiteral(" disabled selected></option>\r\n");
#nullable restore
#line 101 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\PMS\Views\PMSProjects\Edit.cshtml"
                                         foreach (var itemUser in user)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <option");
            BeginWriteAttribute("value", " value=\"", 4750, "\"", 4774, 1);
#nullable restore
#line 103 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\PMS\Views\PMSProjects\Edit.cshtml"
WriteAttributeValue("", 4758, itemUser.UserId, 4758, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                ");
#nullable restore
#line 104 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\PMS\Views\PMSProjects\Edit.cshtml"
                                           Write(itemUser.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </option>\r\n");
#nullable restore
#line 106 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\PMS\Views\PMSProjects\Edit.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 106 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\PMS\Views\PMSProjects\Edit.cshtml"
                                         
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </select>
                            </td>
                            <td>
                                <a href=""javascript:void(0)"" id=""lnkDelete"" class=""btn-sm btn-block text-danger"" onclick=""deleteRow($(this).parent().parent())"">
                                    <i id=""faDelete"" class=""fa fa-trash""></i>
                                    <i id=""faUndo"" class=""fa fa-undo text-white"" style=""display:none""></i>
                                </a>
                            </td>
                        </tr>
");
#nullable restore
#line 117 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\PMS\Views\PMSProjects\Edit.cshtml"
                         if (ProjectTeam.Count() != 0)
                        {

                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 120 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\PMS\Views\PMSProjects\Edit.cshtml"
                             foreach (var item in ProjectTeam)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td style=\"display:none\">\r\n                                        <input type=\"hidden\" id=\"TeamId\" name=\"TeamId\"");
            BeginWriteAttribute("value", " value=\"", 5915, "\"", 5957, 1);
#nullable restore
#line 124 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\PMS\Views\PMSProjects\Edit.cshtml"
WriteAttributeValue("", 5923, item.TeamId !=0 ? item.TeamId:0, 5923, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    </td>\r\n                                    <td class=\"text-center\">\r\n                                        <select id=\"ProjectUserId\" name=\"ProjectUserId\" class=\"form-control text-center\">\r\n");
#nullable restore
#line 128 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\PMS\Views\PMSProjects\Edit.cshtml"
                                             if (isEdit)
                                            {
                                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 130 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\PMS\Views\PMSProjects\Edit.cshtml"
                                                 foreach (var itemUser in user)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <option");
            BeginWriteAttribute("value", " value=\"", 6485, "\"", 6509, 1);
#nullable restore
#line 132 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\PMS\Views\PMSProjects\Edit.cshtml"
WriteAttributeValue("", 6493, itemUser.UserId, 6493, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 132 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\PMS\Views\PMSProjects\Edit.cshtml"
                                                                                 Write(itemUser != null && itemUser.UserId == item.ProjectUserId ? "selected" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n                                                        ");
#nullable restore
#line 133 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\PMS\Views\PMSProjects\Edit.cshtml"
                                                   Write(itemUser.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </option>\r\n");
#nullable restore
#line 135 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\PMS\Views\PMSProjects\Edit.cshtml"
                                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 135 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\PMS\Views\PMSProjects\Edit.cshtml"
                                                 
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        </select>
                                    </td>
                                    <td>
                                        <input type=""hidden"" id=""IsDeleted"" name=""IsDeleted"" value=""false"">
                                        <a href=""javascript:void(0)"" id=""lnkDelete"" class=""btn-sm btn-block text-danger"" onclick=""deleteRow($(this).parent().parent())"">
                                            <i id=""faDelete"" class=""fa fa-trash""></i>
                                            <i id=""faUndo"" class=""fa fa-undo text-white"" style=""display:none""></i>
                                        </a>
                                    </td>
                                </tr>
");
#nullable restore
#line 147 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\PMS\Views\PMSProjects\Edit.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 147 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\PMS\Views\PMSProjects\Edit.cshtml"
                             
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</form>\r\n\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"

    <script>

        $(function () {
            $('#Forms').addClass(""menu-open"");
            $('#Reports').removeClass(""menu-open"");
            var actionType = $('#ACTION_TYPE').val();
            if (actionType == ""save"") {
                addRow(3);

            }
            setTriggers();

        });

        $('#frmEdit').on('submit', function (e) {
            e.preventDefault();

            var routeArray = new Array();
            var taskObject = {
                ProjectId: parseInt($('#ProjectId').val()),
                ProjectName: $('#ProjectName').val(),
                ProjectDesc: $('#ProjectDesc').val(),
                CompanyId: parseInt($('#CompanyId').val()),
            }
            $(""#tblLines tbody TR"").not(""#trSample"").each(function () {

                var row = $(this);
                var inputFields = row.find("":input"");
                var routeObject = {};
                var user = row.find('#ProjectUserId').val();
                i");
                WriteLiteral(@"f (user != null) {

                    routeObject.TeamId = parseInt(row.find('#TeamId').val());
                    routeObject.ProjectUserId = parseInt(row.find('#ProjectUserId').val());
                    routeObject.IsDeleted = row.find('#IsDeleted').val()

                    routeArray.push(routeObject);
                }
            });

            var projectViewModel = {

                Project: taskObject,
                ProjectTeam: routeArray

            }

            var actionType = $('#ACTION_TYPE').val();

            confirmAction('Confirm ?', 'Are you sure you want to save changes ?', 'info', 'Yes', 'No').then(function (result) {
                if (result.value == true) {


                    $.ajax({
                        url: ""~/PMS/PMSProjects/"" + actionType,
                        type: ""POST"",
                        data: projectViewModel,
                        async: false,
                        success: function (data) {
                  ");
                WriteLiteral(@"          if (data.result.isError != true) {
                                showMsg('Saved !', 'Record has been saved !', 'success');
                                setTimeout(function () {
                                    window.location = '~/PMS/PMSProjects';
                                }, 500);
                            }
                            else if (data.result.msg != '') {
                                showMsg('Save Failed !', data.result.msg, 'error');
                            }
                            else {
                                showMsg('Save Failed !', 'Something went wrong. Try again', 'error');
                            }
                        }
                    });


                }
            });
        });

        function addRow(n) {
            var table = $('#tblLines');
            trSample = table.find('#trSample');
            for (var i = 0; i < n; i++) {
                var newRow = trSample.clone();
             ");
                WriteLiteral(@"   newRow.removeAttr('id');
                table.find('tbody').append(newRow);
            }
            table.find('tbody tr').not('#trSample').show();
            setTriggers();

        }
        function setTriggers() {
            var table = $('#tblLines');
            table.find('tbody tr').each((i, item) => {
                var tr = $(item);
            });
        }
        function deleteRow(tr) {

            tr.toggleClass('bg-danger');
            tr.find('a > #faDelete').toggle();
            tr.find('a > #faUndo').toggle();
            var inputFields = tr.find('#IsDeleted');

            var isDelete = tr.find('#IsDeleted').val();
            if (isDelete == ""false"") {
                tr.find('#IsDeleted').val(""true"");
            }
            if (isDelete == ""true"") {
                tr.find('#IsDeleted').val(""false"");
            }

        }

        $('#CompanyId').change(function () {

            var id = $('#CompanyId').val();

            $.ajax({
");
                WriteLiteral(@"                url: ""~/PMS/PMSProjects/GetCompanyTeam"",
                async: false,
                type: ""POST"",
                data: { id: id },
                success: function (data) {
                    var item = '';
                    var startrow = '<option value="""" disabled selected></option>';
                    item += startrow;
                    $.each(data.result, function (i, product) {
                        debugger
                        item += ""<option value='"" + product.userId + ""'>"" + product.userName + ""</option>"";
                    });
                    $('#tblLines tbody tr').each(function (e) {
                        $(this).find(""#ProjectUserId"").html(item);
                    });
                }
            });

        });
    </script>
");
            }
            );
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
