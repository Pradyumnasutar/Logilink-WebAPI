using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistic_Management_Lib.Model
{
    public class Driver_Allocation
    {
        #region Instance Properties
        [Key]
        public int driverallocationid { get; set; }

        public int? contractid { get; set; }

        public int? driver_id { get; set; }

        public string? driver_name { get; set; }

        public int? trip_plan_no { get; set; }

        public string? vehicle_no { get; set; }

        public string? a_role { get; set; }

        public DateTime? created_date { get; set; }

        public DateTime? updated_date { get; set; }

        public int? shipmentid { get; set; }

        public DateTime? planned_from { get; set; }

        public DateTime? planned_to { get; set; }

        public string? chassis_no { get; set; }

        public int? tripdetailid { get; set; }

        public int? tripid { get; set; }

        public int? is_present { get; set; }

        public int? is_main { get; set; }

        public string? epod_driver_remarks { get; set; }

        public string? driver_contact_no { get; set; }

        public string? outsourced_vehicle_no { get; set; }

        public string? outsourced_contact_person { get; set; }

        public string? outsourced_contact_no { get; set; }

        public string? driver_code { get; set; }

        public double? allowance_amt { get; set; }

        #endregion Instance Properties
    }
}
