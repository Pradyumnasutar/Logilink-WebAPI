using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class LesSalesorder
{
    public int Salesorderid { get; set; }

    public string? Salesorderno { get; set; }

    public int? Customerid { get; set; }

    public int? Status { get; set; }

    public int? Currencyid { get; set; }

    public string? Buyerref { get; set; }

    public string? Shipname { get; set; }

    public DateTime? RfqDelDate { get; set; }

    public int? DeliveryDays { get; set; }

    public double? Discount { get; set; }

    public string? SupplierRemarks { get; set; }

    public string? PayTerms { get; set; }

    public string? GeneralTerms { get; set; }

    public double? Profitmargin { get; set; }

    public double? Amount { get; set; }

    public double? Freightamt { get; set; }

    public double? Othercosts { get; set; }

    public string? QuoteReference { get; set; }

    public DateTime? QuoteValidity { get; set; }

    public string? QuoteSubject { get; set; }

    public int? Quotationid { get; set; }

    public DateTime? VesselEta { get; set; }

    public DateTime? UpdateDate { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public int? CreatedBy { get; set; }
}
