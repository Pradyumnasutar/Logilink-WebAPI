using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class LesLocation
{
    public int Locationid { get; set; }

    public string? Loccode { get; set; }

    public string? LocDescription { get; set; }

    public int? Addressid { get; set; }

    public string? MappedEmail { get; set; }

    public DateTime? UpdateDate { get; set; }
}
