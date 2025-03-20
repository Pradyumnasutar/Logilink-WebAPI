using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class SmBuyerSupplierRule
{
    public int GroupRuleId { get; set; }

    public int? BuyerId { get; set; }

    public int? SupplierId { get; set; }

    public string? RuleCode { get; set; }

    public string? RuleValue { get; set; }

    public int? GroupId { get; set; }

    public int? RuleId { get; set; }

    public DateTime? UpdateDate { get; set; }
}
