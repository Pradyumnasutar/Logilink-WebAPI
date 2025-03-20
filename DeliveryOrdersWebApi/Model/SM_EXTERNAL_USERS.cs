using System.ComponentModel.DataAnnotations;

namespace DeliveryOrdersWebApi.Model
{
    public class SM_EXTERNAL_USERS
    {
        [Key]
        public int? EX_USERID { get; set; }
        public int? ADDRESSID { get; set; }
        public int? LINKID { get; set; }
        public string? EX_USERCODE { get; set; }
        public string? EX_USERNAME { get; set; }
        public string? EX_PASSWORD { get; set; }
        public string? EX_EMAILID { get; set; }
        public int? USERTYPE { get; set; }
        public DateTime? CREATED_DATE { get; set; }
        public int? SITEID { get; set; }
        public byte? EXPORTED { get; set; }
        public DateTime? UPDATE_DATE { get; set; }
        public int? UPDATE_SITE { get; set; }
        public byte? ISACTIVE { get; set; }
        public byte? UPDATE_INVOICE { get; set; }
        public int? PWD_EXPIRED { get; set; }
        public int? ACCESS_LEVEL { get; set; }
        public int? INV_USERTYPE { get; set; }
        public int? DASHBOARD_ACCESS { get; set; }
        public int? ePOD_Access { get; set; }
        public DateTime? PWD_EXPIRY_DATE { get; set; }
        public int? COMPANYID { get; set; }
        
    }

    public class Login_Data
    {
        public string UserId { get; set; }
        public string password { get; set; }
    }
}

