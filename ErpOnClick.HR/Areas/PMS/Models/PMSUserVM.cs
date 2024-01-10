using ErpOnClick.DAL.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ErpOnClick.ErpMain.Areas.PMS.Models
{
    public class PMSUserVM : PmsUser
    {
        [NotMapped]
        public IFormFile ProfilePicFile { get; set; }
    }
}
