using ErpOnClick.DAL.Interfaces;
using ErpOnClick.DAL.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace ErpOnClick.ErpMain.Areas.Finance.Controllers
{
    [Area("Finance")]
    [Authorize]
    public class FinancialYearController : Controller
    {
        private readonly ILogger<FinancialYearController> _logger;
        private IApplicationParameterService _ParameterService;
        

        private dynamic expObj;
        public FinancialYearController(ILogger<FinancialYearController> logger, IApplicationParameterService ParameterService, ICompanyService CompanyService)
        {
            _logger = logger;
            _ParameterService = ParameterService;
            expObj = new ExpandoObject();
        }

        public IActionResult Index()
        {
            return View(expObj);
        }

        public IActionResult _list(int ApplicationParameterId)
        {
            expObj.ApplicationParameterIdList = _ParameterService.GetAll();
            return PartialView(expObj);
        }


        public IActionResult edit(int id)
        {

            expObj.ApplicationParameterIdDetail = _ParameterService.GetAll().FirstOrDefault();
            return View(expObj);
        }


        [HttpPost]
        public ActionResult save(ApplicationParameters postedData)
        {
            DbResult result = new DbResult();
            if (ModelState.IsValid)
            {
                var item = _ParameterService.GetById(postedData.ApplicationParameterId);
                if (item != null)
                {
                    result.isError = true;
                    result.msg = "ApplicationParameters ID " + postedData.ApplicationParameterId + " is already exists !";
                }
                else
                {
                    postedData.CreatedDate = System.DateTime.Now;
                    postedData.ModifiedDate = System.DateTime.Now;
                    postedData.CreatedBy = 0;

                    result.msg = _ParameterService.Insert(postedData);
                    if (result.msg == "")
                    {
                        result.msg = _ParameterService.SaveChanges();
                    }
                    result.isError = (result.msg != "" ? true : false);

                }
            }

            return Json(new { result = result });
        }


        [HttpPost]
        public ActionResult update(ApplicationParameters postedData)
        {
            DbResult result = new DbResult();

            if (ModelState.IsValid)
            {
                postedData.ModifiedDate = System.DateTime.Now;
                postedData.ModifiedBy = 1;


                result.msg = _ParameterService.Update(postedData);
                if (result.msg == "")
                {
                    result.msg = _ParameterService.SaveChanges();
                }

                result.isError = (result.msg != "" ? true : false);
            }

            return Json(new { result = result });
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            DbResult result = new DbResult();
            var n = _ParameterService.Find(c => c.ApplicationParameterId == id).Count();
            if (n > 0)
            {
                result.isError = true;
                result.msg = "ApplicationParameters " + id + " is being used in ApplicationParameters !";
            }
            else
            {
                _ParameterService.Delete(id);

                result.msg = _ParameterService.SaveChanges();
                result.isError = (result.msg != "" ? true : false);
            }
            return Json(new { result = result });
        }



    }
}
