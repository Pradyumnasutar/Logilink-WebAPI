using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class SmMailTransactionLog
{
    public int TransId { get; set; }

    public string? ModuleName { get; set; }

    public string? LogType { get; set; }

    public string? FromMail { get; set; }

    public string? ToMail { get; set; }

    public string? KeyRefno { get; set; }

    public int? Linkid { get; set; }

    public int? BuyerId { get; set; }

    public int? SupplierId { get; set; }

    public string? Msgfile { get; set; }

    public string? File1 { get; set; }

    public string? File2 { get; set; }

    public string? MailSubject { get; set; }

    public int? TransStatus { get; set; }

    public DateTime? Updatedate { get; set; }

    public string? Comments { get; set; }
}
