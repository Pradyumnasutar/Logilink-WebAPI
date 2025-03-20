using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class SmPartunit
{
    public int Partunitid { get; set; }

    public string? UnitCode { get; set; }

    public string? UnitDescr { get; set; }

    public byte? Exported { get; set; }

    public int? UpdateSite { get; set; }

    public DateTime? UpdateDate { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? Siteid { get; set; }
}
