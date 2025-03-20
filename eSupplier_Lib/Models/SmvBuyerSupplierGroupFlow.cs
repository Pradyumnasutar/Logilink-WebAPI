using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class SmvBuyerSupplierGroupFlow
{
    public int GroupId { get; set; }

    public string? GroupCode { get; set; }

    public string? BuyerFormat { get; set; }

    public string? SupplierFormat { get; set; }

    public string? BuyerExportFormat { get; set; }

    public string? SupplierExportFormat { get; set; }

    public int? Rfq { get; set; }

    public int? Quote { get; set; }

    public int? Po { get; set; }

    public int? Poc { get; set; }

    public int? RfqEndState { get; set; }

    public int? QuoteEndState { get; set; }

    public int? PoEndState { get; set; }

    public int? PocEndState { get; set; }
}
