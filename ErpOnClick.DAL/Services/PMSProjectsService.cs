using ErpOnClick.DAL.Interfaces.PMS;
using ErpOnClick.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErpOnClick.DAL.Services
{
    public class PMSProjectsService : GenericRepository<PmsProjects>, IPMSProjectsService
    {
        public PMSProjectsService(ERPonClickContext context) : base(context)
        {

        }
    }
}
