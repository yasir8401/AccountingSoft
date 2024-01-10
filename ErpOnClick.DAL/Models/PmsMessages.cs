using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class PmsMessages
    {
        public int MessageId { get; set; }
        public string Message { get; set; }
        public int SendBy { get; set; }
        public int SendTo { get; set; }
        public DateTime Date { get; set; }
        public int TaskId { get; set; }

        public virtual PmsUser SendByNavigation { get; set; }
        public virtual PmsUser SendToNavigation { get; set; }
        public virtual PmsProjectTasks Task { get; set; }
    }
}
