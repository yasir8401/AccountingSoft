using ErpOnClick.DAL.Interfaces;
using ErpOnClick.ErpMain.ViewModel;
using ExcelDataReader;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Z.EntityFramework.Plus;

namespace ErpOnClick.ErpMain.Areas.Finance.Controllers
{
    [Area("Finance")]
    [Authorize]
    public class COASettingsController : Controller
    {
        private readonly ILogger<COASettingsController> _logger;
        private IAccountsService _AccountsService;
        private IAccountTypesService _AccountTypesService;
        private IAccountGroupsService _AccountGroupsService;
        private IBranchService _BranchService;
        private ICompanyService _CompanyService;
        private IVoucherLinesService _VoucherLinesService;
        private ILookupsService _LookupsService;

        public static IWebHostEnvironment _HostEnvironment;
        public static IHostingEnvironment _env;


        string wwwRootPath = "";
        private dynamic expObj;
        public COASettingsController(IHostingEnvironment env, IWebHostEnvironment HostEnvironment, IVoucherLinesService VoucherLinesService, ILogger<COASettingsController> logger, ICompanyService CompanyService, IBranchService BranchService, IAccountsService AccountsService, IAccountTypesService AccountTypesService, IAccountGroupsService AccountGroupsService, ILookupsService lookupsService)
        {
            _env = env;

            _logger = logger;
            _AccountsService = AccountsService;
            _AccountTypesService = AccountTypesService;
            _AccountGroupsService = AccountGroupsService;
            _BranchService = BranchService;
            _CompanyService = CompanyService;
            _VoucherLinesService = VoucherLinesService;
            _LookupsService = lookupsService;

            wwwRootPath = HostEnvironment.WebRootPath;
            _HostEnvironment = HostEnvironment;


            expObj = new ExpandoObject();
        }
        public IActionResult Index(string filename = "charts_of_accounts_xc.xlsx")
        {
            List<importData> datas = new List<importData>();

            expObj.Accounts = _AccountsService.dbset().IncludeOptimized(c => c.AccountType.ParentAccountType.ParentAccountType).Where(x => x.Deleted == false).OrderBy(x => x.AccountCode).ToList();
            expObj.AccountTypes = _AccountTypesService.GetAll().ToList();
            if (filename == "")
            {
                System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
                using (var stream = System.IO.File.Open(wwwRootPath + "/Files/" + filename, FileMode.Open, FileAccess.Read))
                {
                    using (var reader = ExcelReaderFactory.CreateReader(stream))
                    {
                        while (reader.Read())
                        {
                            if (reader.GetValue(0).ToString() == "Code" && reader.GetValue(1).ToString() == "Name" && reader.GetValue(2).ToString() == "Level" && reader.GetValue(3).ToString() == "Nature" && reader.GetValue(4).ToString() == "Opening_Balance" && reader.GetValue(5).ToString() == "Closing_Balance")
                            {
                            }
                            else
                            {
                                datas.Add(new importData
                                {
                                    Code = reader.GetValue(0).ToString(),
                                    Name = reader.GetValue(1).ToString(),
                                    Level = reader.GetValue(2).ToString(),
                                    Nature = reader.GetValue(3).ToString(),
                                    OpeningBalance = Convert.ToDecimal(reader.GetValue(4)),
                                    Balance = Convert.ToDecimal(reader.GetValue(5))
                                });
                            }
                        }
                    }
                }
            }
            expObj.importedData = datas;
            return View(expObj);
            //return View();
        }
    }
}
