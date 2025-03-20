﻿using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class SmPdfBuyerLink
{
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

    public int? DoNotUse { get; set; }
}
