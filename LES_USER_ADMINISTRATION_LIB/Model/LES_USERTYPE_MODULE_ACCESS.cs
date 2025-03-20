using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LES_USER_ADMINISTRATION_LIB.Model
{
    public class LES_USERTYPE_MODULE_ACCESS
    {
        [Key]

        public int moduleaccessid { get; set; }
        public int? usertypeid { get; set; }
        public int? moduleid { get; set; }
        public int? access_level { get; set; }
        public DateTime? update_date { get; set; }
        public DateTime? created_date { get; set; }
    }

    public class V_APPLICATION_MODULE_ACCESS
    {
        [Key]
		public System.Int64 rownum { get; set; }
		public int ModuleAccessId { get; set; }
        public int? ModuleId { get; set; }
        public int? ApplicationId { get; set; }
        public string? Module_Code { get; set; }
        public string? Module_Desc { get; set; }
        public int? UserTypeId { get; set; }
        public int Access_Level { get; set; }
        public string? UserTypeDescr { get; set; }
        public int Ex_UserId { get; set; }
        public int? CompanyId { get; set; }
        public int? User_Company_Link_Id { get; set; }
        public string? Application_Name { get; set; }

    }


}
