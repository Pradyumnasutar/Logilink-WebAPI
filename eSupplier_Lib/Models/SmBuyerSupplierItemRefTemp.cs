using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class SmBuyerSupplierItemRefTemp
{
    public int? Refid { get; set; }

    public string? Reftype { get; set; }

    public string? BuyerRef { get; set; }

    public string? SupplierRef { get; set; }

    public string? ItemDesc { get; set; }

    public string? Comments { get; set; }

    public int? BuyerId { get; set; }

    public int? SupplierId { get; set; }
}
