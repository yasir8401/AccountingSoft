﻿using ErpOnClick.DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ErpOnClick.ErpMain.Models
{
    public class VoucherLinesInheritance : VoucherLines
    {
        [NotMapped]
        public string IsDeleted { get; set; }
    }
}
