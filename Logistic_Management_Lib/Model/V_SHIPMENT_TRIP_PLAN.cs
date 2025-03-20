using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistic_Management_Lib.Model
{
    public class V_SHIPMENT_TRIP_PLAN
    {
        #region Instance Properties
        [Key]
        public int shipmentid { get; set; }

        public string? order_no { get; set; }

        public string? status_desc { get; set; }

        public int? shipment_statusid { get; set; }

        public string? jobno { get; set; }

        public string? driver_name { get; set; }

        public string? transport_type_description { get; set; }

        public string? transport_type_code { get; set; }

        public int? transport_type_id { get; set; }

        public string? vehicle_no { get; set; }

        public string? driver_contact_no { get; set; }

        public double? estimate_packaging_unit { get; set; }

        public string? location_from { get; set; }

        public string? location_to { get; set; }

        public string? boarding_officer_name { get; set; }

        public string? transport_company { get; set; }

        public double? ctm { get; set; }

        public DateTime? actual_delivery_start { get; set; }

        public DateTime? actual_delivery_end { get; set; }

        public DateTime? planned_from { get; set; }

        public DateTime? planned_to { get; set; }

        public string? outsourced_vehicle_no { get; set; }

        public string? outsourced_contact_person { get; set; }

        public string? outsourced_contact_no { get; set; }

        public string? driver_code { get; set; }
        public double ? allowance_amt { get; set; }

        #endregion Instance Properties
    }

	public class CURD_SHIPMENT_TRIP_PLAN
	{
		#region Instance Properties
		public int shipmentid { get; set; }

		public string? order_no { get; set; }

		public string? status_desc { get; set; }

		public int? shipment_statusid { get; set; }

		public string? jobno { get; set; }

		public string? driver_name { get; set; }

		public string? transport_type_description { get; set; }

		public string? transport_type_code { get; set; }

		public int? transport_type_id { get; set; }

		public string? vehicle_no { get; set; }

		public string? driver_contact_no { get; set; }

		public double? estimate_packaging_unit { get; set; }

		public string? location_from { get; set; }

		public string? location_to { get; set; }

		public string? boarding_officer_name { get; set; }

		public string? transport_company { get; set; }

		public double? ctm { get; set; }

		public string? actual_delivery_start { get; set; }

		public string? actual_delivery_end { get; set; }

		public string? planned_from { get; set; }

		public string? planned_to { get; set; }

		public string? outsourced_vehicle_no { get; set; }

		public string? outsourced_contact_person { get; set; }

		public string? outsourced_contact_no { get; set; }

		public string? driver_code { get; set; }
		public double? allowance_amt { get; set; }

		#endregion Instance Properties
	}
}
