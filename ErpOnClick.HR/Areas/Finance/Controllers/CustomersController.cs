﻿using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using ErpOnClick.DAL.Common;
using ErpOnClick.DAL.Interfaces;
using ErpOnClick.DAL.Models;
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
    public class CustomersController : Controller
    {
        private readonly ILogger<CustomersController> _logger;
        private ICustomersService _CustomersService;
        private IAccountsService _AccountsService;
        private ILookupsService _LookupService;
        private IBranchService _BranchService;
        private ICompanyService _CompanyService;
        private IUserService _UserService;

        private dynamic expObj;
        public CustomersController(IUserService UserService,ILogger<CustomersController> logger, ICompanyService CompanyService, IBranchService BranchService, ILookupsService LookupTypesService, ICustomersService CustomersService, IAccountsService AccountsService)
        {
            _logger = logger;
            _UserService = UserService;
            _CustomersService = CustomersService;
            _AccountsService = AccountsService;
            _LookupService = LookupTypesService;
            _BranchService = BranchService;
            _CompanyService = CompanyService;
            expObj = new ExpandoObject();
        }


        public IActionResult Index()
        {
            var lookupList = _LookupService.GetAll();

            expObj.Accounts = _AccountsService.GetAll(); 
            expObj.ActiveStatus = lookupList.Where(x => x.LookupTypeId == LookupTypList.ActiveStatus_015).ToList();

            return View(expObj);
        }

        public IActionResult _list(int AccountId, string Status)
        {
            expObj.CustomerIdList = _CustomersService.dbset()
                .IncludeOptimized(c => c.Account)
                .Where(c => (c.AccountId == AccountId || AccountId == 0)
                && (Status != null && c.ActiveStatus == Status || Status == null))
                .ToList();
            return PartialView(expObj);
        }

        public IActionResult PrintList(int AccountId, string Status)
        {
            expObj.CustomerIdList = _CustomersService.dbset()
                .IncludeOptimized(c => c.Account)
                .Where(c => (c.AccountId == AccountId || AccountId == 0)
                && (Status != null && c.ActiveStatus == Status || Status == null))
                .ToList();

            if(AccountId == 0)
            {
                expObj.AccountId = "All";
            }
            else
            {
                expObj.AccountId = _AccountsService.GetById(AccountId).AccountNameEn;
            }
            if (Status== null)
            {
                expObj.Status = "All";
            }
            else
            {
                expObj.Status = Status;
            }

            expObj.CompanyDetail = _CompanyService.GetAll().FirstOrDefault();
            return PartialView(expObj);
        }

        public IActionResult edit(int id)
        {
            var lookupList = _LookupService.GetAll();
            expObj.ActiveStatus = lookupList.Where(x => x.LookupTypeId == LookupTypList.ActiveStatus_015).ToList();
            expObj.City = lookupList.Where(x => x.LookupTypeId == LookupTypList.City_005).ToList();
            expObj.Country = lookupList.Where(x => x.LookupTypeId == LookupTypList.Country_004).ToList();
            expObj.State = lookupList.Where(x => x.LookupTypeId == LookupTypList.State_028).ToList();
            //expObj.Accounts = _AccountsService.GetAll();
            expObj.Accounts = _AccountsService.dbset().Where(c => c.IsTransactionable == true).ToList();
            expObj.CompanyDetail = _CompanyService.GetAll();
            expObj.IdDetail = _CustomersService.GetById(id);
            if (expObj.IdDetail != null)
            {
                int compnayid = Convert.ToInt32(expObj.IdDetail.CompanyId);
                expObj.branchList = _BranchService.Find(c => c.CompanyId == compnayid).ToList();
            }
            else
            {
                expObj.branchList = _BranchService.GetAll();
            }
            return View(expObj);
        }


        [HttpPost]
        public ActionResult save(Customers postedData)
        {

            DbResult result = new DbResult();
            if (ModelState.IsValid)
            {
                var EmpId = Convert.ToInt32(User.Identity.Name);
                var user = _UserService.dbset().Where(c => c.UserId == EmpId).FirstOrDefault();
                postedData.CreatedDate = System.DateTime.Now;
                postedData.CreatedBy = 1;
                postedData.PortalId = 0;
                postedData.CompanyId = user.CompanyId;
                postedData.BranchId = user.BranchId;
                result.msg = _CustomersService.Insert(postedData);
                if (result.msg == "")
                {
                    result.msg = _CustomersService.SaveChanges();
                    result.scalerVal = postedData.CustomerId;
                }
                result.isError = (result.msg != "" ? true : false);

            }
            return Json(new { result = result });
        }

        [HttpPost]
        public ActionResult update(Customers postedData)
        {

            DbResult result = new DbResult();

            if (ModelState.IsValid)
            {

                postedData.ModifiedDate = System.DateTime.Now;
                postedData.ModifiedBy = 1;


                result.msg = _CustomersService.Update(postedData);
                if (result.msg == "")
                {
                    result.msg = _CustomersService.SaveChanges();
                    result.scalerVal = postedData.CustomerId;
                }

                result.isError = (result.msg != "" ? true : false);
            }

            return Json(new { result = result });
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            DbResult result = new DbResult();

            if (id != 0)
            {
                _CustomersService.Delete(id);
                result.msg = _CustomersService.SaveChanges();
                result.isError = (result.msg != "" ? true : false);
            }
            else
                result.msg = "Id is null";


            return Json(new { result = result });
        }

    }
}
