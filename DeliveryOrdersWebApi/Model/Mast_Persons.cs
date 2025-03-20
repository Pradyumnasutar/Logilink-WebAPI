using System.ComponentModel.DataAnnotations;

namespace DeliveryOrdersWebApi.Model
{
    public class Mast_Persons
    {
        [Key]
        public int Person_ID { get; set; }
        public string? Person_Code { get; set; }
        public string? Full_Name { get; set; }
        public string? Contact_No { get; set; }
        public string? EmailID { get; set; }
        public int? SMS_INDICATOR { get; set; }
        public int? WHATSAPP_INDICATOR { get; set; }

    }
}
