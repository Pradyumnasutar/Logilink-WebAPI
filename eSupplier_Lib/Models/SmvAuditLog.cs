using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class SmvAuditLog
{
    public int LogId { get; set; }

    public string? ModuleName { get; set; }

    public string? FileName { get; set; }

    public string? AuditValue { get; set; }

    public string? KeyRef1 { get; set; }

    public string? KeyRef2 { get; set; }

    public string? LogType { get; set; }

    public DateTime? UpdateDate { get; set; }

    public int? BuyerId { get; set; }

    public int? SupplierId { get; set; }

    public string? ServerName { get; set; }

    public string? BuyerCode { get; set; }

    public string? SupplierCode { get; set; }

    public string? DocType { get; set; }

    public string? Filename2 { get; set; }

    public string? Filename3 { get; set; }

    public string? ProcessorName { get; set; }
}
