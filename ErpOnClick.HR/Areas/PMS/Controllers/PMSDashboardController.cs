using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using ErpOnClick.DAL.Interfaces.PMS;
using ErpOnClick.DAL.Models;
using ErpOnClick.ErpMain.Areas.PMS.Controllers;
using ErpOnClick.ErpMain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace PMS.Controllers
{
    public class PMSDashboardController : BaseController
    {
        private readonly ILogger<PMSDashboardController> _logger;
        private IPMSProjectTasksService _ProjectTasksService;
        private IPMSUserService _UserService;
        private IPMSProjectsService _ProjectsService;
        private IPMSProjectTeamService _ProjectTeamService;

        private ERPonClickContext _db;


        private dynamic expObj;
        public PMSDashboardController(ILogger<PMSDashboardController> logger, ERPonClickContext db, IPMSProjectTasksService ProjectTasksService, IPMSProjectTeamService ProjectTeamService, IPMSUserService UserService, IPMSProjectsService ProjectsService)
        {
            _logger = logger;
            this._ProjectTasksService = ProjectTasksService;

            this._UserService = UserService;
            this._ProjectsService = ProjectsService;
            this._ProjectTeamService = ProjectTeamService;

            _db = db;

            expObj = new ExpandoObject();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult _chart()
        {
            var tasks = _ProjectTasksService.dbset().Include(c => c.Project).ToList();
            var projects = _ProjectsService.dbset().Include(c => c.PmsProjectTeam).ToList();
            var users = _UserService.dbset().Where(c => c.UserRole != "Super Admin").ToList();
            var projecttasks = _ProjectTasksService.dbset().Include(c => c.Project).ToList();
            var role = User.Claims.FirstOrDefault(c => c.Type == System.Security.Claims.ClaimTypes.Role).Value;
            var userid = User.Claims.FirstOrDefault(c => c.Type == "UserId").Value;
            var user = _UserService.dbset().Where(c => c.UserId == Convert.ToInt32(userid)).FirstOrDefault();
            if (role == "SuperAdmin")
            {
                expObj.tasks = tasks;
                expObj.projects = projects;
                expObj.users = users;
                expObj.projecttasks = projecttasks;
            }
            else if (role == "Manager")
            {
                expObj.tasks = tasks.Where(c => c.Project.CompanyId == user.CompanyId).ToList(); ;
                expObj.projects = projects.Where(c => c.CompanyId == user.CompanyId).ToList();
                expObj.users = users.Where(c => c.CompanyId == user.CompanyId).ToList();
                expObj.projecttasks = projecttasks.Where(c => c.Project.CompanyId == user.CompanyId).ToList();
            }
            else if (role == "Developer")
            {
                expObj.tasks = tasks.Where(c => c.AssignedToId == user.UserId).ToList();
                expObj.projects = _ProjectTeamService.dbset().Where(c => c.ProjectUserId == user.UserId).Include(c => c.Project).Select(c => c.Project).ToList();
                expObj.users = users.Where(c => c.CompanyId == user.CompanyId).ToList();
                expObj.projecttasks = projecttasks.Where(c => c.AssignedToId == user.UserId).ToList();
            }




            return PartialView(expObj);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
