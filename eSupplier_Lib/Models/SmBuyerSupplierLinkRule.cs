using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class SmBuyerSupplierLinkRule
{
    public int LinkRuleId { get; set; }

    public int? Linkid { get; set; }

    public int? Ruleid { get; set; }

    public string? RuleValue { get; set; }

    public int? InheritRule { get; set; }

    public DateTime? UpdateDate { get; set; }
}
