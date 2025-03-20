using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class SmvImportScannedPdfDoc
{
    public int MapId { get; set; }

    public int? PdfMapid { get; set; }

    public int Linkid { get; set; }

    public int? Buyerid { get; set; }

    public int? Supplierid { get; set; }

    public string? DocType { get; set; }

    public string? ImportPath { get; set; }

    public int? GroupId { get; set; }
}
