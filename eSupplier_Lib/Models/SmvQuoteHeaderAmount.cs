using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class SmvQuoteHeaderAmount
{
    public string? Docid { get; set; }

    public int Quotationid { get; set; }

    public string? Vrno { get; set; }

    public double? QuoteAmount { get; set; }

    public double? ItemTotal { get; set; }

    public double? NetItemTotal { get; set; }

    public double? AddDiscValue { get; set; }

    public double? Othercosts { get; set; }

    public double? Freightamt { get; set; }

    public double? QuoteDiscount { get; set; }

    public double? AdditionalDisc { get; set; }

    public double? TaxPercnt { get; set; }

    public double? GrandTotal { get; set; }

    public double? Allowance { get; set; }

    public double? OtherCost2 { get; set; }

    public double? OtherCost3 { get; set; }
}
