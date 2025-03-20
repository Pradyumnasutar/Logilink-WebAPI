using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class SmEsupplierRule
{
    public int Ruleid { get; set; }

    public string? RuleCode { get; set; }

    public string? RuleDesc { get; set; }

    public string? RuleComments { get; set; }

    public string? RuleNumber { get; set; }

    public int? Sequence { get; set; }

    public string? DocType { get; set; }

    public DateTime? UpdateDate { get; set; }
}
