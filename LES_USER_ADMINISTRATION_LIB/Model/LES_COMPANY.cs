using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LES_USER_ADMINISTRATION_LIB.Model
{
    public class LES_COMPANY
    {
        [Key]
        public int companyid { get; set; }
        public string? company_code { get; set; }
        public string? company_description { get; set; }
        public DateTime? created_date { get; set; }
        public DateTime? updated_date { get; set; }
        public string? logopath { get; set; }
        public int? addressid { get; set; }
        public string? min_logopath { get; set; }
        public string? print_logo_path { get; set; }
        public int? poweredby_flag { get; set; }    

    }

    public class LES_COMPANY_DETAILS
    {
        [Key]
        public int companyid { get; set; }
        public string? company_code { get; set; }
        public string? company_description { get; set; }
        

    }

}
