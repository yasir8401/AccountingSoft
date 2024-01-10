using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErpOnClick.ErpMain.Areas.PMS.Models
{
    public class PMSMessageVM
    {
        public int ManagerId { get; set; }
        public int PTaskId { get; set; }
        public string Message { get; set; }
    }
}
