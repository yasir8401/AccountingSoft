using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class PmsProjects
    {
        public PmsProjects()
        {
            PmsProjectTasks = new HashSet<PmsProjectTasks>();
            PmsProjectTeam = new HashSet<PmsProjectTeam>();
        }

        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string ProjectDesc { get; set; }
        public int CompanyId { get; set; }

        public virtual PmsCompany Company { get; set; }
        public virtual ICollection<PmsProjectTasks> PmsProjectTasks { get; set; }
        public virtual ICollection<PmsProjectTeam> PmsProjectTeam { get; set; }
    }
}
