using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class SmvQuotationsItem
{
    public int? Quotationid { get; set; }

    public string? Vrno { get; set; }

    public int? Itemno { get; set; }

    public string? Partname { get; set; }

    public string? Drawingno { get; set; }

    public string? Posno { get; set; }

    public string? Refno { get; set; }

    public string? EquipName { get; set; }

    public string? EquipMaker { get; set; }

    public double? QtyReq { get; set; }

    public double? QtyQuoted { get; set; }

    public double? QtyOrd { get; set; }

    public double? QuotedPrice { get; set; }

    public double? QuoteExchrate { get; set; }

    public double? Discount { get; set; }

    public int? Deliverytime { get; set; }

    public string? UnitCode { get; set; }

    public string? ItemRemark { get; set; }

    public string? QuoteitemRemark { get; set; }

    public string? CurrCode { get; set; }

    public string? Docid { get; set; }

    public string? Originatingsystemref { get; set; }

    public string? EquipDrawingno { get; set; }

    public string? EquipType { get; set; }

    public string? EquipSerno { get; set; }

    public string? EquipModel { get; set; }

    public int? Itemstatus { get; set; }

    public int Quotationdetailid { get; set; }

    public double? UnitPrice { get; set; }

    public double? ListPrice { get; set; }

    public double GrossItemPrice { get; set; }

    public double? NetItemPrice { get; set; }

    public double? GrossItemTotal { get; set; }

    public double? NetItemTotal { get; set; }

    public string? PartName1 { get; set; }

    public string? EquipDetails { get; set; }

    public int? ChangedByVendor { get; set; }

    public string? VendorItemno { get; set; }

    public string? VendorRefno { get; set; }

    public string? ItemUnit { get; set; }

    public string? ItemMarkedRemark { get; set; }
}
