using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class PmsCompany
    {
        public PmsCompany()
        {
            PmsProjects = new HashSet<PmsProjects>();
            PmsUser = new HashSet<PmsUser>();
        }

        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public string ContactPerson { get; set; }
        public string CompanyImageUrl { get; set; }
        public string CompanyAddress { get; set; }

        public virtual ICollection<PmsProjects> PmsProjects { get; set; }
        public virtual ICollection<PmsUser> PmsUser { get; set; }
    }
}
