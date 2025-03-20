using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class LesTransaction
{
    public string? BuyerCode { get; set; }

    public string? BuyerName { get; set; }

    public string? SupplierName { get; set; }

    public string? DocType { get; set; }

    public int? VendorStatus { get; set; }

    public int LinkRecordid { get; set; }

    public int IsDeclined { get; set; }

    public string? FileType { get; set; }

    public int? FileStatus { get; set; }

    public int? FileEndState { get; set; }

    public DateTime? FileImport { get; set; }

    public DateTime? FileExport { get; set; }

    public DateTime? FileUpload { get; set; }

    public int Quotationid { get; set; }

    public string? DocXml { get; set; }

    public string? Docid { get; set; }

    public string? Vrno { get; set; }

    public string? BuyerVrno { get; set; }

    public string? SupplierVrno { get; set; }

    public int? QuoteAddressid { get; set; }

    public int? BuyerAddressid { get; set; }

    public DateTime? RfqSentDate { get; set; }

    public DateTime? QuoteRecvdDate { get; set; }

    public int? Currencyid { get; set; }

    public string? CurrCode { get; set; }

    public double? QuoteAmount { get; set; }

    public double? QuoteExchrate { get; set; }

    public double? ItemTotal { get; set; }

    public double? Othercosts { get; set; }

    public double? Freightamt { get; set; }

    public int? PaymentTerms { get; set; }

    public double? QuoteDiscount { get; set; }

    public double? AdditionalDisc { get; set; }

    public byte? AddDiscType { get; set; }

    public DateTime? QuoteValidity { get; set; }

    public string? QuoteRemarks { get; set; }

    public DateTime? UpdateDate { get; set; }

    public DateTime? Deliverytime { get; set; }

    public string? Payloadid { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? Siteid { get; set; }

    public int? SentBy { get; set; }

    public string? PortCode { get; set; }

    public string? PortName { get; set; }

    public DateTime? QuoteApproveddate { get; set; }

    public int? Deliverydays { get; set; }

    public int? QuoteSubmitBy { get; set; }

    public string? QuoteReference { get; set; }

    public DateTime? ReplyByDate { get; set; }

    public DateTime? QuoteSubmitDate { get; set; }

    public byte? ChangedByVendor { get; set; }

    public DateTime? Latedate { get; set; }

    public DateTime? RfqAckDate { get; set; }

    public DateTime? PoAckDate { get; set; }

    public string? PocReference { get; set; }

    public DateTime? Podate { get; set; }

    public DateTime? PocDate { get; set; }

    public int? PocBy { get; set; }

    public string? BuyerRemarks { get; set; }

    public string? VesselName { get; set; }

    public string? VesselIdno { get; set; }

    public string? VesselOwner { get; set; }

    public string? VesselOwnerCode { get; set; }

    public short? Exported { get; set; }

    public byte? Version { get; set; }

    public byte? RfqExport { get; set; }

    public string? QuoteFileRef { get; set; }

    public int? PrintStatus { get; set; }

    public string? QuoteFileStamp { get; set; }

    public DateTime? DeliveryPromised { get; set; }

    public string? GeneralTerms { get; set; }

    public string? PayTerms { get; set; }

    public double? TaxPercnt { get; set; }

    public double? TaxAmount { get; set; }

    public int? QuoteVersion { get; set; }

    public string? QuoteSubject { get; set; }

    public string? SpMasRemark { get; set; }

    public int? ByrSuppLinkid { get; set; }

    public string? Attachment1 { get; set; }

    public string? Attachment2 { get; set; }

    public double? Allowance { get; set; }

    public string? Udf1 { get; set; }

    public string? Udf2 { get; set; }

    public string? Udf3 { get; set; }

    public string? RevisionNumber { get; set; }

    public string? TransportMode { get; set; }

    public string? OrderHandling { get; set; }

    public string? OrderType { get; set; }

    public string? OriginatingRequestNo { get; set; }

    public string? ShipComplete { get; set; }

    public string? SupplierOrgref { get; set; }

    public string? UpdType { get; set; }

    public string? ContractType { get; set; }

    public string? OrgSystemRef { get; set; }

    public double? OtherCost2 { get; set; }

    public double? OtherCost3 { get; set; }

    public DateTime? VesselEta { get; set; }

    public DateTime? VesselEtd { get; set; }

    public string? Location { get; set; }

    public int? Priority { get; set; }

    public string Status { get; set; } = null!;

    public string HasAttachment { get; set; } = null!;

    public int? CreatedDateInt { get; set; }

    public int? UpdateDateInt { get; set; }
}
