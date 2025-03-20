using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class MtmlDocAmount
{
    public Guid Amountid { get; set; }

    public Guid? Mtmldocid { get; set; }

    public string? Qualifier { get; set; }

    public double? AmtValue { get; set; }

    public int Autoid { get; set; }

    public DateTime? UpdateDate { get; set; }
}
