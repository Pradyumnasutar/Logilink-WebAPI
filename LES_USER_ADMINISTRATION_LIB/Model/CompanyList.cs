using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LES_USER_ADMINISTRATION_LIB.Model
{
    public class CompanyList
    {
        public int companyid { get; set; }
        public string? company_code { get; set; }
        public string? company_description { get; set; }
        public int? addressId { get; set; }
        public string? addr_type { get; set; }
        public string? Country { get; set; }
    }

    public class AddressType
    {
        public int? addressId { get; set; }
        public string? addr_type { get; set; }
        public string? Country {  get; set; }
    }
}
