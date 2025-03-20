using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistic_Management_Lib.Model
{
    public class V_Shipment_Info
    {
        #region Instance Properties
        [Key]
        public int shipmentid { get; set; }

        public string? order_no { get; set; }

        public int? receiverid { get; set; }

        public DateTime? planned_ship_date { get; set; }

        public DateTime? planned_delivery_date { get; set; }

        public string? shipment_notes { get; set; }

        public int? shipment_statusid { get; set; }

        
        public string? jobno { get; set; }

        public int? companyid { get; set; }

        public int? vessel_id { get; set; }

        public DateTime? vessel_eta { get; set; }

        public DateTime? vessel_ata { get; set; }

        public DateTime? delivery_date { get; set; }

        public int? anchorage_id { get; set; }

        public string? agent { get; set; }

        public string? agent_contact_person { get; set; }

        public string? agent_contact_no { get; set; }

        public string? supply_boat { get; set; }

        public string? supply_boat_contact_person { get; set; }

        public string? supply_boat_contact_no { get; set; }

        public string? loading_point { get; set; }

        public DateTime? loading_time { get; set; }

        public string? co_party { get; set; }

        public string? vessel_code { get; set; }

        public string? vessel_name { get; set; }

        public string? imo_no { get; set; }

        public string? anchorage_code { get; set; }

        public string? anchorage_description { get; set; }

        public string? transport_type_code { get; set; }

        public string? transport_type_description { get; set; }

        public int? transport_type_id { get; set; }

        public string? driver_name { get; set; }

        public string? cust_code { get; set; }

        public string? cust_name { get; set; }

        public string? shipment_statusdesc { get; set; }

        public string? Epod_Shipment_Notes { get; set; }

        public int? Is_Delete { get; set; }

        public string? Vehicle_no { get; set; }

        public string? Boarding_Officer_Name { get; set; }
		public int? InitialReceiptExported { get; set; }
		public int? FinalReceiptExported { get; set; }
		[NotMapped] //added by ravi 28-11-2024
		public string? CompanyName {  get; set; }
        [NotMapped] //added by ravi 28-11-2024
        public string? CompanyCode {  get; set; }
		#endregion Instance Properties
	}

	public class CURD_Shipment_Info
	{
		#region Instance Properties
		public int shipmentid { get; set; }

		public string? order_no { get; set; }

		public int? receiverid { get; set; }

		public string? planned_ship_date { get; set; }

		public string? planned_delivery_date { get; set; }

		public string? shipment_notes { get; set; }

		public int? shipment_statusid { get; set; }


		public string? jobno { get; set; }

		public int? companyid { get; set; }

		public int? vessel_id { get; set; }

		public string? vessel_eta { get; set; }

		public string? vessel_ata { get; set; }

		public string? delivery_date { get; set; }

		public int? anchorage_id { get; set; }

		public string? agent { get; set; }

		public string? agent_contact_person { get; set; }

		public string? agent_contact_no { get; set; }

		public string? supply_boat { get; set; }

		public string? supply_boat_contact_person { get; set; }

		public string? supply_boat_contact_no { get; set; }

		public string? loading_point { get; set; }

		public string? loading_time { get; set; }

		public string? co_party { get; set; }

		public string? vessel_code { get; set; }

		public string? vessel_name { get; set; }

		public int? imo_no { get; set; }

		public string? anchorage_code { get; set; }

		public string? anchorage_description { get; set; }

		public string? transport_type_code { get; set; }

		public string? transport_type_description { get; set; }

		public int? transport_type_id { get; set; }

		public string? driver_name { get; set; }

		public string? cust_code { get; set; }

		public string? cust_name { get; set; }

		public string? shipment_statusdesc { get; set; }

		public string? Epod_Shipment_Notes { get; set; }

		public int? Is_Delete { get; set; }

		public string? Vehicle_no { get; set; }

		public string? Boarding_Officer_Name { get; set; }

		#endregion Instance Properties
	}

	public class Print_Shipment_Info
	{
		#region Instance Properties
		
		public int shipmentid { get; set; }

		public string? order_no { get; set; }

		public int? receiverid { get; set; }

		public DateTime? planned_ship_date { get; set; }

		public DateTime? planned_delivery_date { get; set; }

		public string? shipment_notes { get; set; }

		public int? shipment_statusid { get; set; }

		public string? jobno { get; set; }

		public int? companyid { get; set; }

		public int? vessel_id { get; set; }

		public DateTime? vessel_eta { get; set; }

		public DateTime? vessel_ata { get; set; }

		public DateTime? delivery_date { get; set; }

		public int? anchorage_id { get; set; }

		public string? agent { get; set; }

		public string? agent_contact_person { get; set; }

		public string? agent_contact_no { get; set; }

		public string? supply_boat { get; set; }

		public string? supply_boat_contact_person { get; set; }

		public string? supply_boat_contact_no { get; set; }

		public string? loading_point { get; set; }

		public DateTime? loading_time { get; set; }

		public string? co_party { get; set; }

		public string? vessel_code { get; set; }

		public string? vessel_name { get; set; }

		public string? imo_no { get; set; }

		public string? anchorage_code { get; set; }

		public string? anchorage_description { get; set; }

		public string? transport_type_code { get; set; }

		public string? transport_type_description { get; set; }

		public int? transport_type_id { get; set; }

		public string? driver_name { get; set; }

		public string? cust_code { get; set; }

		public string? cust_name { get; set; }

		public string? shipment_statusdesc { get; set; }

		public string? Epod_Shipment_Notes { get; set; }
		public int? Is_Delete { get; set; }
		public string? Vehicle_no { get; set; }
		public string? Boarding_Officer_Name { get; set; }

        public string? Initial_Receipt_Emailid  { get; set; }
		public string? Initial_Receipt_Crew { get; set; }
		public string? Initial_Receipt_Role { get; set; }
		public DateTime? Initial_Receipt_Date { get; set; }
		public string? Initial_Receipt_LoCode { get; set; }

		public string? Final_Receipt_Emailid { get; set; }
		public string? Final_Receipt_Crew { get; set; }
		public string? Final_Receipt_Role { get; set; }
		public DateTime? Final_Receipt_Date { get; set; }
		public string? Final_Receipt_LoCode { get; set; }


		#endregion Instance Properties
	}
}
