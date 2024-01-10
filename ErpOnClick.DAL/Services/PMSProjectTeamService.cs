using ErpOnClick.DAL.Interfaces.PMS;
using ErpOnClick.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErpOnClick.DAL.Services
{
    public class PMSProjectTeamService : GenericRepository<PmsProjectTeam>, IPMSProjectTeamService
    {
        public PMSProjectTeamService(ERPonClickContext context) : base(context)
        {

        }
    }
}
