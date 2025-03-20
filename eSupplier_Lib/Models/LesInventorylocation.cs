using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class LesInventorylocation
{
    public int Inventorylocationid { get; set; }

    public int? Locationid { get; set; }

    public int? Inventoryid { get; set; }

    public double? Stock { get; set; }

    public DateTime? UpdateDate { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public int? CreatedBy { get; set; }
}
