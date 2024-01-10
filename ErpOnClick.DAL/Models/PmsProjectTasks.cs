using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class PmsProjectTasks
    {
        public PmsProjectTasks()
        {
            PmsMessages = new HashSet<PmsMessages>();
            PmsTaskAttachments = new HashSet<PmsTaskAttachments>();
        }

        public int TaskId { get; set; }
        public int ProjectId { get; set; }
        public string TaskName { get; set; }
        public string TaskDesc { get; set; }
        public DateTime? TaskCreatedDate { get; set; }
        public int? TaskCreatedBy { get; set; }
        public int AssignedToId { get; set; }
        public DateTime? TaskEndDate { get; set; }
        public string TaskStatus { get; set; }
        public int? TaskCompletedPercentage { get; set; }
        public string TaskPublishedUrl { get; set; }
        public DateTime? TaskStartDate { get; set; }

        public virtual PmsUser AssignedTo { get; set; }
        public virtual PmsProjects Project { get; set; }
        public virtual PmsUser TaskCreatedByNavigation { get; set; }
        public virtual ICollection<PmsMessages> PmsMessages { get; set; }
        public virtual ICollection<PmsTaskAttachments> PmsTaskAttachments { get; set; }
    }
}
