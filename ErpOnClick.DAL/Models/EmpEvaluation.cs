using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class EmpEvaluation
    {
        public int RecId { get; set; }
        public int EmpId { get; set; }
        public string EvaluationTypeId { get; set; }
        public int? EvaluationYear { get; set; }
        public string EvaluationQuarter { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public string Remarks { get; set; }
        public string Attachment { get; set; }
        public string ApprovalStatus { get; set; }
        public string ApprovalDate { get; set; }
        public int? CompanyId { get; set; }
        public int? BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual Lookups ApprovalStatusNavigation { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual Company Company { get; set; }
        public virtual Emp Emp { get; set; }
    }
}
