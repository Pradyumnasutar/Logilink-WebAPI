using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DeliveryOrdersWebApi.Model
{
    public partial class Driver_Profile_Tab
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
    }

    public partial class V_COMMISSION_RECEIVERS
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
        public string? curr_code { get; set; }
        public DateTime? created_date { get; set; }
        public DateTime? updated_date { get; set; }
        public string? driver_code { get; set; }
        public string? commissionreceiversgroup { get; set; }

    }
}
