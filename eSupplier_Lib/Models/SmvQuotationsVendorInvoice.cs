using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class SmvQuotationsVendorInvoice
{
    public int Quotationid { get; set; }

    public int? QuoteAddressid { get; set; }

    public int? BuyerAddressid { get; set; }

    public string? Docid { get; set; }

    public string? DocXml { get; set; }

    public string? DocType { get; set; }

    public string? Vrno { get; set; }

    public string? BuyerMtsCode { get; set; }

    public string? VesselName { get; set; }

    public string? VesselIdno { get; set; }

    public string? VesselOwner { get; set; }

    public DateTime? Latedate { get; set; }

    public string? PortCode { get; set; }

    public string? PortName { get; set; }

    public int? VendorStatus { get; set; }

    public string? QuoteReference { get; set; }

    public DateTime? RfqSentDate { get; set; }

    public DateTime? QuoteRecvdDate { get; set; }

    public DateTime? QuoteApproveddate { get; set; }

    public DateTime? ReplyByDate { get; set; }

    public double? Othercosts { get; set; }

    public double? Freightamt { get; set; }

    public double? QuoteExchrate { get; set; }

    public double? QuoteDiscount { get; set; }

    public double? AdditionalDisc { get; set; }

    public string? CurrCode { get; set; }

    public string? QuoteRemarks { get; set; }

    public DateTime? Podate { get; set; }

    public string? StatusText { get; set; }

    public int? Deliverydays { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? QuoteSubmitDate { get; set; }

    public DateTime? QuoteValidity { get; set; }

    public string? PocReference { get; set; }

    public string ShipidType { get; set; } = null!;

    public string? BuyerCode { get; set; }

    public string? BuyerName { get; set; }

    public string? BuyerContact { get; set; }

    public string? BuyerRemarks { get; set; }

    public DateTime? Deliverytime { get; set; }

    public string? VendorCode { get; set; }

    public string? VendorName { get; set; }

    public string? VendorAddr1 { get; set; }

    public string? VendorContact { get; set; }

    public string? VendorMtsCode { get; set; }

    public string? BuyerEmail { get; set; }

    public string? VendorEmail { get; set; }

    public string? VendorPhone { get; set; }

    public string? VendorFax { get; set; }

    public string? VendorTelex { get; set; }

    public string? VendorMob { get; set; }

    public string? BuyerMtmlCode { get; set; }

    public string? VendorMtmlCode { get; set; }

    public byte? RfqExport { get; set; }

    public string? ViewStatus { get; set; }

    public string? QuoteFileRef { get; set; }

    public int? PrintStatus { get; set; }

    public byte? Version { get; set; }

    public string? QuoteFileStamp { get; set; }

    public string? BuyerLinkCode { get; set; }

    public string? VendorLinkCode { get; set; }

    public int? IsDeclined { get; set; }

    public string? PayTerms { get; set; }

    public string? QuoteSubject { get; set; }

    public string? BuyerFormat { get; set; }

    public string? VendorFormat { get; set; }

    public short? NotifyBuyer { get; set; }

    public short? NotifySupplr { get; set; }

    public double? TaxPercnt { get; set; }

    public short? Exported { get; set; }

    public string? SpMasRemark { get; set; }

    public string? VendorCountry { get; set; }

    public int Linkid { get; set; }

    public int? ByrSuppLinkid { get; set; }

    public string? SuppSenderCode { get; set; }

    public string? SuppReceiverCode { get; set; }

    public string? ByrSenderCode { get; set; }

    public string? ByrReceiverCode { get; set; }

    public string? BuyerExportFormat { get; set; }

    public string? BuyerMapping { get; set; }

    public string? SupplierMapping { get; set; }

    public string? SupplierVrno { get; set; }

    public string? GeneralTerms { get; set; }

    public string? AddrOutbox { get; set; }

    public string? OrderType { get; set; }

    public double? QuoteAmount { get; set; }

    public string? Department { get; set; }

    public DateTime? UpdateDate { get; set; }
}
