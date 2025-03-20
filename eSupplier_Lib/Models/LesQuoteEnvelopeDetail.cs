using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class LesQuoteEnvelopeDetail
{
    public int QuoteEnvelopeId { get; set; }

    public int? Quotationid { get; set; }

    public int? Linkid { get; set; }

    public string? MsgName { get; set; }

    public string? MsgFullpath { get; set; }

    public string? MailFrom { get; set; }

    public string? MailTo { get; set; }

    public string? MailReply { get; set; }

    public string? MailCc { get; set; }

    public string? MailBcc { get; set; }

    public string? DepartmentMail { get; set; }

    public string? Location { get; set; }

    public string? MappedMail { get; set; }

    public string? MessageNumber { get; set; }

    public string? CaseNumber { get; set; }

    public string? CaseId { get; set; }

    public string? CaseThreadId { get; set; }

    public string? MessageId { get; set; }

    public string? Udf1 { get; set; }

    public string? Udf2 { get; set; }

    public string? Udf3 { get; set; }

    public virtual SmQuotationsVendor? Quotation { get; set; }
}
