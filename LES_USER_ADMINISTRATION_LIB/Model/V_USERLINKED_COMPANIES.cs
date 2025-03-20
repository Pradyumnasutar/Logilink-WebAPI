using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LES_USER_ADMINISTRATION_LIB.Model
{
    public class V_USERLINKED_COMPANIES
    {
        
        
        public int ex_userid { get; set; }

        public string? ex_usercode { get; set; }

        public int companyid { get; set; }

        [Key, Column(Order = 0)]
        public int user_company_link_id { get; set; }

        public string? company_code { get; set; }

        public string? company_description { get; set; }
        public string? usertypedescr {  get; set; }
   
    }
}
