using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class SmFileAudit
{
    public int Recordid { get; set; }

    public string? Vrno { get; set; }

    public int? GroupId { get; set; }

    public int? Buyerid { get; set; }

    public int? Supplierid { get; set; }

    public int? Version { get; set; }

    public DateTime? RfqDownload { get; set; }

    public DateTime? RfqImp { get; set; }

    public DateTime? RfqExp { get; set; }

    public DateTime? RfqUpload { get; set; }

    public DateTime? RfqMailSent { get; set; }

    public DateTime? QuoteDownload { get; set; }

    public DateTime? QuoteImp { get; set; }

    public DateTime? QuoteExp { get; set; }

    public DateTime? QuoteUpload { get; set; }

    public DateTime? QuoteMailSent { get; set; }

    public DateTime? PoDownload { get; set; }

    public DateTime? PoImp { get; set; }

    public DateTime? PoExp { get; set; }

    public DateTime? PoUpload { get; set; }

    public DateTime? PoMailSent { get; set; }

    public DateTime? PocDownload { get; set; }

    public DateTime? PocImp { get; set; }

    public DateTime? PocExp { get; set; }

    public DateTime? PocUpload { get; set; }

    public DateTime? PocMailSent { get; set; }

    public int? RfqId { get; set; }

    public int? QuoteId { get; set; }

    public int? PoId { get; set; }

    public int? PocId { get; set; }

    public DateTime? UpdateDate { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? NotToCheck { get; set; }

    public string? BuyerRef { get; set; }

    public string? SupplierRef { get; set; }

    public string? RfqMail { get; set; }

    public string? OrderMail { get; set; }
}
