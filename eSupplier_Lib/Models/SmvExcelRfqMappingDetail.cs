using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class SmvExcelRfqMappingDetail
{
    public int Mapid { get; set; }

    public int? Buyerid { get; set; }

    public int? Supplierid { get; set; }

    public int? SectionRowStart { get; set; }

    public int? ItemRowStart { get; set; }

    public int? SkipRowsBefItem { get; set; }

    public int? SkipRowsAftSection { get; set; }

    public string? CellVrno { get; set; }

    public string? CellRfqDt { get; set; }

    public string? CellVessel { get; set; }

    public string? CellPort { get; set; }

    public string? CellLateDt { get; set; }

    public string? CellSuppRef { get; set; }

    public string? CellValidUpto { get; set; }

    public string? CellCurrCode { get; set; }

    public string? CellContact { get; set; }

    public string? CellPayTerms { get; set; }

    public string? CellDelTerms { get; set; }

    public string? CellBuyerRemarks { get; set; }

    public string? CellSuplrRemarks { get; set; }

    public string? ColSection { get; set; }

    public string? ColItemno { get; set; }

    public string? ColItemRefno { get; set; }

    public string? ColItemName { get; set; }

    public string? ColItemQty { get; set; }

    public string? ColItemUnit { get; set; }

    public string? ColItemPrice { get; set; }

    public string? ColItemAltQty { get; set; }

    public string? ColItemAltUnit { get; set; }

    public string? ColItemAltPrice { get; set; }

    public string? ColItemDelDays { get; set; }

    public string? ColItemRemarks { get; set; }

    public string? BuyerLinkCode { get; set; }

    public string? VendorLinkCode { get; set; }

    public string? BuyerFormat { get; set; }

    public string? ImportPath { get; set; }

    public string? ExportPath { get; set; }

    public string? BuyerCode { get; set; }

    public string? CurrCode { get; set; }

    public string? BuyerName { get; set; }

    public short? NotifyBuyer { get; set; }

    public short? NotifySupplr { get; set; }

    public string? BuyerEmailid { get; set; }

    public string? SupplrEmailid { get; set; }

    public string? SupplrName { get; set; }

    public string? ColItemDiscount { get; set; }

    public int? ActiveSheet { get; set; }

    public string? CellMapping { get; set; }

    public string? MappingVal1 { get; set; }

    public string? MappingVal2 { get; set; }

    public string? Cell2Mapping { get; set; }

    public string? Cell2MapValue { get; set; }

    public short? ExitForNoitem { get; set; }

    public string? ColItemCurr { get; set; }

    public int? DynSupRmrkOffset { get; set; }

    public int? OverrideAltQty { get; set; }

    public int? SkipHiddenRows { get; set; }

    public int? ItemDiscPercnt { get; set; }

    public string? ColItemTotal { get; set; }

    public int? ApplyTotalFormula { get; set; }

    public int? ReadItemRemarksUptoNo { get; set; }

    public string? ColItemBuyerRemarks { get; set; }

    public string? AddToVrno { get; set; }

    public string? RemoveFromVrno { get; set; }

    public int? ItemNoAsRowno { get; set; }

    public int? SkipRowsAftItem { get; set; }

    public string? ColItemComments { get; set; }
}
