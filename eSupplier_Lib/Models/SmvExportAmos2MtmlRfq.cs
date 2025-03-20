using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class SmvExportAmos2MtmlRfq
{
    public int Quotationid { get; set; }

    public string? BuyerFormat { get; set; }

    public byte? RfqExport { get; set; }

    public string? SysDocType { get; set; }
}
