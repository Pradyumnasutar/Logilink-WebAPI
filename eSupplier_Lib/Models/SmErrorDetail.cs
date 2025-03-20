using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class SmErrorDetail
{
    public int ErrorId { get; set; }

    public string? ErrorNo { get; set; }

    public string? ErrorDesc { get; set; }

    public string? ErrorProblem { get; set; }

    public string? ErrorSolution { get; set; }

    public string? ErrorTemplate { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }
}
