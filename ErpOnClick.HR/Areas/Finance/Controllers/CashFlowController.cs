using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using ErpOnClick.DAL.Common;
using ErpOnClick.DAL.Interfaces;
using ErpOnClick.DAL.Models;
using ErpOnClick.ErpMain.Models;
using ErpOnClick.ErpMain.Models.Finance;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Z.EntityFramework.Plus;

namespace ErpOnClick.ErpMain.Areas.Admin.Controllers
{
    [Area("Finance")]
    [Authorize]
    public class CashFlowController : Controller
    {
        private readonly ILogger<CashFlowController> _logger;

        private IAccountTypesService _AccountTypesService;
        private IAccountGroupsService _AccountGroupsService;
        private IBranchService _BranchService;
        private ICompanyService _CompanyService;
        private IAccountsService _accountsService;
        private IVoucherLinesService _voucherLinesService;
        private IApplicationParameterService _applicationParameterService;

        private dynamic expObj;
        public CashFlowController(ILogger<CashFlowController> logger, IVoucherLinesService voucherLinesService, IAccountsService accountsService, ICompanyService CompanyService, IBranchService BranchService, IAccountTypesService AccountTypesService, IAccountGroupsService AccountGroupsService,IApplicationParameterService applicationParameterService)
        {
            _logger = logger;

            _AccountTypesService = AccountTypesService;
            _AccountGroupsService = AccountGroupsService;
            _BranchService = BranchService;
            _CompanyService = CompanyService;
            _voucherLinesService = voucherLinesService;
            _accountsService = accountsService;
            _applicationParameterService = applicationParameterService;
            expObj = new ExpandoObject();
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult _list()
        {
            //expObj.financialPositionViewModel = GenerateReportForFinancialPosition();

            return PartialView();
        }

        public IActionResult PrintList()
        {
            //expObj.financialPositionViewModel = GenerateReportForFinancialPosition();
            expObj.CompanyDetail = _CompanyService.GetAll().FirstOrDefault();

            return PartialView(expObj);
        }

        public List<FinancialPositionViewModel> GenerateReportForFinancialPosition()
        {
            var applicationParameters = _applicationParameterService.GetAll().FirstOrDefault();
            if (applicationParameters == null)
            {
                applicationParameters = new ApplicationParameters();
            }
            List<FinancialPositionViewModel> financialPositionViewModel = new List<FinancialPositionViewModel>();
            List<VoucherLines> voucherLines = _voucherLinesService.dbset().IncludeOptimized(x => x.Account.ParentAccount.ParentAccount).ToList();

            List<Accounts> accouts = _accountsService.dbset().IncludeOptimized(c => c.ParentAccount.ParentAccount).ToList();

            #region MakingReportForFinancialPosition

            #endregion

            return financialPositionViewModel;
        }


    }
}
