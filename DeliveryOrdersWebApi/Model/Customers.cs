using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DeliveryOrdersWebApi.Model
{
    public partial class Customers
    {
        [Key]
        public int Customer_ID { get; set; }
        public string? Customer_Code { get; set; }
        public string? Customer_Name { get; set; }
        public int? COUNTRYID { get; set; }
        public string? Email_Id { get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public int? Is_Active { get; set; }
        public DateTime? CREATED_DATE { get; set; }
        public DateTime? UPDATED_DATE { get; set; }
        public string? ASSOCIATION_NO { get; set; }
        public int? LANGUAGEID { get; set; }
        public string? CUSTOMER_CATEGORY { get; set; }
        public int? CURRENCYID { get; set; }
        public int? DELIVERYTERMID { get; set; }
        public int? ShipViaID { get; set; }
        public string? Customer_Type { get; set; }
        public string? CONTACT_NO { get; set; }
        public int? SMS_INDICATOR { get; set; }
        public int? WHATS_APP_INDICATOR { get; set; }
    }

    public partial class CustomerAddress
    {
        [Key]
        public int CustomerAddressId { get; set; }
        public int? CustomerId { get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? Address3 { get; set; }
        public string? Address4 { get; set; }
        public string? Address5 { get; set; }
        public string? Zipcode { get; set; }
        public string? City { get; set; }
        public int? CountryId { get; set; }
        public string? State { get; set; }
        public DateTime? Created_Date { get; set; }
        public DateTime? Updated_Date { get; set; }
        public string? Addr_Type { get; set; }
        public string? addr_name { get; set; }
        public string? addr_code { get; set; }
        //public string? contact_person { get; set; }
        //public virtual Customers Customers { get; set; }
        public int? CONTACT_PERSONID { get; set; }//added by Kalpita on 02/08/2023 CONTACT_PERSONID
        public string? Contact_No { get; set; }
        public string? EmailID { get; set; }

    }

    public partial class CustomersFilter
    {
        [Key]
        public int Customer_ID { get; set; }
        public string? Customer_Name { get; set; }
    }
}
