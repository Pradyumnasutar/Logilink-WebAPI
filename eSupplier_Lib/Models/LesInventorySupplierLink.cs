using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class LesInventorySupplierLink
{
    public int Invsupid { get; set; }

    public int? Inventoryid { get; set; }

    public int? Supplierid { get; set; }

    public int? Ispreferred { get; set; }

    public DateTime? UpdateDate { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public int? CreatedBy { get; set; }
}
