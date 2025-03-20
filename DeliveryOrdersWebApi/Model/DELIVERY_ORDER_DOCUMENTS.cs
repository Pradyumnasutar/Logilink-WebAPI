using System.ComponentModel.DataAnnotations;

namespace DeliveryOrdersWebApi.Model
{
    public class DELIVERY_ORDER_DOCUMENTS
    {
        [Key]
        public int Delivery_Document_ID { get; set; }
        public int? Document_No { get; set; }
        public string? Document_Type { get; set; }
        public string? Document_Name { get; set; }
        public string? Document_Title { get; set; }
        public string? Document_Path { get; set; }
        public DateTime? CREATED_DATE { get; set; }
        public DateTime? UPDATED_DATE { get; set; }
        public int? DELIVERY_ORDER_ID { get; set; }
        public int? Is_Delete { get; set; }

    }
    public class sDELIVERY_ORDER_DOCUMENTS
    {
        public int? Delivery_Document_ID { get; set; }
        public int? Document_No { get; set; }
        public string? Document_Type { get; set; }
        public string? Document_Name { get; set; }
        public string? Document_Title { get; set; }
        public string? Document_Path { get; set; }
        public string? Base64Data { get; set; }
        public DateTime? CREATED_DATE { get; set; }
        public DateTime? UPDATED_DATE { get; set; }
        public int? DELIVERY_ORDER_ID { get; set; }
        public int? Is_Delete { get; set; }

    }

    public class vDELIVERY_ORDER_DOCUMENTS
    {
        public int? DELIVERY_ORDER_ID { get; set; }
        public int? DriverID { get; set; }
        public int? Delivery_Document_ID { get; set; }
        public string? Document_Name { get; set; }
        public string? Document_Title { get; set; }
        public string? Base64Data { get; set; }
    } 

}
