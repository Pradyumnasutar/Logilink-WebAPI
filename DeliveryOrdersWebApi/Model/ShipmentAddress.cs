using System.ComponentModel.DataAnnotations;

namespace DeliveryOrdersWebApi.Model
{
    public partial class ShipmentAddress
    {
        [Key]
        public int Shipment_AddressId { get; set; }
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
        public string? Addr_Name { get; set; }
        public string? Addr_Code { get; set; }
        public string? Dock { get; set; }
        public string? Sub_Dock { get; set; }
        public string? Destination { get; set; }
        public string? ReferenceID { get; set; }
        public int? Single_Occurence { get; set; }
        public string? ToLocation_No { get; set; }
        public int? ShipmentId { get; set; }

        public int? Is_Delete { get; set; }
        public int? contact_personId { get; set; }//added on 03/08/2023
        public string? Contact_No { get; set; }
        public string? EmailID { get; set; }
        public string? Contact_Person_Name { get; set; }
    }

    public partial class V_ShipmentAddress
    {
        [Key]
        public int Shipment_AddressId { get; set; }
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
        public string? Addr_Name { get; set; }
        public string? Addr_Code { get; set; }
        public string? Dock { get; set; }
        public string? Sub_Dock { get; set; }
        public string? Destination { get; set; }
        public string? ReferenceID { get; set; }
        public int? Single_Occurence { get; set; }
        public string? ToLocation_No { get; set; }
        public int? ShipmentId { get; set; }

        public int? Is_Delete { get; set; }
        public int? contact_personId { get; set; }
        public string? Contact_No { get; set; }
        public string? EmailID { get; set; }
        public string? Contact_Person_Name { get; set; }
    }
}
