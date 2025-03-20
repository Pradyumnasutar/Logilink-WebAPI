using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryOrdersWebApi.Model
{
    public class V_Available_Drivers
    {
        [Key]
        public int driverprofile_id { get; set; }
        public string? driver_name { get; set; }
        public string? driver_role { get; set; }
        public int? commission_group_id { get; set; }
        public string? vehicle_no { get; set; }
        public string? calculation_period { get; set; }
        public int? d_status { get; set; }
        public int? agreement_id { get; set; }
        public int? currencyid { get; set; }
        public DateTime? created_date { get; set; }
        public DateTime? updated_date { get; set; }
        public string? driver_code { get; set; }
        public DateTime? PLANNED_FROM { get; set; }
        public DateTime? PLANNED_TO { get; set; }

        public int? tripid { get; set; }
        public int? tripdetailid { get; set; }
    }
}
