using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class SmvInvoiceDetailsPortal
{
    public int? Reqninvoiceid { get; set; }

    public string? Invoiceno { get; set; }

    public string? Vesselname { get; set; }

    public double? InvoiceAmount { get; set; }

    public int? FinalInvoice { get; set; }

    public string? InvoiceRemark { get; set; }

    public DateTime? InvoiceDate { get; set; }

    public DateTime? InvoiceRecvDate { get; set; }

    public string? InvoiceComment { get; set; }

    public double? Variance { get; set; }

    public double? InvoiceExchrate { get; set; }

    public DateTime? DueDate { get; set; }

    public DateTime? ApprovedDate { get; set; }

    public DateTime? PaidDate { get; set; }

    public int? VendorId { get; set; }

    public int? BuyerId { get; set; }

    public int? InvoiceType { get; set; }

    public double? TotTax { get; set; }

    public double? PaidAmount { get; set; }

    public string? AcIbanId { get; set; }

    public string? AcBicId { get; set; }

    public string? PaymentRef { get; set; }

    public string? AccountOwner { get; set; }

    public int? InvoiceStatus { get; set; }

    public string? SupplierEmail { get; set; }

    public string? InvFilename { get; set; }

    public string? Attachment1 { get; set; }

    public string? Attachment2 { get; set; }

    public DateTime? UpdateDate { get; set; }

    public decimal? Exported { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? PortalStatus { get; set; }

    public string? Portalstatus1 { get; set; }

    public string Invoicetype1 { get; set; } = null!;

    public int? Currencyid { get; set; }

    public string? CurrCode { get; set; }

    public int Addressid { get; set; }

    public double? NetInvoiceAmountView { get; set; }

    public string? AddrCode { get; set; }

    public string? AddrName { get; set; }

    public int? Buyerid1 { get; set; }

    public string? AddrMtsCode { get; set; }

    public double? SumLineItem { get; set; }

    public string? AccountNum { get; set; }

    public string? IbanNum { get; set; }

    public string? SwiftNum { get; set; }

    public double? VatAmount { get; set; }

    public int? VatPrcnt { get; set; }

    public string? Expr1 { get; set; }

    public DateTime? SubmitDate { get; set; }

    public int BuyersId { get; set; }

    public string? BuyerCode { get; set; }

    public string? BuyerName { get; set; }

    public double? Amount { get; set; }

    public int? SupplierXmlNo { get; set; }

    public int? BuyerXmlNo { get; set; }

    public string? Status { get; set; }

    public string? Vesselcode { get; set; }

    public string? PoNo { get; set; }
}
