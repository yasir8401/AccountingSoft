#pragma checksum "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\Branch\edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "513414e3f91652f49c2933429de36045260fcc0c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Security_Views_Branch_edit), @"mvc.1.0.view", @"/Areas/Security/Views/Branch/edit.cshtml")]
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
#line 1 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\Branch\edit.cshtml"
using ErpOnClick.DAL.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"513414e3f91652f49c2933429de36045260fcc0c", @"/Areas/Security/Views/Branch/edit.cshtml")]
    public class Areas_Security_Views_Branch_edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Security/Branch"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn  btn-sm btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\Branch\edit.cshtml"
  
    Branch BranchDetail = Model.BranchIdDetail;
    bool isEdit = (BranchDetail != null);
    List<Company> companies = Model.companyList;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<form id=\"frmEdit\" role=\"form\">\r\n    <input type=\"hidden\" id=\"ACTION_TYPE\" name=\"ACTION_TYPE\"");
            BeginWriteAttribute("value", " value=\"", 278, "\"", 315, 1);
#nullable restore
#line 11 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\Branch\edit.cshtml"
WriteAttributeValue("", 286, isEdit ? "update" : "save", 286, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input type=\"hidden\" id=\"BranchId\" name=\"BranchId\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 396, "\"", 455, 1);
#nullable restore
#line 12 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\Branch\edit.cshtml"
WriteAttributeValue("", 404, BranchDetail != null ? BranchDetail.BranchId : 0, 404, 51, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 12 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\Branch\edit.cshtml"
                                                                                                                                    Write(isEdit ? "readonly" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(@" min=""3"" maxlength=""3"">

    <div class=""card card-default card-outline col-lg-8"">

        <div class=""card-header"">
            <h2 class=""card-title"">
                Branch Info
            </h2>
            <!-- tools box -->
            <div class=""card-tools float-right"">
                <button type=""submit"" class=""btn  btn-sm btn-primary"">
                    <i class=""fal fa-save fa-fw""></i> Save
                </button>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "513414e3f91652f49c2933429de36045260fcc0c6202", async() => {
                WriteLiteral("\r\n                    <i class=\"fal fa-arrow-left fa-fw\"></i> Return\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
                        <label>Branch Name</label>
                        <input type=""text"" id=""BranchNameEn"" name=""BranchNameEn"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 1495, "\"", 1556, 1);
#nullable restore
#line 41 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\Branch\edit.cshtml"
WriteAttributeValue("", 1503, BranchDetail!=null?BranchDetail.BranchNameEn: null, 1503, 53, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" required>
                    </div>
                </div>
                <div class=""col-sm-6"">
                    <div class=""form-group"">
                        <label>Branch Name in Arabic</label>
                        <input type=""text"" id=""BranchNameAr"" name=""BranchNameAr"" class=""form-control"" dir=""rtl""");
            BeginWriteAttribute("value", " value=\"", 1880, "\"", 1941, 1);
#nullable restore
#line 47 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\Branch\edit.cshtml"
WriteAttributeValue("", 1888, BranchDetail!=null?BranchDetail.BranchNameAr: null, 1888, 53, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                </div>
                <div class=""col-sm-6"">
                    <div class=""form-group"">
                        <label>Company</label>
                        <select id=""CompanyId"" name=""CompanyId"" class=""form-control""  required>
                            <option></option>
");
#nullable restore
#line 55 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\Branch\edit.cshtml"
                             foreach (var item in companies)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <option");
            BeginWriteAttribute("value", " value=\"", 2407, "\"", 2430, 1);
#nullable restore
#line 57 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\Branch\edit.cshtml"
WriteAttributeValue("", 2415, item.CompanyId, 2415, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 57 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\Branch\edit.cshtml"
                                                            Write(BranchDetail != null && BranchDetail.CompanyId == item.CompanyId ? "selected" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n                                    ");
#nullable restore
#line 58 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\Branch\edit.cshtml"
                               Write(item.CoNameEn);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </option>\r\n");
#nullable restore
#line 60 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\Branch\edit.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </select>
                    </div>
                </div>


                <div class=""col-sm-6 d-none"">
                    <div class=""form-group"">
                        <label>Active Status</label>
                        <select id=""IsEnable"" name=""IsEnable"" class=""form-control"">
");
            WriteLiteral("                            <option value=\"True\" ");
#nullable restore
#line 71 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\Branch\edit.cshtml"
                                             Write(BranchDetail != null && BranchDetail.IsEnable == true ? "selected" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(">Active</option>\r\n                            <option value=\"False\" ");
#nullable restore
#line 72 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\Branch\edit.cshtml"
                                              Write(BranchDetail != null && BranchDetail.IsEnable == false ? "selected" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(@">Inactive</option>
                        </select>
                    </div>
                </div>

            </div>
        </div>

    </div>



    <div class=""card card-default card-outline col-lg-8"">
        <div class=""card-header"">
            <h2 class=""card-title"">
                Contact Info
            </h2>
        </div>
        <div class=""card-body"">
            <div class=""row"">
                <div class=""col-sm-6"">
                    <div class=""form-group"">
                        <label>Email</label>
                        <input type=""email"" id=""BranchEmail"" name=""BranchEmail"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 3943, "\"", 4001, 1);
#nullable restore
#line 95 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\Branch\edit.cshtml"
WriteAttributeValue("", 3951, BranchDetail!=null?BranchDetail.BranchEmail: "", 3951, 50, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                </div>

                <div class=""col-sm-6"">
                    <div class=""form-group"">
                        <label>Phone</label>
                        <input type=""number"" id=""BranchPhone"" name=""BranchPhone"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 4292, "\"", 4350, 1);
#nullable restore
#line 102 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\Branch\edit.cshtml"
WriteAttributeValue("", 4300, BranchDetail!=null?BranchDetail.BranchPhone: "", 4300, 50, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                </div>

            </div>
        </div>
    </div>




    <div class=""card card-default card-outline col-lg-8"">
        <div class=""card-header"">
            <h2 class=""card-title"">
                Address
            </h2>
        </div>
        <div class=""card-body"">
            <div class=""row"">
                <div class=""col-sm-6"">
                    <div class=""form-group"">
                        <label>Address</label>
                        <textarea id=""BranchAddressEn"" name=""BranchAddressEn"" rows=""5"" class=""form-control"">");
#nullable restore
#line 124 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\Branch\edit.cshtml"
                                                                                                        Write(BranchDetail!=null?BranchDetail.BranchAddressEn: "");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</textarea>
                    </div>
                </div>

                <div class=""col-sm-6"">
                    <div class=""form-group"">
                        <label>Address in Arabic</label>
                        <textarea id=""BranchAddressAr"" name=""BranchAddressAr"" rows=""5"" class=""form-control"" dir=""rtl"">");
#nullable restore
#line 131 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Security\Views\Branch\edit.cshtml"
                                                                                                                  Write(BranchDetail!=null?BranchDetail.BranchAddressAr: "");

#line default
#line hidden
#nullable disable
            WriteLiteral("</textarea>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n\r\n  \r\n\r\n\r\n</form>\r\n\r\n\r\n\r\n\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"

    <script>
        $(function () {

        });


        $('#frmEdit').on('submit', function (e) {
            e.preventDefault();
            var actionType = $('#ACTION_TYPE').val();

            confirmAction('Confirm ?', 'Are you sure you want to save changes ?', 'info', 'Yes', 'No').then(function (result) {
                if (result.value == true) {

                    var params = $('#frmEdit').serialize();
                    $.ajax({
                        url: getApplicationName() +""Security/Branch/"" + actionType,
                        async: false,
                        type: ""POST"",
                        data: params,
                        success: function (data) {
                            if (data.result.isError != true) {
                                showMsg('Saved !', 'Record has been saved !', 'success');
                                setTimeout(function () {
                                    window.location = getApplicationName() +'Security/B");
                WriteLiteral(@"ranch';
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
