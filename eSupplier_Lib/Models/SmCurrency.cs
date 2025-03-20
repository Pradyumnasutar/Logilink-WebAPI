using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class SmCurrency
{
    public int Currencyid { get; set; }

    public string? CurrCode { get; set; }

    public string? CurrDescr { get; set; }

    public double? ExchRate { get; set; }

    public DateTime? CurrValidityDate { get; set; }

    public string? CurrRemarks { get; set; }

    public int? Exported { get; set; }

    public DateTime? UpdateDate { get; set; }

    public int? UpdateSite { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? Siteid { get; set; }

    public string? CurrSymbol { get; set; }

    public DateTime? ValidFrom { get; set; }

    public int? CreatedBy { get; set; }

    public int? UpdateBy { get; set; }
}
