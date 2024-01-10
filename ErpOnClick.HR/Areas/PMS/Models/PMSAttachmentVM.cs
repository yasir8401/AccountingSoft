using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ErpOnClick.ErpMain.Areas.PMS.Models
{
    public class PMSAttachmentVM
    {
        public int TaskId { get; set; }
        [NotMapped]
        public IFormFile AttachmentFile { get; set; }
        [NotMapped]
        public string AttachmentName { get; set; }
    }
}
