using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class LesInventory
{
    public int Inventoryid { get; set; }

    public string? Inventoryno { get; set; }

    public string? Invname { get; set; }

    public string? Makerref { get; set; }

    public string? Drawingno { get; set; }

    public string? Posno { get; set; }

    public int? Partunitid { get; set; }

    public int? MakerAddressid { get; set; }

    public double? Minlvl { get; set; }

    public double? Maxlvl { get; set; }

    public double? AvailStock { get; set; }

    public int? Stockable { get; set; }

    public string? Remark { get; set; }

    public int? Parttypeid { get; set; }

    public DateTime? PartPriceDate { get; set; }

    public int? Lastsuppllier { get; set; }

    public double? AvgPrice { get; set; }

    public string? PartsText1 { get; set; }

    public string? PartsText2 { get; set; }

    public string? PartsText3 { get; set; }

    public string? PartsText4 { get; set; }

    public int? PckUnitid { get; set; }

    public double? PackQty { get; set; }

    public double? ReservedStock { get; set; }

    public DateTime? UpdateDate { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public int? CreatedBy { get; set; }
}
