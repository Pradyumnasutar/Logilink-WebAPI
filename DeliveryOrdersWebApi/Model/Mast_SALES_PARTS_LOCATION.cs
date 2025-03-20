using System.ComponentModel.DataAnnotations;

namespace DeliveryOrdersWebApi.Model
{
    public class MAST_SALES_PARTS_LOCATION
    {
        [Key]
        public int PARTLOCATIONID { get; set; }
        public string? PARTLOCATION_CODE { get; set; }
        public string? PARTLOCATION_DESCR { get; set; }
        public DateTime? UPDATED_DATE { get; set; }
        public DateTime? CREATED_DATE { get; set; }
        public int? siteid { get; set; }
        public int location_groupid { get; set; }

    }

   
}
