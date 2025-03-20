using System.ComponentModel.DataAnnotations;

namespace DeliveryOrdersWebApi.Model
{
    public partial class Shipment
    {
        [Key]
        public int ShipmentId { get; set; }
        public int? ReceiverID { get; set; }
        public int? SenderID { get; set; }
        public int? SiteId { get; set; }
        public DateTime? Planned_Ship_Date { get; set; }
        public DateTime? Planned_Delivery_Date { get; set; }
        public string? Reference_Type { get; set; }
        public int? ShipmentType_Id { get; set; }
        public DateTime? Created_Date { get; set; }
        public DateTime? Updated_Date { get; set; }
        public int? Shipment_StatusId { get; set; }
        public string? Shipment_Notes { get; set; }

        public string? Next_Step_Shipment { get; set; }

        public string? Order_No { get; set; }

        public int? AutoConnection_Blocked { get; set; }

        public ShipmentGeneral General { get; set; }

        public int? Is_Delete { get; set; }

        public int? IsAuto { get; set; } //added on 28/07/2023
    }

    public partial class ShipmentGeneral
    {
        [Key]
        public int Shipment_GeneralId { get; set; }
        public int? ShipmentId { get; set; }
        public int? ForwarderID { get; set; }
        public int? Ship_ViaId { get; set; }

        public int? RouteIdentityId { get; set; }

        public int? Approved_by { get; set; }

        public string? Load_SequenceNo { get; set; }
        public int? Shipment_LocationId { get; set; }

        public int? DeliveryTermId { get; set; }

        public string? DelTerms_Location { get; set; }

        public string? PlaceOfDeparture { get; set; }

        public Double? Pallets_Qty { get; set; }

        public int? Consolidated_ShipmentID { get; set; }
        public string? Consignment_lineNo { get; set; }
        public string? Delivery_NoteNo { get; set; }
        public string? Alt_Delivery_Note_No { get; set; }
        public string? PRO_No { get; set; }
        public string? Airway_Bill_No { get; set; }

        public DateTime? Planned_Ship_Period { get; set; }
        public DateTime? Actual_Ship_Date { get; set; }
        public string? Remit_Cod_To { get; set; }

        public string? Sender_Reference { get; set; }

        public string? Receiver_Reference { get; set; }

        public int? Custom_Val_Curr { get; set; }

        public DateTime? Created_Date { get; set; }
        public DateTime? Updated_Date { get; set; }
        public int? LanguageId { get; set; }

        public string? Manual_Gross_Weight { get; set; }

        public string? Manual_Volume { get; set; }
        public string? Operation_Volume { get; set; }


        public int? Freight_PayerId { get; set; }

        public string? Freight_PayerType { get; set; }

        public string? Freight_Payer_Note { get; set; }

        //added columns

        public string? Net_Weight { get; set; }
        public string? Tare_Weight { get; set; }
        public string? Operative_Gross_Weight { get; set; }
        public string? Adjusted_Net_Weight { get; set; }
        public string? Operative_Adjust_Gross_Weight { get; set; }

        public int? Is_Delete { get; set; }
    }

    public partial class V_SHIPMENT
    {
        [Key]
        public int ShipmentId { get; set; }
        public string? Site_Code { get; set; }

        public string? Site_Name { get; set; }

        public string? Shipment_Status { get; set; }
        public string? Sender_Code { get; set; }

        public string? Sender_Name { get; set; }


        public string? Sender_Address1 { get; set; }

        public string? Recv_Code { get; set; }

        public string? Recv_Cust_Category { get; set; }

        public string? Recv_Name { get; set; }

        public string? Recv_Address1 { get; set; }

        public string? Next_Step_Shipment { get; set; }

        public string? Is_Autoconnect_Block { get; set; }

        public DateTime? Created_Date { get; set; }
        public int? SenderID { get; set; }
        public int? Order_Id { get; set; }
        public int? SiteId { get; set; }
        public int? ReceiverID { get; set; }

        public DateTime? Planned_Ship_Date { get; set; }
        public DateTime? Planned_Delivery_Date { get; set; }

        public string? ShipmentType_Code { get; set; }

        public DateTime? Updated_Date { get; set; }

        public int? Shipment_StatusId { get; set; }
        public string? Shipment_Notes { get; set; }

        public int? Single_Occurence { get; set; }

        public string? Order_No { get; set; }

        public string? customer_type { get; set; }

        //added
        public string? Sender_Address2 { get; set; }
        public string? Sender_Address3 { get; set; }
        public string? Sender_ZipCode { get; set; }
        public string? Sender_State { get; set; }
        public string? Sender_City { get; set; }
        public string? Sender_Country { get; set; }

        public int? Customer_ID { get; set; }

        //09/08/2023
        public string? Contact_No { get; set; }
        public string? EmailID { get; set; }

        public int? IsAuto { get; set; }

        public int? CompanyId { get; set; }
    }
}
