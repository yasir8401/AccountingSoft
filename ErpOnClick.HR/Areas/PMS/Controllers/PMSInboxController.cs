using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using ErpOnClick.DAL.Interfaces.PMS;
using ErpOnClick.DAL.Models;
using ErpOnClick.ErpMain.Areas.PMS.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace PMS.Areas.Admin.Controllers
{

    public class PMSInboxController : BaseController
    {
        private readonly ILogger<PMSInboxController> _logger;
        private IPMSCompanyService _CompanyService;
        private IPMSUserService _UserService;
        private IPMSMessagesService _MessagesService;
        public static IWebHostEnvironment _HostEnvironment;


        private ERPonClickContext _db;


        private dynamic expObj;
        public PMSInboxController(ILogger<PMSInboxController> logger, ERPonClickContext db, IPMSMessagesService MessagesService, IPMSCompanyService CompanyService, IPMSUserService UserService, IWebHostEnvironment HostEnvironment)
        {
            _logger = logger;
            this._MessagesService = MessagesService;
            this._CompanyService = CompanyService;
            this._UserService = UserService;
            _HostEnvironment = HostEnvironment;


            _db = db;

            expObj = new ExpandoObject();
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult _list(string Type)
        {
            var userid = User.Claims.FirstOrDefault(c => c.Type == "UserId").Value;
            var user = _UserService.dbset().Where(c => c.UserId == Convert.ToInt32(userid)).FirstOrDefault();
            var role = User.Claims.FirstOrDefault(c => c.Type == System.Security.Claims.ClaimTypes.Role).Value;
            if (Type == "All")
            {
                expObj.Messages = _MessagesService.dbset().Where(c => c.SendBy == Convert.ToInt32(userid) || c.SendTo == Convert.ToInt32(userid)).Include(c => c.Task.Project).Include(c => c.SendToNavigation).Include(c => c.SendByNavigation).ToList();
            }
            if (Type == "Sent")
            {
                expObj.Messages = _MessagesService.dbset().Where(c => c.SendBy == Convert.ToInt32(userid)).Include(c => c.Task.Project).Include(c => c.SendToNavigation).Include(c => c.SendByNavigation).ToList();
            }
            if (Type == "Received")
            {
                expObj.Messages = _MessagesService.dbset().Where(c => c.SendTo == Convert.ToInt32(userid)).Include(c => c.Task.Project).Include(c => c.SendToNavigation).Include(c => c.SendByNavigation).ToList();
            }
            return PartialView(expObj);
        }

        public IActionResult _notification()
        {
            int UserId = Convert.ToInt32(User.Claims.FirstOrDefault(c => c.Type == "UserId").Value);

            var Messages = _MessagesService.dbset()
                .Where(c => c.SendTo == UserId)
                .OrderByDescending(c => c.MessageId)
                .ToList();

            expObj.myApprovals = Messages.Take(5);
            expObj.count = Messages.Count();

            return Json(expObj);
        }
    }
}