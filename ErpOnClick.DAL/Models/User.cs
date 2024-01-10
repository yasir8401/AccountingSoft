using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class User
    {
        public User()
        {
            InverseUserManager = new HashSet<User>();
            Messages1SendByNavigation = new HashSet<Messages1>();
            Messages1SendToNavigation = new HashSet<Messages1>();
            ProjectTasksAssignedTo = new HashSet<ProjectTasks>();
            ProjectTasksTaskCreatedByNavigation = new HashSet<ProjectTasks>();
            ProjectTeam = new HashSet<ProjectTeam>();
        }

        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string UserEmail { get; set; }
        public string UserContact { get; set; }
        public string UserRole { get; set; }
        public int? CompanyId { get; set; }
        public int? UserManagerId { get; set; }
        public string UserImageUrl { get; set; }

        public virtual Company1 Company { get; set; }
        public virtual User UserManager { get; set; }
        public virtual ICollection<User> InverseUserManager { get; set; }
        public virtual ICollection<Messages1> Messages1SendByNavigation { get; set; }
        public virtual ICollection<Messages1> Messages1SendToNavigation { get; set; }
        public virtual ICollection<ProjectTasks> ProjectTasksAssignedTo { get; set; }
        public virtual ICollection<ProjectTasks> ProjectTasksTaskCreatedByNavigation { get; set; }
        public virtual ICollection<ProjectTeam> ProjectTeam { get; set; }
    }
}
