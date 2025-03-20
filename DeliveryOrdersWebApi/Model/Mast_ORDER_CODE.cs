using System.ComponentModel.DataAnnotations;

namespace DeliveryOrdersWebApi.Model
{
    public class Mast_ORDER_CODE
    {
        [Key]
        public int order_code_id { get; set; }
        public string? order_code { get; set; }
        public string? description { get; set; }

    }
}
