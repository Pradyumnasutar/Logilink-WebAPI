using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class LesInventoryHistory
{
    public int Invhistoryid { get; set; }

    public int? Inventoryid { get; set; }

    public int? Currencyid { get; set; }

    public int? HistoryType { get; set; }

    public double? Quantity { get; set; }

    public double? UnitPrice { get; set; }

    public int? Supplierid { get; set; }

    public int? Supunitid { get; set; }

    public int? Used { get; set; }

    public DateTime? UpdateDate { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public int? CreatedBy { get; set; }
}
