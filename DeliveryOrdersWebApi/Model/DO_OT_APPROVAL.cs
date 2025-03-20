using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DeliveryOrdersWebApi.Model
{
    public class DO_OT_APPROVAL
    {
        [Key]
        public int? DO_APPROVAL_ID { get; set; }
        public int? DELIVERY_ORDER_ID { get; set; }
        public int? DriverProfile_id { get; set; }
        public double? Actual_Total_Hours { get; set; }
        public double? Customer_OT_Charge_hours { get; set; }
        public double? Driver_OT_Hours { get; set; }
        public int? Approved_By { get; set; }
        public DateTime? Approved_Date { get; set; }
        public int? HOD_Approved_By { get; set; }
        public DateTime? HOD_Approval_Date { get; set; }
        public DateTime? Created_Date { get; set; }
        public DateTime? Updated_Date { get; set; }
        public int? Is_Delete { get; set; }
        public double? Approve_Customer_OT_Charge_hours { get; set; }
        public double? Approve_Driver_OT_Hours { get; set; }

    }
}
