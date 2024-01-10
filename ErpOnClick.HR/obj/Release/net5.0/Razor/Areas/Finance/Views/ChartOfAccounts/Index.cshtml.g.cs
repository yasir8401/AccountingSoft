#pragma checksum "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\ChartOfAccounts\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32376c8f99871901baf311c04a2262e3d9b573c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Finance_Views_ChartOfAccounts_Index), @"mvc.1.0.view", @"/Areas/Finance/Views/ChartOfAccounts/Index.cshtml")]
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
#line 1 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\ChartOfAccounts\Index.cshtml"
using ErpOnClick.DAL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\ChartOfAccounts\Index.cshtml"
using ErpOnClick.ErpMain.Resources;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\ChartOfAccounts\Index.cshtml"
using ErpOnClick.ErpMain.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32376c8f99871901baf311c04a2262e3d9b573c2", @"/Areas/Finance/Views/ChartOfAccounts/Index.cshtml")]
    public class Areas_Finance_Views_ChartOfAccounts_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 600px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/adminlte/dist/img/loadingpleasewait.gif"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 6 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\ChartOfAccounts\Index.cshtml"
  
    List<Accounts> Accounts = Model.Accounts;
    List<AccountTypes> AccountTypes = Model.AccountTypes;
    List<importData> importedData = Model.importedData;
    List<importData> importedDatalvl1 = importedData.Where(c => c.Level == "1").ToList();
    List<importData> importedDatalvl2 = importedData.Where(c => c.Level == "2").ToList();
    List<importData> importedDatalvl3 = importedData.Where(c => c.Level == "3").ToList();
    List<importData> importedDatalvl4 = importedData.Where(c => c.Level == "4").ToList();
    List<importData> importedDatalvl5 = importedData.Where(c => c.Level == "5").ToList();
    var childnode = 0;
    var node = 0;



#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"loading col-md-12 \" style=\"text-align:center;\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "32376c8f99871901baf311c04a2262e3d9b573c25098", async() => {
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
            WriteLiteral("</div>\r\n\r\n<div class=\"card card-default card-outline\" id=\"div\" style=\"display:none;\">\r\n\r\n    <div class=\"card-header\">\r\n        <h2 class=\"card-title\">\r\n            ");
#nullable restore
#line 26 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\ChartOfAccounts\Index.cshtml"
       Write(SharedLocalizer.GetLocalizedHtmlString("Diagram for Chart Of Accounts"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </h2>\r\n        <!-- tools box -->\r\n        <div class=\"card-tools fa-pull-right\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 1293, "\"", 1355, 2);
#nullable restore
#line 30 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\ChartOfAccounts\Index.cshtml"
WriteAttributeValue("", 1300, Url.Content("~/"), 1300, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1318, "Finance/ChartOfAccounts/ExcelDocument", 1318, 37, true);
            EndWriteAttribute();
            WriteLiteral(" id=\"exportdata\" type=\"button\" class=\"btn btn-sm btn-primary\">\r\n                <i class=\"fal fa-file-export\"></i> ");
#nullable restore
#line 31 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\ChartOfAccounts\Index.cshtml"
                                              Write(SharedLocalizer.GetLocalizedHtmlString("Export File"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </a>\r\n");
            WriteLiteral("            <a");
            BeginWriteAttribute("href", " href=\"", 1815, "\"", 1863, 2);
#nullable restore
#line 36 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\ChartOfAccounts\Index.cshtml"
WriteAttributeValue("", 1822, Url.Content("~/"), 1822, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1840, "Finance/Accounts/edit/0", 1840, 23, true);
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\" id=\"importdata\" type=\"button\" class=\"btn btn-sm btn-primary\">\r\n                <i class=\"fal fa-plus\"></i> ");
#nullable restore
#line 37 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\ChartOfAccounts\Index.cshtml"
                                       Write(SharedLocalizer.GetLocalizedHtmlString("Add Account"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </a>\r\n        </div>\r\n        <!-- /. tools -->\r\n    </div>\r\n\r\n\r\n    <div class=\"card-footer pb-0 pt-2 text-sm\">\r\n        <div id=\"jstree\">\r\n            <ul>\r\n");
#nullable restore
#line 47 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\ChartOfAccounts\Index.cshtml"
                 foreach (var head in Accounts.Where(c => c.ParentAccountId == null))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li>\r\n                        <span class=\"head\">\r\n                            ");
#nullable restore
#line 51 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\ChartOfAccounts\Index.cshtml"
                       Write(head.AccountNameEn);

#line default
#line hidden
#nullable disable
            WriteLiteral(" -");
#nullable restore
#line 51 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\ChartOfAccounts\Index.cshtml"
                                            Write(head.AccountCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </span>\r\n                        <ul>\r\n");
#nullable restore
#line 54 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\ChartOfAccounts\Index.cshtml"
                             foreach (var subhead in Accounts.Where(c => c.ParentAccountId == head.AccountId))
                            {
                                childnode = childnode + 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li");
            BeginWriteAttribute("id", " id=\"", 2761, "\"", 2787, 2);
            WriteAttributeValue("", 2766, "child_node_", 2766, 11, true);
#nullable restore
#line 57 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\ChartOfAccounts\Index.cshtml"
WriteAttributeValue("", 2777, childnode, 2777, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    ");
#nullable restore
#line 58 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\ChartOfAccounts\Index.cshtml"
                               Write(subhead.AccountNameEn);

#line default
#line hidden
#nullable disable
            WriteLiteral(" -");
#nullable restore
#line 58 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\ChartOfAccounts\Index.cshtml"
                                                       Write(subhead.AccountCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("                                    <ul>\r\n");
#nullable restore
#line 63 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\ChartOfAccounts\Index.cshtml"
                                         foreach (var lower in Accounts.Where(c => c.ParentAccountId == subhead.AccountId))
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li class=\"last\"");
            BeginWriteAttribute("id", " id=\"", 3477, "\"", 3503, 2);
            WriteAttributeValue("", 3482, "last_", 3482, 5, true);
#nullable restore
#line 65 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\ChartOfAccounts\Index.cshtml"
WriteAttributeValue("", 3487, lower.AccountId, 3487, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n                                                ");
#nullable restore
#line 67 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\ChartOfAccounts\Index.cshtml"
                                           Write(lower.AccountNameEn);

#line default
#line hidden
#nullable disable
            WriteLiteral(" -");
#nullable restore
#line 67 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\ChartOfAccounts\Index.cshtml"
                                                                 Write(lower.AccountCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                <span class=\"text-right\">\r\n                                                    <a href=\"javascript:void(0)\" data-toggle=\"tooltip\" title=\"Delete\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3791, "\"", 3833, 3);
            WriteAttributeValue("", 3801, "deleteitem(\'", 3801, 12, true);
#nullable restore
#line 69 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\ChartOfAccounts\Index.cshtml"
WriteAttributeValue("", 3813, subhead.AccountId, 3813, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3831, "\')", 3831, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-default btn-sm\"><i class=\"fal fa-trash text-danger\"></i></a>\r\n                                                    <a href=\"javascript:void(0)\" data-toggle=\"tooltip\" title=\"Edit\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4027, "\"", 4061, 3);
            WriteAttributeValue("", 4037, "edit(\'", 4037, 6, true);
#nullable restore
#line 70 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\ChartOfAccounts\Index.cshtml"
WriteAttributeValue("", 4043, lower.AccountId, 4043, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4059, "\')", 4059, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-default btn-sm\"><i class=\"fal fa-edit text-dark\"></i></a>\r\n                                                </span>\r\n                                            </li>\r\n");
#nullable restore
#line 73 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\ChartOfAccounts\Index.cshtml"

                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </ul>\r\n                                </li>\r\n");
#nullable restore
#line 77 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\ChartOfAccounts\Index.cshtml"



                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\r\n                    </li>\r\n");
#nullable restore
#line 83 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\ChartOfAccounts\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            WriteLiteral(@"

<style>
    .accent-orange .btn-link, .accent-orange a:not(.dropdown-item):not(.btn-app):not(.nav-link):not(.brand-link):not(.page-link):not(.btn) {
        color: #6d8888 !important;
    }

    #jstree {
        font-family: ""Helvetica Neue"",Helvetica,Arial,sans-serif !important;
    }

    .jstree-default .jstree-node {
        min-height: 35px !important;
        line-height: 35px;
        margin-left: 24px;
        min-width: 24px;
    }

    .head {
        /*font-style: normal;
        font-weight: bold;
        letter-spacing: 1px;*/
        font-size: 13px;
    }

    /* The customcheck */
    .customcheck {
        display: block;
        position: relative;
        padding-left: 35px;
        margin-bottom: 12px;
        cursor: pointer;
        font-size: 22px;
        -webkit-user-select: none;
        -moz-user-select: none;
        -ms-user-select: none;
        user-select: none;
    }

        /* Hide the browser's default checkbox */
        .customch");
            WriteLiteral(@"eck input {
            position: absolute;
            opacity: 0;
            cursor: pointer;
        }

    /* Create a custom checkbox */
    .checkmark {
        position: absolute;
        top: 0;
        left: 0;
        height: 25px;
        width: 25px;
        background-color: #dbefef;
        border-radius: 5px;
    }

    /* On mouse-over, add a grey background color */
    .customcheck:hover input ~ .checkmark {
        background-color: #ccc;
    }

    /* When the checkbox is checked, add a blue background */
    .customcheck input:checked ~ .checkmark {
        background-color: #84ceeb;
        border-radius: 5px;
    }

    /* Create the checkmark/indicator (hidden when not checked) */
    .checkmark:after {
        content: """";
        position: absolute;
        display: none;
    }

    /* Show the checkmark when checked */
    .customcheck input:checked ~ .checkmark:after {
        display: block;
    }

    /* Style the checkmark/indicator */
 ");
            WriteLiteral(@"   .customcheck .checkmark:after {
        left: 9px;
        top: 5px;
        width: 5px;
        height: 10px;
        border: solid white;
        border-width: 0 3px 3px 0;
        -webkit-transform: rotate(45deg);
        -ms-transform: rotate(45deg);
        transform: rotate(45deg);
    }

    #jstree ul li .jstree-anchor {
        width: 98%;
    }

        #jstree ul li .jstree-anchor .text-right {
            float: right;
        }

    .jstree-default .jstree-wholerow {
        height: 29px !important;
    }

    .jstree li.last > a > .jstree-icon {
        background-image: none !important;
    }

   
</style>

");
#nullable restore
#line 236 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\ChartOfAccounts\Index.cshtml"
Write(Html.Partial("/areas/Finance/Views/ChartOfAccounts/_generalModalPartial.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 237 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\ChartOfAccounts\Index.cshtml"
Write(Html.Partial("/areas/Finance/Views/ChartOfAccounts/_addAccountModalPartial.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"

    <script>
        $(function () {
            $("".loading"").fadeOut(1500, function () {
                $(""#div"").fadeIn(500);
            });

            $('#Accli').addClass(""menu-open"");
            $('#Reportsli').removeClass(""menu-open"");
            $('#Statementsli').removeClass(""menu-open"");
            $('#AccPli').removeClass(""menu-open"");
            $('#AccRli').removeClass(""menu-open"");
            $('#Setupli').removeClass(""menu-open"");

            $('#jstree').jstree({
                ""plugins"": [""wholerow""]
            });
        });


        $('#jstree').on(""changed.jstree"", function (e, data) {
            console.log(data.selected);
        });
        function importData() {
            $('#importdataModal').modal('show');
        }


        $('#formimportCOA').submit(function (e) {

            e.preventDefault();

            var ext = $('#ChartOfAccountFile').val().split('.').pop().toLowerCase();
            if (!(ext == ""xlsx"" || ext == ""xls""");
                WriteLiteral(@")) {
                document.getElementById(this.id).value = """";
                showMsg(""Invalid File Type !"", ""You may only upload Excel files. Please ensure your file is in one of these formats."", ""error"");
                isValidated = false;
            }
            else {
                var file = $(""#ChartOfAccountFile"")[0].files[0];
                var reader = new FileReader();
                var excelData = [];
                var ImportData = Array();
                var _ImportData = {};
                var count = 0;
                var check = false;
                reader.onload = function (event) {
                    var data = event.target.result;
                    var workbook = XLSX.read(data, {
                        type: 'binary'
                    });

                    workbook.SheetNames.forEach(function (sheetName) {
                        // Here is your object
                        if (sheetName == ""Chart of Account"") {

                        ");
                WriteLiteral(@"    var XL_row_object = XLSX.utils.sheet_to_row_object_array(workbook.Sheets[sheetName]);
                            var row = """";
                            var ImportData = new Array();
                            $.each(XL_row_object, function (key, value) {

                                var DataRows = {};
                                DataRows.LineId = value.Code;
                                DataRows.Name = value.Name;
                                DataRows.Level = value.Level;
                                DataRows.Nature = value.Nature;
                                ImportData.push(DataRows);
                                count = count + 1;
                                if (count == XL_row_object.length) {
                                    check = true;
                                }
                            });
                            var Data = {

                                IData: ImportData
                            };

                    ");
                WriteLiteral(@"        if (check == true) {
                                sendData();
                            }

                        }
                        else {
                            //showMsg('Import Failed !', 'Selected File/Sheet in Incorrect. Try again', 'error');
                        }
                    });
                };

                reader.onerror = function (ex) {
                    console.log(ex);
                };

                reader.readAsBinaryString(file);
            }

        });

        function sendData() {

            $('#formimportCOA').find('#formsubmit').html('<i class=""fal fa-spinner fa-spin fa-fw""></i> Please Wait, While Your Data is Importing...');
            $('#formimportCOA').find('#formsubmit').prop(""disabled"", true);
            var params = $('#formimportCOA').serialize();
            var formEl = document.forms.formimportCOA;
            var formData = new FormData(formEl);
            $.ajax({
                url: getApp");
                WriteLiteral(@"licationName() + ""Finance/ChartOfAccounts/ImportData"",
                type: 'POST',
                cache: false,
                contentType: false,
                processData: false,
                data: formData ? formData : params,
                success: function (data) {

                    if (data.result.isError == false) {
                        setTimeout(function () {
                            showMsg('Data Imported !', 'Data has been Imported !', 'success');
                            window.location.href = getApplicationName() + 'Finance/ChartOfAccounts/Index?filename=' + data.result.msg;

                        }, 1000);
                        $('#formimportCOA').find('#formsubmit').html('<i class=""fal fa-paperclip fa-fw""></i> Upload Now');
                        $('#formimportCOA').find('#formsubmit').prop(""disabled"", false);
                    }
                },
                error: function (jqXHR, textStatus, errorThrown) {
                    console.log(");
                WriteLiteral(@"textStatus, errorThrown);
                }
            });

        }

        function showModal() {
            getCOA();
            gettypes();
            getaccountnaturelist();
            $('#addAccountModal').modal(""show"");
        }

        function getCOA(id, isTransactionable) {

            $.ajax({
                url: getApplicationName() + ""Finance/ChartOfAccounts/GetChartOfAccounts"",
                type: ""POST"",
                success: function (data) {
                    debugger;
                    if (data.result.length > 0) {
                        var maxhead = 0;
                        var toprow = ""<option value='' selected disabled></option>"";
                        var rows = toprow + """";
                        $.each(data.result, function (key, value) {
                            maxhead = (value.nature > maxhead ? value.nature : maxhead);
                            for (var head = 1; head <= maxhead; head++) {
                                i");
                WriteLiteral(@"f (value.code == head && value.nature == head) {
                                    rows += ""<option class='bg-gray' value="" + value.accountId + "" "" + (id != 0 && id == value.accountId ? ""Selected"" : """") + "">"" + value.name + "" (Level: "" + value.level + "")"" + ""</option>"";
                                    $.each(data.result, function (subkey, subvalue) {
                                        if (subvalue.code.substring(0, 1) == head && subvalue.level == 2 && subvalue != value) {
                                            rows += ""<option style='background-color:#8d8d8d;color:#FFFFFF;' value="" + subvalue.accountId + "" "" + (id != 0 && id == subvalue.accountId ? ""Selected"" : """") + "">--"" + subvalue.name + "" (Level: "" + subvalue.level + "")"" + ""</option>"";
                                            $.each(data.result, function (subsubkey, subsubvalue) {
                                                if (subsubvalue.code.substring(0, 2) == subvalue.code && subsubvalue.level == 3 && subsubvalue != subval");
                WriteLiteral(@"ue) {
                                                    rows += ""<option style='background-color:#a6a6a6;color:#FFFFFF;' value="" + subsubvalue.accountId + "" "" + (id != 0 && id == subsubvalue.accountId ? ""Selected"" : """") + "">----"" + subsubvalue.name + "" (Level: "" + subsubvalue.level + "")"" + ""</option>"";
                                                    $.each(data.result, function (subsubsubkey, subsubsubvalue) {
                                                        if (subsubsubvalue.code.substring(0, 3) == subsubvalue.code && subsubsubvalue.level == 4 && subsubsubvalue != subsubvalue) {
                                                            rows += ""<option value="" + subsubsubvalue.accountId + "" "" + (id != 0 && id == subsubsubvalue.accountId ? ""Selected"" : """") + "">------"" + subsubsubvalue.name + "" (Level: "" + subsubsubvalue.level + "")"" + ""</option>"";
                                                        }
                                                    });
                            ");
                WriteLiteral(@"                    }
                                            });
                                        }
                                    });
                                }
                            }
                        });
                        $('#Parent').html(rows);
                    }
                    ParentChange('#Parent', isTransactionable);
                },
                error: function (jqXHR, textStatus, errorThrown) {

                    console.log(textStatus, errorThrown);
                }
            });
        }

        function gettypes(id) {
            $.ajax({
                url: getApplicationName() + ""Finance/ChartOfAccounts/GetAccountTypes"",
                type: ""POST"",
                success: function (data) {

                    if (data.result.length > 0) {
                        var toprow = ""<option value='' selected disabled></option>"";
                        var rows = toprow + """";
                        $.each(");
                WriteLiteral(@"data.result, function (key, value) {

                            rows += ""<option value="" + value.accountTypeId + "" "" + (id != 0 && id == value.accountTypeId ? ""selected"" : """") + "">"" + value.accountTypeNameEn + ""</option>"";
                        });
                        $('#AccountType').html(rows);
                    }
                },
                error: function (jqXHR, textStatus, errorThrown) {

                    console.log(textStatus, errorThrown);
                }
            });
        }

        function getaccountnaturelist(id) {
            $.ajax({
                url: getApplicationName() + ""Finance/ChartOfAccounts/GetAccountNatureList"",
                type: ""POST"",
                success: function (data) {

                    if (data.result.length > 0) {
                        var toprow = ""<option value='' selected disabled></option>"";
                        var rows = toprow + """";
                        $.each(data.result, function (key, value) {");
                WriteLiteral(@"

                            rows += ""<option value="" + value.lookupId + "" "" + (id != 0 && id == value.lookupId ? ""selected"" : """") + "">"" + value.lookupNameEn + ""</option>"";
                        });
                        $('#AccountNatureId').html(rows);
                    }
                },
                error: function (jqXHR, textStatus, errorThrown) {

                    console.log(textStatus, errorThrown);
                }
            });
        }

        $('#formAddChartOfAccount').submit(function (e) {
            e.preventDefault();
            confirmAction('Confirm ?', 'Are you sure you want to save changes ?', 'info', 'Yes', 'No').then(function (result) {
                if (result.value == true) {

                    var params = $('#formAddChartOfAccount').serialize();
                    $.ajax({
                        url: getApplicationName() + ""Finance/ChartOfAccounts/AddChartOfAccount"",
                        async: false,
                        type:");
                WriteLiteral(@" ""POST"",
                        data: params,
                        success: function (data) {

                            if (data.result.isError == false) {
                                setTimeout(function () {
                                    showMsg('Saved !', 'Record has been saved !', 'success');
                                    $('#addAccountModal').modal(""hide"");
                                    window.location.reload();

                                }, 1000);
                            }
                        },
                        error: function (jqXHR, textStatus, errorThrown) {
                            console.log(textStatus, errorThrown);
                        }
                    });
                }
            });
        });


        function edit(id) {
            window.open(getApplicationName() + ""Finance/Accounts/edit/"" + id, ""_blank"");
            //var parentcoa = 0;
            //var type = 0;
            //var accountnature ");
                WriteLiteral(@"= 0;
            //var isTransactionable = null;
            //$.ajax({
            //    url: getApplicationName() + ""Finance/ChartOfAccounts/GetAccountDetails"",
            //    async: false,
            //    type: ""POST"",
            //    data: { id, id },
            //    success: function (data) {

            //        if (data.result != null) {

            //            if (data.result.isTransactionable == true) {
            //                $('#IsTransactionable').prop(""checked"", true);
            //                isTransactionable = true;
            //            }
            //            else {
            //                $('#IsTransactionable').prop(""checked"", false);
            //                isTransactionable = false;
            //            }
            //            parentcoa = data.result.parentAccountId;
            //            type = data.result.accountTypeId;
            //            accountnature = data.result.accountNatureId;
            //   ");
                WriteLiteral(@"         $('#Id').val(data.result.accountId);
            //            $('#Name').val(data.result.accountNameEn);
            //            $('#Code').val(data.result.accountCode);
            //            $('#OpeningBalance').val(data.result.openingBalance);
            //            $('#Balance').val(data.result.closingBalance);

            //            //$('#Parent').val(data.result.parentAccountId);
            //            //$('#AccountNatureId').val(data.result.accountNatureId);

            //            $(""#DefaultType option"").each(function (e) {
            //                if ($(this).val() == data.result.defaultType) {
            //                    $(this).attr(""selected"", ""selected"");
            //                }
            //            });
            //            $(""#Status option"").each(function (e) {
            //                if ($(this).val() == ""Active"" && data.result.status == true) {
            //                    $(this).attr(""selected"", ""selected"")");
                WriteLiteral(@";
            //                }
            //                else if ($(this).val() == ""Inactive"" && data.result.status == false) {
            //                    $(this).attr(""selected"", ""selected"");
            //                }
            //            });
            //        }
            //    },
            //    error: function (jqXHR, textStatus, errorThrown) {
            //        console.log(textStatus, errorThrown);
            //    }
            //});
            //getCOA(parentcoa, isTransactionable);
            //gettypes(type);
            //getaccountnaturelist(accountnature);
            //$('#addAccountModal').modal(""show"");
        }

        function deleteitem(id) {
            confirmAction('Confirm ?', 'Are you sure you want to delete ?', 'info', 'Yes', 'No').then(function (result) {
                if (result.value == true) {
                    $.ajax({
                        url: getApplicationName() + ""Finance/ChartOfAccounts/Delete"",
          ");
                WriteLiteral(@"              async: false,
                        type: ""POST"",
                        data: { id },
                        success: function (data) {
                            if (data.result.isError == true) {
                                showMsg('Deleted !', 'Record has been deleted !', 'success');
                                setTimeout(function () {
                                    window.location = getApplicationName() + 'Finance/ChartOfAccounts';
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

        function");
                WriteLiteral(@" ParentChange(e, isTransactionable = true) {
            debugger;
            var isTransactionable = isTransactionable;
            var dropdownid = $(e).attr(""id"");
            var value = $(""#"" + dropdownid + "" option:selected"").text();
            if (value.toLowerCase().indexOf(""4"") >= 0) {
                $('#checkboxdiv').show();
                $('#CheckboxdivParentALternate').hide();
                $('#IsTransactionable').prop(""checked"", (isTransactionable != null ? isTransactionable : true));
            }
            else {
                $('#CheckboxdivParentALternate').show();
                $('#IsTransactionable').prop(""checked"", false);
                $('#checkboxdiv').hide();
            }
        }
    </script>
");
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
