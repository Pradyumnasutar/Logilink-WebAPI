using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class SmItemUomMapping
{
    public int ItemUomMapid { get; set; }

    public int? BuyerId { get; set; }

    public int? SupplierId { get; set; }

    public string? BuyerItemUom { get; set; }

    public string? SupplierItemUom { get; set; }

    public DateTime? UpdateDate { get; set; }
}
