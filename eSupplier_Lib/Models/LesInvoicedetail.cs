using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class LesInvoicedetail
{
    public int Invoiceid { get; set; }

    public string? Invoiceno { get; set; }

    public DateTime? InvoiceDate { get; set; }

    public DateTime? DueDate { get; set; }

    public DateTime? PaidDate { get; set; }

    public int? Invoicestatusid { get; set; }

    public string? InvoiceStatusText { get; set; }

    public decimal? InvoiceAmount { get; set; }

    public decimal? TotalLineamount { get; set; }

    public decimal? PaidAmount { get; set; }

    public decimal? OtherCharges { get; set; }

    public decimal? VatAmount { get; set; }

    public string? CurrCode { get; set; }

    public string? Attachment { get; set; }

    public string? CustomerReference { get; set; }

    public string? BillingParty { get; set; }

    public int? BillingPartyid { get; set; }

    public string? PaymentStatus { get; set; }

    public int? Customerid { get; set; }

    public string? DeptCode { get; set; }

    public string? CustomerName { get; set; }

    public int? Brokerid { get; set; }

    public int? Forwarderid { get; set; }

    public string? JobOrderno { get; set; }

    public string? OrNo { get; set; }

    public decimal? BalanceAmount { get; set; }

    public string? Vesselno { get; set; }

    public string? VesselName { get; set; }

    public int? Age { get; set; }

    public string? InvoiceRemarks { get; set; }
}
