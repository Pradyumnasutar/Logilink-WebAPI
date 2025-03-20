using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DeliveryOrdersWebApi.Model
{
    public partial class USER_REVIEW
    {
        [Key]
        public int User_Review_ID { get; set; }
        public int? Review_Value { get; set; }
        public DateTime? CREATED_DATE { get; set; }
        public DateTime? UPDATED_DATE { get; set; }
        public int? DELIVERY_ORDER_ID { get; set; }
        public string? User_Remarks { get; set; }
        public string? Review_By { get; set; }
    }

    public class dUSER_REVIEW
    {
        public int? Review_Value { get; set; }
        public int? DELIVERY_ORDER_ID { get; set; }
        public string? User_Remarks { get; set; }
        public string? Review_By { get; set; }
    }
}
