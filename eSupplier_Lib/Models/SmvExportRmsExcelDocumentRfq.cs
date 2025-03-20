using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class SmvExportRmsExcelDocumentRfq
{
    public int Quotationid { get; set; }

    public string? BuyerFormat { get; set; }

    public byte? RfqExport { get; set; }
}
