using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class SmvMailLog
{
    public string? UpdateDate { get; set; }

    public string? BuyerAddr { get; set; }

    public string? SupplierAddr { get; set; }

    public string? FromMail { get; set; }

    public string? ToMail { get; set; }

    public string? MailSubject { get; set; }

    public string? Msgfile { get; set; }

    public string? File1 { get; set; }

    public string? File2 { get; set; }

    public int? BuyerId { get; set; }

    public int? SupplierId { get; set; }

    public string? KeyRefno { get; set; }

    public string? Accepted { get; set; }

    public string? Processed { get; set; }

    public string? Comments { get; set; }

    public DateTime? Updatedate1 { get; set; }
}
