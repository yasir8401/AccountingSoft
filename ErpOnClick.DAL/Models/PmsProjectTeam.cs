using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class PmsProjectTeam
    {
        public int TeamId { get; set; }
        public int ProjectId { get; set; }
        public int ProjectUserId { get; set; }

        public virtual PmsProjects Project { get; set; }
        public virtual PmsUser ProjectUser { get; set; }
    }
}
