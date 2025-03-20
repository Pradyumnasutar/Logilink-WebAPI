using System.ComponentModel.DataAnnotations;

namespace DeliveryOrdersWebApi.Model
{
    public class MAST_COMPANY
    {
        [Key]
        public int COMPANYID { get; set; }
        public string? COMPANY_CODE { get; set; }
        public string? COMPANY_DESCRIPTION { get; set; }
        public string? LOGOPATH { get; set; }
        public DateTime? CREATED_DATE { get; set; }
        public DateTime? UPDATED_DATE { get; set; }

    }
}
