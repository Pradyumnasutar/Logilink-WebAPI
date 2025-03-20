using System.ComponentModel.DataAnnotations;

namespace DeliveryOrdersWebApi.Model
{
    public class Mast_STOCK_CODE
    {
        [Key]
        public int STOCK_CODEID { get; set; }

        public string? STOCK_CODE { get; set; }

        public string? STOCK_CODE_DESCRIPTION { get; set; }

        public DateTime? CREATED_DATE { get; set; }

        public DateTime? UPDATED_DATE { get; set; }
    }
}
