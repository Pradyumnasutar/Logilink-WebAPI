using System.ComponentModel.DataAnnotations;

namespace DeliveryOrdersWebApi.Model
{
    public class CUSTOMERS_PART_LINK
    {
        [Key]
        public int CUST_PART_ID { get; set; }
        public int? Customer_ID { get; set; }
        public int? SalesPartId { get; set; }
        public string? CUST_PART_NO { get; set; }
        public string? CUST_PART_DESC { get; set; }
        public string? BARCODE_IDENTIFICATION { get; set; }
        public DateTime? CREATED_DATE { get; set; }
        public DateTime? UPDATED_DATE { get; set; }
        public int? Updated_By { get; set; }
    }
}
