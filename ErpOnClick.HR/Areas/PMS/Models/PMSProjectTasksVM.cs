using ErpOnClick.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErpOnClick.ErpMain.Areas.PMS.Models
{
    public class PMSProjectTasksVM
    {
        public PmsProjectTasks Project { get; set; }
        public bool completed { get; set; }
    }
}
