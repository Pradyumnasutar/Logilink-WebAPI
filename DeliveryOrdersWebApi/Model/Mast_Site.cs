using System.ComponentModel.DataAnnotations;

namespace DeliveryOrdersWebApi.Model
{
    public partial class Mast_Site
    {
        [Key]
        public int SiteId { get; set; }
        public string? Site_Name { get; set; }
        public int? IsActive { get; set; }
        public DateTime? UPDATED_DATE { get; set; }
        public DateTime? CREATED_DATE { get; set; }
        public string? Site_Code { get; set; }
        public int? COMPANYID { get; set; }
        public int? inventory_type { get; set; }
    }
}
