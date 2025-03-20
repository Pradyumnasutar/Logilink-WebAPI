using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistic_Management_Lib.Model
{

	public class Delivery_Orders_Address
	{
		#region Instance Properties

		[Key]
        public int deliveryorderaddressid { get; set; }

		public int? deliveryorderid { get; set; }

		public string? address1 { get; set; }

		public string? address2 { get; set; }

		public string? address3 { get; set; }

		public string? address4 { get; set; }

		public string? address5 { get; set; }

		public string? zipcode { get; set; }

		public string? city { get; set; }

		public string? state { get; set; }

		public DateTime? created_date { get; set; }

		public DateTime? updated_date { get; set; }

		public String addr_type { get; set; }

		public int? countryid { get; set; }

		public string? addr_name { get; set; }

		public string? addr_code { get; set; }

		public string? contact_number { get; set; }

		public int? is_delete { get; set; }

		public int? contact_personid { get; set; }

		public string? emailid { get; set; }

		public string? contact_person_name { get; set; }

		public string? country_region { get; set; }

		#endregion Instance Properties
	}

	public class V_DELIVERY_ORDERS_ADDRESS_EPOD
    {
        #region Instance Properties
        [Key]
        public int deliveryorderaddressid { get; set; }

        public int? deliveryorderid { get; set; }

        public string? address1 { get; set; }

        public string? address2 { get; set; }

        public string? address3 { get; set; }

        public string? address4 { get; set; }

        public string? address5 { get; set; }

        public string? zipcode { get; set; }

        public string? city { get; set; }

        public string? state { get; set; }

        public DateTime? created_date { get; set; }

        public DateTime? updated_date { get; set; }

        public string? addr_type { get; set; }

        public int? countryid { get; set; }

        public string? addr_name { get; set; }

        public string? addr_code { get; set; }

        public string? contact_number { get; set; }

        public int? is_delete { get; set; }

        public int? contact_personid { get; set; }

        public string? emailid { get; set; }

        public string? contact_person { get; set; }

        public DateTime? planned_ship_date { get; set; }

        public string? country_region { get; set; }

        public string? location_code { get; set; }

        public string? agent_service { get; set; }

        #endregion Instance Properties
    }
}
