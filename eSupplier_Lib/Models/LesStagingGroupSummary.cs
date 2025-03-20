using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class LesStagingGroupSummary
{
    public int StagingGroupSummaryid { get; set; }

    public int? StagingGroupid { get; set; }

    public int? DateInt { get; set; }

    public int? KpiId { get; set; }

    public string? TransactionResult { get; set; }
}
