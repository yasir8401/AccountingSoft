﻿using ErpOnClick.DAL.Interfaces;
using ErpOnClick.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErpOnClick.DAL.Services
{
    public class UserRoleService : GenericRepository<UserRoles>, IUserRolesService
    {
        public UserRoleService(ERPonClickContext context) : base(context)
        {

        }
    }

}
