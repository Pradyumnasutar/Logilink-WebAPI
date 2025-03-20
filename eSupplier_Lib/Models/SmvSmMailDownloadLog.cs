using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class SmvSmMailDownloadLog
{
    public string? ModuleName { get; set; }

    public string? LogType { get; set; }

    public string? FromMail { get; set; }

    public string? ToMail { get; set; }

    public string? AuditValue { get; set; }

    public string? KeyRef1 { get; set; }

    public string? KeyRef2 { get; set; }

    public int LogId { get; set; }

    public string? MailSubject { get; set; }

    public int? SupplierId { get; set; }

    public int? BuyerId { get; set; }

    public DateTime? Updatedate { get; set; }
}
