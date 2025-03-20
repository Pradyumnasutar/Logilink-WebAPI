using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class SmvExportedQuoteAmountVendor
{
    public int? Quotationid { get; set; }

    public double? GrossItemTotal { get; set; }

    public double? NetItemTotal { get; set; }
}
