﻿using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using ErpOnClick.DAL.Interfaces;
using ErpOnClick.DAL.Models;
using ErpOnClick.DAL.Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ErpOnClick.DAL.Utilities;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.AspNetCore.Hosting;


namespace ErpOnClick.ErpMain.Areas.ESS.Controllers
{

    public class EmpBanksController : BaseController
    {
        private readonly ILogger<EmpBanksController> _logger;
        private IEmpBankService _EmpBanksService;
        private IEmpsService _EmpService;
        private ILookupsService _LookupService;
        private IBranchService _BranchService;
        private ICompanyService _CompanyService;
        public static IWebHostEnvironment _HostEnvironment;
        private IUserService _UserService;

        private dynamic expObj;
        public EmpBanksController(IUserService UserService,ILogger<EmpBanksController> logger, IWebHostEnvironment HostEnvironment,   IBranchService BranchService, ICompanyService CompanyService, IEmpBankService EmpBanksService, IEmpsService EmpService, ILookupsService LookupService, ILookupTypesService LookupTypesService)
        {
            _logger = logger;
            _UserService = UserService;
            _EmpBanksService = EmpBanksService;
            _EmpService = EmpService;
            _LookupService = LookupService;
            _CompanyService = CompanyService;
            _BranchService = BranchService;
            _HostEnvironment = HostEnvironment;

            expObj = new ExpandoObject();
        }


        [Route("{area}/{controller}/emp/{empId}")]
        public IActionResult Index(int empId = 0)
        {
            var lookupList = _LookupService.GetAll();
            expObj.ownerTypeList = lookupList.Where(x => x.LookupTypeId == LookupTypList.OwnerType_009).ToList();
            expObj.empId = empId;
            expObj.empDetails = _EmpService.GetById(empId);

            return View(expObj);
        }

        public IActionResult _list(int empId)
        {
            expObj.empId = empId;
            expObj.EmpBanksList = _EmpBanksService.Find(x => x.EmpId == empId).ToList();
            return PartialView(expObj);
        }


        [Route("{area}/{controller}/view/emp/{empId}/{id=0}")]
        public async Task<IActionResult> view(int empId, int id)
        {
            var lookupList = _LookupService.GetAll();

            expObj.banksList = lookupList.Where(x => x.LookupTypeId == LookupTypList.Banks_016).ToList();

            expObj.branchList = _BranchService.GetAll();
            expObj.companyList = _CompanyService.GetAll();
            expObj.empList = _EmpService.Find(c => c.EmpId == empId).ToList();


            expObj.EmpBanksDetails = _EmpBanksService.GetById(id);
            expObj.empDetails = _EmpService.GetById(empId);
            expObj.empId = empId;


            return View(expObj);
        }


    }
}
