using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class ProjectTasks
    {
        public ProjectTasks()
        {
            Messages1 = new HashSet<Messages1>();
            TaskAttachments = new HashSet<TaskAttachments>();
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

        public virtual User AssignedTo { get; set; }
        public virtual Projects Project { get; set; }
        public virtual User TaskCreatedByNavigation { get; set; }
        public virtual ICollection<Messages1> Messages1 { get; set; }
        public virtual ICollection<TaskAttachments> TaskAttachments { get; set; }
    }
}
