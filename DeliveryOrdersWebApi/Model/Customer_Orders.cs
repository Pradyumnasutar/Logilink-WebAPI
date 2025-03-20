using System.ComponentModel.DataAnnotations;

namespace DeliveryOrdersWebApi.Model
{
    public partial class CustomerOrders
    {
        [Key]
        public int OrderId { get; set; }
        public string? Order_No { get; set; }
        public string? BuyerPono { get; set; }
        public string? Order_Code { get; set; }
        public int? ShipViaID { get; set; }
        public int? SupplierId { get; set; }
        public int? BuyerId { get; set; }
        public DateTime? ReceiptDate { get; set; }
        public int? currencyId { get; set; }
        public string? Consignee { get; set; }
        public int? StatusId { get; set; }
        public string? FromServicePoint { get; set; }
        public string? ToServicePoint { get; set; }
        public string? ContainerNumber { get; set; }
        public string? ContainerType { get; set; }
        public string? ContainerSize { get; set; }
        public string? SealNo { get; set; }
        public string? Blno { get; set; }
        public string? VesselNo { get; set; }
        public string? VesselName { get; set; }
        public string? InwardPermitNo { get; set; }
        public string? BondedLotNo { get; set; }
        public int? DELIVERYTERMID { get; set; }
        public string? Potitle { get; set; }
        public string? Poremarks { get; set; }
        public DateTime? OrderDate { get; set; }
        public string? RecipientName { get; set; }
        public int? PayTermsId { get; set; }
        public int? ForwarderId { get; set; }
        public DateTime? Delivery_Date { get; set; }
        public DateTime? Created_Date { get; set; }
        public DateTime? Updated_Date { get; set; }
        public int? CustomerId { get; set; }
        public int? SiteId { get; set; }
        public int? Ordertype_id { get; set; }
        public string? Reference { get; set; }
        public double? Additional_Discount { get; set; }
        public int? Priority { get; set; }
        public int? COORDINATOR_ID { get; set; }
        public int? AgreementID { get; set; }
        public int? LANGUAGEID { get; set; }
        public int? COUNTRYID { get; set; }

        public int? Print_Order_Confirmation { get; set; }
        public int? Print_Delivery_Note { get; set; }
        public int? Print_Pick_List { get; set; }

        public string? TaxFreeCode { get; set; }
        public string? DelTermLocation { get; set; }
        public int? ActivityTypeId { get; set; }
        public string? JobOrderNo { get; set; }

        public double? Item_Total { get; set; }
        public double? Discount_Amount { get; set; }
        public double? Tax_Amount { get; set; }
        public double? Total_Amount { get; set; }

        public int? END_CUSTOMERID { get; set; }

        public int? Is_Delete { get; set; }

        public int? IsAuto { get; set; }//07/08/2023
        public int? updated_by { get; set; }
        //public virtual ICollection<CustomerOrderLine> CustomerOrderLine { get; set; }
        //public virtual ICollection<CustomerOrdersAddress> CustomerOrdersAddress { get; set; }
    }
}
