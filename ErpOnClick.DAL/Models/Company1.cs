using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class Company1
    {
        public Company1()
        {
            Projects = new HashSet<Projects>();
            User = new HashSet<User>();
        }

        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public string ContactPerson { get; set; }
        public string CompanyImageUrl { get; set; }
        public string CompanyAddress { get; set; }

        public virtual ICollection<Projects> Projects { get; set; }
        public virtual ICollection<User> User { get; set; }
    }
}
