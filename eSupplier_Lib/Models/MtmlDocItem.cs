using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class MtmlDocItem
{
    public Guid Mtmldocitemid { get; set; }

    public Guid? Mtmldocid { get; set; }

    public string? ItemDescription { get; set; }

    public string? Partnumber { get; set; }

    public string? Partunit { get; set; }

    public int? Lineitemnumber { get; set; }

    public string? Priority { get; set; }

    public string? Quantity { get; set; }

    public string? Partcode { get; set; }

    public string? Comments { get; set; }

    public double? Unitprice { get; set; }

    public double? Listprice { get; set; }

    public double? Discountedamount { get; set; }

    public string? Originatingsystemref { get; set; }

    public int? SysItemno { get; set; }

    public string? SupplierRefno { get; set; }

    public string? SupplierRemarks { get; set; }

    public int? DeliveryTime { get; set; }

    public int Autoid { get; set; }

    public string? VendorItemno { get; set; }

    public string? ItemType { get; set; }

    public string? Udf1 { get; set; }

    public string? Udf2 { get; set; }

    public string? Udf3 { get; set; }

    public string? SupplierOrgref { get; set; }

    public string? VendorItemname { get; set; }

    public string? BuyerOrgref { get; set; }

    public string? ExternalItemNumber { get; set; }

    public string? Impa { get; set; }

    public string? Issa { get; set; }

    public DateTime? UpdateDate { get; set; }
}
