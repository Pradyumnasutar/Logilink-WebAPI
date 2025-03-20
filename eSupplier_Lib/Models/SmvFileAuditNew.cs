using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class SmvFileAuditNew
{
    public int Recordid { get; set; }

    public string? Vrno { get; set; }

    public int? Version { get; set; }

    public int? GroupId { get; set; }

    public int? Buyerid { get; set; }

    public int? Supplierid { get; set; }

    public string? RfqDownload { get; set; }

    public string? RfqImp { get; set; }

    public string? RfqExp { get; set; }

    public string? RfqUpload { get; set; }

    public string? RfqMailSent { get; set; }

    public string? QuoteDownload { get; set; }

    public string? QuoteImp { get; set; }

    public string? QuoteExp { get; set; }

    public string? QuoteUpload { get; set; }

    public string? QuoteMailSent { get; set; }

    public string? PoDownload { get; set; }

    public string? PoImp { get; set; }

    public string? PoExp { get; set; }

    public string? PoUpload { get; set; }

    public string? PoMailSent { get; set; }

    public string? PocDownload { get; set; }

    public string? PocImp { get; set; }

    public string? PocExp { get; set; }

    public string? PocUpload { get; set; }

    public string? PocMailSent { get; set; }

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
