using System.ComponentModel.DataAnnotations;

namespace DeliveryOrdersWebApi.Model
{
    public partial class Vehicle_Trip_Details
    {
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
        public DateTime? to_do_date { get; set; }
        public double? tonnage { get; set; }
        public int? Is_Delete { get; set; }
        //added by Kalpita on 15/07/2023
        public int? fromlocation_id { get; set; }
        public int? tolocation_id { get; set; }


    }

    public partial class V_Vehicle_Trip_Details
    {
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
        public string? vehicle_type { get; set; }
        public string? status_desc { get; set; }
        public DateTime? to_do_date { get; set; }
        public double? tonnage { get; set; }
        public int? DELIVERY_ORDER_ID { get; set; }

        //added by Kalpita on 15/07/2023
        public int? fromlocation_id { get; set; }
        public int? tolocation_id { get; set; }
        public string? toloc_name { get; set; }
        public string? toloc_address1 { get; set; }
        public string? toloc_address2 { get; set; }
        public string? toloc_address3 { get; set; }
        public string? toloc_zipcode { get; set; }
        public string? toloc_city { get; set; }
        public string? toloc_state { get; set; }
        public int? toloc_countryid { get; set; }

        //added on 03/08/2023
        public int? toloc_contact_personId { get; set; }
        public string? toloc_contactno { get; set; }
        public string? toloc_emailId { get; set; }

        public string? fromloc_name { get; set; }
        public string? fromloc_address1 { get; set; }
        public string? fromloc_address2 { get; set; }
        public string? fromloc_address3 { get; set; }
        public string? fromloc_zipcode { get; set; }
        public string? fromloc_city { get; set; }
        public string? fromloc_state { get; set; }
        public int? fromloc_countryid { get; set; }

        //added on 03/08/2023
        public int? fromloc_contact_personId { get; set; }
        public string? fromloc_contactno { get; set; }
        public string? fromloc_emailId { get; set; }

    }
}
