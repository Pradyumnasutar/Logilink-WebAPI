using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class SmPdfMapping
{
    public int PdfMapid { get; set; }

    public int? Groupid { get; set; }

    public string? BuyerName { get; set; }

    public string? BuyerTel { get; set; }

    public string? BuyerFax { get; set; }

    public string? BuyerEmail { get; set; }

    public string? BuyerContact { get; set; }

    public string? BuyerAddress { get; set; }

    public string? SuppName { get; set; }

    public string? SuppTel { get; set; }

    public string? SuppFax { get; set; }

    public string? SuppEmail { get; set; }

    public string? SuppContact { get; set; }

    public string? SuppAddress { get; set; }

    public string? BillName { get; set; }

    public string? BillContact { get; set; }

    public string? BillTel { get; set; }

    public string? BillFax { get; set; }

    public string? BillEmail { get; set; }

    public string? BillAddress { get; set; }

    public string? ConsignName { get; set; }

    public string? ConsignContact { get; set; }

    public string? ConsignTel { get; set; }

    public string? ConsignFax { get; set; }

    public string? ConsignEmail { get; set; }

    public string? ConsignAddress { get; set; }

    public string? BuyerComments { get; set; }

    public string? VrnoHeader { get; set; }

    public string? Vrno { get; set; }

    public string? PoReference { get; set; }

    public string? QuoteReference { get; set; }

    public string? CreatedDate { get; set; }

    public string? LateDate { get; set; }

    public string? VesselHeader { get; set; }

    public string? Vessel { get; set; }

    public string? ImoNo { get; set; }

    public string? ImoNoHeader { get; set; }

    public string? VesselEta { get; set; }

    public string? VesselEtd { get; set; }

    public string? DeliveryPortHeader { get; set; }

    public string? DeliveryPort { get; set; }

    public string? Currency { get; set; }

    public string? AddDiscountHeader { get; set; }

    public int? DiscountInPrcnt { get; set; }

    public string? DecimalSeprator { get; set; }

    public int? IncludeBlanckLines { get; set; }

    public int? HeaderLineCount { get; set; }

    public int? FooterLineCount { get; set; }

    public string? DateFormat1 { get; set; }

    public string? DateFormat2 { get; set; }

    public string? DateFormat { get; set; }

    public string? SkipLines { get; set; }

    public string? ItemsTotalHeader { get; set; }

    public string? FrieghtAmtHeader { get; set; }

    public string? GrantTotalHeader { get; set; }

    public string? AllowanceAmtHeader { get; set; }

    public string? PackingAmtHeader { get; set; }

    public int? SplitFile { get; set; }

    public string? ConstantRows { get; set; }

    public string? SplitStartContent { get; set; }

    public string? EndCommentStartContent { get; set; }

    public string? ExtraFields { get; set; }

    public string? ExtraFieldsHeader { get; set; }

    public int? AddHeaderToComments { get; set; }

    public int? AddFooterToComments { get; set; }

    public string? FieldsFromHeader { get; set; }

    public string? FieldsFromFooter { get; set; }

    public string? SuppComments { get; set; }

    public string? QuoteValidity { get; set; }

    public string? EquipName { get; set; }

    public string? EquipType { get; set; }

    public string? EquipMaker { get; set; }

    public string? EquipSerno { get; set; }

    public string? EquipRemarks { get; set; }

    public string? EquipNameHeader { get; set; }

    public string? EquipTypeHeader { get; set; }

    public string? EquipMakerHeader { get; set; }

    public string? EquipSernoHeader { get; set; }

    public string? EquipRemarksHeader { get; set; }

    public int? ReadContentBelowItem { get; set; }

    public string? Subject { get; set; }

    public int? OverrideItemQty { get; set; }

    public int? ValidateItemDescr { get; set; }

    public string? HeaderCommentsStartText { get; set; }

    public string? HeaderCommentsEndText { get; set; }

    public int? ItemDescrUptoLineCount { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? Department { get; set; }

    public int? AddItemDeldateToHeader { get; set; }

    public int? RemHeaderRemarkSpace { get; set; }

    public string? HeaderFlineContent { get; set; }

    public string? HeaderLlineContent { get; set; }

    public string? FooterFlineContent { get; set; }

    public string? FooterLlineContent { get; set; }

    public string? SkipTextStart { get; set; }

    public string? SkipTextEnd { get; set; }

    public int? AddSkippedTxtToRemakrs { get; set; }

    public string? CurrHeader { get; set; }

    public string? DeptHeader { get; set; }

    public string? QuoteRefHeader { get; set; }

    public string? PocRefHeader { get; set; }

    public string? SubjectHeader { get; set; }

    public string? DelDateHeader { get; set; }

    public string? DocDateHeader { get; set; }

    public string? QuoteExpHeader { get; set; }

    public string? EtaHeader { get; set; }

    public string? EtdHeader { get; set; }

    public string? ByrAddrHeader { get; set; }

    public string? SuppAddrHeader { get; set; }

    public string? ShipAddrHeader { get; set; }

    public string? BillAddrHeader { get; set; }

    public string? ItemFormat { get; set; }

    public string? ItemCountHeader { get; set; }

    public string? SampleFile { get; set; }

    public string? PortCode { get; set; }

    public string? PortCodeHeader { get; set; }

    public string? PaymentTerms { get; set; }

    public string? PaymentTermsHeader { get; set; }

    public string? TermCondition { get; set; }

    public string? TermConditionHeader { get; set; }

    public int? ItemSeparatedByNewline { get; set; }

    public string? DefaultVessel { get; set; }

    public int? CenterAlignedItems { get; set; }

    public string? CommentsColRange { get; set; }

    public string? BuyerContactHeader { get; set; }

    public string? SuppContactHeader { get; set; }

    public string? BillContactHeader { get; set; }

    public string? ShipContactHeader { get; set; }
}
