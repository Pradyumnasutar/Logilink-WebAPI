using System.ComponentModel.DataAnnotations;

namespace DeliveryOrdersWebApi.Model
{
    public class Mast_STOCK_TYPE
    {
        [Key]
        public int STOCK_TYPEID { get; set; }

        public string? STOCK_TYPE { get; set; }

        public string? STOCK_TYPE_DESCRIPTION { get; set; }

        public DateTime? CREATED_DATE { get; set; }

        public DateTime? UPDATED_DATE { get; set; }
        public int? Part_Supply_Control { get; set; }
        public int? Part_Auto_Reservation_Control { get; set; }
        public int? Part_Manual_Reservation_Control { get; set; }
        public int? Part_Order_Issue_Control { get; set; }
        /*public int Part_NonOrder_Issue_Control  { get; set; }
        public int Part_Scrap_Control  { get; set; }
        public int Part_Counting_Control { get; set; }*/
        public int? Part_Movement_Control { get; set; }
        public int? Validity { get; set; }

    }

   


}
