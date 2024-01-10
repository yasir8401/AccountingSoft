using ErpOnClick.DAL.Common;
using ErpOnClick.DAL.Interfaces;
using ErpOnClick.DAL.Models;
using ErpOnClick.DAL.Utilities;
using ErpOnClick.ErpMain.Areas.ESS.Models;
using ErpOnClick.ErpMain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace ErpOnClick.ErpMain.Areas.ESS.Controllers
{
    [Area("HumanResource")]
    [Authorize]
    public class EmpEvaluationController : Controller
    {
        private readonly ILogger<EmpEvaluationController> _logger;
        private ILookupsService _LookupService;
        private IBranchService _BranchService;
        private ICompanyService _CompanyService;
        private IEmpsService _EmpService;
        private IUserService _UserService;
        private IEmpEvaluationService _EmpEvaluationService;
        private IApprovalTaskService _approvalTaskService;
        private IApprovalRouteService _approvalRouteService;
        private IApprovalRouteDetailsService _approvalRouteDetailsService;
        public static IWebHostEnvironment _HostEnvironment;



        private dynamic expObj;
        public EmpEvaluationController(IUserService UserService, ILogger<EmpEvaluationController> logger, IWebHostEnvironment HostEnvironment, IEmpsService EmpService, IBranchService BranchService, ICompanyService CompanyService,  ILookupsService LookupService, ILookupTypesService LookupTypesService, IEmpEvaluationService empEvaluationService, IApprovalRouteService approvalRouteService, IApprovalRouteDetailsService approvalRouteDetailsService, IApprovalTaskService approvalTaskService)
        {
            _logger = logger;
            _UserService = UserService;
            _EmpEvaluationService = empEvaluationService;
            _LookupService = LookupService;
            _CompanyService = CompanyService;
            _BranchService = BranchService;
            _EmpService = EmpService;
            _approvalTaskService = approvalTaskService;
            _approvalRouteService = approvalRouteService;
            _approvalRouteDetailsService = approvalRouteDetailsService;
            _HostEnvironment = HostEnvironment;

            expObj = new ExpandoObject();
        }
        public IActionResult Index(string attendanceDate)
        {
            var lookups = _LookupService.GetAll();
            expObj.employeeList = _EmpService.GetAll();
            expObj.evaluationTypeList = lookups.Where(x => x.LookupTypeId == LookupTypList.EvaluationType_079).ToList();

            //expObj.employeecheck = empcheck;
            return View(expObj);
        }

        public IActionResult _list(string date)
        {
            expObj.evaluationList = _EmpEvaluationService.dbset().Include(x => x.Emp).Include(x => x.ApprovalStatusNavigation).ToList();
            return PartialView(expObj);
        }

        [HttpPost]
        public async Task<ActionResult> save(EmpEvaluationInherited postedData)
        {
            DbResult result = new DbResult();
            if (postedData != null)
            {
                var item = _EmpEvaluationService.GetById(postedData.RecId);
                if (item != null)
                {
                    result.isError = true;
                    result.msg = "RecId " + postedData.RecId + " is already exists !";
                }
                else
                {
                    var EmpId = Convert.ToInt32(User.Identity.Name);
                    var user = _UserService.dbset().Where(c => c.UserId == EmpId).FirstOrDefault();
                    postedData.CompanyId = user.CompanyId;
                    postedData.BranchId = user.BranchId;
                    postedData.CreatedDate = System.DateTime.Now;
                    postedData.CreatedBy = 0;
                    postedData.PortalId = 0;

                    var attachmentfilePath = await FileHandling.UploadFile(_HostEnvironment, postedData.AttachmentFile);
                    
                    if (!String.IsNullOrWhiteSpace(attachmentfilePath))
                    {
                        postedData.Attachment = attachmentfilePath;
                    }


                    result.msg = _EmpEvaluationService.Insert(postedData);
                    if (result.msg == "")
                    {
                        result.msg = _EmpEvaluationService.SaveChanges();
                        PostRequestForApproval(postedData.RecId);
                    }
                    result.isError = (result.msg != "" ? true : false);
                }
            }
            return Json(new { result = result });
        }

        private void PostRequestForApproval(int id)
        {
            DbResult result = new DbResult();

            
            var evaluation = _EmpEvaluationService.GetById(id);
            evaluation.ApprovalStatus = "007001";
            result.msg = _EmpEvaluationService.Update(evaluation);
            result.msg = _EmpEvaluationService.SaveChanges();


            var approvalTask = _approvalTaskService.Find(x => x.ApprovalTaskNameEn == "Evaluation Request").FirstOrDefault();
            if (approvalTask != null)
            {
                var approvalRoutes = _approvalRouteService.Find(x => x.ApprovalTaskId == approvalTask.ApprovalTaskId).ToList();

                foreach (var route in approvalRoutes)
                {
                    var routeDetail = new ApprovalRoutesDetail();


                    routeDetail.ApprovalRouteId = route.ApprovalRouteId;
                    routeDetail.SeqId = route.SeqId;
                    routeDetail.ApprovalTaskId = approvalTask.ApprovalTaskId + "";
                    routeDetail.ApproverUserId = route.UserId;
                    routeDetail.IsDepartment = route.IsDepartment;
                    routeDetail.DepartmentId = route.DepartmentId;
                    routeDetail.RequestedBy = Convert.ToInt32(User.Identity.Name);
                    routeDetail.RecordId = id + "";
                    routeDetail.ApprovalStatus = "007001";
                    routeDetail.RecordNotes = null;
                    routeDetail.ApproverNotes = null;
                    routeDetail.ActionDate = DateTime.Now;
                    routeDetail.CreatedDate = DateTime.Now;
                    routeDetail.CreatedBy = Convert.ToInt32(User.Identity.Name);
                    routeDetail.RecordName = "Evaluation Request";
                    routeDetail.RecordNotes = "Evaluation pending for apporval";

                    result.msg = _approvalRouteDetailsService.Insert(routeDetail);
                }
                result.msg = _approvalRouteDetailsService.SaveChanges();
            }
            result.scalerVal = id;
            result.isError = (result.msg != "" ? true : false);
        }
    }
}
