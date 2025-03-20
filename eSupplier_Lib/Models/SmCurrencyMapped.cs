using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class SmCurrencyMapped
{
    public int Autoid { get; set; }

    public string? SourceCurrCode { get; set; }

    public string? TargetCurrCode { get; set; }

    public int? Mapid { get; set; }
}
