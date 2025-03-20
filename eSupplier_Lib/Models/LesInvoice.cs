using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class LesInvoice
{
    public int InvoiceId { get; set; }

    public string? Invoiceno { get; set; }

    public DateTime? InvoiceDate { get; set; }

    public DateTime? DueDate { get; set; }

    public DateTime? InvoiceRecvDate { get; set; }

    public int? Portalstatus { get; set; }

    public string? Invoicetype { get; set; }

    public string? PaymentRef { get; set; }

    public string? Attachment { get; set; }

    public double? VatAmt { get; set; }

    public double? InvoiceAmount { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? CurrCode { get; set; }

    public string? VesselName { get; set; }

    public int? SupplierAddressid { get; set; }

    public int? BuyerAddressid { get; set; }

    public string? AccountNo { get; set; }

    public string? IbanNo { get; set; }

    public string? SwiftNo { get; set; }

    public string? PoNo { get; set; }

    public DateTime? SubmittedDate { get; set; }

    public string? SubmitedXmlFile { get; set; }

    public double? Othercosts { get; set; }

    public double? Freightamt { get; set; }

    public string? PaymentTerms { get; set; }

    public string? Remarks { get; set; }

    public string? VesselCode { get; set; }

    public string? Linkid { get; set; }

    public int? Sflag { get; set; }

    public string? CustomerNo { get; set; }

    public string? OrderId { get; set; }

    public DateTime? DateOfDelivery { get; set; }

    public string? DeliveryNoteNo { get; set; }

    public string? Conveyance { get; set; }

    public string? ShippingMarks { get; set; }

    public string? DeliveryPortName { get; set; }

    public string? IpAddress { get; set; }

    public string? Username { get; set; }

    public string? SAccountNo { get; set; }

    public string? SIbanNo { get; set; }

    public double? Discount { get; set; }

    public int? Invlinkid { get; set; }

    public string? DeliveryTerms { get; set; }

    public int? ItemsCount { get; set; }

    public string? PoRefNo { get; set; }

    public string? SupplierDispatchNo { get; set; }

    public string? ForwarderDispatchNo { get; set; }

    public string? CourierName { get; set; }

    public string? BuyerVatNo { get; set; }

    public string? SupplierVatNo { get; set; }

    public DateTime? BuyerPoDate { get; set; }

    public DateTime? DispatchDate { get; set; }

    public string? BankName { get; set; }

    public string? AccName { get; set; }

    public string? ChamberOfCommerce { get; set; }

    public string? SortCode { get; set; }

    public string? SSwiftNo { get; set; }

    public string? SKvKNo { get; set; }

    public double? TotalItemsAmt { get; set; }

    public double? PackingHandlingAmt { get; set; }

    public double? FcaAmt { get; set; }

    public double? CourierAmt { get; set; }

    public double? InsuranceAmt { get; set; }

    public double? TransactionAmt { get; set; }

    public string? ImoNo { get; set; }

    public string? BuyerOrgNo { get; set; }

    public string? SupplierOrgNo { get; set; }

    public string? CreditToInvoiceNo { get; set; }

    public string? GrnNumber { get; set; }

    public string? GrnFileRef { get; set; }

    public int? GrnToVoucherFlag { get; set; }

    public double? PoAmount { get; set; }

    public string? PoDepartment { get; set; }

    public double? DiscountPercent { get; set; }
}
