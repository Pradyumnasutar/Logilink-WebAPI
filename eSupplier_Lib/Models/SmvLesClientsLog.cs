using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class SmvLesClientsLog
{
    public int Addressid { get; set; }

    public string? AddrType { get; set; }

    public string? LisenceKey { get; set; }

    public string? AddrCode { get; set; }

    public string? AddrName { get; set; }

    public DateTime? LastConnect { get; set; }

    public DateTime? LastConnect1 { get; set; }

    public int Connectid { get; set; }

    public int? Interval { get; set; }

    public DateTime? NextConnect { get; set; }
}
