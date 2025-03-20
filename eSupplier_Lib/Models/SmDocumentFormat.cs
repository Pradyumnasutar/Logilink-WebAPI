using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class SmDocumentFormat
{
    public int Docformatid { get; set; }

    public string? DocumentFormat { get; set; }

    public string? ImportPath { get; set; }

    public string? ExportPath { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? AddrType { get; set; }
}
