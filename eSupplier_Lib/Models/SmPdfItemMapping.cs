using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class SmPdfItemMapping
{
    public int ItemMapid { get; set; }

    public int? PdfMapid { get; set; }

    public int? MapNumber { get; set; }

    public int? InitialItemSpace { get; set; }

    public int? ItemHeaderLineCount { get; set; }

    public string? ItemHeaderContent { get; set; }

    public string? ItemEndContent { get; set; }

    public string? ItemEquipment { get; set; }

    public string? ItemGroupHeader { get; set; }

    public string? ItemNo { get; set; }

    public string? ItemQty { get; set; }

    public string? ItemUnit { get; set; }

    public string? ItemRefno { get; set; }

    public string? ItemDescr { get; set; }

    public string? ItemRemark { get; set; }

    public string? ItemUnitprice { get; set; }

    public string? ItemLeaddays { get; set; }

    public string? ItemDiscount { get; set; }

    public string? ItemTotal { get; set; }

    public int? ItemMinLines { get; set; }

    public int? LeaddaysInDate { get; set; }

    public string? ItemRemarksAppendText { get; set; }

    public string? ItemRemarksInitials { get; set; }

    public int? HasNoEquipHeader { get; set; }

    public int? MaxEquipRows { get; set; }

    public int? MaxEquipRange { get; set; }

    public int? CheckContentBelowItem { get; set; }

    public string? ExtraColumns { get; set; }

    public string? ExtraColumnsHeader { get; set; }

    public int? ReadItemnoUptoMinlines { get; set; }

    public string? EquipNameRange { get; set; }

    public string? EquipTypeRange { get; set; }

    public string? EquipSernoRange { get; set; }

    public string? EquipMakerRange { get; set; }

    public string? EquipNoteRange { get; set; }

    public int? AppendUom { get; set; }

    public int? MakerrefExtranoLineCount { get; set; }

    public string? MakerrefRange { get; set; }

    public string? ExtranoRange { get; set; }

    public int? ReadPartnoFromLastLine { get; set; }

    public string? ItemCurrency { get; set; }

    public DateTime? UpdateDate { get; set; }

    public int? AppendRefNo { get; set; }

    public int? IsBoldText { get; set; }

    public int? IsQtyUomMerged { get; set; }

    public int? RemoveDigitInUom { get; set; }

    public string? ItemRefNoHeader { get; set; }

    public int? ValidateItemPriceTotal { get; set; }
}
