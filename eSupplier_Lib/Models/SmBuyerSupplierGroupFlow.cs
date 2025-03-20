using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class SmBuyerSupplierGroupFlow
{
    public int GroupFlowid { get; set; }

    public int? GroupId { get; set; }

    public int? Rfq { get; set; }

    public int? Quote { get; set; }

    public int? Po { get; set; }

    public int? Poc { get; set; }

    public int? RfqEndState { get; set; }

    public int? QuoteEndState { get; set; }

    public int? PoEndState { get; set; }

    public int? PocEndState { get; set; }

    public int? QuoteExportMarker { get; set; }

    public int? QuoteBuyerExportMarker { get; set; }

    public int? PocExportMarker { get; set; }

    public int? PocBuyerExportMarker { get; set; }

    public DateTime? UpdateDate { get; set; }

    public int? Voucher { get; set; }
}
