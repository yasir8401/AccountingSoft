using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ErpOnClick.DAL.Models;
using ErpOnClick.DAL.Interfaces;
using ErpOnClick.ErpMain.Areas.PMS.Controllers;
using ErpOnClick.DAL.Interfaces.PMS;
using ErpOnClick.ErpMain.Areas.PMS.Models;

namespace PMS.Areas.Admin.Controllers
{
 

    public class PMSProjectsController : BaseController
    {
        private readonly ILogger<PMSProjectsController> _logger;
        private IPMSCompanyService _CompanyService;
        private IPMSProjectsService _ProjectsService;
        private IPMSProjectTeamService _ProjectTeamService;
        private IPMSUserService _UserService;


        private ERPonClickContext _db;


        private dynamic expObj;
        public PMSProjectsController(ILogger<PMSProjectsController> logger, ERPonClickContext db, IPMSCompanyService CompanyService, IPMSProjectsService ProjectsService, IPMSUserService UserService, IPMSProjectTeamService ProjectTeamService)
        {
            _logger = logger;
            this._CompanyService = CompanyService;
            this._ProjectsService = ProjectsService;
            this._UserService = UserService;
            this._ProjectTeamService = ProjectTeamService;


            _db = db;

            expObj = new ExpandoObject();
        }
        public IActionResult Index()
        {
            return View();
        }
        
        
        public IActionResult _list()
        {
            var userid = User.Claims.FirstOrDefault(c => c.Type == "UserId").Value;
            var user = _UserService.dbset().Where(c => c.UserId == Convert.ToInt32(userid)).FirstOrDefault();
            var role = User.Claims.FirstOrDefault(c => c.Type == System.Security.Claims.ClaimTypes.Role).Value;
            if (role == "SuperAdmin")
            {
                expObj.Projects = _ProjectsService.dbset().Include(c => c.Company).ToList();
            }
            else if (role == "Manager")
            {
                expObj.Projects = _ProjectsService.dbset().Where(c => c.CompanyId == user.CompanyId).Include(c => c.Company).ToList();
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
                expObj.User = _UserService.dbset().Where(c => c.UserRole != "Super Admin").ToList();
            }
            else if (role == "Manager")
            {
                expObj.Companies = _CompanyService.dbset().Where(c => c.CompanyId == user.CompanyId).ToList();
                expObj.User = _UserService.dbset().Where(c => c.UserRole != "Super Admin" && c.CompanyId != null && c.CompanyId == user.CompanyId).ToList();
            }
            expObj.Project = _ProjectsService.GetById(id);
            expObj.ProjectTeam = _ProjectTeamService.dbset().Where(c => c.ProjectId == id).Include(c => c.ProjectUser).ToList();
            return View(expObj);
        }

        public JsonResult GetCompanyTeam(int id)
        {
            var team = _UserService.dbset().Where(c => c.UserRole != "Super Admin" && c.CompanyId == id).Select(x => new { x.UserId, x.UserName }).ToList();

            return Json(new { result = team });

        }


        [HttpPost]
        public ActionResult save(PMSProjectVM postedData)
        {
            DbResult result = new DbResult();

            var item = _ProjectsService.GetById(postedData.Project.ProjectId);
            if (item != null)
            {
                result.isError = true;
                result.msg = "Project= " + postedData.Project.ProjectId + " is already exists !";
            }
            else
            {
                result.msg = _ProjectsService.Insert(postedData.Project);
                if (result.msg == "")
                {
                    result.msg = _ProjectsService.SaveChanges();
                    if (result.msg == "")
                    {
                        if (postedData.ProjectTeam != null)
                        {
                            foreach (var itemRoutes in postedData.ProjectTeam)
                            {
                                itemRoutes.ProjectId = postedData.Project.ProjectId;
                                result.msg = _ProjectTeamService.Insert(itemRoutes);
                            }
                            result.msg = _ProjectTeamService.SaveChanges();
                            foreach (var itemRoutes in postedData.ProjectTeam)
                            {
                                if (itemRoutes.IsDeleted == "true")
                                {
                                    result.msg = _ProjectTeamService.Delete(itemRoutes.TeamId);
                                }
                                result.msg = _ProjectTeamService.SaveChanges();
                            }
                        }
                    }
                }
                result.isError = (result.msg != "" ? true : false);
            }
            return Json(new { result = result });
        }


        [HttpPost]
        public ActionResult update(PMSProjectVM postedData)
        {
            DbResult result = new DbResult();

            result.msg = _ProjectsService.Update(postedData.Project);
            if (result.msg == "")
            {
                result.msg = _ProjectsService.SaveChanges();
                if (result.msg == "")
                {
                    if (postedData.ProjectTeam != null)
                    {
                        foreach (var itemRoutes in postedData.ProjectTeam)
                        {
                            itemRoutes.ProjectId = postedData.Project.ProjectId;
                            result.msg = _ProjectTeamService.Update(itemRoutes);
                        }
                        result.msg = _ProjectTeamService.SaveChanges();
                        foreach (var itemRoutes in postedData.ProjectTeam)
                        {
                            if (itemRoutes.IsDeleted == "true")
                            {
                                result.msg = _ProjectTeamService.Delete(itemRoutes.TeamId);
                            }
                            result.msg = _ProjectTeamService.SaveChanges();
                        }
                    }
                }
            }
            result.isError = (result.msg != "" ? true : false);
            return Json(new { result = result });
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            DbResult result = new DbResult();
            var n = _ProjectTeamService.Find(c => c.ProjectId == id).Count();
            if (n > 0)
            {
                result.isError = true;
                result.msg = "Project " + id + " is being used!";
            }
            else
            {
                _ProjectsService.Delete(id);

                result.msg = _ProjectsService.SaveChanges();
                result.isError = (result.msg != "" ? true : false);
            }
            return Json(new { result = result });
        }
    }
}