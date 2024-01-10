#pragma checksum "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\AccountLedger\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a6f84dcfcbed21cf03e332697d8ca1b27c6f7c6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Finance_Views_AccountLedger_Index), @"mvc.1.0.view", @"/Areas/Finance/Views/AccountLedger/Index.cshtml")]
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
#line 1 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\AccountLedger\Index.cshtml"
using ErpOnClick.DAL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\AccountLedger\Index.cshtml"
using ErpOnClick.ErpMain.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a6f84dcfcbed21cf03e332697d8ca1b27c6f7c6", @"/Areas/Finance/Views/AccountLedger/Index.cshtml")]
    public class Areas_Finance_Views_AccountLedger_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\AccountLedger\Index.cshtml"
  
    List<Accounts> accountsList = Model.accountsList;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<div class=\"card card-default card-outline\">\r\n\r\n    <div class=\"card-header\">\r\n        <h2 class=\"card-title\">\r\n            ");
#nullable restore
#line 15 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\AccountLedger\Index.cshtml"
       Write(SharedLocalizer.GetLocalizedHtmlString("ACCOUNT LEDGER"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </h2>\r\n        <!-- tools box -->\r\n        <div class=\"card-tools float-right\">\r\n            <a id=\"printList\"");
            BeginWriteAttribute("href", " href=\"", 474, "\"", 481, 0);
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\" class=\"btn btn-default btn-sm\"><i class=\"fal fa-print fa-fw\"></i>");
#nullable restore
#line 19 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\AccountLedger\Index.cshtml"
                                                                                                                  Write(SharedLocalizer.GetLocalizedHtmlString("Print"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>


        </div>
        <!-- /. tools -->
    </div>
    <div class=""card-footer pb-0 pt-2 text-sm"">
        <form id=""frmSearch"">
            <div class=""row"">


                <div class=""col-sm-3"">
                    <div class=""form-group"">
                        <label>");
#nullable restore
#line 32 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\AccountLedger\Index.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("From Date"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </label>
                        <input type=""text"" id=""FromDate"" name=""FromDate"" class=""form-control DatePicker"">
                    </div>
                </div>
                <div class=""col-sm-3"">
                    <div class=""form-group"">
                        <label>");
#nullable restore
#line 38 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\AccountLedger\Index.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("To Date"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                        <input type=""text"" id=""ToDate"" name=""ToDate"" class=""form-control DatePicker"">
                    </div>
                </div>
                <div class=""col-sm-4"">
                    <div class=""form-group "">
                        <label>");
#nullable restore
#line 44 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\AccountLedger\Index.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Account"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <select name=\"AccountId\" id=\"AccountId\" class=\"form-control\" required>\r\n                            <option");
            BeginWriteAttribute("value", " value=\"", 1772, "\"", 1780, 0);
            EndWriteAttribute();
            WriteLiteral(" disabled selected ></option>\r\n");
#nullable restore
#line 47 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\AccountLedger\Index.cshtml"
                             foreach (var transactionable in accountsList.Where(c => c.IsTransactionable == true))
                            {
                             

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <option");
            BeginWriteAttribute("value", " value=\"", 2021, "\"", 2055, 1);
#nullable restore
#line 50 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\AccountLedger\Index.cshtml"
WriteAttributeValue("", 2029, transactionable.AccountId, 2029, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 50 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\AccountLedger\Index.cshtml"
                                                              Write(transactionable.AccountId);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 50 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\AccountLedger\Index.cshtml"
                                                                                           Write(transactionable.AccountNameEn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 51 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\AccountLedger\Index.cshtml"
                                         
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </select>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-sm-1\">\r\n                    <button style=\"margin-top:29px\" type=\"submit\" class=\"btn btn-primary \"> ");
#nullable restore
#line 57 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\AccountLedger\Index.cshtml"
                                                                                       Write(SharedLocalizer.GetLocalizedHtmlString("Search"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                </div>\r\n            </div>\r\n        </form>\r\n    </div>\r\n    <div class=\"card-body\">\r\n        <div id=\"divList\"></div>\r\n\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        $(function () {
            $('#Accli').addClass(""menu-open"");
            $('#Reportsli').addClass(""menu-open"");
            $('#Statementsli').removeClass(""menu-open"");
            $('#AccRli').removeClass(""menu-open"");
            $('#AccPli').removeClass(""menu-open"");
            $('#Setupli').removeClass(""menu-open"");

            $('#printList').hide();

            var date = new Date();
            var dd = String(date.getDate()).padStart(2, '0');
            var mm = String(date.getMonth() + 1).padStart(2, '0')
            var yyyy = date.getFullYear();
            var premonth = parseInt(mm) - 1;
            var start = yyyy + '-' + mm + '-' + '01';
            today = yyyy + '-' + mm + '-' + dd;
            $('#FromDate').val(start);
            $('#ToDate').val(today);
            initDatePicker();

            $('#frmSearch').submit(function (e) {

                e.preventDefault();
                BindGrid();
            })

        });

        f");
                WriteLiteral(@"unction BindGrid() {

            $('#divList').html('<h5 class=""margin-0""><p><i class=""fa fa-spinner fa-spin fa-fw""></i> Please wait while data is loading...</p></h5>');
            $.ajax({
                url: getApplicationName() + 'Finance/AccountLedger/_list',
                data: $('#frmSearch').serialize(),
                success: function (data) {
                    $('#printList').show();

                    $('#divList').html(data);
                }
            })
        }

        $('#printList').click(function (e) {
            var FromDate = $('#FromDate').val();
            var ToDate = $('#ToDate').val();
            var AccountId = $('#AccountId').val();
            window.open(getApplicationName() + ""Finance/AccountLedger/PrintList?FromDate="" + FromDate + ""&ToDate="" + ToDate + ""&AccountId="" + AccountId, ""_blank"");
        });
    </script>
");
            }
            );
            WriteLiteral("\r\n");
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