using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class LesBuyer
{
    public int? No { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? Format { get; set; }

    public DateTime? UpdateDate { get; set; }
}
