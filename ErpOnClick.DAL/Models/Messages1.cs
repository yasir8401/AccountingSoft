using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class Messages1
    {
        public int MessageId { get; set; }
        public string Message { get; set; }
        public int SendBy { get; set; }
        public int SendTo { get; set; }
        public DateTime Date { get; set; }
        public int TaskId { get; set; }

        public virtual User SendByNavigation { get; set; }
        public virtual User SendToNavigation { get; set; }
        public virtual ProjectTasks Task { get; set; }
    }
}
