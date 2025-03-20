using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class LesKpiQuery
{
    public int Id { get; set; }

    public int KpiId { get; set; }

    public string? SqlQuery { get; set; }

    public string? AddrType { get; set; }

    public string? QueryType { get; set; }

    public virtual LesKpi Kpi { get; set; } = null!;
}
