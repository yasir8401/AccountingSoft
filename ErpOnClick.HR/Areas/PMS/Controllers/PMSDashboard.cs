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
 

    public class PMSDashboardController : BaseController
    {
        private readonly ILogger<PMSProjectsController> _logger;
        private IPMSCompanyService _CompanyService;
        private IPMSProjectsService _ProjectsService;
        private IPMSProjectTeamService _ProjectTeamService;
        private IPMSUserService _UserService;


        private ERPonClickContext _db;


        private dynamic expObj;
        public PMSDashboardController(ILogger<PMSProjectsController> logger, ERPonClickContext db, IPMSCompanyService CompanyService, IPMSProjectsService ProjectsService, IPMSUserService UserService, IPMSProjectTeamService ProjectTeamService)
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
      
    }
}