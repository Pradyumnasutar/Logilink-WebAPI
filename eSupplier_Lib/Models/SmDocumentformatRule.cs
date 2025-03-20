using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class SmDocumentformatRule
{
    public int DocumentformatRuleid { get; set; }

    public int? Docformatid { get; set; }

    public int? RuleId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? RuleValue { get; set; }
}
