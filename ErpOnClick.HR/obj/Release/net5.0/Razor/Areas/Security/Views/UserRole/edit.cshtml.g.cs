#pragma checksum "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\UserRole\edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a373366e0d05a6e5a679d745bcb42cabaa97214"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Security_Views_UserRole_edit), @"mvc.1.0.view", @"/Areas/Security/Views/UserRole/edit.cshtml")]
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
#line 1 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\UserRole\edit.cshtml"
using ErpOnClick.ErpMain.Resources;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\UserRole\edit.cshtml"
using ErpOnClick.DAL.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a373366e0d05a6e5a679d745bcb42cabaa97214", @"/Areas/Security/Views/UserRole/edit.cshtml")]
    public class Areas_Security_Views_UserRole_edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn  btn-sm btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 4 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\UserRole\edit.cshtml"
  


    IList<Branch> branchList = Model.branchList;
    IList<Company> companyList = Model.companyList;
    IList<Users> userList = Model.userList;
    IList<Roles> roleList = Model.roleList;

    var userId = Model.userId;
    Users userDetails = Model.userDetails;


    UserRoles UserRoleDetails = Model.UserRolesDetails;
    bool isEdit = (UserRoleDetails != null);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n<form id=\"frmEdit\" role=\"form\" enctype=\"multipart/form-data\">\r\n    <input type=\"hidden\" id=\"ACTION_TYPE\" name=\"ACTION_TYPE\"");
            BeginWriteAttribute("value", " value=\"", 625, "\"", 662, 1);
#nullable restore
#line 25 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\UserRole\edit.cshtml"
WriteAttributeValue("", 633, isEdit ? "update" : "save", 633, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input type=\"hidden\" id=\"UserRoleId\" name=\"UserRoleId\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 747, "\"", 814, 1);
#nullable restore
#line 26 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\UserRole\edit.cshtml"
WriteAttributeValue("", 755, UserRoleDetails != null ? UserRoleDetails.UserRoleId : 0, 755, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 26 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\UserRole\edit.cshtml"
                                                                                                                                                Write(isEdit ? "readonly" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(@" min=""3"" maxlength=""3"">

    <div class=""card card-default card-outline col-lg-8"">
        <div class=""card-header p-0 border-bottom-0"">
            <ul class=""nav nav-tabs"" id=""custom-content-below-tab"" role=""tablist"">
                <li class=""nav-item"">
                    <a class=""nav-link"" onclick=""navigation()"" href=""javascript:void(0)"">");
#nullable restore
#line 32 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\UserRole\edit.cshtml"
                                                                                    Write(SharedLocalizer.GetLocalizedHtmlString("user"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                </li>\r\n\r\n\r\n                <li class=\"nav-item\">\r\n                    <a class=\"nav-link\" id=\"tabUserPrivileges-tab\" data-toggle=\"pill\" onclick=\"navigationTwo()\" href=\"javascript:void(0)\">");
#nullable restore
#line 37 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\UserRole\edit.cshtml"
                                                                                                                                     Write(SharedLocalizer.GetLocalizedHtmlString("User Privilage"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                </li>\r\n                <li class=\"nav-item\">\r\n                    <a class=\"nav-link\" id=\"tabUserRole-tab\" data-toggle=\"pill\" onclick=\"navigationThree()\" href=\"javascript:void(0)\">");
#nullable restore
#line 40 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\UserRole\edit.cshtml"
                                                                                                                                 Write(SharedLocalizer.GetLocalizedHtmlString("User Roles"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                </li>\r\n\r\n            </ul>\r\n        </div>\r\n        <div class=\"card-header\">\r\n            <h2 class=\"card-title\">\r\n                ");
#nullable restore
#line 47 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\UserRole\edit.cshtml"
           Write(SharedLocalizer.GetLocalizedHtmlString("Details"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </h2>\r\n            <!-- tools box -->\r\n            <div class=\"card-tools float-right\">\r\n                <button type=\"submit\" class=\"btn  btn-sm btn-primary\">\r\n                    <i class=\"fal fa-save fa-fw\"></i> ");
#nullable restore
#line 52 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\UserRole\edit.cshtml"
                                                 Write(SharedLocalizer.GetLocalizedHtmlString("Save"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </button>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a373366e0d05a6e5a679d745bcb42cabaa972149030", async() => {
                WriteLiteral("\r\n                    <i class=\"fal fa-arrow-left fa-fw\"></i> ");
#nullable restore
#line 55 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\UserRole\edit.cshtml"
                                                       Write(SharedLocalizer.GetLocalizedHtmlString("Return"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2299, "~/Security/userrole/user/", 2299, 25, true);
#nullable restore
#line 54 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\UserRole\edit.cshtml"
AddHtmlAttributeValue("", 2324, userId, 2324, 7, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n            <!-- /. tools -->\r\n        </div>\r\n        <div class=\"card-body\">\r\n\r\n            <div class=\"row\">\r\n                <div class=\"col-sm-6\">\r\n                    <div class=\"form-group\">\r\n                        <label>");
#nullable restore
#line 65 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\UserRole\edit.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Users"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <select id=\"UserId\" name=\"UserId\" class=\"form-control\" required>\r\n\r\n");
#nullable restore
#line 68 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\UserRole\edit.cshtml"
                             foreach (var item in userList)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <option");
            BeginWriteAttribute("value", " value=\"", 3045, "\"", 3065, 1);
#nullable restore
#line 70 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\UserRole\edit.cshtml"
WriteAttributeValue("", 3053, item.UserId, 3053, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 70 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\UserRole\edit.cshtml"
                                                         Write(UserRoleDetails != null && UserRoleDetails.UserId == item.UserId ? "selected" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n                                    ");
#nullable restore
#line 71 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\UserRole\edit.cshtml"
                               Write(item.DisplayNameEn);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </option>\r\n");
#nullable restore
#line 73 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\UserRole\edit.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </select>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-sm-6\">\r\n                    <div class=\"form-group\">\r\n                        <label>");
#nullable restore
#line 79 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\UserRole\edit.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Roles"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <select id=\"RoleId\" name=\"RoleId\" class=\"form-control\" required>\r\n\r\n");
#nullable restore
#line 82 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\UserRole\edit.cshtml"
                             foreach (var item in roleList)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <option");
            BeginWriteAttribute("value", " value=\"", 3771, "\"", 3791, 1);
#nullable restore
#line 84 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\UserRole\edit.cshtml"
WriteAttributeValue("", 3779, item.RoleId, 3779, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 84 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\UserRole\edit.cshtml"
                                                         Write(UserRoleDetails != null && UserRoleDetails.RoleId == item.RoleId ? "selected" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n                                    ");
#nullable restore
#line 85 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\UserRole\edit.cshtml"
                               Write(item.RoleNameEn);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </option>\r\n");
#nullable restore
#line 87 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\UserRole\edit.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </select>
                    </div>
                </div>

            </div>


        </div>

    </div>

    <div class=""card card-default card-outline col-lg-8"">
        <div class=""card-header"">
            <h2 class=""card-title"">
                ");
#nullable restore
#line 102 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\UserRole\edit.cshtml"
           Write(SharedLocalizer.GetLocalizedHtmlString("More Details"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </h2>\r\n        </div>\r\n        <div class=\"card-body\">\r\n            <div class=\"row\">\r\n\r\n\r\n                <div class=\"col-sm-6 \">\r\n                    <div class=\"form-group\">\r\n                        <label>");
#nullable restore
#line 111 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\UserRole\edit.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Company"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <select id=\"CompanyId\" name=\"CompanyId\" class=\"form-control\" required>\r\n                            <option></option>\r\n");
#nullable restore
#line 114 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\UserRole\edit.cshtml"
                             foreach (var item in companyList)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <option");
            BeginWriteAttribute("value", " value=\"", 4916, "\"", 4939, 1);
#nullable restore
#line 116 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\UserRole\edit.cshtml"
WriteAttributeValue("", 4924, item.CompanyId, 4924, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 116 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\UserRole\edit.cshtml"
                                                            Write(UserRoleDetails != null && UserRoleDetails.CompanyId == item.CompanyId ? "selected" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n                                    ");
#nullable restore
#line 117 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\UserRole\edit.cshtml"
                               Write(item.CoNameEn);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </option>\r\n");
#nullable restore
#line 119 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\UserRole\edit.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </select>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-sm-6 \">\r\n                    <div class=\"form-group\">\r\n                        <label>");
#nullable restore
#line 125 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\UserRole\edit.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Branch"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <select id=\"BranchId\" name=\"BranchId\" class=\"form-control\" required>\r\n");
#nullable restore
#line 127 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\UserRole\edit.cshtml"
                             if (isEdit)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 129 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\UserRole\edit.cshtml"
                                 foreach (var item in branchList)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <option");
            BeginWriteAttribute("value", " value=\"", 5737, "\"", 5759, 1);
#nullable restore
#line 131 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\UserRole\edit.cshtml"
WriteAttributeValue("", 5745, item.BranchId, 5745, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 131 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\UserRole\edit.cshtml"
                                                               Write(UserRoleDetails != null && UserRoleDetails.BranchId == item.BranchId ? "selected" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n                                        ");
#nullable restore
#line 132 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\UserRole\edit.cshtml"
                                   Write(item.BranchNameEn);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </option>\r\n");
#nullable restore
#line 134 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\UserRole\edit.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 134 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\UserRole\edit.cshtml"
                                 
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </select>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-sm-6\">\r\n                    <div class=\"form-group\">\r\n                        <label>");
#nullable restore
#line 141 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\UserRole\edit.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Is-Active"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <select id=\"IsActive\" name=\"IsActive\" class=\"form-control\" required>\r\n");
            WriteLiteral("                            <option value=\"True\" ");
#nullable restore
#line 144 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\UserRole\edit.cshtml"
                                             Write(UserRoleDetails != null && UserRoleDetails.IsActive == true ? "selected" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(">Active</option>\r\n                            <option value=\"False\" ");
#nullable restore
#line 145 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\UserRole\edit.cshtml"
                                              Write(UserRoleDetails != null && UserRoleDetails.IsActive == false ? "selected" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(">Inactive</option>\r\n                        </select>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</form>\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"

    <script>

        $(function () {
            $('#ApplicationSummary').summernote(
                {
                    height: 200,

                }
            );
        });


        $('#frmEdit').on('submit', function (e) {
            e.preventDefault();
            var actionType = $('#ACTION_TYPE').val();

            confirmAction('Confirm ?', 'Are you sure you want to save changes ?', 'info', 'Yes', 'No').then(function (result) {
                if (result.value == true) {

                    var params = $('#frmEdit').serialize();
                    $.ajax({
                        url: getApplicationName()+""Security/UserRole/"" + actionType,
                        async: false,
                        type: ""POST"",
                        data: params,
                        success: function (data) {
                            if (data.result.isError != true) {
                                showMsg('Saved !', 'Record has been saved !', 'success');
    ");
                WriteLiteral("                            setTimeout(function () {\r\n                                    window.location = getApplicationName() +\'Security/UserRole/user/");
#nullable restore
#line 191 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\UserRole\edit.cshtml"
                                                                                               Write(userId);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"';
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

        $('#CompanyId').change(function () {

            var id = $('#CompanyId').val();

            $.ajax({
                url: getApplicationName()+""Ajax/BranchCascading"",
                async: false,
                type: ""POST"",
                data: { id: id },
                success: function (data) {

                    var item = '';

                    $.each(data.result, function (i, product) {

                        item += ""<option value='"" + pro");
                WriteLiteral(@"duct.branchId + ""'>"" + product.branchNameEn + ""</option>"";
                    });

                    $(""#BranchId"").html(item);

                }
            });

        });
           function navigation() {

             window.location = getApplicationName() + 'Security/User/edit/");
#nullable restore
#line 236 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\UserRole\edit.cshtml"
                                                                     Write(userId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\';\r\n    };\r\n          function navigationTwo() {\r\n\r\n              window.location = getApplicationName() + \'Security/userprivileges/user/");
#nullable restore
#line 240 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\UserRole\edit.cshtml"
                                                                                Write(userDetails.UserId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\';\r\n            };\r\n         function navigationThree() {\r\n\r\n              window.location = getApplicationName() + \'Security/userrole/user/");
#nullable restore
#line 244 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\UserRole\edit.cshtml"
                                                                          Write(userDetails.UserId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\';\r\n            };\r\n    </script>\r\n\r\n");
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
