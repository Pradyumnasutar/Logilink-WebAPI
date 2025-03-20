using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistic_Management_Lib.Model
{
    public class Vehicle_Trip_Details
    {
        #region Instance Properties
        [Key]
        public int tripdetailid { get; set; }

        public int? tripid { get; set; }

        public int? trip_plan_no { get; set; }

        public int? statusid { get; set; }

        public string? lot { get; set; }

        public string? location_from { get; set; }

        public string? location_to { get; set; }

        public DateTime? eta_etd { get; set; }

        public string? permit { get; set; }

        public int? vehicletypeid { get; set; }

        public DateTime? b_lcutoff { get; set; }

        public DateTime? created_date { get; set; }

        public DateTime? updated_date { get; set; }

        public string? vessel { get; set; }

        public string? remarks { get; set; }

        public string? bkg_ref { get; set; }

        public int? assigned_driver { get; set; }

        public string? service_type { get; set; }

        public int? commission_calculated { get; set; }

        public double? tonnage { get; set; }

        public DateTime? to_do_date { get; set; }

        public int? is_delete { get; set; }

        public int? fromlocation_id { get; set; }

        public int? tolocation_id { get; set; }

        public int? controller { get; set; }

        public int? vehicle_tonnageid { get; set; }

        public int? exported { get; set; }

        public int? reject_return_link_record_id { get; set; }

        public int? driver_commission_id { get; set; }

        public int? driver_comm_proposal_itemid { get; set; }

        public int? transport_type_id { get; set; }

        public string? boarding_officer_name { get; set; }

        public string? transport_company { get; set; }

        public double? estimate_packaging_unit { get; set; }

        public double? ctm { get; set; }

        public DateTime? actual_delivery_start { get; set; }

        public DateTime? actual_delivery_end { get; set; }

        #endregion Instance Properties
    }
}
