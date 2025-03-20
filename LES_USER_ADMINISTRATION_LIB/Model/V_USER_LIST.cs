using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LES_USER_ADMINISTRATION_LIB.Model
{
    public class V_USER_LIST
    {
        [Key]
        public int ex_userid { get; set; }
        public int? addressid { get; set; }
        public string? ex_usercode { get; set; }
        public string? ex_username { get; set; }
        public string? ex_password {  get; set; }
        public string? ex_emailid { get; set; }
        public int? usertype { get; set; }
        public DateTime? created_date { get; set; }
        public DateTime? update_date { get; set; }
        public byte? isactive { get; set; }
        public int? pwd_expired { get; set; }
        public int? access_level { get; set; }
        public byte? exported { get; set; }
        public string? usertypedescr { get; set; }
        public int? dashboard_access { get; set; }
        public string? companyid { get; set; }
        public string? company_code { get; set; }
        public string? company_description { get; set; }
        public int? mail_notification { get; set; }
    }
}
