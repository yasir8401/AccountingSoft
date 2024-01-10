using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using ErpOnClick.DAL.Interfaces.PMS;
using ErpOnClick.DAL.Models;
using ErpOnClick.DAL.Utilities;
using ErpOnClick.ErpMain.Areas.PMS.Controllers;
using ErpOnClick.ErpMain.Areas.PMS.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace PMS.Areas.Admin.Controllers
{


    public class PMSProjectTasksController : BaseController
    {
        private readonly ILogger<PMSProjectTasksController> _logger;
        private IPMSCompanyService _CompanyService;
        private IPMSUserService _UserService;
        private IPMSProjectsService _ProjectsService;
        private IPMSProjectTasksService _ProjectTasksService;
        private IPMSProjectTeamService _ProjectTeamService;
        private IPMSTaskAttachmentsService _TaskAttachmentsService;
        private IPMSMessagesService _MessagesService;
        public static IWebHostEnvironment _HostEnvironment;
        private readonly IHostingEnvironment _hostEnvironment;



        private ERPonClickContext _db;


        private dynamic expObj;
        public PMSProjectTasksController(ILogger<PMSProjectTasksController> logger, IHostingEnvironment appEnvironment, ERPonClickContext db, IPMSMessagesService MessagesService, IWebHostEnvironment HostEnvironment, IPMSTaskAttachmentsService TaskAttachmentsService, IPMSProjectTeamService ProjectTeamService, IPMSProjectTasksService ProjectTasksService, IPMSCompanyService CompanyService, IPMSUserService UserService, IPMSProjectsService ProjectsService)
        {
            _logger = logger;
            this._CompanyService = CompanyService;
            this._UserService = UserService;
            this._ProjectsService = ProjectsService;
            this._ProjectTasksService = ProjectTasksService;
            this._ProjectTeamService = ProjectTeamService;
            this._TaskAttachmentsService = TaskAttachmentsService;
            this._MessagesService = MessagesService;
            _HostEnvironment = HostEnvironment;
            _hostEnvironment = appEnvironment;



            _db = db;

            expObj = new ExpandoObject();
        }
        public IActionResult Index()
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
            else if (role == "Developer")
            {
                expObj.Projects = _ProjectTeamService.dbset().Where(c => c.ProjectUserId == Convert.ToInt32(userid)).Include(c => c.Project).Select(c => c.Project).ToList();
            }
            return View(expObj);
        }

        public IActionResult _list(int Project, string DateFrom, string DateTo, string Status)
        {
            var userid = User.Claims.FirstOrDefault(c => c.Type == "UserId").Value;
            var user = _UserService.dbset().Where(c => c.UserId == Convert.ToInt32(userid)).FirstOrDefault();
            var role = User.Claims.FirstOrDefault(c => c.Type == System.Security.Claims.ClaimTypes.Role).Value;
            if (role == "SuperAdmin")
            {
                expObj.ProjectTasks = _ProjectTasksService.dbset().Where(c => c.ProjectId == Project
                && ((Status != null && c.TaskStatus == Status) || Status == null)
                && (c.TaskCreatedDate >= Convert.ToDateTime(DateFrom) && c.TaskCreatedDate <= Convert.ToDateTime(DateTo))
                && (c.TaskStartDate >= Convert.ToDateTime(DateFrom) && c.TaskStartDate <= Convert.ToDateTime(DateTo))
                && (c.TaskEndDate >= Convert.ToDateTime(DateFrom) && c.TaskEndDate <= Convert.ToDateTime(DateTo))
                ).Include(c => c.Project).Include(c => c.TaskCreatedByNavigation).Include(c => c.AssignedTo).ToList();
            }
            else if (role == "Manager")
            {
                expObj.ProjectTasks = _ProjectTasksService.dbset().Where(c => c.Project.CompanyId == user.CompanyId
                && c.ProjectId == Project
                && ((Status != null && c.TaskStatus == Status) || Status == null)
                && (c.TaskCreatedDate >= Convert.ToDateTime(DateFrom) && c.TaskCreatedDate <= Convert.ToDateTime(DateTo))
                && (c.TaskStartDate >= Convert.ToDateTime(DateFrom) && c.TaskStartDate <= Convert.ToDateTime(DateTo))
                && (c.TaskEndDate >= Convert.ToDateTime(DateFrom) && c.TaskEndDate <= Convert.ToDateTime(DateTo))
                ).Include(c => c.Project).Include(c => c.TaskCreatedByNavigation).Include(c => c.AssignedTo).ToList();
            }
            else if (role == "Developer")
            {
                expObj.ProjectTasks = _ProjectTasksService.dbset().Where(c => c.AssignedToId == Convert.ToInt32(userid)
                && c.ProjectId == Project
                && ((Status != null && c.TaskStatus == Status) || Status == null)
                && (c.TaskCreatedDate >= Convert.ToDateTime(DateFrom) && c.TaskCreatedDate <= Convert.ToDateTime(DateTo))
                && (c.TaskStartDate >= Convert.ToDateTime(DateFrom) && c.TaskStartDate <= Convert.ToDateTime(DateTo))
                && (c.TaskEndDate >= Convert.ToDateTime(DateFrom) && c.TaskEndDate <= Convert.ToDateTime(DateTo))
                ).Include(c => c.Project).Include(c => c.TaskCreatedByNavigation).Include(c => c.AssignedTo).ToList();
            }
            return PartialView(expObj);
        }


        public IActionResult Edit(int id)
        {
            var userid = User.Claims.FirstOrDefault(c => c.Type == "UserId").Value;
            var user = _UserService.dbset().Where(c => c.UserId == Convert.ToInt32(userid)).FirstOrDefault();
            var role = User.Claims.FirstOrDefault(c => c.Type == System.Security.Claims.ClaimTypes.Role).Value;
            var projectTask = _ProjectTasksService.GetById(id);

            if (role == "SuperAdmin")
            {
                expObj.Projects = _ProjectsService.GetAll();
            }
            else if (role == "Manager")
            {
                expObj.Projects = _ProjectsService.dbset().Where(c => c.CompanyId == user.CompanyId).ToList();
            }
            else if (role == "Developer")
            {
                expObj.Projects = _ProjectsService.dbset().Where(c => c.ProjectId == (projectTask != null ? projectTask.ProjectId : 0)).ToList();
            }
            expObj.ProjectTask = projectTask;
            expObj.ProjectTeam = _ProjectTeamService.dbset().Where(c => c.ProjectId == (projectTask != null ? projectTask.ProjectId : 0)).Include(c => c.ProjectUser).ToList();
            return View(expObj);
        }

        public JsonResult GetProjectTeam(int id)
        {
            var team = _ProjectTeamService.dbset().Where(c => c.ProjectId == id).Include(c => c.ProjectUser).Select(x => new { x.ProjectUserId, x.ProjectUser.UserName }).ToList();

            return Json(new { result = team });

        }

        public JsonResult GetManagers(int TaskId)
        {
            var userid = Convert.ToInt32(User.Claims.FirstOrDefault(c => c.Type == "UserId").Value);
            var user = _UserService.dbset().Where(c => c.UserId == Convert.ToInt32(userid)).FirstOrDefault();
            var role = User.Claims.FirstOrDefault(c => c.Type == System.Security.Claims.ClaimTypes.Role).Value;
            List<PmsUser> team = new List<PmsUser>();
            if (role == "Developer")
            {
                team = _UserService.dbset().Where(c => c.CompanyId == user.CompanyId && c.UserRole == "Manager").ToList();
            }
            else if (role == "Manager")
            {
                team = _ProjectTasksService.dbset().Where(c => c.TaskId == TaskId).Include(c => c.AssignedTo).Select(c => c.AssignedTo).ToList();
            }
            return Json(new { result = team });

        }

        public JsonResult GetConvo(int TaskId, int ManagerId)
        {
            var receivedname = "";

            List<PmsMessages> convo = new List<PmsMessages>();
            var userid = Convert.ToInt32(User.Claims.FirstOrDefault(c => c.Type == "UserId").Value);
            var user = _UserService.dbset().Where(c => c.UserId == Convert.ToInt32(userid)).FirstOrDefault();

            var convoreceived = _MessagesService.dbset().Where(c => c.TaskId == TaskId && c.SendBy == ManagerId && c.SendTo == userid).Include(c => c.SendByNavigation).ToList();
            if (convoreceived.Count() > 0)
            {
                receivedname = convoreceived.FirstOrDefault().SendByNavigation.UserRole + " [ " + convoreceived.FirstOrDefault().SendByNavigation.UserName + " ]";
            }
            foreach (var receive in convoreceived)
            {
                receive.SendByNavigation.UserName = receivedname;
            }
            var convosend = _MessagesService.dbset().Where(c => c.TaskId == TaskId && c.SendBy == userid && c.SendTo == ManagerId).Include(c => c.SendByNavigation).ToList();
            foreach (var receive in convosend)
            {
                receive.SendByNavigation.UserName = receive.SendByNavigation.UserRole + " [ You ]";
            }
            convo.AddRange(convoreceived);
            convo.AddRange(convosend);
            return Json(new { result = convo.OrderBy(c => c.Date) });
        }

        public JsonResult GetDetails(int id)
        {
            var details = _ProjectTasksService.dbset().Where(c => c.TaskId == id).FirstOrDefault();

            return Json(new { result = details });

        }

        [HttpPost]
        public ActionResult save(PMSProjectTasksVM postedData)
        {
            var userid = User.Claims.FirstOrDefault(c => c.Type == "UserId").Value;
            var user = _UserService.dbset().Where(c => c.UserId == Convert.ToInt32(userid)).FirstOrDefault();

            DbResult result = new DbResult();

            var item = _ProjectTasksService.GetById(postedData.Project.TaskId);
            if (item != null)
            {
                result.isError = true;
                result.msg = "Project Task = " + postedData.Project.TaskId + " is already exists !";
            }
            else
            {
                postedData.Project.TaskCreatedBy = Convert.ToInt32(userid);
                postedData.Project.TaskCreatedDate = System.DateTime.Now;

                result.msg = _ProjectTasksService.Insert(postedData.Project);
                if (result.msg == "")
                {
                    result.msg = _ProjectTasksService.SaveChanges();
                    if (result.msg == "")
                    {
                        PmsMessages message = new PmsMessages();
                        message.TaskId = postedData.Project.TaskId;
                        message.Date = System.DateTime.Now;
                        message.SendBy = Convert.ToInt32(userid);
                        message.SendTo = postedData.Project.AssignedToId;
                        message.Message = "New Task [" + postedData.Project.TaskName + "] has Assigned By " + user.UserName;
                        result.msg = _MessagesService.Insert(message);
                        if (result.msg == "")
                        {
                            result.msg = _MessagesService.SaveChanges();
                        }
                    }
                }
                result.isError = (result.msg != "" ? true : false);
            }
            return Json(new { result = result });
        }


        [HttpPost]
        public ActionResult update(PMSProjectTasksVM postedData)
        {
            var role = User.Claims.FirstOrDefault(c => c.Type == System.Security.Claims.ClaimTypes.Role).Value;
            var oldprogress = 0;
            DbResult result = new DbResult();
            if (postedData.completed == true)
            {
                postedData.Project.TaskStatus = "Complete";
            }
            if (role == "Developer")
            {
                var taskdetails = _ProjectTasksService.dbset().Where(c => c.TaskId == postedData.Project.TaskId).Include(c => c.Project).FirstOrDefault();
                oldprogress = Convert.ToInt32(taskdetails.TaskCompletedPercentage);
                taskdetails.TaskCompletedPercentage = postedData.Project.TaskCompletedPercentage;
                taskdetails.TaskPublishedUrl = postedData.Project.TaskPublishedUrl;
                taskdetails.TaskStatus = (postedData.completed == true ? postedData.Project.TaskStatus : taskdetails.TaskStatus);
                result.msg = _ProjectTasksService.Update(taskdetails);
                result.msg = SendMail(taskdetails, oldprogress);
            }
            else
            {
                result.msg = _ProjectTasksService.Update(postedData.Project);
            }
            if (result.msg == "")
            {
                result.msg = _ProjectTasksService.SaveChanges();
            }
            result.isError = (result.msg != "" ? true : false);
            return Json(new { result = result });
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            DbResult result = new DbResult();
            var n = _ProjectTasksService.Find(c => c.TaskId == id).Count();
            if (n == 0)
            {
                result.isError = false;
                result.msg = "";
            }
            else
            {
                _ProjectTasksService.Delete(id);

                result.msg = _ProjectTasksService.SaveChanges();
                result.isError = (result.msg != "" ? true : false);
            }
            return Json(new { result = result });
        }

        public JsonResult Attachments(int TaskId)
        {
            List<PmsTaskAttachments> allattachments = new List<PmsTaskAttachments>();
            if (TaskId != 0)
            {
                allattachments = _TaskAttachmentsService.Find(c => c.TaskId == TaskId).ToList();
            }
            else
            {
                allattachments = null;
            }
            return Json(new { result = allattachments });
        }

        public async Task<JsonResult> AddAttachment(PMSAttachmentVM attachment)
        {
            DbResult result = new DbResult();
            PmsTaskAttachments attachments = new PmsTaskAttachments();

            if (attachment != null && attachment.AttachmentFile != null)
            {
                var checkattachment = _TaskAttachmentsService.Find(c => c.TaskAttachmentName == attachment.AttachmentName).Count();
                if (checkattachment > 0)
                {
                    result.msg = "Selected File Already Uploaded";
                    result.isError = true;
                }
                else
                {
                    attachments.TaskId = attachment.TaskId;
                    attachments.TaskAttachmentName = attachment.AttachmentName;
                    attachments.TaskId = attachment.TaskId;
                    var attachmentfilePath = await FileHandling.UploadFile(_HostEnvironment, attachment.AttachmentFile);
                    if (!String.IsNullOrWhiteSpace(attachmentfilePath))
                    {
                        attachments.TaskAttachmentUrl = attachmentfilePath;
                    }

                    result.msg = _TaskAttachmentsService.Insert(attachments);
                    if (result.msg == "")
                    {
                        result.msg = _TaskAttachmentsService.SaveChanges();
                        if (result.msg == "")
                        {
                            result.msg = "File Uploaded";
                            result.isError = false;

                        }
                        else
                        {
                            result.msg = "Failed To Upload File";
                            result.isError = true;

                        }

                    }
                    else
                    {
                        result.msg = "Failed To Upload File";
                        result.isError = true;


                    }
                }

            }
            else if (attachment.AttachmentFile == null)
            {
                result.msg = "Please Choose File To Upload";
                result.isError = true;
            }
            else
            {
                result.msg = "Failed To Upload File";
                result.isError = true;


            }
            return Json(new { result = result, taskAttachmentName = attachment.AttachmentName, taskAttachmentId = attachments.TaskAttachmentId, taskAttachmentUrl = attachments.TaskAttachmentUrl });

        }

        public JsonResult DeleteAttachment(int attachmentid)
        {
            DbResult result = new DbResult();
            bool ans = false;
            var attachment = _TaskAttachmentsService.Find(c => c.TaskAttachmentId == attachmentid).FirstOrDefault();
            ans = FileHandling.DeleteFile(_HostEnvironment, attachment.TaskAttachmentUrl);

            if (ans == true)
            {
                result.msg = _TaskAttachmentsService.Delete(attachment.TaskAttachmentId);
                if (result.msg == "")
                {
                    result.msg = _TaskAttachmentsService.SaveChanges();
                    if (result.msg == "")
                    {
                        result.isError = false;
                        result.msg = "Deleted Successfully";
                    }
                    else
                    {
                        result.isError = true;
                        result.msg = "Failed To Delete File";
                    }
                }
                else
                {
                    result.isError = true;
                    result.msg = "Failed To Delete File";
                }
            }
            else
            {
                result.isError = true;
                result.msg = "Failed To Delete File";
            }

            return Json(new { result = result, deletedid = attachmentid });

        }

        [HttpPost]
        public ActionResult SendMsg(PMSMessageVM data)
        {
            DbResult result = new DbResult();
            var taskdetails = _ProjectTasksService.dbset().Where(c => c.TaskId == data.PTaskId).Include(c => c.AssignedTo).FirstOrDefault();
            var userid = User.Claims.FirstOrDefault(c => c.Type == "UserId").Value;
            var user = _UserService.dbset().Where(c => c.UserId == Convert.ToInt32(userid)).FirstOrDefault();
            var role = User.Claims.FirstOrDefault(c => c.Type == System.Security.Claims.ClaimTypes.Role).Value;
            if (role == "Developer")
            {
                PmsMessages message = new PmsMessages();
                message.Message = data.Message;
                message.Date = System.DateTime.Now;
                message.SendBy = Convert.ToInt32(userid);
                message.SendTo = data.ManagerId;
                message.TaskId = data.PTaskId;
                result.msg = _MessagesService.Insert(message);
            }
            else if (role == "Manager")
            {

                PmsMessages message = new PmsMessages();
                message.Message = data.Message;
                message.Date = System.DateTime.Now;
                message.SendBy = Convert.ToInt32(userid);
                message.SendTo = taskdetails.AssignedToId;
                message.TaskId = data.PTaskId;
                result.msg = _MessagesService.Insert(message);
            }
            if (result.msg == "")
            {
                result.msg = _MessagesService.SaveChanges();
            }
            result.isError = (result.msg != "" ? true : false);
            return Json(new { result = "" });
        }

        public string SendMail(PmsProjectTasks postedData, int oldprogress)
        {
            List<PmsUser> managers = new List<PmsUser>();
            var userid = User.Claims.FirstOrDefault(c => c.Type == "UserId").Value;
            var user = _UserService.dbset().Where(c => c.UserId == Convert.ToInt32(userid)).FirstOrDefault();
            //var project_team = _ProjectTeamService.dbset().Where(c => c.ProjectId == postedData.ProjectId).ToList();    //Managers from Project Team OF Project
            var companyId = _ProjectTasksService.dbset().Include(c => c.Project.Company).Where(c => c.ProjectId == postedData.ProjectId).Select(c => c.Project.CompanyId).FirstOrDefault();    //Managers from Company of Project
            var project_team = _UserService.dbset().Where(c => c.CompanyId == Convert.ToInt32(companyId)).ToList();
            foreach (var member in project_team)
            {
                var userdetails = _UserService.dbset().Where(c => c.UserId == member.UserId).FirstOrDefault();
                if (userdetails.UserRole == "Manager")
                {
                    managers.Add(userdetails);
                }
            }

            //var emailtoManager = userdetails.UserEmail;
            //Fetching Email Body Text from EmailTemplate File.  
            string FilePath = _hostEnvironment.WebRootPath + "/EmailTemplates/EmailTemplate.html";
            StreamReader str = new StreamReader(FilePath);
            string MailText = str.ReadToEnd();

            str.Close();

            //Repalce [newusername] = signup user name   
            MailText = MailText.Replace("[Action]", "Task Updated by " + user.UserName + "(Developer)");

            MailText = MailText.Replace("[Project]", postedData.Project.ProjectName);
            MailText = MailText.Replace("[TaskName]", postedData.TaskName);
            MailText = MailText.Replace("[OldProgress]", oldprogress.ToString() + "%");
            MailText = MailText.Replace("[NewProgress]", postedData.TaskCompletedPercentage.ToString() + "%");
            MailText = MailText.Replace("[Date]", Convert.ToDateTime(System.DateTime.Now).ToString("dd-MMM-yyyy"));
            MailText = MailText.Replace("[UpdateBy]", user.UserName);


            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("pms@nayelsolutions.com");
            mail.To.Add(user.UserEmail);
            mail.Subject = "Email Notification from PMS";
            mail.Body = MailText;
            mail.IsBodyHtml = true;
            foreach (var manager in managers)
            {
                MailAddress email = new MailAddress(manager.UserEmail, manager.UserName);
                mail.CC.Add(email);
            }
            var _smtpAddress = "mail.nayelsolutions.com";
            var _port = 8889;
            var _username = "pms@nayelsolutions.com";
            var _passsword = "PmsPms123_";

            using (SmtpClient smtp = new SmtpClient(_smtpAddress, _port))
            {
                smtp.Credentials = new NetworkCredential(_username, _passsword);
                smtp.EnableSsl = false;
                try
                {
                    smtp.Send(mail);
                    return "";
                }
                catch (Exception ex)
                {
                    return ex.Message.ToString();
                }
            }
        }
    }
}