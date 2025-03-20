using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class SmBuyerSupplierItemRef
{
    public int Refid { get; set; }

    public string? Reftype { get; set; }

    public string? BuyerRef { get; set; }

    public string? SupplierRef { get; set; }

    public string? ItemDesc { get; set; }

    public string? Comments { get; set; }

    public int? BuyerId { get; set; }

    public int? SupplierId { get; set; }

    public DateTime? UpdateDate { get; set; }

    public int? BuyerSupplierLinkid { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? BuyerItemDesc { get; set; }
}
