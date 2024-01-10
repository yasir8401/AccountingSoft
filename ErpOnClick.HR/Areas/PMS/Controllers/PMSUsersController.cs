using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using ErpOnClick.DAL.Interfaces.PMS;
using ErpOnClick.DAL.Models;
using ErpOnClick.DAL.Utilities;
using ErpOnClick.ErpMain.Areas.PMS.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace PMS.Areas.Admin.Controllers
{
    [Area("PMS")]
    [Authorize(Roles = "SuperAdmin,Manager")]

    public class PMSUsersController : Controller
    {
        private readonly ILogger<PMSUsersController> _logger;
        private IPMSCompanyService _CompanyService;
        private IPMSUserService _UserService;
        private IPMSProjectTeamService _ProjectTeamService;
        public static IWebHostEnvironment _HostEnvironment;


        private ERPonClickContext _db;


        private dynamic expObj;
        public PMSUsersController(ILogger<PMSUsersController> logger, ERPonClickContext db, IPMSProjectTeamService ProjectTeamService, IPMSCompanyService CompanyService, IPMSUserService UserService, IWebHostEnvironment HostEnvironment)
        {
            _logger = logger;
            this._ProjectTeamService = ProjectTeamService;
            this._CompanyService = CompanyService;
            this._UserService = UserService;
            _HostEnvironment = HostEnvironment;


            _db = db;

            expObj = new ExpandoObject();
        }
        public IActionResult Index()
        {
            var userid = User.Claims.FirstOrDefault(c => c.Type == "UserId").Value;
            var role = User.Claims.FirstOrDefault(c => c.Type == System.Security.Claims.ClaimTypes.Role).Value;
            if (role == "SuperAdmin")
            {
                expObj.companies = _CompanyService.dbset().ToList();
            }
            else if (role == "Manager")
            {
                expObj.companies = _ProjectTeamService.dbset().Where(c => c.ProjectUserId == Convert.ToInt32(userid)).Include(c => c.Project.Company).Select(c => c.Project.Company).ToList();
            }
            return View(expObj);
        }

        public IActionResult _list(int Company)
        {
            var userid = User.Claims.FirstOrDefault(c => c.Type == "UserId").Value;
            var user = _UserService.dbset().Where(c => c.UserId == Convert.ToInt32(userid)).FirstOrDefault();
            var role = User.Claims.FirstOrDefault(c => c.Type == System.Security.Claims.ClaimTypes.Role).Value;
            if (role == "SuperAdmin")
            {
                expObj.Users = _UserService.dbset().Where(c => (Company == 0 ? Company == 0 : c.CompanyId == Company)).Include(c => c.Company).Include(c => c.UserManager).ToList();
            }
            else if (role == "Manager")
            {
                expObj.Users = _UserService.dbset().Where(c => c.CompanyId != null && c.CompanyId == user.CompanyId).Include(c => c.Company).Include(c => c.UserManager).ToList();
            }
            return PartialView(expObj);
        }


        public IActionResult Edit(int id)
        {
            var userid = User.Claims.FirstOrDefault(c => c.Type == "UserId").Value;
            var user = _UserService.dbset().Where(c => c.UserId == Convert.ToInt32(userid)).FirstOrDefault();
            var role = User.Claims.FirstOrDefault(c => c.Type == System.Security.Claims.ClaimTypes.Role).Value;
            if (role == "SuperAdmin")
            {
                expObj.Companies = _CompanyService.GetAll();
                expObj.Managers = _UserService.dbset().Where(c => c.UserRole == "Manager").ToList();

            }
            else if (role == "Manager")
            {
                expObj.Companies = _CompanyService.dbset().Where(c => c.CompanyId == user.CompanyId).ToList();
                expObj.Managers = _UserService.dbset().Where(c => c.UserRole == "Manager" && c.CompanyId != null && c.CompanyId == user.CompanyId).ToList();

            }
            expObj.User = _UserService.GetById(id);
            return View(expObj);
        }


        [HttpPost]
        public async Task<IActionResult> save(PMSUserVM postedData)
        {
            DbResult result = new DbResult();
            if (ModelState.IsValid)
            {
                var item = _UserService.GetById(postedData.UserId);
                if (item != null)
                {
                    result.isError = true;
                    result.msg = "User= " + postedData.UserId + " is already exists !";
                }
                else
                {
                    var profilePicPath = await FileHandling.UploadFile(_HostEnvironment, postedData.ProfilePicFile);

                    if (!String.IsNullOrWhiteSpace(profilePicPath))
                    {
                        postedData.UserImageUrl = profilePicPath;
                    }
                    result.msg = _UserService.Insert(postedData);
                    if (result.msg == "")
                    {
                        result.msg = _UserService.SaveChanges();
                    }
                    result.isError = (result.msg != "" ? true : false);
                }
            }

            return Json(new { result = result });
        }


        [HttpPost]
        public async Task<IActionResult> update(PMSUserVM postedData)
        {
            DbResult result = new DbResult();

            if (ModelState.IsValid)
            {
                var profilePicPath = await FileHandling.UploadFile(_HostEnvironment, postedData.ProfilePicFile);

                if (!String.IsNullOrWhiteSpace(profilePicPath.ToString()))
                {
                    postedData.UserImageUrl = profilePicPath.ToString();
                }
                result.msg = _UserService.Update(postedData);
                if (result.msg == "")
                {
                    result.msg = _UserService.SaveChanges();
                }
                result.isError = (result.msg != "" ? true : false);
            }
            return Json(new { result = result });
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            DbResult result = new DbResult();
            var n = _UserService.Find(c => c.CompanyId == id).Count();
            if (n > 0)
            {
                result.isError = true;
                result.msg = "Company " + id + " is being used!";
            }
            else
            {
                _UserService.Delete(id);

                result.msg = _UserService.SaveChanges();
                result.isError = (result.msg != "" ? true : false);
            }
            return Json(new { result = result });
        }


        public IActionResult UploadImage()
        {
            string filePath = String.Empty;
            string wwwRootPath = _HostEnvironment.WebRootPath;
            string result = string.Empty;
            try
            {
                long size = 0;
                var file = Request.Form.Files;
                var filename = ContentDispositionHeaderValue
                                .Parse(file[0].ContentDisposition)
                                .FileName
                                .Trim('"');
                string fileNameInsurance = Path.GetFileNameWithoutExtension(filename);
                string extensionInsurance = Path.GetExtension(filename);
                filePath = fileNameInsurance = fileNameInsurance + DateTime.Now.ToString("yymmssfff") + extensionInsurance;
                string pathInsurance = Path.Combine(wwwRootPath + "/Files/" + fileNameInsurance);

                size += file[0].Length;
                using (FileStream fs = System.IO.File.Create(pathInsurance))
                {
                    file[0].CopyTo(fs);
                    fs.Flush();
                }
                result = filePath;
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            return Json(new { result = result });
        }
    }
}