using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LES_USER_ADMINISTRATION_LIB.Model
{
    public class LoginModalViews
    {
        public int? Userid { get; set; }
        public string? UserName { get; set; }
        public string? UserCode { get; set; }
        public string? UserEmail { get; set; }
        public string? DefaultCompanyID { get; set; }
        public List<V_COMPANY_DETAILS_DATA> list_company_details { get; set; }
        public List<V_APPLICATION_MODULE_ACCESS> list_Application_Module_Access { get; set; }
        
    }
    public class CreateUpdateUserModal
    {
        public SM_EXTERNAL_USERS? userdetails { get; set; }
        public string? password { get; set; }
        public string? confirmpassword { get; set; }
        public int? IsNewUser { get; set; } //Update:0 and New:1
    }
    public class UserDetailsModal
    {
        public V_USER_LIST? userdetails { get; set; }
        public List<V_USERLINKED_COMPANIES>? linkedcompanies { get; set; }
    }
    public class CompanyUpdateModal
    {
        public LES_COMPANY_UPDATE? companydetails { get; set; }
        public int accessuserid {  get; set; }
    }

}
