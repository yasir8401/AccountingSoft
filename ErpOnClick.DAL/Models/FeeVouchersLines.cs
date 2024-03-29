﻿using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class FeeVouchersLines
    {
        public int LineId { get; set; }
        public int? FeeVoucherId { get; set; }
        public int? CourseId { get; set; }
        public string Description { get; set; }
        public decimal? Qty { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? CoursePrice { get; set; }
        public decimal? DiscountPercent { get; set; }
        public decimal? DiscountAmount { get; set; }
        public int? TaxRateId { get; set; }
        public decimal? TaxRate { get; set; }
        public decimal? TaxAmount { get; set; }
        public decimal? LineAmount { get; set; }
        public int? CompanyId { get; set; }
        public int? BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual Branch Branch { get; set; }
        public virtual Course Course { get; set; }
        public virtual FeeVouchers FeeVoucher { get; set; }
        public virtual TaxRates TaxRateNavigation { get; set; }
    }
}
