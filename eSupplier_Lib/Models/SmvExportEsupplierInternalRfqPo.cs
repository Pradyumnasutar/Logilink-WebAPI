using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class SmvExportEsupplierInternalRfqPo
{
    public int Quotationid { get; set; }

    public string? DocType { get; set; }

    public string? Vrno { get; set; }

    public string? BuyerExportFormat { get; set; }

    public string? BuyerFormat { get; set; }

    public int? VendorStatus { get; set; }

    public int? QuoteAddressid { get; set; }

    public int? BuyerAddressid { get; set; }

    public int IsDeclined { get; set; }
}
