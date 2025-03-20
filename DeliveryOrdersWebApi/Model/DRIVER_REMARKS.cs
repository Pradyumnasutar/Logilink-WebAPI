using System.ComponentModel.DataAnnotations;

namespace DeliveryOrdersWebApi.Model
{
    public class DRIVER_REMARKS
    {
        [Key]
        public int driver_rmk_id { get; set; }
        public string? driver_remark { get; set; }
        public int? driver_id { get; set; }
        public int? delivery_order_id { get; set; }
        public int? statusid { get; set; }
        public DateTime? created_date { get; set; }
        public DateTime? update_date { get; set; }
        public int? created_by { get; set; }
        public int? update_by { get; set; }

    }
}
