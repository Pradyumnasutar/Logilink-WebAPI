using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class SmvExportMtmlV2Rfq
{
    public int Quotationid { get; set; }

    public string? VendorFormat { get; set; }

    public byte? RfqExport { get; set; }

    public int? GroupId { get; set; }
}
