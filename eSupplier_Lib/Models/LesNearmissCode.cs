using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class LesNearmissCode
{
    public int Nmid { get; set; }

    public string? Nmappid { get; set; }

    public string? NmCode { get; set; }

    public string? Nearmissid { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? IsCancelled { get; set; }

    public DateTime? Reportdate { get; set; }

    public int? Exported { get; set; }

    public string? CancelledByUser { get; set; }
}
