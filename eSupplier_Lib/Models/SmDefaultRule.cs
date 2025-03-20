using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class SmDefaultRule
{
    public int DefId { get; set; }

    public int? Addressid { get; set; }

    public string? GroupFormat { get; set; }

    public int? RuleId { get; set; }

    public string? RuleValue { get; set; }

    public DateTime? UpdateDate { get; set; }
}
