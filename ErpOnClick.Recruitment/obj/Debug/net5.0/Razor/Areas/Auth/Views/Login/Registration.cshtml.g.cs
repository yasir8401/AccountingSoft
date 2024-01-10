#pragma checksum "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Areas\Auth\Views\Login\Registration.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2834aee41bf24ea6c3756904b1d6f201c1a3511"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Auth_Views_Login_Registration), @"mvc.1.0.view", @"/Areas/Auth/Views/Login/Registration.cshtml")]
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
#line 1 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Areas\Auth\Views\Login\Registration.cshtml"
using ErpOnClick.DAL.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2834aee41bf24ea6c3756904b1d6f201c1a3511", @"/Areas/Auth/Views/Login/Registration.cshtml")]
    public class Areas_Auth_Views_Login_Registration : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/adminlte/dist/img/Erponclick.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/auth/login/index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:inherit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Areas\Auth\Views\Login\Registration.cshtml"
  
    Layout = "~/Views/Shared/adminlte/_AuthLayout.cshtml";

    List<Company> CompanyDetails = Model.CompanyDetail;
    List<Branch> BranchDetails = Model.BranchDetail;


#line default
#line hidden
#nullable disable
            WriteLiteral("<form id=\"frmEdit\" role=\"form\">\r\n \r\n    <div class=\"register-box\">\r\n        <div class=\"card\">\r\n            <div class=\"card-body register-card-body\">\r\n\r\n                <div class=\"text-center\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a2834aee41bf24ea6c3756904b1d6f201c1a35114957", async() => {
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
            WriteLiteral(@"
                </div>
                <p class=""login-box-msg mt-2 text-center""><b>Recruitment On Click</b><hr class=""mt-0"" /> Registration Form</p>


                <div class=""row"">
                    <div class=""col-sm-6"">
                        <div class=""form-group"">
                            <label>User Name</label>
                            <input type=""text"" id=""UserName"" name=""UserName"" class=""form-control"" required>
                        </div>
                    </div>
                    <div class=""col-sm-6"">
                        <div class=""form-group"">
                            <label>Email</label>
                            <input type=""email"" id=""Email"" name=""Email"" class=""form-control"" required />

                        </div>
                    </div>
                    <div class=""col-sm-6"">
                        <div class=""form-group"">
                            <label>Mobile No</label>
                            <input type=""number"" id=""M");
            WriteLiteral(@"obileNo"" name=""MobileNo"" class=""form-control"" required />
                        </div>
                    </div>

                    <div class=""col-sm-3"">
                        <div class=""form-group"">
                            <label>Password</label>
                            <input type=""password"" id=""Password"" name=""Password"" class=""form-control"" ");
            WriteLiteral(@" title=""Must contain at least one number and one uppercase and lowercase letter, and at least 8 or more characters"" required />
                        </div>
                    </div>
                    <div class=""col-sm-3"">
                        <div class=""form-group"">
                            <label>Confirm Password</label>
                            <input type=""password"" id=""ConfirmPassword"" name=""ConfirmPassword"" class=""form-control"" ");
            WriteLiteral(@" title=""Must contain at least one number and one uppercase and lowercase letter, and at least 8 or more characters"" required />
                        </div>
                    </div>

                    <div class=""col-sm-6"">
                        <div class=""form-group"">
                            <label>Company</label>
                            <select id=""CompanyId"" name=""CompanyId"" class=""form-control"" required>

");
#nullable restore
#line 60 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Areas\Auth\Views\Login\Registration.cshtml"
                                 foreach (var item in CompanyDetails)
                                {
                                  

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <option");
            BeginWriteAttribute("value", " value=\"", 3062, "\"", 3085, 1);
#nullable restore
#line 63 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Areas\Auth\Views\Login\Registration.cshtml"
WriteAttributeValue("", 3070, item.CompanyId, 3070, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 63 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Areas\Auth\Views\Login\Registration.cshtml"
                                                                Write(item.CoNameEn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 64 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Areas\Auth\Views\Login\Registration.cshtml"

                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </select>
                        </div>
                    </div>
                    <div class=""col-sm-6"">
                        <div class=""form-group"">
                            <label>Branch</label>
                            <select id=""BranchId"" name=""BranchId"" class=""form-control"" required>

");
#nullable restore
#line 74 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Areas\Auth\Views\Login\Registration.cshtml"
                                 foreach (var item in BranchDetails)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <option");
            BeginWriteAttribute("value", " value=\"", 3642, "\"", 3664, 1);
#nullable restore
#line 76 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Areas\Auth\Views\Login\Registration.cshtml"
WriteAttributeValue("", 3650, item.BranchId, 3650, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" )> ");
#nullable restore
#line 76 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Areas\Auth\Views\Login\Registration.cshtml"
                                                                 Write(item.BranchNameEn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 77 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.Recruitment\Areas\Auth\Views\Login\Registration.cshtml"

                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </select>
                        </div>
                    </div>

                    <div class=""col-sm-12"">
                        <div class=""form-group"">
                            <button type=""submit"" class=""btn btn-primary btn-block"">Submit</button>
                        </div>
                    </div>
                    <div class=""col-12 text-center p-1"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a2834aee41bf24ea6c3756904b1d6f201c1a351112191", async() => {
                WriteLiteral("Already have an account? Sign In");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n\r\n                </div>\r\n\r\n\r\n            </div>\r\n\r\n        </div>\r\n\r\n    </div>\r\n</form>\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"

    <script>
        $(function () {

        });
        var applicationName = getApplicationName();


        $('#frmEdit').on('submit', function (e) {

            e.preventDefault();
            confirmAction('Confirm ?', 'Are you sure you want to Register yourself ?', 'info', 'Yes', 'No').then(function (result) {
                if (result.value == true) {
                    
                    var Password = $('#Password').val();
                    var confirm = $('#ConfirmPassword').val();
                    if (Password == confirm) {


                        var params = $('#frmEdit').serialize();
                        $.ajax({
                            url: applicationName+""Auth/Login/RegistrationValidation"",
                            async: false,
                            type: ""POST"",
                            data: params,
                            success: function (data) {
                                if (data.result.isError != true) {
         ");
                WriteLiteral(@"                           showMsg('Register Successfully');
                                    setTimeout(function () {
                                        window.location = applicationName+'Auth/login/Index';
                                    }, 600);
                                }
                                else if (data.result.msg != '') {
                                    showMsg('This Email Already Exist!');

                                }
                                else {
                                    showMsg('Save Failed !', 'Something went wrong. Try again', 'error');
                                }

                            }
                        });
                    }
                    else {
                        showMsg('Password and confirm password are not same')
                    }

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