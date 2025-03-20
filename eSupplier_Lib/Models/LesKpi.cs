using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class LesKpi
{
    public int KpiId { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<LesKpiQuery> LesKpiQueries { get; set; } = new List<LesKpiQuery>();

    public virtual ICollection<LesKpiResult> LesKpiResults { get; set; } = new List<LesKpiResult>();
}
