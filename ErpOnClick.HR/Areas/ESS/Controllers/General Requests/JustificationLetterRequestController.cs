using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using ErpOnClick.DAL.Interfaces;
using ErpOnClick.DAL.Models;
using ErpOnClick.DAL.Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ErpOnClick.ErpMain.Models;
using Microsoft.AspNetCore.Hosting;
using ErpOnClick.DAL.Utilities;
using ErpOnClick.ErpMain.ViewModel;
using Microsoft.EntityFrameworkCore;
namespace ErpOnClick.ErpMain.Areas.ESS.Controllers.General_Requests
{
    public class JustificationLetterRequestController : BaseController
    {

        private readonly ILogger<JustificationLetterRequestController> _logger;
        private IJustificationLetterService _JustificationLetterService;
        private IBranchService _BranchService;
        private ICompanyService _CompanyService;
        public static IWebHostEnvironment _HostEnvironment;
        private IUserService _UserService;
        private IDepartmentService _departmentService;
        private INavigationService _NavigationService;
        private IEmpsService _empsService;
        private ERPonClickContext _context;
        private ILookupsService _LookupService;
        private IApprovalTaskService _approvalTaskService;
        private IApprovalRouteService _approvalRouteService;
        private IApprovalRouteDetailsService _approvalRouteDetailsService;
        private IEmpsService _EmpService;
        private IEmpAttendancesService _EmpAttendancesService;

        private dynamic expObj;
        public JustificationLetterRequestController(ILogger<JustificationLetterRequestController> logger, IEmpsService empsService, INavigationService NavigationService, IDepartmentService departmentService, IUserService UserService, IWebHostEnvironment HostEnvironment, IBranchService BranchService, ICompanyService CompanyService, ILookupTypesService LookupTypesService, ERPonClickContext context, ILookupsService LookupService, IApprovalRouteService approvalRouteService, IApprovalRouteDetailsService approvalRouteDetailsService, IApprovalTaskService approvalTaskService, ITimeCorrectionService TimeCorrectionService, IEmpsService EmpService, IEmpAttendancesService empAttendancesService, IJustificationLetterService justificationLetterService)
        {
            _logger = logger;
            _NavigationService = NavigationService;
            _CompanyService = CompanyService;
            _BranchService = BranchService;
            _HostEnvironment = HostEnvironment;
            _UserService = UserService;
            _departmentService = departmentService;
            _empsService = empsService;
            _context = context;
            _LookupService = LookupService;
            _approvalTaskService = approvalTaskService;
            _approvalRouteService = approvalRouteService;
            _approvalRouteDetailsService = approvalRouteDetailsService;
            _JustificationLetterService = justificationLetterService;
            _EmpService = EmpService;
            _EmpAttendancesService = empAttendancesService;

            expObj = new ExpandoObject();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult _list(string FromDate, string ToDate)
        {
            var empId = GetEmployeeId();

            var justificationLetterList = _JustificationLetterService.dbset().Include(x => x.ApprovalStatusNavigation).Where(x => x.EmpId == empId).ToList();
            if (!String.IsNullOrWhiteSpace(FromDate) && !String.IsNullOrWhiteSpace(ToDate))
            {
                justificationLetterList = justificationLetterList.Where(x => x.CreatedDate.Value.Date >= DateTime.Parse(FromDate).Date && x.CreatedDate.Value.Date <= DateTime.Parse(ToDate).Date).ToList();
            }
            expObj.JustificationLetterList = justificationLetterList;

            return PartialView(expObj);
        }

        public IActionResult edit(int id, int code = 0)
        {
            var empId = GetEmployeeId();
            var lookupList = _LookupService.GetAll();

            expObj.RequestStatus = lookupList.Where(x => x.LookupTypeId == LookupTypList.ApplicationStatus_007).ToList();
            expObj.RequestType = lookupList.Where(x => x.LookupTypeId == LookupTypList.RequestType_042).ToList();

            expObj.branchList = _BranchService.GetAll();
            expObj.companyList = _CompanyService.GetAll();

            //expObj.employeesList = _EmpService.GetAll();
            expObj.employeesList = _EmpService.Find(c => c.EmpId == empId).ToList();

            expObj.JustificationLetterDetail = _JustificationLetterService.GetById(id);

            ViewBag.Code = code;
            return View(expObj);
        }

        [HttpPost]
        public async Task<ActionResult> saveAsync(JustificationLetter postedData)
        {
            var empId = GetEmployeeId();
            DbResult result = new DbResult();
            if (postedData != null)
            {

                var item = _JustificationLetterService.GetById(postedData.RecId);
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
                    postedData.EmpId = empId;


                    result.msg = _JustificationLetterService.Insert(postedData);
                    if (result.msg == "")
                    {
                        result.msg = _JustificationLetterService.SaveChanges();
                        result.scalerVal = postedData.RecId;

                    }
                    result.isError = (result.msg != "" ? true : false);

                }
            }

            return Json(new { result = result });
        }

        [HttpPost]
        public async Task<ActionResult> updateAsync(JustificationLetter postedData)
        {
            DbResult result = new DbResult();

            if (postedData != null)
            {

                postedData.ModifiedDate = System.DateTime.Now;
                postedData.ModifiedBy = 1;

                result.msg = _JustificationLetterService.Update(postedData);
                if (result.msg == "")
                {
                    result.msg = _JustificationLetterService.SaveChanges();
                    result.scalerVal = postedData.RecId;
                }

                result.isError = (result.msg != "" ? true : false);
            }

            return Json(new { result = result });
        }

        [HttpPost]
        public ActionResult Post(string id)
        {
            DbResult result = new DbResult();

            var justificationLetterId = (id != null ? Int32.Parse(id) : 0);
            var justificationLetter = _JustificationLetterService.GetById(justificationLetterId);
            justificationLetter.ApprovalStatus = "007001";
            result.msg = _JustificationLetterService.Update(justificationLetter);
            result.msg = _JustificationLetterService.SaveChanges();


            var approvalTask = _approvalTaskService.Find(x => x.ApprovalTaskNameEn == "Justification Letter Request").FirstOrDefault();
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
                routeDetail.RequestedBy = GetEmployeeId();
                routeDetail.RecordId = justificationLetterId + "";
                routeDetail.ApprovalStatus = "007001";
                routeDetail.RecordNotes = null;
                routeDetail.ApproverNotes = null;
                routeDetail.ActionDate = DateTime.Now;
                routeDetail.CreatedDate = DateTime.Now;
                routeDetail.CreatedBy = GetEmployeeId();
                routeDetail.RecordName = "Justification Letter Request";
                routeDetail.RecordNotes = "Justification Letter Request pending for apporval";

                result.msg = _approvalRouteDetailsService.Insert(routeDetail);
            }
            result.msg = _approvalRouteDetailsService.SaveChanges();
            result.scalerVal = justificationLetterId;
            result.isError = (result.msg != "" ? true : false);
            return Json(new { result = result });
        }

        public ActionResult GetCurrentAttendance(string requestedDate)
        {
            var date = Convert.ToDateTime(requestedDate);

            var attendance = _EmpAttendancesService.Find(x => x.AttendanceDate == date).FirstOrDefault();

            if (attendance != null)
            {
                return Json(new { timeIn = Convert.ToDateTime(attendance.TimeIn).TimeOfDay, timeOut = Convert.ToDateTime(attendance.TimeOut).TimeOfDay });
            }

            return Json(new { timeIn = "", timeOut = "" });

        }

    }
}
