using ErpOnClick.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErpOnClick.ErpMain.Areas.PMS.Models
{
    public class PMSProjectVM
    {
        public PmsProjects Project { get; set; }
        public IList<PMSProjectTeamExtended> ProjectTeam { get; set; }
    }
}
