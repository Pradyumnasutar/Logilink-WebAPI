using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class ELitePwd
{
    public int PkId { get; set; }

    public string? LesCode { get; set; }

    public string? LesPwd { get; set; }

    public string? RefKey { get; set; }

    public string? MailFrom { get; set; }

    public string? MailTo { get; set; }

    public string? MailBcc { get; set; }

    public string? MailSubject { get; set; }

    public string? MailBody { get; set; }

    public int? NotToSent { get; set; }

    public string? SupplierName { get; set; }
}
