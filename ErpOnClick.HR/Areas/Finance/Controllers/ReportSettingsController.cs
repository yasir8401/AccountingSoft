using ErpOnClick.DAL.Interfaces;
using ErpOnClick.DAL.Models;
using ErpOnClick.DAL.Utilities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
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
    public class ReportSettingsController : Controller
    {
        private readonly ILogger<ReportSettingsController> _logger;
        private IApplicationParameterService _ParameterService;
        public static IWebHostEnvironment _HostEnvironment;


        private dynamic expObj;
        public ReportSettingsController(ILogger<ReportSettingsController> logger, IApplicationParameterService ParameterService
            , IWebHostEnvironment HostEnvironment)
        {
            _logger = logger;
            _ParameterService = ParameterService;
            _HostEnvironment = HostEnvironment;
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
        public async Task<ActionResult> save(ApplicationParameterInherited postedData)
        {
            var filename = "";
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

                    filename = new Guid().ToString();//lookups.Where(c => c.Code == postedData.DocOwnerType).FirstOrDefault().LookupNameEn + "_" + lookups.Where(c => c.Code == postedData.DocType).FirstOrDefault().LookupNameEn + "_" + postedData.DocOwnerId;
                    postedData.CreatedDate = System.DateTime.Now;
                    postedData.CreatedBy = 0;
                    var filePath = await FileHandling.UploadDoc(_HostEnvironment, postedData.FileToUpload, filename);
                    if (!String.IsNullOrWhiteSpace(filePath))
                    {
                        postedData.CompanyLogoUrl = filePath;
                    }

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
        public async Task<ActionResult> update(ApplicationParameterInherited postedData)
        {
            DbResult result = new DbResult();

            if (ModelState.IsValid)
            {
                postedData.ModifiedDate = System.DateTime.Now;
                postedData.ModifiedBy = 1;

                

                var filename =  Guid.NewGuid().ToString();
                postedData.CreatedDate = System.DateTime.Now;
                postedData.CreatedBy = 0;
                var filePath = await FileHandling.UploadDoc(_HostEnvironment, postedData.FileToUpload, filename);
                if (!String.IsNullOrWhiteSpace(filePath))
                {
                    postedData.CompanyLogoUrl = filePath;
                }
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
