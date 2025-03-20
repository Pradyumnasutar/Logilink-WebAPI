using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace LES_USER_ADMINISTRATION_LIB.Model
{
    public class LES_USER_COMPANY_LINK
    {
        [Key]
        public int user_company_link_id { get;set;}
        public int? ex_userid { get; set; }
        public int? companyid { get; set; }
        public int? usertypeid { get; set; }
        public DateTime? created_date { get; set; }
        public int? created_by { get; set; }

    }

    public class V_COMPANY_DETAILS
    {
        [Key]
        public long rowno { get; set; }
        public int? User_Company_Link_Id { get; set; }
        public int? CompanyId { get; set; }
        public string? Company_Code { get; set; }
        public string? Company_Description { get; set; }
        public string? LogoPath { get; set; }
        public int? AddressId { get; set; }
        public int? Ex_UserId { get; set; }
        public int? UserTypeId { get; set; }
        public string? Usertypedescr { get; set; }
        public string? min_LogoPath { get; set; }
        public string? print_logo_path { get; set; }
        public string ? ex_emailid { get;set; }   //Updated by sayak 11.07.2024
        public int? mail_notification { get; set; } //updated by Raviprasad 26.09.2024
        public int? poweredby_flag { get; set; } //updated by Raviprasad 27.12.2024
    }

    public class V_COMPANY_DETAILS_DATA
    {
        public int User_Company_Link_Id { get; set; }
        public int? CompanyId { get; set; }
        public string? Company_Code { get; set; }
        public string? Company_Description { get; set; }
        public int? CustomerId { get; set; } //updated by Raviprasad 25.11.2024
        public int? mail_notification { get; set; } //updated by Raviprasad 26.09.2024
        public int? AddressId { get; set; }
        public string? AddressType { get; set; } //updated by Praddy 18.11.2024
        public int? Ex_UserId { get; set; }
        public int? UserTypeId { get; set; }
        public string? Usertypedescr { get; set; }
        public string? base64Logo { get; set; }
		public string? base64LogoName { get; set; }
		public string? base64LogoType { get; set; }
		public string? base64minLogo { get; set; }
		public string? base64minLogoName { get; set; }
		public string? base64minLogoType { get; set; }
		public string? base64printLogo { get; set; }
		public string? base64printLogoName { get; set; }
		public string? base64printLogoType { get; set; }
        public string? ex_emailid { get; set; }   //Updated by sayak 11.07.2024
        public int? poweredby_flag { get; set; } //updated by Raviprasad 27.12.2024
    }


    public class COMPANY_INFO_DATA
    {
        public int? CompanyId { get; set; }
        public string? Company_Code { get; set; }
        public string? Company_Description { get; set; }
        public int? AddressId { get; set; }

        public string? base64Logo { get; set; }
		public string? base64LogoName { get; set; }
		public string? base64LogoType { get; set; }

		public string? base64minLogo { get; set; }
		public string? base64minLogoName { get; set; }
		public string? base64minLogoType { get; set; }

		public string? base64printLogo { get; set; }
		public string? base64printLogoName { get; set; }
		public string? base64printLogoType { get; set; }

        public int? poweredby_flag { get; set; } //updated by Raviprasad 27.12.2024

        public string? addr_code { get; set; }
        public string? addr_name { get; set; }
        public string? contact_person { get; set; }
        public string? address1 { get; set; }
        public string? address2 { get; set; }
        public string? address3 { get; set; }
        public string? address4 { get; set; }
        public string? addr_city { get; set; }
        public string? addr_country { get; set; }
        public string? addr_zipcode { get; set; }
        public string? addr_phone1 { get; set; }
        public string? addr_phone2 { get; set; }
        public string? addr_fax { get; set; }
        public string? addr_telex { get; set; }
        public string? addr_email { get; set; }
        public string? addr_mobilephone { get; set; }
        public string? addr_type { get; set; }

    }

}
