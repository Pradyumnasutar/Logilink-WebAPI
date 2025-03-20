using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class SmvXlsMappingNew
{
    public int XlsBuyerMapid { get; set; }

    public string? FormatMapCode { get; set; }

    public string? CompanyName { get; set; }

    public string? DocType { get; set; }

    public int? BuyerSuppLinkid { get; set; }

    public int? Buyerid { get; set; }

    public string? BuyerCode { get; set; }

    public string? BuyerName { get; set; }

    public string? MapCell1 { get; set; }

    public string? MapCell1Val1 { get; set; }

    public string? MapCell1Val2 { get; set; }

    public string? MapCell2 { get; set; }

    public string? MapCell2Val { get; set; }

    public string? MapCellNodisc { get; set; }

    public string? MapCellNodiscVal { get; set; }

    public int ExcelMapid { get; set; }

    public int? GroupId { get; set; }

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

    public string? ColItemDiscount { get; set; }

    public string? ColItemAltQty { get; set; }

    public string? ColItemAltUnit { get; set; }

    public string? ColItemAltPrice { get; set; }

    public string? ColItemDelDays { get; set; }

    public string? ColItemRemarks { get; set; }

    public int? ActiveSheet { get; set; }

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

    public int? SkipRowsAftItem { get; set; }

    public int? ItemNoAsRowno { get; set; }

    public string? ColItemComments { get; set; }

    public string? SampleFile { get; set; }

    public string? CellVslImono { get; set; }

    public string? CellPortName { get; set; }

    public string? CellDocType { get; set; }

    public string? ColItemByrRemark { get; set; }

    public string? ColItemSuppRefno { get; set; }

    public string? CellSuppExpDt { get; set; }

    public string? CellSuppLateDt { get; set; }

    public string? CellSuppLeadDays { get; set; }

    public string? CellByrCompany { get; set; }

    public string? CellByrContact { get; set; }

    public string? CellByrEmail { get; set; }

    public string? CellByrPhone { get; set; }

    public string? CellByrMob { get; set; }

    public string? CellByrFax { get; set; }

    public string? CellSuppCompany { get; set; }

    public string? CellSuppContact { get; set; }

    public string? CellSuppEmail { get; set; }

    public string? CellSuppPhone { get; set; }

    public string? CellSuppMob { get; set; }

    public string? CellSuppFax { get; set; }

    public string? CellFreightAmt { get; set; }

    public string? CellOtherAmt { get; set; }

    public string? XlsMapCode { get; set; }

    public string? CellDiscProvsn { get; set; }

    public string? DiscProvsnValue { get; set; }

    public int? AltItemStartOffset { get; set; }

    public int? AltItemCount { get; set; }

    public string? CellRfqTitle { get; set; }

    public string? CellRfqDept { get; set; }

    public string? CellEquipName { get; set; }

    public string? CellEquipType { get; set; }

    public string? CellEquipMaker { get; set; }

    public string? CellEquipSerno { get; set; }

    public string? CellEquipDtls { get; set; }

    public string? CellMsgno { get; set; }

    public int? DynSupFreightOffset { get; set; }

    public int? DynOthercostOffset { get; set; }

    public int? DynSupCurrOffset { get; set; }

    public string? ExcelNameManager { get; set; }

    public string? DecimalSeparator { get; set; }

    public int? MultilineItemDescr { get; set; }

    public int? DynByrRmrkOffset { get; set; }

    public string? DefaultUom { get; set; }

    public int? DynHdrDiscountOffset { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? RemoveFromVesselName { get; set; }

    public string? CellByrAddr1 { get; set; }

    public string? CellByrAddr2 { get; set; }

    public string? CellSuppAddr1 { get; set; }

    public string? CellSuppAddr2 { get; set; }

    public string? CellBillCompany { get; set; }

    public string? CellBillContact { get; set; }

    public string? CellBillEmail { get; set; }

    public string? CellBillPhone { get; set; }

    public string? CellBillMob { get; set; }

    public string? CellBillFax { get; set; }

    public string? CellBillAddr1 { get; set; }

    public string? CellBillAddr2 { get; set; }

    public string? CellShipCompany { get; set; }

    public string? CellShipContact { get; set; }

    public string? CellShipEmail { get; set; }

    public string? CellShipPhone { get; set; }

    public string? CellShipMob { get; set; }

    public string? CellShipFax { get; set; }

    public string? CellShipAddr1 { get; set; }

    public string? CellShipAddr2 { get; set; }

    public string? CellOrderIdentifier { get; set; }

    public string? CellSuppQuoteDt { get; set; }

    public string? CellEtaDate { get; set; }

    public string? CellEtdDate { get; set; }

    public string? ColItemAltName { get; set; }
}
