using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class SmvGetSendMailQueueSendgrid
{
    public int QueueId { get; set; }

    public int? Quotationid { get; set; }

    public int? QuoteExported { get; set; }

    public string? DocType { get; set; }

    public string? RefKey { get; set; }

    public string? MailFrom { get; set; }

    public string? MailTo { get; set; }

    public string? MailCc { get; set; }

    public string? MailBcc { get; set; }

    public string? MailSubject { get; set; }

    public string? MailBody { get; set; }

    public string? Attachments { get; set; }

    public DateTime? MailDate { get; set; }

    public byte? NotToSent { get; set; }

    public int? BuyerId { get; set; }

    public int? SupplierId { get; set; }

    public string? ReplyEmail { get; set; }

    public string? SenderName { get; set; }

    public string? ReceiverName { get; set; }

    public string? ActionType { get; set; }

    public int? HtmlNotToSend { get; set; }

    public int? SendHtmlMsg { get; set; }

    public int? UseHtmlFileMsg { get; set; }

    public int? DelayMailMin { get; set; }

    public string? Module { get; set; }

    public string? SuppRef { get; set; }

    public string? ByrCode { get; set; }

    public string? SuppCode { get; set; }

    public string? TimeStamp { get; set; }
}
