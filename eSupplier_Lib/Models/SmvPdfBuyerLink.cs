using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class SmvPdfBuyerLink
{
    public int GroupId { get; set; }

    public string? GroupCode { get; set; }

    public string? BuyerCode { get; set; }

    public string? BuyerName { get; set; }

    public string? SupplierCode { get; set; }

    public string? SupplierName { get; set; }

    public int MapId { get; set; }

    public int? PdfMapid { get; set; }

    public int? BuyerSuppLinkid { get; set; }

    public int? Buyerid { get; set; }

    public int? Supplierid { get; set; }

    public string? DocType { get; set; }

    public string? Mapping1 { get; set; }

    public string? Mapping1Value { get; set; }

    public string? Mapping2 { get; set; }

    public string? Mapping2Value { get; set; }

    public string? Mapping3 { get; set; }

    public string? Mapping3Value { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? FormatMapCode { get; set; }

    public string? SampleFile { get; set; }
}
