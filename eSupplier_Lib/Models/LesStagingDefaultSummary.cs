using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class LesStagingDefaultSummary
{
    public int DefaultSummaryid { get; set; }

    public int? Addressid { get; set; }

    public int? KpiId { get; set; }

    public string? TransactionResult { get; set; }

    public int? DateFromInt { get; set; }

    public int? DateToInt { get; set; }
}
