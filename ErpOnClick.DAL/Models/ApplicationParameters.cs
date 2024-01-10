using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ErpOnClick.DAL.Models
{
    public partial class ApplicationParameters
    {

        public int ApplicationParameterId { get; set; }
        public int FinancialYearStartMonth { get; set; }
        public int FinancialYearStartDate { get; set; }
        public int FinancialYearEndMonth { get; set; }
        public int FinancialYearEndDate { get; set; }
        public string CompanyNameEn { get; set; }
        public string CompanyNameAr { get; set; }
        public string CompanyLogoUrl { get; set; }
        public string CompanyPhone1 { get; set; }
        public string CompanyPhone2{ get; set; }
        public string CompanyWebsite { get; set; }
        public string CompanyAddressEn { get; set; }
        public string CompanyAddressAr { get; set; }
        public string ReportFooterSignatureManager1 { get; set; }
        public string ReportFooterSignatureManager2 { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public bool IsEnable { get; set; }

    }
    public class ApplicationParameterInherited : ApplicationParameters
    {
        [NotMapped]
        public IFormFile FileToUpload { get; set; }
    }
}
