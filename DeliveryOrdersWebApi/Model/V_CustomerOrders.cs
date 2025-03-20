using System.ComponentModel.DataAnnotations;

namespace DeliveryOrdersWebApi.Model
{
    public partial class V_CustomerOrders
    {
        [Key]
        public int OrderId { get; set; }
        public string? Order_No { get; set; }
        public string? BuyerPono { get; set; }
        public string? Order_Code { get; set; }
        public string? ShipViaCode { get; set; }
        public int? SupplierId { get; set; }
        public int? statusid { get; set; }
        public int? BuyerId { get; set; }
        public DateTime? ReceiptDate { get; set; }
        public string? Curr_Code { get; set; }
        public string? Consignee { get; set; }
        public string?  FromServicePoint { get; set; }
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
        public string? DeliveryTerms { get; set; }
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
        public int? SITEID { get; set; }
        public int? Ordertype_id { get; set; }

        public string? order_types { get; set; } // Added by 27-10-23
        public string? Site_Code { get; set; }
        public string? Customer_Name { get; set; }
        public string? Status { get; set; }
        public string? Coordinator_Code { get; set; }
        public string? Coordinator_Desc { get; set; }
        public string? Country_Code { get; set; }
        public string? Country { get; set; }
        public double? Additional_Discount { get; set; }
        public double? Item_Total { get; set; }
        public double? Discount_Amount { get; set; }
        public double? Tax_Amount { get; set; }
        public double? Total_Amount { get; set; }

        public int? IsAuto { get; set; }
        public int? CompanyId { get; set; }
        public int? projectid { get; set; }
        public string? project_code { get; set; }
        public string? project_desc { get; set; }
        public int? project_groupid { get; set; }
        public int? billed_type { get; set; }
        public string? order_types_desc { get; set; }
        //added by Kalpita on 28/10/2023
        public string? external_reference_no { get; set; }
        public string? partner_id { get; set; }

    }
}
