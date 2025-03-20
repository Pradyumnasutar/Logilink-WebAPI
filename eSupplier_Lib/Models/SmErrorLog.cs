using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class SmErrorLog
{
    public int ErrorLogid { get; set; }

    public int? Logid { get; set; }

    public string? ErrorProblem { get; set; }

    public string? ErrorSolution { get; set; }

    public int? ErrorStatus { get; set; }

    public int? PriorityFlag { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? AssignTo { get; set; }
}
