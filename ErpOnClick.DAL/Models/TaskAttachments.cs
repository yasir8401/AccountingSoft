using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class TaskAttachments
    {
        public int TaskAttachmentId { get; set; }
        public string TaskAttachmentName { get; set; }
        public string TaskAttachmentUrl { get; set; }
        public int TaskId { get; set; }

        public virtual ProjectTasks Task { get; set; }
    }
}
