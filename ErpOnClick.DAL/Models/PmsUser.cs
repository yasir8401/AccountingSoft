using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class PmsUser
    {
        public PmsUser()
        {
            InverseUserManager = new HashSet<PmsUser>();
            PmsMessagesSendByNavigation = new HashSet<PmsMessages>();
            PmsMessagesSendToNavigation = new HashSet<PmsMessages>();
            PmsProjectTasksAssignedTo = new HashSet<PmsProjectTasks>();
            PmsProjectTasksTaskCreatedByNavigation = new HashSet<PmsProjectTasks>();
            PmsProjectTeam = new HashSet<PmsProjectTeam>();
        }

        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string UserEmail { get; set; }
        public string UserContact { get; set; }
        public string UserRole { get; set; }
        public int? CompanyId { get; set; }
        public int? UserManagerId { get; set; }
        public string UserImageUrl { get; set; }

        public virtual PmsCompany Company { get; set; }
        public virtual PmsUser UserManager { get; set; }
        public virtual ICollection<PmsUser> InverseUserManager { get; set; }
        public virtual ICollection<PmsMessages> PmsMessagesSendByNavigation { get; set; }
        public virtual ICollection<PmsMessages> PmsMessagesSendToNavigation { get; set; }
        public virtual ICollection<PmsProjectTasks> PmsProjectTasksAssignedTo { get; set; }
        public virtual ICollection<PmsProjectTasks> PmsProjectTasksTaskCreatedByNavigation { get; set; }
        public virtual ICollection<PmsProjectTeam> PmsProjectTeam { get; set; }
    }
}
