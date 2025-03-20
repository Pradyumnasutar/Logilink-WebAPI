using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class SmShipmentItem
{
    public int ShipmentItemId { get; set; }

    public int? ShipmentId { get; set; }

    public int? Itemstatus { get; set; }

    public int? Itemno { get; set; }

    public string? VendorItemno { get; set; }

    public double? QtyOrd { get; set; }

    public double? QtyShipment { get; set; }

    public double? QuotedPrice { get; set; }

    public double? QuoteExchrate { get; set; }

    public double? Discount { get; set; }

    public int? Deliverytime { get; set; }

    public string? Partname { get; set; }

    public string? Drawingno { get; set; }

    public string? Posno { get; set; }

    public string? Refno { get; set; }

    public string? UnitCode { get; set; }

    public int? ChangedByVendor { get; set; }

    public string? ItemRemark { get; set; }

    public DateTime? UpdateDate { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? VendorRefno { get; set; }

    public string? Originatingsystemref { get; set; }

    public int? SysItemno { get; set; }

    public string? ItemType { get; set; }

    public string? Udf1 { get; set; }

    public string? Udf2 { get; set; }

    public string? Udf3 { get; set; }

    public string? SupplierOrgref { get; set; }

    public string? VendorItemname { get; set; }

    public string? BuyerOrgref { get; set; }

    public virtual SmShipmentDocument? Shipment { get; set; }
}
