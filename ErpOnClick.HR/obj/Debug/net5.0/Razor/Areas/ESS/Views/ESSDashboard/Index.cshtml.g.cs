#pragma checksum "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\ESSDashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69a608c5cf68a8f37a759977dee53f239910fdd9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_ESS_Views_ESSDashboard_Index), @"mvc.1.0.view", @"/Areas/ESS/Views/ESSDashboard/Index.cshtml")]
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
#line 1 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\ESSDashboard\Index.cshtml"
using ErpOnClick.ErpMain.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69a608c5cf68a8f37a759977dee53f239910fdd9", @"/Areas/ESS/Views/ESSDashboard/Index.cshtml")]
    public class Areas_ESS_Views_ESSDashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div id=\"main\" role=\"main\">\r\n\r\n    <!-- #MAIN CONTENT -->\r\n    <div>\r\n        <div class=\"outer-block\">\r\n\r\n            <div class=\"items colBG\">\r\n                <h4> ");
#nullable restore
#line 11 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\ESSDashboard\Index.cshtml"
                Write(SharedLocalizer.GetLocalizedHtmlString("Salaries"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                <div class=\"clearfix margin-5\"></div>\r\n                <div style=\"height:350px\">\r\n                    <div class=\"chartjs-size-monitor\"><div class=\"chartjs-size-monitor-expand\"><div");
            BeginWriteAttribute("class", " class=\"", 498, "\"", 506, 0);
            EndWriteAttribute();
            WriteLiteral("></div></div><div class=\"chartjs-size-monitor-shrink\"><div");
            BeginWriteAttribute("class", " class=\"", 565, "\"", 573, 0);
            EndWriteAttribute();
            WriteLiteral(@"></div></div></div>
                    <canvas id=""chartAging"" width=""399"" height=""350"" class=""chartjs-render-monitor"" style=""display: block; width: 399px; height: 350px;""></canvas>
                </div>
            </div>

            <div class=""items colSM"">
                <a href=""/Admin/Customers""><h4> ");
#nullable restore
#line 20 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\ESSDashboard\Index.cshtml"
                                           Write(SharedLocalizer.GetLocalizedHtmlString("Employees"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4></a>
                <div class=""pull-left "" style=""width:50%"">

                    <div class=""margin-top-25"">&nbsp;</div>
                    <h1 class=""text-center "" style=""line-height:30px"" title=""Total Customers"">
                        55
                        <small><br>50 ");
#nullable restore
#line 26 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\ESSDashboard\Index.cshtml"
                                 Write(SharedLocalizer.GetLocalizedHtmlString("Active"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" | 5 ");
#nullable restore
#line 26 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\ESSDashboard\Index.cshtml"
                                                                                       Write(SharedLocalizer.GetLocalizedHtmlString("Non Active"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</small>
                    </h1>
                </div>
                <div class=""pull-right "" style=""width:50%"">

                    <div style=""height:140px"">
                        <div class=""chartjs-size-monitor""><div class=""chartjs-size-monitor-expand""><div");
            BeginWriteAttribute("class", " class=\"", 1622, "\"", 1630, 0);
            EndWriteAttribute();
            WriteLiteral("></div></div><div class=\"chartjs-size-monitor-shrink\"><div");
            BeginWriteAttribute("class", " class=\"", 1689, "\"", 1697, 0);
            EndWriteAttribute();
            WriteLiteral(@"></div></div></div>
                        <canvas id=""chartCustomers"" width=""200"" height=""140"" class=""chartjs-render-monitor"" style=""display: block; width: 200px; height: 140px;""></canvas>
                    </div>
                </div>
            </div>



            <div class=""items colBG"">
                <h4>");
#nullable restore
#line 41 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\ESSDashboard\Index.cshtml"
               Write(SharedLocalizer.GetLocalizedHtmlString("Attendance"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                <div class=\"clearfix margin-5\"></div>\r\n                <div style=\"height:350px\">\r\n                    <div class=\"chartjs-size-monitor\"><div class=\"chartjs-size-monitor-expand\"><div");
            BeginWriteAttribute("class", " class=\"", 2286, "\"", 2294, 0);
            EndWriteAttribute();
            WriteLiteral("></div></div><div class=\"chartjs-size-monitor-shrink\"><div");
            BeginWriteAttribute("class", " class=\"", 2353, "\"", 2361, 0);
            EndWriteAttribute();
            WriteLiteral(@"></div></div></div>
                    <canvas id=""chartGeneralEntries"" style=""display: block; width: 399px; height: 350px;"" width=""399"" height=""350"" class=""chartjs-render-monitor""></canvas>
                </div>
            </div>

            <div class=""items colSM"">

                <a href=""/Admin/Vendors""><h4>");
#nullable restore
#line 51 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\ESSDashboard\Index.cshtml"
                                        Write(SharedLocalizer.GetLocalizedHtmlString("Profile"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4></a>
                <div class=""pull-left "" style=""width:50%"">

                    <div class=""margin-top-25"">&nbsp;</div>
                    <h1 class=""text-center "" style=""line-height:30px"" title=""Total Vendors"">
                        1
                        <small><br>1 ");
#nullable restore
#line 57 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\ESSDashboard\Index.cshtml"
                                Write(SharedLocalizer.GetLocalizedHtmlString("Active"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" | 0 ");
#nullable restore
#line 57 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\ESSDashboard\Index.cshtml"
                                                                                      Write(SharedLocalizer.GetLocalizedHtmlString("Non Active"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</small>
                    </h1>
                </div>
                <div class=""pull-right "" style=""width:50%"">

                    <div style=""height:140px"">
                        <div class=""chartjs-size-monitor""><div class=""chartjs-size-monitor-expand""><div");
            BeginWriteAttribute("class", " class=\"", 3412, "\"", 3420, 0);
            EndWriteAttribute();
            WriteLiteral("></div></div><div class=\"chartjs-size-monitor-shrink\"><div");
            BeginWriteAttribute("class", " class=\"", 3479, "\"", 3487, 0);
            EndWriteAttribute();
            WriteLiteral(@"></div></div></div>
                        <canvas id=""chartVendors"" width=""200"" height=""140"" class=""chartjs-render-monitor"" style=""display: block; width: 200px; height: 140px;""></canvas>
                    </div>
                </div>
            </div>






            <div class=""items colBG"">
                <h4>");
#nullable restore
#line 75 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\ESSDashboard\Index.cshtml"
               Write(SharedLocalizer.GetLocalizedHtmlString("Documents"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                <div class=\"clearfix margin-5\"></div>\r\n                <div style=\"height:340px\">\r\n                    <div class=\"chartjs-size-monitor\"><div class=\"chartjs-size-monitor-expand\"><div");
            BeginWriteAttribute("class", " class=\"", 4079, "\"", 4087, 0);
            EndWriteAttribute();
            WriteLiteral("></div></div><div class=\"chartjs-size-monitor-shrink\"><div");
            BeginWriteAttribute("class", " class=\"", 4146, "\"", 4154, 0);
            EndWriteAttribute();
            WriteLiteral(@"></div></div></div>
                    <canvas id=""chartServices"" width=""399"" height=""340"" class=""chartjs-render-monitor"" style=""display: block; width: 399px; height: 340px;""></canvas>
                </div>
            </div>

            <div class=""items colSM"">

                <a href=""/demo_erp/reports/rpttimesheet""><h4>");
#nullable restore
#line 85 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\ESSDashboard\Index.cshtml"
                                                        Write(SharedLocalizer.GetLocalizedHtmlString("Timesheets"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </h4></a>
                <div class=""pull-left "" style=""width:50%"">

                    <div class=""margin-top-25"">&nbsp;</div>
                    <h1 class=""text-center "" style=""line-height:30px"" title=""Submitted Timesheets"">
                        0
                        <small title=""Pending Timesheets""><br>2 ");
#nullable restore
#line 91 "C:\Users\SGH\OneDrive\Documents\Github\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\ESSDashboard\Index.cshtml"
                                                           Write(SharedLocalizer.GetLocalizedHtmlString("Pending"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</small>
                    </h1>
                </div>
                <div class=""pull-right "" style=""width:50%"">

                    <div style=""height:140px"">
                        <div class=""chartjs-size-monitor""><div class=""chartjs-size-monitor-expand""><div");
            BeginWriteAttribute("class", " class=\"", 5196, "\"", 5204, 0);
            EndWriteAttribute();
            WriteLiteral("></div></div><div class=\"chartjs-size-monitor-shrink\"><div");
            BeginWriteAttribute("class", " class=\"", 5263, "\"", 5271, 0);
            EndWriteAttribute();
            WriteLiteral(@"></div></div></div>
                        <canvas id=""chartTimesheet"" width=""200"" height=""140"" class=""chartjs-render-monitor"" style=""display: block; width: 200px; height: 140px;""></canvas>
                    </div>
                </div>
            </div>



        </div>


        <style type=""text/css"">

            /* Chart.js */
            ");
            WriteLiteral(@"@keyframes chartjs-render-animation {
                from {
                    opacity: .99
                }

                to {
                    opacity: 1
                }
            }

            .chartjs-render-monitor {
                animation: chartjs-render-animation 1ms
            }

            .chartjs-size-monitor, .chartjs-size-monitor-expand, .chartjs-size-monitor-shrink {
                position: absolute;
                direction: ltr;
                left: 0;
                top: 0;
                right: 0;
                bottom: 0;
                overflow: hidden;
                pointer-events: none;
                visibility: hidden;
                z-index: -1
            }

                .chartjs-size-monitor-expand > div {
                    position: absolute;
                    width: 1000000px;
                    height: 1000000px;
                    left: 0;
                    top: 0
                }

                .cha");
            WriteLiteral(@"rtjs-size-monitor-shrink > div {
                    position: absolute;
                    width: 200%;
                    height: 200%;
                    left: 0;
                    top: 0
                }
        </style>





        <style>

            body {
                background-color: #e5e5e5 !important;
            }

            .colSM {
                height: 200px;
            }

            .colBG {
                height: 415px;
            }

            ");
            WriteLiteral(@"@media only screen and (min-device-width: 768px) {
                .outer-block {
                    -moz-column-count: 3;
                    -webkit-column-count: 3;
                    column-count: 3;
                    -moz-column-gap: 1em;
                    -webkit-column-gap: 1em;
                    column-gap: 1em;
                }
            }

            .items {
                display: inline-block;
                margin: 0 0 1em;
                width: 100%;
                background-color: #FFF;
                padding: 10px 10px;
            }

                .items h4 {
                    font-size: 1.3em;
                    font-weight: 600;
                    color: #345b90;
                    border-bottom: 2px solid whitesmoke;
                    padding-bottom: 10px;
                    text-transform: uppercase;
                }

                .items h1 {
                    font-size: 5em;
                    font-weight: 500;
          ");
            WriteLiteral(@"          color: #9a9a9a;
                }

                .items .align-text-bottom {
                }

            .pull-left {
                float: left !important;
            }

            .pull-right {
                float: right !important;
            }

            .margin-top-25 {
                margin-top: 25px !important
            }

            h1 small {
                font-size: 18px;
                font-weight: 300;
                letter-spacing: -1px;
            }
        </style>



    </div>
    <!-- end row -->
    <!-- END #MAIN CONTENT -->

</div>


");
            DefineSection("scripts", async() => {
                WriteLiteral(@"

    <script>
        $(document).ready(function () {
            initChartGeneralEntries();
            initChartServices();
            initChartVendors();
            initChartCustomers();
            initChartAging();
            initChartTimesheet();
        })


        function initChartGeneralEntries() {
            var ctx = document.getElementById('chartGeneralEntries').getContext('2d');
            var chart = new Chart(ctx, {
                // The type of chart we want to create
                type: 'line',

                // The data for our dataset
                data: {
                    labels: ['January', 'February', 'March', 'April', 'May', 'June', 'July', 'August', 'September', 'Octuber', 'November', 'December'],
                    datasets: [{
                        label: 'GeneralEntries',
                        backgroundColor: '#b3c3ea',
                        borderColor: '#4679cc',
                        data: [0, 10, 5, 2, 20, 30, 45, 50, 55, 45,");
                WriteLiteral(@" 65, 50, 75, 90]
                    }]
                },

                // Configuration options go here
                options: {
                    maintainAspectRatio: false,
                }
            });

        }


        function initChartServices() {
            var ctx = document.getElementById('chartServices').getContext('2d');
            var chart = new Chart(ctx, {
                // The type of chart we want to create
                type: 'pie',

                // The data for our dataset
                data: {
                    labels: ['ID Card', 'Passport', 'Contract', 'Birth Certificate', 'Insurance'],
                    datasets: [{
                        label: 'Sales',
                        backgroundColor: ['#a1b7d4', '#345b90', '#4679cc', '#5883bb', '#538ae4'],
                        //backgroundColor: ['#5D9CEC','#48CFAD','#A0D468','#6bafae','#ffe500'],
                        borderColor: 'white',
                        data: [20, 15, 1");
                WriteLiteral(@"5, 20, 35]
                    }]
                },

                // Configuration options go here
                options: {
                    maintainAspectRatio: false,
                }
            });

        }


        function initChartVendors() {
            var ctx = document.getElementById('chartVendors').getContext('2d');
            var chart = new Chart(ctx, {
                // The type of chart we want to create
                type: 'doughnut',

                // The data for our dataset
                data: {
                    labels: ['Active', 'Non-Active'],
                    datasets: [{
                        label: 'Status',
                        backgroundColor: ['#4679cc', '#b3c3ea'],
                        borderColor: 'white',
                        data: [1, 0]
                    }]
                },

                // Configuration options go here
                options: {
                    maintainAspectRatio: false,
      ");
                WriteLiteral(@"          }
            });

        }



        function initChartCustomers() {
            var ctx = document.getElementById('chartCustomers').getContext('2d');
            var chart = new Chart(ctx, {
                // The type of chart we want to create
                type: 'doughnut',

                // The data for our dataset
                data: {
                    labels: ['Active', 'Non-Active'],
                    datasets: [{
                        label: 'Status',
                        backgroundColor: ['#4679cc', '#b3c3ea'],
                        borderColor: 'white',
                        data: [50, 5]
                    }]
                },

                // Configuration options go here
                options: {
                    maintainAspectRatio: false,
                }
            });

        }


        function initChartTimesheet() {
            var ctx = document.getElementById('chartTimesheet').getContext('2d');
            v");
                WriteLiteral(@"ar chart = new Chart(ctx, {
                // The type of chart we want to create
                type: 'doughnut',

                // The data for our dataset
                data: {
                    labels: ['Submitted', 'Pending'],
                    datasets: [{
                        label: 'Pending',
                        backgroundColor: ['#4679cc', '#b3c3ea'],
                        borderColor: 'white',
                        data: [0, 2]
                    }]
                },

                // Configuration options go here
                options: {
                    maintainAspectRatio: false,
                }
            });

        }



        function initChartAging() {
            var ctx = document.getElementById('chartAging').getContext('2d');
            var chart = new Chart(ctx, {
                // The type of chart we want to create
                type: 'bar',

                // The data for our dataset
                data: {
     ");
                WriteLiteral(@"               labels: ['0 Days', '15 Days', '30 Days', '45 Days', '60 Days', '90 Days', '120 Days'],
                    datasets: [{
                        label: 'Due',
                        backgroundColor: ['#a1b7d4', '#345b90', '#4679cc', '#5883bb', '#538ae4', '#90bdfd', '#506d9c'],
                        data: [1500, 2000, 13000, 25000, 35000, 7000, 20000, 10000]
                    }]
                },

                // Configuration options go here
                options: {
                    maintainAspectRatio: false,
                }
            });

        }

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
