using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class LeSReportRequest
{
    public long RepRequestId { get; set; }

    public string UserId { get; set; } = null!;

    public string? RequestId { get; set; }

    public string? ReportInputFile { get; set; }

    public string ReportFileName { get; set; } = null!;

    public int? ReportStatus { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? ServerName { get; set; }
}
