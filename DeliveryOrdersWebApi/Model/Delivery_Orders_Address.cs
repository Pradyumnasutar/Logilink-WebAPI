using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryOrdersWebApi.Model
{
    public class Delivery_Orders_Address
    {
		[Key]
		public int DeliveryOrderAddressId { get; set; }
		public int? DeliveryOrderId { get; set; }
		public string? ADDRESS1 { get; set; }
		public string? ADDRESS2 { get; set; }
		public string? ADDRESS3 { get; set; }
		public string? ADDRESS4 { get; set; }
		public string? ADDRESS5 { get; set; }
		public string? ZIPCODE { get; set; }
		public string? CITY { get; set; }
		public string? STATE { get; set; }
		public DateTime? CREATED_DATE { get; set; }
		public DateTime? UPDATED_DATE { get; set; }
		public string? ADDR_TYPE { get; set; }
		public int? COUNTRYID { get; set; }
		public string? ADDR_NAME { get; set; }
		public string? ADDR_CODE { get; set; }
		public string? CONTACT_PERSON { get; set; }
		public string? CONTACT_NUMBER { get; set; }
        public int? Is_Delete { get; set; }
    }

    public class V_Delivery_Orders_Address
    {
        [Key]
        public int DeliveryOrderAddressId { get; set; }
        public int? DeliveryOrderId { get; set; }
        public string? ADDRESS1 { get; set; }
        public string? ADDRESS2 { get; set; }
        public string? ADDRESS3 { get; set; }
        public string? ADDRESS4 { get; set; }
        public string? ADDRESS5 { get; set; }
        public string? ZIPCODE { get; set; }
        public string? CITY { get; set; }
        public string? STATE { get; set; }
        public DateTime? CREATED_DATE { get; set; }
        public DateTime? UPDATED_DATE { get; set; }
        public string? ADDR_TYPE { get; set; }
        public int? COUNTRYID { get; set; }
        public string? ADDR_NAME { get; set; }
        public string? ADDR_CODE { get; set; }
        public string? CONTACT_PERSON { get; set; }
        public string? CONTACT_NUMBER { get; set; }
        public int? Is_Delete { get; set; }
        public string? COUNTRY_NAME { get; set; }

    }
}
