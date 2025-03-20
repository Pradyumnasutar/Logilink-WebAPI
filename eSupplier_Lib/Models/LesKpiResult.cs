using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class LesKpiResult
{
    public int Id { get; set; }

    public int KpiId { get; set; }

    public int? Branchid { get; set; }

    public int? DateInt { get; set; }

    public string? Result { get; set; }

    public virtual LesKpi Kpi { get; set; } = null!;
}
