using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class SmvFileAudit
{
    public int Recordid { get; set; }

    public string? Vrno { get; set; }

    public int? Version { get; set; }

    public int? GroupId { get; set; }

    public int? Buyerid { get; set; }

    public int? Supplierid { get; set; }

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

    public int? Rfq { get; set; }

    public int? Quote { get; set; }

    public int? Po { get; set; }

    public int? Poc { get; set; }

    public string? BuyerCode { get; set; }

    public string? SupplierCode { get; set; }

    public int? RfqEndState { get; set; }

    public int? QuoteEndState { get; set; }

    public int? PoEndState { get; set; }

    public int? PocEndState { get; set; }

    public DateTime? UpdateDate { get; set; }
}
