using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class SmSendMailAudit
{
    public int MailAuditid { get; set; }

    public int? Quotationid { get; set; }

    public int? ByrSuppLinkid { get; set; }

    public string? MailTo { get; set; }

    public string? MailCc { get; set; }

    public string? MailBcc { get; set; }

    public string? MailReply { get; set; }

    public string? MailSubject { get; set; }

    public string? MailBody { get; set; }

    public string? MailAttachments { get; set; }

    public DateTime? MailDate { get; set; }

    public DateTime? ReceivedDate { get; set; }

    public string? EmlFile { get; set; }

    public string? MailGuid { get; set; }

    public string? Remarks { get; set; }
}
