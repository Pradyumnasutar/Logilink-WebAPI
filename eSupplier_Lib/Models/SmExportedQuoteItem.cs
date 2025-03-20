using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class SmExportedQuoteItem
{
    public int Quotationdetailid { get; set; }

    public int? Quotationid { get; set; }

    public int? Itemstatus { get; set; }

    public int? Itemno { get; set; }

    public string? VendorItemno { get; set; }

    public double? QtyReq { get; set; }

    public double? QtyQuoted { get; set; }

    public double? QtyOrd { get; set; }

    public double? ExportedQty { get; set; }

    public double? QuotedPrice { get; set; }

    public double? ExportedPrice { get; set; }

    public double? QuoteExchrate { get; set; }

    public double? Discount { get; set; }

    public int? Deliverytime { get; set; }

    public string? Partname { get; set; }

    public string? Drawingno { get; set; }

    public string? Posno { get; set; }

    public string? Refno { get; set; }

    public string? UnitCode { get; set; }

    public string? EquipName { get; set; }

    public string? EquipMaker { get; set; }

    public string? EquipType { get; set; }

    public string? EquipSerno { get; set; }

    public string? EquipRemarks { get; set; }

    public string? QuoteitemRemark { get; set; }

    public string? ItemRemark { get; set; }

    public DateTime? UpdateDate { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ChangedByVendor { get; set; }

    public int? Siteid { get; set; }

    public string? Docitemid { get; set; }

    public string? QuoteFile { get; set; }

    public string? VendorRefno { get; set; }

    public string? Originatingsystemref { get; set; }

    public string? ItemMarkedRemark { get; set; }

    public int? SysItemno { get; set; }

    public string? BuyerUnitCode { get; set; }
}
