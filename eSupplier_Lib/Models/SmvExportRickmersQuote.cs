using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class SmvExportRickmersQuote
{
    public int Quotationid { get; set; }

    public int? Linkid { get; set; }

    public string? DocType { get; set; }

    public string? Vrno { get; set; }

    public string? Messagereferencenumber { get; set; }

    public string? Messagenumber { get; set; }

    public int? QuoteAddressid { get; set; }

    public int? BuyerAddressid { get; set; }
}
