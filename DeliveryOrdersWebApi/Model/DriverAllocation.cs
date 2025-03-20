using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DeliveryOrdersWebApi.Model
{
    public partial class Driver_Allocation
    {
        [Key]
        public int driverallocationid { get; set; }
        public int? contractid { get; set; }
        public int? driver_id { get; set; }
        public string? driver_name { get; set; }
        public int? tripdetailid { get; set; }
        public int? shipmentid { get; set; }
        public int? tripid { get; set; }
        public int? trip_plan_no { get; set; }
        public string? vehicle_no { get; set; }
        public string? chassis_no { get; set; }
        // public string? controller { get; set; }
        public string? a_role { get; set; }
        public DateTime? created_date { get; set; }
        public DateTime? updated_date { get; set; }
        public DateTime? planned_from { get; set; }
        public DateTime? planned_to { get; set; }
        public int? is_Present { get; set; }
        public int? is_Main { get; set; }
        public string? EPOD_Driver_Remarks { get; set; }
    }

    public partial class V_Driver_Allocation
    {
        [Key]
        public int driverallocationid { get; set; }
        public int? contractid { get; set; }
        public int? driver_id { get; set; }
        public string? driver_name { get; set; }
        public int? tripdetailid { get; set; }
        public int? shipmentid { get; set; }
        public int? tripid { get; set; }
        public int? trip_plan_no { get; set; }
        public string? vehicle_no { get; set; }
        public string? chassis_no { get; set; }
        //public string? controller { get; set; }
        public string?   Driver_Role { get; set; }
        public DateTime? created_date { get; set; }
        public DateTime? updated_date { get; set; }
        public DateTime? planned_from { get; set; }
        public DateTime? planned_to { get; set; }
        public string? driver_code { get; set; }
        public int? is_Present { get; set; }
        public int? is_Main { get; set; }
        public string? EPOD_Driver_Remarks { get; set; }
    }

    public partial class V_DRIVER_SCHEDULES
    {
        [Key]
        public int driverallocationid { get; set; }
        public int? contractid { get; set; }
        public int? driver_id { get; set; }
        public string? driver_name { get; set; }
        public int? tripdetailid { get; set; }
        public int? shipmentid { get; set; }
        public int? tripid { get; set; }
        public int? trip_plan_no { get; set; }
        public string? vehicle_no { get; set; }
        public string? chassis_no { get; set; }
        public string? controller { get; set; }
        public string? a_role { get; set; }
        public DateTime? created_date { get; set; }
        public DateTime? updated_date { get; set; }
        public DateTime? planned_from { get; set; }
        public DateTime? planned_to { get; set; }
    }

    //added
    public partial class V_Driver_Trip_Details
    {
        [Key]
        public int? driver_id { get; set; }
        public string? driver_name { get; set; }
        public int? tripdetailid { get; set; }
        public int? tripid { get; set; }
        public int? trip_plan_no { get; set; }

        public int? StatusId { get; set; }

        public int? Assigned_Driver { get; set; }

        public string? Status_desc { get; set; }

        public int? Commission_Calculated { get; set; }

        public string? vehicle_no { get; set; }
        public string? chassis_no { get; set; }
        public string? controller { get; set; }
        public string? a_role { get; set; }

        public DateTime? planned_from { get; set; }
        public DateTime? planned_to { get; set; }

        //added
        public int? driverallocationid { get; set; }
    }
}
