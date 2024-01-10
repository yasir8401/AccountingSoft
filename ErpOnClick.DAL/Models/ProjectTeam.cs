using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class ProjectTeam
    {
        public int TeamId { get; set; }
        public int ProjectId { get; set; }
        public int ProjectUserId { get; set; }

        public virtual Projects Project { get; set; }
        public virtual User ProjectUser { get; set; }
    }
}
