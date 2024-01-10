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
    public class ReceiptsController : Controller
    {
        private readonly ILogger<ReceiptsController> _logger;
        private IAccountsService _AccountsService;
        private IReceiptsService _ReceiptsService;
        private ICustomersService _CustomersService;
        private IBranchService _BranchService;
        private ICompanyService _CompanyService;
        private IUserService _UserService;

        private dynamic expObj;
        public ReceiptsController(IUserService UserService,ILogger<ReceiptsController> logger, IAccountsService AccountsService, IReceiptsService ReceiptsService, ICompanyService CompanyService, IBranchService BranchService, ICustomersService CustomersService)
        {
            _logger = logger;
            _UserService = UserService;
            _AccountsService = AccountsService;
            _CustomersService = CustomersService;
            _ReceiptsService = ReceiptsService;
            _BranchService = BranchService;
            _CompanyService = CompanyService;
            expObj = new ExpandoObject();
        }


        public IActionResult Index()
        {
            expObj.customersList = _CustomersService.GetAll();
            return View(expObj);
        }

        public IActionResult _list(DateTime ReceiptsDateFrom, DateTime ReceiptsDateTo, int CustomerId)
        {
            string receiptsdatefrom = ReceiptsDateFrom.ToString("yyyy-MM-dd");
            string receiptsdateto = ReceiptsDateTo.ToString("yyyy-MM-dd");
            expObj.receiptsMList = _ReceiptsService.dbset()
                .IncludeOptimized(c => c.Customer)
                .Where(c => (c.CustomerId == CustomerId || CustomerId == 0)
                && (receiptsdatefrom != "0001-01-01" && c.ReceiptDate >= Convert.ToDateTime(receiptsdatefrom) || receiptsdatefrom == "0001-01-01")
                && (receiptsdateto != "0001-01-01" && c.ReceiptDate <= Convert.ToDateTime(receiptsdateto) || receiptsdateto == "0001-01-01"))
                .ToList();
            return PartialView(expObj);
        }

        public IActionResult edit(int id)
        {
            expObj.receiptNo = 0;
            expObj.Accounts = _AccountsService.dbset().Where(c => c.IsTransactionable == true).ToList();
            expObj.CompanyDetail = _CompanyService.GetAll();
            expObj.Customers = _CustomersService.GetAll();
            expObj.IdDetail = _ReceiptsService.GetById(id);
            if (expObj.IdDetail != null)
            {
                int compnayid = Convert.ToInt32(expObj.IdDetail.CompanyId);
                expObj.branchList = _BranchService.Find(c => c.CompanyId == compnayid).ToList();
            }
            else
            {
                expObj.branchList = _BranchService.GetAll();
            }

            if (id == 0 && _ReceiptsService.GetAll() != null && _ReceiptsService.GetAll().ToList() != null && _ReceiptsService.GetAll().ToList().Count > 0)
            {
                
                expObj.receiptNo = (_ReceiptsService.GetAll().ToList().Max(x => x.ReceiptId) + 1).ToString("00000");
            }
            else if (id == 0)
            {
                expObj.receiptNo = "00001";
            }

            return View(expObj);
        }


        public IActionResult PrintList(DateTime ReceiptsDateFrom, DateTime ReceiptsDateTo, int CustomerId)
        {
            string receiptsdatefrom = ReceiptsDateFrom.ToString("yyyy-MM-dd");
            string receiptsdateto = ReceiptsDateTo.ToString("yyyy-MM-dd");

            expObj.ReceiptsDateFrom = ReceiptsDateFrom.ToString("yyyy-MM-dd");
            expObj.ReceiptsDateTo = ReceiptsDateTo.ToString("yyyy-MM-dd");
            if (CustomerId == 0)
            {
                expObj.CustomerId = "All";
            }
            else
            {
                expObj.CustomerId = _CustomersService.GetById(CustomerId).CustomerNameEn;
            }

            expObj.receiptsList = _ReceiptsService.dbset()
                .IncludeOptimized(c => c.Customer)
                .Where(c => (c.CustomerId == CustomerId || CustomerId == 0)
                && (receiptsdatefrom != "0001-01-01" && c.ReceiptDate >= Convert.ToDateTime(receiptsdatefrom) || receiptsdatefrom == "0001-01-01")
                && (receiptsdateto != "0001-01-01" && c.ReceiptDate <= Convert.ToDateTime(receiptsdateto) || receiptsdateto == "0001-01-01"))
                .ToList();
            expObj.CompanyDetail = _CompanyService.GetAll().FirstOrDefault();
            return View(expObj);
        }

        [HttpPost]
        public ActionResult save(Receipts postedData)
        {
            DbResult result = new DbResult();
            if (ModelState.IsValid)
            {
                var EmpId = Convert.ToInt32(User.Identity.Name);
                var user = _UserService.dbset().Where(c => c.UserId == EmpId).FirstOrDefault();
                postedData.CompanyId = user.CompanyId;
                postedData.BranchId = user.BranchId;
                postedData.CreatedDate = System.DateTime.Now;
                postedData.CreatedBy = 1;
                postedData.PortalId = 0;

                result.msg = _ReceiptsService.Insert(postedData);
                if (result.msg == "")
                {
                    result.msg = _ReceiptsService.SaveChanges();
                    result.scalerVal = postedData.ReceiptId;
                }
                result.isError = (result.msg != "" ? true : false);
            }
            return Json(new { result = result });
        }

        [HttpPost]
        public ActionResult update(Receipts postedData)
        {
            DbResult result = new DbResult();
            if (ModelState.IsValid)
            {
                postedData.ModifiedDate = System.DateTime.Now;
                postedData.ModifiedBy = 1;

                result.msg = _ReceiptsService.Update(postedData);
                if (result.msg == "")
                {
                    result.msg = _ReceiptsService.SaveChanges();
                    result.scalerVal = postedData.ReceiptId;
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
                _ReceiptsService.Delete(id);
                result.msg = _ReceiptsService.SaveChanges();
                result.isError = (result.msg != "" ? true : false);
            }
            else
                result.msg = "Id is null";
            return Json(new { result = result });
        }
    }
}