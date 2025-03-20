using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class CaTemp1
{
    public DateTime? Date { get; set; }

    public string? DocType { get; set; }

    public string? Vrno { get; set; }

    public double? QuoteAmount { get; set; }

    public int? QuoteAddressid { get; set; }
}
