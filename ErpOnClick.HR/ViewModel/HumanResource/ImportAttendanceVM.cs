using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErpOnClick.ErpMain.ViewModel.HumanResource
{
    public class ImportAttendanceVM
    {
        public string EmployeeId { get; set; }
        public DateTime DateIn { get; set; }
        public string InTime { get; set; }
        public string In { get; set; }
        public string Out { get; set; }
        public string MachineIP { get; set; }
        public DateTime DateOut { get; set; }
       
    }
}
