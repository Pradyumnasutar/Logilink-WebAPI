using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class SmCurrencylog
{
    public int Currencylogid { get; set; }

    public int? Currencyid { get; set; }

    public double? ExchRate { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public DateTime? ValidTo { get; set; }

    public DateTime? ValidFrom { get; set; }
}
