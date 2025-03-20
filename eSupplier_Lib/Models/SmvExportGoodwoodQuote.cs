using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class SmvExportGoodwoodQuote
{
    public int Quotationid { get; set; }

    public string? Vrno { get; set; }

    public string? Messagereferencenumber { get; set; }

    public string? XlsFile { get; set; }

    public string? ExportPath { get; set; }

    public string? BuyerMapping { get; set; }

    public int Linkid { get; set; }

    public int? Supplierid { get; set; }

    public int? Buyerid { get; set; }
}
